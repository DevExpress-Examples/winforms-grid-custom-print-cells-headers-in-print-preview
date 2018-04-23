Imports DevExpress.Utils
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Printing
Imports DevExpress.XtraPrinting
Imports System.ComponentModel

Namespace GridBeforePrint
	<ToolboxItem(True)>
	Public Class MyGridControl
		Inherits GridControl

		Protected Overrides Function CreateDefaultView() As BaseView
			Return CreateView("MyGridView")
		End Function
		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyGridViewInfoRegistrator())
		End Sub
	End Class

	Public Class MyGridViewInfoRegistrator
		Inherits GridInfoRegistrator

		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyGridView(TryCast(grid, GridControl))
		End Function
	End Class

	Public Class MyGridView
		Inherits GridView

		Protected Overrides Function CreatePrintInfoInstance(ByVal args As PrintInfoArgs) As BaseViewPrintInfo
			Return New MyGridViewPrintInfo(args)
		End Function
		Public Delegate Sub SampleEventHandler(ByVal sender As Object, ByVal args As SamplePrintEventArgs)

		Public Delegate Sub HeaderPainterEventHandler(ByVal sender As Object, ByVal args As HeaderPrintEventArgs)

		Public Event HeaderPrintEvent As HeaderPainterEventHandler

		Public Event SamplePrintEvent As SampleEventHandler

		Public Sub RaiseHeaderPrintEvent(ByVal sender As Object, ByVal args As HeaderPrintEventArgs)
			RaiseEvent HeaderPrintEvent(sender, args)
		End Sub

		Public Sub RaiseSamplePrintEvent(ByVal sender As Object, ByVal args As SamplePrintEventArgs)
			RaiseEvent SamplePrintEvent(sender, args)
		End Sub

		Public Sub New()
			Me.New(Nothing)
		End Sub
		Public Sub New(ByVal grid As DevExpress.XtraGrid.GridControl)
			MyBase.New(grid)
		End Sub

		Public Sub New(ByVal grid As MyGridControl)
			MyBase.New(grid)
		End Sub

		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property

		Protected Friend Function GoAndGetNonFormattedCaption(ByVal caption As String) As String
			Return GetNonFormattedCaption(caption)
		End Function

		Friend Function GoAndGetRowCellDisplayTextCore(ByVal rowHandle As Integer, ByVal column As GridColumn, ByVal bev As BaseEditViewInfo, ByVal value As Object, ByVal forGroupRow As Boolean) As String
			Return MyBase.GetRowCellDisplayTextCore(rowHandle, column, bev, value, forGroupRow)
		End Function

		Public Function GetHorzAlignment(ByVal rowHandle As Integer, ByVal column As GridColumn, ByVal currentAlignment As HorzAlignment) As HorzAlignment
			Return MyBase.GetRowCellDefaultAlignment(rowHandle, column, currentAlignment)
		End Function
	End Class

	Public Class MyGridViewInfo
		Inherits GridViewInfo

		Public Sub New(ByVal gridView As MyGridView)
			MyBase.New(gridView)
		End Sub

		Protected Friend Sub GoAndUpdateCellAppearanceCore(ByVal cell As GridCellInfo)
			MyBase.UpdateCellAppearanceCore(cell)
		End Sub
	End Class
End Namespace

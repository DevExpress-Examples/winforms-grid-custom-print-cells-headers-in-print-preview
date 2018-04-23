Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraPrinting

Namespace GridBeforePrint
	Public Class SamplePrintEventArgs
		Private privateIsPreview As Boolean
		Public Property IsPreview() As Boolean
			Get
				Return privateIsPreview
			End Get
			Private Set(ByVal value As Boolean)
				privateIsPreview = value
			End Set
		End Property

		Private privateBrick As IVisualBrick
		Public Property Brick() As IVisualBrick
			Get
				Return privateBrick
			End Get
			Private Set(ByVal value As IVisualBrick)
				privateBrick = value
			End Set
		End Property

		Private privateColumn As GridColumn
		Public Property Column() As GridColumn
			Get
				Return privateColumn
			End Get
			Private Set(ByVal value As GridColumn)
				privateColumn = value
			End Set
		End Property

		Private privateRowHandle As Integer
		Public Property RowHandle() As Integer
			Get
				Return privateRowHandle
			End Get
			Private Set(ByVal value As Integer)
				privateRowHandle = value
			End Set
		End Property

		Public Sub New(ByVal rowHandle As Integer, ByVal column As GridColumn, ByVal brick As IVisualBrick, ByVal isPreview As Boolean)
			Me.RowHandle = rowHandle
			Me.Column = column
			Me.Brick = brick
			Me.IsPreview = isPreview
		End Sub
	End Class
End Namespace

Imports System
Imports System.Collections.Generic
Imports System.Drawing

Namespace GridBeforePrint
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Private customerList As List(Of Customer)

		Private Function GetData() As List(Of Customer)
			Dim list As New List(Of Customer)()
			For i As Integer = 0 To 14
				Dim customer As New Customer() With {.FirstName = String.Format("FirstName {0}", i), .LastName = String.Format("LastName {0}", i), .Id = i}
				list.Add(customer)
			Next i
			Return list
		End Function

		Public Sub New()
			InitializeComponent()
			myGridView1.OptionsView.ShowPreview = True
			myGridView1.OptionsView.AutoCalcPreviewLineCount = False
			myGridView1.PreviewFieldName = "FirstName"
			customerList = GetData()
			myGridControl1.DataSource = customerList
			Me.Controls.Add(myGridControl1)

			AddHandler myGridView1.HeaderPrintEvent, AddressOf MyGridView1_HeaderPrintEvent
			AddHandler myGridView1.SamplePrintEvent, AddressOf MyGridView1_SamplePrintEvent
		End Sub

		Private Sub MyGridView1_SamplePrintEvent(ByVal sender As Object, ByVal args As SamplePrintEventArgs)
			args.Brick.Style.BackColor = Color.Pink
		End Sub

		Private Sub MyGridView1_HeaderPrintEvent(ByVal sender As Object, ByVal args As HeaderPrintEventArgs)
			args.Brick.Style.BackColor = Color.PowderBlue
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			myGridControl1.ShowPrintPreview()
		End Sub
	End Class
End Namespace

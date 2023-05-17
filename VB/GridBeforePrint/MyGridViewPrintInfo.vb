Imports DevExpress.Utils
Imports DevExpress.Utils.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Printing
Imports DevExpress.XtraPrinting
Imports System
Imports System.Drawing

Namespace GridBeforePrint
    Public Class MyGridViewPrintInfo
        Inherits GridViewPrintInfo

        Public Sub New(ByVal args As PrintInfoArgs)
            MyBase.New(args)
        End Sub

        Public Overrides Sub PrintHeader(ByVal graph As BrickGraphics)
            If Not View.OptionsPrint.PrintHeader Then
                Return
            End If
            Dim indent As New Point(Me.Indent, HeaderY)
            Dim r As Rectangle = Rectangle.Empty
            Dim usePrintStyles As Boolean = View.OptionsPrint.UsePrintStyles
            SetDefaultBrickStyle(graph, Bricks("HeaderPanel"))
            For Each col As PrintColumnInfo In Columns
                If Not usePrintStyles Then
                    Dim temp As New AppearanceObject()
                    AppearanceHelper.Combine(temp, New AppearanceObject() {col.Column.AppearanceHeader, View.Appearance.HeaderPanel, AppearancePrint.HeaderPanel})
                    SetDefaultBrickStyle(graph, Bricks.Create(temp, BorderSide.All, temp.BorderColor, 1))
                End If
                r = col.Bounds
                r.Offset(indent)
                Dim caption As String = GetTextCaptionForPrinting(col.Column)
                If Not col.Column.OptionsColumn.ShowCaption Then
                    caption = String.Empty
                End If
                Dim itb As ITextBrick = DrawTextBrick(graph, caption, r)

                TryCast(View, MyGridView).RaiseHeaderPrintEvent(Me, New HeaderPrintEventArgs(itb, col))

                If caption.Contains(Environment.NewLine) Then
                    itb.Style.StringFormat = BrickStringFormat.Create(itb.Style.TextAlignment, True)
                End If
                If AppearancePrint.HeaderPanel.TextOptions.WordWrap = WordWrap.NoWrap AndAlso View.OptionsPrint.UsePrintStyles Then
                    Using g As Graphics = Me.View.GridControl.CreateGraphics()
                        Dim s As SizeF = g.MeasureString(itb.Text, itb.Font, 1000, itb.StringFormat.Value)
                        If s.Width + 5 >= r.Width Then
                            itb.Text = ""
                            itb.TextValue = ""
                        End If
                    End Using
                End If
            Next col
        End Sub

        Protected Function GetTextCaptionForPrinting(ByVal column As GridColumn) As String
            If View Is Nothing Then
                Return column.Caption
            End If
            Dim gview = TryCast(View.OptionsPrint, GridOptionsPrint)
            If gview IsNot Nothing AndAlso (Not gview.AllowMultilineHeaders) Then
                Return column.GetTextCaption()
            End If
            Return (TryCast(View, MyGridView)).GoAndGetNonFormattedCaption(column.GetCaption())
        End Function

        Protected Overrides Sub PrintRowCell(ByVal rowHandle As Integer, ByVal cell As GridCellInfo, ByVal r As Rectangle)
            Me.View.OptionsPrint.PrintPreview = True
            Dim displayText As String = (TryCast(Me.View, MyGridView)).GoAndGetRowCellDisplayTextCore(rowHandle, cell.Column, cell.ViewInfo, cell.CellValue, False)
            Dim myGridViewInfo As New MyGridViewInfo(TryCast(Me.View, MyGridView))
            myGridViewInfo.GoAndUpdateCellAppearanceCore(cell)
            If cell.ViewInfo.AllowHtmlString Then
                displayText = StringPainter.Default.RemoveFormat(displayText, True)
            End If
            Dim horzAlignment As HorzAlignment = (TryCast(Me.View, MyGridView)).GetHorzAlignment(rowHandle, cell.Column, cell.Appearance.HAlignment)
            Dim info As New PrintCellHelperInfo(New Point(If(cell.Column Is Nothing, -1, cell.Column.AbsoluteIndex), rowHandle), LineColor, PrintingSystemBase, cell.CellValue, cell.Appearance, displayText, r, Graph, horzAlignment, Me.View.OptionsPrint.PrintHorzLines, Me.View.OptionsPrint.PrintVertLines, cell.ColumnInfo.Column.DisplayFormat.FormatString, CalcBrickBordersEX(), PaddingInfo.Empty)

            Dim brick As VisualBrick = cell.Editor.GetBrick(info)

            Dim view As MyGridView = TryCast(Me.View, MyGridView)
            view.RaiseSamplePrintEvent(Me, New SamplePrintEventArgs(cell.RowHandle, cell.Column, brick, False))

            If AllowProcessMergedInfo Then
                brick.Rect = r
                UpdateMergedStatus(cell, DirectCast(brick, VisualBrick))
            End If
            Graph.DrawBrick(brick, r)
        End Sub

        Private Function CalcBrickBordersEX() As DevExpress.XtraPrinting.BorderSide
            Dim border As BorderSide = BorderSide.None
            If View.OptionsPrint.PrintHorzLines Then
                border = border Or BorderSide.Top Or BorderSide.Bottom
            End If
            If View.OptionsPrint.PrintVertLines Then
                border = border Or BorderSide.Left Or BorderSide.Right
            End If
            Return border
        End Function

    End Class
End Namespace

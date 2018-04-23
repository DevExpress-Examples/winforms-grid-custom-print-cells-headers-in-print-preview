Imports DevExpress.XtraGrid.Views.Printing
Imports DevExpress.XtraPrinting

Namespace GridBeforePrint
    Public Class HeaderPrintEventArgs
        Private privateBrick As ITextBrick
        Public Property Brick() As ITextBrick
            Get
                Return privateBrick
            End Get
            Private Set(ByVal value As ITextBrick)
                privateBrick = value
            End Set
        End Property

        Private privateColumnInfo As PrintColumnInfo
        Public Property ColumnInfo() As PrintColumnInfo
            Get
                Return privateColumnInfo
            End Get
            Private Set(ByVal value As PrintColumnInfo)
                privateColumnInfo = value
            End Set
        End Property

        Public Sub New(ByVal brick As ITextBrick, ByVal columnInfo As PrintColumnInfo)
            Me.Brick = brick
            Me.ColumnInfo = columnInfo
        End Sub
    End Class
End Namespace

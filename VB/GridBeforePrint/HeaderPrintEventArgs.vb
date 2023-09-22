Imports DevExpress.XtraGrid.Views.Printing
Imports DevExpress.XtraPrinting

Namespace GridBeforePrint

    Public Class HeaderPrintEventArgs

        Private _Brick As ITextBrick, _ColumnInfo As PrintColumnInfo

        Public Property Brick As ITextBrick
            Get
                Return _Brick
            End Get

            Private Set(ByVal value As ITextBrick)
                _Brick = value
            End Set
        End Property

        Public Property ColumnInfo As PrintColumnInfo
            Get
                Return _ColumnInfo
            End Get

            Private Set(ByVal value As PrintColumnInfo)
                _ColumnInfo = value
            End Set
        End Property

        Public Sub New(ByVal brick As ITextBrick, ByVal columnInfo As PrintColumnInfo)
            Me.Brick = brick
            Me.ColumnInfo = columnInfo
        End Sub
    End Class
End Namespace

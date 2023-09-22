Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraPrinting

Namespace GridBeforePrint

    Public Class SamplePrintEventArgs

        Private _IsPreview As Boolean, _Brick As IVisualBrick, _Column As GridColumn, _RowHandle As Integer

        Public Property IsPreview As Boolean
            Get
                Return _IsPreview
            End Get

            Private Set(ByVal value As Boolean)
                _IsPreview = value
            End Set
        End Property

        Public Property Brick As IVisualBrick
            Get
                Return _Brick
            End Get

            Private Set(ByVal value As IVisualBrick)
                _Brick = value
            End Set
        End Property

        Public Property Column As GridColumn
            Get
                Return _Column
            End Get

            Private Set(ByVal value As GridColumn)
                _Column = value
            End Set
        End Property

        Public Property RowHandle As Integer
            Get
                Return _RowHandle
            End Get

            Private Set(ByVal value As Integer)
                _RowHandle = value
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

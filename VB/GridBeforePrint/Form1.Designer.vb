Namespace GridBeforePrint
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            Me.myGridControl1 = New GridBeforePrint.MyGridControl()
            Me.myGridView1 = New GridBeforePrint.MyGridView()
            DirectCast(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' simpleButton2
            ' 
            Me.simpleButton2.Location = New System.Drawing.Point(279, 394)
            Me.simpleButton2.Name = "simpleButton2"
            Me.simpleButton2.Size = New System.Drawing.Size(170, 23)
            Me.simpleButton2.TabIndex = 2
            Me.simpleButton2.Text = "Show Print Preview"
            ' 
            ' myGridControl1
            ' 
            Me.myGridControl1.Location = New System.Drawing.Point(13, 13)
            Me.myGridControl1.MainView = Me.myGridView1
            Me.myGridControl1.Name = "myGridControl1"
            Me.myGridControl1.Size = New System.Drawing.Size(744, 375)
            Me.myGridControl1.TabIndex = 3
            Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myGridView1})
            ' 
            ' myGridView1
            ' 
            Me.myGridView1.GridControl = Me.myGridControl1
            Me.myGridView1.Name = "myGridView1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(769, 429)
            Me.Controls.Add(Me.myGridControl1)
            Me.Controls.Add(Me.simpleButton2)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
        Private myGridControl1 As MyGridControl
        Private myGridView1 As MyGridView
    End Class
End Namespace


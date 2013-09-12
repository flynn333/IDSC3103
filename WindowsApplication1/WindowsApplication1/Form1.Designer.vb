<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn1MoveExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn1MoveExit
        '
        Me.Btn1MoveExit.Location = New System.Drawing.Point(245, 238)
        Me.Btn1MoveExit.Name = "Btn1MoveExit"
        Me.Btn1MoveExit.Size = New System.Drawing.Size(77, 48)
        Me.Btn1MoveExit.TabIndex = 0
        Me.Btn1MoveExit.Text = "Click Me and Win!"
        Me.Btn1MoveExit.UseVisualStyleBackColor = True
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 662)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn1MoveExit)
        Me.MaximumSize = New System.Drawing.Size(700, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 700)
        Me.Name = "FrmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Click me"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn1MoveExit As System.Windows.Forms.Button

End Class

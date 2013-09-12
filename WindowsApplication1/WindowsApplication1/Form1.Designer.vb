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
        Me.MoveExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MoveExit
        '
        Me.MoveExit.Location = New System.Drawing.Point(78, 143)
        Me.MoveExit.Name = "MoveExit"
        Me.MoveExit.Size = New System.Drawing.Size(75, 39)
        Me.MoveExit.TabIndex = 0
        Me.MoveExit.Text = "Moving button"
        Me.MoveExit.UseVisualStyleBackColor = True
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 362)
        Me.Controls.Add(Me.MoveExit)
        Me.Name = "FrmHome"
        Me.Text = "Click me"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MoveExit As System.Windows.Forms.Button

End Class

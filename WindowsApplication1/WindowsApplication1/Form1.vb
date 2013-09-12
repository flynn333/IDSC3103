Public Class FrmHome



    Private Sub MoveExit_Click(sender As System.Object, e As System.EventArgs) Handles MoveExit.Click, MoveExit.MouseEnter

        Dim NumX As New Integer
        Dim NumY As New Integer
        NumX = Rnd() * CInt(Me.Width)
        NumX = Math.Round(NumX)
        NumY = Rnd() * CInt(Me.Height)
        NumY = Math.Round(NumY)
        MoveExit.Location = New Point(NumX, NumY)

    End Sub

End Class

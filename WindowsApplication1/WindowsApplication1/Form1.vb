Public Class FrmHome



    Private Sub MoveExit_Click(sender As System.Object, e As System.EventArgs) Handles Btn1MoveExit.MouseEnter

        Dim NumX As New Integer
        Dim NumY As New Integer
        NumX = Rnd() * CInt(Me.Width - Btn1MoveExit.Width - 14)
        NumX = Math.Round(NumX)
        NumY = Rnd() * CInt(Me.Height - Btn1MoveExit.Height - 36)
        NumY = Math.Round(NumY)
        Btn1MoveExit.Location = New Point(NumX, NumY)

    End Sub

    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

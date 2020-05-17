Public Class Note

    Private newpoint As System.Drawing.Point
    Private xpos1 As Integer
    Private ypos1 As Integer


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub

    Private Sub NoteBar_MouseDown(sender As Object, e As MouseEventArgs) Handles NoteBar.MouseDown
        xpos1 = Control.MousePosition.X - Location.X
        ypos1 = Control.MousePosition.Y - Location.Y
    End Sub

    Private Sub NoteBar_MouseMove(sender As Object, e As MouseEventArgs) Handles NoteBar.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (xpos1)
            newpoint.Y -= (ypos1)
            Location = newpoint
        End If
    End Sub

End Class
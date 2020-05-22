Public Class Settings

    Public Notes As New List(Of Form)
    Private Sub btn_spawner_Click(sender As Object, e As EventArgs) Handles btn_spawner.Click
        Dim x As New Note
        x.init("New Note", True)
        x.Show()
        Notes.Add(x)
    End Sub

    Private Sub btn_close_all_Click(sender As Object, e As EventArgs) Handles btn_close_all.Click
        For Each note In Notes
            note.Close()
        Next
    End Sub
End Class

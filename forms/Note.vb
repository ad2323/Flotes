Public Class Note

    Private _newpoint As System.Drawing.Point
    Private _xpos1 As Integer
    Private _ypos1 As Integer
    Private _Title As String = ""
    Private _OnTop As Boolean = False

    Public Sub init(title, Optional always_top = False)
        _Title = title
        lbl_title.Text = title
        _OnTop = always_top
        Me.TopMost = always_top
    End Sub

    Sub TitleTextBoxLostFocus(sender As TextBox, e As EventArgs)
        _Title = sender.Text
        lbl_title.Text = _Title
        sender.Dispose()
        lbl_title.Show()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub
    Private Sub btn_pin_Click(sender As Object, e As EventArgs) Handles btn_pin.Click
        _OnTop = Not _OnTop
        Me.TopMost = _OnTop
    End Sub

    Private Sub NoteBar_MouseDown(sender As Object, e As MouseEventArgs) Handles NoteBar.MouseDown, TitleBar.MouseDown, lbl_title.MouseDown
        _xpos1 = Control.MousePosition.X - Location.X
        _ypos1 = Control.MousePosition.Y - Location.Y
    End Sub

    Private Sub NoteBar_MouseMove(sender As Object, e As MouseEventArgs) Handles NoteBar.MouseMove, TitleBar.MouseMove, lbl_title.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            _newpoint = Control.MousePosition
            _newpoint.X -= (_xpos1)
            _newpoint.Y -= (_ypos1)
            Location = _newpoint
        End If
    End Sub

    Private Sub lbl_title_Click(sender As Object, e As EventArgs) Handles lbl_title.Click
        lbl_title.Hide()

        Dim tmp_text As New TextBox
        tmp_text.Dock = DockStyle.Fill
        tmp_text.BorderStyle = BorderStyle.None
        tmp_text.Font = lbl_title.Font
        tmp_text.Text = _Title
        tmp_text.AutoSize = False
        tmp_text.Height = lbl_title.Height
        AddHandler tmp_text.Leave, AddressOf TitleTextBoxLostFocus

        TitleBar.Controls.Add(tmp_text)
        tmp_text.Focus()
    End Sub

End Class
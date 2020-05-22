<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Note
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Note))
        Me.Root = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.NoteBar = New System.Windows.Forms.Panel()
        Me.btn_pin = New System.Windows.Forms.Button()
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Root.SuspendLayout()
        Me.NoteBar.SuspendLayout()
        Me.TitleBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Root
        '
        Me.Root.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Root.Controls.Add(Me.RichTextBox1)
        Me.Root.Controls.Add(Me.NoteBar)
        Me.Root.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Name = "Root"
        Me.Root.Padding = New System.Windows.Forms.Padding(2)
        Me.Root.Size = New System.Drawing.Size(432, 389)
        Me.Root.TabIndex = 2
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(2, 26)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(428, 361)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'NoteBar
        '
        Me.NoteBar.Controls.Add(Me.btn_pin)
        Me.NoteBar.Controls.Add(Me.TitleBar)
        Me.NoteBar.Controls.Add(Me.btn_close)
        Me.NoteBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.NoteBar.Location = New System.Drawing.Point(2, 2)
        Me.NoteBar.Name = "NoteBar"
        Me.NoteBar.Size = New System.Drawing.Size(428, 24)
        Me.NoteBar.TabIndex = 2
        '
        'btn_pin
        '
        Me.btn_pin.BackColor = System.Drawing.Color.Salmon
        Me.btn_pin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_pin.FlatAppearance.BorderSize = 0
        Me.btn_pin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pin.Location = New System.Drawing.Point(372, 0)
        Me.btn_pin.Name = "btn_pin"
        Me.btn_pin.Size = New System.Drawing.Size(28, 24)
        Me.btn_pin.TabIndex = 2
        Me.btn_pin.Text = "P"
        Me.btn_pin.UseVisualStyleBackColor = False
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.White
        Me.TitleBar.Controls.Add(Me.lbl_title)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleBar.Location = New System.Drawing.Point(0, 0)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Padding = New System.Windows.Forms.Padding(15, 2, 0, 2)
        Me.TitleBar.Size = New System.Drawing.Size(400, 24)
        Me.TitleBar.TabIndex = 1
        '
        'lbl_title
        '
        Me.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(15, 2)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(385, 20)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "Title"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Red
        Me.btn_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Location = New System.Drawing.Point(400, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(28, 24)
        Me.btn_close.TabIndex = 0
        Me.btn_close.Text = "X"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'Note
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 389)
        Me.Controls.Add(Me.Root)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Note"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Root.ResumeLayout(False)
        Me.NoteBar.ResumeLayout(False)
        Me.TitleBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Root As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents NoteBar As Panel
    Friend WithEvents btn_pin As Button
    Friend WithEvents TitleBar As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_close As Button
End Class

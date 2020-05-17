<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btn_spawner = New System.Windows.Forms.Button()
        Me.btn_close_all = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Flotes"
        Me.NotifyIcon1.Visible = True
        '
        'btn_spawner
        '
        Me.btn_spawner.Location = New System.Drawing.Point(12, 12)
        Me.btn_spawner.Name = "btn_spawner"
        Me.btn_spawner.Size = New System.Drawing.Size(114, 47)
        Me.btn_spawner.TabIndex = 0
        Me.btn_spawner.Text = "Spawn"
        Me.btn_spawner.UseVisualStyleBackColor = True
        '
        'btn_close_all
        '
        Me.btn_close_all.Location = New System.Drawing.Point(132, 12)
        Me.btn_close_all.Name = "btn_close_all"
        Me.btn_close_all.Size = New System.Drawing.Size(114, 47)
        Me.btn_close_all.TabIndex = 1
        Me.btn_close_all.Text = "Close All"
        Me.btn_close_all.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 92)
        Me.Controls.Add(Me.btn_close_all)
        Me.Controls.Add(Me.btn_spawner)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents btn_spawner As Button
    Friend WithEvents btn_close_all As Button
End Class

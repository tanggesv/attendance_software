<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Att = New System.Windows.Forms.Button()
        Me.Btn_Device = New System.Windows.Forms.Button()
        Me.Btn_User = New System.Windows.Forms.Button()
        Me.Btn_Home = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Btn_Att)
        Me.Panel1.Controls.Add(Me.Btn_Device)
        Me.Panel1.Controls.Add(Me.Btn_User)
        Me.Panel1.Controls.Add(Me.Btn_Home)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(158, 479)
        Me.Panel1.TabIndex = 0
        '
        'Btn_Att
        '
        Me.Btn_Att.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Att.Location = New System.Drawing.Point(0, 91)
        Me.Btn_Att.Name = "Btn_Att"
        Me.Btn_Att.Size = New System.Drawing.Size(159, 31)
        Me.Btn_Att.TabIndex = 7
        Me.Btn_Att.Text = "&Attendance"
        Me.Btn_Att.UseVisualStyleBackColor = True
        '
        'Btn_Device
        '
        Me.Btn_Device.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Device.Location = New System.Drawing.Point(-1, 61)
        Me.Btn_Device.Name = "Btn_Device"
        Me.Btn_Device.Size = New System.Drawing.Size(159, 31)
        Me.Btn_Device.TabIndex = 6
        Me.Btn_Device.Text = "&Device"
        Me.Btn_Device.UseVisualStyleBackColor = True
        '
        'Btn_User
        '
        Me.Btn_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_User.Location = New System.Drawing.Point(-1, 31)
        Me.Btn_User.Name = "Btn_User"
        Me.Btn_User.Size = New System.Drawing.Size(159, 31)
        Me.Btn_User.TabIndex = 5
        Me.Btn_User.Text = "&User"
        Me.Btn_User.UseVisualStyleBackColor = True
        '
        'Btn_Home
        '
        Me.Btn_Home.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Home.Location = New System.Drawing.Point(-1, 1)
        Me.Btn_Home.Name = "Btn_Home"
        Me.Btn_Home.Size = New System.Drawing.Size(159, 31)
        Me.Btn_Home.TabIndex = 4
        Me.Btn_Home.Text = "&Home"
        Me.Btn_Home.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1213, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(160, 27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1053, 491)
        Me.Panel3.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 503)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Btn_Att As System.Windows.Forms.Button
    Friend WithEvents Btn_Device As System.Windows.Forms.Button
    Friend WithEvents Btn_User As System.Windows.Forms.Button
    Friend WithEvents Btn_Home As System.Windows.Forms.Button

End Class

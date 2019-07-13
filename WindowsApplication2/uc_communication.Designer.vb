<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_communication
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtIpPort = New System.Windows.Forms.TextBox()
        Me.TxtIP = New System.Windows.Forms.TextBox()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(248, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 13)
        Me.Label16.TabIndex = 112
        Me.Label16.Text = "Device Status"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(366, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(10, 13)
        Me.Label15.TabIndex = 111
        Me.Label15.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(366, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 13)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(366, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(10, 13)
        Me.Label13.TabIndex = 109
        Me.Label13.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(248, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 13)
        Me.Label12.TabIndex = 108
        Me.Label12.Text = "Device Serial Number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(248, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Device Mac Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(382, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Disconnected"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(382, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Disconnected"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(83, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(83, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(83, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = ":"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(382, 14)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(73, 13)
        Me.lblState.TabIndex = 100
        Me.lblState.Text = "Disconnected"
        '
        'BtnConnect
        '
        Me.BtnConnect.Location = New System.Drawing.Point(251, 87)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(85, 23)
        Me.BtnConnect.TabIndex = 97
        Me.BtnConnect.Text = "Connect"
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Port"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "IP Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Device Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Device ID"
        '
        'TxtIpPort
        '
        Me.TxtIpPort.Location = New System.Drawing.Point(126, 89)
        Me.TxtIpPort.Name = "TxtIpPort"
        Me.TxtIpPort.Size = New System.Drawing.Size(100, 20)
        Me.TxtIpPort.TabIndex = 94
        Me.TxtIpPort.Text = "4370"
        '
        'TxtIP
        '
        Me.TxtIP.Location = New System.Drawing.Point(126, 63)
        Me.TxtIP.Name = "TxtIP"
        Me.TxtIP.Size = New System.Drawing.Size(100, 20)
        Me.TxtIP.TabIndex = 93
        Me.TxtIP.Text = "192.168.86.201"
        '
        'TxtDesc
        '
        Me.TxtDesc.Location = New System.Drawing.Point(126, 37)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(100, 20)
        Me.TxtDesc.TabIndex = 92
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(126, 11)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 91
        '
        'uc_communication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.BtnConnect)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtIpPort)
        Me.Controls.Add(Me.TxtIP)
        Me.Controls.Add(Me.TxtDesc)
        Me.Controls.Add(Me.TxtId)
        Me.Name = "uc_communication"
        Me.Size = New System.Drawing.Size(461, 121)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents BtnConnect As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtIpPort As System.Windows.Forms.TextBox
    Friend WithEvents TxtIP As System.Windows.Forms.TextBox
    Friend WithEvents TxtDesc As System.Windows.Forms.TextBox
    Friend WithEvents TxtId As System.Windows.Forms.TextBox

End Class

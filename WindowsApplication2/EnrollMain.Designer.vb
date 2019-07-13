<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnrollMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnSaveEnrolledTmp = New System.Windows.Forms.Button()
        Me.btnStartEnroll = New System.Windows.Forms.Button()
        Me.cbFingerIndex = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblState)
        Me.GroupBox1.Controls.Add(Me.BtnConnect)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtIpPort)
        Me.GroupBox1.Controls.Add(Me.TxtIP)
        Me.GroupBox1.Controls.Add(Me.TxtDesc)
        Me.GroupBox1.Controls.Add(Me.TxtId)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connect To Device"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(261, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 13)
        Me.Label16.TabIndex = 156
        Me.Label16.Text = "Device Status"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(379, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(10, 13)
        Me.Label15.TabIndex = 155
        Me.Label15.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(379, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 13)
        Me.Label14.TabIndex = 154
        Me.Label14.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(379, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(10, 13)
        Me.Label13.TabIndex = 153
        Me.Label13.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(261, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 13)
        Me.Label12.TabIndex = 152
        Me.Label12.Text = "Device Serial Number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(261, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 151
        Me.Label11.Text = "Device Mac Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(395, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 150
        Me.Label10.Text = "Disconnected"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(395, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 149
        Me.Label9.Text = "Disconnected"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(96, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 148
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(96, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 147
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(96, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 146
        Me.Label6.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = ":"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(395, 16)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(73, 13)
        Me.lblState.TabIndex = 144
        Me.lblState.Text = "Disconnected"
        '
        'BtnConnect
        '
        Me.BtnConnect.Location = New System.Drawing.Point(264, 89)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(85, 23)
        Me.BtnConnect.TabIndex = 141
        Me.BtnConnect.Text = "Connect"
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "Port"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "IP Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Device Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Device ID"
        '
        'TxtIpPort
        '
        Me.TxtIpPort.Location = New System.Drawing.Point(139, 91)
        Me.TxtIpPort.Name = "TxtIpPort"
        Me.TxtIpPort.Size = New System.Drawing.Size(100, 20)
        Me.TxtIpPort.TabIndex = 138
        Me.TxtIpPort.Text = "4370"
        '
        'TxtIP
        '
        Me.TxtIP.Location = New System.Drawing.Point(139, 65)
        Me.TxtIP.Name = "TxtIP"
        Me.TxtIP.Size = New System.Drawing.Size(100, 20)
        Me.TxtIP.TabIndex = 137
        Me.TxtIP.Text = "192.168.86.201"
        '
        'TxtDesc
        '
        Me.TxtDesc.Location = New System.Drawing.Point(139, 39)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(100, 20)
        Me.TxtDesc.TabIndex = 136
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(139, 13)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 135
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.btnSaveEnrolledTmp)
        Me.GroupBox2.Controls.Add(Me.btnStartEnroll)
        Me.GroupBox2.Controls.Add(Me.cbFingerIndex)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtUserID)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(493, 100)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enroll and Save Fingerprint Online"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(128, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(234, 13)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "(Save enrolled fingerprint templates to database)"
        '
        'btnSaveEnrolledTmp
        '
        Me.btnSaveEnrolledTmp.Location = New System.Drawing.Point(34, 63)
        Me.btnSaveEnrolledTmp.Name = "btnSaveEnrolledTmp"
        Me.btnSaveEnrolledTmp.Size = New System.Drawing.Size(88, 23)
        Me.btnSaveEnrolledTmp.TabIndex = 58
        Me.btnSaveEnrolledTmp.Tag = "Save Enrolled Tmp to Database"
        Me.btnSaveEnrolledTmp.Text = "SaveTmpToDB"
        Me.btnSaveEnrolledTmp.UseVisualStyleBackColor = True
        '
        'btnStartEnroll
        '
        Me.btnStartEnroll.Location = New System.Drawing.Point(382, 25)
        Me.btnStartEnroll.Name = "btnStartEnroll"
        Me.btnStartEnroll.Size = New System.Drawing.Size(92, 23)
        Me.btnStartEnroll.TabIndex = 57
        Me.btnStartEnroll.Text = "StartEnroll"
        Me.btnStartEnroll.UseVisualStyleBackColor = True
        '
        'cbFingerIndex
        '
        Me.cbFingerIndex.FormattingEnabled = True
        Me.cbFingerIndex.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbFingerIndex.Location = New System.Drawing.Point(260, 26)
        Me.cbFingerIndex.Name = "cbFingerIndex"
        Me.cbFingerIndex.Size = New System.Drawing.Size(42, 21)
        Me.cbFingerIndex.TabIndex = 56
        Me.cbFingerIndex.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(183, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 13)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "FingerIndex"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(92, 26)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(69, 20)
        Me.txtUserID.TabIndex = 0
        Me.txtUserID.Text = "1"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(36, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 18)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "User ID"
        '
        'EnrollMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "EnrollMain"
        Me.Size = New System.Drawing.Size(499, 452)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents btnSaveEnrolledTmp As System.Windows.Forms.Button
    Private WithEvents btnStartEnroll As System.Windows.Forms.Button
    Private WithEvents cbFingerIndex As System.Windows.Forms.ComboBox
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents txtUserID As System.Windows.Forms.TextBox
    Private WithEvents Label19 As System.Windows.Forms.Label

End Class

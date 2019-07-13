<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttLogs
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
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"1", "123", "1", "1", "2018-11-21", "2018-11-29 15:49:03", "15:04"}, -1)
        Me.lvLogs = New System.Windows.Forms.ListView()
        Me.lvLogsch1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvLogsch2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvLogsch3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvLogsch4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvLogsch5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvLogsch6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvLogsch7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnGetGeneralLogData = New System.Windows.Forms.Button()
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
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.lvlogsch8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvlLogsch9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Btc_Upload = New System.Windows.Forms.Button()
        Me.ofd_dat = New System.Windows.Forms.OpenFileDialog()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Lbl_count = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvLogs
        '
        Me.lvLogs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvLogsch1, Me.lvLogsch2, Me.lvLogsch3, Me.lvLogsch4, Me.lvLogsch5, Me.lvlogsch8, Me.lvlLogsch9, Me.lvLogsch6, Me.lvLogsch7})
        Me.lvLogs.GridLines = True
        Me.lvLogs.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.lvLogs.Location = New System.Drawing.Point(0, 156)
        Me.lvLogs.Name = "lvLogs"
        Me.lvLogs.Size = New System.Drawing.Size(499, 260)
        Me.lvLogs.TabIndex = 10
        Me.lvLogs.UseCompatibleStateImageBehavior = False
        Me.lvLogs.View = System.Windows.Forms.View.Details
        '
        'lvLogsch1
        '
        Me.lvLogsch1.Text = "Count"
        Me.lvLogsch1.Width = 45
        '
        'lvLogsch2
        '
        Me.lvLogsch2.Text = "EnrollNumber"
        '
        'lvLogsch3
        '
        Me.lvLogsch3.Text = "VerifyMode"
        Me.lvLogsch3.Width = 76
        '
        'lvLogsch4
        '
        Me.lvLogsch4.Text = "InOutMode"
        '
        'lvLogsch5
        '
        Me.lvLogsch5.Text = "Date"
        '
        'lvLogsch6
        '
        Me.lvLogsch6.Text = "WorkCode"
        '
        'lvLogsch7
        '
        Me.lvLogsch7.Text = "Reserved"
        Me.lvLogsch7.Width = 81
        '
        'btnGetGeneralLogData
        '
        Me.btnGetGeneralLogData.Location = New System.Drawing.Point(359, 127)
        Me.btnGetGeneralLogData.Name = "btnGetGeneralLogData"
        Me.btnGetGeneralLogData.Size = New System.Drawing.Size(137, 23)
        Me.btnGetGeneralLogData.TabIndex = 9
        Me.btnGetGeneralLogData.Text = "Download Attendance Logs"
        Me.btnGetGeneralLogData.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(249, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 13)
        Me.Label16.TabIndex = 134
        Me.Label16.Text = "Device Status"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(367, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(10, 13)
        Me.Label15.TabIndex = 133
        Me.Label15.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(367, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 13)
        Me.Label14.TabIndex = 132
        Me.Label14.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(367, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(10, 13)
        Me.Label13.TabIndex = 131
        Me.Label13.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(249, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 13)
        Me.Label12.TabIndex = 130
        Me.Label12.Text = "Device Serial Number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(249, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 129
        Me.Label11.Text = "Device Mac Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(383, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "Disconnected"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(383, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 127
        Me.Label9.Text = "Disconnected"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(84, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 126
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(84, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(84, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 124
        Me.Label6.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = ":"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(383, 10)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(73, 13)
        Me.lblState.TabIndex = 122
        Me.lblState.Text = "Disconnected"
        '
        'BtnConnect
        '
        Me.BtnConnect.Location = New System.Drawing.Point(252, 83)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(85, 23)
        Me.BtnConnect.TabIndex = 119
        Me.BtnConnect.Text = "Connect"
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Port"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "IP Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Device Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Device ID"
        '
        'TxtIpPort
        '
        Me.TxtIpPort.Location = New System.Drawing.Point(127, 85)
        Me.TxtIpPort.Name = "TxtIpPort"
        Me.TxtIpPort.Size = New System.Drawing.Size(100, 20)
        Me.TxtIpPort.TabIndex = 116
        Me.TxtIpPort.Text = "4370"
        '
        'TxtIP
        '
        Me.TxtIP.Location = New System.Drawing.Point(127, 59)
        Me.TxtIP.Name = "TxtIP"
        Me.TxtIP.Size = New System.Drawing.Size(100, 20)
        Me.TxtIP.TabIndex = 115
        Me.TxtIP.Text = "192.168.86.201"
        '
        'TxtDesc
        '
        Me.TxtDesc.Location = New System.Drawing.Point(127, 33)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(100, 20)
        Me.TxtDesc.TabIndex = 114
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(127, 7)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 113
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(284, 127)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Save.TabIndex = 135
        Me.Btn_Save.Text = "Save to DB"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'lvlogsch8
        '
        Me.lvlogsch8.Text = "DateTime"
        Me.lvlogsch8.Width = 134
        '
        'lvlLogsch9
        '
        Me.lvlLogsch9.Text = "time"
        '
        'Btc_Upload
        '
        Me.Btc_Upload.Location = New System.Drawing.Point(203, 127)
        Me.Btc_Upload.Name = "Btc_Upload"
        Me.Btc_Upload.Size = New System.Drawing.Size(75, 23)
        Me.Btc_Upload.TabIndex = 136
        Me.Btc_Upload.Text = "Upload .dta"
        Me.Btc_Upload.UseVisualStyleBackColor = True
        '
        'ofd_dat
        '
        Me.ofd_dat.FileName = "OpenFileDialog1"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 140)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 137
        Me.Label17.Text = "Total Count"
        '
        'Lbl_count
        '
        Me.Lbl_count.AutoSize = True
        Me.Lbl_count.Location = New System.Drawing.Point(74, 140)
        Me.Lbl_count.Name = "Lbl_count"
        Me.Lbl_count.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_count.TabIndex = 138
        Me.Lbl_count.Text = "."
        '
        'AttLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Lbl_count)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Btc_Upload)
        Me.Controls.Add(Me.Btn_Save)
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
        Me.Controls.Add(Me.lvLogs)
        Me.Controls.Add(Me.btnGetGeneralLogData)
        Me.Name = "AttLogs"
        Me.Size = New System.Drawing.Size(499, 416)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lvLogs As System.Windows.Forms.ListView
    Private WithEvents lvLogsch1 As System.Windows.Forms.ColumnHeader
    Private WithEvents lvLogsch2 As System.Windows.Forms.ColumnHeader
    Private WithEvents lvLogsch3 As System.Windows.Forms.ColumnHeader
    Private WithEvents lvLogsch4 As System.Windows.Forms.ColumnHeader
    Private WithEvents lvLogsch5 As System.Windows.Forms.ColumnHeader
    Private WithEvents lvLogsch6 As System.Windows.Forms.ColumnHeader
    Private WithEvents lvLogsch7 As System.Windows.Forms.ColumnHeader
    Private WithEvents btnGetGeneralLogData As System.Windows.Forms.Button
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
    Friend WithEvents Btn_Save As System.Windows.Forms.Button
    Private WithEvents lvlogsch8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvlLogsch9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Btc_Upload As System.Windows.Forms.Button
    Friend WithEvents ofd_dat As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Lbl_count As System.Windows.Forms.Label

End Class

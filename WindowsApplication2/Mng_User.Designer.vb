<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mng_User
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btn_getdata = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LV_dataDB = New System.Windows.Forms.ListView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LV_dataDev = New System.Windows.Forms.ListView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rd_usr_infofinger = New System.Windows.Forms.RadioButton()
        Me.Rd_uOnly = New System.Windows.Forms.RadioButton()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbFlag = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSaveEnrolledTmp = New System.Windows.Forms.Button()
        Me.btnStartEnroll = New System.Windows.Forms.Button()
        Me.cbFingerIndex = New System.Windows.Forms.ComboBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.Uc_communication1 = New WindowsApplication2.uc_communication()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Uc_communication1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Btn_getdata)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1053, 125)
        Me.Panel1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(790, 34)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 25)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(790, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 25)
        Me.TextBox1.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(947, 99)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Clear Log"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Btn_getdata
        '
        Me.Btn_getdata.Location = New System.Drawing.Point(835, 99)
        Me.Btn_getdata.Name = "Btn_getdata"
        Me.Btn_getdata.Size = New System.Drawing.Size(106, 23)
        Me.Btn_getdata.TabIndex = 3
        Me.Btn_getdata.Text = "View User Terminal"
        Me.Btn_getdata.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1053, 415)
        Me.Panel2.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1053, 415)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1045, 389)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Management User"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.LV_dataDB)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(512, 287)
        Me.Panel5.TabIndex = 2
        '
        'LV_dataDB
        '
        Me.LV_dataDB.CheckBoxes = True
        Me.LV_dataDB.Dock = System.Windows.Forms.DockStyle.Left
        Me.LV_dataDB.GridLines = True
        Me.LV_dataDB.Location = New System.Drawing.Point(0, 0)
        Me.LV_dataDB.Name = "LV_dataDB"
        Me.LV_dataDB.Size = New System.Drawing.Size(506, 287)
        Me.LV_dataDB.TabIndex = 5
        Me.LV_dataDB.UseCompatibleStateImageBehavior = False
        Me.LV_dataDB.View = System.Windows.Forms.View.Details
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.LV_dataDev)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(515, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(527, 287)
        Me.Panel4.TabIndex = 1
        '
        'LV_dataDev
        '
        Me.LV_dataDev.CheckBoxes = True
        Me.LV_dataDev.Dock = System.Windows.Forms.DockStyle.Right
        Me.LV_dataDev.GridLines = True
        Me.LV_dataDev.Location = New System.Drawing.Point(6, 0)
        Me.LV_dataDev.Name = "LV_dataDev"
        Me.LV_dataDev.Size = New System.Drawing.Size(521, 287)
        Me.LV_dataDev.TabIndex = 6
        Me.LV_dataDev.UseCompatibleStateImageBehavior = False
        Me.LV_dataDev.View = System.Windows.Forms.View.Details
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rd_usr_infofinger)
        Me.Panel3.Controls.Add(Me.Rd_uOnly)
        Me.Panel3.Controls.Add(Me.Button6)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 290)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1039, 96)
        Me.Panel3.TabIndex = 0
        '
        'rd_usr_infofinger
        '
        Me.rd_usr_infofinger.AutoSize = True
        Me.rd_usr_infofinger.Location = New System.Drawing.Point(137, 9)
        Me.rd_usr_infofinger.Name = "rd_usr_infofinger"
        Me.rd_usr_infofinger.Size = New System.Drawing.Size(121, 17)
        Me.rd_usr_infofinger.TabIndex = 10
        Me.rd_usr_infofinger.TabStop = True
        Me.rd_usr_infofinger.Text = "User Info and Finger"
        Me.rd_usr_infofinger.UseVisualStyleBackColor = True
        '
        'Rd_uOnly
        '
        Me.Rd_uOnly.AutoSize = True
        Me.Rd_uOnly.Location = New System.Drawing.Point(3, 9)
        Me.Rd_uOnly.Name = "Rd_uOnly"
        Me.Rd_uOnly.Size = New System.Drawing.Size(92, 17)
        Me.Rd_uOnly.TabIndex = 9
        Me.Rd_uOnly.TabStop = True
        Me.Rd_uOnly.Text = "User Info Only"
        Me.Rd_uOnly.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(350, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Modify User"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(431, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Upload"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(599, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(518, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Download"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1045, 389)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add User Enrollment"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbFlag)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnSaveEnrolledTmp)
        Me.GroupBox1.Controls.Add(Me.btnStartEnroll)
        Me.GroupBox1.Controls.Add(Me.cbFingerIndex)
        Me.GroupBox1.Controls.Add(Me.label9)
        Me.GroupBox1.Controls.Add(Me.txtUserID)
        Me.GroupBox1.Controls.Add(Me.label8)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 133)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enroll and Save Fingerprint Online"
        '
        'cbFlag
        '
        Me.cbFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFlag.FormattingEnabled = True
        Me.cbFlag.Items.AddRange(New Object() {"0", "1", "3"})
        Me.cbFlag.Location = New System.Drawing.Point(372, 26)
        Me.cbFlag.Name = "cbFlag"
        Me.cbFlag.Size = New System.Drawing.Size(42, 21)
        Me.cbFlag.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(332, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Flag"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(128, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "(Save enrolled fingerprint templates to database)"
        '
        'btnSaveEnrolledTmp
        '
        Me.btnSaveEnrolledTmp.Location = New System.Drawing.Point(34, 95)
        Me.btnSaveEnrolledTmp.Name = "btnSaveEnrolledTmp"
        Me.btnSaveEnrolledTmp.Size = New System.Drawing.Size(88, 23)
        Me.btnSaveEnrolledTmp.TabIndex = 58
        Me.btnSaveEnrolledTmp.Tag = "Save Enrolled Tmp to Database"
        Me.btnSaveEnrolledTmp.Text = "SaveTmpToDB"
        Me.btnSaveEnrolledTmp.UseVisualStyleBackColor = True
        '
        'btnStartEnroll
        '
        Me.btnStartEnroll.Location = New System.Drawing.Point(184, 59)
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
        Me.cbFingerIndex.Location = New System.Drawing.Point(262, 26)
        Me.cbFingerIndex.Name = "cbFingerIndex"
        Me.cbFingerIndex.Size = New System.Drawing.Size(42, 21)
        Me.cbFingerIndex.TabIndex = 56
        Me.cbFingerIndex.Text = "0"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(187, 30)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(62, 13)
        Me.label9.TabIndex = 55
        Me.label9.Text = "FingerIndex"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(90, 26)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(69, 20)
        Me.txtUserID.TabIndex = 0
        Me.txtUserID.Text = "1"
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(36, 30)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(50, 18)
        Me.label8.TabIndex = 40
        Me.label8.Text = "User ID"
        '
        'Uc_communication1
        '
        Me.Uc_communication1.bIsConnect = False
        Me.Uc_communication1.Location = New System.Drawing.Point(7, 1)
        Me.Uc_communication1.Name = "Uc_communication1"
        Me.Uc_communication1.Size = New System.Drawing.Size(461, 121)
        Me.Uc_communication1.TabIndex = 7
        '
        'Mng_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Mng_User"
        Me.Size = New System.Drawing.Size(1053, 540)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbFlag As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents btnSaveEnrolledTmp As System.Windows.Forms.Button
    Private WithEvents btnStartEnroll As System.Windows.Forms.Button
    Private WithEvents cbFingerIndex As System.Windows.Forms.ComboBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents txtUserID As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents Lv_Dev As System.Windows.Forms.ListView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Btn_getdata As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents LV_dataDB As System.Windows.Forms.ListView
    Private WithEvents LV_dataDev As System.Windows.Forms.ListView
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents rd_usr_infofinger As System.Windows.Forms.RadioButton
    Friend WithEvents Rd_uOnly As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Uc_communication1 As WindowsApplication2.uc_communication

End Class

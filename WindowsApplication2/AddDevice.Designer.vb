<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDevice
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
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.DgvListDevice = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.btnGetDeviceTime = New System.Windows.Forms.Button()
        Me.btnSetDeviceTime = New System.Windows.Forms.Button()
        Me.cbSecond = New System.Windows.Forms.ComboBox()
        Me.cbMonth = New System.Windows.Forms.ComboBox()
        Me.cbMinute = New System.Windows.Forms.ComboBox()
        Me.btnSetDeviceTime2 = New System.Windows.Forms.Button()
        Me.txtGetDeviceTime = New System.Windows.Forms.TextBox()
        Me.cbDay = New System.Windows.Forms.ComboBox()
        Me.cbHour = New System.Windows.Forms.ComboBox()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.Uc_communication1 = New WindowsApplication2.uc_communication()
        CType(Me.DgvListDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(316, 189)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(85, 23)
        Me.BtnUpdate.TabIndex = 30
        Me.BtnUpdate.Text = "&Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(407, 189)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(85, 23)
        Me.BtnDelete.TabIndex = 29
        Me.BtnDelete.Text = "&Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(225, 189)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(85, 23)
        Me.Btn_Save.TabIndex = 28
        Me.Btn_Save.Text = "&Save"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'DgvListDevice
        '
        Me.DgvListDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListDevice.Location = New System.Drawing.Point(3, 218)
        Me.DgvListDevice.Name = "DgvListDevice"
        Me.DgvListDevice.Size = New System.Drawing.Size(493, 195)
        Me.DgvListDevice.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.label19)
        Me.GroupBox1.Controls.Add(Me.btnGetDeviceTime)
        Me.GroupBox1.Controls.Add(Me.btnSetDeviceTime)
        Me.GroupBox1.Controls.Add(Me.cbSecond)
        Me.GroupBox1.Controls.Add(Me.cbMonth)
        Me.GroupBox1.Controls.Add(Me.cbMinute)
        Me.GroupBox1.Controls.Add(Me.btnSetDeviceTime2)
        Me.GroupBox1.Controls.Add(Me.txtGetDeviceTime)
        Me.GroupBox1.Controls.Add(Me.cbDay)
        Me.GroupBox1.Controls.Add(Me.cbHour)
        Me.GroupBox1.Controls.Add(Me.cbYear)
        Me.GroupBox1.Location = New System.Drawing.Point(504, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 143)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.ForeColor = System.Drawing.Color.Red
        Me.label19.Location = New System.Drawing.Point(15, 35)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(161, 13)
        Me.label19.TabIndex = 86
        Me.label19.Text = "Get or set the time of the device."
        '
        'btnGetDeviceTime
        '
        Me.btnGetDeviceTime.Location = New System.Drawing.Point(154, 66)
        Me.btnGetDeviceTime.Name = "btnGetDeviceTime"
        Me.btnGetDeviceTime.Size = New System.Drawing.Size(95, 23)
        Me.btnGetDeviceTime.TabIndex = 77
        Me.btnGetDeviceTime.Text = "GetDeviceTime"
        Me.btnGetDeviceTime.UseVisualStyleBackColor = True
        '
        'btnSetDeviceTime
        '
        Me.btnSetDeviceTime.Location = New System.Drawing.Point(11, 65)
        Me.btnSetDeviceTime.Name = "btnSetDeviceTime"
        Me.btnSetDeviceTime.Size = New System.Drawing.Size(95, 23)
        Me.btnSetDeviceTime.TabIndex = 76
        Me.btnSetDeviceTime.Text = "SetDeviceTime"
        Me.btnSetDeviceTime.UseVisualStyleBackColor = True
        '
        'cbSecond
        '
        Me.cbSecond.FormattingEnabled = True
        Me.cbSecond.Items.AddRange(New Object() {"1", "..", "59"})
        Me.cbSecond.Location = New System.Drawing.Point(276, 107)
        Me.cbSecond.Name = "cbSecond"
        Me.cbSecond.Size = New System.Drawing.Size(41, 21)
        Me.cbSecond.TabIndex = 84
        Me.cbSecond.Text = "8"
        '
        'cbMonth
        '
        Me.cbMonth.DisplayMember = "Month"
        Me.cbMonth.FormattingEnabled = True
        Me.cbMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbMonth.Location = New System.Drawing.Point(80, 106)
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.Size = New System.Drawing.Size(41, 21)
        Me.cbMonth.TabIndex = 80
        Me.cbMonth.Text = "12"
        '
        'cbMinute
        '
        Me.cbMinute.FormattingEnabled = True
        Me.cbMinute.Items.AddRange(New Object() {"1", "..", "59"})
        Me.cbMinute.Location = New System.Drawing.Point(227, 107)
        Me.cbMinute.Name = "cbMinute"
        Me.cbMinute.Size = New System.Drawing.Size(41, 21)
        Me.cbMinute.TabIndex = 83
        Me.cbMinute.Text = "8"
        '
        'btnSetDeviceTime2
        '
        Me.btnSetDeviceTime2.Location = New System.Drawing.Point(325, 105)
        Me.btnSetDeviceTime2.Name = "btnSetDeviceTime2"
        Me.btnSetDeviceTime2.Size = New System.Drawing.Size(114, 23)
        Me.btnSetDeviceTime2.TabIndex = 85
        Me.btnSetDeviceTime2.Text = "SetDeviceTime2"
        Me.btnSetDeviceTime2.UseVisualStyleBackColor = True
        '
        'txtGetDeviceTime
        '
        Me.txtGetDeviceTime.Location = New System.Drawing.Point(280, 65)
        Me.txtGetDeviceTime.Name = "txtGetDeviceTime"
        Me.txtGetDeviceTime.ReadOnly = True
        Me.txtGetDeviceTime.Size = New System.Drawing.Size(156, 20)
        Me.txtGetDeviceTime.TabIndex = 78
        '
        'cbDay
        '
        Me.cbDay.FormattingEnabled = True
        Me.cbDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "..", "30"})
        Me.cbDay.Location = New System.Drawing.Point(129, 106)
        Me.cbDay.Name = "cbDay"
        Me.cbDay.Size = New System.Drawing.Size(41, 21)
        Me.cbDay.TabIndex = 81
        Me.cbDay.Text = "31"
        '
        'cbHour
        '
        Me.cbHour.FormattingEnabled = True
        Me.cbHour.Items.AddRange(New Object() {"1", "..", "59"})
        Me.cbHour.Location = New System.Drawing.Point(178, 107)
        Me.cbHour.Name = "cbHour"
        Me.cbHour.Size = New System.Drawing.Size(41, 21)
        Me.cbHour.TabIndex = 82
        Me.cbHour.Text = "8"
        '
        'cbYear
        '
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Items.AddRange(New Object() {"2009", "2010", "2011", "2012"})
        Me.cbYear.Location = New System.Drawing.Point(12, 106)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(60, 21)
        Me.cbYear.TabIndex = 79
        Me.cbYear.Text = "2009"
        '
        'Uc_communication1
        '
        Me.Uc_communication1.bIsConnect = False
        Me.Uc_communication1.Location = New System.Drawing.Point(3, 3)
        Me.Uc_communication1.Name = "Uc_communication1"
        Me.Uc_communication1.Size = New System.Drawing.Size(461, 121)
        Me.Uc_communication1.TabIndex = 32
        '
        'AddDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Uc_communication1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.DgvListDevice)
        Me.Name = "AddDevice"
        Me.Size = New System.Drawing.Size(953, 416)
        CType(Me.DgvListDevice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents Btn_Save As System.Windows.Forms.Button
    Friend WithEvents DgvListDevice As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label19 As System.Windows.Forms.Label
    Private WithEvents btnGetDeviceTime As System.Windows.Forms.Button
    Private WithEvents btnSetDeviceTime As System.Windows.Forms.Button
    Private WithEvents cbSecond As System.Windows.Forms.ComboBox
    Private WithEvents cbMonth As System.Windows.Forms.ComboBox
    Private WithEvents cbMinute As System.Windows.Forms.ComboBox
    Private WithEvents btnSetDeviceTime2 As System.Windows.Forms.Button
    Private WithEvents txtGetDeviceTime As System.Windows.Forms.TextBox
    Private WithEvents cbDay As System.Windows.Forms.ComboBox
    Private WithEvents cbHour As System.Windows.Forms.ComboBox
    Private WithEvents cbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Uc_communication1 As WindowsApplication2.uc_communication

End Class

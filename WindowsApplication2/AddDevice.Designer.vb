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
        Me.txtGetDeviceTime = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Uc_communication1 = New WindowsApplication2.uc_communication()
        CType(Me.DgvListDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(319, 18)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(85, 23)
        Me.BtnUpdate.TabIndex = 30
        Me.BtnUpdate.Text = "&Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(410, 18)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(85, 23)
        Me.BtnDelete.TabIndex = 29
        Me.BtnDelete.Text = "&Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(228, 18)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(85, 23)
        Me.Btn_Save.TabIndex = 28
        Me.Btn_Save.Text = "&Save"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'DgvListDevice
        '
        Me.DgvListDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListDevice.Location = New System.Drawing.Point(6, 47)
        Me.DgvListDevice.Name = "DgvListDevice"
        Me.DgvListDevice.Size = New System.Drawing.Size(493, 195)
        Me.DgvListDevice.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.label19)
        Me.GroupBox1.Controls.Add(Me.btnGetDeviceTime)
        Me.GroupBox1.Controls.Add(Me.btnSetDeviceTime)
        Me.GroupBox1.Controls.Add(Me.txtGetDeviceTime)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 23)
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
        'txtGetDeviceTime
        '
        Me.txtGetDeviceTime.Location = New System.Drawing.Point(280, 65)
        Me.txtGetDeviceTime.Name = "txtGetDeviceTime"
        Me.txtGetDeviceTime.ReadOnly = True
        Me.txtGetDeviceTime.Size = New System.Drawing.Size(156, 20)
        Me.txtGetDeviceTime.TabIndex = 78
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(5, 142)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(514, 274)
        Me.TabControl1.TabIndex = 33
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DgvListDevice)
        Me.TabPage1.Controls.Add(Me.Btn_Save)
        Me.TabPage1.Controls.Add(Me.BtnDelete)
        Me.TabPage1.Controls.Add(Me.BtnUpdate)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(506, 248)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Device"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(506, 248)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Set Time Zone"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Uc_communication1)
        Me.Name = "AddDevice"
        Me.Size = New System.Drawing.Size(523, 416)
        CType(Me.DgvListDevice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
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
    Private WithEvents txtGetDeviceTime As System.Windows.Forms.TextBox
    Friend WithEvents Uc_communication1 As WindowsApplication2.uc_communication
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage

End Class

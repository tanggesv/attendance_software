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
        CType(Me.DgvListDevice, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'AddDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.DgvListDevice)
        Me.Name = "AddDevice"
        Me.Size = New System.Drawing.Size(499, 416)
        CType(Me.DgvListDevice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents Btn_Save As System.Windows.Forms.Button
    Friend WithEvents DgvListDevice As System.Windows.Forms.DataGridView

End Class

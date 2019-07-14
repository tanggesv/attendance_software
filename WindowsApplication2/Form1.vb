Public Class Form1

    Private Sub Btn_Device_Click(sender As Object, e As EventArgs) Handles Btn_Device.Click
        ' Dim attLogControl As New uc_communication()
        Dim attlogControl As New AddDevice()
        'Me.Panel2.Controls.Add(attLogControl)
        Me.Panel3.Controls.Add(attlogControl)
        attlogControl.Dock = DockStyle.Fill


    End Sub


    Private Sub Btn_User_Click(sender As Object, e As EventArgs) Handles Btn_User.Click
      
    End Sub

    Private Sub Btn_Att_Click(sender As Object, e As EventArgs) Handles Btn_Att.Click
        ' Dim attLogControl As New uc_communication()
        Dim attlogControl As New AttLogs()
        'Me.Panel2.Controls.Add(attLogControl)
        Me.Panel3.Controls.Add(attlogControl)
        attlogControl.Dock = DockStyle.Fill
    End Sub
End Class

Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class EnrollMain
    Public AxCZKEM1 As New zkemkeeper.CZKEM
    Private bIsConnected = False 'the boolean value identifies whether the device is connected
    Private iMachineNumber As Integer 'the serial number of the device.After connecting the device ,this value will be changed.
#Region "Communication"

    Private Sub BtnConnect_Click_1(sender As Object, e As EventArgs) Handles BtnConnect.Click
        If TxtIP.Text.Trim() = "" Or TxtIpPort.Text.Trim() = "" Then
            MsgBox("IP and Port cannot be null", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        Dim idwErrorCode As Integer
        Cursor = Cursors.WaitCursor
        If BtnConnect.Text = "Disconnect" Then
            AxCZKEM1.Disconnect()
            bIsConnected = False
            BtnConnect.Text = "Connect"
            lblState.Text = "Disconnected"
            Cursor = Cursors.Default
            Return
        End If
        bIsConnected = AxCZKEM1.Connect_Net(TxtIP.Text.Trim(), Convert.ToInt32(TxtIpPort.Text.Trim()))
        If bIsConnected = True Then
            BtnConnect.Text = "Disconnect"
            BtnConnect.Refresh()
            lblState.Text = "Connected"
            iMachineNumber = 1 'In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
            AxCZKEM1.RegEvent(iMachineNumber, 65535) 'Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
        Else
            AxCZKEM1.GetLastError(idwErrorCode)
            MsgBox("Unable to connect the device,ErrorCode=" & idwErrorCode, MsgBoxStyle.Exclamation, "Error")
        End If
        Cursor = Cursors.Default
    End Sub
#End Region
#Region "OnlineEnroll"
    'Make sure you have enrolled the fingerprint templates you will save.
    Dim iCanSaveTmp As String = 0
    'Enroll a certain user's specified fingerprint template online.
    'It only supports 9.0 fingerprint arithmetic at present.
    Private Sub btnStartEnroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartEnroll.Click
        If bIsConnected = False Then
            MsgBox("Please connect the device first", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        If txtUserID.Text.Trim() = "" Or cbFingerIndex.Text.Trim() = "" Then
            MsgBox("UserID,FingerIndex must be inputted first!", MsgBoxStyle.Information, "Error")
            Return
        End If
        Dim idwErrorCode As Integer

        Dim iUserID As String = Convert.ToInt32(txtUserID.Text.Trim())
        Dim sUserID = txtUserID.Text.Trim()
        Dim iFingerIndex = Convert.ToInt32(cbFingerIndex.Text.Trim())

        AxCZKEM1.CancelOperation()
        AxCZKEM1.DelUserTmp(iMachineNumber, iUserID, iFingerIndex)
        If AxCZKEM1.StartEnroll(iUserID, iFingerIndex) = True Then
            MsgBox("Start to Enroll a new User,UserID=" + iUserID.ToString() + " FingerID=" + iFingerIndex.ToString(), MsgBoxStyle.Information, "Start")
            iCanSaveTmp = 1
            AxCZKEM1.StartIdentify() 'After enrolling templates,you should let the device into the 1:N verification condition
        Else
            AxCZKEM1.GetLastError(idwErrorCode)
            MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub
#End Region
End Class

Imports System.Data.SqlClient
Public Class AddDevice


#Region "Communication DB"
    Sub view_grid()
        Call OpenDB()
        DA = New SqlDataAdapter("SELECT * from TerminalInfo", CONN)
        DS = New DataSet

        DA.Fill(DS, "TerminalInfo")
        DgvListDevice.DataSource = DS.Tables("TerminalInfo")
        DgvListDevice.ReadOnly = True
    End Sub
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        If UC_Communication1.TxtId.Text = "" Or UC_Communication1.TxtDesc.Text = "" Or UC_Communication1.TxtIP.Text = "" Or UC_Communication1.TxtIpPort.Text = "" Then
            MsgBox("Not Null", MsgBoxStyle.Critical, "Error")
        Else
            Dim conntypes As String = "Ethernet"
            Call OpenDB()
            Save = "Insert Into TerminalInfo(TerminalID,Description,COnnection,TerminalPort,IPPort)VALUES(@P0,@P1,@P2,@P3,@P4)"
            CMD = CONN.CreateCommand
            With CMD
                .CommandText = Save
                .Connection = CONN
                .Parameters.Add("p0", SqlDbType.Int).Value = UC_Communication1.TxtId.Text
                .Parameters.Add("p1", SqlDbType.VarChar, 40).Value = UC_Communication1.TxtDesc.Text
                .Parameters.Add("p2", SqlDbType.VarChar, 15).Value = conntypes.ToString
                .Parameters.Add("p3", SqlDbType.VarChar, 15).Value = UC_Communication1.TxtIP.Text
                .Parameters.Add("p4", SqlDbType.Int).Value = UC_Communication1.TxtIpPort.Text
                .ExecuteNonQuery()
            End With
            MsgBox("successful", MsgBoxStyle.Information, "Information Success")
            CMD.Dispose()
            CONN.Close()
            DgvListDevice.Rows.Clear()
            Call view_grid()
        End If
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Call OpenDB()
        Delete = "DELETE From TerminalInfo Where TerminalID =@p0"
        CMD = CONN.CreateCommand
        With CMD
            .CommandText = Delete
            .Connection = CONN
            .Parameters.Add("@p0", SqlDbType.Int).Value = UC_Communication1.TxtId.Text
            .ExecuteNonQuery()
        End With
        MsgBox("Data Has Been Delete", MsgBoxStyle.Information, "Information")
        CMD.Dispose()
        CONN.Close()
        DgvListDevice.Rows.Clear()
        Call view_grid()
    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If UC_Communication1.TxtId.Text = "" Or UC_Communication1.TxtDesc.Text = "" Or UC_Communication1.TxtIP.Text = "" Or UC_Communication1.TxtIpPort.Text = "" Then
            MsgBox("Not Null", MsgBoxStyle.Critical, "Error")
        Else
            Dim conntypes As String = "Ethernet"
            Call OpenDB()
            ubah = "UPDATE TerminalInfo SET TerminalID=@P0,Description=@P1,TerminalPort=@P2,IPPort=@P3 WHERE TerminalID =@P0"
            '"UPDATE tbbarang SET namabarang=@p2,harga=@p3,stok=@p4 WHERE kodebarang = @p1"
            CMD = CONN.CreateCommand
            With CMD
                .CommandText = ubah
                .Connection = CONN
                .Parameters.Add("p0", SqlDbType.Int).Value = UC_Communication1.TxtId.Text
                .Parameters.Add("p1", SqlDbType.VarChar, 40).Value = UC_Communication1.TxtDesc.Text
                .Parameters.Add("p2", SqlDbType.VarChar, 15).Value = UC_Communication1.TxtIP.Text
                .Parameters.Add("p3", SqlDbType.Int).Value = UC_Communication1.TxtIpPort.Text
                .ExecuteNonQuery()
            End With
            MsgBox("successful", MsgBoxStyle.Information, "Information Success")
            CMD.Dispose()
            CONN.Close()
            'DgvListDevice.Rows.Clear()
            Call view_grid()
        End If
    End Sub
    Private Sub DgvListDevice_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListDevice.CellClick
        If DgvListDevice.RowCount > 0 Then
            Dim line As Integer
            With DgvListDevice
                line = .CurrentRow.Index
                UC_Communication1.TxtId.Text = .Item(0, line).Value.ToString
                UC_Communication1.TxtDesc.Text = .Item(1, line).Value.ToString
                UC_Communication1.TxtIP.Text = .Item(3, line).Value.ToString
                UC_Communication1.TxtIpPort.Text = .Item(4, line).Value.ToString
            End With
        End If
    End Sub
#End Region

    Private Sub btnSetDeviceTime_Click(sender As Object, e As EventArgs) Handles btnSetDeviceTime.Click
        If Uc_communication1.bIsConnected = False Then
            MsgBox("Please connect the device first", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        Dim idwErrorCode As Integer

        Cursor = Cursors.WaitCursor
        If Uc_communication1.axCZKEM1.SetDeviceTime(Uc_communication1.iMachineNumber) = True Then
            Uc_communication1.axCZKEM1.RefreshData(Uc_communication1.iMachineNumber) 'the data in the device should be refreshed
            MsgBox("Successfully set the time of the machine and the terminal to sync PC!", MsgBoxStyle.Information, "Success")
            Dim idwYear As Integer
            Dim idwMonth As Integer
            Dim idwDay As Integer
            Dim idwHour As Integer
            Dim idwMinute As Integer
            Dim idwSecond As Integer
            If Uc_communication1.axCZKEM1.GetDeviceTime(Uc_communication1.iMachineNumber, idwYear, idwMonth, idwDay, idwHour, idwMinute, idwSecond) Then 'show the time
                txtGetDeviceTime.Text = idwYear.ToString() + "-" + idwMonth.ToString() + "-" + idwDay.ToString() + " " + idwHour.ToString() + ":" + idwMinute.ToString() + ":" + idwSecond.ToString()
            End If
        Else
            Uc_communication1.axCZKEM1.GetLastError(idwErrorCode)
            MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub btnGetDeviceTime_Click(sender As Object, e As EventArgs) Handles btnGetDeviceTime.Click
        If Uc_communication1.bIsConnected = False Then
            MsgBox("Please connect the device first", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        Dim idwErrorCode As Integer

        Dim idwYear As Integer
        Dim idwMonth As Integer
        Dim idwDay As Integer
        Dim idwHour As Integer
        Dim idwMinute As Integer
        Dim idwSecond As Integer

        Cursor = Cursors.WaitCursor
        If Uc_communication1.axCZKEM1.GetDeviceTime(Uc_communication1.iMachineNumber, idwYear, idwMonth, idwDay, idwHour, idwMinute, idwSecond) = True Then
            Uc_communication1.axCZKEM1.RefreshData(Uc_communication1.iMachineNumber) 'the data in the device should be refreshed
            txtGetDeviceTime.Text = idwYear.ToString() + "-" + idwMonth.ToString() + "-" + idwDay.ToString() + " " + idwHour.ToString() + ":" + idwMinute.ToString() + ":" + idwSecond.ToString()
        Else
            Uc_communication1.axCZKEM1.GetLastError(idwErrorCode)
            MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
        End If
        Cursor = Cursors.Default
    End Sub

  

    Private Sub AddDevice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call view_grid()
    End Sub
End Class

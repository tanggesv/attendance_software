Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports Microsoft.Office.Interop

Public Class AttLogs
    'declare zkeemkeper
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

    Private Sub btnGetGeneralLogData_Click(sender As Object, e As EventArgs) Handles btnGetGeneralLogData.Click

        If bIsConnected = False Then
            MsgBox("Please connect the device first", MsgBoxStyle.Exclamation, "Error")
            Return
        End If

        Dim sdwEnrollNumber As String = ""
        Dim idwVerifyMode As Integer
        Dim idwInOutMode As Integer
        Dim idwYear As Integer
        Dim idwMonth As Integer
        Dim idwDay As Integer
        Dim idwHour As Integer
        Dim idwMinute As Integer
        Dim idwSecond As Integer
        Dim idwWorkcode As Integer

        Dim idwErrorCode As Integer
        Dim iGLCount = 0
        Dim lvItem As New ListViewItem("Items", 0)

        Cursor = Cursors.WaitCursor
        lvLogs.Items.Clear()

        AxCZKEM1.EnableDevice(iMachineNumber, False) 'disable the device
        If AxCZKEM1.ReadGeneralLogData(iMachineNumber) Then 'read all the attendance records to the memory
            'get records from the memory
            While AxCZKEM1.SSR_GetGeneralLogData(iMachineNumber, sdwEnrollNumber, idwVerifyMode, idwInOutMode, idwYear, idwMonth, idwDay, idwHour, idwMinute, idwSecond, idwWorkcode)
                iGLCount += 1
                lvItem = lvLogs.Items.Add(iGLCount.ToString())
                lvItem.SubItems.Add(sdwEnrollNumber)
                lvItem.SubItems.Add(idwVerifyMode.ToString())
                lvItem.SubItems.Add(idwInOutMode.ToString())
                lvItem.SubItems.Add(idwYear.ToString() & "-" + idwMonth.ToString() & "-" & idwDay.ToString() & " " & idwHour.ToString() & ":" & idwMinute.ToString() & ":" & idwSecond.ToString())
                lvItem.SubItems.Add(idwYear.ToString() & "-" + idwMonth.ToString() & "-" & idwDay.ToString())
                lvItem.SubItems.Add(idwHour.ToString() & ":" & idwMinute.ToString())
                lvItem.SubItems.Add(idwWorkcode.ToString())
            End While
            WarnaListview(lvLogs)
        Else
            Cursor = Cursors.Default
            AxCZKEM1.GetLastError(idwErrorCode)
            If idwErrorCode <> 0 Then
                MsgBox("Reading data from terminal failed,ErrorCode: " & idwErrorCode, MsgBoxStyle.Exclamation, "Error")
            Else
                MsgBox("No data from terminal returns!", MsgBoxStyle.Exclamation, "Error")
            End If
        End If

        AxCZKEM1.EnableDevice(iMachineNumber, True) 'enable the device
        Cursor = Cursors.Default
    End Sub
#Region "Save DB"
    Protected trc As SqlTransaction
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Call OpenDB()

        CMD = New SqlCommand("SELECT COUNT(*) as jumlah FROM personallog where FingerPrintID = FingerPrintID", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        Dim nilai = DR.Item("jumlah")
        CMD.Dispose()
        CONN.Close()

        Try
            Call OpenDB()

            trc = CONN.BeginTransaction()
            CMD.Connection = CONN
            CMD.Transaction = trc
            For i As Integer = 0 To lvLogs.Items.Count - 1

                nilai = nilai + 1
                With CMD
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@p0", nilai.ToString)
                    .Parameters.AddWithValue("@p1", lvLogs.Items(i).SubItems(1).Text)
                    .Parameters.AddWithValue("@p2", TxtId.Text)
                    .Parameters.AddWithValue("@p3", lvLogs.Items(i).SubItems(2).Text)
                    .Parameters.AddWithValue("@p4", CDate(lvLogs.Items(i).SubItems(4).Text))
                    .Parameters.AddWithValue("@p5", CDate(lvLogs.Items(i).SubItems(5).Text))
                    .Parameters.AddWithValue("@p6", lvLogs.Items(i).SubItems(6).Text)
                    .CommandText = "SET IDENTITY_INSERT personallog ON insert into personallog (PersonalLogID,FingerPrintID,TerminalID,VerifyMode,datelog,datetime,TimeLog)values(@p0,@p1,@p2,@p3,@p4,@p5,@p6) "
                    .ExecuteNonQuery()
                    'SET IDENTITY_INSERT personallog ON
                    'SET IDENTITY_INSERT personallog ON
                    'SET IDENTITY_INSERT personallog ON
                End With
            Next
            trc.Commit()
        Catch ex As Exception
            trc.Rollback()
        Finally
            CMD.Dispose()
            CONN.Close()
            lvLogs.Items.Clear()

        End Try
    End Sub
    Private Sub WarnaListview(ByVal lv As ListView)
        ' perulangan untuk setiap item pada listview
        For Each item As ListViewItem In lv.Items
            If item.Index Mod 2 = 0 Then
                'warna baris genap
                item.BackColor = Color.White
            Else
                'warna baris ganjil
                item.BackColor = Color.Aquamarine
            End If
        Next
    End Sub
#End Region

    Private Sub Btc_Upload_Click(sender As Object, e As EventArgs) Handles Btc_Upload.Click
        lvLogs.Items.Clear()
        lvLogs.Refresh()
        ofd_dat.Filter = "1_attlog(*.dat)|*.dat|All files (*.*)|*.*"
        'ofd_dat.FileName = "1_attlog.dat"
        Dim stream As FileStream
        Dim ind As Integer = 1
        If ofd_dat.ShowDialog = DialogResult.OK Then
            Stream = New FileStream(ofd_dat.FileName, FileMode.OpenOrCreate, FileAccess.Read)
            Dim files = File.ReadAllLines(ofd_dat.FileName)

            Cursor = Cursors.WaitCursor
            For i As Integer = 0 To files.Length + 1
                Dim line() As String = files(4).Split(",") 'regex.Split(files(i.ToString), "\t")
                'Dim line() As String = files
                With lvLogs
                    .Items.Add(ind.ToString)
                    With .Items(.Items.Count - 1).SubItems
                        .Add(line(0)) 'enroll number
                        .Add(line(1)) 'date
                        .Add(line(2)) 'in out mode
                        .Add(line(3)) 'vetify mode
                    End With
                End With
                ind = ind + 1

            Next
            lvLogs.Refresh()
            Dim counts As Integer = lvLogs.Items.Count
            Lbl_count.Text = counts
            WarnaListview(lvLogs)
        End If
        Cursor = Cursors.Default
    End Sub
    

    Private Sub AttLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call WarnaListview(lvLogs)
        ProgressBar1.Visible = False
    End Sub
#Region "Export Excel"


    Private Sub Btn_export_Click(sender As Object, e As EventArgs) Handles Btn_export.Click
        Label17.Text = picker1.Text
        Lbl_count.Text = picker2.Text
        Call export_to_excel()
    End Sub

    Private Sub Btn_fine_Click(sender As Object, e As EventArgs) Handles Btn_fine.Click
        Me.lvLogs.Items.Clear()
        OpenDB()
        CMD = New SqlCommand("select TerminalID, fingerprintid,datelog,timelog, verifymode from personallog where datelog between '" & picker1.Text & "' and '" & picker2.Text & "'", CONN)
        DA = New SqlDataAdapter(CMD)
        Dim tbl As New DataTable
        DA.Fill(tbl)
        For i As Integer = 0 To tbl.Rows.Count - 1
            With lvLogs
                .Items.Add(tbl.Rows(i)("TerminalID"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(tbl.Rows(i)("fingerprintid"))
                    .Add(tbl.Rows(i)("datelog"))
                    .Add(tbl.Rows(i)("timelog"))
                End With
            End With

        Next
        
    End Sub
    Sub export_to_excel()
        sfd_export.Title = "Save Excel File"
        sfd_export.Filter = "Excel File (*.xls)|*xls"
        'sfd_export.ShowDialog()

        'If sfd_export.FileName = "" Then
        '    Exit Sub
        'End If
        If sfd_export.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim xls As New Excel.Application
                Dim book As Excel.Workbook
                Dim sheet As Excel.Worksheet
                Dim sheetrange As Excel.Range
                'create a workbook and get reference to first worksheet
                xls.Workbooks.Add()
                book = xls.ActiveWorkbook
                sheet = book.ActiveSheet
                'step through rows and columns and copy data to worksheet
                Dim row As Integer = 2
                Dim col As Integer = 1
                Dim colum As Integer = 1
                For j As Integer = 0 To lvLogs.Columns.Count - 1
                    sheet.Cells(1, col) = lvLogs.Columns(j).Text.ToString
                    With sheet.Range("a1")
                        .EntireColumn.ColumnWidth = 70
                        .Font.Bold = True
                        .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    End With
                    With sheet.Range("b1")
                        .EntireColumn.ColumnWidth = 120
                        .Font.Bold = True
                        .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    End With
                    With sheet.Range("c1")
                        .EntireColumn.ColumnWidth = 15
                        .Font.Bold = True
                        .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    End With
                    With sheet.Range("d1", "e1")
                        .EntireColumn.ColumnWidth = 15
                        .Font.Bold = True
                        .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    End With
                    With sheet.Range("f1", "g1")
                        .EntireColumn.ColumnWidth = 15
                        .Font.Bold = True
                        .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    End With
                    col = col + 1
                Next
                Me.ProgressBar1.Visible = True
                Me.ProgressBar1.Minimum = 0
                Me.ProgressBar1.Maximum = lvLogs.Items.Count
                For Each item As ListViewItem In lvLogs.Items
                    For i As Integer = 0 To item.SubItems.Count - 1
                        sheet.Cells(row, colum) = item.SubItems(i).Text
                        sheetrange = sheet.Range("a1", "f1")
                        sheetrange.EntireColumn.AutoFit()
                        sheetrange.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter
                        colum = colum + 1
                    Next
                    row += 1
                    colum = 1
                    If Me.ProgressBar1.Maximum > Me.ProgressBar1.Value + 1 Then
                        Me.ProgressBar1.Value = Me.ProgressBar1.Value + 1
                    End If
                Next

                'save the workbook and clean up

                book.SaveAs(sfd_export.FileName)
                xls.Workbooks.Close()
                xls.Quit()
                releaseObject(sheet)
                releaseObject(book)
                releaseObject(xls)

                Me.ProgressBar1.Visible = False
                Me.ProgressBar1.Minimum = 0
                MsgBox("Berhasil export Laporan, data laporan tersimpan di : " & sfd_export.FileName, MsgBoxStyle.Information, "Informasi")
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        'Release an automation object
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
#End Region
End Class

Imports System.Data.SqlClient

Public Class Mng_User

#Region "Communication"
    'Public AxCZKEM1 As New zkemkeeper.CZKEM

    'Private bIsConnected = False 'the boolean value identifies whether the device is connected
    'Private iMachineNumber As Integer 'the serial number of the device.After connecting the device ,this value will be changed.

  
#End Region

    
    
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
   
    Sub header_UserDev()
        Me.LV_dataDev.Columns.Clear()
        With LV_dataDev
            .Columns.Add("Finger Print", 90, HorizontalAlignment.Center)
            .Columns.Add("Card Number", 100, HorizontalAlignment.Center)
            .Columns.Add("Nick Name", 120, HorizontalAlignment.Center)
            .Columns.Add("Authority", 70, HorizontalAlignment.Center)
            .Columns.Add("Finger Index", 70, HorizontalAlignment.Center)
            .Columns.Add("Authority", 70, HorizontalAlignment.Center)
            .Columns.Add("Card Number", 70, HorizontalAlignment.Center)
            .Columns.Add("Authority", 70, HorizontalAlignment.Center)
            .Columns.Add("1", 70, HorizontalAlignment.Center)
            

        End With
    End Sub
   
    Private Sub btnSaveEnrolledTmp_Click(sender As Object, e As EventArgs) Handles btnSaveEnrolledTmp.Click

    End Sub


    Private Sub Mng_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call header_UserDev()
        Call header_UserDB()
        Call WarnaListview(LV_dataDB)
        Call WarnaListview(LV_dataDev)
        Call isilist()

    End Sub


  
    Private Sub Uc_communication1_Load(sender As Object, e As EventArgs) Handles Uc_communication1.Load
        If Uc_communication1.TxtIP.Text.Trim() = "" Or Uc_communication1.TxtIpPort.Text.Trim() = "" Then
            MsgBox("IP and Port cannot be null", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        Dim idwErrorCode As Integer
        Cursor = Cursors.WaitCursor
        If Uc_communication1.BtnConnect.Text = "Disconnect" Then
            Uc_communication1.axCZKEM1.Disconnect()

            'RemoveHandler axCZKEM1.OnVerify, AddressOf axCZKEM1.OnVerify
            'RemoveHandler axCZKEM1.OnAttTransaction, AddressOf axCZKEM1.OnAttTransaction
            'RemoveHandler axCZKEM1.OnNewUser, AddressOf axCZKEM1.OnNewUser
            'RemoveHandler axCZKEM1.OnWriteCard, AddressOf axCZKEM1.OnWriteCard
            'RemoveHandler axCZKEM1.OnEmptyCard, AddressOf axCZKEM1.OnEmptyCard
            'RemoveHandler axCZKEM1.OnHIDNum, AddressOf axCZKEM1.OnHIDNum

            Uc_communication1.bIsConnected = False

            Uc_communication1.BtnConnect.Text = "Connect"
            Uc_communication1.lblState.Text = "Disconnected"
            Cursor = Cursors.Default
            Return
        End If
        Uc_communication1.bIsConnected = Uc_communication1.axCZKEM1.Connect_Net(Uc_communication1.TxtIP.Text.Trim(), Convert.ToInt32(Uc_communication1.TxtIpPort.Text.Trim()))
        If Uc_communication1.bIsConnected = True Then
            Uc_communication1.bIsConnect = Uc_communication1.bIsConnected
            'attlogControl.isConnect = bIsConnected
            'statconn = bIsConnected
            'MsgBox(attlogControl.isConnect)
            Uc_communication1.BtnConnect.Text = "Disconnect"
            Uc_communication1.BtnConnect.Refresh()
            Uc_communication1.lblState.Text = "Connected"
            Dim smac As String = ""
            Dim SN As String = ""
            Uc_communication1.axCZKEM1.GetDeviceMAC(Uc_communication1.iMachineNumber, smac)
            label9.Text = smac
            Uc_communication1.axCZKEM1.GetSerialNumber(Uc_communication1.iMachineNumber, SN)
            Uc_communication1.Label10.Text = SN
            Uc_communication1.iMachineNumber = 1 'In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.

            Uc_communication1.axCZKEM1.RegEvent(Uc_communication1.iMachineNumber, 65535)  'Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)

            'AddHandler axCZKEM1.OnVerify, AddressOf axCZKEM1.OnVerify
            'AddHandler axCZKEM1.OnAttTransaction, AddressOf axCZKEM1.OnAttTransaction
            'AddHandler axCZKEM1.OnNewUser, AddressOf axCZKEM1.OnNewUser
            'AddHandler axCZKEM1.OnWriteCard, AddressOf axCZKEM1.OnWriteCard
            'AddHandler axCZKEM1.OnEmptyCard, AddressOf axCZKEM1.OnEmptyCard
            'AddHandler axCZKEM1.OnHIDNum, AddressOf axCZKEM1.OnHIDNum


        Else
            Uc_communication1.axCZKEM1.GetLastError(idwErrorCode)
            MsgBox("Unable to connect the device,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub Btn_getdata_Click(sender As Object, e As EventArgs) Handles Btn_getdata.Click
        Call getdata_userMachine()
    End Sub
    Protected trc As SqlTransaction
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        If LV_dataDB.Items.Count = 0 Then
            MsgBox("Please get user first", MsgBoxStyle.Critical, "Error")
            Return
        End If

        If LV_dataDB.CheckedItems.Count = -1 Then
            MsgBox("Please select user first", MsgBoxStyle.Critical, "Error")
            Return
        End If

        Dim x As Integer
        Dim userid As String
        Dim nickName As String
        Dim cardNumber As String
        Dim fingerIdx As Integer
        Dim templateFp As String
        Dim privillege As Integer

        Dim queryFpIdx As String

        For x = 0 To LV_dataDB.CheckedItems.Count - 1

            userid = LV_dataDB.CheckedItems(x).SubItems(1).Text

            nickName = LV_dataDB.CheckedItems(x).SubItems(2).Text
            If nickName <> "" And nickName.Length > 7 Then
                nickName = nickName.Substring(0, 6)
            End If

            cardNumber = LV_dataDB.CheckedItems(x).SubItems(3).Text
            privillege = LV_dataDB.CheckedItems(x).SubItems(6).Text

            fingerIdx = LV_dataDB.CheckedItems(x).SubItems(4).Text
            queryFpIdx = "EmployeeFingerData" & fingerIdx
            templateFp = LV_dataDB.CheckedItems(x).SubItems(5).Text

            Dim isExistFPID = userid
            If isExistFPID = True Then
                Try
                    OpenDB()
                    Save = "UPDATE Employee SET EmployeeNickName = @p0 , EmployeePrivilege = @p1 , EmployeeCardNumber = @p2 , " & queryFpIdx & " = @p3 WHERE FingerPrintID = @p4"
                    CMD = CONN.CreateCommand
                    With CMD
                        .CommandText = Save
                        .Connection = CONN
                        .Parameters.Add("p0", SqlDbType.NVarChar).Value = nickName
                        .Parameters.Add("p1", SqlDbType.Int).Value = privillege
                        .Parameters.Add("p2", SqlDbType.NVarChar).Value = cardNumber
                        .Parameters.Add("p3", SqlDbType.Text).Value = templateFp
                        .Parameters.Add("p4", SqlDbType.Int).Value = userid
                        .ExecuteNonQuery()
                    End With

                    CMD.Dispose()
                    CONN.Close()

                Catch ex As Exception
                    MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical, "Error delete device from database")
                End Try
            Else
                Try
                    OpenDB()
                    Save = "INSERT INTO Employee (FingerPrintID, EmployeeID, EmployeeNickName, EmployeePrivilege, EmployeeCardNumber, " & queryFpIdx & ", DepartmentCode, GroupShiftCode, EmployeeFirstName, EmployeeAddress)" &
                           " values(@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)"
                    CMD = CONN.CreateCommand
                    With CMD
                        .CommandText = Save
                        .Connection = CONN
                        .Parameters.Add("p0", SqlDbType.Int).Value = userid
                        .Parameters.Add("p1", SqlDbType.NVarChar).Value = userid.ToString()
                        .Parameters.Add("p2", SqlDbType.NVarChar).Value = nickName
                        .Parameters.Add("p3", SqlDbType.Int).Value = privillege
                        .Parameters.Add("p4", SqlDbType.NVarChar).Value = cardNumber
                        .Parameters.Add("p5", SqlDbType.Text).Value = templateFp
                        .Parameters.Add("p6", SqlDbType.NVarChar).Value = "1"
                        .Parameters.Add("p7", SqlDbType.NVarChar).Value = "1"
                        .Parameters.Add("p8", SqlDbType.NVarChar).Value = nickName
                        .Parameters.Add("p9", SqlDbType.NVarChar).Value = "Address"
                        .ExecuteNonQuery()
                    End With

                    CMD.Dispose()
                    CONN.Close()

                Catch ex As Exception
                    MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical, "Error save user to database")
                End Try
            End If
        Next

        MsgBox("Success save user to database ", MsgBoxStyle.Information, "Information")
        ' setLV_dataDB()
    End Sub




    Sub getdata_userMachine()
        If Uc_communication1.bIsConnected = False Then
            MsgBox("Please connect the device first", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        Dim sdwEnrollNumber As String = ""
        Dim sName As String = ""
        Dim sPassword As String = ""
        Dim iPrivilege As Integer
        Dim bEnabled As Boolean = False
        Dim idwFingerIndex As Integer
        Dim sTmpData As String = ""
        Dim iTmpLength As Integer
        Dim iFlag As Integer
        Dim scardnumber As Integer
        Dim lvItem As New ListViewItem("Items", 0)
        LV_dataDev.Items.Clear()
        LV_dataDev.BeginUpdate()
        Uc_communication1.axCZKEM1.EnableDevice(Uc_communication1.iMachineNumber, False)

        Cursor = Cursors.WaitCursor
        Uc_communication1.axCZKEM1.ReadAllUserID(Uc_communication1.iMachineNumber) 'read all the user information to the memory
        Uc_communication1.axCZKEM1.ReadAllTemplate(Uc_communication1.iMachineNumber) 'read all the users' fingerprint templates to the memory

        While Uc_communication1.axCZKEM1.SSR_GetAllUserInfo(Uc_communication1.iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled) = True  'get all the users' information from the memory
            If Uc_communication1.axCZKEM1.GetStrCardNumber(scardnumber) = True Then


                For idwFingerIndex = 0 To 9
                    If Uc_communication1.axCZKEM1.GetUserTmpExStr(Uc_communication1.iMachineNumber, sdwEnrollNumber, idwFingerIndex, iFlag, sTmpData, iTmpLength) Then 'get the corresponding templates string and length from the memory
                        lvItem = LV_dataDev.Items.Add(sdwEnrollNumber.ToString())
                        lvItem.SubItems.Add(scardnumber)
                        lvItem.SubItems.Add(sName)
                        lvItem.SubItems.Add(iPrivilege.ToString())
                        lvItem.SubItems.Add(idwFingerIndex.ToString())
                        lvItem.SubItems.Add(sTmpData)
                        lvItem.SubItems.Add(sPassword)

                        If bEnabled = True Then
                            lvItem.SubItems.Add("true")
                        Else
                            lvItem.SubItems.Add("false")
                        End If
                        lvItem.SubItems.Add(iFlag.ToString())
                    End If
                Next
            End If
        End While
        LV_dataDev.EndUpdate()
        Uc_communication1.axCZKEM1.EnableDevice(Uc_communication1.iMachineNumber, True)
        Cursor = Cursors.Default
    End Sub
    Sub buattable()

    End Sub
    Sub header_UserDB()
        Me.LV_dataDB.Columns.Clear()
        With LV_dataDB
            .Columns.Add("", 30, HorizontalAlignment.Center)
            .Columns.Add("Finger Print ID", 90, HorizontalAlignment.Center)
            .Columns.Add("Card Number", 100, HorizontalAlignment.Center)
            .Columns.Add("Nick Name", 120, HorizontalAlignment.Center)
            .Columns.Add("Employee Number", 120, HorizontalAlignment.Center)
            .Columns.Add("Privilege", 70, HorizontalAlignment.Center)
            .Columns.Add("Password", 70, HorizontalAlignment.Center)
            .Columns.Add("employeeid", 70, HorizontalAlignment.Center)
            .Columns.Add("finger status", 70, HorizontalAlignment.Center)
            .Columns.Add("Template", 70, HorizontalAlignment.Center)
            .Columns.Add("flag", 70, HorizontalAlignment.Center)
        End With
    End Sub
    Sub isilist()
        LV_dataDB.Items.Clear()
        LV_dataDB.Refresh()
        'Dim Query = "SELECT FingerPrintID, EmployeeCardNumber, EmployeeNickName, EmployeeID, EmployeePrivilege  FROM Employee"

        ' Unpivot Table
        Dim Query = "select fingerprintid,EmployeeCardNumber, EmployeeNickName, fpidx ,EmployeePrivilege ,  employeepassword,   EmployeeID,employeefingerstatus,  orders FROM" &
                   "(SELECT fingerprintid, EmployeeFingerData0, EmployeeFingerData1, EmployeeFingerData2, " &
                   "EmployeeFingerData3, EmployeeFingerData4, EmployeeFingerData5, EmployeeFingerData6," &
                   "EmployeeFingerData7, EmployeeFingerData8, EmployeeFingerData9, EmployeeCardNumber, EmployeeNickName,EmployeePrivilege ,employeepassword, employeefingerstatus, EmployeeID" &
                   " FROM employee) e " &
                   "UNPIVOT" &
                   "(Orders FOR fpidx IN " &
                   "(EmployeeFingerData0, EmployeeFingerData1, EmployeeFingerData2, " &
                   "EmployeeFingerData3, EmployeeFingerData4, EmployeeFingerData5, EmployeeFingerData6," &
                   "EmployeeFingerData7, EmployeeFingerData8, EmployeeFingerData9)" &
                   ")AS unpvt"
        Try
            Call OpenDB()
            CMD = New SqlCommand(Query, CONN)
            DR = CMD.ExecuteReader()

            Dim CountNumber As Integer = 1
            
            While (DR.Read())
                Dim dataRow() As String = {
                    "",
                    DR.GetValue(0).ToString(),
                    DR.GetValue(1).ToString(),
                    DR.GetValue(2).ToString(),
                    DR.GetValue(3).ToString().Substring(DR.GetValue(3).ToString().Length - 1, 1),
                    DR.GetValue(4).ToString(),
                    DR.GetValue(5).ToString(),
                    DR.GetValue(6).ToString(),
                    DR.GetValue(7).ToString(),
                    DR.GetValue(8).ToString()
                }

                Dim lvItem As New ListViewItem()

                lvItem = New ListViewItem(dataRow)
                LV_dataDB.Items.Add(lvItem)
                CountNumber += CountNumber
            End While
            CMD.Dispose()
            DR.Close()
            CONN.Close()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
        'Call OpenDB()
        ''CMD = New SqlCommand("select fingerprintid,employeecardnumber,employeenickname,EmployeeFingerLength0,EmployeePrivilege,employeepassword,employeeid,employeefingerdata0,employeefingerstatus,employeenotes from employee", CONN)
        'CMD = New SqlCommand("select fingerprintid,employeenotes,employeefingerstatus,employeepassword, fpidx, tmpData ,   EmployeeCardNumber, EmployeeNickName, EmployeeID, EmployeePrivilege  FROM (SELECT fingerprintid, EmployeeFingerData0,employeefingerstatus, EmployeeFingerData1, EmployeeFingerData2, EmployeeFingerData3, EmployeeFingerData4, EmployeeFingerData5, EmployeeFingerData6, EmployeeFingerData7, EmployeeFingerData8, EmployeeFingerData9  ,   EmployeeCardNumber, EmployeeNickName,employeenotes,employeepassword, EmployeeID, EmployeePrivilege    FROM employee) e UNPIVOT (tmpData FOR fpidx IN         (EmployeeFingerData0, EmployeeFingerData1, EmployeeFingerData2, EmployeeFingerData3, EmployeeFingerData4, EmployeeFingerData5, EmployeeFingerData6, EmployeeFingerData7, EmployeeFingerData8, EmployeeFingerData9)  )AS unpvt ", CONN)
        'DA = New SqlDataAdapter(CMD)
        'Dim dt As New DataTable
        'DA.Fill(dt)
        'With LV_dataDB
        '    .View = View.Details
        '    .FullRowSelect = True
        '    .GridLines = True
        '    header_UserDB()
        '    Dim v_nilai As Integer = -5
        '    For i As Integer = 0 To dt.Rows.Count - 1

        '        LV_dataDB.Items.Add((dt.Rows(i)("fingerprintid"))) '0
        '        With .Items(.Items.Count - 1).SubItems
        '            .Add(dt.Rows(i)("employeenickname").ToString) '2 
        '            .Add(dt.Rows(i)("fingerprintid").ToString) '3
        '            .Add(dt.Rows(i)("EmployeePrivilege").ToString) '4

        '            .Add(dt.Rows(i)("employeecardnumber").ToString) '1
        '            .Add(dt.Rows(i)("employeepassword").ToString) '5
        '            .Add(dt.Rows(i)("employeenotes").ToString) '6
        '            ' .Add(dt.Rows(i)("employeefingerstatus").ToString) '7

        '            .Add(dt.Rows(i)(9).ToString().Substring(dt.Rows(i).ToString().Length - 1, 1)) '7

        '            .Add(dt.Rows(i)("employeeid").ToString) '8
        '            .Add(dt.Rows(i)("tmpData").ToString) '9
        '        End With
        '    Next
        '    .AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        'End With
        'For i As Integer = 0 To dt.Rows.Count - 1
        '    .Items.Add((dt.Rows(i)("fingerprintid"))) '0
        '    With .Items(.Items.Count - 1).SubItems

        '        .Add(dt.Rows(i)("employeenickname").ToString) '1

        '        .Add(dt.Rows(i)("EmployeeFingerLength0").ToString) '2 
        '        .Add(dt.Rows(i)("employeefingerdata0").ToString) '3
        '        .Add(dt.Rows(i)("EmployeePrivilege").ToString) '4
        '        .Add(dt.Rows(i)("employeepassword").ToString) '5
        '        .Add(dt.Rows(i)("employeefingerstatus").ToString) '6
        '        .Add(dt.Rows(i)("employeenotes").ToString) '7
        '        '.Add(dt.Rows(i)("employeeid").ToString) '8



        '        '.Add(dt.Rows(i)("employeecardnumber").ToString) '1


        '    End With

        'Next
    End Sub
   

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If Uc_communication1.bIsConnected = False Then
            MsgBox("Please connect the device first", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        If LV_dataDB.Items.Count = 0 Then
            MsgBox("There is no data to upload!", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        Dim idwErrorCode As Integer

        Dim sdwEnrollNumber As String = ""
        Dim sName As String = ""
        Dim sPassword As String = ""
        Dim iPrivilege As Integer
        Dim idwFingerIndex As Integer
        Dim sTmpData As String = ""
        Dim sEnabled As String = ""
        Dim bEnabled As Boolean = False
        Dim iflag As Integer

        Dim iUpdateFlag As Integer = 1
        Dim lvItem As New ListViewItem

        Cursor = Cursors.WaitCursor
        Uc_communication1.axCZKEM1.EnableDevice(Uc_communication1.iMachineNumber, False)

        If Uc_communication1.axCZKEM1.BeginBatchUpdate(Uc_communication1.iMachineNumber, iUpdateFlag) Then 'create memory space for batching data
            Dim iLastEnrollNumber As Integer = 0 'the former enrollnumber you have upload(define original value as 0)
            For Each lvItem In LV_dataDB.Items
                sdwEnrollNumber = Convert.ToInt32(lvItem.SubItems(1).Text.Trim())
                sName = lvItem.SubItems(3).Text.Trim()
                idwFingerIndex = Convert.ToInt32(lvItem.SubItems(4).Text.Trim())
                sTmpData = lvItem.SubItems(9).Text.Trim()
                iPrivilege = Convert.ToInt32(lvItem.SubItems(5).Text.Trim())
                sPassword = lvItem.SubItems(6).Text.Trim()
                sEnabled = lvItem.SubItems(8).Text.Trim()
                'iflag = Convert.ToInt32(lvItem.SubItems(8).Text.Trim().ToString)
                '.Columns.Add("", 30, HorizontalAlignment.Center)0
                '.Columns.Add("Finger Print ID", 90, HorizontalAlignment.Center)1
                '.Columns.Add("Card Number", 100, HorizontalAlignment.Center)2
                '.Columns.Add("Nick Name", 120, HorizontalAlignment.Center) 3
                '.Columns.Add("Employee Number", 120, HorizontalAlignment.Center)4
                '.Columns.Add("Privilege", 70, HorizontalAlignment.Center)5
                '.Columns.Add("Password", 70, HorizontalAlignment.Center)6
                '.Columns.Add("employeeid", 70, HorizontalAlignment.Center)7
                '.Columns.Add("finger status", 70, HorizontalAlignment.Center)8
                '.Columns.Add("Template", 70, HorizontalAlignment.Center)9
                If sEnabled = "true" Then
                    bEnabled = True
                Else
                    bEnabled = False
                End If

                If sdwEnrollNumber <> iLastEnrollNumber Then 'identify whether the user information(except fingerprint templates) has been uploaded
                    If Uc_communication1.axCZKEM1.SSR_SetUserInfo(Uc_communication1.iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled) Then 'upload user information to the device
                        Uc_communication1.axCZKEM1.SetUserTmpExStr(Uc_communication1.iMachineNumber, sdwEnrollNumber, idwFingerIndex, iflag, sTmpData) 'upload templates information to the device
                    Else
                        Uc_communication1.axCZKEM1.GetLastError(idwErrorCode)
                        MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
                        Cursor = Cursors.Default
                        Uc_communication1.axCZKEM1.EnableDevice(Uc_communication1.iMachineNumber, True)
                        Return
                    End If
                Else 'the current fingerprint and the former one belongs the same user,that is ,one user has more than one template
                    Uc_communication1.axCZKEM1.SetUserTmpExStr(Uc_communication1.iMachineNumber, sdwEnrollNumber, idwFingerIndex, iflag, sTmpData) 'upload tempates information to the memory
                End If
                iLastEnrollNumber = sdwEnrollNumber 'change the value of iLastEnrollNumber dynamicly
            Next
        End If

        Uc_communication1.axCZKEM1.BatchUpdate(Uc_communication1.iMachineNumber) 'upload all the information in the memory
        Uc_communication1.axCZKEM1.RefreshData(Uc_communication1.iMachineNumber) 'the data in the device should be refreshed
        Uc_communication1.axCZKEM1.EnableDevice(Uc_communication1.iMachineNumber, True)
        Cursor = Cursors.Default
        MsgBox("Successfully upload fingerprint templates in batches , " + "total:" + LV_dataDB.Items.Count.ToString(), MsgBoxStyle.Information, "Success")
    End Sub
    'Sub a1()
    'If Uc_communication1.bIsConnected = False Then
    '    MsgBox("Please connect the device first", MsgBoxStyle.Exclamation, "Error")
    '    Return
    'End If
    'If LV_dataDB.Items.Count = 0 Then
    '    MsgBox("There is no data to upload!", MsgBoxStyle.Exclamation, "Error")
    '    Return
    'End If
    'Dim idwErrorCode As Integer

    'Dim sdwEnrollNumber As String = ""
    'Dim sName As String = ""
    'Dim sPassword As String = ""
    'Dim iPrivilege As Integer
    'Dim idwFingerIndex As Integer
    'Dim sTmpData As String = ""
    'Dim sEnabled As String = ""
    'Dim bEnabled As Boolean = False
    'Dim iflag As Integer

    'Dim iUpdateFlag As Integer = 1
    'Dim lvItem As New ListViewItem

    'Cursor = Cursors.WaitCursor
    'Uc_communication1.axCZKEM1.EnableDevice(Uc_communication1.iMachineNumber, False)

    'If Uc_communication1.axCZKEM1.BeginBatchUpdate(Uc_communication1.iMachineNumber, iUpdateFlag) Then 'create memory space for batching data
    '    Dim iLastEnrollNumber As Integer = 0 'the former enrollnumber you have upload(define original value as 0)
    '    For Each lvItem In LV_dataDB.Items
    '        sdwEnrollNumber = Convert.ToInt32(lvItem.SubItems(0).Text.Trim())
    '        sName = lvItem.SubItems(1).Text.Trim()
    '        idwFingerIndex = Convert.ToInt32(lvItem.SubItems(2).Text.Trim())
    '        sTmpData = lvItem.SubItems(3).Text.Trim()
    '        iPrivilege = Convert.ToInt32(lvItem.SubItems(4).Text.Trim())
    '        sPassword = lvItem.SubItems(5).Text.Trim()
    '        sEnabled = lvItem.SubItems(6).Text.Trim()
    '        iflag = Convert.ToInt32(lvItem.SubItems(7).Text.Trim())

    '        If sEnabled = "true" Then
    '            bEnabled = True
    '        Else
    '            bEnabled = False
    '        End If

    '        If sdwEnrollNumber <> iLastEnrollNumber Then 'identify whether the user information(except fingerprint templates) has been uploaded
    '            If Uc_communication1.axCZKEM1.SSR_SetUserInfo(Uc_communication1.iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled) Then 'upload user information to the device
    '                Uc_communication1.axCZKEM1.SetUserTmpExStr(Uc_communication1.iMachineNumber, sdwEnrollNumber, idwFingerIndex, iflag, sTmpData) 'upload templates information to the device
    '            Else
    '                Uc_communication1.axCZKEM1.GetLastError(idwErrorCode)
    '                MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
    '                Cursor = Cursors.Default
    '                Uc_communication1.axCZKEM1.EnableDevice(Uc_communication1.iMachineNumber, True)
    '                Return
    '            End If
    '        Else 'the current fingerprint and the former one belongs the same user,that is ,one user has more than one template
    '            Uc_communication1.axCZKEM1.SetUserTmpExStr(Uc_communication1.iMachineNumber, sdwEnrollNumber, idwFingerIndex, iflag, sTmpData) 'upload tempates information to the memory
    '        End If
    '        iLastEnrollNumber = sdwEnrollNumber 'change the value of iLastEnrollNumber dynamicly
    '    Next
    'End If

    'Uc_communication1.axCZKEM1.BatchUpdate(Uc_communication1.iMachineNumber) 'upload all the information in the memory
    'Uc_communication1.axCZKEM1.RefreshData(Uc_communication1.iMachineNumber) 'the data in the device should be refreshed
    'Uc_communication1.axCZKEM1.EnableDevice(Uc_communication1.iMachineNumber, True)
    'Cursor = Cursors.Default
    'MsgBox("Successfully upload fingerprint templates in batches , " + "total:" + LV_dataDB.Items.Count.ToString(), MsgBoxStyle.Information, "Success")


    'End Sub

    'Sub gagal()
    '    If Uc_communication1.bIsConnected = False Then
    '        MsgBox("Please connect the device first", MsgBoxStyle.Exclamation, "Error")
    '        Return
    '    End If
    '    If LV_dataDB.Items.Count = 0 Then
    '        MsgBox("There is no data to upload!", MsgBoxStyle.Exclamation, "Error")
    '        Return
    '    End If
    '    Dim idwErrorCode As Integer

    '    Dim sdwEnrollNumber As String = ""
    '    Dim sName As String = ""
    '    Dim sPassword As String = ""
    '    Dim iPrivilege As Integer
    '    Dim idwFingerIndex As Integer
    '    Dim sTmpData As String = ""
    '    Dim sEnabled As String = ""
    '    Dim bEnabled As Boolean = False
    '    Dim iflag As Integer

    '    Dim iUpdateFlag As Integer = 1
    '    Dim lvItem As New ListViewItem

    '    Cursor = Cursors.WaitCursor
    '    Uc_communication1.axCZKEM1.EnableDevice(Uc_communication1.iMachineNumber, False)

    '    If Uc_communication1.axCZKEM1.BeginBatchUpdate(Uc_communication1.iMachineNumber, iUpdateFlag) Then 'create memory space for batching data
    '        Dim iLastEnrollNumber As Integer = 0 'the former enrollnumber you have upload(define original value as 0)
    '        For Each lvItem In LV_dataDB.Items
    '            sdwEnrollNumber = Convert.ToInt32(lvItem.SubItems(0).Text.Trim())
    '            sName = lvItem.SubItems(2).Text.Trim()
    '            idwFingerIndex = Convert.ToInt32(lvItem.SubItems(6).Text.Trim())
    '            sTmpData = lvItem.SubItems(7).Text.Trim()
    '            iPrivilege = Convert.ToInt32(lvItem.SubItems(4).Text.Trim())
    '            sPassword = lvItem.SubItems(5).Text.Trim()
    '            sEnabled = lvItem.SubItems(9).Text.Trim()
    '            'iflag = Convert.ToInt32(lvItem.SubItems(8).Text.Trim().ToString)

    '            If sEnabled = "true" Then
    '                bEnabled = True
    '            Else
    '                bEnabled = False
    '            End If

    '            If sdwEnrollNumber <> iLastEnrollNumber Then 'identify whether the user information(except fingerprint templates) has been uploaded
    '                If Uc_communication1.axCZKEM1.SSR_SetUserInfo(Uc_communication1.iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled) Then 'upload user information to the device
    '                    Uc_communication1.axCZKEM1.SetUserTmpExStr(Uc_communication1.iMachineNumber, sdwEnrollNumber, idwFingerIndex, iflag, sTmpData) 'upload templates information to the device
    '                Else
    '                    Uc_communication1.axCZKEM1.GetLastError(idwErrorCode)
    '                    MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
    '                    Cursor = Cursors.Default
    '                    Uc_communication1.axCZKEM1.EnableDevice(Uc_communication1.iMachineNumber, True)
    '                    Return
    '                End If
    '            Else 'the current fingerprint and the former one belongs the same user,that is ,one user has more than one template
    '                Uc_communication1.axCZKEM1.SetUserTmpExStr(Uc_communication1.iMachineNumber, sdwEnrollNumber, idwFingerIndex, iflag, sTmpData) 'upload tempates information to the memory
    '            End If
    '            iLastEnrollNumber = sdwEnrollNumber 'change the value of iLastEnrollNumber dynamicly
    '        Next
    '    End If

    '    Uc_communication1.axCZKEM1.BatchUpdate(Uc_communication1.iMachineNumber) 'upload all the information in the memory
    '    Uc_communication1.axCZKEM1.RefreshData(Uc_communication1.iMachineNumber) 'the data in the device should be refreshed
    '    Uc_communication1.axCZKEM1.EnableDevice(Uc_communication1.iMachineNumber, True)
    '    Cursor = Cursors.Default
    '    MsgBox("Successfully upload fingerprint templates in batches , " + "total:" + LV_dataDB.Items.Count.ToString(), MsgBoxStyle.Information, "Success")
    'End Sub

End Class

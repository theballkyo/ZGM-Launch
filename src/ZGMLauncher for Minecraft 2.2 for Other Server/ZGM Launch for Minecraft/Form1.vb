Imports System
Imports System.IO
Imports System.Net
Imports Ionic.Zip
Imports System.Threading
Imports System.Security.Principal
Imports System.Timers
Imports ZGMLaunch
Imports System.Text.RegularExpressions

Public Class Form1
    Dim keyvalue(10) As String
    Dim keyname(10) As String
    Dim keyvaluesv(10) As String
    Dim keynamesv(10) As String
    Dim errorcheck As String
    Dim file_data(3, 50000) As String
    Dim file_delete(3, 999) As String
    Dim fn As String
    Dim path_file As String
    Dim md5f As String
    Dim server As String = "http://mc.zone-gamer.th.ht/patch/"
    Public Shared ProgramFilesPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\"
    Public Shared path As String = Application.StartupPath + "\"
    Public Shared server_file_name As String = "zgm"
    Public Shared UrlAuth As String = ""
    Delegate Sub ChangeTextsSafe(ByVal length As Long, ByVal position As Integer, ByVal speed As Double, ByVal filename As String)
    Delegate Sub DownloadCompleteSafe(ByVal cancelled As Boolean)
    Delegate Sub showform()
    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
         Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, _
         ByVal lpKeyName As String, ByVal lpString As String, _
        ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpDefault As String, _
    ByVal lpReturnedString As String, ByVal nSize As Int32, _
    ByVal lpFileName As String) As Int32

    Public Overloads Sub ReadINIFile(ByVal INIPath As String, _
                                      ByVal SectionName As String, ByVal KeyName As String(), _
                                      ByRef KeyValue As String())
        Dim Length As Integer
        Dim strData As String
        strData = Space$(1024)
        For i As Integer = 1 To KeyName.Length - 1
            If KeyName(i) <> "" Then
                'This will read the ini file using Section Name and Key
                Length = GetPrivateProfileString(SectionName, KeyName(i), KeyValue(i), _
                                            strData, strData.Length, LTrim(RTrim((INIPath))))
                If Length > 0 Then
                    KeyValue(i) = strData.Substring(0, Length)
                Else
                    KeyValue(i) = ""
                End If
            End If
        Next
    End Sub

    Public Sub INIWrite(ByVal INIPath As String, ByVal SectionName As String, _
ByVal KeyName As String, ByVal TheValue As String)
        Call WritePrivateProfileString(SectionName, KeyName, TheValue, INIPath)
    End Sub


    Public Sub DownloadComplete(ByVal cancelled As Boolean)
        ' Me.txtFileName.Enabled = True
        ' Me.btnDownload.Enabled = True
        ' Me.btnCancel.Enabled = False

        If cancelled Then

            Me.Label4.Text = "Cancelled"

            'MessageBox.Show("ยกเลิกการ Download", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            Me.Label4.Text = "Successfully downloaded"

            MessageBox.Show("Successfully downloaded!", "All OK", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If

        Me.ProgressBar1.Value = 0
        ' Me.Label5.Text = "Downloading: "
        'Me.Label6.Text = "Save to: "
        Me.Label3.Text = "File size: "
        Me.Label2.Text = "Download speed: "
        Me.Label4.Text = ""

    End Sub

    Public Sub ChangeTexts(ByVal length As Long, ByVal position As Integer, ByVal speed As Double, ByVal filename As String)

        Me.Label3.Text = "File Name : " & filename & " - File Size: " & Math.Round((length / 1024), 2) & " KB"

        'Me.Label5.Text = "Downloading: " & Me.txtFileName.Text

        Me.Label4.Text = "Downloaded " & Math.Round((position / 1024), 2) & " KB of " & Math.Round((length / 1024), 2) & "KB"

        If speed = -1 Then
            Me.Label2.Text = "Speed: calculating..."
        Else
            Me.Label2.Text = "Speed: " & Math.Round((speed / 1024), 2) & " KB/s"
        End If
        If length > 0 Then
            Me.ProgressBar1.Maximum = length
            Me.ProgressBar1.Value = position
        Else
            Me.Label3.Text = "กำลังดาวน์โหลด ... - ไม่สามารถค้นหาขนาดของไฟล์ได้"
            'Me.Label2.Text = "กำลังดาวน์โหลด - ไม่สามารถค้นหาขนาดของไฟล์ได้"
        End If


    End Sub
    Public Sub showf()
        Dim frm As Form2
        If keyvalue(6) = "true" Then
            frm = New Form2("online")
            frm.Show()
        Else
            frm = New Form2("offline")
            frm.Show()
        End If

    End Sub
    Private Sub check()
        'valini(keyname, keyvalue, keyvaluesv)
        If File.Exists(path & "server.ini") Then ' Check Server.ini file

            If (My.Settings.version < keyvaluesv(1)) Then 'Checkversion launch
                MsgBox("ตรวจพบเวอร์ชั่นโปรแกรมใหม่")
                dl(keyvalue(3) & "zgmlaunch.zip", "zgmlaunch.zip")

            ElseIf (keyvalue(2) < keyvaluesv(2)) Then 'Checkversion game
                Dim version As Integer = keyvalue(2) + 1
                dl(keyvalue(3) & "zgmpatch" & version & ".zip", "zgmdl.zip")

            End If

            If (keyvaluesv(1) <> "") Then 'Startgame
                Dim formshow As New showform(AddressOf showf)
                Me.Invoke(formshow)

            End If
        End If

        Exit Sub
    End Sub

    Private Sub dl(ByVal urlfile, ByVal filename)

        'Crating the request and getting the response
        Dim theResponse As HttpWebResponse
        Dim theRequest As HttpWebRequest
        Try 'Checks if the file exist

            theRequest = WebRequest.Create(urlfile)
            theResponse = theRequest.GetResponse

        Catch ex As Exception

            MessageBox.Show("เกิดข้อผิดพลาดขณะ download file. Possibe causes:" & ControlChars.CrLf & _
                            "1) ไม่มีไฟล์ในเซิฟเวอร์" & ControlChars.CrLf & _
                            "2) เซิฟเวอร์ทำงานผิดพลาด(อาจล่มอยู่)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)

            Me.Invoke(cancelDelegate, True)
            errorcheck = "1"
            Exit Sub
        End Try

        Dim length As Long = theResponse.ContentLength 'Size of the response (in bytes)

        Dim safedelegate As New ChangeTextsSafe(AddressOf ChangeTexts)
        Me.Invoke(safedelegate, length, 0, 0, filename) 'Invoke the TreadsafeDelegate

        'If Not Directory.Exists() Then

        'End If

        Dim writeStream As New IO.FileStream(path + filename, IO.FileMode.Create)

        'Replacement for Stream.Position (webResponse stream doesn't support seek)
        Dim nRead As Integer

        'To calculate the download speed
        Dim speedtimer As New Stopwatch
        Dim currentspeed As Double = -1
        Dim readings As Integer = 0

        Do

            If BackgroundWorker1.CancellationPending Then 'If user abort download
                Exit Do
            End If

            speedtimer.Start()

            Dim readBytes(4095) As Byte
            Dim bytesread As Integer = theResponse.GetResponseStream.Read(readBytes, 0, 4096)

            nRead += bytesread

            Me.Invoke(safedelegate, length, nRead, currentspeed, filename)

            If bytesread = 0 Then Exit Do

            writeStream.Write(readBytes, 0, bytesread)

            speedtimer.Stop()

            readings += 1
            If readings >= 5 Then 'For increase precision, the speed it's calculated only every five cicles
                currentspeed = 20480 / (speedtimer.ElapsedMilliseconds / 1000)
                speedtimer.Reset()
                readings = 0
            End If
        Loop

        'Close the streams
        theResponse.GetResponseStream.Close()
        writeStream.Close()

        If Me.BackgroundWorker1.CancellationPending Then

            IO.File.Delete(path)

            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)

            Me.Invoke(cancelDelegate, True)

            Exit Sub

        End If
        If (filename = "zgmlaunch.zip" Or filename = server_file_name + "\.clean\clean.zip" Or filename = server_file_name + "\.bigpatch\patch.zip" Or InStr(filename, server_file_name + "\.bigpatch\")) Then
            unzip(filename)
        End If
    End Sub
    Private Sub unzip(ByVal filename)
        'Unzip
        Using zip As ZipFile = ZipFile.Read(path + filename)

            If (filename = server_file_name + "\.clean\clean.zip") Then

                zip.ExtractAll(path + server_file_name + "\.clean\", Ionic.Zip.ExtractExistingFileAction.OverwriteSilently)

                Dim p As New Process
                p.StartInfo.FileName = path + server_file_name + "\.clean\cleanmain.exe"
                p.Start()
                If Not (p Is Nothing) Then
                    p.WaitForExit()
                End If
                check2()

            ElseIf (InStr(filename, server_file_name + "\.bigpatch\")) Then

                zip.ExtractAll(path + server_file_name + "\.bigpatch\", Ionic.Zip.ExtractExistingFileAction.OverwriteSilently)
                Dim p As New Process
                Dim filename2 As String = Replace(filename, ".zip", ".exe")
                Dim filepath As String = """" + path + filename2 + """"
                p.StartInfo.FileName = filepath
                'p.WaitForExit()
                p.Start()
                If Not (p Is Nothing) Then
                    p.WaitForExit()
                End If
            Else
                zip.ExtractAll(path, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently)
            End If

        End Using

        If (filename = "zgmdl.zip") Then
            'INIWrite(path & "config.ini", "client", "versionmc", keyvalue(2) + 1)
            File.Delete(path & "zgmdl.zip")
            check()
        End If

        If (filename = "zgmclient.zip") Then
            'INIWrite(path & "config.ini", "client", "versionmc", keyvaluesv(4))
            File.Delete(path & "zgmclient.zip")
            check()
        End If

        If (filename = "zgmlaunch.zip") Then
            'INIWrite(path & "config.ini", "client", "versionlaunch", keyvaluesv(1))
            File.Delete(path & "zgmlaunch.zip")
            MsgBox("พบโปรแกรมเวอร์ชั่นใหม่" & ControlChars.CrLf & "โปรแกรมจะทำการ Restart !")
            Process.Start("update.exe")
            End
        End If



    End Sub

    Private Sub closeme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeme.Click
        If BackgroundWorker1.IsBusy <> True Then
        Else
            BackgroundWorker1.CancelAsync()
        End If
        If BackgroundWorker2.IsBusy <> True Then
        Else
            BackgroundWorker2.CancelAsync()
        End If
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://mc.zone-gamer.th.ht/launchnew")
        AddHandler WebBrowser1.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        'Label1.Text = New System.Text.UTF7Encoding().GetString(Convert.FromBase64String("qTIwMTIgWkdNTGF1bmNoIDEuMC4yIERldmVsb3BlZCBieSBUaGViYWxsa3lv"))
        Label3.Text = ""
        Label4.Text = ""
        Label1.Text = "© ZGMLauncher " + My.Settings.fullversion + " :: ZGMLibrary " + ZGM.GetVersion() + " Developed by Theballkyo"
        'Load setting form config.ini 
        Loadsetting()

        ZGM.LockFile(path & server_file_name)
    End Sub
    Private Sub valini(ByRef keyname, ByRef keyvalue)
        keyname(1) = "DirServer"
        keyname(2) = "title"
        keyname(3) = "dlserver"
        keyname(4) = "UrlAuth"
        keyname(5) = "UrlNews"
        keyname(6) = "OpenAuth"
        ReadINIFile(path + "config.ini", "client", keyname, keyvalue)
        'ReadINIFile(path + "server.ini", "server", keyname, keyvaluesv)
    End Sub
    Private Sub Loadsetting()
        'ตัวแปร keyvalue
        '@keyvalue(1) = "DirServer"
        '@keyvalue(2) = "title"
        '@keyvalue(3) = "dlserver"
        '@keyvalue(4) = "UrlAuth"
        '@keyvalue(5) = "UrlNews"
        '@keyvalue(6) = "OpenAuth"
        valini(keyname, keyvalue)
        server_file_name = keyvalue(1)
        Me.Text = keyvalue(2) + " :: Version " + My.Settings.fullversion
        server = keyvalue(3)
        UrlAuth = keyvalue(4)
        If keyvalue(5) = "" Then
            WebBrowser1.Navigate("http://mc.zone-gamer.th.ht/freelauncher")
        Else
            WebBrowser1.Navigate(keyvalue(5))
        End If
    End Sub

    Private Sub startgame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startgame.Click
        'If File.Exists(path & "server.ini") Then
        'File.Delete(path & "server.ini")
        'End If
        startgame.Enabled = False
        'dlgame.Enabled = False
        'valini(keyname, keyvalue, keyvaluesv)
        If BackgroundWorker1.IsBusy <> True Then
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub PageWaiter(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        If WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
            WebBrowser1.Visible = True
            RemoveHandler WebBrowser1.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'reset
        errorcheck = "0"

        'Create Folder file
        If Not Directory.Exists(path & server_file_name) Then
            Directory.CreateDirectory(path & server_file_name)
        End If

        'Update XML in Server
        ZGM.UpdateXML(server)

        'valini(keyname, keyvalue, keyvaluesv)
        dl(server & "zgm_patch.xml", "patchlist.xml")
        If errorcheck = "1" Then
            MsgBox("มีข้อผิดพลาดขณะทำการตรวจสอบไฟล์ กรุณาลองใหม่", MsgBoxStyle.Critical)
            Exit Sub
        End If
        check2()
    End Sub
    Public Sub check2()

        'MsgBox(CalcMD5((path + "test.xml")))
        Call xml_read.file_data_xml(path + "patchlist.xml", file_data)
        ' Get bounds of the array.
        Dim bound0 As Integer = file_data.GetUpperBound(0)
        Dim bound1 As Integer = file_data.GetUpperBound(1)

        'Check program update
        'Dim zgmversion = file_data(3, 0)
        Dim sv_ver As String = ZGM.CheckUpdate(server_file_name)
        If Regex.IsMatch(sv_ver, "^[0-9]+$") Then
            If My.Settings.version < sv_ver Then
                dl("http://dl1.zone-gamer.th.ht/mc/zgmlaunch.zip", "zgmlaunch.zip")
                If errorcheck = "1" Then
                    MsgBox("มีข้อผิดพลาดขณะทำการตรวจสอบไฟล์ กรุณาลองใหม่", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
        End If
        ' Loop over all elements.

        For i As Integer = 0 To bound1
            '0,3 = zgmversion ; 0,i = path ; 1,i = filename ; 2,i = md5
            path_file = file_data(0, i)
            fn = file_data(1, i)
            md5f = file_data(2, i)

            If fn = "" Then
                Exit For
            End If
            'MsgBox(fn + " : " + md5f)

            'check file
            If File.Exists(path & server_file_name + "\" + path_file + "\" + fn) Then
                Dim md5_this = ZGM.CalcMD5(path & server_file_name + "\" + path_file + "\" + fn)
                md5_this = md5_this.ToLower
                'Check md5
                If md5_this <> md5f Then
                    'Download new file
                    dl(server + "game" + "/" + path_file + "/" + fn, server_file_name + "\" + path_file + "\" + fn)
                    If errorcheck = "1" Then
                        MsgBox("มีข้อผิดพลาดขณะทำการตรวจสอบไฟล์ กรุณาลองใหม่", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            Else
                'Download new file
                If path_file <> "" Then
                    If Not Directory.Exists(path & server_file_name + "\" + path_file) Then
                        Directory.CreateDirectory(path & server_file_name + "\" + path_file)
                    End If
                End If
                dl(server + "game" + "/" + path_file + "/" + fn, server_file_name + "\" + path_file + "\" + fn)
                If errorcheck = "1" Then
                    MsgBox("มีข้อผิดพลาดขณะทำการตรวจสอบไฟล์ กรุณาลองใหม่", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
        Next
        'MsgBox("ตรวจสอบสำเร็จแล้ว", MsgBoxStyle.OkOnly)


        '    For Each dt As String In file_data
        'If dt = "" Then
        'Exit For
        '   End If
        '  If CalcMD5((path + "test.xml")) <> dt(1) Then
        '' MsgBox("error")
        '  End If
        '  MsgBox(dt)
        ' Next
        'MsgBox(keyvalue(2))
    End Sub
    Private Sub bw1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        If e.Cancelled = True Then
            Me.Label2.Text = "Status : การทำงานถูกยกเลิกโดยผู้ใช้ !"
        ElseIf e.Error IsNot Nothing Then
            Me.Label2.Text = "Status : มีความผิดพลาด " & e.Error.Message
        ElseIf errorcheck = "1" Then
            Me.Label2.Text = "Status : มีความผิดพลาดขณะ Download files."

            'No Error ?
        Else
            Me.Label2.Text = "Status : Ready!"
            Dim formshow As New showform(AddressOf showf)
            Me.Invoke(formshow)
        End If
        resetui()

    End Sub

    Private Sub about_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles about.Click
        Form3.Show()
    End Sub
    Private Sub resetui()
        startgame.Enabled = True
        'dlgame.Enabled = True
        about.Enabled = True
        Label4.Text = ""
        Label3.Text = ""
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub startoffline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startoffline.Click
        Dim frm As Form2
        frm = New Form2("offline")
        frm.Show()
    End Sub


    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub
End Class





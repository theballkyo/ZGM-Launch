Imports System.IO
Imports System.Threading
Imports ZGMLaunch

Public Class Form2
    Dim path As String = Form1.path
    Dim server_file_name As String = Form1.server_file_name
    Dim mode As String
    Dim bit As String
    Dim status As Int32

    Public Sub New(ByVal m As String)
        InitializeComponent()
        mode = m
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim startIndex As Int32 = 85
        Dim endIndex As Int32 = startIndex + Len("PRESS HERE") - 3
        'RichTextBox1.Select(startIndex, endIndex)
        'RichTextBox1.SelectionColor = Color.Blue
        If (File.Exists(path & "start.bat")) Then
            File.Delete(path & "start.bat")
        End If
        If mode = "offline" Then
            TextBox1.Enabled = True
            TextBox2.Enabled = False
            TextBox2.Visible = False
            Label2.Visible = False

        End If
        Form1.WindowState = FormWindowState.Minimized
        ZGM.LockFile(path & server_file_name)
    End Sub

    Private Sub RichTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If (RichTextBox1.SelectionColor = Color.Blue) Then
        'MessageBox.Show("Press here!")
        'Process.Start("http://forums.zone-gamer.th.ht/")
        ' End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        status = 0
        Button1.Enabled = False
        If (mode = "online") Then
            If (TextBox1.TextLength >= 3 And TextBox1.TextLength <= 15) Then
                If (TextBox2.TextLength > 0) Then
                    If BackgroundWorker1.IsBusy <> True Then
                        BackgroundWorker1.RunWorkerAsync()
                    End If
                Else
                    MsgBox("กรุณากรอก Password")
                    Button1.Enabled = True
                End If
            Else
                MsgBox("กรุณากรอก Username มีความยาว 3-15 ตัวอักษร")
                Button1.Enabled = True
            End If

        Else
            If (TextBox1.TextLength >= 3 And TextBox1.TextLength <= 15) Then
                    If BackgroundWorker1.IsBusy <> True Then
                        BackgroundWorker1.RunWorkerAsync()
                    End If
                Else
                    MsgBox("กรุณากรอก Username มีความยาว 3-15 ตัวอักษร")
                    Button1.Enabled = True
                End If
        End If
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If (mode = "online") Then
            Dim keycode As String = ZGM.login_verify(Form1.UrlAuth, TextBox1.Text, TextBox2.Text)
            If (keycode = "spout") Then
                start_spout(TextBox1.Text, "1234")
            ElseIf (keycode = "true") Then
                startgame(keycode)
            ElseIf (keycode = "Bad login") Then
                status = 2
            End If
        Else
            startgame(0)
        End If
    End Sub
    Private Sub bw1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If (status = 1) Then
            Me.Close()
        ElseIf (status = 0) Then
            MsgBox("Username หรือ Password ผิดพลาด", MsgBoxStyle.Critical, "error")
            Button1.Enabled = True
        ElseIf (status = 2) Then
            MsgBox("การเชื่อมต่อกับเซิฟเวอร์ผิดพลาด", MsgBoxStyle.Critical, "error")
            Button1.Enabled = True
        End If
    End Sub
    Private Sub startgame(ByVal keycode As String)
        Dim username As String = TextBox1.Text

        Dim javapath As String = ZGM.FindJava()
        If (javapath = "0") Then
            MsgBox("ไม่พบ Java ในเครื่องคุณ กรุณาติดตั้ง Java7 ก่อนใช้งาน")
        ElseIf (javapath = "java6") Then
            MsgBox("ตรวจสอบพบ Java6 กรุณาอัพเดทเป็น Java7 ก่อนใช้งาน")
        End If

        If Not File.Exists(path & "start.bat") Then
            File.Delete(path & "start.bat")
            File.Create(path & "start.bat").Dispose()
        End If

        Dim swriter As StreamWriter
        swriter = File.AppendText(path & "start.bat")
        swriter.WriteLine("@echo off")
        swriter.WriteLine("set APPDATA=" & path & server_file_name)
        swriter.WriteLine("cd %APPDATA%")
        swriter.WriteLine(Chr(34) & javapath & Chr(34) & " -cp " & Chr(34) & "%APPDATA%\.minecraft/bin" & "/minecraft.jar" & ";%APPDATA%\.minecraft\bin/lwjgl.jar;%APPDATA%\.minecraft\bin/lwjgl_util.jar;%APPDATA%\.minecraft\bin/jinput.jar;" & Chr(34) & " " & Chr(34) & "-Djava.library.path=%APPDATA%\.minecraft\bin\natives" & Chr(34) & " -Xmx1024M -Xms512M net.minecraft.client.Minecraft " & username & " " & keycode & " ")
        swriter.WriteLine("pause")
        swriter.Close()

        Dim p As New ProcessStartInfo
        p.FileName = path & "start.bat"
        p.UseShellExecute = True
        ZGM.UnLockFile(path & server_file_name)
        Process.Start(p)
        Thread.Sleep(3500)
        File.Delete(path & "start.bat")

        status = 1
    End Sub
    Private Sub start_spout(ByVal username As String, ByVal password As String)
        Dim javapath As String = ZGM.FindJava()
        If (javapath = "0") Then
            MsgBox("ไม่พบ Java ในเครื่องคุณ กรุณาติดตั้ง Java7 ก่อนใช้งาน")
        ElseIf (javapath = "java6") Then
            MsgBox("ตรวจสอบพบ Java6 กรุณาอัพเดทเป็น Java7 ก่อนใช้งาน")
        End If

        If Not File.Exists(path & "start.bat") Then
            File.Delete(path & "start.bat")
            File.Create(path & "start.bat").Dispose()
        End If

        Dim swriter As StreamWriter
        swriter = File.AppendText(path & "start.bat")
        swriter.WriteLine("@echo off")
        swriter.WriteLine("set APPDATA=" & path & server_file_name)
        swriter.WriteLine("cd %APPDATA%")
        swriter.WriteLine(Chr(34) & javapath & Chr(34) & " -jar spoutstart.jar -pm -s 127.0.0.1 -nomd5 -u " & username & " -p " & password)
        swriter.WriteLine("pause")
        swriter.Close()

        Dim p As New ProcessStartInfo
        p.FileName = path & "start.bat"
        p.UseShellExecute = True
        ZGM.UnLockFile(path & server_file_name)
        Process.Start(p)
        Thread.Sleep(3500)
        File.Delete(path & "start.bat")

        status = 1
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''' Old Code ''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        If Not File.Exists(path & "start.bat") Then
            File.Delete(path & "start.bat")
            File.Create(path & "start.bat").Dispose()
        End If


        Dim swriter As StreamWriter
        swriter = File.AppendText(path & "start.bat")
        'swriter.WriteLine("echo off")
        swriter.WriteLine("set APPDATA=" & path & server_file_name)
        swriter.WriteLine("cd %APPDATA%")
        If Environment.GetEnvironmentVariable("java") = "" Then
            '64 Bit folder
            If File.Exists(Environment.GetEnvironmentVariable("ProgramW6432") & "\Java\jre7\bin\java.exe") Then
                swriter.WriteLine(Chr(34) & Environment.GetEnvironmentVariable("ProgramW6432") & "\Java\jre7\bin\javaw.exe" & Chr(34) & " -Xms512M -Xmx1024M -jar " & Chr(34) & "MinecraftSP.jar")
            Else
                '32 Bit folder
                MsgBox(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)") & "\Java\jre7\bin\java.exe")
                If File.Exists(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)") & "\Java\jre7\bin\java.exe") Then
                    swriter.WriteLine(Chr(34) & Environment.GetEnvironmentVariable("PROGRAMFILES(X86)") & "\Java\jre7\bin\javaw.exe" & Chr(34) & " -Xms512M -Xmx1024M -jar " & Chr(34) & "MinecraftSP.jar")
                End If
            End If


        Else
            swriter.WriteLine("javaw" & " -Xms512M -Xmx1024M -jar " & Chr(34) & "MinecraftSP.jar")
        End If
        swriter.WriteLine("javaw" & " -Xms512M -Xmx1024M -jar " & Chr(34) & "MinecraftSP.jar")
        'swriter.WriteLine(Chr(34) & "%ProgramFiles%\Java\jre7\bin\javaw.exe" & Chr(34) & " -Xms512M -Xmx1024M -jar " & Chr(34) & "MinecraftSP.jar")
        swriter.WriteLine("pause")
        swriter.Close()

        Dim p As New Process
        'Environment.SetEnvironmentVariable("APPDATA", path & server_file_name)
        p.StartInfo.FileName = "start.bat"
        'p.StartInfo.EnvironmentVariables.Add("APPDATA", path & server_file_name)
        'p.StartInfo.UseShellExecute = True
        'p.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        p.Start()
        'p.WaitForExit()
        'Shell(path & "start.bat")
        Thread.Sleep(2000)
        'File.Delete(path & "start.bat")

    End Sub
    Private Sub bw2_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        Me.Close()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("หากเริ่มเกมไม่ได้ให้ทำการติดตั้ง Java เวอร์ชั่น 7 ขึ้นไปก่อน", MsgBoxStyle.Information, "Start")
        'Button1.Visible = False
        If BackgroundWorker2.IsBusy <> True Then
            BackgroundWorker2.RunWorkerAsync()

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (TextBox1.TextLength >= 3 And TextBox1.TextLength <= 15) Then
            If BackgroundWorker3.IsBusy <> True Then
                BackgroundWorker3.RunWorkerAsync()
            End If
        Else
            MsgBox("กรุณากรอก Username มีความยาว 3-15 ตัวอักษร")
        End If

    End Sub
    Private Sub BackgroundWorker3_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        If Not File.Exists(path & "start.bat") Then
            File.Delete(path & "start.bat")
            File.Create(path & "start.bat").Dispose()
        End If
        Dim username As String = TextBox1.Text

        Dim swriter As StreamWriter
        swriter = File.AppendText(path & "start.bat")

        'swriter.WriteLine("echo off")

        swriter.WriteLine("set APPDATA=" & path & server_file_name)
        swriter.WriteLine("cd %APPDATA%")
        If Environment.GetEnvironmentVariable("java") = "" Then
            '64 Bit folder
            If File.Exists(Environment.GetEnvironmentVariable("ProgramW6432") & "\Java\jre7\bin\java.exe") Then
                swriter.WriteLine(Chr(34) & Environment.GetEnvironmentVariable("ProgramW6432") & "\Java\jre7\bin\java.exe" & Chr(34) & " -cp " & Chr(34) & "%APPDATA%\.minecraft/bin" & "/minecraft.jar" & ";%APPDATA%\.minecraft\bin/lwjgl.jar;%APPDATA%\.minecraft\bin/lwjgl_util.jar;%APPDATA%\.minecraft\bin/jinput.jar;" & Chr(34) & " " & Chr(34) & "-Djava.library.path=%APPDATA%\.minecraft\bin\natives" & Chr(34) & " -Xmx1024M -Xms512M net.minecraft.client.Minecraft " & username & " 123456:0 ")
                ' swriter.WriteLine(Chr(34) & Environment.GetEnvironmentVariable("ProgramW6432") & "\Java\jre7\bin\javaw.exe" & Chr(34) & " -Xms512M -Xmx1024M -jar " & Chr(34) & "MinecraftSP.jar")
            Else
                '32 Bit folder
                MsgBox(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)") & "\Java\jre7\bin\java.exe")
                If File.Exists(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)") & "\Java\jre7\bin\java.exe") Then
                    swriter.WriteLine(Chr(34) & Environment.GetEnvironmentVariable("PROGRAMFILES(X86)") & "\Java\jre7\bin\java.exe" & Chr(34) & " -cp " & Chr(34) & "%APPDATA%\.minecraft/bin" & "/minecraft.jar" & ";%APPDATA%\.minecraft\bin/lwjgl.jar;%APPDATA%\.minecraft\bin/lwjgl_util.jar;%APPDATA%\.minecraft\bin/jinput.jar;" & Chr(34) & " " & Chr(34) & "-Djava.library.path=%APPDATA%\.minecraft\bin\natives" & Chr(34) & " -Xmx1024M -Xms512M net.minecraft.client.Minecraft " & username & " 123456:0 ")
                End If
            End If

        Else
            swriter.WriteLine("java" & Chr(34) & " -cp " & Chr(34) & "%APPDATA%\.minecraft/bin" & "/minecraft.jar" & ";%APPDATA%\.minecraft\bin/lwjgl.jar;%APPDATA%\.minecraft\bin/lwjgl_util.jar;%APPDATA%\.minecraft\bin/jinput.jar;" & Chr(34) & " " & Chr(34) & "-Djava.library.path=%APPDATA%\.minecraft\bin\natives" & Chr(34) & " -Xmx1024M -Xms512M net.minecraft.client.Minecraft " & username & " 123456:0 ")
        End If
        swriter.WriteLine("java" & Chr(34) & " -cp " & Chr(34) & "%APPDATA%\.minecraft/bin" & "/minecraft.jar" & ";%APPDATA%\.minecraft\bin/lwjgl.jar;%APPDATA%\.minecraft\bin/lwjgl_util.jar;%APPDATA%\.minecraft\bin/jinput.jar;" & Chr(34) & " " & Chr(34) & "-Djava.library.path=%APPDATA%\.minecraft\bin\natives" & Chr(34) & " -Xmx1024M -Xms512M net.minecraft.client.Minecraft " & username & " 123456:0 ")


        'swriter.WriteLine(Chr(34) & "%ProgramFiles%\Java\jre7\bin\javaw.exe" & Chr(34) & " -Xms512M -Xmx1024M -jar " & Chr(34) & "MinecraftSP.jar")
        swriter.WriteLine("pause")
        swriter.Close()

        Dim p As New Process
        'Environment.SetEnvironmentVariable("APPDATA", path & server_file_name)
        p.StartInfo.FileName = "start.bat"
        'p.StartInfo.EnvironmentVariables.Add("APPDATA", path & server_file_name)
        'p.StartInfo.UseShellExecute = True
        'p.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        p.Start()
        'p.WaitForExit()
        'Shell(path & "start.bat")
        Thread.Sleep(2000)
        'File.Delete(path & "start.bat")
    End Sub
    Private Sub bw3_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker3.RunWorkerCompleted
        Me.Close()
    End Sub
End Class
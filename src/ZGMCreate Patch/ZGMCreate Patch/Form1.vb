Imports System.IO
Imports Ionic.Zip
Imports System.Text
Imports System.Threading

Public Class Form1

    Dim selectpath As String
    Dim EntriesSaved As Integer = 0
    Dim EntriesTotal As Integer = 0
    Dim CompressionLevel As Integer = 6
    Dim FileSize As Long = 0
    Dim TotalBytes As ULong = 0
    Dim TotalSaves As Long = 0
    Dim percentage As Double = 0
    Dim percentage2 As Double = 0
    Dim i9 As Integer = 0
    Delegate Sub ZipSaveTextSafe(ByVal e)


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        FolderBrowserDialog1.ShowDialog()
        selectpath = FolderBrowserDialog1.SelectedPath
        If selectpath <> Nothing Then
            Dim file = IO.Directory.GetFiles(selectpath, "*.*", SearchOption.AllDirectories)
            Dim arrayList As New System.Collections.ArrayList()
            For Each filenm As String In file
                Dim filename As Array
                filename = Split(filenm, selectpath & "\")
                For Each filename2 In filename
                    If filename2 <> Nothing Then
                        ListBox1.Items.Add(filename2)
                    End If
                Next
            Next
            selectpath = selectpath & "\"
        End If
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = "5"
        TextBox2.Text = ZGMConfig.ZGMLaunchVersion
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim selecteditems = ListBox1.SelectedItems

        While ListBox1.SelectedItems.Count <> 0
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End While

        'ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim selecteditems = ListBox2.SelectedItems

        While ListBox2.SelectedItems.Count <> 0
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End While
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox3.Items.Add(TextBox1.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim selecteditems = ListBox3.SelectedItems

        While ListBox3.SelectedItems.Count <> 0
            ListBox3.Items.Remove(ListBox3.SelectedItem)
        End While
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Label6.Text = "กำลังทำงาน ..."
        TotalSaves = 0
        FileSize = 0
        TotalBytes = 0
        ComboBox1.Enabled = False
        ListBox1.Enabled = False
        ListBox2.Enabled = False
        ListBox3.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False

        CompressionLevel = ComboBox1.SelectedIndex + 1
        If BackgroundWorker1.IsBusy <> True Then
            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

    Private Sub CreateZIP()

        Dim fn_in_blacklist As Boolean = False
        Dim box1items = ListBox1.Items
        Dim box2items = ListBox2.Items
        Dim box3items = ListBox3.Items
        Dim fn
        Dim paths
        Dim new_path As String = ""
        Dim num_paths
        Dim zip As ZipFile = New ZipFile
        zip.AlternateEncodingUsage = ZipOption.Always
        zip.AlternateEncoding = Encoding.UTF8
        zip.Password = "!#Zone-Gamer0Launcher@#!1"
        zip.Encryption = EncryptionAlgorithm.WinZipAes256
        zip.CompressionLevel = CompressionLevel

        For i = 1 To box1items.Count
            If box3items.Count > 0 Then
                fn_in_blacklist = False
                For i2 = 1 To box3items.Count
                    Dim filename = Split(box3items(i2 - 1), "*")
                    For Each fn In filename
                        If fn_in_blacklist <> True Then
                            If fn <> Nothing Then
                                If box1items(i - 1).ToString.ToLower().Contains(fn.ToLower()) Then
                                    'Debug
                                    'MsgBox(box1items(i - 1) & " - " & fn & " - True")
                                    fn_in_blacklist = True
                                    'Exit For
                                Else
                                    'Debug
                                    'MsgBox(box1items(i - 1) & " - " & fn & " - False")
                                    fn_in_blacklist = False
                                    Exit For
                                End If
                            End If
                        End If
                    Next
                Next
                If fn_in_blacklist <> True Then
                    TotalBytes += New FileInfo(selectpath & box1items(i - 1)).Length
                    zip.AddFile(selectpath & box1items(i - 1))
                    'MsgBox(box1items(i - 1) & " - " & "True")
                End If
            Else
                paths = Split(box1items(i - 1), "\")
                num_paths = UBound(paths)
                new_path = ""
                For i3 = 0 To num_paths - 1
                    new_path += "\" & paths(i3)
                Next
                TotalBytes += New FileInfo(selectpath & box1items(i - 1)).Length
                zip.AddFile(selectpath & box1items(i - 1), new_path)
            End If
        Next
        EntriesTotal = zip.EntryFileNames.Count
        EntriesSaved = 0
        MsgBox(TotalBytes)
        AddHandler zip.SaveProgress, AddressOf ZipSaveProgress
        zip.Save("test.zip")

    End Sub
    Private Sub ZipSaveProgress(ByVal sender As Object, ByVal e As SaveProgressEventArgs)
        BeginInvoke(New ZipSaveTextSafe(AddressOf ZipSaveText), e)
    End Sub
    Private Sub ZipSaveText(ByVal e As SaveProgressEventArgs)
        If e.EventType = ZipProgressEventType.Saving_AfterWriteEntry Then
            EntriesSaved += 1

        End If

        If e.EventType = ZipProgressEventType.Saving_BeforeWriteEntry Then
            If FileSize > 0 Then
                TotalSaves += FileSize
                FileSize = 0
            End If
        End If

        If e.EventType = ZipProgressEventType.Saving_EntryBytesRead Then
            progressfilename.Text = String.Format("{1} of {2} files - Zipping : {0}", e.CurrentEntry.FileName, EntriesSaved + 1, EntriesTotal)
        End If

        progressbytes.Text = e.BytesTransferred & " bytes of " & e.TotalBytesToTransfer & " bytes."

        If e.TotalBytesToTransfer > 0 Then
            FileSize = e.TotalBytesToTransfer
            percentage = (e.BytesTransferred / e.TotalBytesToTransfer) * 100
            percentage2 = ((TotalSaves + e.BytesTransferred) / TotalBytes) * 100
        End If

        ProgressBar1.Value = percentage
        ProgressBar2.Value = percentage2
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If BackgroundWorker1.IsBusy = True Then
            BackgroundWorker1.CancelAsync()
        End If
        End
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        CreateZIP()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ComboBox1.Enabled = True
        ListBox1.Enabled = True
        ListBox2.Enabled = True
        ListBox3.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Label6.Text = "Ready!"
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'minimize the form
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            Me.NotifyIcon1.Visible = True
            Me.WindowState = FormWindowState.Minimized
            Me.NotifyIcon1.ShowBalloonTip(500)
        End If
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        NotifyIcon1.Visible = False
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class

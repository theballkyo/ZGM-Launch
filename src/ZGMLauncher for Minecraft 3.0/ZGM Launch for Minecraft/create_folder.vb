Module create_folder
    Private Declare Function MakeSureDirectoryPathExists _
    Lib "imagehlp.dll" (ByVal lpPath As String) As Boolean

    Sub CreateDirectoryStructure()
        On Error GoTo 1
        MakeSureDirectoryPathExists("C:\FolderA\FolderB\FolderC\FolderD\")
        Exit Sub
1:      MsgBox("Error " & Err.Number & vbLf & Err.Description, 64)
    End Sub
End Module

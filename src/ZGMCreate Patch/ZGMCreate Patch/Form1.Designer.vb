<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.progressfilename = New System.Windows.Forms.Label()
        Me.progressbytes = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.ColumnWidth = 150
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 22)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(508, 498)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(526, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "เลือกโฟร์เดอร์เกม"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 560)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1122, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(650, 22)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox2.Size = New System.Drawing.Size(484, 316)
        Me.ListBox2.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(526, 63)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = ">>>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(526, 92)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "<<<"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(650, 386)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox3.Size = New System.Drawing.Size(484, 134)
        Me.ListBox3.TabIndex = 7
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(827, 357)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(79, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "เพิ่ม"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(650, 360)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 20)
        Me.TextBox1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(647, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "รายชื่อไฟล์ที่ไม่ต้องการ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "รายชื่อไฟล์"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(647, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "รายชื่อไฟล์ที่ไม่ต้องการ"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(912, 357)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "ลบ"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(526, 386)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(118, 23)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "สร้างแพช"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(526, 497)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(118, 23)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "Exit"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Level1 (fastest)", "Level2", "Level3", "Level4", "Level5", "Level6 (Default)", "Level7", "Level8", "Level9 (slowly)"})
        Me.ComboBox1.Location = New System.Drawing.Point(526, 135)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(118, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(526, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "CompressionLevel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(569, 421)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "สถานะ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(526, 442)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Ready!"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(108, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(217, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Developed By Theballkyo@Zone-Gamer 1.0"
        '
        'progressfilename
        '
        Me.progressfilename.AutoSize = True
        Me.progressfilename.Location = New System.Drawing.Point(12, 523)
        Me.progressfilename.Name = "progressfilename"
        Me.progressfilename.Size = New System.Drawing.Size(86, 13)
        Me.progressfilename.TabIndex = 21
        Me.progressfilename.Text = "progressfilename"
        '
        'progressbytes
        '
        Me.progressbytes.AutoSize = True
        Me.progressbytes.Location = New System.Drawing.Point(12, 544)
        Me.progressbytes.Name = "progressbytes"
        Me.progressbytes.Size = New System.Drawing.Size(72, 13)
        Me.progressbytes.TabIndex = 22
        Me.progressbytes.Text = "progressbytes"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(12, 589)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(1122, 23)
        Me.ProgressBar2.TabIndex = 23
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "Program is running"
        Me.NotifyIcon1.BalloonTipTitle = "ZGMCreate Patch"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "ZGMCreate Patch"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(526, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "ZGMLaunchVersion"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(526, 175)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(118, 20)
        Me.TextBox2.TabIndex = 25
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 617)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.progressbytes)
        Me.Controls.Add(Me.progressfilename)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1163, 656)
        Me.MinimumSize = New System.Drawing.Size(1163, 656)
        Me.Name = "Form1"
        Me.Text = "ZGMCreate Patch 1.0 - For Minecraft only"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents progressfilename As System.Windows.Forms.Label
    Friend WithEvents progressbytes As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox

End Class

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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.startgame = New System.Windows.Forms.Button()
        Me.about = New System.Windows.Forms.Button()
        Me.closeme = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.startoffline = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        '
        'startgame
        '
        Me.startgame.BackColor = System.Drawing.Color.Transparent
        Me.startgame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.startgame.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startgame.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.startgame.Location = New System.Drawing.Point(464, 32)
        Me.startgame.Name = "startgame"
        Me.startgame.Size = New System.Drawing.Size(115, 40)
        Me.startgame.TabIndex = 0
        Me.startgame.Text = "START GAME !"
        Me.startgame.UseVisualStyleBackColor = False
        '
        'about
        '
        Me.about.BackColor = System.Drawing.Color.Transparent
        Me.about.Cursor = System.Windows.Forms.Cursors.Hand
        Me.about.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.about.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.about.Location = New System.Drawing.Point(596, 32)
        Me.about.Name = "about"
        Me.about.Size = New System.Drawing.Size(115, 40)
        Me.about.TabIndex = 2
        Me.about.Text = "ABOUT"
        Me.about.UseVisualStyleBackColor = False
        '
        'closeme
        '
        Me.closeme.BackColor = System.Drawing.Color.Transparent
        Me.closeme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeme.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.closeme.Location = New System.Drawing.Point(596, 96)
        Me.closeme.Name = "closeme"
        Me.closeme.Size = New System.Drawing.Size(115, 40)
        Me.closeme.TabIndex = 3
        Me.closeme.Text = "EXIT"
        Me.closeme.UseVisualStyleBackColor = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.CausesValidation = False
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(13, 32)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(445, 327)
        Me.WebBrowser1.TabIndex = 4
        Me.WebBrowser1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "© ZGMLauncher 2.2 - ZGMLibrary 1.2 Developed by Theballkyo"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(464, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Status : Ready!"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(464, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label 3"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(464, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Label4"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Black
        Me.ProgressBar1.Location = New System.Drawing.Point(465, 273)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(247, 33)
        Me.ProgressBar1.TabIndex = 9
        '
        'startoffline
        '
        Me.startoffline.BackColor = System.Drawing.Color.Transparent
        Me.startoffline.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startoffline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.startoffline.Location = New System.Drawing.Point(465, 96)
        Me.startoffline.Name = "startoffline"
        Me.startoffline.Size = New System.Drawing.Size(115, 40)
        Me.startoffline.TabIndex = 10
        Me.startoffline.Text = "OFFLINE MODE"
        Me.startoffline.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(465, 326)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(247, 33)
        Me.ProgressBar2.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Aqua
        Me.Label5.Location = New System.Drawing.Point(461, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Downloaded XX MB of XXX MB"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Zone-Gamer Minecraft"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(516, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Login as Guest"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(518, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 35)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Guest"
        Me.Label7.UseCompatibleTextRendering = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.ZGM_Launch_for_Minecraft.My.Resources.Resources.mc21
        Me.ClientSize = New System.Drawing.Size(714, 363)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.startoffline)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.closeme)
        Me.Controls.Add(Me.about)
        Me.Controls.Add(Me.startgame)
        Me.ForeColor = System.Drawing.Color.Red
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ZGM launch for Minecraft V 2.2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents startgame As System.Windows.Forms.Button
    Friend WithEvents about As System.Windows.Forms.Button
    Friend WithEvents closeme As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents startoffline As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class

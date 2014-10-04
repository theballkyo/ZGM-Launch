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
        Me.startgame.ForeColor = System.Drawing.Color.Black
        Me.startgame.Location = New System.Drawing.Point(464, 32)
        Me.startgame.Name = "startgame"
        Me.startgame.Size = New System.Drawing.Size(115, 40)
        Me.startgame.TabIndex = 0
        Me.startgame.Text = "เริ่มเกม !!!"
        Me.startgame.UseVisualStyleBackColor = False
        '
        'about
        '
        Me.about.BackColor = System.Drawing.Color.Transparent
        Me.about.Cursor = System.Windows.Forms.Cursors.Hand
        Me.about.ForeColor = System.Drawing.Color.Black
        Me.about.Location = New System.Drawing.Point(596, 32)
        Me.about.Name = "about"
        Me.about.Size = New System.Drawing.Size(115, 40)
        Me.about.TabIndex = 2
        Me.about.Text = "เกี่ยวกับโปรแกรม"
        Me.about.UseVisualStyleBackColor = False
        '
        'closeme
        '
        Me.closeme.BackColor = System.Drawing.Color.Transparent
        Me.closeme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeme.ForeColor = System.Drawing.Color.Black
        Me.closeme.Location = New System.Drawing.Point(596, 96)
        Me.closeme.Name = "closeme"
        Me.closeme.Size = New System.Drawing.Size(115, 40)
        Me.closeme.TabIndex = 3
        Me.closeme.Text = "ออก"
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "© ZGMLauncher 2.2 - ZGMLibrary 1.2 Developed by Theballkyo"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(464, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Status : Ready !"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 381)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label 3"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(11, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Label4"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Black
        Me.ProgressBar1.Location = New System.Drawing.Point(465, 362)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(247, 33)
        Me.ProgressBar1.TabIndex = 9
        '
        'startoffline
        '
        Me.startoffline.BackColor = System.Drawing.Color.Transparent
        Me.startoffline.ForeColor = System.Drawing.Color.Black
        Me.startoffline.Location = New System.Drawing.Point(465, 96)
        Me.startoffline.Name = "startoffline"
        Me.startoffline.Size = New System.Drawing.Size(115, 40)
        Me.startoffline.TabIndex = 10
        Me.startoffline.Text = "เล่นคนเดียว"
        Me.startoffline.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.ZGM_Launch_for_Minecraft.My.Resources.Resources.mc21
        Me.ClientSize = New System.Drawing.Size(714, 398)
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
        Me.MaximumSize = New System.Drawing.Size(730, 437)
        Me.MinimumSize = New System.Drawing.Size(730, 437)
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

End Class

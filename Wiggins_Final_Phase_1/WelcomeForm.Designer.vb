<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeForm
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
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAccountAccess = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnQuit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnQuit.Location = New System.Drawing.Point(35, 407)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(898, 133)
        Me.btnQuit.TabIndex = 0
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnInfo.Location = New System.Drawing.Point(35, 49)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(898, 133)
        Me.btnInfo.TabIndex = 1
        Me.btnInfo.Text = "&General Store Information"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.btnInfo)
        Me.Panel1.Controls.Add(Me.btnAccountAccess)
        Me.Panel1.Controls.Add(Me.btnQuit)
        Me.Panel1.Location = New System.Drawing.Point(76, 196)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(955, 572)
        Me.Panel1.TabIndex = 2
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Magneto", 35.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblWelcome.Location = New System.Drawing.Point(87, 69)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(922, 56)
        Me.lblWelcome.TabIndex = 3
        Me.lblWelcome.Text = "Hello and Welcome to Cardio Plus!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wiggins_Final_Phase_1.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(48, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnAccountAccess
        '
        Me.btnAccountAccess.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAccountAccess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAccountAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountAccess.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAccountAccess.Location = New System.Drawing.Point(35, 232)
        Me.btnAccountAccess.Name = "btnAccountAccess"
        Me.btnAccountAccess.Size = New System.Drawing.Size(898, 133)
        Me.btnAccountAccess.TabIndex = 0
        Me.btnAccountAccess.Text = "&Account Access"
        Me.btnAccountAccess.UseVisualStyleBackColor = True
        '
        'WelcomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 748)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WelcomeForm"
        Me.Text = "Welcome Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAccountAccess As System.Windows.Forms.Button

End Class

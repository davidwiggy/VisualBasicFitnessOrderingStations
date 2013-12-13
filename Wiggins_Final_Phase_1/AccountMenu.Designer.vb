<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountMenu
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnInquiry = New System.Windows.Forms.Button()
        Me.btnTransAction = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAccountMenu = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.btnInquiry)
        Me.Panel1.Controls.Add(Me.btnTransAction)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Location = New System.Drawing.Point(77, 182)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(955, 546)
        Me.Panel1.TabIndex = 12
        '
        'btnInquiry
        '
        Me.btnInquiry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInquiry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInquiry.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInquiry.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnInquiry.Location = New System.Drawing.Point(35, 51)
        Me.btnInquiry.Name = "btnInquiry"
        Me.btnInquiry.Size = New System.Drawing.Size(898, 133)
        Me.btnInquiry.TabIndex = 0
        Me.btnInquiry.Text = "&Account Inquiry"
        Me.btnInquiry.UseVisualStyleBackColor = True
        '
        'btnTransAction
        '
        Me.btnTransAction.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTransAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTransAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransAction.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnTransAction.Location = New System.Drawing.Point(35, 218)
        Me.btnTransAction.Name = "btnTransAction"
        Me.btnTransAction.Size = New System.Drawing.Size(898, 133)
        Me.btnTransAction.TabIndex = 0
        Me.btnTransAction.Text = "Account &Transaction"
        Me.btnTransAction.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnBack.Location = New System.Drawing.Point(35, 385)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(898, 133)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wiggins_Final_Phase_1.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(48, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'lblAccountMenu
        '
        Me.lblAccountMenu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAccountMenu.AutoSize = True
        Me.lblAccountMenu.Font = New System.Drawing.Font("Magneto", 35.0!, System.Drawing.FontStyle.Bold)
        Me.lblAccountMenu.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblAccountMenu.Location = New System.Drawing.Point(318, 70)
        Me.lblAccountMenu.Name = "lblAccountMenu"
        Me.lblAccountMenu.Size = New System.Drawing.Size(401, 56)
        Me.lblAccountMenu.TabIndex = 14
        Me.lblAccountMenu.Text = "Account Menu"
        '
        'AccountMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 712)
        Me.Controls.Add(Me.lblAccountMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccountMenu"
        Me.Text = "AccountMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnInquiry As System.Windows.Forms.Button
    Friend WithEvents btnTransAction As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblAccountMenu As System.Windows.Forms.Label
End Class

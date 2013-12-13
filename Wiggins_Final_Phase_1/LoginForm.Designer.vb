<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSubmitLoginForm = New System.Windows.Forms.Button()
        Me.btnBackLoginForm = New System.Windows.Forms.Button()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblPin = New System.Windows.Forms.Label()
        Me.txtbxID = New System.Windows.Forms.TextBox()
        Me.txtbxPin = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wiggins_Final_Phase_1.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(48, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.btnSubmitLoginForm)
        Me.Panel1.Controls.Add(Me.btnBackLoginForm)
        Me.Panel1.Location = New System.Drawing.Point(64, 372)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(955, 349)
        Me.Panel1.TabIndex = 6
        '
        'btnSubmitLoginForm
        '
        Me.btnSubmitLoginForm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSubmitLoginForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSubmitLoginForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitLoginForm.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnSubmitLoginForm.Location = New System.Drawing.Point(35, 49)
        Me.btnSubmitLoginForm.Name = "btnSubmitLoginForm"
        Me.btnSubmitLoginForm.Size = New System.Drawing.Size(898, 133)
        Me.btnSubmitLoginForm.TabIndex = 0
        Me.btnSubmitLoginForm.Text = "&Submit"
        Me.btnSubmitLoginForm.UseVisualStyleBackColor = True
        '
        'btnBackLoginForm
        '
        Me.btnBackLoginForm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBackLoginForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBackLoginForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackLoginForm.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnBackLoginForm.Location = New System.Drawing.Point(35, 208)
        Me.btnBackLoginForm.Name = "btnBackLoginForm"
        Me.btnBackLoginForm.Size = New System.Drawing.Size(898, 133)
        Me.btnBackLoginForm.TabIndex = 0
        Me.btnBackLoginForm.Text = "&Back"
        Me.btnBackLoginForm.UseVisualStyleBackColor = True
        '
        'lblLogin
        '
        Me.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Magneto", 35.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogin.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblLogin.Location = New System.Drawing.Point(178, 59)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(716, 56)
        Me.lblLogin.TabIndex = 7
        Me.lblLogin.Text = "Login In To Your Account"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblID.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblID.Location = New System.Drawing.Point(158, 216)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(281, 17)
        Me.lblID.TabIndex = 8
        Me.lblID.Text = "Please enter your account id number:"
        '
        'lblPin
        '
        Me.lblPin.AutoSize = True
        Me.lblPin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPin.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblPin.Location = New System.Drawing.Point(208, 280)
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(231, 17)
        Me.lblPin.TabIndex = 8
        Me.lblPin.Text = "Please enter your account pin:"
        '
        'txtbxID
        '
        Me.txtbxID.Location = New System.Drawing.Point(463, 216)
        Me.txtbxID.Name = "txtbxID"
        Me.txtbxID.Size = New System.Drawing.Size(131, 20)
        Me.txtbxID.TabIndex = 9
        '
        'txtbxPin
        '
        Me.txtbxPin.Location = New System.Drawing.Point(463, 277)
        Me.txtbxPin.Name = "txtbxPin"
        Me.txtbxPin.Size = New System.Drawing.Size(131, 20)
        Me.txtbxPin.TabIndex = 9
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 715)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtbxPin)
        Me.Controls.Add(Me.txtbxID)
        Me.Controls.Add(Me.lblPin)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSubmitLoginForm As System.Windows.Forms.Button
    Friend WithEvents btnBackLoginForm As System.Windows.Forms.Button
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblPin As System.Windows.Forms.Label
    Friend WithEvents txtbxID As System.Windows.Forms.TextBox
    Friend WithEvents txtbxPin As System.Windows.Forms.TextBox
End Class

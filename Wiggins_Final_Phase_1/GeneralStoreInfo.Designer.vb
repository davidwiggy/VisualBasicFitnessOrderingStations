<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneralStoreInfo
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
        Me.btnRequest = New System.Windows.Forms.Button()
        Me.btnProductInfo = New System.Windows.Forms.Button()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.btnWelcome = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.lblGeneralStore = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnRequest)
        Me.Panel1.Controls.Add(Me.btnProductInfo)
        Me.Panel1.Controls.Add(Me.btnAccounts)
        Me.Panel1.Controls.Add(Me.btnWelcome)
        Me.Panel1.Controls.Add(Me.btnProfile)
        Me.Panel1.Location = New System.Drawing.Point(56, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(946, 587)
        Me.Panel1.TabIndex = 0
        '
        'btnRequest
        '
        Me.btnRequest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequest.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnRequest.Location = New System.Drawing.Point(22, 351)
        Me.btnRequest.Name = "btnRequest"
        Me.btnRequest.Size = New System.Drawing.Size(898, 100)
        Me.btnRequest.TabIndex = 6
        Me.btnRequest.Text = "&Request More Information"
        Me.btnRequest.UseVisualStyleBackColor = True
        '
        'btnProductInfo
        '
        Me.btnProductInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnProductInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductInfo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnProductInfo.Location = New System.Drawing.Point(22, 240)
        Me.btnProductInfo.Name = "btnProductInfo"
        Me.btnProductInfo.Size = New System.Drawing.Size(898, 100)
        Me.btnProductInfo.TabIndex = 5
        Me.btnProductInfo.Text = "Product &Information"
        Me.btnProductInfo.UseVisualStyleBackColor = True
        '
        'btnAccounts
        '
        Me.btnAccounts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccounts.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAccounts.Location = New System.Drawing.Point(22, 129)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(898, 100)
        Me.btnAccounts.TabIndex = 4
        Me.btnAccounts.Text = "Types of &Accounts"
        Me.btnAccounts.UseVisualStyleBackColor = True
        '
        'btnWelcome
        '
        Me.btnWelcome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWelcome.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnWelcome.Location = New System.Drawing.Point(22, 462)
        Me.btnWelcome.Name = "btnWelcome"
        Me.btnWelcome.Size = New System.Drawing.Size(898, 100)
        Me.btnWelcome.TabIndex = 3
        Me.btnWelcome.Text = "&Welcome Screen"
        Me.btnWelcome.UseVisualStyleBackColor = True
        '
        'btnProfile
        '
        Me.btnProfile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnProfile.Location = New System.Drawing.Point(22, 18)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(898, 100)
        Me.btnProfile.TabIndex = 2
        Me.btnProfile.Text = "Store &Profile"
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'lblGeneralStore
        '
        Me.lblGeneralStore.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGeneralStore.AutoSize = True
        Me.lblGeneralStore.Font = New System.Drawing.Font("Magneto", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneralStore.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblGeneralStore.Location = New System.Drawing.Point(226, 20)
        Me.lblGeneralStore.Name = "lblGeneralStore"
        Me.lblGeneralStore.Size = New System.Drawing.Size(726, 56)
        Me.lblGeneralStore.TabIndex = 4
        Me.lblGeneralStore.Text = "General Store Information"
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
        'GeneralStoreInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1003, 724)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblGeneralStore)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GeneralStoreInfo"
        Me.Text = "GeneralStoreInfo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnProfile As System.Windows.Forms.Button
    Friend WithEvents btnWelcome As System.Windows.Forms.Button
    Friend WithEvents lblGeneralStore As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRequest As System.Windows.Forms.Button
    Friend WithEvents btnProductInfo As System.Windows.Forms.Button
    Friend WithEvents btnAccounts As System.Windows.Forms.Button
End Class

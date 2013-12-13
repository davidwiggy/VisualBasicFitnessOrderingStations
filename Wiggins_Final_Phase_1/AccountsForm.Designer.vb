<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountsForm
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
        Me.rtxtbox1 = New System.Windows.Forms.RichTextBox()
        Me.lblAccounts = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGeneralStore = New System.Windows.Forms.Button()
        Me.picIogo = New System.Windows.Forms.PictureBox()
        Me.cmbAccountSelection = New System.Windows.Forms.ComboBox()
        Me.lblAccountSelection = New System.Windows.Forms.Label()
        Me.lblEligible = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.picIogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtxtbox1
        '
        Me.rtxtbox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rtxtbox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.rtxtbox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtbox1.Font = New System.Drawing.Font("Castellar", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.rtxtbox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rtxtbox1.Location = New System.Drawing.Point(31, 226)
        Me.rtxtbox1.Name = "rtxtbox1"
        Me.rtxtbox1.Size = New System.Drawing.Size(951, 235)
        Me.rtxtbox1.TabIndex = 8
        Me.rtxtbox1.Text = ""
        '
        'lblAccounts
        '
        Me.lblAccounts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAccounts.AutoSize = True
        Me.lblAccounts.Font = New System.Drawing.Font("Magneto", 35.0!, System.Drawing.FontStyle.Bold)
        Me.lblAccounts.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblAccounts.Location = New System.Drawing.Point(299, 3)
        Me.lblAccounts.Name = "lblAccounts"
        Me.lblAccounts.Size = New System.Drawing.Size(507, 56)
        Me.lblAccounts.TabIndex = 7
        Me.lblAccounts.Text = "Types of Accounts"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.btnGeneralStore)
        Me.Panel1.Location = New System.Drawing.Point(18, 401)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 287)
        Me.Panel1.TabIndex = 5
        '
        'btnGeneralStore
        '
        Me.btnGeneralStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneralStore.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnGeneralStore.Location = New System.Drawing.Point(40, 130)
        Me.btnGeneralStore.Name = "btnGeneralStore"
        Me.btnGeneralStore.Size = New System.Drawing.Size(898, 133)
        Me.btnGeneralStore.TabIndex = 0
        Me.btnGeneralStore.Text = "&General Store Information"
        Me.btnGeneralStore.UseVisualStyleBackColor = True
        '
        'picIogo
        '
        Me.picIogo.Image = Global.Wiggins_Final_Phase_1.My.Resources.Resources.Logo
        Me.picIogo.Location = New System.Drawing.Point(48, 45)
        Me.picIogo.Name = "picIogo"
        Me.picIogo.Size = New System.Drawing.Size(100, 125)
        Me.picIogo.TabIndex = 6
        Me.picIogo.TabStop = False
        '
        'cmbAccountSelection
        '
        Me.cmbAccountSelection.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbAccountSelection.FormattingEnabled = True
        Me.cmbAccountSelection.Items.AddRange(New Object() {"Retail Account", "Business Account"})
        Me.cmbAccountSelection.Location = New System.Drawing.Point(485, 125)
        Me.cmbAccountSelection.Name = "cmbAccountSelection"
        Me.cmbAccountSelection.Size = New System.Drawing.Size(121, 21)
        Me.cmbAccountSelection.TabIndex = 9
        '
        'lblAccountSelection
        '
        Me.lblAccountSelection.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAccountSelection.AutoSize = True
        Me.lblAccountSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountSelection.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblAccountSelection.Location = New System.Drawing.Point(435, 92)
        Me.lblAccountSelection.Name = "lblAccountSelection"
        Me.lblAccountSelection.Size = New System.Drawing.Size(230, 17)
        Me.lblAccountSelection.TabIndex = 10
        Me.lblAccountSelection.Text = "Please Select a Account Type:"
        '
        'lblEligible
        '
        Me.lblEligible.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEligible.AutoSize = True
        Me.lblEligible.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEligible.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblEligible.Location = New System.Drawing.Point(350, 171)
        Me.lblEligible.Name = "lblEligible"
        Me.lblEligible.Size = New System.Drawing.Size(408, 17)
        Me.lblEligible.TabIndex = 10
        Me.lblEligible.Text = "Every customer is only eligible for one type of account:"
        '
        'AccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 691)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblEligible)
        Me.Controls.Add(Me.lblAccountSelection)
        Me.Controls.Add(Me.cmbAccountSelection)
        Me.Controls.Add(Me.rtxtbox1)
        Me.Controls.Add(Me.lblAccounts)
        Me.Controls.Add(Me.picIogo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AccountsForm"
        Me.Text = "AccountsForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picIogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtxtbox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblAccounts As System.Windows.Forms.Label
    Friend WithEvents picIogo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnGeneralStore As System.Windows.Forms.Button
    Friend WithEvents cmbAccountSelection As System.Windows.Forms.ComboBox
    Friend WithEvents lblAccountSelection As System.Windows.Forms.Label
    Friend WithEvents lblEligible As System.Windows.Forms.Label
End Class

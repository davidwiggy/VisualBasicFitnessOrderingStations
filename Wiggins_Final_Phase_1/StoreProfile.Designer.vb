<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StoreProfile
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
        Me.btnGeneralStore = New System.Windows.Forms.Button()
        Me.lblMission = New System.Windows.Forms.Label()
        Me.rtxtbox1 = New System.Windows.Forms.RichTextBox()
        Me.picIogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picIogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.btnGeneralStore)
        Me.Panel1.Location = New System.Drawing.Point(48, 443)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 287)
        Me.Panel1.TabIndex = 0
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
        'lblMission
        '
        Me.lblMission.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMission.AutoSize = True
        Me.lblMission.Font = New System.Drawing.Font("Magneto", 35.0!, System.Drawing.FontStyle.Bold)
        Me.lblMission.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblMission.Location = New System.Drawing.Point(329, 45)
        Me.lblMission.Name = "lblMission"
        Me.lblMission.Size = New System.Drawing.Size(512, 56)
        Me.lblMission.TabIndex = 3
        Me.lblMission.Text = "Mission Statement"
        '
        'rtxtbox1
        '
        Me.rtxtbox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rtxtbox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.rtxtbox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtbox1.Font = New System.Drawing.Font("Castellar", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.rtxtbox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rtxtbox1.Location = New System.Drawing.Point(61, 112)
        Me.rtxtbox1.Name = "rtxtbox1"
        Me.rtxtbox1.Size = New System.Drawing.Size(951, 312)
        Me.rtxtbox1.TabIndex = 4
        Me.rtxtbox1.Text = ""
        '
        'picIogo
        '
        Me.picIogo.Image = Global.Wiggins_Final_Phase_1.My.Resources.Resources.Logo
        Me.picIogo.Location = New System.Drawing.Point(48, 45)
        Me.picIogo.Name = "picIogo"
        Me.picIogo.Size = New System.Drawing.Size(100, 125)
        Me.picIogo.TabIndex = 2
        Me.picIogo.TabStop = False
        '
        'StoreProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 693)
        Me.ControlBox = False
        Me.Controls.Add(Me.rtxtbox1)
        Me.Controls.Add(Me.lblMission)
        Me.Controls.Add(Me.picIogo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StoreProfile"
        Me.Text = "GeneralStoreInfo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picIogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnGeneralStore As System.Windows.Forms.Button
    Friend WithEvents picIogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblMission As System.Windows.Forms.Label
    Friend WithEvents rtxtbox1 As System.Windows.Forms.RichTextBox
End Class

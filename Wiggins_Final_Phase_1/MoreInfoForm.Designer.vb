<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoreInfoForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnGeneralStoreInfo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.rtxtComments = New System.Windows.Forms.RichTextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.cmboxService = New System.Windows.Forms.ComboBox()
        Me.cmboxState = New System.Windows.Forms.ComboBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblMessages = New System.Windows.Forms.Label()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblRequest = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlForm.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.btnGeneralStoreInfo)
        Me.Panel1.Location = New System.Drawing.Point(48, 588)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 379)
        Me.Panel1.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnSubmit.Location = New System.Drawing.Point(42, 68)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(898, 110)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnGeneralStoreInfo
        '
        Me.btnGeneralStoreInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneralStoreInfo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnGeneralStoreInfo.Location = New System.Drawing.Point(42, 207)
        Me.btnGeneralStoreInfo.Name = "btnGeneralStoreInfo"
        Me.btnGeneralStoreInfo.Size = New System.Drawing.Size(898, 110)
        Me.btnGeneralStoreInfo.TabIndex = 0
        Me.btnGeneralStoreInfo.Text = "&General Store Information"
        Me.btnGeneralStoreInfo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wiggins_Final_Phase_1.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(48, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'pnlForm
        '
        Me.pnlForm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlForm.Controls.Add(Me.rtxtComments)
        Me.pnlForm.Controls.Add(Me.txtPhone)
        Me.pnlForm.Controls.Add(Me.txtZip)
        Me.pnlForm.Controls.Add(Me.lblZip)
        Me.pnlForm.Controls.Add(Me.cmboxService)
        Me.pnlForm.Controls.Add(Me.cmboxState)
        Me.pnlForm.Controls.Add(Me.lblState)
        Me.pnlForm.Controls.Add(Me.txtAddress)
        Me.pnlForm.Controls.Add(Me.txtCity)
        Me.pnlForm.Controls.Add(Me.lblMessages)
        Me.pnlForm.Controls.Add(Me.lblSelection)
        Me.pnlForm.Controls.Add(Me.lblPhone)
        Me.pnlForm.Controls.Add(Me.lblAddress)
        Me.pnlForm.Controls.Add(Me.lblCity)
        Me.pnlForm.Controls.Add(Me.txtLastName)
        Me.pnlForm.Controls.Add(Me.txtFirstName)
        Me.pnlForm.Controls.Add(Me.lblLastName)
        Me.pnlForm.Controls.Add(Me.lblFirstName)
        Me.pnlForm.Location = New System.Drawing.Point(237, 173)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(666, 387)
        Me.pnlForm.TabIndex = 7
        '
        'rtxtComments
        '
        Me.rtxtComments.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rtxtComments.Location = New System.Drawing.Point(34, 199)
        Me.rtxtComments.Name = "rtxtComments"
        Me.rtxtComments.Size = New System.Drawing.Size(529, 165)
        Me.rtxtComments.TabIndex = 11
        Me.rtxtComments.Text = "(Up to 250 Characters)"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(34, 145)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(183, 20)
        Me.txtPhone.TabIndex = 8
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(536, 87)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(94, 20)
        Me.txtZip.TabIndex = 7
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZip.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblZip.Location = New System.Drawing.Point(533, 72)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(36, 17)
        Me.lblZip.TabIndex = 8
        Me.lblZip.Text = "Zip:"
        '
        'cmboxService
        '
        Me.cmboxService.FormattingEnabled = True
        Me.cmboxService.Items.AddRange(New Object() {"Store Profile", "Accounts", "Products"})
        Me.cmboxService.Location = New System.Drawing.Point(241, 144)
        Me.cmboxService.Name = "cmboxService"
        Me.cmboxService.Size = New System.Drawing.Size(181, 21)
        Me.cmboxService.TabIndex = 9
        '
        'cmboxState
        '
        Me.cmboxState.FormattingEnabled = True
        Me.cmboxState.Items.AddRange(New Object() {"AL", "AK", "AS", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FM", "FL", "GA", "GU", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MH", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "MP", "OH", "OK", "OR", "PW", "PA", "PR", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VI", "VA", "WA", "WV", "WI", "WY"})
        Me.cmboxState.Location = New System.Drawing.Point(445, 87)
        Me.cmboxState.Name = "cmboxState"
        Me.cmboxState.Size = New System.Drawing.Size(67, 21)
        Me.cmboxState.TabIndex = 6
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblState.Location = New System.Drawing.Point(442, 72)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(51, 17)
        Me.lblState.TabIndex = 6
        Me.lblState.Text = "State:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(34, 87)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(222, 20)
        Me.txtAddress.TabIndex = 4
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(265, 87)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(171, 20)
        Me.txtCity.TabIndex = 5
        '
        'lblMessages
        '
        Me.lblMessages.AutoSize = True
        Me.lblMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessages.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblMessages.Location = New System.Drawing.Point(31, 179)
        Me.lblMessages.Name = "lblMessages"
        Me.lblMessages.Size = New System.Drawing.Size(87, 17)
        Me.lblMessages.TabIndex = 4
        Me.lblMessages.Text = "Comments:"
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelection.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblSelection.Location = New System.Drawing.Point(238, 125)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(371, 17)
        Me.lblSelection.TabIndex = 4
        Me.lblSelection.Text = "Which service would you like more information on:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblPhone.Location = New System.Drawing.Point(31, 125)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(120, 17)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone Number:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblAddress.Location = New System.Drawing.Point(31, 71)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(67, 17)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Address"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblCity.Location = New System.Drawing.Point(262, 72)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(40, 17)
        Me.lblCity.TabIndex = 4
        Me.lblCity.Text = "City:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(320, 39)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(243, 20)
        Me.txtLastName.TabIndex = 3
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(34, 39)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(243, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblLastName.Location = New System.Drawing.Point(317, 23)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(90, 17)
        Me.lblLastName.TabIndex = 12
        Me.lblLastName.Text = "Last Name:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblFirstName.Location = New System.Drawing.Point(31, 23)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(91, 17)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name:"
        '
        'lblRequest
        '
        Me.lblRequest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRequest.AutoSize = True
        Me.lblRequest.Font = New System.Drawing.Font("Magneto", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequest.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblRequest.Location = New System.Drawing.Point(188, 45)
        Me.lblRequest.Name = "lblRequest"
        Me.lblRequest.Size = New System.Drawing.Size(811, 56)
        Me.lblRequest.TabIndex = 8
        Me.lblRequest.Text = "Request for More Information"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'MoreInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 1012)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblRequest)
        Me.Controls.Add(Me.pnlForm)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MoreInfoForm"
        Me.Text = "MoreInfoForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnGeneralStoreInfo As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents lblRequest As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents cmboxState As System.Windows.Forms.ComboBox
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblMessages As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents cmboxService As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelection As System.Windows.Forms.Label
    Friend WithEvents rtxtComments As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
End Class

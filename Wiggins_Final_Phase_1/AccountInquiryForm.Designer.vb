<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountInquiryForm
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
        Me.lblAccountInquiryForm = New System.Windows.Forms.Label()
        Me.panelBtns = New System.Windows.Forms.Panel()
        Me.btnSubmitInquiryForm = New System.Windows.Forms.Button()
        Me.btnBackInquiryForm = New System.Windows.Forms.Button()
        Me.panelcustInfo = New System.Windows.Forms.Panel()
        Me.txtbxState = New System.Windows.Forms.TextBox()
        Me.txtbxZip = New System.Windows.Forms.TextBox()
        Me.txtbxCity = New System.Windows.Forms.TextBox()
        Me.txtbxAddress = New System.Windows.Forms.TextBox()
        Me.txtbxName = New System.Windows.Forms.TextBox()
        Me.txtbxCustID = New System.Windows.Forms.TextBox()
        Me.lblCustCityStateZip = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.lblCustId = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelUpdate = New System.Windows.Forms.Panel()
        Me.cmboxState = New System.Windows.Forms.ComboBox()
        Me.txtbxZipUp = New System.Windows.Forms.TextBox()
        Me.txtbxCityUp = New System.Windows.Forms.TextBox()
        Me.txtbxAddUp = New System.Windows.Forms.TextBox()
        Me.txtbxNameUp = New System.Windows.Forms.TextBox()
        Me.lblCityStZipUp = New System.Windows.Forms.Label()
        Me.lblAddressUp = New System.Windows.Forms.Label()
        Me.lblCustUp = New System.Windows.Forms.Label()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblAmountDue = New System.Windows.Forms.Label()
        Me.txtbxAmountOwed = New System.Windows.Forms.TextBox()
        Me.panelBtns.SuspendLayout()
        Me.panelcustInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelUpdate.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAccountInquiryForm
        '
        Me.lblAccountInquiryForm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAccountInquiryForm.AutoSize = True
        Me.lblAccountInquiryForm.Font = New System.Drawing.Font("Magneto", 35.0!, System.Drawing.FontStyle.Bold)
        Me.lblAccountInquiryForm.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblAccountInquiryForm.Location = New System.Drawing.Point(315, 72)
        Me.lblAccountInquiryForm.Name = "lblAccountInquiryForm"
        Me.lblAccountInquiryForm.Size = New System.Drawing.Size(457, 56)
        Me.lblAccountInquiryForm.TabIndex = 8
        Me.lblAccountInquiryForm.Text = "Account Inquiry"
        '
        'panelBtns
        '
        Me.panelBtns.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelBtns.Controls.Add(Me.btnSubmitInquiryForm)
        Me.panelBtns.Controls.Add(Me.btnBackInquiryForm)
        Me.panelBtns.Location = New System.Drawing.Point(66, 663)
        Me.panelBtns.Name = "panelBtns"
        Me.panelBtns.Size = New System.Drawing.Size(955, 349)
        Me.panelBtns.TabIndex = 11
        '
        'btnSubmitInquiryForm
        '
        Me.btnSubmitInquiryForm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSubmitInquiryForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSubmitInquiryForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitInquiryForm.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnSubmitInquiryForm.Location = New System.Drawing.Point(35, 49)
        Me.btnSubmitInquiryForm.Name = "btnSubmitInquiryForm"
        Me.btnSubmitInquiryForm.Size = New System.Drawing.Size(898, 133)
        Me.btnSubmitInquiryForm.TabIndex = 0
        Me.btnSubmitInquiryForm.Text = "&Submit"
        Me.btnSubmitInquiryForm.UseVisualStyleBackColor = True
        '
        'btnBackInquiryForm
        '
        Me.btnBackInquiryForm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBackInquiryForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBackInquiryForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackInquiryForm.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnBackInquiryForm.Location = New System.Drawing.Point(35, 208)
        Me.btnBackInquiryForm.Name = "btnBackInquiryForm"
        Me.btnBackInquiryForm.Size = New System.Drawing.Size(898, 133)
        Me.btnBackInquiryForm.TabIndex = 0
        Me.btnBackInquiryForm.Text = "&Back"
        Me.btnBackInquiryForm.UseVisualStyleBackColor = True
        '
        'panelcustInfo
        '
        Me.panelcustInfo.Controls.Add(Me.txtbxState)
        Me.panelcustInfo.Controls.Add(Me.txtbxZip)
        Me.panelcustInfo.Controls.Add(Me.txtbxAmountOwed)
        Me.panelcustInfo.Controls.Add(Me.txtbxCity)
        Me.panelcustInfo.Controls.Add(Me.txtbxAddress)
        Me.panelcustInfo.Controls.Add(Me.txtbxName)
        Me.panelcustInfo.Controls.Add(Me.txtbxCustID)
        Me.panelcustInfo.Controls.Add(Me.lblCustCityStateZip)
        Me.panelcustInfo.Controls.Add(Me.lblAmountDue)
        Me.panelcustInfo.Controls.Add(Me.lblAddress)
        Me.panelcustInfo.Controls.Add(Me.lblCustName)
        Me.panelcustInfo.Controls.Add(Me.lblCustId)
        Me.panelcustInfo.Location = New System.Drawing.Point(253, 152)
        Me.panelcustInfo.Name = "panelcustInfo"
        Me.panelcustInfo.Size = New System.Drawing.Size(618, 242)
        Me.panelcustInfo.TabIndex = 12
        '
        'txtbxState
        '
        Me.txtbxState.Location = New System.Drawing.Point(313, 171)
        Me.txtbxState.Name = "txtbxState"
        Me.txtbxState.ReadOnly = True
        Me.txtbxState.Size = New System.Drawing.Size(132, 20)
        Me.txtbxState.TabIndex = 15
        '
        'txtbxZip
        '
        Me.txtbxZip.Location = New System.Drawing.Point(451, 171)
        Me.txtbxZip.Name = "txtbxZip"
        Me.txtbxZip.ReadOnly = True
        Me.txtbxZip.Size = New System.Drawing.Size(145, 20)
        Me.txtbxZip.TabIndex = 16
        '
        'txtbxCity
        '
        Me.txtbxCity.Location = New System.Drawing.Point(182, 171)
        Me.txtbxCity.Name = "txtbxCity"
        Me.txtbxCity.ReadOnly = True
        Me.txtbxCity.Size = New System.Drawing.Size(134, 20)
        Me.txtbxCity.TabIndex = 17
        '
        'txtbxAddress
        '
        Me.txtbxAddress.Location = New System.Drawing.Point(182, 126)
        Me.txtbxAddress.Name = "txtbxAddress"
        Me.txtbxAddress.ReadOnly = True
        Me.txtbxAddress.Size = New System.Drawing.Size(423, 20)
        Me.txtbxAddress.TabIndex = 18
        '
        'txtbxName
        '
        Me.txtbxName.Location = New System.Drawing.Point(182, 87)
        Me.txtbxName.Name = "txtbxName"
        Me.txtbxName.ReadOnly = True
        Me.txtbxName.Size = New System.Drawing.Size(423, 20)
        Me.txtbxName.TabIndex = 19
        '
        'txtbxCustID
        '
        Me.txtbxCustID.Location = New System.Drawing.Point(182, 45)
        Me.txtbxCustID.Name = "txtbxCustID"
        Me.txtbxCustID.ReadOnly = True
        Me.txtbxCustID.Size = New System.Drawing.Size(155, 20)
        Me.txtbxCustID.TabIndex = 20
        '
        'lblCustCityStateZip
        '
        Me.lblCustCityStateZip.AutoSize = True
        Me.lblCustCityStateZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustCityStateZip.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblCustCityStateZip.Location = New System.Drawing.Point(22, 174)
        Me.lblCustCityStateZip.Name = "lblCustCityStateZip"
        Me.lblCustCityStateZip.Size = New System.Drawing.Size(121, 17)
        Me.lblCustCityStateZip.TabIndex = 11
        Me.lblCustCityStateZip.Text = "City, State, Zip:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblAddress.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblAddress.Location = New System.Drawing.Point(22, 129)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(145, 17)
        Me.lblAddress.TabIndex = 12
        Me.lblAddress.Text = "Customer Address:"
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustName.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblCustName.Location = New System.Drawing.Point(22, 90)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(127, 17)
        Me.lblCustName.TabIndex = 13
        Me.lblCustName.Text = "Customer Name:"
        '
        'lblCustId
        '
        Me.lblCustId.AutoSize = True
        Me.lblCustId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustId.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblCustId.Location = New System.Drawing.Point(22, 45)
        Me.lblCustId.Name = "lblCustId"
        Me.lblCustId.Size = New System.Drawing.Size(99, 17)
        Me.lblCustId.TabIndex = 14
        Me.lblCustId.Text = "Customer Id:"
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
        'panelUpdate
        '
        Me.panelUpdate.Controls.Add(Me.cmboxState)
        Me.panelUpdate.Controls.Add(Me.txtbxZipUp)
        Me.panelUpdate.Controls.Add(Me.txtbxCityUp)
        Me.panelUpdate.Controls.Add(Me.txtbxAddUp)
        Me.panelUpdate.Controls.Add(Me.txtbxNameUp)
        Me.panelUpdate.Controls.Add(Me.lblCityStZipUp)
        Me.panelUpdate.Controls.Add(Me.lblAddressUp)
        Me.panelUpdate.Controls.Add(Me.lblCustUp)
        Me.panelUpdate.Controls.Add(Me.lblUpdate)
        Me.panelUpdate.Location = New System.Drawing.Point(253, 448)
        Me.panelUpdate.Name = "panelUpdate"
        Me.panelUpdate.Size = New System.Drawing.Size(618, 186)
        Me.panelUpdate.TabIndex = 12
        '
        'cmboxState
        '
        Me.cmboxState.FormattingEnabled = True
        Me.cmboxState.Items.AddRange(New Object() {"AL", "AK", "AS", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FM", "FL", "GA", "GU", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MH", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "MP", "OH", "OK", "OR", "PW", "PA", "PR", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VI", "VA", "WA", "WV", "WI", "WY"})
        Me.cmboxState.Location = New System.Drawing.Point(321, 148)
        Me.cmboxState.Name = "cmboxState"
        Me.cmboxState.Size = New System.Drawing.Size(132, 21)
        Me.cmboxState.TabIndex = 20
        '
        'txtbxZipUp
        '
        Me.txtbxZipUp.Location = New System.Drawing.Point(459, 149)
        Me.txtbxZipUp.Name = "txtbxZipUp"
        Me.txtbxZipUp.Size = New System.Drawing.Size(145, 20)
        Me.txtbxZipUp.TabIndex = 16
        '
        'txtbxCityUp
        '
        Me.txtbxCityUp.Location = New System.Drawing.Point(181, 149)
        Me.txtbxCityUp.Name = "txtbxCityUp"
        Me.txtbxCityUp.Size = New System.Drawing.Size(134, 20)
        Me.txtbxCityUp.TabIndex = 17
        '
        'txtbxAddUp
        '
        Me.txtbxAddUp.Location = New System.Drawing.Point(181, 104)
        Me.txtbxAddUp.Name = "txtbxAddUp"
        Me.txtbxAddUp.Size = New System.Drawing.Size(423, 20)
        Me.txtbxAddUp.TabIndex = 18
        '
        'txtbxNameUp
        '
        Me.txtbxNameUp.Location = New System.Drawing.Point(181, 65)
        Me.txtbxNameUp.Name = "txtbxNameUp"
        Me.txtbxNameUp.Size = New System.Drawing.Size(423, 20)
        Me.txtbxNameUp.TabIndex = 19
        '
        'lblCityStZipUp
        '
        Me.lblCityStZipUp.AutoSize = True
        Me.lblCityStZipUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCityStZipUp.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblCityStZipUp.Location = New System.Drawing.Point(30, 152)
        Me.lblCityStZipUp.Name = "lblCityStZipUp"
        Me.lblCityStZipUp.Size = New System.Drawing.Size(121, 17)
        Me.lblCityStZipUp.TabIndex = 11
        Me.lblCityStZipUp.Text = "City, State, Zip:"
        '
        'lblAddressUp
        '
        Me.lblAddressUp.AutoSize = True
        Me.lblAddressUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblAddressUp.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblAddressUp.Location = New System.Drawing.Point(30, 107)
        Me.lblAddressUp.Name = "lblAddressUp"
        Me.lblAddressUp.Size = New System.Drawing.Size(145, 17)
        Me.lblAddressUp.TabIndex = 12
        Me.lblAddressUp.Text = "Customer Address:"
        '
        'lblCustUp
        '
        Me.lblCustUp.AutoSize = True
        Me.lblCustUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustUp.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblCustUp.Location = New System.Drawing.Point(30, 68)
        Me.lblCustUp.Name = "lblCustUp"
        Me.lblCustUp.Size = New System.Drawing.Size(127, 17)
        Me.lblCustUp.TabIndex = 13
        Me.lblCustUp.Text = "Customer Name:"
        '
        'lblUpdate
        '
        Me.lblUpdate.AutoSize = True
        Me.lblUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdate.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblUpdate.Location = New System.Drawing.Point(198, 23)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(238, 24)
        Me.lblUpdate.TabIndex = 14
        Me.lblUpdate.Text = "Update your information:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblAmountDue
        '
        Me.lblAmountDue.AutoSize = True
        Me.lblAmountDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblAmountDue.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblAmountDue.Location = New System.Drawing.Point(22, 215)
        Me.lblAmountDue.Name = "lblAmountDue"
        Me.lblAmountDue.Size = New System.Drawing.Size(154, 17)
        Me.lblAmountDue.TabIndex = 12
        Me.lblAmountDue.Text = "Total Amount Owed:"
        '
        'txtbxAmountOwed
        '
        Me.txtbxAmountOwed.Location = New System.Drawing.Point(182, 214)
        Me.txtbxAmountOwed.Name = "txtbxAmountOwed"
        Me.txtbxAmountOwed.ReadOnly = True
        Me.txtbxAmountOwed.Size = New System.Drawing.Size(134, 20)
        Me.txtbxAmountOwed.TabIndex = 17
        '
        'AccountInquiryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 879)
        Me.Controls.Add(Me.panelUpdate)
        Me.Controls.Add(Me.panelcustInfo)
        Me.Controls.Add(Me.panelBtns)
        Me.Controls.Add(Me.lblAccountInquiryForm)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AccountInquiryForm"
        Me.Text = "AccountInquiryForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelBtns.ResumeLayout(False)
        Me.panelcustInfo.ResumeLayout(False)
        Me.panelcustInfo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelUpdate.ResumeLayout(False)
        Me.panelUpdate.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblAccountInquiryForm As System.Windows.Forms.Label
    Friend WithEvents panelBtns As System.Windows.Forms.Panel
    Friend WithEvents btnSubmitInquiryForm As System.Windows.Forms.Button
    Friend WithEvents btnBackInquiryForm As System.Windows.Forms.Button
    Friend WithEvents panelcustInfo As System.Windows.Forms.Panel
    Friend WithEvents txtbxState As System.Windows.Forms.TextBox
    Friend WithEvents txtbxZip As System.Windows.Forms.TextBox
    Friend WithEvents txtbxCity As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtbxName As System.Windows.Forms.TextBox
    Friend WithEvents txtbxCustID As System.Windows.Forms.TextBox
    Friend WithEvents lblCustCityStateZip As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCustName As System.Windows.Forms.Label
    Friend WithEvents lblCustId As System.Windows.Forms.Label
    Friend WithEvents panelUpdate As System.Windows.Forms.Panel
    Friend WithEvents txtbxZipUp As System.Windows.Forms.TextBox
    Friend WithEvents txtbxCityUp As System.Windows.Forms.TextBox
    Friend WithEvents txtbxAddUp As System.Windows.Forms.TextBox
    Friend WithEvents txtbxNameUp As System.Windows.Forms.TextBox
    Friend WithEvents lblCityStZipUp As System.Windows.Forms.Label
    Friend WithEvents lblAddressUp As System.Windows.Forms.Label
    Friend WithEvents lblCustUp As System.Windows.Forms.Label
    Friend WithEvents lblUpdate As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmboxState As System.Windows.Forms.ComboBox
    Friend WithEvents txtbxAmountOwed As System.Windows.Forms.TextBox
    Friend WithEvents lblAmountDue As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductInfo
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
        Me.btnBackToTransactions = New System.Windows.Forms.Button()
        Me.btnGeneralStore = New System.Windows.Forms.Button()
        Me.lblProductInfo = New System.Windows.Forms.Label()
        Me.lblProductSelection = New System.Windows.Forms.Label()
        Me.cmbProducts = New System.Windows.Forms.ComboBox()
        Me.rtxtbox1 = New System.Windows.Forms.RichTextBox()
        Me.lblmodel = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblModelSetter = New System.Windows.Forms.Label()
        Me.lblPriceSetter = New System.Windows.Forms.Label()
        Me.pbProduct = New System.Windows.Forms.PictureBox()
        Me.picIogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.btnBackToTransactions)
        Me.Panel1.Controls.Add(Me.btnGeneralStore)
        Me.Panel1.Location = New System.Drawing.Point(95, 800)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 227)
        Me.Panel1.TabIndex = 1
        '
        'btnBackToTransactions
        '
        Me.btnBackToTransactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToTransactions.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnBackToTransactions.Location = New System.Drawing.Point(42, 128)
        Me.btnBackToTransactions.Name = "btnBackToTransactions"
        Me.btnBackToTransactions.Size = New System.Drawing.Size(898, 90)
        Me.btnBackToTransactions.TabIndex = 0
        Me.btnBackToTransactions.Text = "&Back to Transactions"
        Me.btnBackToTransactions.UseVisualStyleBackColor = True
        '
        'btnGeneralStore
        '
        Me.btnGeneralStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneralStore.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnGeneralStore.Location = New System.Drawing.Point(42, 20)
        Me.btnGeneralStore.Name = "btnGeneralStore"
        Me.btnGeneralStore.Size = New System.Drawing.Size(898, 90)
        Me.btnGeneralStore.TabIndex = 0
        Me.btnGeneralStore.Text = "&General Store Information"
        Me.btnGeneralStore.UseVisualStyleBackColor = True
        '
        'lblProductInfo
        '
        Me.lblProductInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProductInfo.AutoSize = True
        Me.lblProductInfo.Font = New System.Drawing.Font("Magneto", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductInfo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblProductInfo.Location = New System.Drawing.Point(267, 213)
        Me.lblProductInfo.Name = "lblProductInfo"
        Me.lblProductInfo.Size = New System.Drawing.Size(556, 56)
        Me.lblProductInfo.TabIndex = 5
        Me.lblProductInfo.Text = "Product Information"
        '
        'lblProductSelection
        '
        Me.lblProductSelection.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProductSelection.AutoSize = True
        Me.lblProductSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductSelection.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblProductSelection.Location = New System.Drawing.Point(433, 303)
        Me.lblProductSelection.Name = "lblProductSelection"
        Me.lblProductSelection.Size = New System.Drawing.Size(184, 17)
        Me.lblProductSelection.TabIndex = 6
        Me.lblProductSelection.Text = "Please select a product:"
        '
        'cmbProducts
        '
        Me.cmbProducts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbProducts.FormattingEnabled = True
        Me.cmbProducts.Items.AddRange(New Object() {"Treadmill", "StairMaster", "Elliptical", "Stationary Bike", "Rowing Machine", "Treadclimber"})
        Me.cmbProducts.Location = New System.Drawing.Point(455, 347)
        Me.cmbProducts.Name = "cmbProducts"
        Me.cmbProducts.Size = New System.Drawing.Size(121, 21)
        Me.cmbProducts.TabIndex = 7
        '
        'rtxtbox1
        '
        Me.rtxtbox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rtxtbox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.rtxtbox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtbox1.Font = New System.Drawing.Font("Castellar", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.rtxtbox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rtxtbox1.Location = New System.Drawing.Point(222, 471)
        Me.rtxtbox1.Name = "rtxtbox1"
        Me.rtxtbox1.Size = New System.Drawing.Size(776, 302)
        Me.rtxtbox1.TabIndex = 9
        Me.rtxtbox1.Text = ""
        '
        'lblmodel
        '
        Me.lblmodel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblmodel.AutoSize = True
        Me.lblmodel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblmodel.Location = New System.Drawing.Point(246, 393)
        Me.lblmodel.Name = "lblmodel"
        Me.lblmodel.Size = New System.Drawing.Size(56, 17)
        Me.lblmodel.TabIndex = 10
        Me.lblmodel.Text = "Model:"
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblPrice.Location = New System.Drawing.Point(246, 437)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(50, 17)
        Me.lblPrice.TabIndex = 10
        Me.lblPrice.Text = "Price:"
        '
        'lblModelSetter
        '
        Me.lblModelSetter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblModelSetter.AutoSize = True
        Me.lblModelSetter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelSetter.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblModelSetter.Location = New System.Drawing.Point(319, 393)
        Me.lblModelSetter.Name = "lblModelSetter"
        Me.lblModelSetter.Size = New System.Drawing.Size(0, 17)
        Me.lblModelSetter.TabIndex = 10
        '
        'lblPriceSetter
        '
        Me.lblPriceSetter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPriceSetter.AutoSize = True
        Me.lblPriceSetter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceSetter.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblPriceSetter.Location = New System.Drawing.Point(319, 437)
        Me.lblPriceSetter.Name = "lblPriceSetter"
        Me.lblPriceSetter.Size = New System.Drawing.Size(0, 17)
        Me.lblPriceSetter.TabIndex = 10
        '
        'pbProduct
        '
        Me.pbProduct.Location = New System.Drawing.Point(48, 267)
        Me.pbProduct.Name = "pbProduct"
        Me.pbProduct.Size = New System.Drawing.Size(125, 129)
        Me.pbProduct.TabIndex = 8
        Me.pbProduct.TabStop = False
        '
        'picIogo
        '
        Me.picIogo.Image = Global.Wiggins_Final_Phase_1.My.Resources.Resources.Logo
        Me.picIogo.Location = New System.Drawing.Point(48, 45)
        Me.picIogo.Name = "picIogo"
        Me.picIogo.Size = New System.Drawing.Size(100, 125)
        Me.picIogo.TabIndex = 3
        Me.picIogo.TabStop = False
        '
        'ProductInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 1029)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblPriceSetter)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblModelSetter)
        Me.Controls.Add(Me.lblmodel)
        Me.Controls.Add(Me.rtxtbox1)
        Me.Controls.Add(Me.pbProduct)
        Me.Controls.Add(Me.cmbProducts)
        Me.Controls.Add(Me.lblProductSelection)
        Me.Controls.Add(Me.lblProductInfo)
        Me.Controls.Add(Me.picIogo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductInfo"
        Me.Text = "ProductInfo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnGeneralStore As System.Windows.Forms.Button
    Friend WithEvents picIogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblProductInfo As System.Windows.Forms.Label
    Friend WithEvents lblProductSelection As System.Windows.Forms.Label
    Friend WithEvents cmbProducts As System.Windows.Forms.ComboBox
    Friend WithEvents pbProduct As System.Windows.Forms.PictureBox
    Friend WithEvents rtxtbox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblmodel As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblModelSetter As System.Windows.Forms.Label
    Friend WithEvents lblPriceSetter As System.Windows.Forms.Label
    Friend WithEvents btnBackToTransactions As System.Windows.Forms.Button
End Class

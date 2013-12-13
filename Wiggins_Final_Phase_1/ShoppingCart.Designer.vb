<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShoppingCart
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblShoppingCart = New System.Windows.Forms.Label()
        Me.pnlGridHolder = New System.Windows.Forms.Panel()
        Me.cmbbxQuantity = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtbxTotal = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblCartItems = New System.Windows.Forms.Label()
        Me.pnlbtnHolder = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGridHolder.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlbtnHolder.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wiggins_Final_Phase_1.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(48, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'lblShoppingCart
        '
        Me.lblShoppingCart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblShoppingCart.AutoSize = True
        Me.lblShoppingCart.Font = New System.Drawing.Font("Magneto", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShoppingCart.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblShoppingCart.Location = New System.Drawing.Point(501, 78)
        Me.lblShoppingCart.Name = "lblShoppingCart"
        Me.lblShoppingCart.Size = New System.Drawing.Size(395, 56)
        Me.lblShoppingCart.TabIndex = 12
        Me.lblShoppingCart.Text = "Shopping Cart"
        '
        'pnlGridHolder
        '
        Me.pnlGridHolder.Controls.Add(Me.cmbbxQuantity)
        Me.pnlGridHolder.Controls.Add(Me.DataGridView1)
        Me.pnlGridHolder.Controls.Add(Me.txtbxTotal)
        Me.pnlGridHolder.Controls.Add(Me.lblQuantity)
        Me.pnlGridHolder.Controls.Add(Me.lbltotal)
        Me.pnlGridHolder.Controls.Add(Me.lblCartItems)
        Me.pnlGridHolder.Location = New System.Drawing.Point(154, 78)
        Me.pnlGridHolder.Name = "pnlGridHolder"
        Me.pnlGridHolder.Size = New System.Drawing.Size(997, 630)
        Me.pnlGridHolder.TabIndex = 13
        '
        'cmbbxQuantity
        '
        Me.cmbbxQuantity.FormattingEnabled = True
        Me.cmbbxQuantity.Location = New System.Drawing.Point(225, 476)
        Me.cmbbxQuantity.Name = "cmbbxQuantity"
        Me.cmbbxQuantity.Size = New System.Drawing.Size(121, 21)
        Me.cmbbxQuantity.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Location = New System.Drawing.Point(3, 59)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 50
        Me.DataGridView1.Size = New System.Drawing.Size(991, 350)
        Me.DataGridView1.TabIndex = 0
        '
        'txtbxTotal
        '
        Me.txtbxTotal.Location = New System.Drawing.Point(726, 436)
        Me.txtbxTotal.Name = "txtbxTotal"
        Me.txtbxTotal.ReadOnly = True
        Me.txtbxTotal.Size = New System.Drawing.Size(125, 20)
        Me.txtbxTotal.TabIndex = 0
        '
        'lblQuantity
        '
        Me.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblQuantity.Location = New System.Drawing.Point(199, 436)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(171, 20)
        Me.lblQuantity.TabIndex = 0
        Me.lblQuantity.Text = "Select New Quantity"
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbltotal.Location = New System.Drawing.Point(606, 436)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(104, 20)
        Me.lbltotal.TabIndex = 0
        Me.lbltotal.Text = "Order Total:"
        '
        'lblCartItems
        '
        Me.lblCartItems.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCartItems.AutoSize = True
        Me.lblCartItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartItems.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblCartItems.Location = New System.Drawing.Point(389, 17)
        Me.lblCartItems.Name = "lblCartItems"
        Me.lblCartItems.Size = New System.Drawing.Size(159, 29)
        Me.lblCartItems.TabIndex = 0
        Me.lblCartItems.Text = "Items in Cart"
        '
        'pnlbtnHolder
        '
        Me.pnlbtnHolder.Controls.Add(Me.btnUpdate)
        Me.pnlbtnHolder.Controls.Add(Me.btnBack)
        Me.pnlbtnHolder.Controls.Add(Me.btnSubmit)
        Me.pnlbtnHolder.Controls.Add(Me.btnCancel)
        Me.pnlbtnHolder.Location = New System.Drawing.Point(154, 716)
        Me.pnlbtnHolder.Name = "pnlbtnHolder"
        Me.pnlbtnHolder.Size = New System.Drawing.Size(997, 295)
        Me.pnlbtnHolder.TabIndex = 14
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnUpdate.Location = New System.Drawing.Point(27, 149)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(449, 83)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "&Update Quantity"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnBack.Location = New System.Drawing.Point(521, 149)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(449, 83)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnSubmit.Location = New System.Drawing.Point(521, 39)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(449, 83)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancel.Location = New System.Drawing.Point(27, 39)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(449, 83)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel Order"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ShoppingCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1355, 1023)
        Me.Controls.Add(Me.pnlbtnHolder)
        Me.Controls.Add(Me.pnlGridHolder)
        Me.Controls.Add(Me.lblShoppingCart)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ShoppingCart"
        Me.Text = "ShoppingCart"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGridHolder.ResumeLayout(False)
        Me.pnlGridHolder.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlbtnHolder.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblShoppingCart As System.Windows.Forms.Label
    Friend WithEvents pnlGridHolder As System.Windows.Forms.Panel
    Friend WithEvents lblCartItems As System.Windows.Forms.Label
    Friend WithEvents txtbxTotal As System.Windows.Forms.TextBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents pnlbtnHolder As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents cmbbxQuantity As System.Windows.Forms.ComboBox
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountTransactions
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.lblTransactions = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnbtnHolder = New System.Windows.Forms.Panel()
        Me.btnShoppingCart = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cmbQuantities = New System.Windows.Forms.ComboBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnbtnHolder.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DataGridView1.Location = New System.Drawing.Point(14, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 50
        Me.DataGridView1.Size = New System.Drawing.Size(780, 470)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblProducts)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(112, 184)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 540)
        Me.Panel1.TabIndex = 1
        '
        'lblProducts
        '
        Me.lblProducts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProducts.AutoSize = True
        Me.lblProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducts.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblProducts.Location = New System.Drawing.Point(296, 22)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New System.Drawing.Size(216, 29)
        Me.lblProducts.TabIndex = 9
        Me.lblProducts.Text = "Products For Sell"
        '
        'lblTransactions
        '
        Me.lblTransactions.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTransactions.AutoSize = True
        Me.lblTransactions.Font = New System.Drawing.Font("Magneto", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactions.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblTransactions.Location = New System.Drawing.Point(237, 104)
        Me.lblTransactions.Name = "lblTransactions"
        Me.lblTransactions.Size = New System.Drawing.Size(590, 56)
        Me.lblTransactions.TabIndex = 9
        Me.lblTransactions.Text = "Account Transactions"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wiggins_Final_Phase_1.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(48, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'pnbtnHolder
        '
        Me.pnbtnHolder.Controls.Add(Me.btnShoppingCart)
        Me.pnbtnHolder.Controls.Add(Me.btnSubmit)
        Me.pnbtnHolder.Controls.Add(Me.btnBack)
        Me.pnbtnHolder.Controls.Add(Me.cmbQuantities)
        Me.pnbtnHolder.Controls.Add(Me.lblQuantity)
        Me.pnbtnHolder.Location = New System.Drawing.Point(112, 730)
        Me.pnbtnHolder.Name = "pnbtnHolder"
        Me.pnbtnHolder.Size = New System.Drawing.Size(808, 281)
        Me.pnbtnHolder.TabIndex = 11
        '
        'btnShoppingCart
        '
        Me.btnShoppingCart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnShoppingCart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnShoppingCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShoppingCart.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnShoppingCart.Location = New System.Drawing.Point(78, 184)
        Me.btnShoppingCart.Name = "btnShoppingCart"
        Me.btnShoppingCart.Size = New System.Drawing.Size(697, 83)
        Me.btnShoppingCart.TabIndex = 12
        Me.btnShoppingCart.Text = "&Shopping Cart"
        Me.btnShoppingCart.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnSubmit.Location = New System.Drawing.Point(437, 77)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(338, 83)
        Me.btnSubmit.TabIndex = 12
        Me.btnSubmit.Text = "S&ubmit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnBack.Location = New System.Drawing.Point(78, 77)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(338, 83)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'cmbQuantities
        '
        Me.cmbQuantities.FormattingEnabled = True
        Me.cmbQuantities.Location = New System.Drawing.Point(635, 33)
        Me.cmbQuantities.Name = "cmbQuantities"
        Me.cmbQuantities.Size = New System.Drawing.Size(103, 21)
        Me.cmbQuantities.TabIndex = 11
        '
        'lblQuantity
        '
        Me.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblQuantity.Location = New System.Drawing.Point(620, 10)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(132, 20)
        Me.lblQuantity.TabIndex = 10
        Me.lblQuantity.Text = "Select Quantity"
        '
        'AccountTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 1023)
        Me.Controls.Add(Me.pnbtnHolder)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTransactions)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccountTransactions"
        Me.Text = "AccountTransactions"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnbtnHolder.ResumeLayout(False)
        Me.pnbtnHolder.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblProducts As System.Windows.Forms.Label
    Friend WithEvents lblTransactions As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnbtnHolder As System.Windows.Forms.Panel
    Friend WithEvents cmbQuantities As System.Windows.Forms.ComboBox
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents btnShoppingCart As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class

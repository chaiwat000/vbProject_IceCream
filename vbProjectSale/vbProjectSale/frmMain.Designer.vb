<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSale = New System.Windows.Forms.ToolStripButton()
        Me.btnMangeEmployee = New System.Windows.Forms.ToolStripButton()
        Me.btnManageCustomer = New System.Windows.Forms.ToolStripButton()
        Me.btnManageProduct = New System.Windows.Forms.ToolStripButton()
        Me.btnProduct = New System.Windows.Forms.ToolStripButton()
        Me.btnCheckOrder = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lbllevel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.lblname = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.lblDay = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSale, Me.btnMangeEmployee, Me.btnManageCustomer, Me.btnManageProduct, Me.btnProduct, Me.btnCheckOrder, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1270, 153)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSale
        '
        Me.btnSale.AutoSize = False
        Me.btnSale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSale.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Land_Sales_96px
        Me.btnSale.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSale.Name = "btnSale"
        Me.btnSale.Size = New System.Drawing.Size(150, 150)
        Me.btnSale.Text = "ขายสินค้า"
        Me.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnMangeEmployee
        '
        Me.btnMangeEmployee.AutoSize = False
        Me.btnMangeEmployee.Image = Global.vbProjectSale.My.Resources.Resources.icons8_User_96px_1
        Me.btnMangeEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnMangeEmployee.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMangeEmployee.Name = "btnMangeEmployee"
        Me.btnMangeEmployee.Size = New System.Drawing.Size(150, 150)
        Me.btnMangeEmployee.Text = "จัดการพนักงาน"
        Me.btnMangeEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnManageCustomer
        '
        Me.btnManageCustomer.AutoSize = False
        Me.btnManageCustomer.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Conference_96px
        Me.btnManageCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnManageCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnManageCustomer.Name = "btnManageCustomer"
        Me.btnManageCustomer.Size = New System.Drawing.Size(150, 150)
        Me.btnManageCustomer.Text = "จัดการลูกค้า"
        Me.btnManageCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnManageProduct
        '
        Me.btnManageProduct.AutoSize = False
        Me.btnManageProduct.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Ice_Cream_Sundae_96px
        Me.btnManageProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnManageProduct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnManageProduct.Name = "btnManageProduct"
        Me.btnManageProduct.Size = New System.Drawing.Size(150, 150)
        Me.btnManageProduct.Text = "จัดการไอศรีม"
        Me.btnManageProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnProduct
        '
        Me.btnProduct.AutoSize = False
        Me.btnProduct.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Depot_96px
        Me.btnProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnProduct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(150, 150)
        Me.btnProduct.Text = "จัดการวัตถุดิบ"
        Me.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnCheckOrder
        '
        Me.btnCheckOrder.AutoSize = False
        Me.btnCheckOrder.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Search_Property_96px
        Me.btnCheckOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCheckOrder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCheckOrder.Name = "btnCheckOrder"
        Me.btnCheckOrder.Size = New System.Drawing.Size(150, 150)
        Me.btnCheckOrder.Text = "ตรวจสอบยอดขาย"
        Me.btnCheckOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnExit
        '
        Me.btnExit.AutoSize = False
        Me.btnExit.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Close_Program_96px
        Me.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 150)
        Me.btnExit.Text = "ออกจากระบบ"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.lbllevel, Me.ToolStripLabel3, Me.lblname, Me.ToolStripLabel5, Me.lblDay})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 586)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1270, 25)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripLabel1.Text = "Status :"
        '
        'lbllevel
        '
        Me.lbllevel.ForeColor = System.Drawing.Color.Green
        Me.lbllevel.Name = "lbllevel"
        Me.lbllevel.Size = New System.Drawing.Size(44, 22)
        Me.lbllevel.Text = "xxxxx"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripLabel3.Text = "Name :"
        '
        'lblname
        '
        Me.lblname.ForeColor = System.Drawing.Color.Green
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(44, 22)
        Me.lblname.Text = "xxxxx"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripLabel5.Text = "Date :"
        '
        'lblDay
        '
        Me.lblDay.ForeColor = System.Drawing.Color.Green
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(37, 22)
        Me.lblDay.Text = "xxxx"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1270, 611)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSale As ToolStripButton
    Friend WithEvents btnMangeEmployee As ToolStripButton
    Friend WithEvents btnManageCustomer As ToolStripButton
    Friend WithEvents btnCheckOrder As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lbllevel As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents lblname As ToolStripLabel
    Friend WithEvents btnManageProduct As ToolStripButton
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents lblDay As ToolStripLabel
    Friend WithEvents btnProduct As ToolStripButton
End Class

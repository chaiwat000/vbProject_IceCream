<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.listIceCream = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.listTopping = New System.Windows.Forms.ListView()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.linkCancel = New System.Windows.Forms.LinkLabel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblShowName = New System.Windows.Forms.Label()
        Me.lblShowID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.linkSelect = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvSale = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblBill = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.brnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCalculator = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(613, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(563, 631)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 134)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(563, 497)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.listIceCream)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(555, 468)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ice Cream"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'listIceCream
        '
        Me.listIceCream.Cursor = System.Windows.Forms.Cursors.Hand
        Me.listIceCream.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listIceCream.LargeImageList = Me.ImageList1
        Me.listIceCream.Location = New System.Drawing.Point(3, 3)
        Me.listIceCream.Name = "listIceCream"
        Me.listIceCream.Size = New System.Drawing.Size(549, 462)
        Me.listIceCream.TabIndex = 0
        Me.listIceCream.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(100, 70)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.listTopping)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(555, 468)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Topping"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'listTopping
        '
        Me.listTopping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listTopping.LargeImageList = Me.ImageList2
        Me.listTopping.Location = New System.Drawing.Point(3, 3)
        Me.listTopping.Name = "listTopping"
        Me.listTopping.Size = New System.Drawing.Size(549, 462)
        Me.listTopping.TabIndex = 0
        Me.listTopping.UseCompatibleStateImageBehavior = False
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(100, 70)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.Controls.Add(Me.linkCancel)
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.linkSelect)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(563, 134)
        Me.Panel3.TabIndex = 0
        '
        'linkCancel
        '
        Me.linkCancel.AutoSize = True
        Me.linkCancel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.linkCancel.Location = New System.Drawing.Point(498, 100)
        Me.linkCancel.Name = "linkCancel"
        Me.linkCancel.Size = New System.Drawing.Size(51, 17)
        Me.linkCancel.TabIndex = 5
        Me.linkCancel.TabStop = True
        Me.linkCancel.Text = "Cancel"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel8.Controls.Add(Me.lblShowName)
        Me.Panel8.Controls.Add(Me.lblShowID)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Location = New System.Drawing.Point(27, 12)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(302, 105)
        Me.Panel8.TabIndex = 6
        '
        'lblShowName
        '
        Me.lblShowName.AutoSize = True
        Me.lblShowName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblShowName.ForeColor = System.Drawing.Color.Green
        Me.lblShowName.Location = New System.Drawing.Point(120, 53)
        Me.lblShowName.Name = "lblShowName"
        Me.lblShowName.Size = New System.Drawing.Size(50, 24)
        Me.lblShowName.TabIndex = 3
        Me.lblShowName.Text = "xxxx"
        '
        'lblShowID
        '
        Me.lblShowID.AutoSize = True
        Me.lblShowID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblShowID.ForeColor = System.Drawing.Color.Green
        Me.lblShowID.Location = New System.Drawing.Point(120, 11)
        Me.lblShowID.Name = "lblShowID"
        Me.lblShowID.Size = New System.Drawing.Size(50, 24)
        Me.lblShowID.TabIndex = 2
        Me.lblShowID.Text = "xxxx"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ชื่อลูกค้า :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "รหัสลูกค้า :"
        '
        'linkSelect
        '
        Me.linkSelect.AutoSize = True
        Me.linkSelect.Location = New System.Drawing.Point(433, 100)
        Me.linkSelect.Name = "linkSelect"
        Me.linkSelect.Size = New System.Drawing.Size(47, 17)
        Me.linkSelect.TabIndex = 4
        Me.linkSelect.TabStop = True
        Me.linkSelect.Text = "Select"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvSale)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(613, 631)
        Me.Panel2.TabIndex = 1
        '
        'dgvSale
        '
        Me.dgvSale.AllowUserToAddRows = False
        Me.dgvSale.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dgvSale.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSale.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSale.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvSale.Location = New System.Drawing.Point(0, 201)
        Me.dgvSale.Name = "dgvSale"
        Me.dgvSale.ReadOnly = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvSale.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSale.RowTemplate.Height = 24
        Me.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSale.Size = New System.Drawing.Size(613, 352)
        Me.dgvSale.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "รหัสสินค้า"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 90
        '
        'Column2
        '
        Me.Column2.HeaderText = "รายการ"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 160
        '
        'Column3
        '
        Me.Column3.HeaderText = "หน่วย"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.HeaderText = "ราคา"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 70
        '
        'Column5
        '
        Me.Column5.HeaderText = "จำนวน"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 70
        '
        'Column6
        '
        Me.Column6.HeaderText = "ราคาสุทธิ"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 154)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(613, 47)
        Me.Panel7.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.YellowGreen
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(613, 45)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "รายการขายสินค้า"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.lblBill)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 100)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(613, 54)
        Me.Panel6.TabIndex = 5
        '
        'lblBill
        '
        Me.lblBill.AutoSize = True
        Me.lblBill.ForeColor = System.Drawing.Color.Green
        Me.lblBill.Location = New System.Drawing.Point(134, 21)
        Me.lblBill.Name = "lblBill"
        Me.lblBill.Size = New System.Drawing.Size(32, 17)
        Me.lblBill.TabIndex = 2
        Me.lblBill.Text = "xxxx"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "หมายเลขใบเสร็จ :"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblTotal)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(613, 100)
        Me.Panel5.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotal.Location = New System.Drawing.Point(0, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(613, 100)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "           0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnDelete)
        Me.Panel4.Controls.Add(Me.brnCancel)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCalculator)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 553)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(613, 78)
        Me.Panel4.TabIndex = 2
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Waste_48px
        Me.btnDelete.Location = New System.Drawing.Point(184, 13)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(61, 58)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'brnCancel
        '
        Me.brnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.brnCancel.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Close_Window_48px_2
        Me.brnCancel.Location = New System.Drawing.Point(94, 13)
        Me.brnCancel.Name = "brnCancel"
        Me.brnCancel.Size = New System.Drawing.Size(61, 58)
        Me.brnCancel.TabIndex = 2
        Me.brnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Save_48px_2
        Me.btnSave.Location = New System.Drawing.Point(12, 11)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 60)
        Me.btnSave.TabIndex = 1
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCalculator
        '
        Me.btnCalculator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalculator.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Calculator_48px
        Me.btnCalculator.Location = New System.Drawing.Point(282, 11)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(58, 60)
        Me.btnCalculator.TabIndex = 0
        Me.btnCalculator.UseVisualStyleBackColor = True
        '
        'frmSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 631)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSale"
        Me.Text = "frmSale"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents listIceCream As ListView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents listTopping As ListView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents brnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCalculator As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblShowName As Label
    Friend WithEvents lblShowID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents linkCancel As LinkLabel
    Friend WithEvents linkSelect As LinkLabel
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblBill As Label
    Friend WithEvents dgvSale As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents ImageList2 As ImageList
End Class

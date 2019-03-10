<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProid = New System.Windows.Forms.TextBox()
        Me.txtProName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.picProduct = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSelectPic = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.panelRegis = New System.Windows.Forms.Panel()
        Me.cboProduct = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtgv = New System.Windows.Forms.DataGridView()
        Me.panelBTN = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.picProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelRegis.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBTN.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสสินค้า :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อสินค้า :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ราคา :"
        '
        'txtProid
        '
        Me.txtProid.Location = New System.Drawing.Point(156, 77)
        Me.txtProid.Multiline = True
        Me.txtProid.Name = "txtProid"
        Me.txtProid.Size = New System.Drawing.Size(163, 29)
        Me.txtProid.TabIndex = 1
        '
        'txtProName
        '
        Me.txtProName.Location = New System.Drawing.Point(156, 124)
        Me.txtProName.Multiline = True
        Me.txtProName.Name = "txtProName"
        Me.txtProName.Size = New System.Drawing.Size(163, 29)
        Me.txtProName.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(156, 169)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(163, 29)
        Me.txtPrice.TabIndex = 3
        '
        'picProduct
        '
        Me.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProduct.Location = New System.Drawing.Point(156, 232)
        Me.picProduct.Name = "picProduct"
        Me.picProduct.Size = New System.Drawing.Size(163, 121)
        Me.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProduct.TabIndex = 9
        Me.picProduct.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "รูปสินค้า :"
        '
        'btnSelectPic
        '
        Me.btnSelectPic.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Pictures_Folder_48px_3
        Me.btnSelectPic.Location = New System.Drawing.Point(202, 363)
        Me.btnSelectPic.Name = "btnSelectPic"
        Me.btnSelectPic.Size = New System.Drawing.Size(57, 45)
        Me.btnSelectPic.TabIndex = 5
        Me.btnSelectPic.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Save_48px_2
        Me.btnSave.Location = New System.Drawing.Point(322, 403)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(64, 53)
        Me.btnSave.TabIndex = 6
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Close_Window_48px_2
        Me.btnCancel.Location = New System.Drawing.Point(392, 403)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 53)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'panelRegis
        '
        Me.panelRegis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelRegis.Controls.Add(Me.cboProduct)
        Me.panelRegis.Controls.Add(Me.Label4)
        Me.panelRegis.Controls.Add(Me.txtProid)
        Me.panelRegis.Controls.Add(Me.btnCancel)
        Me.panelRegis.Controls.Add(Me.Label1)
        Me.panelRegis.Controls.Add(Me.btnSave)
        Me.panelRegis.Controls.Add(Me.Label2)
        Me.panelRegis.Controls.Add(Me.btnSelectPic)
        Me.panelRegis.Controls.Add(Me.Label3)
        Me.panelRegis.Controls.Add(Me.Label6)
        Me.panelRegis.Controls.Add(Me.picProduct)
        Me.panelRegis.Controls.Add(Me.txtProName)
        Me.panelRegis.Controls.Add(Me.txtPrice)
        Me.panelRegis.Location = New System.Drawing.Point(569, 16)
        Me.panelRegis.Name = "panelRegis"
        Me.panelRegis.Size = New System.Drawing.Size(469, 470)
        Me.panelRegis.TabIndex = 14
        '
        'cboProduct
        '
        Me.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduct.FormattingEnabled = True
        Me.cboProduct.Location = New System.Drawing.Point(156, 29)
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.Size = New System.Drawing.Size(163, 24)
        Me.cboProduct.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ประเภทสินค้า :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.dtgv)
        Me.Panel2.Location = New System.Drawing.Point(13, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(539, 413)
        Me.Panel2.TabIndex = 15
        '
        'dtgv
        '
        Me.dtgv.AllowUserToAddRows = False
        Me.dtgv.AllowUserToDeleteRows = False
        Me.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgv.Location = New System.Drawing.Point(0, 0)
        Me.dtgv.Name = "dtgv"
        Me.dtgv.ReadOnly = True
        Me.dtgv.RowTemplate.Height = 24
        Me.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgv.Size = New System.Drawing.Size(537, 411)
        Me.dtgv.TabIndex = 0
        '
        'panelBTN
        '
        Me.panelBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panelBTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBTN.Controls.Add(Me.btnDelete)
        Me.panelBTN.Controls.Add(Me.btnEdit)
        Me.panelBTN.Controls.Add(Me.btnAdd)
        Me.panelBTN.Location = New System.Drawing.Point(37, 439)
        Me.panelBTN.Name = "panelBTN"
        Me.panelBTN.Size = New System.Drawing.Size(500, 80)
        Me.panelBTN.TabIndex = 16
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Trash_48px
        Me.btnDelete.Location = New System.Drawing.Point(346, 6)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 64)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Pencil_Drawing_48px
        Me.btnEdit.Location = New System.Drawing.Point(216, 6)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 64)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Plus_48px
        Me.btnAdd.Location = New System.Drawing.Point(87, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 64)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 534)
        Me.Controls.Add(Me.panelBTN)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelRegis)
        Me.Name = "frmProduct"
        Me.Text = "จัดการสินค้า"
        CType(Me.picProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelRegis.ResumeLayout(False)
        Me.panelRegis.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBTN.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProid As TextBox
    Friend WithEvents txtProName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents picProduct As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSelectPic As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents panelRegis As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtgv As DataGridView
    Friend WithEvents panelBTN As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cboProduct As ComboBox
End Class

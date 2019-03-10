<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Me.dtgvEmp = New System.Windows.Forms.DataGridView()
        Me.panelRegit = New System.Windows.Forms.Panel()
        Me.btnSelectpic = New System.Windows.Forms.Button()
        Me.cbostatus = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSav = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DTBorn = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdcard = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.picAddEmp = New System.Windows.Forms.PictureBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelBTN = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtSeach = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelRegit.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picAddEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBTN.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtgvEmp)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(618, 351)
        Me.Panel1.TabIndex = 0
        '
        'dtgvEmp
        '
        Me.dtgvEmp.AllowUserToAddRows = False
        Me.dtgvEmp.AllowUserToDeleteRows = False
        Me.dtgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvEmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgvEmp.Location = New System.Drawing.Point(0, 0)
        Me.dtgvEmp.Name = "dtgvEmp"
        Me.dtgvEmp.ReadOnly = True
        Me.dtgvEmp.RowTemplate.Height = 24
        Me.dtgvEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvEmp.Size = New System.Drawing.Size(618, 351)
        Me.dtgvEmp.TabIndex = 0
        '
        'panelRegit
        '
        Me.panelRegit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panelRegit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelRegit.Controls.Add(Me.btnSelectpic)
        Me.panelRegit.Controls.Add(Me.cbostatus)
        Me.panelRegit.Controls.Add(Me.Label12)
        Me.panelRegit.Controls.Add(Me.btnCancel)
        Me.panelRegit.Controls.Add(Me.btnSav)
        Me.panelRegit.Controls.Add(Me.GroupBox1)
        Me.panelRegit.Controls.Add(Me.Label11)
        Me.panelRegit.Controls.Add(Me.DTBorn)
        Me.panelRegit.Controls.Add(Me.Label10)
        Me.panelRegit.Controls.Add(Me.txtAdress)
        Me.panelRegit.Controls.Add(Me.Label9)
        Me.panelRegit.Controls.Add(Me.txtTel)
        Me.panelRegit.Controls.Add(Me.Label8)
        Me.panelRegit.Controls.Add(Me.txtLastname)
        Me.panelRegit.Controls.Add(Me.Label7)
        Me.panelRegit.Controls.Add(Me.txtName)
        Me.panelRegit.Controls.Add(Me.Label6)
        Me.panelRegit.Controls.Add(Me.txtIdcard)
        Me.panelRegit.Controls.Add(Me.Label5)
        Me.panelRegit.Controls.Add(Me.Label4)
        Me.panelRegit.Controls.Add(Me.picAddEmp)
        Me.panelRegit.Controls.Add(Me.txtPass)
        Me.panelRegit.Controls.Add(Me.Label3)
        Me.panelRegit.Controls.Add(Me.txtUser)
        Me.panelRegit.Controls.Add(Me.Label2)
        Me.panelRegit.Controls.Add(Me.txtId)
        Me.panelRegit.Controls.Add(Me.Label1)
        Me.panelRegit.Location = New System.Drawing.Point(3, 17)
        Me.panelRegit.Name = "panelRegit"
        Me.panelRegit.Size = New System.Drawing.Size(704, 531)
        Me.panelRegit.TabIndex = 1
        '
        'btnSelectpic
        '
        Me.btnSelectpic.BackColor = System.Drawing.Color.Cyan
        Me.btnSelectpic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectpic.Location = New System.Drawing.Point(116, 264)
        Me.btnSelectpic.Name = "btnSelectpic"
        Me.btnSelectpic.Size = New System.Drawing.Size(134, 34)
        Me.btnSelectpic.TabIndex = 27
        Me.btnSelectpic.Text = "Upload Picture"
        Me.btnSelectpic.UseVisualStyleBackColor = False
        '
        'cbostatus
        '
        Me.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Items.AddRange(New Object() {"ผู้จัดการ", "พนักงาน"})
        Me.cbostatus.Location = New System.Drawing.Point(101, 6)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.Size = New System.Drawing.Size(163, 24)
        Me.cbostatus.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 17)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "ตำแหน่ง"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Close_Window_48px_2
        Me.btnCancel.Location = New System.Drawing.Point(615, 465)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 58)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSav
        '
        Me.btnSav.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSav.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Save_48px_2
        Me.btnSav.Location = New System.Drawing.Point(518, 465)
        Me.btnSav.Name = "btnSav"
        Me.btnSav.Size = New System.Drawing.Size(75, 58)
        Me.btnSav.TabIndex = 23
        Me.btnSav.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radFemale)
        Me.GroupBox1.Controls.Add(Me.radMale)
        Me.GroupBox1.Location = New System.Drawing.Point(407, 308)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 58)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(62, 18)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(54, 21)
        Me.radFemale.TabIndex = 1
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "หญิง"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(6, 18)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(50, 21)
        Me.radMale.TabIndex = 0
        Me.radMale.TabStop = True
        Me.radMale.Text = "ชาย"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(291, 326)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 17)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "เพศ"
        '
        'DTBorn
        '
        Me.DTBorn.Location = New System.Drawing.Point(407, 372)
        Me.DTBorn.Name = "DTBorn"
        Me.DTBorn.Size = New System.Drawing.Size(252, 22)
        Me.DTBorn.TabIndex = 20
        Me.DTBorn.Value = New Date(2019, 3, 8, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(288, 372)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 17)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "วัน/เดือน/ปีเกิด"
        '
        'txtAdress
        '
        Me.txtAdress.Location = New System.Drawing.Point(407, 205)
        Me.txtAdress.Multiline = True
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtAdress.Size = New System.Drawing.Size(252, 97)
        Me.txtAdress.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(288, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "ที่อยู่"
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTel.Location = New System.Drawing.Point(407, 407)
        Me.txtTel.MaxLength = 10
        Me.txtTel.Multiline = True
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(167, 34)
        Me.txtTel.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(288, 410)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "เบอร์โทร"
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(407, 162)
        Me.txtLastname.MaxLength = 30
        Me.txtLastname.Multiline = True
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(167, 37)
        Me.txtLastname.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(288, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "นามสกุล"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtName.Location = New System.Drawing.Point(407, 123)
        Me.txtName.MaxLength = 30
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(167, 33)
        Me.txtName.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(290, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ชื่อ"
        '
        'txtIdcard
        '
        Me.txtIdcard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtIdcard.Location = New System.Drawing.Point(407, 86)
        Me.txtIdcard.MaxLength = 13
        Me.txtIdcard.Multiline = True
        Me.txtIdcard.Name = "txtIdcard"
        Me.txtIdcard.Size = New System.Drawing.Size(167, 31)
        Me.txtIdcard.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(289, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "รหัสบัตรประชาชน"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "รูปภาพ"
        '
        'picAddEmp
        '
        Me.picAddEmp.BackColor = System.Drawing.Color.White
        Me.picAddEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAddEmp.Location = New System.Drawing.Point(101, 99)
        Me.picAddEmp.Name = "picAddEmp"
        Me.picAddEmp.Size = New System.Drawing.Size(163, 149)
        Me.picAddEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAddEmp.TabIndex = 6
        Me.picAddEmp.TabStop = False
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPass.Location = New System.Drawing.Point(407, 48)
        Me.txtPass.MaxLength = 30
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(167, 32)
        Me.txtPass.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(291, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUser.Location = New System.Drawing.Point(407, 9)
        Me.txtUser.MaxLength = 30
        Me.txtUser.Multiline = True
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(167, 33)
        Me.txtUser.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtId.Location = New System.Drawing.Point(101, 46)
        Me.txtId.Multiline = True
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(163, 35)
        Me.txtId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัส"
        '
        'panelBTN
        '
        Me.panelBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panelBTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBTN.Controls.Add(Me.btnDelete)
        Me.panelBTN.Controls.Add(Me.btnEdit)
        Me.panelBTN.Controls.Add(Me.btnAdd)
        Me.panelBTN.Location = New System.Drawing.Point(831, 473)
        Me.panelBTN.Name = "panelBTN"
        Me.panelBTN.Size = New System.Drawing.Size(441, 75)
        Me.panelBTN.TabIndex = 2
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Denied_48px
        Me.btnDelete.Location = New System.Drawing.Point(310, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 64)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Registration_48px
        Me.btnEdit.Location = New System.Drawing.Point(180, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 64)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Add_User_Male_48px
        Me.btnAdd.Location = New System.Drawing.Point(51, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 64)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(713, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(626, 359)
        Me.Panel2.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(862, 17)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(363, 89)
        Me.Panel5.TabIndex = 33
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txtSeach)
        Me.Panel6.Controls.Add(Me.PictureBox1)
        Me.Panel6.Location = New System.Drawing.Point(14, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(340, 79)
        Me.Panel6.TabIndex = 2
        '
        'txtSeach
        '
        Me.txtSeach.Location = New System.Drawing.Point(90, 18)
        Me.txtSeach.Multiline = True
        Me.txtSeach.Name = "txtSeach"
        Me.txtSeach.Size = New System.Drawing.Size(223, 37)
        Me.txtSeach.TabIndex = 1
        Me.txtSeach.Text = " "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Search_48px
        Me.PictureBox1.Location = New System.Drawing.Point(14, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1351, 560)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelBTN)
        Me.Controls.Add(Me.panelRegit)
        Me.Name = "frmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ระบบจัดการพนักงาน"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtgvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelRegit.ResumeLayout(False)
        Me.panelRegit.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picAddEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBTN.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtgvEmp As DataGridView
    Friend WithEvents panelRegit As Panel
    Friend WithEvents panelBTN As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DTBorn As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAdress As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIdcard As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents picAddEmp As PictureBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSav As Button
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cbostatus As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtSeach As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSelectpic As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleDetail
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
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.btnSale = New System.Windows.Forms.Button()
        Me.btnSaleDetail = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearchSale = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSearch
        '
        Me.dgvSearch.AllowUserToAddRows = False
        Me.dgvSearch.AllowUserToDeleteRows = False
        Me.dgvSearch.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSearch.Location = New System.Drawing.Point(0, 0)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.ReadOnly = True
        Me.dgvSearch.RowTemplate.Height = 24
        Me.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSearch.Size = New System.Drawing.Size(800, 456)
        Me.dgvSearch.TabIndex = 0
        '
        'btnSale
        '
        Me.btnSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSale.Location = New System.Drawing.Point(30, 16)
        Me.btnSale.Name = "btnSale"
        Me.btnSale.Size = New System.Drawing.Size(140, 46)
        Me.btnSale.TabIndex = 1
        Me.btnSale.Text = "ดูใบเสร็จ"
        Me.btnSale.UseVisualStyleBackColor = False
        '
        'btnSaleDetail
        '
        Me.btnSaleDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSaleDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaleDetail.Location = New System.Drawing.Point(209, 16)
        Me.btnSaleDetail.Name = "btnSaleDetail"
        Me.btnSaleDetail.Size = New System.Drawing.Size(140, 46)
        Me.btnSaleDetail.TabIndex = 2
        Me.btnSaleDetail.Text = "ดูยอดขาย"
        Me.btnSaleDetail.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtSearchSale)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 65)
        Me.Panel1.TabIndex = 3
        '
        'txtSearchSale
        '
        Me.txtSearchSale.Location = New System.Drawing.Point(78, 15)
        Me.txtSearchSale.Multiline = True
        Me.txtSearchSale.Name = "txtSearchSale"
        Me.txtSearchSale.Size = New System.Drawing.Size(385, 36)
        Me.txtSearchSale.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Search_48px
        Me.PictureBox1.Location = New System.Drawing.Point(17, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 456)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSaleDetail)
        Me.Panel3.Controls.Add(Me.btnSale)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 448)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 73)
        Me.Panel3.TabIndex = 5
        '
        'frmSaleDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 521)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSaleDetail"
        Me.Text = "frmSaleDetail"
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvSearch As DataGridView
    Friend WithEvents btnSale As Button
    Friend WithEvents btnSaleDetail As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearchSale As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class

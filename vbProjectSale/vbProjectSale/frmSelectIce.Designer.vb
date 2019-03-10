<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectIce
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNameIce = New System.Windows.Forms.Label()
        Me.lblIdIce = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(251, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 24)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 24)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Ice Cream ID :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(296, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "จำนวน"
        '
        'btnSelect
        '
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.Image = Global.vbProjectSale.My.Resources.Resources.icons8_Checked_Checkbox_48px
        Me.btnSelect.Location = New System.Drawing.Point(530, 85)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(44, 45)
        Me.btnSelect.TabIndex = 28
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Location = New System.Drawing.Point(177, 99)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(32, 17)
        Me.lblprice.TabIndex = 25
        Me.lblprice.Text = "......"
        '
        'txtamount
        '
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtamount.Location = New System.Drawing.Point(367, 89)
        Me.txtamount.Multiline = True
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(147, 34)
        Me.txtamount.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "ประเภทสินค้า"
        '
        'lblNameIce
        '
        Me.lblNameIce.AutoSize = True
        Me.lblNameIce.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblNameIce.Location = New System.Drawing.Point(363, 46)
        Me.lblNameIce.Name = "lblNameIce"
        Me.lblNameIce.Size = New System.Drawing.Size(35, 24)
        Me.lblNameIce.TabIndex = 20
        Me.lblNameIce.Text = "....."
        '
        'lblIdIce
        '
        Me.lblIdIce.AutoSize = True
        Me.lblIdIce.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblIdIce.Location = New System.Drawing.Point(176, 46)
        Me.lblIdIce.Name = "lblIdIce"
        Me.lblIdIce.Size = New System.Drawing.Size(35, 24)
        Me.lblIdIce.TabIndex = 19
        Me.lblIdIce.Text = "....."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "ราคา :"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblType.Location = New System.Drawing.Point(159, 7)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(25, 24)
        Me.lblType.TabIndex = 32
        Me.lblType.Text = "..."
        '
        'frmSelectIce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 136)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNameIce)
        Me.Controls.Add(Me.lblIdIce)
        Me.Name = "frmSelectIce"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSelectIce"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents lblprice As Label
    Friend WithEvents txtamount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNameIce As Label
    Friend WithEvents lblIdIce As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblType As Label
End Class

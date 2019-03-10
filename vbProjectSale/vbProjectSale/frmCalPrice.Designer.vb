<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalPrice
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
        Me.lblSale = New System.Windows.Forms.Label()
        Me.txtTotalMoney = New System.Windows.Forms.TextBox()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSale
        '
        Me.lblSale.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblSale.Font = New System.Drawing.Font("Microsoft YaHei", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSale.Location = New System.Drawing.Point(389, 37)
        Me.lblSale.Name = "lblSale"
        Me.lblSale.Size = New System.Drawing.Size(467, 100)
        Me.lblSale.TabIndex = 0
        Me.lblSale.Text = "0.00"
        Me.lblSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalMoney
        '
        Me.txtTotalMoney.Font = New System.Drawing.Font("Microsoft YaHei", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMoney.Location = New System.Drawing.Point(387, 150)
        Me.txtTotalMoney.Multiline = True
        Me.txtTotalMoney.Name = "txtTotalMoney"
        Me.txtTotalMoney.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalMoney.Size = New System.Drawing.Size(469, 100)
        Me.txtTotalMoney.TabIndex = 1
        Me.txtTotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMoney
        '
        Me.lblMoney.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblMoney.Font = New System.Drawing.Font("Microsoft YaHei", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.Location = New System.Drawing.Point(389, 263)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(467, 100)
        Me.lblMoney.TabIndex = 2
        Me.lblMoney.Text = "0.00"
        Me.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(746, 408)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(110, 55)
        Me.btnCal.TabIndex = 3
        Me.btnCal.Text = "คำนวณ"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 100)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ยอดซื้อสุทธิ"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 100)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ชำระ"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(358, 100)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "เงินทอน"
        '
        'frmCalPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 475)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.txtTotalMoney)
        Me.Controls.Add(Me.lblSale)
        Me.Name = "frmCalPrice"
        Me.Text = "frmCalPrice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSale As Label
    Friend WithEvents txtTotalMoney As TextBox
    Friend WithEvents lblMoney As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class

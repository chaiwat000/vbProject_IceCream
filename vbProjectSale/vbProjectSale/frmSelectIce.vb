Public Class frmSelectIce
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        frmSale.dgvSale.Rows.Add()
        Dim n As Integer = frmSale.dgvSale.Rows.Count - 1
        Dim type As String
        If lblType.Text = "Ice cream" Then
            type = "ถ้วย"
        Else
            type = "ชิ้น"
        End If
        With frmSale
            .dgvSale.Item(0, n).Value = lblIdIce.Text
            .dgvSale.Item(1, n).Value = lblNameIce.Text
            .dgvSale.Item(2, n).Value = type
            .dgvSale.Item(3, n).Value = lblprice.Text
            .dgvSale.Item(4, n).Value = txtamount.Text
            .dgvSale.Item(5, n).Value = Format(frmSale.dgvSale.Item(3, n).Value * frmSale.dgvSale.Item(4, n).Value)
        End With

        Dim total As Decimal
        For i = 0 To frmSale.dgvSale.RowCount - 1
            total = total + Val(frmSale.dgvSale.Item(5, i).Value)
        Next
        frmSale.lblTotal.Text = FormatNumber(total, 2)

        Me.Close()
    End Sub


End Class
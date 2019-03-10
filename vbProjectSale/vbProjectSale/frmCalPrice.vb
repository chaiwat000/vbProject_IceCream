Public Class frmCalPrice

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim moneySale As Decimal = Val(lblSale.Text)
        Dim moneyTotal As Decimal = Val(txtTotalMoney.Text)
        If moneyTotal < moneySale Then
            MessageBox.Show("ไม่สารมารถชำระสินค้าได้ กรุณาดูราคาซื้อใหม่")
            Exit Sub
        End If

        lblMoney.Text = FormatNumber(moneyTotal - moneySale)

    End Sub

End Class
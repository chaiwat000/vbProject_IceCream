Public Class frmSaleDetail
    Private Sub btnSale_Click(sender As Object, e As EventArgs) Handles btnSale.Click
        connectionDb()
        sql = "select * from Sale "
        da = New SqlClient.SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "tb")
        dgvSearch.DataSource = ds.Tables("tb")
        cn.Close()

        dgvSearch.Columns(0).HeaderText = "หมายเลขใบเสร็จ"
        dgvSearch.Columns(1).HeaderText = "รหัสพนักงานขาย"
        dgvSearch.Columns(2).HeaderText = "วันที่ขาย"
        dgvSearch.Columns(3).HeaderText = "รหัสลูกค้า"
        dgvSearch.Columns(4).HeaderText = "สถานะลูกค้า"

        dgvSearch.Columns(0).Width = 200
        dgvSearch.Columns(1).Width = 200
        dgvSearch.Columns(2).Width = 200
        dgvSearch.Columns(3).Width = 200
        dgvSearch.Columns(4).Width = 200
    End Sub

    Private Sub btnSaleDetail_Click(sender As Object, e As EventArgs) Handles btnSaleDetail.Click
        connectionDb()
        sql = "select * from Sale_Detail "
        da = New SqlClient.SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "tb")
        dgvSearch.DataSource = ds.Tables("tb")
        cn.Close()

        dgvSearch.Columns(0).HeaderText = "หมายเลขใบเสร็จ"
        dgvSearch.Columns(1).HeaderText = "รหัสสินค้า"
        dgvSearch.Columns(2).HeaderText = "ราคาสินค้า(ขาย)"
        dgvSearch.Columns(3).HeaderText = "จำนวนสินค้า(ขาย)"


        dgvSearch.Columns(0).Width = 200
        dgvSearch.Columns(1).Width = 200
        dgvSearch.Columns(2).Width = 200
        dgvSearch.Columns(3).Width = 200

    End Sub


End Class
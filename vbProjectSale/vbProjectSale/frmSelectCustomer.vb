Public Class frmSelectCustomer
    Private Sub frmSelectCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionDb()
        sql = "select cus_id, cus_name from customer "
        da = New SqlClient.SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        dgvCus.DataSource = ds.Tables("table")

        dgvCus.Columns(0).HeaderText = "รหัสลูกค้า"
        dgvCus.Columns(1).HeaderText = "ชื่อลูกค้า"

        dgvCus.Columns(0).Width = 105
        dgvCus.Columns(1).Width = 105

        cn.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        connectionDb()
        Dim i As Integer = dgvCus.CurrentCell.RowIndex
        Dim select_cus As String = dgvCus.Item(0, i).Value
        sql = "select cus_id,cus_name from Customer "
        cmd = New SqlClient.SqlCommand(sql, cn)

        frmSale.lblShowID.Text = dgvCus.Item(0, i).Value
        frmSale.lblShowName.Text = dgvCus.Item(1, i).Value

        Me.Close()
        cn.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
End Class
Public Class frmSale
    Private Sub frmSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionDb()
        sql = "select pro_id,pro_name,pro_pic from product where cat_id='ICE' "
        dt = cmdDatatable()
        Load_Sale_item(ImageList1, listIceCream, dt, My.Resources.lionel_messi_oil_painting_giclee, "pro_pic", "pro_id", "pro_name")

        sql = "select pro_id,pro_name,pro_pic from product where cat_id='TOP' "
        dt = cmdDatatable()
        Load_Sale_item(ImageList2, listTopping, dt, My.Resources.lionel_messi_oil_painting_giclee, "pro_pic", "pro_id", "pro_name")

        lblBill.Text = getNewBill()

    End Sub

    Private Sub listIceCream_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listIceCream.SelectedIndexChanged

        Dim select_ice As String = listIceCream.FocusedItem.Text
        Dim ice_split() As String = select_ice.Split("|")
        ice_split(0) = ice_split(0).ToString.Trim

        sql = "select Product.*,Categories.cat_name from product,Categories where pro_id = '" & ice_split(0) & "'"
        dt = cmdDatatable()

        Dim price As Decimal
        Dim pro_id, pro_name, cat_id As String

        price = dt.Rows(0)("pro_price")
        cat_id = dt.Rows(0)("cat_name")
        pro_id = dt.Rows(0)("pro_id")
        pro_name = dt.Rows(0)("pro_name")

        frmSelectIce.Show()
        frmSelectIce.TopMost = True

        With frmSelectIce
            .lblType.Text = cat_id
            .lblprice.Text = price
            .lblIdIce.Text = pro_id
            .lblNameIce.Text = pro_name
            .txtamount.Select()
            .txtamount.Text = ""
        End With
    End Sub


    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        frmCalPrice.Show()
        frmCalPrice.TopMost = True
        frmCalPrice.txtTotalMoney.Select()
        frmCalPrice.lblSale.Text = FormatNumber(lblTotal.Text)

    End Sub

    Private Sub brnCancel_Click(sender As Object, e As EventArgs) Handles brnCancel.Click
        'listSale.Items.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dgvSale.RowCount = 0 Then
            MessageBox.Show("ท่านไม่ได้รายการขายสินค้าใดๆ ไม่สามารถบันทึกได้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        connectionDb()

        If lblShowID.Text = "xxxx" Then
            sql = "insert into Sale (sale_id, emp_id, date,description) values(@sid, (select emp_id from Employee where emp_name='" & frmMain.lblname.Text & "'),@date,@des )"
            cmd = New SqlClient.SqlCommand(sql, cn)
            With cmd.Parameters
                .AddWithValue("sid", lblBill.Text)
                .AddWithValue("date", frmMain.lblDay.Text)
                .AddWithValue("des", "ลูกค้าไม่ได้เป็นสมากชิกร้าน")
            End With
            cmd.ExecuteNonQuery()

        Else

            sql = "insert into Sale (sale_id, emp_id, date, cus_id ,description) values(@sid, (select emp_id from Employee where emp_name='" & frmMain.lblname.Text & "'),@date , @cid, @des)"
            cmd = New SqlClient.SqlCommand(sql, cn)
            With cmd.Parameters
                .AddWithValue("sid", lblBill.Text)
                .AddWithValue("date", frmMain.lblDay.Text)
                .AddWithValue("cid", lblShowID.Text)
                .AddWithValue("des", "ลูกค้าเป็นสมากชิกร้าน")
            End With
            cmd.ExecuteNonQuery()

        End If

        For i = 0 To dgvSale.Rows.Count - 1
            sql = "insert into Sale_Detail (sale_id, pro_id, sale_price, sale_amount) values(@sidd , @pid, @sprice, @samount)"
            cmd.Parameters.Clear()
            cmd.CommandText = sql
            With cmd.Parameters
                .AddWithValue("sidd", lblBill.Text)
                .AddWithValue("pid", dgvSale.Item(0, i).Value)
                .AddWithValue("sprice", dgvSale.Item(3, i).Value)
                .AddWithValue("samount", dgvSale.Item(4, i).Value)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("add success")

        Next


        cn.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        dgvSale.Rows.RemoveAt(dgvSale.SelectedRows(0).Index)
        Dim total As Decimal
        For i = 0 To dgvSale.RowCount - 1
            total = Val(dgvSale.Item(5, i).Value) - total
        Next
        lblTotal.Text = FormatNumber(total, 2)

    End Sub

    Private Sub listTopping_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listTopping.SelectedIndexChanged
        Dim select_top As String = listTopping.FocusedItem.Text
        Dim top_split() As String = select_top.Split("|")
        top_split(0) = top_split(0).ToString.Trim

        sql = "select Product.*,Categories.cat_name from product,Categories where pro_id = '" & top_split(0) & "' "
        dt = cmdDatatable()

        Dim price As Decimal
        Dim pro_id, pro_name, cat_id As String

        price = dt.Rows(0)("pro_price")
        'cat_id = dt.Rows(0)("cat_name")
        pro_id = dt.Rows(0)("pro_id")
        pro_name = dt.Rows(0)("pro_name")

        frmSelectIce.Show()
        frmSelectIce.TopMost = True

        With frmSelectIce
            .lblType.Text = "Topping"
            .lblprice.Text = price
            .lblIdIce.Text = pro_id
            .lblNameIce.Text = pro_name
            .txtamount.Select()
            .txtamount.Text = ""
        End With
    End Sub

    Private Sub linkSelect_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSelect.LinkClicked
        Dim frmSelectCus As New frmSelectCustomer
        frmSelectCus.ShowDialog()
    End Sub

    Private Sub linkCancel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkCancel.LinkClicked
        lblShowID.Text = ""
        lblShowName.Text = ""
    End Sub
End Class
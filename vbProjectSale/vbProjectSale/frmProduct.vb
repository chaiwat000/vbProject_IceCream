Public Class frmProduct
    Dim status As String
    Dim memid As String
    Private Sub btnSelectPic_Click(sender As Object, e As EventArgs) Handles btnSelectPic.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            picProduct.Image = System.Drawing.Bitmap.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If status = "insert" Then
            connectionDb()

            sql = "select pro_id from Product where pro_id='" & txtProid.Text & "'"
            cmd = New SqlClient.SqlCommand(sql, cn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("มีไอดีนี้แล้ว")
                dr.Close()
                Exit Sub
            End If
            dr.Close()


            sql = "insert into product (cat_id, pro_id, pro_name, pro_price, pro_pic) values((select cat_id from Categories where cat_name='" & cboProduct.SelectedItem & "'), @pid, @pname, @pprice, @ppic)"
            cmd = New SqlClient.SqlCommand(sql, cn)
            cmd.Parameters.Clear()
            With cmd.Parameters

                .AddWithValue("pid", txtProid.Text)
                .AddWithValue("pname", txtProName.Text)
                .AddWithValue("pprice", txtPrice.Text)
                Dim pic As New IO.MemoryStream
                picProduct.Image.Save(pic, Imaging.ImageFormat.Bmp)
                Dim add() As Byte
                add = pic.ToArray()
                .AddWithValue("ppic", add)
            End With

            If cmd.ExecuteNonQuery = 0 Then
                MsgBox("add fail")
            Else
                sql = "select * from Product"
                da = New SqlClient.SqlDataAdapter(sql, cn)
                ds = New DataSet
                da.Fill(ds, "table")
                dtgv.DataSource = ds.Tables("table")
                MsgBox("add success")
            End If

            txtProid.Clear()
            txtProName.Clear()
            txtPrice.Clear()

            picProduct.Image = Nothing

            cn.Close()

        Else

            connectionDb()
            If memid <> txtProid.Text Then
                sql = "select pro_id from Product where pro_id='" & txtProid.Text & "'"
                cmd = New SqlClient.SqlCommand(sql, cn)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    MsgBox("มีไอดีนี้แล้ว")
                    dr.Close()
                    Exit Sub
                End If
                dr.Close()
            End If

            sql = "update Product SET cat_id=(select cat_id from Categories where cat_name='" & cboProduct.SelectedItem & "'), pro_id=@pid, pro_name=@pname, pro_price=@pprice, pro_pic=@ppic where pro_id=@newpid"
            cmd = New SqlClient.SqlCommand(sql, cn)
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("newpid", memid)
                .AddWithValue("pid", txtProid.Text)
                .AddWithValue("pname", txtProName.Text)
                .AddWithValue("pprice", txtPrice.Text)
                Dim pic As New IO.MemoryStream
                picProduct.Image.Save(pic, Imaging.ImageFormat.Bmp)
                Dim add() As Byte
                add = pic.ToArray()
                .AddWithValue("ppic", add)
            End With

            If cmd.ExecuteNonQuery = 0 Then
                MsgBox("edit fail")
            Else
                sql = "select * from Product"
                da = New SqlClient.SqlDataAdapter(sql, cn)
                ds = New DataSet
                da.Fill(ds, "table")
                dtgv.DataSource = ds.Tables("table")

                MsgBox("eidt success")
            End If
        End If
    End Sub

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionDb()
        sql = "select * from Product"
        da = New SqlClient.SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        dtgv.DataSource = ds.Tables("table")

        sql = "select cat_name from Categories "
        cmd = New SqlClient.SqlCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cboProduct.Items.Add(dr.Item("cat_name"))
                cboProduct.SelectedIndex = 0
            End While
        End If
        dr.Close()

        panelRegis.Enabled = False
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        status = "insert"
        panelBTN.Enabled = False
        panelRegis.Enabled = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        status = "update"
        panelBTN.Enabled = False
        panelRegis.Enabled = True
        memid = txtProid.Text
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv.CellClick
        connectionDb()

        Dim i As Integer = dtgv.CurrentCell.RowIndex
        Dim select_id As String = dtgv.Item(1, i).Value


        sql = "select Product.*,Categories.cat_id from Product,Categories where Product.cat_id = Categories.cat_id and pro_id='" & select_id & "'"
        cmd = New SqlClient.SqlCommand(sql, cn)
        dr = cmd.ExecuteReader
        dr.Read()

        Dim row As DataGridViewRow
        row = Me.dtgv.Rows(e.RowIndex)

        txtProid.Text = row.Cells("pro_id").Value.ToString
        txtProName.Text = row.Cells("pro_name").Value.ToString
        txtPrice.Text = row.Cells("pro_price").Value.ToString
        Dim bytes() As Byte = row.Cells("pro_pic").Value
        Dim ms As New IO.MemoryStream(bytes)
        picProduct.Image = Image.FromStream(ms)
        cboProduct.Text = dtgv.Item(0, i).Value

        If row.Cells("cat_id").Value.ToString = "ICE" Then
            cboProduct.Text = "Ice Cream"
        Else
            cboProduct.Text = "Topping"
        End If

        dr.Close()
        cn.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        connectionDb()
        Dim i As Integer = dtgv.CurrentCell.RowIndex
        Dim select_id As String = dtgv.Item(1, i).Value

        If MessageBox.Show("คุณต้องการลบข้อมูลสินค้าหรือไม่", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            sql = "delete from Product where pro_id='" & select_id & "'"
            cmd = New SqlClient.SqlCommand(sql, cn)

            If cmd.ExecuteNonQuery = 0 Then
                MsgBox("delete fail")
            Else
                sql = "select * from Product"
                da = New SqlClient.SqlDataAdapter(sql, cn)
                ds = New DataSet
                da.Fill(ds, "table")
                dtgv.DataSource = ds.Tables("table")

                MsgBox("delete success")
            End If
        Else

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        panelBTN.Enabled = True
        panelRegis.Enabled = False
    End Sub
End Class
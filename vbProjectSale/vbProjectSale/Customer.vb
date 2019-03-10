Public Class frmCustomer
    Dim status As String
    Dim gender As Boolean
    Dim memid As String
    Dim memidcard As String

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If radmale.Checked = True Then
            gender = True
        Else
            gender = True
        End If

        If status = "insert" Then
            connectionDb()

            sql = "select cus_id from Customer where cus_id='" & txtid.Text & "' "
            cmd = New SqlClient.SqlCommand(sql, cn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("มี id นี้แล้ว")
                dr.Close()
                Exit Sub
            End If
            dr.Close()

            sql = "select cus_idcard from Customer where cus_idcard='" & txtidcard.Text & "'"
            cmd = New SqlClient.SqlCommand(sql, cn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("มี idcard นี้แล้ว")
                dr.Close()
                Exit Sub
            End If
            dr.Close()


            sql = "insert into Customer (cus_id, cus_idcard, cus_name, cus_lastname, cus_gender, cus_born, cus_address, cus_tel) " &
                "values (@cid, @cidcard, @cname, @clastname, @cgender, @cborn, @caddress, @ctel)"
            cmd = New SqlClient.SqlCommand(sql, cn)
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("cid", txtid.Text)
                .AddWithValue("cidcard", txtidcard.Text)
                .AddWithValue("cname", txtname.Text)
                .AddWithValue("clastname", txtlastname.Text)
                .AddWithValue("cgender", gender)
                .AddWithValue("cborn", DTbron.Value)
                .AddWithValue("caddress", txtaddress.Text)
                .AddWithValue("ctel", txtTel.Text)
            End With

            If cmd.ExecuteNonQuery = 0 Then
                MsgBox("fail")
            Else
                sql = "select cus_id, cus_idcard, cus_name, cus_lastname, IIF(cus_gender=1,'ชาย','หญิง'), cus_born, cus_address, cus_tel from Customer"

                da = New SqlClient.SqlDataAdapter(sql, cn)
                ds = New DataSet
                da.Fill(ds, "table")
                dtgv.DataSource = ds.Tables("table")

                MsgBox("success")
            End If

            txtid.Clear()
            txtidcard.Clear()
            txtname.Clear()
            txtlastname.Clear()
            txtaddress.Clear()
            txtTel.Clear()
            radmale.Checked = True

            cn.Close()
        Else
            connectionDb()

            If memid <> txtid.Text Then
                sql = "select cus_id from Customer where cus_id='" & txtid.Text & "' "
                cmd = New SqlClient.SqlCommand(sql, cn)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    MsgBox("มี id นี้แล้ว")
                    dr.Close()
                    Exit Sub
                End If
                dr.Close()
            End If

            If memidcard <> txtidcard.Text Then
                sql = "select cus_idcard from Customer where cus_idcard='" & txtidcard.Text & "'"
                cmd = New SqlClient.SqlCommand(sql, cn)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    MsgBox("มี idcard นี้แล้ว")
                    dr.Close()
                    Exit Sub
                End If
                dr.Close()
            End If

            sql = "update Customer SET cus_id=@cid, cus_idcard=@cidcard, cus_name=@cname, cus_lastname=@clastname, cus_gender=@cgender, cus_born=@cborn," &
                "cus_address=@caddress, cus_tel=@ctel where cus_id=@newcid and cus_idcard=@newcidcard"
            cmd = New SqlClient.SqlCommand(sql, cn)
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("cid", txtid.Text)
                .AddWithValue("cidcard", txtidcard.Text)
                .AddWithValue("cname", txtname.Text)
                .AddWithValue("clastname", txtlastname.Text)
                .AddWithValue("cgender", gender)
                .AddWithValue("cborn", DTbron.Value)
                .AddWithValue("caddress", txtaddress.Text)
                .AddWithValue("ctel", txtTel.Text)
                .AddWithValue("newcid", memid)
                .AddWithValue("newcidcard", memidcard)
            End With

            If cmd.ExecuteNonQuery = 0 Then
                MsgBox("fail")
            Else
                sql = "select cus_id, cus_idcard, cus_name, cus_lastname, IIF(cus_gender=1,'ชาย','หญิง'), cus_born, cus_address, cus_tel from Customer"

                da = New SqlClient.SqlDataAdapter(sql, cn)
                ds = New DataSet
                da.Fill(ds, "table")
                dtgv.DataSource = ds.Tables("table")

                MsgBox("success")
            End If

            txtid.Clear()
            txtidcard.Clear()
            txtname.Clear()
            txtlastname.Clear()
            txtaddress.Clear()
            txtTel.Clear()
            radmale.Checked = True

            cn.Close()
        End If

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        status = "insert"
        Panel1.Enabled = True
        txtid.Select()
        btnedit.Enabled = False
        btnadd.Enabled = False
        btndelete.Enabled = False
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        status = "update"
        memid = txtid.Text
        memidcard = txtidcard.Text
        Panel1.Enabled = True
        txtid.Select()
        btnedit.Enabled = False
        btnadd.Enabled = False
        btndelete.Enabled = False
    End Sub

    Private Sub dtgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv.CellClick
        connectionDb()
        Dim i As Integer = dtgv.CurrentRow.Index
        Dim select_id As String = dtgv.Item(0, i).Value
        sql = "select * from Customer where cus_id='" & select_id & "'"
        cmd = New SqlClient.SqlCommand(sql, cn)

        txtid.Text = dtgv.Item(0, i).Value
        txtidcard.Text = dtgv.Item(1, i).Value
        txtname.Text = dtgv.Item(2, i).Value
        txtlastname.Text = dtgv.Item(3, i).Value
        txtaddress.Text = dtgv.Item(6, i).Value
        txtTel.Text = dtgv.Item(7, i).Value
        If dtgv.Item(4, i).Value = "ชาย" Then
            radmale.Checked = True
        Else
            radfemale.Checked = True
        End If

        cn.Close()
    End Sub

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select cus_id, cus_idcard, cus_name, cus_lastname, IIF(cus_gender=1,'ชาย','หญิง'), cus_born, cus_address, cus_tel from Customer"
        da = New SqlClient.SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        dtgv.DataSource = ds.Tables("table")

        Panel1.Enabled = False
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        btnedit.Enabled = True
        btnadd.Enabled = True
        btndelete.Enabled = True
        Panel1.Enabled = False
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        connectionDb()
        Dim i As Integer = dtgv.CurrentRow.Index
        Dim select_id As String = dtgv.Item(0, i).Value

        sql = "delete from Customer where cus_id='" & select_id & "'"
        cmd = New SqlClient.SqlCommand(sql, cn)

        If cmd.ExecuteNonQuery = 0 Then
            MsgBox("fail")
        Else
            sql = "select cus_id, cus_idcard, cus_name, cus_lastname, IIF(cus_gender=1,'ชาย','หญิง'), cus_born, cus_address, cus_tel from Customer"

            da = New SqlClient.SqlDataAdapter(sql, cn)
            ds = New DataSet
            da.Fill(ds, "table")
            dtgv.DataSource = ds.Tables("table")

            MsgBox("success")
        End If
        cn.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        sql = "select * from Customer where  cus_id like '%" & txtSearch.Text & "%' and cus_name like '%" & txtSearch.Text & "%'"
        da = New SqlClient.SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "tble")
        dtgv.DataSource = ds.Tables("tble")
    End Sub
End Class
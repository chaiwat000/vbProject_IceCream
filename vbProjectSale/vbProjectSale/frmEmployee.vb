Public Class frmEmployee
    Dim status As String
    Dim gender As Boolean
    Dim memUser As String
    Dim memId As String
    Dim memIdCard As String

    Private Sub btnSav_Click(sender As Object, e As EventArgs) Handles btnSav.Click
        connectionDb()
        If radMale.Checked = True Then
            gender = True
        Else
            gender = False
        End If

        If status = "insert" Then
            sql = "select emp_id from Employee where emp_id=@eid"
            cmd = New SqlClient.SqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("eid", txtId.Text)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("id ซ้ำ")
                dr.Close()
                Exit Sub
            End If
            dr.Close()

            sql = "select emp_idcard from Employee where emp_idcard=@eidcard"
            cmd = New SqlClient.SqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("eidcard", txtIdcard.Text)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("idcard ซ้ำ")
                dr.Close()
                Exit Sub
            End If
            dr.Close()

            sql = "select emp_username from Employee where emp_username=@eusername"
            cmd = New SqlClient.SqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("eusername", txtUser.Text)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("username ซ้ำ")
                dr.Close()
                Exit Sub
            End If
            dr.Close()

            sql = "insert into Employee (emp_id, emp_profile, emp_username, emp_password, emp_idcard, emp_name, emp_lastname, emp_born, emp_gender, emp_address, emp_tel, emp_status)" &
                "values (@eid, @eprofile, @eusername, @epassword, @eidcard, @ename, @elastname, @eborn, @egender, @eaddress, @etel, @estatus)"
            cmd = New SqlClient.SqlCommand(sql, cn)
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("eid", txtId.Text)
                Dim pic As New IO.MemoryStream
                picAddEmp.Image.Save(pic, Imaging.ImageFormat.Bmp)
                Dim add() As Byte
                add = pic.ToArray()
                .AddWithValue("eprofile", add)
                .AddWithValue("eusername", txtUser.Text)
                .AddWithValue("epassword", txtPass.Text)
                .AddWithValue("eidcard", txtIdcard.Text)
                .AddWithValue("ename", txtName.Text)
                .AddWithValue("elastname", txtLastname.Text)
                .AddWithValue("eborn", DTBorn.Value)
                .AddWithValue("egender", gender)
                .AddWithValue("eaddress", txtAdress.Text)
                .AddWithValue("etel", txtTel.Text)
                .AddWithValue("estatus", cbostatus.SelectedItem)
            End With

            If cmd.ExecuteNonQuery = 0 Then
                MsgBox("Fail")
            Else
                sql = "select * from Employee"
                cmdExcuteNoneQuerry(dtgvEmp)
                MsgBox("Success")
            End If

            txtId.Clear()
            txtUser.Clear()
            txtPass.Clear()
            picAddEmp.Image = Nothing
            txtName.Clear()
            txtLastname.Clear()
            txtAdress.Clear()
            txtTel.Clear()
            radMale.Checked = True
            txtIdcard.Clear()
            cbostatus.SelectedIndex = 0

            cn.Close()

        Else

            If memUser <> txtUser.Text Then
                sql = "select emp_username from Employee where emp_username=@eusername"
                cmd = New SqlClient.SqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("eusername", txtUser.Text)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    MessageBox.Show("username ซ้ำ")
                    dr.Close()
                    Exit Sub
                End If
                dr.Close()
            End If

            If memId <> txtId.Text Then
                sql = "select emp_id from Employee where emp_id=@eid"
                cmd = New SqlClient.SqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("eid", txtId.Text)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    MessageBox.Show("id ซ้ำ")
                    dr.Close()
                    Exit Sub
                End If
                dr.Close()
            End If

            If memIdCard <> txtIdcard.Text Then
                sql = "select emp_idcard from Employee where emp_idcard=@eidcard"
                cmd = New SqlClient.SqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("eidcard", txtIdcard.Text)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    MessageBox.Show("idcard ซ้ำ")
                    dr.Close()
                    Exit Sub
                End If
                dr.Close()
            End If


            sql = "update Employee set  emp_id=@eid, emp_idcard=@eidcard, emp_profile=@eprofile, emp_username=@username, emp_password=@epassword, emp_name=@ename, emp_lastname=@elastname," &
                "emp_born=@eborn, emp_gender=@egender, emp_address=@eaddress, emp_tel=@etel, emp_status=@estatus where emp_id=@enewid and emp_username=@enewusername and emp_idcard=@enewidcard "
            cmd = New SqlClient.SqlCommand(sql, cn)
            cmd.Parameters.Clear()

            With cmd.Parameters
                Dim pic As New IO.MemoryStream
                picAddEmp.Image.Save(pic, Imaging.ImageFormat.Bmp)
                Dim add() As Byte
                add = pic.ToArray()
                .AddWithValue("eid", txtId.Text)
                .AddWithValue("eprofile", add)
                .AddWithValue("username", txtUser.Text)
                .AddWithValue("epassword", txtPass.Text)
                .AddWithValue("eidcard", txtIdcard.Text)
                .AddWithValue("ename", txtName.Text)
                .AddWithValue("elastname", txtLastname.Text)
                .AddWithValue("eborn", DTBorn.Value)
                .AddWithValue("egender", gender)
                .AddWithValue("eaddress", txtAdress.Text)
                .AddWithValue("etel", txtTel.Text)
                .AddWithValue("estatus", cbostatus.SelectedItem)
                .AddWithValue("enewid", memId)
                .AddWithValue("enewusername", memUser)
                .AddWithValue("enewidcard", memIdCard)
            End With

            If cmd.ExecuteNonQuery = 0 Then
                MsgBox("Fail")
            Else
                sql = "select emp_id, emp_profile, emp_username, emp_password, emp_idcard, emp_name, emp_lastname, emp_born, IIF(emp_gender=1,'ชาย','หญิง')," &
                    "emp_address ,emp_tel ,emp_status from Employee"
                cmdExcuteNoneQuerry(dtgvEmp)
                MsgBox("Success")
            End If

            txtId.Clear()
            txtUser.Clear()
            txtPass.Clear()
            picAddEmp.Image = Nothing
            txtName.Clear()
            txtLastname.Clear()
            txtAdress.Clear()
            txtTel.Clear()
            radMale.Checked = True
            txtIdcard.Clear()
            panelRegit.Enabled = False
            panelBTN.Enabled = True

            cn.Close()

        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        status = "insert"
        panelBTN.Enabled = False
        panelRegit.Enabled = True
        txtId.Select()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        status = "update"
        panelBTN.Enabled = False
        panelRegit.Enabled = True
        memId = txtId.Text
        memUser = txtUser.Text
        memIdCard = txtIdcard.Text
    End Sub

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select emp_id, emp_profile, emp_username, emp_password, emp_idcard, emp_name, emp_lastname, emp_born, IIF(emp_gender=1,'ชาย','หญิง')," &
                    "emp_address ,emp_tel,emp_status from Employee"
        cmdExcuteNoneQuerry(dtgvEmp)
        panelRegit.Enabled = False
        cbostatus.SelectedIndex = 0
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        panelBTN.Enabled = True
        panelRegit.Enabled = False
    End Sub

    Private Sub dtgvEmp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvEmp.CellClick
        connectionDb()

        Dim i As Integer = dtgvEmp.CurrentRow.Index
        Dim Select_id As String = dtgvEmp.Item(0, i).Value

        sql = "select * from Employee where emp_id='" & Select_id & "'"
        cmd = New SqlClient.SqlCommand(sql, cn)

        txtId.Text = dtgvEmp.Item(0, i).Value
        Dim bytes() As Byte = dtgvEmp.Item(1, i).Value
        Dim ms As New IO.MemoryStream(bytes)
        picAddEmp.Image = Image.FromStream(ms)

        txtUser.Text = dtgvEmp.Item(2, i).Value
        txtPass.Text = dtgvEmp.Item(3, i).Value
        txtIdcard.Text = dtgvEmp.Item(4, i).Value
        txtName.Text = dtgvEmp.Item(5, i).Value
        txtLastname.Text = dtgvEmp.Item(6, i).Value
        DTBorn.Value = Convert.ToDateTime(dtgvEmp.Rows(e.RowIndex).Cells(7).Value)
        If dtgvEmp.Item(8, i).Value = "ชาย" Then
            radMale.Checked = True
        Else
            radFemale.Checked = True
        End If
        txtAdress.Text = dtgvEmp.Item(9, i).Value
        txtTel.Text = dtgvEmp.Item(10, i).Value
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        connectionDb()
        Dim delete As DialogResult = MessageBox.Show("คุณต้องการลบหรือมไม่", "ระบบลบพนักงาน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        Dim i As Integer = dtgvEmp.CurrentRow.Index
        Dim Select_id As String = dtgvEmp.Item(0, i).Value

        sql = "delete from Employee where emp_id='" & Select_id & "'"
        cmd = New SqlClient.SqlCommand(sql, cn)

        If cmd.ExecuteNonQuery = 0 Then
            MsgBox("Fail")
            Exit Sub
        Else
            If delete = DialogResult.Yes Then
                sql = "select emp_id, emp_profile, emp_username, emp_password, emp_idcard, emp_name, emp_lastname, emp_born, IIF(emp_gender=1,'ชาย','หญิง')," &
                    "emp_address ,emp_tel,emp_status from Employee"
                cmdExcuteNoneQuerry(dtgvEmp)
                MsgBox("Success")
                Exit Sub
            Else

            End If
        End If
    End Sub

    Private Sub btnSelectpic_Click_1(sender As Object, e As EventArgs) Handles btnSelectpic.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            picAddEmp.Image = System.Drawing.Bitmap.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
End Class
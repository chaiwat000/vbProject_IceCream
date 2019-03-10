Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text.Trim = "" Or txtPassword.Text.Trim = "" Then
            MsgBox("การล็อกอินผิดพลาด กรุณากรอกข้อมูลให้ครบ")
            Exit Sub
        End If

        connectionDb()
        sql = "select * from Employee where emp_username = '" & txtUsername.Text & "' AND emp_password = '" & txtPassword.Text & "'"
        da = New SqlClient.SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")

        If ds.Tables("table").Rows.Count <= 0 Then
            MsgBox("การล็อกอินผิดพลาด")
            txtUsername.Select()
        Else
            If ds.Tables("table").Rows(0)("emp_status") = "ผู้จัดการ" Then

                MsgBox("ล็อกอินด้วยผู้จัดการสำเร็จ")
                With frmMain
                    .lbllevel.Text = ds.Tables("table").Rows(0)("emp_status")
                    .lblname.Text = ds.Tables("table").Rows(0)("emp_name")
                    .lblDay.Text = Format(Date.Now, "dd/MM/yy")
                End With
                Me.Close()
            ElseIf ds.Tables("table").Rows(0)("emp_status") = "พนักงาน" Then

                MsgBox("ล็อกอินด้วยพนักงานสำเร็จ")
                frmMain.btnMangeEmployee.Enabled = False
                With frmMain
                    .lbllevel.Text = ds.Tables("table").Rows(0)("emp_status")
                    .lblname.Text = ds.Tables("table").Rows(0)("emp_name")
                    .lblDay.Text = Format(Date.Now, "dd/MM/yy")
                End With
                Me.Close()

            End If
        End If


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Select()
    End Sub

End Class
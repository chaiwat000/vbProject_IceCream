Public Class frmMain
    Private Sub btnSale_Click(sender As Object, e As EventArgs) Handles btnSale.Click
        frmSale.Show()
        frmSale.MdiParent = Me
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim out As DialogResult = MessageBox.Show("คุฯต้องการออกจากระบบหรือไม่", "ออกจากระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If out = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnManageProduct_Click(sender As Object, e As EventArgs) Handles btnManageProduct.Click
        Dim frmProduct As New frmProduct
        frmProduct.Show()
        frmProduct.MdiParent = Me
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmLogin As New frmLogin
        frmLogin.ShowDialog()

        'lbllevel.Text = "Admin"
        'lblname.Text = "Adminministator"
        'lblDay.Text = Format(Date.Now, "dd/MM/yy")
    End Sub

    Private Sub btnMangeEmployee_Click(sender As Object, e As EventArgs) Handles btnMangeEmployee.Click
        Dim frmEmp As New frmEmployee
        frmEmp.Show()
        frmEmp.MdiParent = Me
    End Sub

    Private Sub btnManageCustomer_Click(sender As Object, e As EventArgs) Handles btnManageCustomer.Click
        Dim frmCustomer As New frmCustomer
        frmCustomer.Show()
        frmCustomer.MdiParent = Me
    End Sub

    Private Sub btnCheckOrder_Click(sender As Object, e As EventArgs) Handles btnCheckOrder.Click
        Dim frmSale_Detail As New frmSaleDetail
        frmSale_Detail.Show()
        frmSale_Detail.MdiParent = Me
    End Sub
End Class
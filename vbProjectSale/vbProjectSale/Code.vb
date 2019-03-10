Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Module Code
    Public strcon As String = ConfigurationManager.ConnectionStrings("vbProjectSale.My.MySettings.strcon").ConnectionString
    Public cn As New SqlConnection(strcon)
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public sql As String
    Public dr As SqlDataReader
    Public dt As DataTable

    Public Sub connectionDb()
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
    End Sub

    'ฟังก์ชั่นแสดงผล listveiw จาก Database
    Friend Sub Load_Sale_item(ByVal imagelist_name As ImageList, ByVal listview_name As ListView, ByVal datatable_query As DataTable, ByVal imageError_Path As Image, ByVal columnName_picture As String, ByVal columnName_ID_Product As String, ByVal columnName_Name_product As String)
        Dim amount_row As Integer = datatable_query.Rows.Count - 1
        Dim img As Image
        Dim img_array As Byte()
        imagelist_name.Images.Clear()
        listview_name.Items.Clear()
        For idx As Integer = 0 To amount_row
            Try
                img_array = datatable_query.Rows(idx)(columnName_picture)
                Dim mem As New System.IO.MemoryStream
                mem.Write(img_array, 0, img_array.Length)
                img = Image.FromStream(mem, True)
                imagelist_name.Images.Add(Image.FromStream(mem, True))

            Catch ex As Exception
                imagelist_name.Images.Add(imageError_Path)
            End Try
            Dim name_picture As String = datatable_query.Rows(idx)(columnName_ID_Product) & " | " & datatable_query.Rows(idx)(columnName_Name_product)
            listview_name.Items.Add(name_picture, idx)
            listview_name.Refresh()
        Next
    End Sub

    Public Function cmdDatatable()
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        Return ds.Tables("table")
    End Function

    Public Sub cmdExcuteNoneQuerry(ByVal dtgv As DataGridView)
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        dtgv.DataSource = ds.Tables("table")

        dtgv.Columns(0).HeaderText = "รหัสพนักงาน"
        dtgv.Columns(1).HeaderText = "รูปประจำตัว"
        dtgv.Columns(2).HeaderText = "Usename"
        dtgv.Columns(3).HeaderText = "Password"
        dtgv.Columns(4).HeaderText = "หมายเลขบัตรประชาชน"
        dtgv.Columns(5).HeaderText = "ชื่อ"
        dtgv.Columns(6).HeaderText = "นามสกุล"
        dtgv.Columns(7).HeaderText = "วัน/เดือน/ปีเกิด"
        dtgv.Columns(8).HeaderText = "เพศ"
        dtgv.Columns(9).HeaderText = "ที่อยู่"
        dtgv.Columns(10).HeaderText = "เบอร์โทรศัพท์"
        dtgv.Columns(11).HeaderText = "ตำแหน่ง"

        dtgv.Columns(0).Width = 150
        dtgv.Columns(1).Width = 200
        dtgv.Columns(2).Width = 100
        dtgv.Columns(3).Width = 100
        dtgv.Columns(4).Width = 200
        dtgv.Columns(6).Width = 100
        dtgv.Columns(7).Width = 150
        dtgv.Columns(8).Width = 80
        dtgv.Columns(9).Width = 200
        dtgv.Columns(10).Width = 100
        dtgv.Columns(11).Width = 100

    End Sub

    'เปิดบิล
    Public Function getNewBill() As String
        Dim newBillID As String = ""
        Dim lastBillID As String

        Dim curYear As Integer = Format(Date.Now, "yyyy") + 543
        connectionDb()
        sql = "Select Max(sale_id) as maxSale from Sale Where sale_id Like 'S" & curYear & "%' "
        cmd = New SqlCommand(sql, cn)

        dr = cmd.ExecuteReader
        dr.Read()

        If Not IsDBNull(dr.Item("maxSale")) Then
            lastBillID = dr.Item("maxSale")
            lastBillID = Mid(lastBillID, 7)
            newBillID = Val(lastBillID) + 1
            Select Case newBillID.Length
                Case 1 : newBillID = "000000" & newBillID
                Case 2 : newBillID = "00000" & newBillID
                Case 3 : newBillID = "0000" & newBillID
                Case 4 : newBillID = "000" & newBillID
                Case 5 : newBillID = "00" & newBillID
                Case 6 : newBillID = "0" & newBillID
            End Select
            newBillID = "S" & curYear & "/" & newBillID
        Else
            newBillID = "S" & curYear & "/0000001"
        End If
        dr.Close()
        cn.Close()
        Return newBillID
    End Function

End Module

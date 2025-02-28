Public Class frmListKaryawan
    Private Sub frmListKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cmbSort.Properties.Items.Add("Nama Karyawan")
        'cmbSort.Properties.Items.Add("Usia")
        'cmbSort.Properties.Items.Add("Tanggal Masuk Kerja")
        'cmbSort.SelectedIndex = 0
        TampilData()
    End Sub

    Private Sub TampilData()
        Dim orderby As String
        'If cmbSort.Text = "Nama Karyawa" Then
        '    orderby = "order by NmKaryawan"
        'ElseIf cmbSort.Text = "Usia" Then
        '    orderby = "order by usia"
        'ElseIf cmbSort.Text = "Tanggal Masuk Kerja" Then
        '    orderby = "order by tglmasukkerja"
        'End If
        sq1 = "select idKaryawan,NmKaryawan,TglMasukKerja,Usia from karyawan ORDER by nmkaryawan"
        objDtTable = ExecuteQuerySQLServer(sq1, objCon)
        If objDtTable.Rows.Count > 0 Then
            GridControl1.DataSource = objDtTable
        End If
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        GridView1.Columns(2).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MMM-yyyy"

    End Sub

    Private Sub btn_add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_add.ItemClick
        Dim frmInput As New frmKaryawan
        mproses = "Add"
        frmInput.ShowDialog()
        TampilData()
    End Sub

    Private Sub btn_edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_edit.ItemClick
        mproses = "Edit"
        Dim frmInput As New frmKaryawan
        frmInput.ShowDialog()
        TampilData()
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        idKar = GridView1.GetFocusedRowCellValue(GridView1.Columns(0))
    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs)
        TampilData()
    End Sub

    Private Sub txttglMSU_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
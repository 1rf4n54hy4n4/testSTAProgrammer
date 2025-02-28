Imports DevExpress.XtraEditors
Public Class frmListKaryawan
    Private Sub frmListKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cmbSort.Properties.Items.Add("Nama Karyawan")
        'cmbSort.Properties.Items.Add("Usia")
        'cmbSort.Properties.Items.Add("Tanggal Masuk Kerja")
        'cmbSort.SelectedIndex = 0
        txtUsia1.Text = "0"
        txtUsia2.Text = "0"
        TampilData()
    End Sub

    Private Sub TampilData()
        Dim xFilter As String

        xFilter = "where ((nmKaryawan like '" & txtNmKar1.Text & "%') or (nmkaryawan like '" & txtNmKar2.Text & "%'))"
        xFilter += " and (usia >=" & CInt(FormatAngkaNol(txtUsia1.Text, True)) & " and usia <= " & CInt(FormatAngkaNol(txtUsia2.Text, True)) & ")"
        xFilter += " and (tglmasukkerja between '" & Format(dtTglKerjaIn1.EditValue, "MM/dd/yyyy") & "' and '" & Format(dtTglKerjaIn2.EditValue, "MM/dd/yyyy") & "')"
        sq1 = "select idKaryawan,NmKaryawan,TglMasukKerja,Usia from karyawan " & xFilter & " ORDER by nmkaryawan"
        objDtTable = ExecuteQuerySQLServer(sq1, objCon)
        If objDtTable.Rows.Count > 0 Then
            GridControl1.DataSource = objDtTable
        End If
        GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        GridView1.Columns(2).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns(2).DisplayFormat.FormatString = "dd-MMM-yyyy"
        GridView1.BestFitColumns()
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

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        TampilData()
    End Sub

    Private Sub mnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub btn_del_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_del.ItemClick
        If idKar = "" Then
            XtraMessageBox.Show("Anda belum menentukan karyawan", "", MessageBoxButtons.OK)
            GridControl1.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Kode Karyawan " & idKar & " akan dihapus, apakah anda sudah yakin?", "Hapus Karyawan", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            sq2 = "delete from karyawan where idkaryawan='" & idKar & "'"
            ExecuteSQLServer(sq2, objCon)
            TampilData()
        End If


    End Sub
End Class
Imports DevExpress.XtraEditors
Public Class frmKaryawan
    Private Sub frmKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If mproses = "Edit" Then
            TampilDetail()
            SimpleButton1.Enabled = False
            SimpleButton2.Enabled = True
        Else
            txtIdKar.Text = ""
            txtNama.Text = ""
            dtTgl.DateTime = Format(Now.Date, "MM/dd/yyyy")
            txtUsia.Text = "0"
            SimpleButton1.Enabled = True
            SimpleButton2.Enabled = False
        End If
    End Sub
    Private Sub TampilDetail()
        sq2 = "select * from karyawan where idkaryawan='" & idKar & "'"
        objDtTable = ExecuteQuerySQLServer(sq2, objCon)
        If objDtTable.Rows.Count > 0 Then
            txtIdKar.Text = idKar
            txtNama.Text = IIf(IsDBNull(objDtTable.Rows(0).Item("nmKaryawan")), "", objDtTable.Rows(0).Item("nmKaryawan"))
            dtTgl.EditValue = IIf(IsDBNull(objDtTable.Rows(0).Item("tglmasukkerja")), "", String.Format("{0:MM/dd/yyyy}", objDtTable.Rows(0).Item("tglmasukkerja")))
            txtUsia.Text = IIf(IsDBNull(objDtTable.Rows(0).Item("usia")), "", objDtTable.Rows(0).Item("usia"))
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txtIdKar.Text = "" Then
            XtraMessageBox.Show("kolom Id Karyawan belum diisi", "", MessageBoxButtons.OK)
            txtIdKar.Focus()
        End If
        If txtNama.Text = "" Then
            XtraMessageBox.Show("kolom Nama Karyawan belum diisi", "", MessageBoxButtons.OK)
            txtNama.Focus()
        End If
        If txtUsia.Text = "0" Then
            XtraMessageBox.Show("kolom usia Karyawan belum diisi", "", MessageBoxButtons.OK)
            txtIdKar.Focus()
        End If

        Simpan
    End Sub
    Private Sub Simpan()
        sq2 = "insert into karyawan(idkaryawan,nmkaryawan,tglmasukkerja,usia) values('" & txtIdKar.Text & "','" & txtNama.Text & "','" & Format(dtTgl.EditValue, "MM/dd/yyyy") & "'," & CInt(txtUsia.Text) & ")"
        ExecuteSQLServer(sq2, objCon)
        XtraMessageBox.Show("Data karyawan sudah disimpan", "", MessageBoxButtons.OK)
        Me.Close()
    End Sub

    Private Sub dtTgl_EditValueChanged(sender As Object, e As EventArgs) Handles dtTgl.EditValueChanged
        'txtUsia.Text = DateDiff(DateInterval.Year, dtTgl.EditValue, Now)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Me.Close()
    End Sub
    Private Sub UpdateData()
        sq2 = "update karyawan set nmkaryawan='" & txtNama.Text & "',tglmasukkerja='" & String.Format("{0:yyyy/MM/dd}", dtTgl.EditValue) & "',usia=" & CInt(txtUsia.Text) & " where idkaryawan = '" & txtIdKar.Text & "'"
        ExecuteSQLServer(sq2, objCon)
        XtraMessageBox.Show("Data karyawan sudah diupdate", "Update Data", MessageBoxButtons.OK)
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        UpdateData()
    End Sub
End Class
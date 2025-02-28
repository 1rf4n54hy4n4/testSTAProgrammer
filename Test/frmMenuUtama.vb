Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors

Partial Public Class frmMenuUtama
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
    Function IsFormActive(ByVal form As XtraForm) As Boolean
        Dim isOpened As Boolean = False
        If XtraTabbedMdiManager1.MdiParent.MdiChildren.Count > 0 Then
            For Each item In MdiChildren

                If form.Name = item.Name Then
                    XtraTabbedMdiManager1.Pages(item).MdiChild.Activate()
                    isOpened = True
                End If
            Next
            Return isOpened
        End If
    End Function
    Private Sub btnKaryawan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnKaryawan.ItemClick
        Dim frm As New frmListKaryawan
        If Not IsFormActive(frm) Then
            frm.MdiParent = Me
            frm.Show()
        End If
    End Sub
End Class

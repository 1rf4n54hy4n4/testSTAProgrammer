
Imports Microsoft.Win32
Imports System.Management
Imports System.Security.Cryptography
Imports System.IO
Imports DevExpress.XtraEditors
Imports System.Runtime.InteropServices.Marshal.GetTypeLibGuidForAssembly
Imports System.Reflection
Imports Microsoft.VisualBasic
Public Class Class1
    Public Shared Sub main()


        Try

            Dim MyCon As New AccessData.DatabaseConnection
            Dim MyConUser As New AccessData.DatabaseConnection

            xIP = GetIP()

            nameServer = My.Settings.nameServer
            dbserver = My.Settings.DBServer
            userserver = My.Settings.userServer
            passServer = My.Settings.passServer
            typeServer = My.Settings.typeserver
            If dbserver = "" Then
                xShowDialog = False
                frmSettingServer.ShowDialog()
                If xShowDialog Then
                    GoTo loadLogin
                End If
            End If
            objCon = MyCon.open(dbserver)
            If objCon.State = ConnectionState.Open Then
                xShowMain = True
                xShowDialog = True
            Else
                frmSettingServer.ShowDialog()
            End If


            If xShowMain Then
loadLogin:

                If xShowDialog Then
                    frmMenuUtama.Refresh()
                    frmMenuUtama.ShowDialog()
                    'End
                End If

                xShowMain = True
                GoTo loadLogin
            End If
            End

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)

        End Try


    End Sub
End Class

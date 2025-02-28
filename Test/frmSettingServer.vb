Public Class frmSettingServer

    Dim FileNum As Integer
    Dim Path As String

    Dim ListDatabase As New DataTable
    Dim vctr As Integer = 0, indCtr As Integer = 0, selInd As Integer = 0

    Dim tmpnameODBC, tmpnameServer, tmpKonDBCadServer, tmpuserServer, tmppassServer, tmpPort As String
    Dim tempObjCon As SqlClient.SqlConnection
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        End
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        dbserver = cmb_database.Text
        nameServer = txtNameServer.Text
        userServer = txtUsername.Text
        passServer = txtPassword.Text
        typeServer = IIf(cekAuth.Checked, "1", "0")
        'authServer = IIf(cekAuth.Checked, "1", "0")
        'Stop
        'If cmbEngine.SelectedIndex = 0 Then
        'MyCon.open(authServer)

        objCon = MyCon.open(dbserver)
        If objCon.State = ConnectionState.Open Then
            'objMySQLUser = openMySQL("fuser")
        End If
        If objCon.State = ConnectionState.Open Then

            'FileOpen(FileNum, Path, OpenMode.Binary) ', , , Len(SetConfig))
            My.Settings.DBServer = dbserver
            My.Settings.nameServer = nameServer
            My.Settings.userServer = userServer
            My.Settings.passServer = passServer
            My.Settings.typeserver = typeServer

            xShowDialog = True
            My.Settings.Save()

            Me.Close()
        End If
    End Sub

    Private Sub txtPassword_EditValueChanged(sender As Object, e As EventArgs) Handles txtPassword.EditValueChanged

    End Sub

    Dim tmpnameODBC2, tmpnameServer2, tmpKonDBCadServer2, tmpuserServer2, tmppassServer2, tmpPort2 As String
    Dim tmpauthServer As String
    Dim tmpEngine As Boolean
    Dim MyCon As New AccessData.DatabaseConnection
    Private Sub frmSettingServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Properties.PasswordChar = "●"
        'tmpnameODBC = dbserver
        tmpnameServer = nameServer
        tmpuserServer = userServer
        tmppassServer = passServer
        'tmpPort = portServer

        nameServer = My.Settings.nameServer
        userServer = My.Settings.userServer
        passServer = My.Settings.passServer
        typeServer = My.Settings.typeserver
        dbserver = My.Settings.DBServer

        tmpnameServer = nameServer
        tmpauthServer = typeServer
        cmb_database.Text = dbserver
        tmpuserServer = userServer
        tmppassServer = passServer

        txtNameServer.Text = nameServer
        txtUsername.Text = userServer
        txtPassword.Text = passServer


        cmb_database.Properties.Items.Clear()
        txtPassword_Leave(sender, e)
        cmb_database.Text = dbserver
    End Sub
    Private Sub CekServer()

        dbserver = cmb_database.Text
        nameServer = txtNameServer.Text
        userServer = txtUsername.Text
        passServer = txtPassword.Text
        typeServer = IIf(cekAuth.Checked, "1", "0")



        'Dim tmpobjcon As New 
        'Dim tmpobjConUser As New SqlClient.SqlConnection
        Dim MyCon As New AccessData.DatabaseConnection
        tempObjCon = MyCon.openCHG(typeServer, "master")


        If tempObjCon.State = ConnectionState.Open Then
            ListDatabase = ExecuteQuerySQLServer("select * from sysdatabases", tempObjCon)
            If ListDatabase.Rows.Count > 0 Then
                vctr = 0
                selInd = 0
                indCtr = 0

                Do While vctr < ListDatabase.Rows.Count
                    With ListDatabase.Rows(vctr)
                        cmb_database.Properties.Items.Add(.Item("name").ToString.ToUpper)
                        If Trim(.Item("name").ToString.ToUpper) = Trim(dbserver) Then
                            selInd = vctr
                        End If

                        vctr += 1
                    End With
                Loop
                cmb_database.SelectedIndex = selInd

            End If
        End If



    End Sub
    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        CekServer()
    End Sub
End Class
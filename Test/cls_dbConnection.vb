Namespace AccessData
    Public Class DatabaseConnection
        Public Function open(ByVal typeSERVER As String) As SqlClient.SqlConnection
            Try
                If typeSERVER = "1" Then
                    objCon = New SqlClient.SqlConnection("Server='" & nameServer & "';Database='" & dbserver & "'; Trusted_Connection=True;")
                Else
                    objCon = New SqlClient.SqlConnection("Server='" & nameServer & "';Database='" & dbserver & "';User ID='" & userServer & "';Password='" & passServer & "'")
                End If
                objCon.Open()
                Return objCon
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
                Return objCon
            End Try

        End Function

        Public Function openCHG(ByVal typeSERVER As String, ByVal namaDatabase As String) As SqlClient.SqlConnection
            'Server = Nama dimana kita menginstall SQL server
            'Database = Nama database yang akan di akses
            'User ID= Account untuk SQL server, sebagai default sa (system administrator)
            'Password = Password untuk login ke SQL server
            'Dim conect As New SqlClient.SqlConnection("Server='" & nameServer & "';Database='" & nameODBC_user & "'; Trusted_Connection=True;")

            Dim objC As New SqlClient.SqlConnection
            Try
                If typeSERVER = "1" Then
                    objC = New SqlClient.SqlConnection("Server='" & nameServer & "';Database='" & namaDatabase & "'; Trusted_Connection=True;")
                Else
                    objC = New SqlClient.SqlConnection("Server='" & nameServer & "';Database='" & namaDatabase & "';User ID='" & userServer & "';Password='" & passServer & "'")
                End If
                'SqlClient.SqlConnection("Server='TESTSERVER';Database='Coba'; " & _
                '" User ID='sa';Password='testserver'")
                objC.Open()
                Return objC
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Perhatian")
                'objCon = Nothing
                Return objC
            End Try

        End Function

    End Class
End Namespace


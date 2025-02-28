
Module ModProgram


    Public xIP As String
    Public nameServer As String
    Public dbserver As String
    Public userServer As String
    Public passServer As String
    Public typeServer As String = ""
    Public xShowMain As Boolean
    Public xShowDialog As Boolean
    Public objCon As SqlClient.SqlConnection
    Public objDtTable As DataTable
    Public mproses, xaksi As String
    Public sq1, sq2 As String
    Public idKar As String
    Public Function GetIP() As String
        Dim sam As System.Net.IPAddress
        Dim sam1 As String

        With System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName())
            sam = New System.Net.IPAddress(.AddressList(0).Address)
            sam1 = sam.ToString
        End With
        Return sam1.ToString
    End Function
    Public Function ExecuteQuerySQLServer(ByVal mSQL0 As String, ByVal objC As SqlClient.SqlConnection) As DataTable
        Dim objDtAdapter As New SqlClient.SqlDataAdapter
        Dim objDtTable As New DataTable
        Dim objDtSet As New DataSet

        objDtSet = New DataSet
        objDtAdapter.SelectCommand = New SqlClient.SqlCommand(mSQL0, objC)
        objDtAdapter.Fill(objDtSet)
        objDtTable = objDtSet.Tables(0)
        Return objDtTable
    End Function
    Public Function FormatAngkaNol(ByVal text As String, ByVal nol As Boolean) As String
        Dim ret As String
        If Not nol Then
            If Val(text) = 0 Then
                ret = ""
            Else
                ret = String.Format("{0:n0}", Double.Parse(text))
            End If
        Else
            If Val(text) = 0 Then
                ret = "0"
            Else
                ret = String.Format("{0:n0}", Double.Parse(text))
            End If
        End If
        Return ret
    End Function
    Public Sub ExecuteSQLServer(ByVal mSQL0 As String, ByVal objC As SqlClient.SqlConnection)
        Dim objCommand As SqlClient.SqlCommand
        objCommand = New SqlClient.SqlCommand(mSQL0)
        objCommand.Connection = objC
        objCommand.ExecuteNonQuery()
    End Sub
End Module

Imports System.Web
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Public Class wipe

    Public Shared Function wipe()

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "DELETE FROM Developers WHERE DID > 0"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Developers")
        cnn.Close()

        SQLQuery = "DELETE FROM Features WHERE GID > 0"
        MDBConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim dss As New DataSet
        Dim con As OleDbConnection = New OleDbConnection(MDBConnectionString)

        con.Open()

        Dim cm As New OleDbCommand(SQLQuery, con)
        Dim dad As New OleDbDataAdapter(cm)
        dad.Fill(dss, "Features")
        con.Close()


        SQLQuery = "DELETE FROM Games WHERE Title CONTAINS ''"
        MDBConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim d As New DataSet
        Dim cn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cn.Open()

        Dim cmdd As New OleDbCommand(SQLQuery, cn)
        Dim du As New OleDbDataAdapter(cmdd)
        du.Fill(d, "Games")
        cn.Close()

        Return "True"
    End Function
End Class

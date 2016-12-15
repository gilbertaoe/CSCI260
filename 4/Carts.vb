Imports System
Imports System.Threading.Tasks
Imports System.Security.Claims
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security
Imports System.Data.OleDb

Public Class Carts
    Public Shared Function insert(GID As String, CID As String)
        If GID Is Nothing Or GID Is "" Then
            Return "Nothing"
        End If

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * From Carts WHERE CID = " & CID & ""
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database2.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Carts")
        cnn.Close()

        For Each row As DataRow In ds.Tables(0).Rows
            If GID = row.ItemArray(1) Then
                Return "Already In Cart"
            End If
        Next

        '/////////////////////////////
        SQLQuery = "INSERT INTO Carts (GID, CID) VALUES (" & GID & ", " & CID & ")"
        MDBConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database2.accdb;"
        ds = New DataSet
        cnn = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        cmd = New OleDbCommand(SQLQuery, cnn)
        da = New OleDbDataAdapter(cmd)
        da.Fill(ds, "Carts")
        cnn.Close()

        Return "True"
    End Function

    Public Shared Function getView()

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Carts"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database2.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Carts")
        cnn.Close()

        Return ds
    End Function

    Public Shared Function getCustomersCart(CID As String)

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Carts WHERE CID = " & CID & ""
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database2.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Carts")
        cnn.Close()

        Return ds
    End Function

    Public Shared Function deleteFromCart(GID As String, CID As String)

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "DELETE FROM Carts WHERE GID = " & GID & " AND CID = " & CID & ""
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database2.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Carts")
        cnn.Close()

        Return ds
    End Function
End Class
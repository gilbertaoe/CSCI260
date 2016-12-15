Imports System
Imports System.Threading.Tasks
Imports System.Security.Claims
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security
Imports System.Data.OleDb

Public Class Customers
    Public Shared Function insert(Name As String, Amount As String)

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "INSERT INTO Customers (Name, Amount) VALUES ('" & Name & "', " & Amount & ")"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database2.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Customers")
        cnn.Close()

        Return "True"
    End Function

    Public Shared Function insertLogin(CID As String, p As String)

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "INSERT INTO LogIn VALUES (" & CID & ", '" & p & "')"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database2.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "LogIn")
        cnn.Close()

        Return "True"
    End Function

    Public Shared Function getCID(Name As String)
        If Name Is Nothing Or Name Is "" Then
            Return "Nothing"
        End If

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Customers"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database2.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Customers")
        cnn.Close()

        For Each row As DataRow In ds.Tables(0).Rows
            Dim arg = row.ItemArray(1)
            If Name.Contains(" ") Then
                Dim args() = Name.Split(" ")
                If arg.Equals(args(1)) Then
                    Return row.ItemArray(0)
                End If
            Else
                If arg.Equals(Name) Then
                    Return row.ItemArray(0)
                End If
            End If
        Next

        Return "False"
    End Function

    Public Shared Function getView()

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Customers"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database2.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Customers")
        cnn.Close()

        Return ds
    End Function

    Public Shared Function getGamesBoughtByCustomer(name As String)

        If name Is Nothing Then
            Return 0
        End If

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT Games.Title FROM Games INNER JOIN Bought_By ON Games.GID = Bought_By.GID WHERE Bought_By.CID = (SELECT Customers.CID FROM Customers WHERE Name = '" & name & "')"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database2.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Games")
        cnn.Close()

        Return ds
    End Function


    Public Shared Function getLogin(name As String)

        If name Is Nothing Then
            Return 0
        End If

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT Password FROM LogIn  WHERE CID = (SELECT Customers.CID FROM Customers WHERE Name = '" & name & "')"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database2.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Games")
        cnn.Close()

        Return ds.Tables(0).Rows(0).ItemArray(0)
    End Function

End Class
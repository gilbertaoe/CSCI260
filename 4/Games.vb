Imports System
Imports System.Threading.Tasks
Imports System.Security.Claims
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security
Imports System.Data.OleDb

Public Class Games
    Public Shared Function insert(GID As String, Title As String, Price As String)
        If GID Is Nothing Or GID Is "" Then
            Return "Nothing"
        End If

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "INSERT INTO Games (GID, Title, Price) VALUES (" & GID & ", '" & Title & "', " & Price & ")"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database2.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Games")
        cnn.Close()

        Return "True"
    End Function

    Public Shared Function getView2()

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT GID, Price FROM Games"
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

    Public Shared Function getView1()

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT Title FROM Games"
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

    Public Shared Function getView()

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Games"
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

    Public Shared Function getGames(stuff)
        If stuff(0) Is Nothing Then
            Return "Nothing"
        End If
        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Games WHERE"
        Dim i = 0
        For Each s As String In stuff
            If s IsNot Nothing Then
                If i = 0 Then
                    SQLQuery += " GID = " & s & ""

                Else
                    SQLQuery += " OR GID = " & s & ""
                End If
            End If
            i += 1
        Next
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

    Public Shared Function getQuery(query As String)
        If query.Equals("ALL") Or query Is Nothing Then
            Dim blnAdminUser As Boolean = False
            Dim SQLQuery As String = "SELECT * FROM Games"
            Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database2.accdb;"
            Dim ds As New DataSet
            Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

            cnn.Open()

            Dim cmd As New OleDbCommand(SQLQuery, cnn)
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(ds, "Games")
            cnn.Close()

            Return ds

        Else
            Dim blnAdminUser As Boolean = False
            Dim SQLQuery As String = "SELECT * FROM Games WHERE Title LIKE '%" + query + "%'"
            Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database2.accdb;"
            Dim ds As New DataSet
            Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

            cnn.Open()

            Dim cmd As New OleDbCommand(SQLQuery, cnn)
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(ds, "Games")
            cnn.Close()

            Return ds
        End If


    End Function

    Public Shared Function getCustomersUnderGame(name As String)

        If name Is Nothing Then
            Return 0
        End If

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT Customers.Name FROM Customers INNER JOIN Bought_By ON Customers.CID = Bought_By.CID WHERE Bought_By.GID = (SELECT Games.GID FROM Games WHERE Title = '" & name & "')"
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

    Public Shared Function getGameDetails(title As String)

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Games WHERE Title = '" & title & "'"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database2.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Games")
        cnn.Close()

        Return ds.Tables(0).Rows(0)
    End Function

    Public Shared Function getGameDetails2(GID As String)

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Games WHERE GID = " & GID & ""
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database2.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Games")
        cnn.Close()

        Return ds.Tables(0).Rows(0)
    End Function

    Public Shared Function getGIDs()

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Games"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database2.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Games")
        cnn.Close()

        Dim list(ds.Tables(0).Rows.Count) As Int32
        Dim i = 0

        For Each row As DataRow In ds.Tables(0).Rows
            Dim data = row.ItemArray()
            list(i) = data(0)

            i = i + 1
        Next

        Return list
    End Function
End Class
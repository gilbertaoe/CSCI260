Imports System.Web
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Public Class games

    Public Shared Function insert(name As String, feat As String, DIDname As String)
        If name Is Nothing Or name Is "" Then
            Return "Nothing"
        End If

        Dim stuff(2) As Integer

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT GID FROM Features WHERE Feature = '" & feat & "'"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Games")
        cnn.Close()

        stuff(0) += ds.Tables(0).Rows(0).Item(0)

        '///////////////////////////////////////////////////////////////////////////////
        SQLQuery = "SELECT DID FROM Developers WHERE Name = '" & DIDname & "'"
        MDBConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        ds = New DataSet
        cnn = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        cmd = New OleDbCommand(SQLQuery, cnn)
        da = New OleDbDataAdapter(cmd)
        da.Fill(ds, "Games")
        cnn.Close()

        stuff(1) += ds.Tables(0).Rows(0).Item(0)

        '///////////////////////////////////////////////////////////
        SQLQuery = "INSERT INTO Games (GID, Title, DID) VALUES (" & stuff(0) & ",'" & name & "', " & stuff(1) & ")"
        MDBConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        ds = New DataSet
        cnn = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        cmd = New OleDbCommand(SQLQuery, cnn)
        da = New OleDbDataAdapter(cmd)
        da.Fill(ds, "Games")
        cnn.Close()

        Return "True"
    End Function

    Public Shared Function delete(title As String)
        If title Is Nothing Then
            Return "Nothing"
        End If

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "DELETE FROM Games WHERE Title = '" & title & "'"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Games")
        cnn.Close()

        Return "True"
    End Function

    Public Shared Function getView()

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Games"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Games")
        cnn.Close()

        Return ds
    End Function
    Public Shared Function getData()

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Games"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Games")
        cnn.Close()
        Dim str(2) As String
        Dim i As Integer = ds.Tables(0).Rows.Count
        str(0) = "" + "!"
        str(1) = "" + "!"
        str(2) = "" + "!"
        For Number = 0 To (i - 1)
            If Number = (i - 1) Then
                str(0) += ds.Tables(0).Rows(Number).Item(0).ToString()
                str(1) += ds.Tables(0).Rows(Number).Item(1).ToString()
                str(2) += ds.Tables(0).Rows(Number).Item(2).ToString()
                Return str
            End If
            str(0) += ds.Tables(0).Rows(Number).Item(0).ToString() + "!"
            str(1) += ds.Tables(0).Rows(Number).Item(1).ToString() + "!"
            str(2) += ds.Tables(0).Rows(Number).Item(2).ToString() + "!"

        Next

        Return str
    End Function
    Public Shared Function modify(title As String, titleNow As String)
        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "UPDATE Games
                                  SET Title = '" & title & "'
                                  WHERE Title = '" & titleNow & "'"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Games")
        cnn.Close()

        Return "True"
    End Function
    Public Shared Function wipe()

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "DELETE FROM Games WHERE DID > 0"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Games")
        cnn.Close()

        Return "True"
    End Function
End Class

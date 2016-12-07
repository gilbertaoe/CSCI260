Imports System.Web
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Public Class features

    Public Shared Function insert(name As String)
        If name Is Nothing Or name Is "" Then
            Return "Nothing"
        End If

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "INSERT INTO Features (Feature) VALUES ('" & name & "')"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Features")
        cnn.Close()

        Return "True"
    End Function

    Public Shared Function delete(feature As String)
        If feature Is Nothing Then
            Return "Nothing"
        End If

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "DELETE Games.* FROM Games
                                    INNER JOIN Features ON Games.GID = Features.GID
                                    WHERE Features.Feature = '" & feature & "'"

        '"DELETE FROM Developers WHERE Name = '" & name & "'"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Games")
        cnn.Close()

        SQLQuery = "DELETE FROM Features WHERE Feature = '" & feature & "'"
        MDBConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        ds = New DataSet
        cnn = New OleDbConnection(MDBConnectionString)


        cnn.Open()

        cmd = New OleDbCommand(SQLQuery, cnn)
        da = New OleDbDataAdapter(cmd)
        da.Fill(ds, "Features")
        cnn.Close()

        Return "True"
    End Function

    Public Shared Function getView()

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Features"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Features")
        cnn.Close()
        Return ds
    End Function

    Public Shared Function getRows()
        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Features"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Features")
        cnn.Close()

        Dim count As Integer = ds.Tables(0).Rows.Count

        Return count
    End Function

    Public Shared Function getData()

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Features"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Features")
        cnn.Close()
        Dim str(1) As String
        Dim i As Integer = ds.Tables(0).Rows.Count
        str(0) = "" + "!"
        str(1) = "" + "!"
        For Number = 0 To (i - 1)
            If Number = (i - 1) Then
                str(0) += ds.Tables(0).Rows(Number).Item(0).ToString()
                str(1) += ds.Tables(0).Rows(Number).Item(1).ToString()
                Return str
            End If
            str(0) += ds.Tables(0).Rows(Number).Item(0).ToString() + "!"
            str(1) += ds.Tables(0).Rows(Number).Item(1).ToString() + "!"


        Next

        Return str
    End Function
    Public Shared Function modify(feature As String, GID As String)
        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "UPDATE Features
                                  SET Feature = '" & feature & "'
                                  Where GID = " & GID
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Features")
        cnn.Close()

        Return "True"
    End Function
    Public Shared Function wipe()

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "DELETE FROM Features WHERE GID > 0"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Features")
        cnn.Close()

        Return "True"
    End Function
End Class

Imports System.Web
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Public Class developers

    Public Shared Function insert(name As String)
        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "INSERT INTO Developers (Name, GameNo) VALUES ('" & name & "', 0)"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Developers")
        cnn.Close()

        Return "True"
    End Function

    Public Shared Function delete(name As String)

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "DELETE Games.* FROM Games
                                    INNER JOIN Developers ON Games.DID = Developers.DID
                                    WHERE Developers.Name = '" & name & "'"

        '"DELETE FROM Developers WHERE Name = '" & name & "'"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Games")
        cnn.Close()

        SQLQuery = "DELETE FROM Developers WHERE Name = '" & name & "'"

        '"DELETE FROM Developers WHERE Name = '" & name & "'"
        MDBConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        ds = New DataSet
        cnn = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        cmd = New OleDbCommand(SQLQuery, cnn)
        da = New OleDbDataAdapter(cmd)
        da.Fill(ds, "Developers")
        cnn.Close()

        Return "True"
    End Function

    Public Shared Function getView()

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Developers"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Developers")
        cnn.Close()

        Return ds
    End Function
    Public Shared Function getData()

        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Developers"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Developers")
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
    End Function

    Public Shared Function getRows()
        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Developers"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Developers")
        cnn.Close()

        Dim count As Integer = ds.Tables(0).Rows.Count

        Return count
    End Function
    Public Shared Function modify(name As String, DID As String)
        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "UPDATE Developers
                                  SET Name = '" & name & "'
                                  Where DID = " & DID
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Developers")
        cnn.Close()

        Return "True"
    End Function

    Public Shared Function update()
        Dim blnAdminUser As Boolean = False
        Dim SQLQuery As String = "SELECT * FROM Games INNER JOIN Developers ON Developers.DID = Games.DID"
        Dim MDBConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        Dim ds As New DataSet
        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        Dim cmd As New OleDbCommand(SQLQuery, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, "Games")
        cnn.Close()

        Dim goal As Integer = ds.Tables(0).Rows.Count()
        Dim args(goal - 1) As String
        Dim args2(goal - 1) As String

        For i As Integer = 0 To (goal - 1)
            args(i) = ds.Tables(0).Rows(i).Item(0).ToString()
        Next

        Dim a = args(0)







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

        SQLQuery = "DELETE FROM Developers WHERE DID > 0"
        MDBConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gilbe\Documents\Database1.accdb;"
        ds = New DataSet
        cnn = New OleDbConnection(MDBConnectionString)

        cnn.Open()

        cmd = New OleDbCommand(SQLQuery, cnn)
        da = New OleDbDataAdapter(cmd)
        da.Fill(ds, "Developers")
        cnn.Close()

        SQLQuery = "DELETE FROM Features WHERE GID > 0"
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
End Class

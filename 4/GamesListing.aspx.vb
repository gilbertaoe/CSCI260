Public Class adminHub
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim g As DataSet = WebApplication1.Games.getView()
        Dim data As DataTable = New DataTable()


        data.Columns.Add("GID", GetType(Integer))
        data.Columns.Add("Title", GetType(String))
        data.Columns.Add("Price", GetType(Double))




        For i = 0 To g.Tables(0).Rows.Count - 1
            data.Rows.Add(g.Tables(0).Rows(i).ItemArray(0), g.Tables(0).Rows(i).ItemArray(1), g.Tables(0).Rows(i).ItemArray(2))
        Next

        grid.DataSource = data
        grid.DataBind()


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox("", 0)
    End Sub

    Protected Function ProcessMyDataItem(myValue As Object)
        If myValue Is Nothing Then
            Return "0 value"
        End If

        Return myValue.ToString()
    End Function

    Protected Sub Unnamed_Click(sender As Object, e As EventArgs)
        Response.Redirect("AdminHub.aspx")
    End Sub

End Class
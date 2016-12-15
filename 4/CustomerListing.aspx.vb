Public Class Details
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim c = WebApplication1.Customers.getView()

        Dim data As DataTable = New DataTable()


        data.Columns.Add("CID", GetType(Integer))
        data.Columns.Add("Name", GetType(String))
        data.Columns.Add("Amount", GetType(Double))


        For i = 0 To c.Tables(0).Rows.Count - 1
            data.Rows.Add(c.Tables(0).Rows(i).ItemArray(0), c.Tables(0).Rows(i).ItemArray(1), c.Tables(0).Rows(i).ItemArray(2))
        Next

        Table.DataSource = data
        Table.DataBind()
    End Sub

    Protected Sub Unnamed_Click(sender As Object, e As EventArgs)
        Response.Redirect("AdminHub.aspx")
    End Sub
End Class
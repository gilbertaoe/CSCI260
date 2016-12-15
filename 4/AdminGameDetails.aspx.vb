Public Class AdminGameDetails
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim details = Request("Details")

        Dim c As DataSet = WebApplication1.Games.getCustomersUnderGame(details)

        Table.DataSource = c
        Table.DataBind()
    End Sub

    Protected Sub Unnamed_Click(sender As Object, e As EventArgs)
        Response.Redirect("GamesListing.aspx")
    End Sub
End Class
Public Class AdminHub1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Unnamed_Click(sender As Object, e As EventArgs)
        Response.Redirect("GamesListing.aspx")
    End Sub

    Protected Sub Unnamed_Click1(sender As Object, e As EventArgs)
        Response.Redirect("CustomerListing.aspx")
    End Sub

    Protected Sub Unnamed_Click2(sender As Object, e As EventArgs)
        Response.Redirect("EnterGame.aspx")
    End Sub
End Class
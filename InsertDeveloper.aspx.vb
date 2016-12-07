Public Class InsertDeveloper
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Insert_Click(sender As Object, e As EventArgs)
        Dim name = Request.Form("developerName")
        WebApplication1.developers.insert(name)
        Response.Redirect("InsertConfirm.aspx")

    End Sub

End Class
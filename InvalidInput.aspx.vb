Public Class InvalidInput
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub GoHome_Click()
        Response.Redirect("Default.aspx")
    End Sub

End Class
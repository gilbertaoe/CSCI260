Public Class SignUp
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Unnamed_Click(sender As Object, e As EventArgs)
        Dim u = userName.Text
        Dim p = password.Text

        If u Is Nothing Or p Is Nothing Then
            Return
        End If

        WebApplication1.Customers.insert(u, 0)

        Dim cid = WebApplication1.Customers.getCID(u)

        WebApplication1.Customers.insertLogin(cid, p)

        Response.Redirect("Default.aspx")
    End Sub
End Class
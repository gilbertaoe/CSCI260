Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub Unnamed_Click(sender As Object, e As EventArgs)
        Dim s = selection.SelectedValue
        Dim u = Request.Form("username")
        Dim p = Request.Form("password")

        If s Is "Admin" And u = "Admin" And p = "1234" Then
            Response.Redirect("AdminHub.aspx")
        Else
            Dim pass = WebApplication1.Customers.getLogin(u)
            If pass = p Then
                Response.Redirect("CustomerHub.aspx?Name=" + u + "")
            Else
                MsgBox("Invalid Username or Password", 0)
            End If
        End If
    End Sub

    Protected Sub Sign_Up(sender As Object, e As EventArgs)
        Response.Redirect("SignUp.aspx")
    End Sub
End Class
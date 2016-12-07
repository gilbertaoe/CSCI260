Public Class About
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim games() As String = WebApplication1.games.getData()
        Dim list As String() = games(1).Split("!")
        DropDownList1.DataSource = list
        DropDownList1.SelectedValue = DropDownList1.SelectedValue
        DropDownList1.DataBind()
    End Sub

    Protected Sub Delete_Click(sender As Object, e As EventArgs)

        Dim arg = DropDownList1.SelectedValue
        Dim res = WebApplication1.games.delete(arg)
        If res Is "Nothing" Then
            Response.Redirect("InvalidInput.aspx")
        End If
        Response.Redirect("DeleteConfirm.aspx")

    End Sub
End Class
Public Class ModifyGame
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim games() As String = WebApplication1.games.getData()
        Dim list As String() = games(1).Split("!")
        DropDownList1.DataSource = list
        DropDownList1.SelectedValue = DropDownList1.SelectedValue
        DropDownList1.DataBind()
    End Sub

    Protected Sub Modify_Click()
        Dim games() As String = WebApplication1.games.getData()
        Dim list As String() = games(1).Split("!")
        Dim name = Request.Form("stuff")
        Dim i = DropDownList1.SelectedIndex
        Dim res = WebApplication1.games.modify(name, list(i))
        If res Is "Nothing" Then
            Response.Redirect("InvalidInput.aspx")
        End If
        Response.Redirect("ModifyConfirm.aspx")
    End Sub

End Class
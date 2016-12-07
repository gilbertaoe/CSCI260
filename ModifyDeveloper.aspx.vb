Public Class ModifyDeveloper
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim devs() As String = WebApplication1.developers.getData()
        Dim list As String() = devs(1).Split("!")
        DropDownList1.DataSource = list
        DropDownList1.SelectedValue = DropDownList1.SelectedValue
        DropDownList1.DataBind()
    End Sub

    Protected Sub Modify_Click()
        Dim devs() As String = WebApplication1.developers.getData()
        Dim list As String() = devs(0).Split("!")
        Dim name = Request.Form("stuff")
        Dim i = DropDownList1.SelectedIndex
        Dim res = WebApplication1.developers.modify(name, list(i))
        If res Is "Nothing" Then
            Response.Redirect("InvalidInput.aspx")
        End If
        Response.Redirect("ModifyConfirm.aspx")
    End Sub

End Class
Public Class DeleteFeatures
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim feats() As String = WebApplication1.features.getData()
        Dim list As String() = feats(1).Split("!")
        DropDownList1.DataSource = list
        DropDownList1.SelectedValue = DropDownList1.SelectedValue
        DropDownList1.DataBind()
    End Sub

    Protected Sub Delete_Click(sender As Object, e As EventArgs)

        Dim arg = DropDownList1.SelectedValue
        Dim res = WebApplication1.features.delete(arg)
        If res Is "Nothing" Then
            Response.Redirect("InvalidInput.aspx")
        End If
        Response.Redirect("DeleteConfirm.aspx")

    End Sub

End Class
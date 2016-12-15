Public Class CustomerHub
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'NavigateUrl='<%# Eval("Name", "~/AdminCustomerDetails.aspx?Details={0}") %>'
    End Sub

    Protected Sub startSearch()
        Dim name = Request("Name")
        Dim searchFor As String = Request.Form("search")
        If searchFor Is Nothing Or searchFor = "" Then
            Response.Redirect("searchResults.aspx?searchFor=ALL&Name= " + name + "")
        Else
            Response.Redirect("searchResults.aspx?searchFor=" + searchFor + "&Name= " + name + "")
        End If
    End Sub

    Protected Sub toCart()
        Dim name = Request("Name")
        Response.Redirect("Cart.aspx?Name=" + name + "")
    End Sub

    Protected Sub signCustomerOut()
        Response.Redirect("Default.aspx")
    End Sub

    Protected Sub toAccount()
        Dim name = Request("Name")
        Response.Redirect("CustomerAccount.aspx?Name=" + name + "")
    End Sub

End Class
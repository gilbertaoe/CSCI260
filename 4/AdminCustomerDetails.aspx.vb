Public Class AdminCustomerDetails
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim details = Request("Details")

        Dim c As DataSet = WebApplication1.Customers.getGamesBoughtByCustomer(details)

        Table.DataSource = c
        Table.DataBind()
    End Sub

    Protected Sub Unnamed_Click(sender As Object, e As EventArgs)
        Response.Redirect("CustomerListing.aspx")
    End Sub
End Class
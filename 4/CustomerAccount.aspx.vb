Public Class CustomerAccount
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim n = Request("Name")

        Dim c = WebApplication1.Customers.getCID(n)

        name.Text = n & "                          ."
        cid.Text = c

        Dim gids As DataSet = WebApplication1.Bought_By.getView(c)
        Dim glist = New List(Of String)

        For Each row As DataRow In gids.Tables(0).Rows
            glist.Add(row.ItemArray(0))
        Next

        Dim result As DataSet = WebApplication1.Games.getGames(glist)
        '////

        Dim data As DataTable = New DataTable()

        data.Columns.Add("Title", GetType(String))

        For Each row As DataRow In result.Tables(0).Rows
            data.Rows.Add(row.ItemArray(1))
        Next

        grid.DataSource = Data
        grid.DataBind()

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

    Protected Sub CustomerHub()
        Dim name = Request("Name")
        Response.Redirect("CustomerHub.aspx?Name=" + name + "")
    End Sub

    Protected Sub Name_Click(sender As Object, e As EventArgs)
        Dim btn As LinkButton = DirectCast(sender, LinkButton)
        Dim test = btn.CommandArgument

        Dim mss As DataRow = WebApplication1.Games.getGameDetails(test)

        Dim str = "GID: " & mss.ItemArray(0).ToString() & vbNewLine & "Title: " & mss.ItemArray(1).ToString() & vbNewLine & "Price: " & mss.ItemArray(2).ToString() & ""

        MsgBox(str, 0)

    End Sub

End Class
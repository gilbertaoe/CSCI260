Public Class searchResults
    Inherits System.Web.UI.Page
    Dim data As DataTable = New DataTable()
    Dim result As DataSet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            Return
        End If
        Dim query = Request("searchFor")

        result = WebApplication1.Games.getQuery(query)

        Dim test = result.Tables(0).Rows.Count


        data.Columns.Add("Title", GetType(String))



        For i = 0 To result.Tables(0).Rows.Count - 1
            data.Rows.Add(result.Tables(0).Rows(i).ItemArray(1))
        Next

        grid.DataSource = data
        grid.DataBind()

    End Sub

    Protected Sub AddToCart(sender As Object, e As EventArgs)
        Dim query = Request("searchFor")
        result = WebApplication1.Games.getQuery(query)

        Dim names As New List(Of String)
        Dim i = 0
        Dim temp = ""
        For Each row As GridViewRow In grid.Rows
            Dim checkRow As CheckBox = row.Cells(0).FindControl("chkRow")

            If checkRow.Checked Then
                names.Add(result.Tables(0).Rows(i).ItemArray(0))
            End If


            i += 1
        Next


        Dim name = Request("Name")

        Dim CID = WebApplication1.Customers.getCID(name)

        For Each s As String In names
            WebApplication1.Carts.insert(s, CID)
        Next

        Response.Redirect("Cart.aspx?Name=" & name & "")
    End Sub

    Protected Sub Name_Click(sender As Object, e As EventArgs)
        Dim btn As LinkButton = DirectCast(sender, LinkButton)
        Dim test = btn.CommandArgument

        Dim mss As DataRow = WebApplication1.Games.getGameDetails(test)

        Dim str = "GID: " & mss.ItemArray(0).ToString() & vbNewLine & "Title: " & mss.ItemArray(1).ToString() & vbNewLine & "Price: " & mss.ItemArray(2).ToString() & ""

        MsgBox(str, 0)

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
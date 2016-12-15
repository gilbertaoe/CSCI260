Public Class Cart
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            Return
        End If
        Dim name = Request("Name")

        Dim CID = WebApplication1.Customers.getCID(name)

        Dim GID As DataSet = WebApplication1.Carts.getCustomersCart(CID)
        Dim i = 0

        Dim args(GID.Tables(0).Rows.Count) As String
        For Each row As DataRow In GID.Tables(0).Rows
            args(i) = row.ItemArray(1)
            i += 1
        Next

        Dim result = WebApplication1.Games.getGames(args)

        Dim total = 0
        If result Is Nothing Then
            For Each row As DataRow In result.Tables(0).Rows
                total += row.ItemArray(2)
            Next

            tot.Text = "The total for your cart:" & total

            grid.DataSource = result
            grid.DataBind()
        Else
            tot.Text = "There is nothing in your cart!"
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

    Protected Sub CustomerHub()
        Dim name = Request("Name")
        Response.Redirect("CustomerHub.aspx?Name=" + name + "")
    End Sub

    Protected Sub deleteFromCart(sender As Object, e As EventArgs)
        Dim name = Request("Name")

        Dim CID = WebApplication1.Customers.getCID(name)

        Dim GID As DataSet = WebApplication1.Carts.getCustomersCart(CID)
        Dim i = 0

        Dim args(GID.Tables(0).Rows.Count) As String
        For Each row As DataRow In GID.Tables(0).Rows
            args(i) = row.ItemArray(1)
            i += 1
        Next

        Dim result = WebApplication1.Games.getGames(args)

        Dim names As New List(Of String)
        i = 0
        Dim temp = ""
        For Each row As GridViewRow In grid.Rows
            Dim checkRow As RadioButton = row.Cells(0).FindControl("RowSelector")

            If checkRow.Checked Then
                names.Add(result.Tables(0).Rows(i).ItemArray(0))
            End If


            i += 1
        Next


        name = Request("Name")

        CID = WebApplication1.Customers.getCID(name)

        For Each s As String In names
            WebApplication1.Carts.deleteFromCart(s, CID)
        Next

        Response.Redirect("Cart.aspx?Name=" & name & "")
    End Sub

    Protected Sub purchaseGame(sender As Object, e As EventArgs)
        Dim name = Request("Name")

        Dim CID = WebApplication1.Customers.getCID(name)

        Dim GID As DataSet = WebApplication1.Carts.getCustomersCart(CID)
        Dim i = 0

        Dim args(GID.Tables(0).Rows.Count) As String
        For Each row As DataRow In GID.Tables(0).Rows
            args(i) = row.ItemArray(1)
            i += 1
        Next

        Dim result = WebApplication1.Games.getGames(args)

        Dim names As New List(Of String)
        i = 0
        For Each row As GridViewRow In grid.Rows
            names.Add(result.Tables(0).Rows(i).ItemArray(0))
            i += 1
        Next


        name = Request("Name")

        CID = WebApplication1.Customers.getCID(name)

        For Each s As String In names
            Dim mss = WebApplication1.Bought_By.insert(s, CID)
            If mss.Equals("Already Purchased") Then
                MsgBox("Game with GID of" & s & " is already purchased, please delete before trying to purchse again", 0)
                Return
            End If
            WebApplication1.Carts.deleteFromCart(s, CID)

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
End Class
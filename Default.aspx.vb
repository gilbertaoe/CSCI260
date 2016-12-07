Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        WebApplication1.developers.update()
        Dim devs = WebApplication1.developers.getView()
        Developers.DataSource = devs
        Developers.DataBind()
        Dim feats = WebApplication1.features.getView()
        Features.DataSource = feats
        Features.DataBind()
        Dim g = WebApplication1.games.getView()
        Games.DataSource = g
        Games.DataBind()
    End Sub
    Protected Sub MoveInsertD_Click(sender As Object, e As EventArgs)
        Response.Redirect("InsertDeveloper.aspx")
    End Sub
    Protected Sub MoveDeleteD_Click(sender As Object, e As EventArgs)
        Response.Redirect("DeleteDevelopers.aspx")
    End Sub
    Protected Sub MoveModifyD_Click(sender As Object, e As EventArgs)
        Response.Redirect("ModifyDeveloper.aspx")
    End Sub
    Protected Sub MoveInsertF_Click(sender As Object, e As EventArgs)
        Response.Redirect("InsertFeature.aspx")
    End Sub
    Protected Sub MoveDeleteF_Click(sender As Object, e As EventArgs)
        Response.Redirect("DeleteFeatures.aspx")
    End Sub
    Protected Sub MoveModifyF_Click(sender As Object, e As EventArgs)
        Response.Redirect("ModifyFeature.aspx")
    End Sub
    Protected Sub MoveInsertG_Click(sender As Object, e As EventArgs)
        Dim feats = WebApplication1.features.getRows()
        Dim devs = WebApplication1.developers.getRows()
        If feats = 0 Or devs = 0 Then
            Dim res = MsgBox("There must be a data value in ", 0, "A Message")
        Else
            Response.Redirect("InsertGame.aspx")
        End If
    End Sub
    Protected Sub MoveDeleteG_Click(sender As Object, e As EventArgs)
        Response.Redirect("DeleteGame.aspx")
    End Sub
    Protected Sub MoveModifyG_Click(sender As Object, e As EventArgs)
        Response.Redirect("ModifyGame.aspx")
    End Sub
    Protected Sub MoveWipe_Click(sender As Object, e As EventArgs)
        Dim res = MsgBox("Are you sure you want to wipe the entire database", 4, "A Message")
        If res = 6 Then
            WebApplication1.games.wipe()
            WebApplication1.developers.wipe()
            WebApplication1.features.wipe()
            Response.Redirect("WipeTable.aspx")
        End If
    End Sub
End Class
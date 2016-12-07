Public Class InsertGame
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim feats() As String = WebApplication1.features.getData()
        Dim featList As String() = feats(1).Split("!")
        FeaturesDropdown.DataSource = featList
        FeaturesDropdown.SelectedValue = FeaturesDropdown.SelectedValue
        FeaturesDropdown.DataBind()

        Dim devs() As String = WebApplication1.developers.getData()
        Dim list As String() = devs(1).Split("!")
        DevolpersDropdown.DataSource = list
        DevolpersDropdown.SelectedValue = DevolpersDropdown.SelectedValue
        DevolpersDropdown.DataBind()
    End Sub

    Protected Sub Insert_Click()
        Dim name = Request.Form("gameName")
        Dim GID As String = FeaturesDropdown.SelectedValue
        Dim DID As String = DevolpersDropdown.SelectedValue
        If GID IsNot "" Or DID IsNot "" Then
            WebApplication1.games.insert(name, GID, DID)
            Response.Redirect("InsertConfirm.aspx")
        End If
    End Sub

End Class
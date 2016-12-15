Public Class EnterGame
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Insert_Click()
        Dim gameTitle As String = Request.Form("gameTitle")
        Dim gameAmount As String = Request.Form("gameAmount")
        Dim result As Integer

        Dim data As Int32() = WebApplication1.Games.getGIDs()


        Dim GID As String

        If data IsNot Nothing Then
            Dim temp = data(0)

            GID = Convert.ToInt32(temp) + 1
        Else
            GID = "97805960"
        End If

        If Integer.TryParse(gameAmount, result) Then
            WebApplication1.Games.insert(GID, gameTitle, gameAmount)
        Else
            MsgBox("Game Amount Must Be A Number!!", 0)
        End If

    End Sub

End Class
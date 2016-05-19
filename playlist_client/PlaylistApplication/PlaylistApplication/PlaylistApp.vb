Imports AxShockwaveFlashObjects
' Module: Web Services
' Arthur: Freddy Lam
' Description: Playlist application allow user login and retrieve saved playlist
' from the server and play the track over the media player
Public Class PlaylistApp
    Public Property AxShockwaveFlash1 As Object
    ' Hide the PlaylistApp form and open the SearchUser form
    Private Sub btnSearchUsername_Click(sender As Object, e As EventArgs) Handles btnSearchUsername.Click
        SearchUser.Show()
        Me.Hide()
    End Sub
    ' Hide the PlaylistApp form and open the SearchPlaylist form
    Private Sub btnSearchPlaylist_Click(sender As Object, e As EventArgs) Handles btnSearchPlaylist.Click
        SearchPlaylist.Show()
        Me.Hide()
    End Sub
    ' Hide the PlaylistApp form and open the AddPlaylist form
    Private Sub btnAddPlaylist_Click(sender As Object, e As EventArgs) Handles btnAddPlaylist.Click
        AddPlaylist.Show()
        Me.Hide()
    End Sub
    ' Hide the PlaylistApp form and open the EditPlaylist form
    Private Sub btnEditPlaylist_Click(sender As Object, e As EventArgs) Handles btnEditPlaylist.Click
        EditPlaylist.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    ' Hide the PlaylistApp form and open the Rate form
    Private Sub btnRank_Click(sender As Object, e As EventArgs) Handles btnRank.Click
        Rate.Show()
        Me.Hide()
    End Sub

    Private Sub PlaylistApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    ' Hide the PlaylistApp form and open the Remove form
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Remove.Show()
        Me.Hide()
    End Sub
    ' Log out the playlist application, hide tge PlaylistApp and go back to the login form
    Private Sub txtLogout_Click(sender As Object, e As EventArgs) Handles txtLogout.Click
        ' Create service object and call log out function from the server
        Dim service As PlaylistService.ServiceSoapClient = New PlaylistService.ServiceSoapClient()
        service.logout()
        Me.Hide()
        frmLogin.Show()

    End Sub
End Class
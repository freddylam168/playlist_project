' Module: Web Services
' Arthur: Freddy Lam
' Description: Playlist application allow user login and retrieve saved playlist
' from the server and play the track over the media player
Public Class AddPlaylist
    ' Add new username, playlist, track title, track location and track duration.
    Private Sub btnAddNewPlaylist_Click(sender As Object, e As EventArgs) Handles btnAddNewPlaylist.Click
        ' Create service object and call the create new client, create new playlist 
        ' and create new track functions from the server
        Dim service As PlaylistService.ServiceSoapClient = New PlaylistService.ServiceSoapClient()
        ' If username exist the new playlist and new track information will add to the existing user,
        ' otherwise it will create a new username and save the new playlist and track information under it.
        service.createNewClient(txtAddUsername.Text)
        service.createNewPlayList(txtAddUsername.Text, txtAddPlaylist.Text)
        service.createNewTrack(txtAddPlaylist.Text, txtAddTitle.Text, txtAddLocation.Text, txtAddDuration.Text)
        txtAddUsername.Clear()
        txtAddPlaylist.Clear()
        txtAddTitle.Clear()
        txtAddLocation.Clear()
        txtAddDuration.Clear()
        MessageBox.Show("New playlist has been created!")
    End Sub
    ' Hide the current window form and open the playlistApp
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        PlaylistApp.Show()
    End Sub
End Class
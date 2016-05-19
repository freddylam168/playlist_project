' Module: Web Services
' Arthur: Freddy Lam
' Description: Playlist application allow user login and retrieve saved playlist
' from the server and play the track over the media player
Public Class EditPlaylist
    ' Hide the current window form and open the playlistApp
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        PlaylistApp.Show()
    End Sub

    Private Sub btnUpdateTrack_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Create service object and call the update client name, update playlist name
        '  and update track functions from the server.
        Dim service As PlaylistService.ServiceSoapClient = New PlaylistService.ServiceSoapClient()
        ' Check if the current username exist then update the username
        ' Check if the current playlist name exist then update the playlist name,
        ' track title, track location and track duration,
        ' otherwise will display error message.
        If (service.updateClientName(txtCurrUsername.Text, txtNewUsername.Text) +
            service.updatePlaylistName(txtNewUsername.Text, txtCurrPlaylist.Text, txtNewPlaylist.Text) +
            service.updateTrack(txtCurrPlaylist.Text, txtNewID.Text, txtNewTitle.Text, txtNewUrl.Text, txtNewDuration.Text)) Then
            MessageBox.Show("Playlist updated")
            txtCurrUsername.Clear()
            txtNewUsername.Clear()
            txtCurrPlaylist.Clear()
            txtNewPlaylist.Clear()
            txtNewID.Clear()
            txtNewTitle.Clear()
            txtNewUrl.Clear()
            txtNewDuration.Clear()
        Else
            MessageBox.Show("Please check input data and re-submit!")
            txtCurrUsername.Clear()
            txtNewUsername.Clear()
            txtCurrPlaylist.Clear()
            txtNewPlaylist.Clear()
            txtNewID.Clear()
            txtNewTitle.Clear()
            txtNewUrl.Clear()
            txtNewDuration.Clear()
        End If
    End Sub
End Class
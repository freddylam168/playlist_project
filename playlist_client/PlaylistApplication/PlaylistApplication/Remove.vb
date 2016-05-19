' Module: Web Services
' Arthur: Freddy Lam
' Description: Playlist application allow user login and retrieve saved playlist
' from the server and play the track over the media player
Public Class Remove
    ' Remove the username and the playlist 
    Private Sub btnPlaylist_Click(sender As Object, e As EventArgs) Handles btnPlaylist.Click
        ' Create service object and call the remove functions from the server
        Dim service As PlaylistService.ServiceSoapClient = New PlaylistService.ServiceSoapClient()
        ' Check if the username and playlist exist then remove, otherwise return error message
        If (service.removeClient(txtUsername.Text) +
        service.removePlaylist(txtPlaylist.Text)) Then
            txtUsername.Clear()
            txtPlaylist.Clear()
            MessageBox.Show("Playlist has been removed")
        Else
            MessageBox.Show("Please check input data and re-submit!")
            txtUsername.Clear()
            txtPlaylist.Clear()
        End If
    End Sub

    ' Hide the current window form and open the playlistApp
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        PlaylistApp.Show()
    End Sub
End Class
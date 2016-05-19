' Module: Web Services
' Arthur: Freddy Lam
' Description: Playlist application allow user login and retrieve saved playlist
' from the server and play the track over the media player
Public Class Rate
    ' Rate the selected playlist according to the playlist
    Private Sub btnRate_Click(sender As Object, e As EventArgs) Handles btnRate.Click
        ' Create service object and call the rate playlist function from the server
        Dim service As PlaylistService.ServiceSoapClient = New PlaylistService.ServiceSoapClient()
        ' Check if the playlist exist then rate the playlist
        If (service.voteOnPlaylist(txtPlaylist.Text, txtRate.Text)) Then
            txtPlaylist.Clear()
            txtRate.Clear()
            MessageBox.Show("Vote has been saved")
        Else
            MessageBox.Show("Playlist not exist!")
            txtPlaylist.Clear()
            txtRate.Clear()
        End If
    End Sub

    ' Hide the current window form and open the playlistApp
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        PlaylistApp.Show()
    End Sub
End Class
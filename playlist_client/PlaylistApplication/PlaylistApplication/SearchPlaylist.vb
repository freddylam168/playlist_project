' Module: Web Services
' Arthur: Freddy Lam
' Description: Playlist application allow user login and retrieve saved playlist
' from the server and play the track over the media player
Public Class SearchPlaylist
    ' Search for the playlist item according to the username and playlist name
    Private Sub btnPlaylist_Click(sender As Object, e As EventArgs) Handles btnPlaylist.Click
        ' Create service object and call the search playlist functions from the server
        Dim service As PlaylistService.ServiceSoapClient = New PlaylistService.ServiceSoapClient
        Dim serviceReturn As String
        Try
            serviceReturn = service.getPlaylist(txtUsername.Text, txtPlaylist.Text)
            Dim xmlPlaylists As New Xml.XmlDocument
            xmlPlaylists.LoadXml(serviceReturn)
            Dim xmlPlaylist As Xml.XmlNode
            lstPlaylistlst.Items.Clear()
            ' Loop through the xml document and display the specific element on the playlist listbox
            For Each xmlPlaylist In xmlPlaylists.DocumentElement.SelectNodes("//playlist")
                lstPlaylistlst.Items.Add(xmlPlaylist.Attributes("playname").Value)
            Next
        Catch ex As Exception
            MessageBox.Show("Playlist Not exist!")
        End Try
    End Sub

    ' Hide the current window form and open the playlistApp
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        PlaylistApp.Show()
    End Sub
End Class
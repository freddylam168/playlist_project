' Module: Web Services
' Arthur: Freddy Lam
' Description: Playlist application allow user login and retrieve saved playlist
' from the server and play the track over the media player
Public Class SearchUser
    ' Call the service for the playlist items and will load the playlist items on the playlist listbox,
    ' and when the user select the playlist item and the track information will display on the track listbox
    Private Sub btnUsername_Click(sender As Object, e As EventArgs) Handles btnUsername.Click
        ' Create service object and call the search user playlist collection function from the server
        Dim service As PlaylistService.ServiceSoapClient = New PlaylistService.ServiceSoapClient
        Dim serviceReturn As String
        ' Retrieve playlist xml document and select the specific element display on the playlist
        ' listbox
        Try
            serviceReturn = service.getClientPlaylistCollection(txtUsername.Text)
            Dim xmlPlaylists As New Xml.XmlDocument
            xmlPlaylists.LoadXml(serviceReturn)
            Dim xmlPlaylist As Xml.XmlNode
            lstPlaylist.Items.Clear()
            ' Loop through the playlist XML document and select the specific element
            For Each xmlPlaylist In xmlPlaylists.DocumentElement.SelectNodes("//playlist")
                ' Display the selected element attribute on the playlist listbox
                lstPlaylist.Items.Add(xmlPlaylist.Attributes("playname").Value)
            Next
        Catch ex As Exception
            MessageBox.Show("Username Not exist!")
        End Try
    End Sub
    Private Sub SearchUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    ' Select the playlist name and the tracks will display on the track listbox
    Private Sub lstPlaylistlst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPlaylist.SelectedIndexChanged

        ' Select playlist listbox playlist and display the track information on the track listbox
        Dim xmlPlaylists As New Xml.XmlDocument
        Dim serviceReturn As String
        Try
            serviceReturn = getPlaylistService((lstPlaylist.SelectedItem).ToString(), txtUsername.Text)

            xmlPlaylists.LoadXml(serviceReturn)
            Dim xmlPlaylist As Xml.XmlNode
            lstTrack.Items.Clear()
            ' Loop thought the playlist XML document and select the specific element
            For Each xmlPlaylist In xmlPlaylists.DocumentElement.SelectNodes("//title")
                Dim playlist As String = xmlPlaylist.FirstChild.InnerText
                '  Display the selected element data on the track listbox
                lstTrack.Items.Add(playlist)
            Next
        Catch ex As Exception

        End Try
    End Sub

    ' Hide the current window form and open the playlistApp
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        PlaylistApp.Show()
    End Sub

    ' Select the track on the track listbox and display the track information on the
    ' text box and play the selected track on the player
    Private Sub lstTrack_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTrack.SelectedIndexChanged

        Dim xmlPlaylists As New Xml.XmlDocument
        Dim serviceReturn As String
        Try
            serviceReturn = getPlaylistService((lstTrack.SelectedItem).ToString(), txtUsername.Text)

            'Dim xmlPlaylists As New Xml.XmlDocument
            xmlPlaylists.LoadXml(serviceReturn)

            ' Display the track title, location and duration on the textbox
            txtTrack.Text = xmlPlaylists.SelectSingleNode("//title").InnerText
            txtUrl.Text = xmlPlaylists.SelectSingleNode("//location").InnerText
            txtDuration.Text = xmlPlaylists.SelectSingleNode("//duration").InnerText
            ' Play the select track over the player
            AxShockwaveFlash1.Movie = txtUrl.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Function getPlaylistService(v As String, playlist As String) As String
        Dim service As PlaylistService.ServiceSoapClient = New PlaylistService.ServiceSoapClient()
        Return service.getClientPlaylistCollection(playlist)
    End Function
End Class
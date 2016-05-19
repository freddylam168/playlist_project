' Module: Web Services
' Arthur: Freddy Lam
' Description: Playlist application allow user login and retrieve saved playlist
' from the server and play the track over the media player
Public Class frmLogin
    ' Login To the playlist application
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Create service object and call the login function from the server
        Dim service As PlaylistService.ServiceSoapClient = New PlaylistService.ServiceSoapClient()
        ' Check if the username and password match from the server then login to the application, 
        ' otherwise will display error message
        If (service.login(txtUsername.Text, txtPassword.Text)) Then
            PlaylistApp.Show()
            txtUsername.Clear()
            txtPassword.Clear()
            Me.Hide()

        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub
End Class

Public Class more

    Public Sub getMore(ByVal client, ByVal api, ByVal id)

        Dim webClient As New System.Net.WebClient
        Dim requ As String = "https://api.digitalocean.com/droplets/" + id + "?client_id=" + client + "&api_key=" + api
        Dim droplet As String = webClient.DownloadString(requ)

        processServers(droplet)


    End Sub

    Private Sub processServers(ByVal server As String)
        Dim parts() As String = Split(server, ",")

        Dim status2() = Split(parts(0), Chr(34))
        If status2(3) = "OK" Then
            Status2leabel.Text = status2(3)

            Dim name() = Split(parts(2), Chr(34))
            nameInfoLabel.Text = name(3)

            Dim status() = Split(parts(7), Chr(34))
            statusInfoLabel.Text = status(3)

            Dim imageID() As String = Split(parts(3), Chr(34))
            imageIDInfoLabel.Text = Replace(imageID(2), ":", "")

            Dim backup() As String = Split(parts(6), Chr(34))
            backupInfoLabel.Text = Replace(backup(2), ":", "")

            Dim region() As String = Split(parts(5), Chr(34))
            regionInfoLabel.Text = Replace(region(2), ":", "")

            Dim size() As String = Split(parts(4), Chr(34))
            sizeInfoLabel.Text = Replace(size(2), ":", "")
        Else
            Status2leabel.Text = "ERROR"
        End If
    End Sub

    Private Sub more_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

    End Sub
End Class
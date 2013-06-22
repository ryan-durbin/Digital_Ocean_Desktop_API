Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub



    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        clearAll()
    End Sub

    Private Sub clearAll()
        apiTextBox.Clear()
        clientIdTextBox.Clear()
        ListBox1.Items.Clear()
        statusLabel.Text = ""
    End Sub

    Private Sub retrieveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles retrieveButton.Click
        If retrieveButton.Text = "Start" Then
            update()
            Timer1.Start()
            retrieveButton.Text = "Pause"
        Else
            Timer1.Stop()
            retrieveButton.Text = "Start"
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        update()
    End Sub


    Private Sub update()
        updateLabelDate.Text = Date.Now
        statusLabel.Text = ""
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        'sets client id and api
        Dim client As String = clientIdTextBox.Text
        Dim api As String = apiTextBox.Text

        'get initial status of services
        Dim webClient As New System.Net.WebClient
        Dim requ As String = "https://api.digitalocean.com/droplets/?client_id=" + client + "&api_key=" + api
        Dim droplets As String = webClient.DownloadString(requ)

        'split return and such
        ListBox1.Items.Add("Host" & Chr(9) & Chr(9) & "Status" & Chr(9) & "IP" & Chr(9) & Chr(9) & "Size ID")
        ListBox2.Items.Add("ID")
        splitReturn(droplets)

        'debug write to listbox
    End Sub

    Private Sub splitReturn(ByVal droplets As String)
        Dim DropArray() As String = Split(droplets, "[")
        Dim DropStatus() As String = Split(DropArray(0), Chr(34))
        status(DropStatus(3))
        Dim DropDroplets() As String = Split(DropArray(1), "]")
        Dim DropServers() As String = Split(DropDroplets(0), "{")
        'RichTextBox1.AppendText(DropServers(1))
        Dim Servers As Integer = DropServers.Length - 1
        Dim i As Integer = 0
        While i < Servers
            i = i + 1
            processServers(DropServers(i))
        End While


    End Sub

    Private Sub servers()

    End Sub


    Private Sub status(ByVal status As String)

        If status = "OK" Then
            statusLabel.Text = "Online"
            statusLabel.ForeColor = Color.Green
        Else
            statusLabel.Text = "Down"
            statusLabel.ForeColor = Color.Red
        End If

    End Sub

    Private Sub processServers(ByVal server As String)
        Dim parts() As String = Split(server, ",")
        Dim name() As String = Split(parts(1), Chr(34))
        Dim insert As String
        If name(3).Length < 9 Then
            insert = Chr(9)
        End If
        Dim status() As String = Split(parts(7), Chr(34))
        Dim ip() As String = Split(parts(6), Chr(34))
        Dim size() As String = Split(parts(3), Chr(34))
        ListBox1.Items.Add(name(3) & insert & Chr(9) & status(3) & Chr(9) & ip(3) & Chr(9) & size(2))
        Dim DropletID() As String = Split(parts(0), Chr(34))
        Dim id As String = Replace(DropletID(2), ":", "")
        ListBox2.Items.Add(id)



    End Sub


    Private Sub fasterCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fasterCheckBox.CheckedChanged
        If fasterCheckBox.Checked = True Then
            Timer1.Interval = 2000
        Else
            Timer1.Interval = 10000
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.SelectedIndex = ListBox1.SelectedIndex
        If ListBox1.SelectedIndex > 0 Then
            moreButton.Enabled = True
        Else
            moreButton.Enabled = False
        End If
    End Sub

    Public Sub moreButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles moreButton.Click
        Timer1.Stop()
        retrieveButton.Text = "Start"

        Dim client As String = clientIdTextBox.Text
        Dim api As String = apiTextBox.Text
        Dim id As String = ListBox2.SelectedItem
        more.Show()
        more.getMore(client, api, id)
        more.Focus()
    End Sub
End Class
Public Class Form1
    Dim RandomNum As Random
    Dim FixedNum As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShiftEngine.CheckSave("Main Menu")
        DoTips()
        marqueetimer.Start()
    End Sub

    Private Sub marqueetimer_Tick(sender As Object, e As EventArgs) Handles marqueetimer.Tick
        If Label2.Location.X <= 0 - Label2.Width Then
            DoTips()
        Else
            Label2.Location = New Point(Label2.Location.X - 3, Label2.Location.Y)
        End If
    End Sub

    Private Sub DoTips()
        Label2.Location = New Point(640, Label2.Location.Y)
        Label2.Text = Nothing
        Dim RandomNum As New Random
        FixedNum = RandomNum.Next(1, 4)
        Select Case FixedNum
            Case 1
                Label2.Text = "Shiftorium brings you lots of upgrades and enhancement for your ShiftOS."
            Case 2
                Label2.Text = "05tray doesn't work in this version due to rewrite in Visual Basic from scratch"
            Case 3
                Label2.Text = "Appscape gets new application as of right now"
        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub CampaignButton_Click(sender As Object, e As EventArgs) Handles CampaignButton.Click
        CampaignPanel.Location = New Point((Width - CampaignPanel.Width) / 2, (Height - CampaignPanel.Height) / 2)
        CampaignPanel.Visible = True
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        CampaignPanel.Visible = False
        CampaignPanel.Location = New Point(12, 207)
    End Sub
End Class

Public Class billing

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        Dim product As Integer
        
        product = RegistrationFeeTB.Text * NoOfParticipantsTB.Text
        AmountDueTB.Text = product + +TrainingFeeTB.Text
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim textbox1 As New TextBox
        textbox1.Name = "Textbox1"
        textbox1.Size = New Size(170, 20)
        textbox1.Location = New Point(81, 152)
        Me.Controls.Add(textbox1)
    End Sub
End Class

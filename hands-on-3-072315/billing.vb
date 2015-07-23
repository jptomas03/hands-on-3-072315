Public Class billing

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim product As Integer
        product = RegistrationFeeTB.Text * NoOfParticipantsTB.Text
        AmountDueTB.Text = product + +TrainingFeeTB.Text
    End Sub
End Class

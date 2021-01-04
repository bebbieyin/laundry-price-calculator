Public Class validationForm



    Private Sub passListBox_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub yesButton_Click(sender As Object, e As EventArgs) Handles yesButton.Click
        SuccessForm.Show()
    End Sub

    Private Sub noButton_Click(sender As Object, e As EventArgs) Handles noButton.Click
        Me.Hide()
        CalculateForm.Show()
        CalculateForm.OutputListBox.Items.Clear()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
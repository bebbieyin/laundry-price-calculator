Public Class SuccessForm
    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        Me.Hide()
        validationForm.Hide()
        CalculateForm.OutputListBox.Items.Clear()
        CalculateForm.ResetButton.PerformClick()

    End Sub
End Class
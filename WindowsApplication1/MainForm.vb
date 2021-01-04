Public Class MainForm

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles StartButton.Click
        CalculateForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub


End Class
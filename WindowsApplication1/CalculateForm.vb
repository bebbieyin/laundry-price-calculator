Public Class CalculateForm
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click

        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub weight2_CheckedChanged(sender As Object, e As EventArgs) Handles mediumWeightRadio.CheckedChanged

    End Sub

    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

        Dim price As Double
        Dim washing, weight, temp, textile, foldserv, ironserv As Double

        Const mainWash As Double = 1
        Const rinseWash As Double = 2
        Const dryingWash As Double = 3

        Const lowTemp As Double = 1
        Const mediumTemp As Double = 2
        Const highTemp As Double = 3

        Const lightWeight As Double = 3
        Const mediumWeight As Double = 4
        Const heavyWeight As Double = 5

        Const plainFibres As Double = 1
        Const animalFibres As Double = 2
        Const syntheticFibres As Double = 2
        Const celluloseFibres As Double = 3

        Const folding As Double = 0.6
        Const nofold As Double = 0

        Const ironing As Double = 1
        Const noiron As Double = 0

        If mainWashRadio.Checked Then
            washing = 3
        ElseIf rinseRadio.Checked Then
            washing = rinseWash
        ElseIf dryingradio.checked Then
            washing = dryingWash

        End If

        If lowTempRadio.Checked Then
            temp = lowTemp
        ElseIf mediumTempRadio.Checked Then
            temp = mediumTemp
        ElseIf highTempRadio.Checked Then
            temp = highTemp

        End If

        If LightWeightRadio.Checked Then
            weight = lightWeight
        ElseIf mediumWeightRadio.Checked Then
            weight = mediumWeight
        ElseIf heavyWeightRadio.Checked Then
            weight = heavyWeight

        End If

        If plainFibresRadio.Checked Then
            textile = plainFibres
        ElseIf animalFibresRadio.Checked Then
            textile = animalFibres
        ElseIf celluloseFibresRadio.Checked Then
            textile = celluloseFibres
        ElseIf syntheticFibresRadio.Checked Then
            textile = syntheticFibres

        End If

        If YesFoldRadio.Checked Then
            foldserv = folding
        ElseIf NoFoldRadio.Checked Then
            foldserv = nofold

        End If

        If yesIronRadio.Checked Then
            ironserv = ironing
        ElseIf noIronRadio.checked Then
            ironserv = noiron
        End If


        price = washing + temp + weight + textile + foldserv + ironserv

        If (mainWashRadio.Checked Or rinseRadio.Checked Or DryingRadio.Checked) And (highTempRadio.Checked Or mediumTempRadio.Checked Or lowTempRadio.Checked) And (LightWeightRadio.Checked Or mediumWeightRadio.Checked Or heavyWeightRadio.Checked) And (plainFibresRadio.Checked Or animalFibresRadio.Checked Or celluloseFibresRadio.Checked Or syntheticFibresRadio.Checked) And (YesFoldRadio.Checked Or NoFoldRadio.Checked) And (yesIronRadio.Checked Or noIronRadio.Checked) Then
            OutputListBox.Items.Add("Washing price is RM " & washing)
            OutputListBox.Items.Add("Textile Fibres price is RM " & textile)
            OutputListBox.Items.Add("Weight price is RM " & weight)
            OutputListBox.Items.Add("Temperature price is RM " & temp)
            OutputListBox.Items.Add("Folding service price is RM " & foldserv)
            OutputListBox.Items.Add("Ironing service price is RM " & ironserv)
            OutputListBox.Items.Add("Total Price is RM " & price)

            validationForm.Show()

        Else
            reset()
            MsgBox("Select all")

        End If

    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        reset()
    End Sub
    Sub reset()
        OutputListBox.Items.Clear()
        mainWashRadio.Checked = False
        rinseRadio.Checked = False
        DryingRadio.Checked = False
        lowTempRadio.Checked = False
        mediumTempRadio.Checked = False
        highTempRadio.Checked = False
        LightWeightRadio.Checked = False
        mediumWeightRadio.Checked = False
        heavyWeightRadio.Checked = False
        plainFibresRadio.Checked = False
        animalFibresRadio.Checked = False
        celluloseFibresRadio.Checked = False
        syntheticFibresRadio.Checked = False
        YesFoldRadio.Checked = False
        NoFoldRadio.Checked = False
        yesIronRadio.Checked = False
        noIronRadio.Checked = False
    End Sub


    Private Sub NoFoldRadio_CheckedChanged(sender As Object, e As EventArgs) Handles NoFoldRadio.CheckedChanged

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateTimeLabel.Text = Date.Now.ToString("dd MMM yyyy hh:mm:ss")
    End Sub

    Private Sub OutputListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OutputListBox.SelectedIndexChanged

    End Sub
End Class

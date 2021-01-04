<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalculateForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.foldServices = New System.Windows.Forms.GroupBox()
        Me.NoFoldRadio = New System.Windows.Forms.RadioButton()
        Me.YesFoldRadio = New System.Windows.Forms.RadioButton()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.washingProcess = New System.Windows.Forms.GroupBox()
        Me.DryingRadio = New System.Windows.Forms.RadioButton()
        Me.rinseRadio = New System.Windows.Forms.RadioButton()
        Me.mainWashRadio = New System.Windows.Forms.RadioButton()
        Me.temperature = New System.Windows.Forms.GroupBox()
        Me.lowTempRadio = New System.Windows.Forms.RadioButton()
        Me.mediumTempRadio = New System.Windows.Forms.RadioButton()
        Me.highTempRadio = New System.Windows.Forms.RadioButton()
        Me.weight = New System.Windows.Forms.GroupBox()
        Me.heavyWeightRadio = New System.Windows.Forms.RadioButton()
        Me.mediumWeightRadio = New System.Windows.Forms.RadioButton()
        Me.LightWeightRadio = New System.Windows.Forms.RadioButton()
        Me.back = New System.Windows.Forms.Button()
        Me.OutputListBox = New System.Windows.Forms.ListBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.textileFibre = New System.Windows.Forms.GroupBox()
        Me.syntheticFibresRadio = New System.Windows.Forms.RadioButton()
        Me.celluloseFibresRadio = New System.Windows.Forms.RadioButton()
        Me.animalFibresRadio = New System.Windows.Forms.RadioButton()
        Me.plainFibresRadio = New System.Windows.Forms.RadioButton()
        Me.ironingService = New System.Windows.Forms.GroupBox()
        Me.noIronRadio = New System.Windows.Forms.RadioButton()
        Me.yesIronRadio = New System.Windows.Forms.RadioButton()
        Me.DateTimeLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.foldServices.SuspendLayout()
        Me.washingProcess.SuspendLayout()
        Me.temperature.SuspendLayout()
        Me.weight.SuspendLayout()
        Me.textileFibre.SuspendLayout()
        Me.ironingService.SuspendLayout()
        Me.SuspendLayout()
        '
        'foldServices
        '
        Me.foldServices.Controls.Add(Me.NoFoldRadio)
        Me.foldServices.Controls.Add(Me.YesFoldRadio)
        Me.foldServices.Location = New System.Drawing.Point(258, 187)
        Me.foldServices.Name = "foldServices"
        Me.foldServices.Size = New System.Drawing.Size(200, 115)
        Me.foldServices.TabIndex = 16
        Me.foldServices.TabStop = False
        Me.foldServices.Text = "FOLDING SERVICES"
        '
        'NoFoldRadio
        '
        Me.NoFoldRadio.AutoSize = True
        Me.NoFoldRadio.Location = New System.Drawing.Point(15, 42)
        Me.NoFoldRadio.Name = "NoFoldRadio"
        Me.NoFoldRadio.Size = New System.Drawing.Size(39, 17)
        Me.NoFoldRadio.TabIndex = 1
        Me.NoFoldRadio.TabStop = True
        Me.NoFoldRadio.Text = "No"
        Me.NoFoldRadio.UseVisualStyleBackColor = True
        '
        'YesFoldRadio
        '
        Me.YesFoldRadio.AutoSize = True
        Me.YesFoldRadio.Location = New System.Drawing.Point(15, 19)
        Me.YesFoldRadio.Name = "YesFoldRadio"
        Me.YesFoldRadio.Size = New System.Drawing.Size(43, 17)
        Me.YesFoldRadio.TabIndex = 0
        Me.YesFoldRadio.TabStop = True
        Me.YesFoldRadio.Text = "Yes"
        Me.YesFoldRadio.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(494, 333)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 15
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'washingProcess
        '
        Me.washingProcess.Controls.Add(Me.DryingRadio)
        Me.washingProcess.Controls.Add(Me.rinseRadio)
        Me.washingProcess.Controls.Add(Me.mainWashRadio)
        Me.washingProcess.Location = New System.Drawing.Point(30, 55)
        Me.washingProcess.Name = "washingProcess"
        Me.washingProcess.Size = New System.Drawing.Size(200, 115)
        Me.washingProcess.TabIndex = 10
        Me.washingProcess.TabStop = False
        Me.washingProcess.Text = "WASHING PROCESS"
        '
        'DryingRadio
        '
        Me.DryingRadio.AutoSize = True
        Me.DryingRadio.Location = New System.Drawing.Point(15, 65)
        Me.DryingRadio.Name = "DryingRadio"
        Me.DryingRadio.Size = New System.Drawing.Size(55, 17)
        Me.DryingRadio.TabIndex = 3
        Me.DryingRadio.TabStop = True
        Me.DryingRadio.Text = "Drying"
        Me.DryingRadio.UseVisualStyleBackColor = True
        '
        'rinseRadio
        '
        Me.rinseRadio.AutoSize = True
        Me.rinseRadio.Location = New System.Drawing.Point(15, 42)
        Me.rinseRadio.Name = "rinseRadio"
        Me.rinseRadio.Size = New System.Drawing.Size(52, 17)
        Me.rinseRadio.TabIndex = 2
        Me.rinseRadio.TabStop = True
        Me.rinseRadio.Text = "Rinse"
        Me.rinseRadio.UseVisualStyleBackColor = True
        '
        'mainWashRadio
        '
        Me.mainWashRadio.AutoSize = True
        Me.mainWashRadio.Location = New System.Drawing.Point(15, 19)
        Me.mainWashRadio.Name = "mainWashRadio"
        Me.mainWashRadio.Size = New System.Drawing.Size(79, 17)
        Me.mainWashRadio.TabIndex = 0
        Me.mainWashRadio.TabStop = True
        Me.mainWashRadio.Text = "Main Wash"
        Me.mainWashRadio.UseVisualStyleBackColor = True
        '
        'temperature
        '
        Me.temperature.Controls.Add(Me.lowTempRadio)
        Me.temperature.Controls.Add(Me.mediumTempRadio)
        Me.temperature.Controls.Add(Me.highTempRadio)
        Me.temperature.Location = New System.Drawing.Point(258, 55)
        Me.temperature.Name = "temperature"
        Me.temperature.Size = New System.Drawing.Size(200, 115)
        Me.temperature.TabIndex = 11
        Me.temperature.TabStop = False
        Me.temperature.Text = "TEMPERATURE (°C)"
        '
        'lowTempRadio
        '
        Me.lowTempRadio.AutoSize = True
        Me.lowTempRadio.Location = New System.Drawing.Point(15, 19)
        Me.lowTempRadio.Name = "lowTempRadio"
        Me.lowTempRadio.Size = New System.Drawing.Size(108, 17)
        Me.lowTempRadio.TabIndex = 2
        Me.lowTempRadio.TabStop = True
        Me.lowTempRadio.Text = "Low Temperature"
        Me.lowTempRadio.UseVisualStyleBackColor = True
        '
        'mediumTempRadio
        '
        Me.mediumTempRadio.AutoSize = True
        Me.mediumTempRadio.Location = New System.Drawing.Point(16, 42)
        Me.mediumTempRadio.Name = "mediumTempRadio"
        Me.mediumTempRadio.Size = New System.Drawing.Size(125, 17)
        Me.mediumTempRadio.TabIndex = 1
        Me.mediumTempRadio.TabStop = True
        Me.mediumTempRadio.Text = "Medium Temperature"
        Me.mediumTempRadio.UseVisualStyleBackColor = True
        '
        'highTempRadio
        '
        Me.highTempRadio.AutoSize = True
        Me.highTempRadio.Location = New System.Drawing.Point(16, 65)
        Me.highTempRadio.Name = "highTempRadio"
        Me.highTempRadio.Size = New System.Drawing.Size(110, 17)
        Me.highTempRadio.TabIndex = 0
        Me.highTempRadio.TabStop = True
        Me.highTempRadio.Text = "High Temperature"
        Me.highTempRadio.UseVisualStyleBackColor = True
        '
        'weight
        '
        Me.weight.Controls.Add(Me.heavyWeightRadio)
        Me.weight.Controls.Add(Me.mediumWeightRadio)
        Me.weight.Controls.Add(Me.LightWeightRadio)
        Me.weight.Location = New System.Drawing.Point(30, 320)
        Me.weight.Name = "weight"
        Me.weight.Size = New System.Drawing.Size(200, 100)
        Me.weight.TabIndex = 13
        Me.weight.TabStop = False
        Me.weight.Text = "WEIGHT (KG)"
        '
        'heavyWeightRadio
        '
        Me.heavyWeightRadio.AutoSize = True
        Me.heavyWeightRadio.Location = New System.Drawing.Point(15, 65)
        Me.heavyWeightRadio.Name = "heavyWeightRadio"
        Me.heavyWeightRadio.Size = New System.Drawing.Size(58, 17)
        Me.heavyWeightRadio.TabIndex = 2
        Me.heavyWeightRadio.TabStop = True
        Me.heavyWeightRadio.Text = "10 - 14"
        Me.heavyWeightRadio.UseVisualStyleBackColor = True
        '
        'mediumWeightRadio
        '
        Me.mediumWeightRadio.AutoSize = True
        Me.mediumWeightRadio.Location = New System.Drawing.Point(15, 42)
        Me.mediumWeightRadio.Name = "mediumWeightRadio"
        Me.mediumWeightRadio.Size = New System.Drawing.Size(46, 17)
        Me.mediumWeightRadio.TabIndex = 1
        Me.mediumWeightRadio.TabStop = True
        Me.mediumWeightRadio.Text = "5 - 9"
        Me.mediumWeightRadio.UseVisualStyleBackColor = True
        '
        'LightWeightRadio
        '
        Me.LightWeightRadio.AutoSize = True
        Me.LightWeightRadio.Location = New System.Drawing.Point(15, 19)
        Me.LightWeightRadio.Name = "LightWeightRadio"
        Me.LightWeightRadio.Size = New System.Drawing.Size(46, 17)
        Me.LightWeightRadio.TabIndex = 0
        Me.LightWeightRadio.TabStop = True
        Me.LightWeightRadio.Text = "0 - 4"
        Me.LightWeightRadio.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(4, 12)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(75, 23)
        Me.back.TabIndex = 17
        Me.back.Text = "&Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'OutputListBox
        '
        Me.OutputListBox.FormattingEnabled = True
        Me.OutputListBox.Location = New System.Drawing.Point(494, 194)
        Me.OutputListBox.Name = "OutputListBox"
        Me.OutputListBox.Size = New System.Drawing.Size(172, 108)
        Me.OutputListBox.TabIndex = 18
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(591, 333)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 19
        Me.ResetButton.Text = "&Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'textileFibre
        '
        Me.textileFibre.Controls.Add(Me.syntheticFibresRadio)
        Me.textileFibre.Controls.Add(Me.celluloseFibresRadio)
        Me.textileFibre.Controls.Add(Me.animalFibresRadio)
        Me.textileFibre.Controls.Add(Me.plainFibresRadio)
        Me.textileFibre.Location = New System.Drawing.Point(30, 187)
        Me.textileFibre.Name = "textileFibre"
        Me.textileFibre.Size = New System.Drawing.Size(200, 115)
        Me.textileFibre.TabIndex = 20
        Me.textileFibre.TabStop = False
        Me.textileFibre.Text = "TEXTILE FIBRE"
        '
        'syntheticFibresRadio
        '
        Me.syntheticFibresRadio.AutoSize = True
        Me.syntheticFibresRadio.Location = New System.Drawing.Point(16, 88)
        Me.syntheticFibresRadio.Name = "syntheticFibresRadio"
        Me.syntheticFibresRadio.Size = New System.Drawing.Size(100, 17)
        Me.syntheticFibresRadio.TabIndex = 7
        Me.syntheticFibresRadio.TabStop = True
        Me.syntheticFibresRadio.Text = "Synthetic Fibres"
        Me.syntheticFibresRadio.UseVisualStyleBackColor = True
        '
        'celluloseFibresRadio
        '
        Me.celluloseFibresRadio.AutoSize = True
        Me.celluloseFibresRadio.Location = New System.Drawing.Point(16, 65)
        Me.celluloseFibresRadio.Name = "celluloseFibresRadio"
        Me.celluloseFibresRadio.Size = New System.Drawing.Size(98, 17)
        Me.celluloseFibresRadio.TabIndex = 2
        Me.celluloseFibresRadio.TabStop = True
        Me.celluloseFibresRadio.Text = "Cellulose Fibres"
        Me.celluloseFibresRadio.UseVisualStyleBackColor = True
        '
        'animalFibresRadio
        '
        Me.animalFibresRadio.AutoSize = True
        Me.animalFibresRadio.Location = New System.Drawing.Point(16, 42)
        Me.animalFibresRadio.Name = "animalFibresRadio"
        Me.animalFibresRadio.Size = New System.Drawing.Size(87, 17)
        Me.animalFibresRadio.TabIndex = 1
        Me.animalFibresRadio.TabStop = True
        Me.animalFibresRadio.Text = "Animal Fibres"
        Me.animalFibresRadio.UseVisualStyleBackColor = True
        '
        'plainFibresRadio
        '
        Me.plainFibresRadio.AutoSize = True
        Me.plainFibresRadio.Location = New System.Drawing.Point(16, 19)
        Me.plainFibresRadio.Name = "plainFibresRadio"
        Me.plainFibresRadio.Size = New System.Drawing.Size(79, 17)
        Me.plainFibresRadio.TabIndex = 0
        Me.plainFibresRadio.TabStop = True
        Me.plainFibresRadio.Text = "Plain Fibres"
        Me.plainFibresRadio.UseVisualStyleBackColor = True
        '
        'ironingService
        '
        Me.ironingService.Controls.Add(Me.noIronRadio)
        Me.ironingService.Controls.Add(Me.yesIronRadio)
        Me.ironingService.Location = New System.Drawing.Point(258, 320)
        Me.ironingService.Name = "ironingService"
        Me.ironingService.Size = New System.Drawing.Size(200, 100)
        Me.ironingService.TabIndex = 21
        Me.ironingService.TabStop = False
        Me.ironingService.Text = "IRONING SERVICES"
        '
        'noIronRadio
        '
        Me.noIronRadio.AutoSize = True
        Me.noIronRadio.Location = New System.Drawing.Point(15, 42)
        Me.noIronRadio.Name = "noIronRadio"
        Me.noIronRadio.Size = New System.Drawing.Size(39, 17)
        Me.noIronRadio.TabIndex = 1
        Me.noIronRadio.TabStop = True
        Me.noIronRadio.Text = "No"
        Me.noIronRadio.UseVisualStyleBackColor = True
        '
        'yesIronRadio
        '
        Me.yesIronRadio.AutoSize = True
        Me.yesIronRadio.Location = New System.Drawing.Point(15, 19)
        Me.yesIronRadio.Name = "yesIronRadio"
        Me.yesIronRadio.Size = New System.Drawing.Size(43, 17)
        Me.yesIronRadio.TabIndex = 0
        Me.yesIronRadio.TabStop = True
        Me.yesIronRadio.Text = "Yes"
        Me.yesIronRadio.UseVisualStyleBackColor = True
        '
        'DateTimeLabel
        '
        Me.DateTimeLabel.AutoSize = True
        Me.DateTimeLabel.Location = New System.Drawing.Point(491, 17)
        Me.DateTimeLabel.Name = "DateTimeLabel"
        Me.DateTimeLabel.Size = New System.Drawing.Size(59, 13)
        Me.DateTimeLabel.TabIndex = 22
        Me.DateTimeLabel.Text = "Date & Time"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'CalculateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(691, 436)
        Me.Controls.Add(Me.DateTimeLabel)
        Me.Controls.Add(Me.ironingService)
        Me.Controls.Add(Me.textileFibre)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.OutputListBox)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.foldServices)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.washingProcess)
        Me.Controls.Add(Me.temperature)
        Me.Controls.Add(Me.weight)
        Me.Name = "CalculateForm"
        Me.Text = "CalculateForm"
        Me.foldServices.ResumeLayout(False)
        Me.foldServices.PerformLayout()
        Me.washingProcess.ResumeLayout(False)
        Me.washingProcess.PerformLayout()
        Me.temperature.ResumeLayout(False)
        Me.temperature.PerformLayout()
        Me.weight.ResumeLayout(False)
        Me.weight.PerformLayout()
        Me.textileFibre.ResumeLayout(False)
        Me.textileFibre.PerformLayout()
        Me.ironingService.ResumeLayout(False)
        Me.ironingService.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents foldServices As GroupBox
    Friend WithEvents YesFoldRadio As RadioButton
    Friend WithEvents CalculateButton As Button
    Friend WithEvents washingProcess As GroupBox
    Friend WithEvents DryingRadio As RadioButton
    Friend WithEvents rinseRadio As RadioButton
    Friend WithEvents mainWashRadio As RadioButton
    Friend WithEvents temperature As GroupBox
    Friend WithEvents lowTempRadio As RadioButton
    Friend WithEvents mediumTempRadio As RadioButton
    Friend WithEvents highTempRadio As RadioButton
    Friend WithEvents weight As GroupBox
    Friend WithEvents heavyWeightRadio As RadioButton
    Friend WithEvents mediumWeightRadio As RadioButton
    Friend WithEvents LightWeightRadio As RadioButton
    Friend WithEvents back As Button
    Friend WithEvents NoFoldRadio As RadioButton
    Friend WithEvents OutputListBox As ListBox
    Friend WithEvents ResetButton As Button
    Friend WithEvents textileFibre As GroupBox
    Friend WithEvents syntheticFibresRadio As RadioButton
    Friend WithEvents celluloseFibresRadio As RadioButton
    Friend WithEvents animalFibresRadio As RadioButton
    Friend WithEvents plainFibresRadio As RadioButton
    Friend WithEvents ironingService As GroupBox
    Friend WithEvents noIronRadio As RadioButton
    Friend WithEvents yesIronRadio As RadioButton
    Friend WithEvents DateTimeLabel As Label
    Friend WithEvents Timer1 As Timer
End Class

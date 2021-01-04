<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class validationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(validationForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.yesButton = New System.Windows.Forms.Button()
        Me.noButton = New System.Windows.Forms.Button()
        Me.askLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'yesButton
        '
        Me.yesButton.Location = New System.Drawing.Point(98, 109)
        Me.yesButton.Name = "yesButton"
        Me.yesButton.Size = New System.Drawing.Size(75, 23)
        Me.yesButton.TabIndex = 2
        Me.yesButton.Text = "&Yes"
        Me.yesButton.UseVisualStyleBackColor = True
        '
        'noButton
        '
        Me.noButton.Location = New System.Drawing.Point(193, 109)
        Me.noButton.Name = "noButton"
        Me.noButton.Size = New System.Drawing.Size(75, 23)
        Me.noButton.TabIndex = 3
        Me.noButton.Text = "&No"
        Me.noButton.UseVisualStyleBackColor = True
        '
        'askLabel
        '
        Me.askLabel.AutoSize = True
        Me.askLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.askLabel.Location = New System.Drawing.Point(125, 41)
        Me.askLabel.Name = "askLabel"
        Me.askLabel.Size = New System.Drawing.Size(203, 25)
        Me.askLabel.TabIndex = 4
        Me.askLabel.Text = "ARE YOU SURE ?"
        '
        'validationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 191)
        Me.Controls.Add(Me.askLabel)
        Me.Controls.Add(Me.noButton)
        Me.Controls.Add(Me.yesButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "validationForm"
        Me.Text = "validationForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents yesButton As Button
    Friend WithEvents noButton As Button
    Friend WithEvents askLabel As Label
End Class

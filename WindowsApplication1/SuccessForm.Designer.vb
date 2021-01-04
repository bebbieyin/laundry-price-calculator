<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuccessForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SuccessForm))
        Me.SuccessLabel = New System.Windows.Forms.Label()
        Me.okButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SuccessLabel
        '
        Me.SuccessLabel.AutoSize = True
        Me.SuccessLabel.BackColor = System.Drawing.Color.Transparent
        Me.SuccessLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SuccessLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuccessLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SuccessLabel.Location = New System.Drawing.Point(119, 36)
        Me.SuccessLabel.Name = "SuccessLabel"
        Me.SuccessLabel.Size = New System.Drawing.Size(254, 24)
        Me.SuccessLabel.TabIndex = 0
        Me.SuccessLabel.Text = "SUCCESS ! THANK YOU !"
        Me.SuccessLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'okButton
        '
        Me.okButton.BackColor = System.Drawing.Color.Snow
        Me.okButton.Location = New System.Drawing.Point(233, 101)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 23)
        Me.okButton.TabIndex = 1
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'SuccessForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(485, 190)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.SuccessLabel)
        Me.Name = "SuccessForm"
        Me.Text = "Success"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SuccessLabel As Label
    Friend WithEvents okButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

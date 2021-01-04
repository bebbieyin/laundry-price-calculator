<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.websiteLink = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("AR CENA", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(589, 343)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME TO MYLAUNDRY CALCULATOR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.Snow
        Me.StartButton.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(222, 194)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(136, 52)
        Me.StartButton.TabIndex = 1
        Me.StartButton.Text = "START"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Snow
        Me.ExitButton.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(222, 275)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(136, 52)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "&EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'websiteLink
        '
        Me.websiteLink.AutoSize = True
        Me.websiteLink.BackColor = System.Drawing.Color.White
        Me.websiteLink.Location = New System.Drawing.Point(473, 314)
        Me.websiteLink.Name = "websiteLink"
        Me.websiteLink.Size = New System.Drawing.Size(104, 13)
        Me.websiteLink.TabIndex = 6
        Me.websiteLink.TabStop = True
        Me.websiteLink.Text = "www.mylaundry.com"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(589, 343)
        Me.Controls.Add(Me.websiteLink)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.Label1)
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents StartButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents websiteLink As LinkLabel
End Class

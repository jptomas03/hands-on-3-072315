<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billing
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
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddressTB = New System.Windows.Forms.TextBox()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.TrainingFeeTB = New System.Windows.Forms.TextBox()
        Me.TrainingFeeLabel = New System.Windows.Forms.Label()
        Me.NoOfParticipantsTB = New System.Windows.Forms.TextBox()
        Me.NumberOfPariticipantsLabel = New System.Windows.Forms.Label()
        Me.AmountDueTB = New System.Windows.Forms.TextBox()
        Me.AmountDueLabel = New System.Windows.Forms.Label()
        Me.RegistrationFeeTB = New System.Windows.Forms.TextBox()
        Me.RegistrationFeeLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ComputeButton
        '
        Me.ComputeButton.Location = New System.Drawing.Point(475, 150)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(244, 23)
        Me.ComputeButton.TabIndex = 0
        Me.ComputeButton.Text = " Compute"
        Me.ComputeButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(109, 48)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Name"
        '
        'NameTB
        '
        Me.NameTB.Location = New System.Drawing.Point(81, 74)
        Me.NameTB.Name = "NameTB"
        Me.NameTB.Size = New System.Drawing.Size(143, 20)
        Me.NameTB.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(335, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Manny Management Consultig"
        '
        'AddressTB
        '
        Me.AddressTB.Location = New System.Drawing.Point(230, 74)
        Me.AddressTB.Name = "AddressTB"
        Me.AddressTB.Size = New System.Drawing.Size(212, 20)
        Me.AddressTB.TabIndex = 5
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(317, 48)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(45, 13)
        Me.AddressLabel.TabIndex = 4
        Me.AddressLabel.Text = "Address"
        '
        'TrainingFeeTB
        '
        Me.TrainingFeeTB.Location = New System.Drawing.Point(619, 67)
        Me.TrainingFeeTB.Name = "TrainingFeeTB"
        Me.TrainingFeeTB.ReadOnly = True
        Me.TrainingFeeTB.Size = New System.Drawing.Size(100, 20)
        Me.TrainingFeeTB.TabIndex = 9
        Me.TrainingFeeTB.Text = "3000"
        '
        'TrainingFeeLabel
        '
        Me.TrainingFeeLabel.AutoSize = True
        Me.TrainingFeeLabel.Location = New System.Drawing.Point(472, 74)
        Me.TrainingFeeLabel.Name = "TrainingFeeLabel"
        Me.TrainingFeeLabel.Size = New System.Drawing.Size(66, 13)
        Me.TrainingFeeLabel.TabIndex = 8
        Me.TrainingFeeLabel.Text = "Training Fee"
        '
        'NoOfParticipantsTB
        '
        Me.NoOfParticipantsTB.Location = New System.Drawing.Point(619, 41)
        Me.NoOfParticipantsTB.Name = "NoOfParticipantsTB"
        Me.NoOfParticipantsTB.Size = New System.Drawing.Size(100, 20)
        Me.NoOfParticipantsTB.TabIndex = 7
        '
        'NumberOfPariticipantsLabel
        '
        Me.NumberOfPariticipantsLabel.AutoSize = True
        Me.NumberOfPariticipantsLabel.Location = New System.Drawing.Point(472, 48)
        Me.NumberOfPariticipantsLabel.Name = "NumberOfPariticipantsLabel"
        Me.NumberOfPariticipantsLabel.Size = New System.Drawing.Size(114, 13)
        Me.NumberOfPariticipantsLabel.TabIndex = 6
        Me.NumberOfPariticipantsLabel.Text = "Number of Participants"
        '
        'AmountDueTB
        '
        Me.AmountDueTB.Location = New System.Drawing.Point(619, 123)
        Me.AmountDueTB.Name = "AmountDueTB"
        Me.AmountDueTB.ReadOnly = True
        Me.AmountDueTB.Size = New System.Drawing.Size(100, 20)
        Me.AmountDueTB.TabIndex = 13
        '
        'AmountDueLabel
        '
        Me.AmountDueLabel.AutoSize = True
        Me.AmountDueLabel.Location = New System.Drawing.Point(472, 126)
        Me.AmountDueLabel.Name = "AmountDueLabel"
        Me.AmountDueLabel.Size = New System.Drawing.Size(66, 13)
        Me.AmountDueLabel.TabIndex = 12
        Me.AmountDueLabel.Text = "Amount Due"
        '
        'RegistrationFeeTB
        '
        Me.RegistrationFeeTB.Location = New System.Drawing.Point(619, 93)
        Me.RegistrationFeeTB.Name = "RegistrationFeeTB"
        Me.RegistrationFeeTB.ReadOnly = True
        Me.RegistrationFeeTB.Size = New System.Drawing.Size(100, 20)
        Me.RegistrationFeeTB.TabIndex = 11
        Me.RegistrationFeeTB.Text = "250"
        '
        'RegistrationFeeLabel
        '
        Me.RegistrationFeeLabel.AutoSize = True
        Me.RegistrationFeeLabel.Location = New System.Drawing.Point(472, 100)
        Me.RegistrationFeeLabel.Name = "RegistrationFeeLabel"
        Me.RegistrationFeeLabel.Size = New System.Drawing.Size(84, 13)
        Me.RegistrationFeeLabel.TabIndex = 10
        Me.RegistrationFeeLabel.Text = "Registration Fee"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = " add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(230, 100)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 20)
        Me.TextBox1.TabIndex = 16
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(81, 100)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(143, 20)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(230, 126)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(212, 20)
        Me.TextBox3.TabIndex = 18
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(81, 126)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(143, 20)
        Me.TextBox4.TabIndex = 17
        '
        'billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(840, 261)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AmountDueTB)
        Me.Controls.Add(Me.AmountDueLabel)
        Me.Controls.Add(Me.RegistrationFeeTB)
        Me.Controls.Add(Me.RegistrationFeeLabel)
        Me.Controls.Add(Me.TrainingFeeTB)
        Me.Controls.Add(Me.TrainingFeeLabel)
        Me.Controls.Add(Me.NoOfParticipantsTB)
        Me.Controls.Add(Me.NumberOfPariticipantsLabel)
        Me.Controls.Add(Me.AddressTB)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NameTB)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.ComputeButton)
        Me.Name = "billing"
        Me.Text = "Manny Managemet Consulting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComputeButton As System.Windows.Forms.Button
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents NameTB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AddressTB As System.Windows.Forms.TextBox
    Friend WithEvents AddressLabel As System.Windows.Forms.Label
    Friend WithEvents TrainingFeeTB As System.Windows.Forms.TextBox
    Friend WithEvents TrainingFeeLabel As System.Windows.Forms.Label
    Friend WithEvents NoOfParticipantsTB As System.Windows.Forms.TextBox
    Friend WithEvents NumberOfPariticipantsLabel As System.Windows.Forms.Label
    Friend WithEvents AmountDueTB As System.Windows.Forms.TextBox
    Friend WithEvents AmountDueLabel As System.Windows.Forms.Label
    Friend WithEvents RegistrationFeeTB As System.Windows.Forms.TextBox
    Friend WithEvents RegistrationFeeLabel As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox

End Class

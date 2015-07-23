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
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(100, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(244, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Compute"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(97, 72)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Name"
        '
        'NameTB
        '
        Me.NameTB.Location = New System.Drawing.Point(244, 65)
        Me.NameTB.Name = "NameTB"
        Me.NameTB.Size = New System.Drawing.Size(100, 20)
        Me.NameTB.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Manny Management Consultig"
        '
        'AddressTB
        '
        Me.AddressTB.Location = New System.Drawing.Point(244, 91)
        Me.AddressTB.Name = "AddressTB"
        Me.AddressTB.Size = New System.Drawing.Size(100, 20)
        Me.AddressTB.TabIndex = 5
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(97, 98)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(45, 13)
        Me.AddressLabel.TabIndex = 4
        Me.AddressLabel.Text = "Address"
        '
        'TrainingFeeTB
        '
        Me.TrainingFeeTB.Location = New System.Drawing.Point(244, 143)
        Me.TrainingFeeTB.Name = "TrainingFeeTB"
        Me.TrainingFeeTB.ReadOnly = True
        Me.TrainingFeeTB.Size = New System.Drawing.Size(100, 20)
        Me.TrainingFeeTB.TabIndex = 9
        Me.TrainingFeeTB.Text = "3000"
        '
        'TrainingFeeLabel
        '
        Me.TrainingFeeLabel.AutoSize = True
        Me.TrainingFeeLabel.Location = New System.Drawing.Point(97, 150)
        Me.TrainingFeeLabel.Name = "TrainingFeeLabel"
        Me.TrainingFeeLabel.Size = New System.Drawing.Size(66, 13)
        Me.TrainingFeeLabel.TabIndex = 8
        Me.TrainingFeeLabel.Text = "Training Fee"
        '
        'NoOfParticipantsTB
        '
        Me.NoOfParticipantsTB.Location = New System.Drawing.Point(244, 117)
        Me.NoOfParticipantsTB.Name = "NoOfParticipantsTB"
        Me.NoOfParticipantsTB.Size = New System.Drawing.Size(100, 20)
        Me.NoOfParticipantsTB.TabIndex = 7
        '
        'NumberOfPariticipantsLabel
        '
        Me.NumberOfPariticipantsLabel.AutoSize = True
        Me.NumberOfPariticipantsLabel.Location = New System.Drawing.Point(97, 124)
        Me.NumberOfPariticipantsLabel.Name = "NumberOfPariticipantsLabel"
        Me.NumberOfPariticipantsLabel.Size = New System.Drawing.Size(114, 13)
        Me.NumberOfPariticipantsLabel.TabIndex = 6
        Me.NumberOfPariticipantsLabel.Text = "Number of Participants"
        '
        'AmountDueTB
        '
        Me.AmountDueTB.Location = New System.Drawing.Point(244, 195)
        Me.AmountDueTB.Name = "AmountDueTB"
        Me.AmountDueTB.ReadOnly = True
        Me.AmountDueTB.Size = New System.Drawing.Size(100, 20)
        Me.AmountDueTB.TabIndex = 13
        '
        'AmountDueLabel
        '
        Me.AmountDueLabel.AutoSize = True
        Me.AmountDueLabel.Location = New System.Drawing.Point(97, 202)
        Me.AmountDueLabel.Name = "AmountDueLabel"
        Me.AmountDueLabel.Size = New System.Drawing.Size(66, 13)
        Me.AmountDueLabel.TabIndex = 12
        Me.AmountDueLabel.Text = "Amount Due"
        '
        'RegistrationFeeTB
        '
        Me.RegistrationFeeTB.Location = New System.Drawing.Point(244, 169)
        Me.RegistrationFeeTB.Name = "RegistrationFeeTB"
        Me.RegistrationFeeTB.ReadOnly = True
        Me.RegistrationFeeTB.Size = New System.Drawing.Size(100, 20)
        Me.RegistrationFeeTB.TabIndex = 11
        Me.RegistrationFeeTB.Text = "250"
        '
        'RegistrationFeeLabel
        '
        Me.RegistrationFeeLabel.AutoSize = True
        Me.RegistrationFeeLabel.Location = New System.Drawing.Point(97, 176)
        Me.RegistrationFeeLabel.Name = "RegistrationFeeLabel"
        Me.RegistrationFeeLabel.Size = New System.Drawing.Size(84, 13)
        Me.RegistrationFeeLabel.TabIndex = 10
        Me.RegistrationFeeLabel.Text = "Registration Fee"
        '
        'billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 261)
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
        Me.Controls.Add(Me.Button1)
        Me.Name = "billing"
        Me.Text = "Manny Managemet Consulting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
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

End Class

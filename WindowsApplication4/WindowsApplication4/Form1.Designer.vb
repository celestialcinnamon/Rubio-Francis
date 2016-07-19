<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.grpPersonalInfo = New System.Windows.Forms.GroupBox()
        Me.numPax = New System.Windows.Forms.NumericUpDown()
        Me.nudAge = New System.Windows.Forms.NumericUpDown()
        Me.lblPax = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lbl1Contact = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grpAccomodation = New System.Windows.Forms.GroupBox()
        Me.rbExecutive = New System.Windows.Forms.RadioButton()
        Me.rbDeluxe = New System.Windows.Forms.RadioButton()
        Me.rbEconomy = New System.Windows.Forms.RadioButton()
        Me.rbStandard = New System.Windows.Forms.RadioButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpDiscount = New System.Windows.Forms.GroupBox()
        Me.rdSenior = New System.Windows.Forms.RadioButton()
        Me.rdDisabled = New System.Windows.Forms.RadioButton()
        Me.rdEmployee = New System.Windows.Forms.RadioButton()
        Me.rbRegular = New System.Windows.Forms.RadioButton()
        Me.grpBillingInfo = New System.Windows.Forms.GroupBox()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.txtTotAmt = New System.Windows.Forms.TextBox()
        Me.lblAmtDue = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.txtTotalDiscount = New System.Windows.Forms.TextBox()
        Me.lblTotalDiscount = New System.Windows.Forms.Label()
        Me.txtAmtDue = New System.Windows.Forms.TextBox()
        Me.grpPersonalInfo.SuspendLayout()
        CType(Me.numPax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAccomodation.SuspendLayout()
        Me.grpDiscount.SuspendLayout()
        Me.grpBillingInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPersonalInfo
        '
        Me.grpPersonalInfo.Controls.Add(Me.numPax)
        Me.grpPersonalInfo.Controls.Add(Me.nudAge)
        Me.grpPersonalInfo.Controls.Add(Me.lblPax)
        Me.grpPersonalInfo.Controls.Add(Me.lblAge)
        Me.grpPersonalInfo.Controls.Add(Me.lbl1Contact)
        Me.grpPersonalInfo.Controls.Add(Me.lblName)
        Me.grpPersonalInfo.Controls.Add(Me.txtName)
        Me.grpPersonalInfo.Controls.Add(Me.TextBox1)
        Me.grpPersonalInfo.Location = New System.Drawing.Point(12, 59)
        Me.grpPersonalInfo.Name = "grpPersonalInfo"
        Me.grpPersonalInfo.Size = New System.Drawing.Size(424, 137)
        Me.grpPersonalInfo.TabIndex = 0
        Me.grpPersonalInfo.TabStop = False
        Me.grpPersonalInfo.Text = "Personal Information"
        '
        'numPax
        '
        Me.numPax.Location = New System.Drawing.Point(283, 68)
        Me.numPax.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.numPax.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numPax.Name = "numPax"
        Me.numPax.Size = New System.Drawing.Size(133, 20)
        Me.numPax.TabIndex = 3
        Me.numPax.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'nudAge
        '
        Me.nudAge.Location = New System.Drawing.Point(76, 69)
        Me.nudAge.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudAge.Minimum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.nudAge.Name = "nudAge"
        Me.nudAge.Size = New System.Drawing.Size(133, 20)
        Me.nudAge.TabIndex = 2
        Me.nudAge.Value = New Decimal(New Integer() {18, 0, 0, 0})
        '
        'lblPax
        '
        Me.lblPax.AutoSize = True
        Me.lblPax.Location = New System.Drawing.Point(249, 70)
        Me.lblPax.Name = "lblPax"
        Me.lblPax.Size = New System.Drawing.Size(28, 13)
        Me.lblPax.TabIndex = 1
        Me.lblPax.Text = "Pax:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(40, 75)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(29, 13)
        Me.lblAge.TabIndex = 1
        Me.lblAge.Text = "Age:"
        '
        'lbl1Contact
        '
        Me.lbl1Contact.AutoSize = True
        Me.lbl1Contact.Location = New System.Drawing.Point(12, 45)
        Me.lbl1Contact.Name = "lbl1Contact"
        Me.lbl1Contact.Size = New System.Drawing.Size(57, 13)
        Me.lbl1Contact.TabIndex = 1
        Me.lbl1Contact.Text = "Contact #:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(31, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(75, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(343, 20)
        Me.txtName.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(75, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(343, 20)
        Me.TextBox1.TabIndex = 0
        '
        'grpAccomodation
        '
        Me.grpAccomodation.Controls.Add(Me.rbExecutive)
        Me.grpAccomodation.Controls.Add(Me.rbDeluxe)
        Me.grpAccomodation.Controls.Add(Me.rbEconomy)
        Me.grpAccomodation.Controls.Add(Me.rbStandard)
        Me.grpAccomodation.Enabled = False
        Me.grpAccomodation.Location = New System.Drawing.Point(12, 231)
        Me.grpAccomodation.Name = "grpAccomodation"
        Me.grpAccomodation.Size = New System.Drawing.Size(209, 137)
        Me.grpAccomodation.TabIndex = 1
        Me.grpAccomodation.TabStop = False
        Me.grpAccomodation.Text = "Accommodation"
        '
        'rbExecutive
        '
        Me.rbExecutive.AutoSize = True
        Me.rbExecutive.Location = New System.Drawing.Point(15, 98)
        Me.rbExecutive.Name = "rbExecutive"
        Me.rbExecutive.Size = New System.Drawing.Size(130, 17)
        Me.rbExecutive.TabIndex = 3
        Me.rbExecutive.TabStop = True
        Me.rbExecutive.Text = "Executive (PHP 1000)"
        Me.rbExecutive.UseVisualStyleBackColor = True
        '
        'rbDeluxe
        '
        Me.rbDeluxe.AutoSize = True
        Me.rbDeluxe.Location = New System.Drawing.Point(15, 75)
        Me.rbDeluxe.Name = "rbDeluxe"
        Me.rbDeluxe.Size = New System.Drawing.Size(110, 17)
        Me.rbDeluxe.TabIndex = 2
        Me.rbDeluxe.TabStop = True
        Me.rbDeluxe.Text = "Deluxe (PHP 900)"
        Me.rbDeluxe.UseVisualStyleBackColor = True
        '
        'rbEconomy
        '
        Me.rbEconomy.AutoSize = True
        Me.rbEconomy.Location = New System.Drawing.Point(15, 52)
        Me.rbEconomy.Name = "rbEconomy"
        Me.rbEconomy.Size = New System.Drawing.Size(121, 17)
        Me.rbEconomy.TabIndex = 1
        Me.rbEconomy.TabStop = True
        Me.rbEconomy.Text = "Economy (PHP 300)"
        Me.rbEconomy.UseVisualStyleBackColor = True
        '
        'rbStandard
        '
        Me.rbStandard.AutoSize = True
        Me.rbStandard.Location = New System.Drawing.Point(15, 29)
        Me.rbStandard.Name = "rbStandard"
        Me.rbStandard.Size = New System.Drawing.Size(120, 17)
        Me.rbStandard.TabIndex = 0
        Me.rbStandard.TabStop = True
        Me.rbStandard.Text = "Standard (PHP 400)"
        Me.rbStandard.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(257, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(319, 37)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Hotel Billing System"
        '
        'grpDiscount
        '
        Me.grpDiscount.Controls.Add(Me.rdSenior)
        Me.grpDiscount.Controls.Add(Me.rdDisabled)
        Me.grpDiscount.Controls.Add(Me.rdEmployee)
        Me.grpDiscount.Controls.Add(Me.rbRegular)
        Me.grpDiscount.Enabled = False
        Me.grpDiscount.Location = New System.Drawing.Point(227, 231)
        Me.grpDiscount.Name = "grpDiscount"
        Me.grpDiscount.Size = New System.Drawing.Size(209, 137)
        Me.grpDiscount.TabIndex = 1
        Me.grpDiscount.TabStop = False
        Me.grpDiscount.Text = "Discount"
        '
        'rdSenior
        '
        Me.rdSenior.AutoSize = True
        Me.rdSenior.Location = New System.Drawing.Point(15, 98)
        Me.rdSenior.Name = "rdSenior"
        Me.rdSenior.Size = New System.Drawing.Size(118, 17)
        Me.rdSenior.TabIndex = 3
        Me.rdSenior.TabStop = True
        Me.rdSenior.Text = "Senior Citizen (20%)"
        Me.rdSenior.UseVisualStyleBackColor = True
        '
        'rdDisabled
        '
        Me.rdDisabled.AutoSize = True
        Me.rdDisabled.Location = New System.Drawing.Point(15, 76)
        Me.rdDisabled.Name = "rdDisabled"
        Me.rdDisabled.Size = New System.Drawing.Size(95, 17)
        Me.rdDisabled.TabIndex = 2
        Me.rdDisabled.TabStop = True
        Me.rdDisabled.Text = "Disabled (10%)"
        Me.rdDisabled.UseVisualStyleBackColor = True
        '
        'rdEmployee
        '
        Me.rdEmployee.AutoSize = True
        Me.rdEmployee.Location = New System.Drawing.Point(15, 52)
        Me.rdEmployee.Name = "rdEmployee"
        Me.rdEmployee.Size = New System.Drawing.Size(94, 17)
        Me.rdEmployee.TabIndex = 1
        Me.rdEmployee.TabStop = True
        Me.rdEmployee.Text = "Employee (5%)"
        Me.rdEmployee.UseVisualStyleBackColor = True
        '
        'rbRegular
        '
        Me.rbRegular.AutoSize = True
        Me.rbRegular.Location = New System.Drawing.Point(15, 29)
        Me.rbRegular.Name = "rbRegular"
        Me.rbRegular.Size = New System.Drawing.Size(62, 17)
        Me.rbRegular.TabIndex = 0
        Me.rbRegular.TabStop = True
        Me.rbRegular.Text = "Regular"
        Me.rbRegular.UseVisualStyleBackColor = True
        '
        'grpBillingInfo
        '
        Me.grpBillingInfo.Controls.Add(Me.txtAmtDue)
        Me.grpBillingInfo.Controls.Add(Me.cmdCalculate)
        Me.grpBillingInfo.Controls.Add(Me.txtTotAmt)
        Me.grpBillingInfo.Controls.Add(Me.lblAmtDue)
        Me.grpBillingInfo.Controls.Add(Me.Label1)
        Me.grpBillingInfo.Controls.Add(Me.txtPayment)
        Me.grpBillingInfo.Controls.Add(Me.lblPayment)
        Me.grpBillingInfo.Controls.Add(Me.txtTotalDiscount)
        Me.grpBillingInfo.Controls.Add(Me.lblTotalDiscount)
        Me.grpBillingInfo.Location = New System.Drawing.Point(491, 69)
        Me.grpBillingInfo.Name = "grpBillingInfo"
        Me.grpBillingInfo.Size = New System.Drawing.Size(320, 307)
        Me.grpBillingInfo.TabIndex = 3
        Me.grpBillingInfo.TabStop = False
        Me.grpBillingInfo.Text = "Billing Information"
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(29, 231)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(253, 55)
        Me.cmdCalculate.TabIndex = 2
        Me.cmdCalculate.Text = "Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'txtTotAmt
        '
        Me.txtTotAmt.Enabled = False
        Me.txtTotAmt.Location = New System.Drawing.Point(22, 68)
        Me.txtTotAmt.Name = "txtTotAmt"
        Me.txtTotAmt.Size = New System.Drawing.Size(276, 20)
        Me.txtTotAmt.TabIndex = 1
        '
        'lblAmtDue
        '
        Me.lblAmtDue.AutoSize = True
        Me.lblAmtDue.Location = New System.Drawing.Point(19, 132)
        Me.lblAmtDue.Name = "lblAmtDue"
        Me.lblAmtDue.Size = New System.Drawing.Size(66, 13)
        Me.lblAmtDue.TabIndex = 0
        Me.lblAmtDue.Text = "Amount Due"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Amount"
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(22, 187)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(276, 20)
        Me.txtPayment.TabIndex = 1
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(19, 171)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(48, 13)
        Me.lblPayment.TabIndex = 0
        Me.lblPayment.Text = "Payment"
        '
        'txtTotalDiscount
        '
        Me.txtTotalDiscount.Enabled = False
        Me.txtTotalDiscount.Location = New System.Drawing.Point(22, 107)
        Me.txtTotalDiscount.Name = "txtTotalDiscount"
        Me.txtTotalDiscount.Size = New System.Drawing.Size(276, 20)
        Me.txtTotalDiscount.TabIndex = 1
        '
        'lblTotalDiscount
        '
        Me.lblTotalDiscount.AutoSize = True
        Me.lblTotalDiscount.Location = New System.Drawing.Point(19, 91)
        Me.lblTotalDiscount.Name = "lblTotalDiscount"
        Me.lblTotalDiscount.Size = New System.Drawing.Size(76, 13)
        Me.lblTotalDiscount.TabIndex = 0
        Me.lblTotalDiscount.Text = "Total Discount"
        '
        'txtAmtDue
        '
        Me.txtAmtDue.Enabled = False
        Me.txtAmtDue.Location = New System.Drawing.Point(23, 148)
        Me.txtAmtDue.Name = "txtAmtDue"
        Me.txtAmtDue.Size = New System.Drawing.Size(274, 20)
        Me.txtAmtDue.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 413)
        Me.Controls.Add(Me.grpBillingInfo)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpDiscount)
        Me.Controls.Add(Me.grpAccomodation)
        Me.Controls.Add(Me.grpPersonalInfo)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Billing System"
        Me.grpPersonalInfo.ResumeLayout(False)
        Me.grpPersonalInfo.PerformLayout()
        CType(Me.numPax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAccomodation.ResumeLayout(False)
        Me.grpAccomodation.PerformLayout()
        Me.grpDiscount.ResumeLayout(False)
        Me.grpDiscount.PerformLayout()
        Me.grpBillingInfo.ResumeLayout(False)
        Me.grpBillingInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpPersonalInfo As System.Windows.Forms.GroupBox
    Friend WithEvents numPax As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAge As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPax As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lbl1Contact As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents grpAccomodation As System.Windows.Forms.GroupBox
    Friend WithEvents rbExecutive As System.Windows.Forms.RadioButton
    Friend WithEvents rbDeluxe As System.Windows.Forms.RadioButton
    Friend WithEvents rbEconomy As System.Windows.Forms.RadioButton
    Friend WithEvents rbStandard As System.Windows.Forms.RadioButton
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpDiscount As System.Windows.Forms.GroupBox
    Friend WithEvents rdSenior As System.Windows.Forms.RadioButton
    Friend WithEvents rdDisabled As System.Windows.Forms.RadioButton
    Friend WithEvents rdEmployee As System.Windows.Forms.RadioButton
    Friend WithEvents rbRegular As System.Windows.Forms.RadioButton
    Friend WithEvents grpBillingInfo As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCalculate As System.Windows.Forms.Button
    Friend WithEvents txtTotAmt As System.Windows.Forms.TextBox
    Friend WithEvents lblAmtDue As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents txtTotalDiscount As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalDiscount As System.Windows.Forms.Label
    Friend WithEvents txtAmtDue As TextBox
End Class

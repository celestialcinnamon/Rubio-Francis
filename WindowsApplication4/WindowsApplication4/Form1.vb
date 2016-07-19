Public Class Form1
    Dim standard, economy, deluxe, executive As Double
    Dim regular, employee, disabled, seniorCitizen As Double
    Dim accomodation, discountType As String
    Dim discount As Double
    Dim cus_Name, contactNum As String
    Dim age, pax As Integer
    Dim totAmt, totDisc, amtDue, payment As Double

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        If Not Double.TryParse(txtPayment.Text, payment) Then
            MessageBox.Show("It seems that you forgot to put your payment.", "Oops!")
        Else
            If payment < amtDue Then
                MessageBox.Show("Your payment is insufficient. Please try again", "Oops!")
            Else
                Dim receipt As String
                pax = CInt(numPax.Text)
                cus_Name = txtName.Text

                receipt = "========================================" & vbNewLine &
                          "                                 Hotel Billing System" & vbNewLine &
                          "                         Caloocan City, NCR, Philippines" & vbNewLine &
                          "========================================" & vbNewLine &
                          vbNewLine &
                          "Accomodation: " & accomodation & vbNewLine &
                          "PAX: " & pax & vbNewLine &
                          "Price: ₱ " & totAmt.ToString("N2") & vbNewLine &
                          "Discount Type: " & discountType & vbNewLine &
                          "Total Discount: ₱ " & discount.ToString("N2") & vbNewLine &
                          vbNewLine &
                          "AMOUNT DUE: ₱ " & amtDue & vbNewLine &
                          "PAYMENT: ₱ " & payment & vbNewLine &
                          "Change:  ₱ " & (payment - amtDue).ToString("N2") &
                          vbNewLine &
                          "Sold to: " & cus_Name & vbNewLine &
                          vbNewLine & vbNewLine & vbNewLine &
                          "========================================" & vbNewLine &
                          "                 THANK YOU FOR THIS TRANSACTION" & vbNewLine &
                          "               THIS SERVES AS YOUR OFFICIAL RECEIPT" & vbNewLine &
                          "========================================"
                MessageBox.Show(receipt, "Official Receipt")

            End If
        End If
    End Sub

    Private Sub txtAmtDue_TextChanged(sender As Object, e As EventArgs)
        Dim tempAmtDue As Double = 0
        Dim tempTotDisc As Double = 0

        Double.TryParse(txtTotalDiscount.Text, tempTotDisc)
        Double.TryParse(txtAmtDue.Text, tempAmtDue)

        amtDue = tempAmtDue - tempTotDisc
        txtAmtDue.Text = "₱ " & amtDue.ToString("N2")
    End Sub

    Private Sub rdSenior_CheckedChanged(sender As Object, e As EventArgs) Handles rdSenior.CheckedChanged
        If rdSenior.Checked = True Then
            seniorCitizen = 0.2
            discountType = "Senior Citizen"
            discount = CDbl(txtTotAmt.Text) * seniorCitizen
            txtTotalDiscount.Text = discount.ToString
            amtDue = totAmt - discount
            txtAmtDue.Text = "₱ " & amtDue.ToString("N2")
        Else
            amtDue = totAmt + discount
            txtAmtDue.Text = "₱ " & amtDue.ToString("N2")
        End If
    End Sub

    Private Sub rdDisabled_CheckedChanged(sender As Object, e As EventArgs) Handles rdDisabled.CheckedChanged
        If rdDisabled.Checked = True Then
            disabled = 0.1
            discountType = "Disabled Person"
            discount = CDbl(txtTotAmt.Text) * disabled
            txtTotalDiscount.Text = "₱ " & discount.ToString("N2")
            amtDue = totAmt - discount
            txtAmtDue.Text = "₱ " & amtDue.ToString("N2")
        Else
            amtDue = totAmt + discount
            txtAmtDue.Text = "₱ " & amtDue.ToString("N2")
        End If
    End Sub

    Private Sub rdEmployee_CheckedChanged(sender As Object, e As EventArgs) Handles rdEmployee.CheckedChanged
        If rdEmployee.Checked = True Then
            employee = 0.05
            discountType = "Employee"
            discount = CDbl(txtTotAmt.Text) * employee
            txtTotalDiscount.Text = "₱ " & discount.ToString("N2")
            amtDue = totAmt - discount
            txtAmtDue.Text = "₱ " & amtDue.ToString("N2")
        Else
            amtDue = totAmt + discount
            txtAmtDue.Text = "₱ " & amtDue.ToString("N2")
        End If
    End Sub

    Private Sub rbRegular_CheckedChanged(sender As Object, e As EventArgs) Handles rbRegular.CheckedChanged
        If rbRegular.Checked = True Then
            regular = 0
            discountType = "Regular"
            discount = CDbl(txtTotAmt.Text) * regular
            txtTotalDiscount.Text = "₱ " & discount.ToString("N2")
            amtDue = totAmt - discount
            txtAmtDue.Text = "₱ " & amtDue.ToString("N2")
        Else
            amtDue = totAmt - discount
            txtAmtDue.Text = "₱ " & amtDue.ToString("N2")
        End If
    End Sub


    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        grpAccomodation.Enabled = True
    End Sub

    Private Sub rbEconomy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEconomy.CheckedChanged
        If rbEconomy.Checked = True Then
            grpDiscount.Enabled = True
            accomodation = "Economy"
            economy = 300
            totAmt += economy
        Else
            totAmt -= economy
        End If
        txtTotAmt.Text = "₱ " & totAmt.ToString("N2")
    End Sub


    Private Sub rbStandard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStandard.CheckedChanged
        If rbStandard.Checked = True Then
            grpDiscount.Enabled = True
            accomodation = "Standard"
            standard = 400
            totAmt += standard
        Else
            totAmt -= standard
        End If
        txtTotAmt.Text = "₱ " & totAmt.ToString("N2")
    End Sub

    Private Sub rbDeluxe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDeluxe.CheckedChanged
        If rbDeluxe.Checked = True Then
            grpDiscount.Enabled = True
            accomodation = "Deluxe"
            deluxe = 900
            totAmt += deluxe
        Else
            totAmt -= deluxe
        End If
        txtTotAmt.Text = "₱ " & totAmt.ToString("N2")
    End Sub

    Private Sub rbExecutive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbExecutive.CheckedChanged
        If rbExecutive.Checked = True Then
            grpDiscount.Enabled = True
            accomodation = "Executive"
            executive = 1000
            totAmt += executive
        Else
            totAmt -= executive
        End If
        txtTotAmt.Text = "₱ " & totAmt.ToString("N2")
    End Sub

End Class

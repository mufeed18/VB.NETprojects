Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim decBaseFee As Decimal 'base monthly fee
        Dim decTotalFee As Decimal 'total membershipfee
        Dim intMonths As Integer 'number of months
        Dim blnInputOk As Boolean = True

        'constants for base fees
        Const decADULT_FEE As Decimal = 40D
        Const decCHILD_FEE As Decimal = 20D
        Const decSTUDENT_FEE As Decimal = 25D
        Const decSENIOR_FEE As Decimal = 30D
        'constants for additional fees
        Const decYOGA_FEE As Decimal = 10D
        Const decKATATE_FEE As Decimal = 30D
        Const decTRAINER_FEE As Decimal = 50D

        'validate and convert the number of months
        lblStatus.Text = String.Empty
        If Integer.TryParse(txtMonths.Text, intMonths) = False Then
            lblStatus.Text = "Months must be integer."
            blnInputOk = False
        End If
        'validate the number of months.
        If intMonths < 1 Or intMonths > 24 Then
            lblStatus.Text = "Months must be integer and in the range of 1-24."
            blnInputOk = False
        End If

        If blnInputOk = True Then
            'determine the base monthly fee
            If radAdult.Checked = True Then
                decBaseFee = decADULT_FEE
            ElseIf radChild.Checked = True Then
                decBaseFee = decCHILD_FEE
            ElseIf radStudent.Checked = True Then
                decBaseFee = decSTUDENT_FEE
            ElseIf radSenior.Checked = True Then
                decBaseFee = decSENIOR_FEE
            End If

            'check for additional services
            If chkYoga.Checked = True Then
                decBaseFee += decYOGA_FEE
            End If
            If chkKarate.Checked = True Then
                decBaseFee += decKATATE_FEE
            End If
            If chkTrainer.Checked = True Then
                decBaseFee += decTRAINER_FEE
            End If

            'calculate the total fee
            decTotalFee = decBaseFee * intMonths

            'display the total fee
            lblMonthlyFee.Text = decBaseFee.ToString("c")
            lblTotalFee.Text = decTotalFee.ToString("c")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'reset the adult radio button
        radAdult.Checked = True
        'clear the check boxes
        chkKarate.Checked = False
        chkTrainer.Checked = False
        chkYoga.Checked = False
        'clear the number of month
        txtMonths.Text = ""
        'clear the fee lables
        lblMonthlyFee.Text = ""
        lblStatus.Text = ""
        lblTotalFee.Text = ""
        'give txtMonth the focus
        txtMonths.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the form
        Me.Close()

    End Sub
End Class

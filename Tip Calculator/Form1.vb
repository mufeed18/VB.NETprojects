Public Class Form1
    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        'declare 2 vaiables 
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0
        'retrieve the user input for the bill amt and store in the dblbill
        dblBill = CDbl(txtBillAmount.Text)
        'calculate 15% tip
        dblTip = dblBill * 0.15
        'display the tip amount in the label control
        lblTip.Text = CStr(dblTip)

    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        'declare 2 variables
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0
        'retreieve the user input for the bill amt and store in the dblBill
        dblBill = CDbl(txtBillAmount.Text)
        'Calculate 20% tip
        dblTip = dblBill * 0.2
        'display the tip amount in the label contro
        lblTip.Text = CStr(dblTip)

    End Sub

    Private Sub btn25_Click(sender As Object, e As EventArgs) Handles btn25.Click

        'declare 2 vaiables 
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0
        'retrieve the user input for the bill amt and store in the dblbill
        dblBill = CDbl(txtBillAmount.Text)
        'calculate 15% tip
        dblTip = dblBill * 0.25
        'display the tip amount in the label control
        lblTip.Text = CStr(dblTip)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear all textboxes and lblcontrol
        txtBillAmount.Clear()
        lblTip.Text = " "

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the app
        Me.Close()

    End Sub
End Class

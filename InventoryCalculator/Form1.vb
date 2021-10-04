Public Class frmInvCalculator
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'closes Inventory Calculator application
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim amt As Integer
        Dim cost As Integer
        Dim value As Integer
        Dim fee As Decimal
        Dim target As Integer = 1000
        Dim highrate As Decimal = 0.15
        Dim lowrate As Decimal = 0.05

        Integer.TryParse(txtbxAmount.Text, amt)
        Decimal.TryParse(txtbxProductCost.Text, cost)

        value = amt * cost

        If value > target Then
            fee = value * highrate
            txtbxStockingFee.BackColor = Color.LightGreen
        End If

        If target > value Then
            fee = value * lowrate
            txtbxStockingFee.BackColor = Color.LightCoral
        End If
        txtbxAmount.Text = Convert.ToString(amt)
        txtbxProductCost.Text = Convert.ToString(cost)
        txtbxStockingFee.Text = Convert.ToString(fee)
        txtbxValue.Text = Convert.ToString(value)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text in textbox
                txtbxStockingFee.BackColor = BackColor.MistyRose
            End If
        Next Control
    End Sub

End Class

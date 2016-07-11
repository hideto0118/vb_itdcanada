Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim number As Integer = 100

        While number >= 51
            Dim numberPlusOne As Integer = number + 1
            lstbxSecondHalf.Items.Add(numberPlusOne)
            number -= 1
        End While

        While number >= 1
            lstbxFirstHalf.Items.Add(number)
            number -= 1
        End While
    End Sub




    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Dim i As Integer = 0
        While i <= 49
            Dim a As Integer = lstbxFirstHalf.Items(i)
            Dim b As Integer = lstbxSecondHalf.Items(i)
            Mul(a, b)
            Sum(a, b)
            i += 1
        End While
    End Sub

    Sub Mul(ByVal value01 As Integer, ByVal value02 As Integer)
        Dim multipliedNumber As Integer = value01 * value02
        lstbxMultiplied.Items.Add(multipliedNumber)
    End Sub

    Sub Sum(ByVal value01 As Integer, ByVal value02 As Integer)
        Dim AddedNumber As Integer = value01 + value02
        lstbxAdded.Items.Add(AddedNumber)
    End Sub

End Class

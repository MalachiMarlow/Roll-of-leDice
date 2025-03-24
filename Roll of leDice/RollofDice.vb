'Malachi Marlow
''Spring 2025
'RCET2265
'RollofleDice
'https://github.com/MalachiMarlow/Roll-of-leDice.git


Option Strict On
Option Explicit On
Public Class RollofDice

    Sub Main()
        Dim Roll As String
        Dim diceRolls(12) As Integer

        RollDiceListBox.Items.Add("Roll the dice".PadLeft(50))
        RollDiceListBox.Items.Add(StrDup(68, "_"))
        RollDiceListBox.Items.Add(" ")
        RollDiceListBox.Items.Add("  2 |   3 |   4 |   5 |   6 |   7 |   8 |   9 |   10 |   11 |   12 |")

        For i = 1 To 1000
            diceRolls(randomNumberBetween(1, 12)) += 1
        Next
        RollDiceListBox.Items.Add(StrDup(68, "_"))
        RollDiceListBox.Items.Add(" ")

        For i = 2 To UBound(diceRolls)
            Roll &= ($"{CStr(diceRolls(i)),4} |")
        Next
        RollDiceListBox.Items.Add(Roll)
        RollDiceListBox.Items.Add(StrDup(68, "_"))
        RollDiceListBox.Items.Add(" ")
    End Sub

    Function randomNumberBetween(max As Integer, min As Integer) As Integer
        Dim temp As Single
        Randomize()
        temp = Rnd()
        temp *= max - min
        temp += min
        Return CInt(temp)
    End Function

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RollDiceListBox.Items.Clear()
    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        Main()
    End Sub
End Class

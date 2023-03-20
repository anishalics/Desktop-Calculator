Imports System.Collections.Generic
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Class Pair
        Public Property st As Stack(Of Double)
        Public Property sign As Char

        Public Sub New(ByVal st As Stack(Of Double), ByVal sign As Char)
            Me.st = st
            Me.sign = sign
        End Sub
    End Class

    Private Sub clrTxt_Click(sender As Object, e As EventArgs) Handles clrTxt.Click
        txtBox.Text = ""
        Label1.Text = ""
    End Sub

    Private Sub one_Click(sender As Object, e As EventArgs) Handles one.Click
        Dim text = txtBox.Text
        If text.EndsWith("π") OrElse text.EndsWith("e") Then
            txtBox.Text &= "*1"
        Else
            txtBox.Text &= "1"
        End If
    End Sub

    Private Sub two_Click(sender As Object, e As EventArgs) Handles two.Click
        Dim text = txtBox.Text
        If text.EndsWith("π") OrElse text.EndsWith("e") Then
            txtBox.Text &= "*2"
        Else
            txtBox.Text &= "2"
        End If
    End Sub

    Private Sub three_Click(sender As Object, e As EventArgs) Handles three.Click
        Dim text = txtBox.Text
        If text.EndsWith("π") OrElse text.EndsWith("e") Then
            txtBox.Text &= "*3"
        Else
            txtBox.Text &= "3"
        End If
    End Sub

    Private Sub four_Click(sender As Object, e As EventArgs) Handles four.Click
        Dim text = txtBox.Text
        If text.EndsWith("π") OrElse text.EndsWith("e") Then
            txtBox.Text &= "*4"
        Else
            txtBox.Text &= "4"
        End If
    End Sub

    Private Sub five_Click(sender As Object, e As EventArgs) Handles five.Click
        Dim text = txtBox.Text
        If text.EndsWith("π") OrElse text.EndsWith("e") Then
            txtBox.Text &= "*5"
        Else
            txtBox.Text &= "5"
        End If
    End Sub

    Private Sub six_Click(sender As Object, e As EventArgs) Handles six.Click
        Dim text = txtBox.Text
        If text.EndsWith("π") OrElse text.EndsWith("e") Then
            txtBox.Text &= "*6"
        Else
            txtBox.Text &= "6"
        End If
    End Sub

    Private Sub seven_Click(sender As Object, e As EventArgs) Handles seven.Click
        Dim text = txtBox.Text
        If text.EndsWith("π") OrElse text.EndsWith("e") Then
            txtBox.Text &= "*7"
        Else
            txtBox.Text &= "7"
        End If
    End Sub

    Private Sub eight_Click(sender As Object, e As EventArgs) Handles eight.Click
        Dim text = txtBox.Text
        If text.EndsWith("π") OrElse text.EndsWith("e") Then
            txtBox.Text &= "*8"
        Else
            txtBox.Text &= "8"
        End If
    End Sub

    Private Sub nine_Click(sender As Object, e As EventArgs) Handles nine.Click
        Dim text = txtBox.Text
        If text.EndsWith("π") OrElse text.EndsWith("e") Then
            txtBox.Text &= "*9"
        Else
            txtBox.Text &= "9"
        End If
    End Sub

    Private Sub zero_Click(sender As Object, e As EventArgs) Handles zero.Click
        Dim text = txtBox.Text
        If text.EndsWith("π") OrElse text.EndsWith("e") Then
            txtBox.Text &= "*0"
        Else
            txtBox.Text &= "0"
        End If
    End Sub

    Private Sub openBracet_Click(sender As Object, e As EventArgs) Handles openBracet.Click
        Dim text As String = txtBox.Text
        If (text.Length = 0 OrElse text.EndsWith("+") OrElse text.EndsWith("-") OrElse text.EndsWith("*") OrElse text.EndsWith("/") OrElse text.EndsWith("d") OrElse text.EndsWith("g") OrElse text.EndsWith("%") OrElse text.EndsWith("(")) Then
            txtBox.Text &= "("
        ElseIf (text.EndsWith("0") OrElse text.EndsWith("1") OrElse text.EndsWith("2") OrElse text.EndsWith("3") OrElse text.EndsWith("4") OrElse text.EndsWith("5") OrElse text.EndsWith("6") OrElse text.EndsWith("7") OrElse text.EndsWith("8") OrElse text.EndsWith("9")) Then
            txtBox.Text &= "*("
        End If
    End Sub

    Public Function IsValid(s As String, ByVal st As Stack(Of Char)) As Boolean
        For i As Integer = 0 To s.Length - 1
            If s.Chars(i) = "("c Then
                st.Push(s(i))
            ElseIf s.Chars(i) = ")"c Then
                If st.Count = 0 Then
                    Return False
                Else
                    st.Pop()
                End If
            End If
        Next

        Return st.Count = 0
    End Function

    Private Sub closeBracket_Click(sender As Object, e As EventArgs) Handles closeBracket.Click
        Dim st As New Stack(Of Char)
        IsValid(txtBox.Text, st)

        If (Text.Length = 0 OrElse st.Count >= 1) Then
            txtBox.Text &= ")"
        End If
    End Sub

    Private Sub mul_Click(sender As Object, e As EventArgs) Handles mul.Click
        Dim text As String = txtBox.Text
        If (Not (text.EndsWith("+") OrElse text.EndsWith("-") OrElse text.EndsWith("*") OrElse text.EndsWith("/") OrElse text.EndsWith("d") OrElse text.EndsWith("g") OrElse text.EndsWith("%"))) Then
            txtBox.Text &= "*"
        End If
    End Sub

    Private Sub divide_Click(sender As Object, e As EventArgs) Handles divide.Click
        Dim text As String = txtBox.Text
        If (Not (text.EndsWith("+") OrElse text.EndsWith("-") OrElse text.EndsWith("*") OrElse text.EndsWith("/") OrElse text.EndsWith("d") OrElse text.EndsWith("g") OrElse text.EndsWith("%"))) Then
            txtBox.Text &= "/"
        End If
    End Sub

    Private Sub addOpera_Click(sender As Object, e As EventArgs) Handles addOpera.Click
        Dim text As String = txtBox.Text
        If (Not (text.EndsWith("+") OrElse text.EndsWith("-") OrElse text.EndsWith("*") OrElse text.EndsWith("/") OrElse text.EndsWith("d") OrElse text.EndsWith("g") OrElse text.EndsWith("%"))) Then
            txtBox.Text &= "+"
        End If
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        Dim text As String = txtBox.Text
        If (Not (text.EndsWith("+") OrElse text.EndsWith("-") OrElse text.EndsWith("*") OrElse text.EndsWith("/") OrElse text.EndsWith("d") OrElse text.EndsWith("g") OrElse text.EndsWith("%"))) Then
            txtBox.Text &= "-"
        End If
    End Sub

    Private Sub Calc(ByVal st As Stack(Of Double), ByVal num As Double, ByVal sign As Char)
        If sign = "+" Then
            st.Push(num)
        ElseIf sign = "-" Then
            st.Push(-num)
        ElseIf sign = "*" Then
            st.Push(st.Pop() * num)
        ElseIf sign = "/" Then
            st.Push(st.Pop() / num)
        ElseIf sign = "^" Then
            st.Push(Math.Pow(st.Pop(), 2))
        ElseIf sign = "d" Then
            st.Push(st.Pop() Mod num)
        End If
    End Sub

    Private Sub findResult_Click(sender As Object, e As EventArgs) Handles findResult.Click
        Dim s As String
        s = txtBox.Text

        If (s.EndsWith("g") OrElse s.EndsWith("√") OrElse s.EndsWith("^")) Then
            Exit Sub
        End If

        Dim parenthesisStack As New Stack(Of Char)
        IsValid(s, parenthesisStack)

        While Not parenthesisStack.Count = 0
            s = s & ")"
            parenthesisStack.Pop()
        End While

        Label1.Text = s

        If (s.Contains("∞")) Then
            txtBox.Text = "∞"
            Exit Sub
        End If

        s = Replace(s, "e", "2.718")
        s = Replace(s, "π", "3.141")
        s = Replace(s, "%", "/100")


        Dim st As New Stack(Of Double)
        Dim stPair As New Stack(Of Pair)

        Dim sign As String = ""

        Dim result As Double = 0

        While s.Contains("^") OrElse s.Contains("√") OrElse s.Contains("log")
            If s.Contains("^") Then
                Dim i As Integer = s.LastIndexOf("^")
                Dim start As Integer = i - 1
                Dim endi As Integer = i + 1
                While start >= 0 AndAlso (Char.IsDigit(s(start)) OrElse s(start) = ".")
                    start -= 1
                End While
                While endi < s.Length AndAlso (Char.IsDigit(s(endi)) OrElse s(endi) = ".")
                    endi += 1
                End While
                Dim num As Double = CDbl(s.Substring(start + 1, i - start - 1))
                Dim power As Double = CDbl(s.Substring(i + 1, endi - i - 1))
                result = Math.Round(Math.Pow(num, power), 3)
                s = s.Remove(start + 1, endi - start - 1)
                s = s.Insert(start + 1, result.ToString())
            ElseIf s.Contains("√") Then
                Dim i As Integer = s.LastIndexOf("√")
                Dim start As Integer = i + 1
                Dim endi As Integer = start
                While endi < s.Length AndAlso (Char.IsDigit(s(endi)) OrElse s(endi) = ".")
                    endi += 1
                End While
                Dim num As Double = CDbl(s.Substring(start, endi - start))
                result = Math.Round(Math.Sqrt(num), 3)
                s = s.Remove(i, endi - i)
                s = s.Insert(i, result.ToString())
            ElseIf s.Contains("log") Then
                Dim i As Integer = s.LastIndexOf("log")
                Dim start As Integer = i + 3
                Dim endi As Integer = start
                While endi < s.Length AndAlso (Char.IsDigit(s(endi)) OrElse s(endi) = ".")
                    endi += 1
                End While
                Dim num As Double = CDbl(s.Substring(start, endi - start))
                result = Math.Round(Math.Log10(num), 3)
                s = s.Remove(i, endi - i)
                s = s.Insert(i, result.ToString())
            End If
        End While

        sign = "+"

        For j As Integer = 0 To s.Length - 1
            If Char.IsDigit(s(j)) Then
                Dim num As Double = 0
                While j < s.Length AndAlso Char.IsDigit(s(j))
                    num = num * 10 + (Asc(s(j)) - Asc("0"))
                    j += 1
                End While

                If (j < s.Length AndAlso s(j) = ".") Then
                    j += 1
                    Dim counter As Integer = 10
                    While j < s.Length AndAlso Char.IsDigit(s(j))
                        num = num + (Asc(s(j)) - Asc("0")) / counter
                        counter *= 10
                        j += 1
                    End While
                End If

                j -= 1
                Calc(st, num, sign)
            ElseIf s(j) = "("c Then
                stPair.Push(New Pair(st, sign))
                st = New Stack(Of Double)
                sign = "+"c
            ElseIf s(j) = ")"c Then
                Dim sum As Double = 0
                While Not st.Count = 0
                    sum += st.Pop()
                End While

                Dim pair As Pair = stPair.Pop()
                st = pair.st
                sign = pair.sign

                Calc(st, sum, sign)
            Else
                sign = s(j)
            End If
        Next

        Dim result2 As Double = 0
        While Not st.Count = 0
            result2 += st.Pop()
        End While

        txtBox.Text = result2
    End Sub

    Private Sub root_Click(sender As Object, e As EventArgs) Handles root.Click
        Dim text As String = txtBox.Text
        If (text.Length = 0 OrElse text.EndsWith("+") OrElse text.EndsWith("-") OrElse text.EndsWith("*") OrElse text.EndsWith("/") OrElse text.EndsWith("(") OrElse text.EndsWith("√")) Then
            txtBox.Text &= "√"
        ElseIf (text.EndsWith("0") OrElse text.EndsWith("1") OrElse text.EndsWith("2") OrElse text.EndsWith("3") OrElse text.EndsWith("4") OrElse text.EndsWith("5") OrElse text.EndsWith("6") OrElse text.EndsWith("7") OrElse text.EndsWith("8") OrElse text.EndsWith("9")) Then
            txtBox.Text &= "*√"
        End If
    End Sub

    Private Sub percentage_Click(sender As Object, e As EventArgs) Handles percentage.Click
        Dim text As String = txtBox.Text
        If (text.EndsWith("0") OrElse text.EndsWith("1") OrElse text.EndsWith("2") OrElse text.EndsWith("3") OrElse text.EndsWith("4") OrElse text.EndsWith("5") OrElse text.EndsWith("6") OrElse text.EndsWith("7") OrElse text.EndsWith("8") OrElse text.EndsWith("9")) Then
            txtBox.Text &= "%*"
        End If
    End Sub

    Private Sub square_Click(sender As Object, e As EventArgs) Handles square.Click
        If (txtBox.Text.Length = 0) Then
            Exit Sub
        End If

        Dim Text As String = txtBox.Text
        If (Text.EndsWith("0") OrElse Text.EndsWith("1") OrElse Text.EndsWith("2") OrElse Text.EndsWith("3") OrElse Text.EndsWith("4") OrElse Text.EndsWith("5") OrElse Text.EndsWith("6") OrElse Text.EndsWith("7") OrElse Text.EndsWith("8") OrElse Text.EndsWith("9")) Then
            txtBox.Text &= "^2"
        End If
    End Sub

    Private Sub log_Click(sender As Object, e As EventArgs) Handles log.Click
        Dim text As String = txtBox.Text
        If (text.Length = 0 OrElse text.EndsWith("+") OrElse text.EndsWith("-") OrElse text.EndsWith("*") OrElse text.EndsWith("(") OrElse text.EndsWith("g")) Then
            txtBox.Text &= "log"
        ElseIf (text.EndsWith("0") OrElse text.EndsWith("1") OrElse text.EndsWith("2") OrElse text.EndsWith("3") OrElse text.EndsWith("4") OrElse text.EndsWith("5") OrElse text.EndsWith("6") OrElse text.EndsWith("7") OrElse text.EndsWith("8") OrElse text.EndsWith("9")) Then
            txtBox.Text &= "*log"
        End If
    End Sub

    Private Sub remainder_Click(sender As Object, e As EventArgs) Handles remainder.Click
        Dim Text As String = txtBox.Text
        If (Text.EndsWith("0") OrElse Text.EndsWith("1") OrElse Text.EndsWith("2") OrElse Text.EndsWith("3") OrElse Text.EndsWith("4") OrElse Text.EndsWith("5") OrElse Text.EndsWith("6") OrElse Text.EndsWith("7") OrElse Text.EndsWith("8") OrElse Text.EndsWith("9")) Then
            txtBox.Text &= "mod"
        End If
    End Sub

    Private Sub pi_Click(sender As Object, e As EventArgs) Handles pi.Click
        Dim text As String = txtBox.Text
        If (text.Length = 0 OrElse text.EndsWith("+") OrElse text.EndsWith("-") OrElse text.EndsWith("*") OrElse text.EndsWith("/") OrElse text.EndsWith("d") OrElse text.EndsWith("g") OrElse text.EndsWith("%") OrElse text.EndsWith("(") OrElse text.EndsWith("√")) Then
            txtBox.Text &= "π*"
        ElseIf (text.EndsWith("0") OrElse text.EndsWith("1") OrElse text.EndsWith("2") OrElse text.EndsWith("3") OrElse text.EndsWith("4") OrElse text.EndsWith("5") OrElse text.EndsWith("6") OrElse text.EndsWith("7") OrElse text.EndsWith("8") OrElse text.EndsWith("9")) Then
            txtBox.Text &= "*π"
        End If
    End Sub

    Private Sub expo_Click(sender As Object, e As EventArgs) Handles expo.Click
        Dim text As String = txtBox.Text
        If (text.Length = 0 OrElse text.EndsWith("+") OrElse text.EndsWith("-") OrElse text.EndsWith("*") OrElse text.EndsWith("/") OrElse text.EndsWith("d") OrElse text.EndsWith("g") OrElse text.EndsWith("%") OrElse text.EndsWith("(") OrElse text.EndsWith("√")) Then
            txtBox.Text &= "e*"
        ElseIf (text.EndsWith("0") OrElse text.EndsWith("1") OrElse text.EndsWith("2") OrElse text.EndsWith("3") OrElse text.EndsWith("4") OrElse text.EndsWith("5") OrElse text.EndsWith("6") OrElse text.EndsWith("7") OrElse text.EndsWith("8") OrElse text.EndsWith("9")) Then
            txtBox.Text &= "*e"
        End If
    End Sub

    Private Sub point_Click(sender As Object, e As EventArgs) Handles point.Click
        Dim Text As String = txtBox.Text
        If (Text.EndsWith("0") OrElse Text.EndsWith("1") OrElse Text.EndsWith("2") OrElse Text.EndsWith("3") OrElse Text.EndsWith("4") OrElse Text.EndsWith("5") OrElse Text.EndsWith("6") OrElse Text.EndsWith("7") OrElse Text.EndsWith("8") OrElse Text.EndsWith("9")) Then
            txtBox.Text &= "."
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        If txtBox.Text.EndsWith("%*") Then
            txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 2)
            Exit Sub
        End If

        If txtBox.Text.Length <> 0 Then
            txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1)
        End If
    End Sub
End Class

Public Class Form1
    'Global Variables'



    Public operation As String
    Private Sub DrawCenteredText(pbox As PictureBox, drawText As String, fontName As String)
        ' Default settings for font size, style, and brush color
        Dim fontSize As Single = 16
        Dim fontStyle As FontStyle = FontStyle.Bold
        Dim brushColor As Color = Color.Black

        ' Handle the Paint event of the PictureBox dynamically
        AddHandler pbox.Paint, Sub(sender As Object, e As PaintEventArgs)
                                   ' Create the Font object based on the provided font name with default size and style
                                   Using drawFont As New Font(fontName, fontSize, fontStyle)
                                       ' Measure the size of the text
                                       Dim textSize As SizeF = e.Graphics.MeasureString(drawText, drawFont)

                                       ' Calculate the position to center the text
                                       Dim x As Single = (pbox.Width - textSize.Width) / 2
                                       Dim y As Single = (pbox.Height - textSize.Height) / 2

                                       ' Create the brush with the default color
                                       Using drawBrush As New SolidBrush(brushColor)
                                           ' Draw the text at the calculated position
                                           e.Graphics.DrawString(drawText, drawFont, drawBrush, x, y)
                                       End Using
                                   End Using
                               End Sub

        ' Trigger the PictureBox to repaint and apply the text drawing
        pbox.Invalidate()
    End Sub

    Private Sub AppendNumber(value As Integer)
        ' Check if the value is a number between 0 and 9
        If value >= 0 AndAlso value <= 9 Then
            ' Append the value to the NumBox TextBox
            NumBox.Text += value.ToString()

        End If

    End Sub

    Private Sub AppendOperation(value As String)

        NumBox.Text += value
    End Sub
    Private Function EvaluateExpression(expression As String) As Double
        ' Handle parentheses first
        While expression.Contains("(")
            ' Find the innermost parentheses
            Dim openIndex As Integer = expression.LastIndexOf("(")
            Dim closeIndex As Integer = expression.IndexOf(")", openIndex)
            Dim subExpression As String = expression.Substring(openIndex + 1, closeIndex - openIndex - 1)
            ' Evaluate the sub-expression
            Dim result As Double = EvaluateSimpleExpression(subExpression)
            ' Replace the parentheses with the result
            expression = expression.Substring(0, openIndex) & result.ToString() & expression.Substring(closeIndex + 1)
        End While

        ' Evaluate the remaining expression
        Return EvaluateSimpleExpression(expression)
    End Function

    Private Function EvaluateSimpleExpression(expression As String) As Double
        Dim operators As Char() = {"+", "-", "*", "/"}
        Dim operatorPrecedence As New Dictionary(Of Char, Integer) From {
        {"+", 1},
        {"-", 1},
        {"*", 2},
        {"/", 2}
    }
        Dim values As New Stack(Of Double)()
        Dim ops As New Stack(Of Char)()

        Dim i As Integer = 0
        While i < expression.Length
            Dim c As Char = expression(i)
            If Char.IsWhiteSpace(c) Then
                i += 1
                Continue While
            End If

            If Char.IsDigit(c) Then
                Dim sb As New System.Text.StringBuilder()
                While i < expression.Length AndAlso (Char.IsDigit(expression(i)) OrElse expression(i) = ".")
                    sb.Append(expression(i))
                    i += 1
                End While
                values.Push(Double.Parse(sb.ToString()))
            ElseIf operators.Contains(c) Then
                While ops.Count > 0 AndAlso operatorPrecedence(ops.Peek()) >= operatorPrecedence(c)
                    values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()))
                End While
                ops.Push(c)
                i += 1
            End If
        End While

        While ops.Count > 0
            values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()))
        End While

        Return values.Pop()
    End Function

    Private Function ApplyOp(op As Char, b As Double, a As Double) As Double
        Select Case op
            Case "+" : Return a + b
            Case "-" : Return a - b
            Case "*" : Return a * b
            Case "/" : Return a / b
            Case Else : Throw New ArgumentException("Invalid operator")
        End Select
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DrawCenteredText(num0, "0", "Arial")
        DrawCenteredText(num1, "1", "Arial")
        DrawCenteredText(num2, "2", "Arial")
        DrawCenteredText(num3, "3", "Arial")
        DrawCenteredText(num4, "4", "Arial")
        DrawCenteredText(num5, "5", "Arial")
        DrawCenteredText(num6, "6", "Arial")
        DrawCenteredText(num7, "7", "Arial")
        DrawCenteredText(num8, "8", "Arial")
        DrawCenteredText(num9, "9", "Arial")
        DrawCenteredText(num00, "00", "Arial")
        DrawCenteredText(EqualBtn, "=", "Arial")
        DrawCenteredText(PlusBtn, "+", "Arial")
        DrawCenteredText(MinusBtn, "-", "Arial")
        DrawCenteredText(MulBtn, "*", "Arial")
        DrawCenteredText(DivBtn, "/", "Arial")
        DrawCenteredText(percentbtn, "%", "Arial")
        DrawCenteredText(clearbtn, "C", "Arial")
        DrawCenteredText(Allclear, "AC", "Arial")
        DrawCenteredText(dotbtn, ".", "Arial")
        DrawCenteredText(exclamation, "!", "Arial")
        DrawCenteredText(rootof, "√", "Arial")
        DrawCenteredText(modoperator, "^", "Arial")
        DrawCenteredText(pinumber, "π", "Arial")
        DrawCenteredText(exponent, "e", "Arial")
        DrawCenteredText(sin, "sin", "Arial")
        DrawCenteredText(cos, "cos", "Arial")
        DrawCenteredText(tan, "tan", "Arial")
        DrawCenteredText(rad, "rad", "Arial")
        DrawCenteredText(deg, "deg", "Arial")
        DrawCenteredText(log, "log", "Arial")
        DrawCenteredText(ln, "ln", "Arial")
        DrawCenteredText(openBacket, "(", "Arial")
        DrawCenteredText(closedBracket, ")", "Arial")
        DrawCenteredText(inverse, "inv", "Arial")



        num0.Tag = 0
        num1.Tag = 1
        num2.Tag = 2
        num3.Tag = 3
        num4.Tag = 4
        num5.Tag = 5
        num6.Tag = 6
        num7.Tag = 7
        num8.Tag = 8
        num9.Tag = 9
    End Sub


    Private Sub DoNothing()
        ' Do nothing in this method.
    End Sub
    Private Sub NumberButton_Click(sender As Object, e As EventArgs) Handles num0.Click, num1.Click, num2.Click, num3.Click, num4.Click, num5.Click, num6.Click, num7.Click, num8.Click, num9.Click, num00.Click
        ' Get the number from the clicked button
        Dim clickedPictureBox As PictureBox = CType(sender, PictureBox)

        Dim number As Integer = CInt(clickedPictureBox.Tag)

        AppendNumber(number)
        ' Append the number to the NumBox TextBox
        'NumBox.Text += number.ToString()'
    End Sub

    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles PlusBtn.Click, MinusBtn.Click, MulBtn.Click, DivBtn.Click
        ' Get the number from the clicked button
        Dim clickedPictureBox As PictureBox = CType(sender, PictureBox)

        Select Case clickedPictureBox.Tag
            Case "+"
                AppendOperation("+")
            Case "-"
                AppendOperation("-")

            Case "*"
                AppendOperation("*")
            Case "/"
                AppendOperation("/")
        End Select
    End Sub

    Private Sub EqualBtn_Click(sender As Object, e As EventArgs) Handles EqualBtn.Click
        Dim d As Double = EvaluateExpression(NumBox.Text)
        NumBox.Text = d.ToString()
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click

    End Sub


End Class

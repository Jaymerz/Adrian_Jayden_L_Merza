Public Class Form1
    Private Sub evaluate_btn_Click(sender As Object, e As EventArgs) Handles evaluate_btn.Click
        Dim Age As Integer = Convert.ToDecimal(Age_textbox.Text)
        If Age >= 100 Then
            MsgBox("Dinosaur Age")
        ElseIf Age >= 90 Then
            MsgBox("Century Age")
        ElseIf Age >= 80 Then
            MsgBox("Grandfather Age")
        ElseIf Age >= 60 Then
            MsgBox("Senior Citizen Age")
        ElseIf Age >= 45 Then
            MsgBox("Middle Age")
        ElseIf Age >= 30 Then
            MsgBox("Young")
        Else
            MsgBox("unkown Age")


        End If

    End Sub
End Class
'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'    '    Dim VarName As String = "Hello"
''    Dim Age As Integer = 20
''    Const MaxSize As Integer = 999


''    Dim Stringvar As String
''    Dim IntVar As Integer
''    Dim BooleanVar As Boolean
''    Dim DecimalVar As Decimal

''    Stringvar = "this is string"
''    IntVar = 345353
''    BooleanVar = False
''    DecimalVar = 34.565656

''    'WRITE COMMENTS USING SINGLE '

''    'ARITHMETIC OPERATOR
''    Age = Age + 34
''    Age = Age - 10
''    Age = Age / 34
''    Age = Age * 20

''    'ASSIGNMENT OPERATOR
''    Dim FirstName As String
''    FirstName = "inserting value using  Equal (=) assignment operator"

''    'COMPARISON OPERATORS
''    ' =
''    If (1 = 1) Then
''        MsgBox("TRUE")
''    End If
''    ' <> not equal
''    If (45 <> 78) Then
''        MsgBox("TRUE")
''    End If
''    ' greaterthan
''    If (100 > 85) Then
''        MsgBox("TRUE")
''    End If
''    ' lessthan
''    If (35 < 65) Then
''        MsgBox("TRUE")
''    End If
''    ' GreaterThan Equal
''    If (100 >= 101) Then
''        MsgBox("TRUE")
''    End If
''    ' LessThan Equal
''    If (100 <= 101) Then
''        MsgBox("TRUE")
''    End If

''    Age = 11
''    If (Age = 10) Then
''        'TRUE
''        MessageBox.Show("ITR TRUE AGE IS EQUAL TO 10 & GREATERTHAN 9")
''        If Age > 9 Then

''        End If
''    Else
''        If Age > 12 Then
''            'FALSE
''            MessageBox.Show("ITS FALSE, AGE IS NOT GREATER THAN 12")

''        End If

''    End If

''    Dim grade As Char
''    grade = "B"
''    Select Case grade
''        Case "A"
''            MessageBox.Show("Excellent!")
''        Case "B", "C"
''            MessageBox.Show("Well Done")
''        Case "D"
''            MessageBox.Show("You Passed")
''        Case "F"
''            MessageBox.Show("Better try again")
''        Case Else
''            MessageBox.Show("Invalid grade")
''    End Select



'End Sub

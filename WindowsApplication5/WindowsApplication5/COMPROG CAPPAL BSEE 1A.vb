Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim Varname As String = "HELLO"
        'Dim Age As Integer = 20
        'Const MaxSize As Integer = 999

        'Dim StringVar As String
        'Dim IntVar As Integer
        'Dim BooleanVar As Boolean
        'Dim DecimalVar As Decimal

        'StringVar = "this is string"
        'IntVar = 345353
        'BooleanVar = False
        'DecimalVar = 34.565656



        ''WRITE COMMENTS USING SINGLE '


        ''ARITHMETIC OPERATORS
        'Age = Age + 34
        'Age = Age - 10
        'Age = Age / 34
        'Age = Age * 20


        ''ASSIGNMENT OPERATORS
        'Dim Firstname As String
        'Firstname = "inserting value using  equal (=)  assignment operator"

        ''COMPARISON OPERATORS
        '' = 
        'If (1 = 1) Then
        '    MsgBox("TRUE")
        'End If
        '' <> not equal
        'If (45 <> 78) Then
        '    MsgBox("TRUE")
        'End If

        '' greaterthan
        'If (100 > 85) Then
        '    MsgBox("TRUE")
        'End If

        '' lessthan
        'If (35 < 65) Then
        '    MsgBox("TRUE")
        'End If

        ''greaterthan equal
        'If (100 >= 99) Then
        '    MsgBox("TRUE")
        'End If

        ''lessthan equal 
        'If (100 <= 101) Then
        '    MsgBox("TRUE")

        'End If

        ''logical operator
        ''AND 
        'Dim price As Integer = 25
        '    If price > 20 And price > 0 Then
        '        MsgBox("true")

        '    End If



        '    'OR
        '    If price < 10 Or price > 0 Then
        '        MsgBox(price < 10 Or price > 0)


        '    If Age = 10 Then
        '        'TRUE
        '        MessageBox.Show("ITS TRUE AGE IS EQUAL TO 10")
        '    Else
        '        'FALSE
        '        MessageBox.Show("ITS FALSE, AGE IS NOT EQUAL TO 10")
        '        End If


        '    If Age = 10 Then
        '        If Age > 9 Then
        '            'TRUE
        '            MessageBox.Show("ITS TRUE AGE IS EQUAL TO 10 & GREATERTHAN 9")

        '            If Age > 0 Then
        '                'TRUE
        '                MessageBox.Show("ITS TRUE AGE IS GREATER THAN 0")
        '            End If
        '        End If
        '    Else
        '        If Age > 11 Then
        '                'FALSE
        '                MessageBox.Show("ITS FALSE, AGE IS NOT GREATER THAN TO 11")


        '            Dim grade As Char
        '            grade = "B"
        '            Select Case grade
        '                Case "A"
        '                    MessageBox.Show("Excellent")
        '                Case "B", "C"
        '                    MessageBox.Show("Well done")
        '                Case "D"
        '                    MessageBox.Show("You passed")
        '                Case "F"
        '                    MessageBox.Show("Better try again")
        '                Case Else
        '                    MessageBox.Show("invalid grade")
        '            End Select












    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub evaluate_btn_Click(sender As Object, e As EventArgs) Handles evaluate_btn.Click

        Dim age As Integer = Convert.ToDecimal(age_txtbox.Text)

        If age >= 100 Then
            MsgBox("DINOSAUR AGE")
        ElseIf age >= 90 Then
            MsgBox("Century Age")
        ElseIf age >= 80 Then
            MsgBox("GrandFather Age")
        ElseIf age >= 60 Then
            MsgBox("Senior Citizen Age")
        ElseIf age >= 45 Then
            MsgBox("Middle Age")
        ElseIf age >= 30 Then
            MsgBox("Young")
        Else
            MsgBox("Unknown Age")



        End If

    End Sub
End Class

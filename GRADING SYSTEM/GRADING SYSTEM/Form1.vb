Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub math_txtbox_TextChanged(sender As Object, e As EventArgs) Handles math_txtbox.TextChanged
        Dim grade As Char
        grade = "100 - 90"
        Select Case grade
            Case "100 - 90"
                MessageBox.Show("A+")
            Case "89 - 80"
                MessageBox.Show("B+")
            Case "79 - 75"
                MessageBox.Show("C+")
            Case "74 > 0 "
                MessageBox.Show("F")




        End Select

    End Sub

    Private Sub science_txtbox_TextChanged(sender As Object, e As EventArgs) Handles science_txtbox.TextChanged

    End Sub

    Private Sub english_txt_box_TextChanged(sender As Object, e As EventArgs) Handles english_txt_box.TextChanged

    End Sub

    Private Sub evaluate_btn_Click(sender As Object, e As EventArgs) Handles evaluate_btn.Click
        Dim math As Integer
        Dim science As Integer
        Dim english As Integer
        Dim grade As Double

        math = Val(math_txtbox.Text)
        science = Val(science_txtbox.Text)
        english = Val(english_txtbox.Text)

        grade = (math + science + english)
        grade = grade / 3

        If grade >= 90 Then
            MsgBox("A+")
        ElseIf grade >= 80 Then
            MsgBox("B+")
        ElseIf grade >= 75 Then
            MsgBox("C+")
        Else
            MsgBox("failed")

        End If
    End Sub
End Class

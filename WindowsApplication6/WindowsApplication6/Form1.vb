Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim grade As String
        grade = "100"
        Select Case grade
            Case "100 - 90"
                MessageBox.Show("A+")

            Case "89 - 80"
                MessageBox.Show("B+")

            Case "79 - 75"
                MessageBox.Show("C+")

            Case "74 > 0"
                MessageBox.Show("F")



                'GRADE EQUIVALENT
                '100 - 90 = (A+)
                '89 - 80 = (B+)
                '79 - 75 = (C+)
                '74 = (F)
        End Select

    End Sub

    Private Sub math_txt_box_TextChanged(sender As Object, e As EventArgs) Handles math_txtbox.TextChanged
        Dim grade As String
        grade = "100"
        Select Case grade
            Case "100 - 90"
                MessageBox.Show("A+")

            Case "89 - 80"
                MessageBox.Show("B+")

            Case "79 - 75"
                MessageBox.Show("C+")

            Case "74 > 0"
                MessageBox.Show("F")



                'GRADE EQUIVALENT
                '100 - 90 = (A+)
                '89 - 80 = (B+)
                '79 - 75 = (C+)
                '74 = (F)
        End Select
        If grade = 100 - 90 Then
            MessageBox.Show("A+")


        End If

        If grade = 89 - 80 Then
            MessageBox.Show("B+")


        End If



        If grade = 79 - 75 Then
            MessageBox.Show("C+")

            If grade = 74 > 0 Then
                MessageBox.Show("F")

            End If




        End If

    End Sub

    Private Sub science_txtbox_TextChanged(sender As Object, e As EventArgs) Handles science_txtbox.TextChanged

    End Sub

    Private Sub english_txt_box_TextChanged(sender As Object, e As EventArgs) Handles english_txt_box.TextChanged

    End Sub

    Private Sub evaluate_btn_Click(sender As Object, e As EventArgs) Handles evaluate_btn.Click

    End Sub
End Class

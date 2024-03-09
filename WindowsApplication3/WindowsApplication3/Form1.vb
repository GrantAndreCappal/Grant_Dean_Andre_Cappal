Public Class Calculator
    Dim Firstval As Double
    Dim Secondval As Double
    Dim [operators] As String
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles three_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles equal_btn.Click
        Dim Result As Double
        Secondval = Val(total_txtbox.Text)
        Select Case [operators]
            Case = "+"
                Result = Firstval + Secondval
                total_txtbox.Text = Result.ToString()
            Case = "-"
                Result = Firstval - Secondval
                total_txtbox.Text = Result.ToString()
            Case = "*"
                Result = Firstval * Secondval
                total_txtbox.Text = Result.ToString
            Case = "/"
                Result = Firstval / Secondval
                total_txtbox.Text = Result.ToString
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub one_btn_Click(sender As Object, e As EventArgs) Handles one_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub two_btn_Click(sender As Object, e As EventArgs) Handles two_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub four_btn_Click(sender As Object, e As EventArgs) Handles four_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub five_btn_Click(sender As Object, e As EventArgs) Handles five_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text

    End Sub

    Private Sub six_btn_Click(sender As Object, e As EventArgs) Handles six_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub seven_btn_Click(sender As Object, e As EventArgs) Handles seven_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub eight_btn_Click(sender As Object, e As EventArgs) Handles eight_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub nine_btn_Click(sender As Object, e As EventArgs) Handles nine_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub zero_btn_Click(sender As Object, e As EventArgs) Handles zero_btn.Click
        total_txtbox.Text = total_txtbox.Text & sender.text
    End Sub

    Private Sub multiplication_btn_Click(sender As Object, e As EventArgs) Handles multiplication_btn.Click
        Firstval = Val(total_txtbox.Text)
        total_txtbox.Focus()
        [operators] = "*"
        total_txtbox.Text = ""
    End Sub

    Private Sub subtraction_btn_Click(sender As Object, e As EventArgs) Handles subtraction_btn.Click
        Firstval = Val(total_txtbox.Text)
        total_txtbox.Focus()
        [operators] = "-"
        total_txtbox.Text = ""
    End Sub

    Private Sub addition_btn_Click(sender As Object, e As EventArgs) Handles addition_btn.Click
        Firstval = Val(total_txtbox.Text)
        total_txtbox.Focus()
        [operators] = "+"
        total_txtbox.Text = ""
    End Sub

    Private Sub division_btn_Click(sender As Object, e As EventArgs) Handles division_btn.Click
        Firstval = Val(total_txtbox.Text)
        total_txtbox.Focus()
        [operators] = "/"
        total_txtbox.Text = ""
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        total_txtbox.Text = ""
    End Sub
End Class

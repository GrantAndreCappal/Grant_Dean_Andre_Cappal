Public Class form1
    Dim Firstval As Double
    Dim Secondval As Double
    Dim [operator] As String


    Private Sub one_button_Click(sender As Object, e As EventArgs) Handles one_btn.Click
        total_textbox.Text = total_textbox.Text & sender.text
    End Sub

    Private Sub two_button_Click(sender As Object, e As EventArgs) Handles two_btn.Click
        total_textbox.Text = total_textbox.Text & sender.text
    End Sub

    Private Sub three_button_Click(sender As Object, e As EventArgs) Handles three_btn.Click
        total_textbox.Text = total_textbox.Text & sender.text
    End Sub

    Private Sub four_button_Click(sender As Object, e As EventArgs) Handles four_btn.Click
        total_textbox.Text = total_textbox.Text & sender.text
    End Sub

    Private Sub five_button_Click(sender As Object, e As EventArgs) Handles five_btn.Click
        total_textbox.Text = total_textbox.Text & sender.text
    End Sub

    Private Sub six_button_Click(sender As Object, e As EventArgs) Handles six_btn.Click
        total_textbox.Text = total_textbox.Text & sender.text
    End Sub

    Private Sub seven_button_Click(sender As Object, e As EventArgs) Handles seven_btn.Click
        total_textbox.Text = total_textbox.Text & sender.text
    End Sub

    Private Sub eight_button_Click(sender As Object, e As EventArgs) Handles eight_btn.Click
        total_textbox.Text = total_textbox.Text & sender.text
    End Sub

    Private Sub nine_button_Click(sender As Object, e As EventArgs) Handles nine_btn.Click
        total_textbox.Text = total_textbox.Text & sender.text
    End Sub

    Private Sub zero_button_Click(sender As Object, e As EventArgs) Handles zero_btn.Click
        total_textbox.Text = total_textbox.Text & sender.text
    End Sub

    Private Sub plus_button_Click(sender As Object, e As EventArgs) Handles plus_btn.Click
        Dim firstval = Val(total_textbox.Text)
        total_textbox.Focus()
        [operator] = "+"
        total_textbox.Text = total_textbox.Text & sender.text
    End Sub

    Private Sub minus_button_Click(sender As Object, e As EventArgs) Handles minus_btn.Click
        Dim firstval = Val(total_textbox.Text)
        total_textbox.Focus()
        [operator] = "-"
        total_textbox.Text = total_textbox.Text & sender.text
    End Sub

    Private Sub times_button_Click(sender As Object, e As EventArgs) Handles times_btn.Click
        Dim firstval = Val(total_textbox.Text)
        total_textbox.Focus()
        [operator] = "*"
        total_textbox.Text = total_textbox.Text & sender.text
    End Sub

    Private Sub divide_button_Click(sender As Object, e As EventArgs) Handles divide_btn.Click
        Dim firstval = Val(total_textbox.Text)
        total_textbox.Focus()
        [operator] = "/"
        total_textbox.Text = total_textbox.Text & sender.text
    End Sub

    Private Sub equal_button_Click(sender As Object, e As EventArgs) Handles equal_btn.Click
        Dim firstval = Val(total_textbox.Text)
        total_textbox.Focus()
        [operator] = "="
        total_textbox.Text = total_textbox.Text & sender.text

    End Sub

End Class
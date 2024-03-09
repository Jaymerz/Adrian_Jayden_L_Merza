Public Class Form1
    Dim firstval As Double
    Dim Secondval As Double
    Dim [Operator] As String
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles equal_btn.Click
        Dim Result As Double
        Secondval = Val(txt_total.Text)
        Select Case [Operator]
            Case = "+"
                Result = firstval + Secondval
                txt_total.Text = Result.ToString
            Case = "-"
                Result = firstval - Secondval
                txt_total.Text = Result.ToString
            Case = "*"
                Result = firstval * Secondval
                txt_total.Text = Result.ToString
            Case = "/"
                Result = firstval / Secondval
                txt_total.Text = Result.ToString
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles seven_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Nine_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles divide_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Focus()
        [Operator] = "/"
        txt_total.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub eight_btn_Click(sender As Object, e As EventArgs) Handles eight_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub four_btn_Click(sender As Object, e As EventArgs) Handles four_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub five_btn_Click(sender As Object, e As EventArgs) Handles five_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub six_btn_Click(sender As Object, e As EventArgs) Handles six_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub one_btn_Click(sender As Object, e As EventArgs) Handles one_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub two_btn_Click(sender As Object, e As EventArgs) Handles two_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub three_btn_Click(sender As Object, e As EventArgs) Handles three_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Focus()
        [Operator] = "+"
        txt_total.Text = ""
    End Sub

    Private Sub minus_btn_Click(sender As Object, e As EventArgs) Handles minus_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Focus()
        [Operator] = "-"
        txt_total.Text = ""
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        txt_total.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles times_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Focus()
        [Operator] = "*"
        txt_total.Text = ""
    End Sub

    Private Sub zero_btn_Click(sender As Object, e As EventArgs) Handles zero_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub
End Class

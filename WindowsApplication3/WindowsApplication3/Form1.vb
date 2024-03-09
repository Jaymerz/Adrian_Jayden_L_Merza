Public Class Form1

    Dim firstval As Double
    Dim Secondval As Double
    Dim [Operator] As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_one.Click
        txt_box1.Text = txt_box1.Text & sender.text
        txt_box1.Text = firstval.ToString
        If [Operator] >= "+" Then
            txt_box2.Text = txt_box2.Text & sender.text
        End If
    End Sub

    Private Sub btn_two_Click(sender As Object, e As EventArgs) Handles btn_two.Click
        txt_box1.Text = txt_box1.Text & sender.text
    End Sub

    Private Sub btn_three_Click(sender As Object, e As EventArgs) Handles btn_three.Click
        txt_box1.Text = txt_box1.Text & sender.text
    End Sub

    Private Sub btn_four_Click(sender As Object, e As EventArgs) Handles btn_four.Click
        txt_box1.Text = txt_box1.Text & sender.text
    End Sub

    Private Sub btn_five_Click(sender As Object, e As EventArgs) Handles btn_five.Click
        txt_box1.Text = txt_box1.Text & sender.text
    End Sub

    Private Sub btn_six_Click(sender As Object, e As EventArgs) Handles btn_six.Click
        txt_box1.Text = txt_box1.Text & sender.text
    End Sub

    Private Sub btn_seven_Click(sender As Object, e As EventArgs) Handles btn_seven.Click
        txt_box1.Text = txt_box1.Text & sender.text
    End Sub

    Private Sub btn_eight_Click(sender As Object, e As EventArgs) Handles btn_eight.Click
        txt_box1.Text = txt_box1.Text & sender.text
    End Sub

    Private Sub btn_nine_Click(sender As Object, e As EventArgs) Handles btn_nine.Click
        txt_box1.Text = txt_box1.Text & sender.text
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        firstval = Val(txt_box1.Text)
        txt_box2.Focus()
        [Operator] = "+"
    End Sub

    Private Sub btn_total_Click(sender As Object, e As EventArgs) Handles btn_total.Click
        Dim Result As Double
        Secondval = Val(txt_box3.Text)
        Select Case [Operator]
            Case = "+"
                Result = firstval + Secondval
                txt_box3.Text = Result.ToString
        End Select
    End Sub
End Class

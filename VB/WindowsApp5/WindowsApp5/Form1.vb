Public Class Form1
    Dim car As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        car = car + 1
        TextBox1.Text = car
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()

    End Sub

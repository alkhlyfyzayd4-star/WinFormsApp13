Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fullname As String = "زايد ناصر طالب "
        Dim father As String = fullname.Substring(5, 4)
        TextBox4.Text = father
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fullname As String = "زايد ناصر طالب "
        Dim cleanstr As String = fullname.Remove(5, 5)
        TextBox4.Text = cleanstr
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fullname As String = "زايد ناصر طالب "
        Dim newstr As String = fullname.Insert(0, "ناصر ")
        TextBox4.Text = newstr
    End Sub
End Class
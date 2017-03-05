Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        If (username = "" Or password = "") Then
            MessageBox.Show("Please complete all fields.", "Please complete all fields")
        ElseIf (username = "johnsmith" And password = "computer") Then




        Else
            MessageBox.Show("User account can't be found. Please try again, or create a new account.", "User not found!")
        End If



    End Sub
End Class

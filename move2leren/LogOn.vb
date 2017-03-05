Public Class LogOn

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        If (username = "" Or password = "") Then
            MessageBox.Show("Please complete all fields.", "Please complete all fields")
        ElseIf (username = "johnsmith" And password = "computer") Then

            Home.Show()
            Me.Hide()


        Else
            MessageBox.Show("User account can't be found. Please try again, or create a new account.", "User not found!")
        End If



    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class

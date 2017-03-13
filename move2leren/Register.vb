Public Class Register

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub
    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim forename As String = TextBox3.Text
        Dim validation As Boolean = True
        If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "") Then
            MessageBox.Show("Please complete all fields.", "Please complete all fields")

        Else
            If (TextBox1.Text = "johnsmith") Then
                MessageBox.Show("Username Already Taken", "Username Already Taken")
                validation = False
            End If
            If (TextBox4.Text <> TextBox2.Text) Then
                MessageBox.Show("Passwords Don't Match", "Passwords Don't Match")
                validation = False


            End If

        End If

        If validation = True Then
            Threading.Thread.Sleep(1000)
            MessageBox.Show("Account Saved!", "Account Saved!")

        End If

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        LogOn.Show()
    End Sub
End Class
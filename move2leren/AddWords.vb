Public Class AddWords

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MsgBox("Saving this Cache")
        Threading.Thread.Sleep(500)
        MsgBox("Cached Saved! Thanks for contributing to move2leren!")

        Me.Hide()
        Home.Show()




    End Sub

    Private Sub AddWords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        TextBox2.Hide()
        TextBox8.Hide()
        TextBox4.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        TextBox5.Hide()
        TextBox9.Hide()
        TextBox10.Hide()
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        Label4.Show()
        TextBox2.Show()
        TextBox4.Show()
    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        Label5.Show()
        TextBox6.Show()
        TextBox8.Show()
    End Sub

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged
        Label6.Show()
        TextBox7.Show()
        TextBox5.Show()
    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged
        Label7.Show()
        TextBox10.Show()
        TextBox5.Show()
    End Sub
End Class
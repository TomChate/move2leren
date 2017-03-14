Public Class Profile

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Profile_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = "johnsmith"
        TextBox3.Text = "John"
        TextBox2.Text = "Smith"
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Close()
        Home.Show()
    End Sub
End Class
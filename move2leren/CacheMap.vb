Public Class CacheMap
    Dim location As String
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub CacheMap_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("https://www.google.com/maps")
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        WebBrowser1.Navigate("https://www.google.com/maps")
        location = TextBox1.Text
        WebBrowser1.Navigate("https://www.google.com/maps/place/" + location)
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        MsgBox("Food & Drink Cache")
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        MsgBox("Shopping Cache")
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        MsgBox("Travel Cache")
    End Sub
End Class
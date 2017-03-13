Public Class NewCache

    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        TextBox1.Text = "50.105.232"
        TextBox2.Text = "01.23.123"
    End Sub

    Private Sub NewCache_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("https://www.google.com/maps")
        ComboBox1.Items.Add("Food & Drink")
        ComboBox1.Items.Add("Health")
        ComboBox1.Items.Add("Accomdation")
        ComboBox1.Items.Add("Travel")
        ComboBox1.Items.Add("Shopping")
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        AddWords.Show()
    End Sub
End Class
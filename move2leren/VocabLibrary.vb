Public Class VocabLibrary

    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)
        Dim g As Graphics
        Dim sText As String
        Dim iX As Integer
        Dim iY As Integer
        Dim sizeText As SizeF
        Dim ctlTab As TabControl

        ctlTab = CType(sender, TabControl)

        g = e.Graphics

        sText = ctlTab.TabPages(e.Index).Text
        sizeText = g.MeasureString(sText, ctlTab.Font)
        iX = e.Bounds.Left + 6
        iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2
        g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY) 'Code taken from http://arsalantamiz.blogspot.co.uk/2008/07/custom-tab-control-layout.html
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub TabPageShopping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ListBoxVocab_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub VocabLibrary_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Food & Drink")
        ListBox1.Items.Add("Health")
        ListBox1.Items.Add("Accomdation")
        ListBox1.Items.Add("Travel")
        ListBox1.Items.Add("Shopping")
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim selectedItem As String = ListBox1.SelectedItem.ToString
        Threading.Thread.Sleep(750)
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        If selectedItem = "Food & Drink" Then
            ListBox2.Items.Add("ober")
            ListBox3.Items.Add("waiter")

            ListBox2.Items.Add("de groente")
            ListBox3.Items.Add("the vegetables")

            ListBox2.Items.Add("het fruit")
            ListBox3.Items.Add("the fruits")

            ListBox2.Items.Add("het brood")
            ListBox3.Items.Add("the bread")

        ElseIf selectedItem = "Shopping" Then
            ListBox2.Items.Add("cheap")
            ListBox3.Items.Add("goedkoop")
        Else
            MsgBox("You haven't learnt any " + selectedItem + " vocab! You better go out and find some!")
        End If


    End Sub

    Private Sub Panel1_Paint_1(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label2_Click_1(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
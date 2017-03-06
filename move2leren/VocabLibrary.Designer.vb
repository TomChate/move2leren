<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VocabLibrary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageShopping = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ListBoxVocab = New System.Windows.Forms.ListBox()
        Me.TabControl.SuspendLayout()
        Me.TabPageShopping.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(411, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 72)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Vocab Library"
        '
        'TabControl
        '
        Me.TabControl.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl.Controls.Add(Me.TabPageShopping)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.ItemSize = New System.Drawing.Size(30, 120)
        Me.TabControl.Location = New System.Drawing.Point(144, 126)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(926, 564)
        Me.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl.TabIndex = 9
        '
        'TabPageShopping
        '
        Me.TabPageShopping.Controls.Add(Me.ListBoxVocab)
        Me.TabPageShopping.Location = New System.Drawing.Point(124, 4)
        Me.TabPageShopping.Name = "TabPageShopping"
        Me.TabPageShopping.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageShopping.Size = New System.Drawing.Size(798, 556)
        Me.TabPageShopping.TabIndex = 0
        Me.TabPageShopping.Text = "Shopping"
        Me.TabPageShopping.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(124, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(798, 556)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Travel"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(12, 696)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(126, 40)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "Return"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ListBoxVocab
        '
        Me.ListBoxVocab.FormattingEnabled = True
        Me.ListBoxVocab.ItemHeight = 24
        Me.ListBoxVocab.Location = New System.Drawing.Point(112, 80)
        Me.ListBoxVocab.Name = "ListBoxVocab"
        Me.ListBoxVocab.Size = New System.Drawing.Size(501, 76)
        Me.ListBoxVocab.TabIndex = 0
        '
        'VocabLibrary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1167, 748)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VocabLibrary"
        Me.Text = "VocabLibrary"
        Me.TabControl.ResumeLayout(False)
        Me.TabPageShopping.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPageShopping As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ListBoxVocab As System.Windows.Forms.ListBox
End Class

Public Class View_emp
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        InformationBindingSource.MovePrevious()


    End Sub

    Private Sub View_emp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database9DataSet3.information' table. You can move, or remove it, as needed.
        Me.InformationTableAdapter.Fill(Me.Database9DataSet3.information)
        'TODO: This line of code loads data into the 'Database9DataSet1.information' table. You can move, or remove it, as needed.
        Me.InformationTableAdapter.Fill(Me.Database9DataSet3.information)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        InformationBindingSource.MoveNext()


    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        Me.InformationBindingSource.Filter = "EmployeeID LIKE '" & TextBox14.Text & "%'"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox2.Text = FormatCurrency(TextBox2.Text)

        txtReceipt1.Text = ""
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtReceipt1.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("Employee ID: " + vbTab & TextBox1.Text + vbNewLine)
        txtReceipt1.AppendText("Employee Name: " + vbTab & TextBox6.Text + vbNewLine)
        txtReceipt1.AppendText("Address: " + vbTab + vbTab & TextBox5.Text + vbNewLine)
        txtReceipt1.AppendText("Contact: " + vbTab + vbTab & TextBox4.Text + vbNewLine)
        txtReceipt1.AppendText("Email: " + vbTab + vbTab + vbTab & TextBox3.Text + vbNewLine)
        txtReceipt1.AppendText("Blood Type: " + vbTab + vbTab & TextBox1.Text + vbNewLine)
        txtReceipt1.AppendText("Department: " + vbTab + vbTab & TextBox7.Text + vbNewLine)
        txtReceipt1.AppendText("Designation: " + vbTab + vbTab & TextBox8.Text + vbNewLine)
        txtReceipt1.AppendText("Position: " + vbTab + vbTab & TextBox9.Text + vbNewLine)
        txtReceipt1.AppendText("Date of Birth: " + vbTab + vbTab & TextBox12.Text + vbNewLine)
        txtReceipt1.AppendText("Date of Joined: " + vbTab + vbTab & TextBox10.Text + vbNewLine)
        txtReceipt1.AppendText("Salary: " + vbTab + vbTab & TextBox2.Text + vbNewLine)

        txtReceipt1.AppendText("" + vbNewLine)

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(txtReceipt1.Text, Font, Brushes.Black, 140, 140)
        e.Graphics.DrawImage(Me.PictureBox1.Image, 120, 130, PictureBox1.Width - 15, PictureBox1.Height - 25)

    End Sub
End Class
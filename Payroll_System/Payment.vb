'Imports System.Data.OleDb
Public Class Payment
    Dim ans As Integer
    Dim insur As Integer
    Dim tax As Integer
    Dim pf As Integer
    Dim inco As Integer
    Dim net As Integer

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database9DataSet4.information' table. You can move, or remove it, as needed.
        Me.InformationTableAdapter.Fill(Me.Database9DataSet4.information)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ans = (((TextBox8.Text * TextBox7.Text) + (TextBox12.Text)) * (TextBox4.Text))
        TextBox9.Text = ans
        insur = ans * 0.001
        TextBox5.Text = insur
        pf = ans * 0.1
        TextBox3.Text = pf
        inco = ans * 0.004
        TextBox2.Text = inco
        tax = insur + pf + inco
        TextBox10.Text = tax
        net = ans - tax
        TextBox11.Text = net

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Me.InformationBindingSource.Filter = "EmployeeID LIKE '" & TextBox1.Text & "%'"
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
        txtReceipt1.AppendText("Employee ID: " + vbTab + vbTab & TextBox1.Text + vbNewLine)
        txtReceipt1.AppendText("Employee Name: " + vbTab & TextBox6.Text + vbNewLine)
        txtReceipt1.AppendText("Rate Per Hour: " + vbTab + vbTab & TextBox4.Text + vbNewLine)
        txtReceipt1.AppendText("Hour Per Day: " + vbTab + vbTab & TextBox8.Text + vbNewLine)
        txtReceipt1.AppendText("Over Time: " + vbTab + vbTab & TextBox12.Text + vbNewLine)
        txtReceipt1.AppendText("Number of days works: " + vbTab & TextBox7.Text + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("BASIC SALARY: " + vbTab + vbTab & TextBox9.Text + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)

        txtReceipt1.AppendText("TAX DEDUCTION " + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)

        txtReceipt1.AppendText("Insurance: " + vbTab + vbTab & TextBox5.Text + vbNewLine)
        txtReceipt1.AppendText("PF: " + vbTab + vbTab + vbTab & TextBox3.Text + vbNewLine)
        txtReceipt1.AppendText("Income Tax: " + vbTab + vbTab & TextBox2.Text + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("TOTAL DEDUCTION: " + vbTab & TextBox10.Text + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("NET SALARY: " + vbTab + vbTab & TextBox11.Text + vbNewLine)

        txtReceipt1.AppendText("" + vbNewLine)
        'PrintPreviewDialog1.Document = PrintDocument1




        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(txtReceipt1.Text, Font, Brushes.Black, 140, 140)
        e.Graphics.DrawImage(Me.PictureBox1.Image, 120, 130, PictureBox1.Width - 15, PictureBox1.Height - 25)
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Calc.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
Imports System.Data.OleDb
Public Class Register_emp
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        InformationBindingSource2.MovePrevious()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Register_emp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database9DataSet2.information' table. You can move, or remove it, as needed.
        Me.InformationTableAdapter2.Fill(Me.Database9DataSet2.information)
        'TODO: This line of code loads data into the 'Database9DataSet.information' table. You can move, or remove it, as needed.
        'Me.InformationTableAdapter2.Fill(Me.Database9DataSet.information)
        'TODO: This line of code loads data into the 'Database1DataSet1.information' table. You can move, or remove it, as needed.
        'Me.InformationTableAdapter1.Fill(Me.Database1DataSet1.information)
        'TODO: This line of code loads data into the 'Database1DataSet.information' table. You can move, or remove it, as needed.
        'Me.InformationTableAdapter.Fill(Me.Database1DataSet.information)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Len(Trim(TextBox1.Text)) = 0 Then
            MessageBox.Show("Please enter employee ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Focus()
            Exit Sub
        End If

        If Len(Trim(TextBox6.Text)) = 0 Then
            MessageBox.Show("Please enter employee name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox6.Focus()
            Exit Sub
        End If

        If Len(Trim(TextBox5.Text)) = 0 Then
            MessageBox.Show("Please enter employee Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox5.Focus()
            Exit Sub
        End If

        If Len(Trim(TextBox4.Text)) = 0 Then
            MessageBox.Show("Please enter employee Contact Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox4.Focus()
            Exit Sub
        End If

        If Len(Trim(TextBox3.Text)) = 0 Then
            MessageBox.Show("Please enter employee Email", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox3.Focus()
            Exit Sub
        End If

        If Len(Trim(BloodTypeComboBox.Text)) = 0 Then
            MessageBox.Show("Please enter employee Blood Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BloodTypeComboBox.Focus()
            Exit Sub
        End If

        If Len(Trim(ComboBox1.Text)) = 0 Then
            MessageBox.Show("Please enter employee Department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox1.Focus()
            Exit Sub
        End If

        If Len(Trim(ComboBox2.Text)) = 0 Then
            MessageBox.Show("Please enter employee Designation", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox2.Focus()
            Exit Sub
        End If

        If Len(Trim(ComboBox3.Text)) = 0 Then
            MessageBox.Show("Please enter employee Position", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox3.Focus()
            Exit Sub
        End If

        If Len(Trim(DateTimePicker2.Text)) = 0 Then
            MessageBox.Show("Please enter employee Date of Birth", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker2.Focus()
            Exit Sub
        End If

        If Len(Trim(DateTimePicker1.Text)) = 0 Then
            MessageBox.Show("Please enter employee Date of Joined", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker1.Focus()
            Exit Sub
        End If

        If Len(Trim(TextBox2.Text)) = 0 Then
            MessageBox.Show("Please enter employee Basic Salary", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Focus()
            Exit Sub
        End If

        Try
            Me.Validate()
            Me.InformationBindingSource2.EndEdit()
            Me.InformationTableAdapter2.Update(Me.Database9DataSet2.information)
            MessageBox.Show("Successfully Added")
            TextBox6.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DateofOriginLabel_Click(sender As Object, e As EventArgs)

    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
#Enable Warning IDE1006 ' Naming Styles
        If Len(Trim(TextBox1.Text)) = 0 Then
            MessageBox.Show("Please enter employee ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Focus()
            Exit Sub
        End If

        If Len(Trim(TextBox6.Text)) = 0 Then
            MessageBox.Show("Please enter employee name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox6.Focus()
            Exit Sub
        End If

        If Len(Trim(TextBox5.Text)) = 0 Then
            MessageBox.Show("Please enter employee Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox5.Focus()
            Exit Sub
        End If

        If Len(Trim(TextBox4.Text)) = 0 Then
            MessageBox.Show("Please enter employee Contact Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox4.Focus()
            Exit Sub
        End If

        If Len(Trim(TextBox3.Text)) = 0 Then
            MessageBox.Show("Please enter employee Email", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox3.Focus()
            Exit Sub
        End If

        If Len(Trim(BloodTypeComboBox.Text)) = 0 Then
            MessageBox.Show("Please enter employee Blood Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BloodTypeComboBox.Focus()
            Exit Sub
        End If

        If Len(Trim(ComboBox1.Text)) = 0 Then
            MessageBox.Show("Please enter employee Department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox1.Focus()
            Exit Sub
        End If

        If Len(Trim(ComboBox2.Text)) = 0 Then
            MessageBox.Show("Please enter employee Designation", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox2.Focus()
            Exit Sub
        End If

        If Len(Trim(ComboBox3.Text)) = 0 Then
            MessageBox.Show("Please enter employee Position", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox3.Focus()
            Exit Sub
        End If

        If Len(Trim(DateTimePicker2.Text)) = 0 Then
            MessageBox.Show("Please enter employee Date of Birth", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker2.Focus()
            Exit Sub
        End If

        If Len(Trim(DateTimePicker1.Text)) = 0 Then
            MessageBox.Show("Please enter employee Date of Joined", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker1.Focus()
            Exit Sub
        End If

        If Len(Trim(TextBox2.Text)) = 0 Then
            MessageBox.Show("Please enter employee Salary", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Focus()
            Exit Sub
        End If

        Try
            If MsgBox("Do you want to add new employee?", vbYesNo + vbQuestion) = vbYes Then
                InformationBindingSource2.AddNew()
                Me.InformationTableAdapter2.Update(Me.Database9DataSet2.information)
                MessageBox.Show("You can now input...")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub btnDeleteJHS_Click(sender As Object, e As EventArgs) Handles btnDeleteJHS.Click
#Enable Warning IDE1006 ' Naming Styles
        Try
            If TextBox1.Text = "" Then
                MessageBox.Show("Please select employee id", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If TextBox1.Text.Count > 0 Then
                If MessageBox.Show("Do you really want to delete the record?" & vbCrLf & "You can not restore the record" & vbCrLf & "It will delete record permanently" & vbCrLf & "related to selected employee", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    InformationBindingSource2.RemoveCurrent()
                    Me.InformationTableAdapter2.Update(Me.Database9DataSet2.information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        InformationBindingSource2.MoveNext()
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
        txtReceipt1.AppendText("Blood Type: " + vbTab + vbTab & BloodTypeComboBox.Text + vbNewLine)
        txtReceipt1.AppendText("Department: " + vbTab + vbTab & ComboBox1.Text + vbNewLine)
        txtReceipt1.AppendText("Designation: " + vbTab + vbTab & ComboBox2.Text + vbNewLine)
        txtReceipt1.AppendText("Position: " + vbTab + vbTab & ComboBox3.Text + vbNewLine)
        txtReceipt1.AppendText("Date of Birth: " + vbTab + vbTab & DateTimePicker2.Text + vbNewLine)
        txtReceipt1.AppendText("Date of Joined: " + vbTab + vbTab & DateTimePicker1.Text + vbNewLine)
        txtReceipt1.AppendText("Salary: " + vbTab + vbTab & TextBox2.Text + vbNewLine)

        txtReceipt1.AppendText("" + vbNewLine)

        PrintPreviewDialog1.ShowDialog()
    End Sub


    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(txtReceipt1.Text, Font, Brushes.Black, 140, 140)
        e.Graphics.DrawImage(Me.PictureBox1.Image, 120, 130, PictureBox1.Width - 15, PictureBox1.Height - 25)

    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        Me.InformationBindingSource2.Filter = "EmployeeID LIKE '" & TextBox14.Text & "%'"
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub
End Class
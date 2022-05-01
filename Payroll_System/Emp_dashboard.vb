Public Class Emp_dashboard
    Private Sub Emp_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("hh:mm:ss tt")
        Label2.Text = DateTime.Now.ToString("MMMM  dd  yyyy")
    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
#Enable Warning IDE1006 ' Naming Styles
        btnLogout.BackColor = Color.White
        btnLogout.ForeColor = Color.Black
        If MsgBox("Do you want to switch user?", vbYesNo + vbQuestion) = vbYes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub btnCataloging_Click(sender As Object, e As EventArgs) Handles btnCataloging.Click
#Enable Warning IDE1006 ' Naming Styles
        View_emp.Show()
        
    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub btnCirculation_Click(sender As Object, e As EventArgs) Handles btnCirculation.Click
#Enable Warning IDE1006 ' Naming Styles
        Payment.Show()


    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Calc.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked

    End Sub

    Private Sub NotePadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotePadToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Notepad.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
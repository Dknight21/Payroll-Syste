Imports System.Data.OleDb

Imports System.Data
Imports System.IO
Public Class Ad_dashboard
    Private Sub Ad_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("hh:mm:ss tt")
        Label2.Text = DateTime.Now.ToString("MMMM  dd  yyyy")
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Try
            System.Diagnostics.Process.Start("Notepad.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click

    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Try
            System.Diagnostics.Process.Start("Calc.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Reg_form.Show()


    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Re_staff.Show()


    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub btnCataloging_Click(sender As Object, e As EventArgs)
#Enable Warning IDE1006 ' Naming Styles

    End Sub

    Private Sub btnCirculation_Click(sender As Object, e As EventArgs) 

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
    Private Sub btnCataloging_Click_1(sender As Object, e As EventArgs) Handles btnCataloging.Click
#Enable Warning IDE1006 ' Naming Styles
        Register_emp.Show()


    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
#Enable Warning IDE1006 ' Naming Styles
        Try
            Dim fdb As New FolderBrowserDialog
            If fdb.ShowDialog() = vbOK Then
                File.Copy("Database9.mdb", fdb.SelectedPath & "\Database9.mdb")
                MsgBox("Done...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
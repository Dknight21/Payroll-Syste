Imports System.Data.OleDb
Imports System.Data

Public Class Log2
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "•"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Do you want to switch user?", vbYesNo + vbQuestion) = vbYes Then
            Me.Hide()
            Form1.Show()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =  " & Application.StartupPath & "\Database21.accdb;")
        Dim cmd As OleDbCommand = New OleDbCommand(
                   "SELECT * FROM User_log WHERE Username = '" &
                   TextBox1.Text & "' AND [Password] = '" & txtPassword.Text & "' ", con)
        con.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            MessageBox.Show("You are Now Logged In")
            Emp_dashboard.Show()
            TextBox1.Focus()
            TextBox1.Clear()
            txtPassword.Clear()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password!")
        End If



    End Sub

    Private Sub Log2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
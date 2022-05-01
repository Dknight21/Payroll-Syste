Imports System.Data.OleDb
Imports System.Data

Public Class Form1
    Dim Admin As New ArrayList
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Admin.Add("Admin")
        Admin.Add("User")
        ComboBox1.DataSource = Admin
        ComboBox1.Text = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Admin" Then
            Log1.Show()
            Me.Hide()
        Else
            ComboBox1.Text = "User"
            Log2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class

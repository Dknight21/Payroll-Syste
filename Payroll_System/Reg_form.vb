Imports System.Data.OleDb
Public Class Reg_form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'UserlogBindingSource.AddNew()
        'On Error GoTo SaveError
        'UserlogBindingSource.EndEdit()
        'User_logTableAdapter.Update(Database21DataSet.User_log)
        'MsgBox("Data has been save")
        'Me.User_logTableAdapter.Fill(Me.Database21DataSet.User_log)



        'SaveError:
        '       Exit Sub




        Try
            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =  " & Application.StartupPath & "\Database21.accdb;")
            Dim insert As String = "Insert into User_log values('" & TextBox1.Text & "','" & TextBox2.Text & "');"
            Dim cmd As New OleDbCommand(insert, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("create success")
            TextBox1.Clear()
            TextBox2.Clear()
            Me.Hide()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Private Sub Reg_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database21DataSet.User_log' table. You can move, or remove it, as needed.
        Me.User_logTableAdapter.Fill(Me.Database21DataSet.User_log)
        'TODO: This line of code loads data into the 'Database21DataSet.Admin_log' table. You can move, or remove it, as needed.
        'Me.Admin_logTableAdapter.Fill(Me.Database21DataSet.Admin_log)
        'TODO: This line of code loads data into the 'Database21DataSet.User_log' table. You can move, or remove it, as needed.
        'Me.User_logTableAdapter.Fill(Me.Database21DataSet.User_log)

    End Sub
End Class
Imports System.Data.OleDb
Imports System.Data
Imports System.Data.DataTable
Public Class Re_staff
    Dim source1 As New BindingSource()
    Dim source2 As New BindingSource()
    Dim ds As DataSet = New DataSet
    Dim tables As DataTableCollection = ds.Tables
    Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =  " & Application.StartupPath & "\Database21.accdb;")

#Disable Warning IDE1006 ' Naming Styles
    Sub fill()
#Enable Warning IDE1006 ' Naming Styles
        Dim dt As New DataTable
        Dim str As String = "Select Username as [Staff Username], Password as [Staff Password] from User_log ORDER By Username "
        Dim da As New OleDb.OleDbDataAdapter(str, con)
        da.Fill(dt)
        da.Dispose()
        source1.DataSource = dt
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
        DataGridView1.Columns(1).Width = 90
    End Sub
#Disable Warning IDE1006 ' Naming Styles
    Public Sub delterminated()
#Enable Warning IDE1006 ' Naming Styles
        Try
            Dim str1 As String = "Delete * from User_log where [User_log.Username]= '" & DataGridView1.SelectedCells(0).Value.ToString & "'"
            Dim cmd1 As New OleDbCommand(str1, con)
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            fill()
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub
#Disable Warning IDE1006 ' Naming Styles
    Private Sub deleteuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
#Enable Warning IDE1006 ' Naming Styles
        fill()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()


    End Sub

    Private Sub Re_staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database21DataSet.User_log' table. You can move, or remove it, as needed.
        Me.User_logTableAdapter.Fill(Me.Database21DataSet.User_log)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dr As New DialogResult
        dr = MessageBox.Show("Are you sure you want to permanently delete " & DataGridView1.SelectedCells(0).Value & "?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If dr = Windows.Forms.DialogResult.Cancel Then
            MessageBox.Show("Action aborted!", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.ClearSelection()
            Exit Sub
        Else
            delterminated()
            fill()
        End If
    End Sub
End Class
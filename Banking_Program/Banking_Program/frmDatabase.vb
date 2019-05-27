Public Class frmDatabase
    'Calculate and load the data
    Private Sub frmDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'lets get the data from a file
        Dim TextFieldParser1 As New Microsoft.VisualBasic.FileIO.TextFieldParser(Application.StartupPath & "\data.csv")

        'we will set a limiter such as ","
        TextFieldParser1.Delimiters = New String() {","}

        'Check all the values
        While Not TextFieldParser1.EndOfData
            Dim Row1 As String() = TextFieldParser1.ReadFields()

            If DataGridView1.Columns.Count = 0 AndAlso Row1.Count > 0 Then
                Dim i As Integer

                For i = 0 To Row1.Count - 1
                    DataGridView1.Columns.Add("Column" & i + 1, "Column" & i + 1)
                Next
            End If

            'Add the data
            DataGridView1.Rows.Add(Row1)
        End While
    End Sub

    'We need a row count to keep track
    Dim rowCount As String = 1

    'When the previous button is clicked
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        btnNext.Enabled = True
        rowCount = rowCount - 1
        DataGridView1.ClearSelection()
        DataGridView1.Rows(rowCount).Selected = True
        If rowCount <= 1 Then
            btnPrevious.Enabled = False
        End If
    End Sub

    'When the next button is clicked
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        btnPrevious.Enabled = True
        rowCount = rowCount + 1
        DataGridView1.ClearSelection()
        DataGridView1.Rows(rowCount).Selected = True
        If rowCount >= 11 Then
            btnNext.Enabled = False
        End If
    End Sub

    'When the values change 
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Try

            For Each row In DataGridView1.SelectedRows

                'Add the entries to the data
                Dim CustomerNumber As String = row.cells(0).value.ToString
                Dim BusinessName As String = row.cells(1).value.ToString
                Dim Email As String = row.cells(2).value.ToString
                Dim Balance As String = row.cells(3).value.ToString
                Dim CreditLimit As String = row.cells(4).value.ToString

                txtBizName.Text = BusinessName
                txtEmail.Text = Email
                txtCreditLimit.Text = Balance

                If CreditLimit - Balance < 1000 Then
                    DataGridView1.Rows.Remove(row)
                End If

            Next
        Catch ex As Exception

        End Try
    End Sub
End Class
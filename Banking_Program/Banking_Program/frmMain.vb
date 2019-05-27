Public Class frmMain
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'We will use this to check the credentials 
        If txtUsername.Text = "BankNE" And txtPassword.Text = "England$" Then
            'The user is authenticated

            'Show the Database Form
            frmDatabase.Show()

            'Delete the credentials for security
            txtUsername.Clear()
            txtPassword.Clear()

            'Hide the login Form
            Me.Hide()
        Else
            'Provide a credential incorrect message
            MsgBox("Authentication Failed!", MsgBoxStyle.Critical, Title:="The Bank of New England")
        End If
    End Sub

    Private Sub llbShowPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbShowPassword.LinkClicked
        'This will allow the user to peek at the password
        If txtPassword.UseSystemPasswordChar = True Then
            'Show the password
            txtPassword.UseSystemPasswordChar = False
        Else
            'Hide the password
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

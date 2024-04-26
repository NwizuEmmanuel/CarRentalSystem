Imports MySql.Data.MySqlClient

Public Class SignUp
    Private connectionString As String = "server=localhost;user=root;database=car_rental"
    Private Sub SignUpBtn_Click(sender As Object, e As EventArgs) Handles SignUpBtn.Click
        Dim query As String = "insert into user (username, email, password) values (@v1,@v2,@v3)"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", UsernameFd.Text)
                command.Parameters.AddWithValue("@v2", EmailFd.Text)
                command.Parameters.AddWithValue("@v3", PasswordFd.Text)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Sign up complete.")
                    Me.Hide()
                    Login.Show()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using

        UsernameFd.Clear()
        PasswordFd.Clear()
        EmailFd.Clear()
    End Sub

    Private Sub LoginLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LoginLink.LinkClicked
        Me.Hide()
        Login.Show()
    End Sub
End Class
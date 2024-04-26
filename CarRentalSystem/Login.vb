Imports MySql.Data.MySqlClient

Public Class Login
    Private connectionString As String = "server=localhost;user=root;database=car_rental"

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim query As String = "select count(*) from user where username=@v1 and password=@v2"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", UsernameFd.Text)
                command.Parameters.AddWithValue("@v2", PasswordFd.Text)

                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar)
                    If count > 0 Then
                        Me.Hide()
                        MainApp.Show()
                    Else
                        MessageBox.Show("Invalid username or password")
                    End If
                Catch ex As Exception

                End Try
            End Using
        End Using
    End Sub

    Private Sub SignUpLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignUpLink.LinkClicked
        Me.Hide()
        SignUp.Show()
    End Sub
End Class
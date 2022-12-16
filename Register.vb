Public Class Register
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        If (validateRegister()) Then
            Login.Users.AddUsersDatabase(TxtUsername.Text, TxtPassword.Text)
            MessageBox.Show("Berhasil Register")
        Else
            MessageBox.Show("Validasi Gagal")
        End If
    End Sub

    Public Function validateRegister() As Boolean
        If (TxtUsername.Text <> "") Then
            If TxtPassword.Text = TxtConfirmPassword.Text And TxtPassword.Text <> "" Then
                Return True
            End If
            Return False
        End If
        Return False
    End Function

End Class
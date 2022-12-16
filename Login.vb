Public Class Login
    Public Shared Users As New Users()
    Public Shared Perpustakaan As Perpustakaan
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Users = New Users()
        Perpustakaan = New Perpustakaan()
    End Sub
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim Register = New Register()
        Register.Show()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username = TxtUsername.Text
        Dim password = TxtPassword.Text

        Dim authData = Users.CheckAuthDatabase(username, password)

        If authData.Count() > 0 Then
            Users.GSUsernameProperty = authData(1)
            Perpustakaan.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Password")
        End If
    End Sub


End Class
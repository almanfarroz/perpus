Public Class HapusKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblKoleksi.Text = Perpustakaan.ListBoxKoleksi.SelectedItem()

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        'Perpustakaan.ListBoxKoleksi.Items.Remove(Perpustakaan.ListBoxKoleksi.SelectedItem())
        Perpustakaan.data_perpus.DeleteDataKoleksiByIDDatabase(Perpustakaan.SelectedTableKoleksi)
        Me.Close()
    End Sub
End Class
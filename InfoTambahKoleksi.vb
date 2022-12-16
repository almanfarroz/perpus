Public Class InfoTambahKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LblNama.Text = Perpustakaan.data_perpus.GSNama
        LblJenis.Text = Perpustakaan.data_perpus.GSJenis
        LblDeskripsi.Text = Perpustakaan.data_perpus.GSDeskripsi
        LblPenerbit.Text = Perpustakaan.data_perpus.GSPenerbit
        LblTahun.Text = Perpustakaan.data_perpus.GSTahun
        LblTanggal.Text = Perpustakaan.data_perpus.GSTanggal_masuk
        LblStock.Text = Perpustakaan.data_perpus.GSStock
        LblBahasa.Text = Perpustakaan.data_perpus.GSBahasa

        Try
            PictureBoxCol.Load(Perpustakaan.data_perpus.GSFoto)
            PictureBoxCol.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception

        End Try

        For Each kategori In Perpustakaan.data_perpus.GSkategori_list
            ListBoxKat.Items.Add(kategori)
        Next


    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub
End Class
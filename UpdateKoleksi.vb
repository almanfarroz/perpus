Public Class UpdateKoleksi
    Public Shared jenis As New List(Of String) From {"Buku", "Komik", "Majalah", "Novel"}
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CBjenis.DataSource = jenis
        Dim data_perpus = Perpustakaan.data_perpus

        PicFoto.Load(data_perpus.GSFoto)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"

        TxtNama.Text = data_perpus.GSNama
        CBjenis.SelectedItem() = data_perpus.GSJenis
        RichTextBoxDeks.Text = data_perpus.GSDeskripsi
        Txtpenerbit.Text = data_perpus.GSPenerbit
        Txtlokasi.Text = data_perpus.GSLokasi
        DateTimePicker1.Value = data_perpus.GSTanggal_masuk
        Txtstock.Text = data_perpus.GSStock

        If String.Compare(Perpustakaan.data_perpus.GSBahasa, "Indonesia") = 0 Then
            RBbindo.Checked = True
        ElseIf String.Compare(Perpustakaan.data_perpus.GSBahasa, "Inggris") = 0 Then
            RBbing.Checked = True
        End If

        For Each kategori In data_perpus.GSkategori_list
            If String.Compare(kategori, "Sains") Then
                Chksains.Checked = True
            ElseIf String.Compare(kategori, "Sosial") Then
                ChkSosial.Checked = True
            ElseIf String.Compare(kategori, "Teknologi") Then
                Chkteknologi.Checked = True
            ElseIf String.Compare(kategori, "Budaya") Then
                Chkbudaya.Checked = True
            End If
        Next

        data_perpus.GSKategori_list.Clear()
        'Perpustakaan.data_perpus.resetKategori()
    End Sub

    Private Sub BtnGambar_Click(sender As Object, e As EventArgs) Handles BtnGambar.Click
        OpenFileDialog1.Title = "Upload Photo"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()
        PicFoto.Load(OpenFileDialog1.FileName)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage

        Perpustakaan.data_perpus.GSFoto = OpenFileDialog1.FileName.ToString()
        Perpustakaan.data_perpus.GSFoto = Perpustakaan.data_perpus.GSFoto.Replace("\", "/")
    End Sub

    Private Sub Btntambahkoleksi_Click(sender As Object, e As EventArgs) Handles Btntambahkoleksi.Click
        Perpustakaan.data_perpus.GSNama = TxtNama.Text
        Perpustakaan.data_perpus.GSJenis = CBjenis.SelectedItem
        Perpustakaan.data_perpus.GSDeskripsi = RichTextBoxDeks.Text
        Perpustakaan.data_perpus.GSPenerbit = Txtpenerbit.Text
        Perpustakaan.data_perpus.GSTahun = Txttahun.Text
        Perpustakaan.data_perpus.GSLokasi = Txtlokasi.Text
        Perpustakaan.data_perpus.GSTanggal_masuk = DateTimePicker1.Value
        Perpustakaan.data_perpus.GSStock = Txtstock.Text

        If RBbing.Checked Then
            Perpustakaan.data_perpus.GSBahasa = "Bahasa Inggris"
        ElseIf RBbindo.Checked Then
            Perpustakaan.data_perpus.GSBahasa = "Bahasa Indonesia"
        End If

        '' Check Checkbox Value
        '' ==================================================
        Dim kategori = New List(Of String)
        If Chksains.Checked() Then
            kategori.Add("Sains")
        End If
        If ChkSosial.Checked() Then
            kategori.Add("Sosial")
        End If
        If Chkbudaya.Checked() Then
            kategori.Add("Budaya")
        End If
        If Chkteknologi.Checked() Then
            kategori.Add("Teknologi")
        End If

        Perpustakaan.data_perpus.GSkategori_list = kategori

        Dim convertedKoleksi = Perpustakaan.data_perpus.ConvertKoleksiToString(Perpustakaan.data_perpus.GSkategori_list)

        Perpustakaan.data_perpus.UpdateDataKoleksiByIDDatabase(
                                                    Perpustakaan.SelectedTableKoleksi,
                                                    Perpustakaan.data_perpus.GSFoto,
                                                    Perpustakaan.data_perpus.GSNama,
                                                    Perpustakaan.data_perpus.GSJenis,
                                                    Perpustakaan.data_perpus.GSPenerbit,
                                                    Perpustakaan.data_perpus.GSDeskripsi,
                                                    Perpustakaan.data_perpus.GSTahun,
                                                    Perpustakaan.data_perpus.GSLokasi,
                                                    Perpustakaan.data_perpus.GSTanggal_masuk,
                                                    Perpustakaan.data_perpus.GSStock,
                                                    Perpustakaan.data_perpus.GSBahasa,
                                                    convertedKoleksi
                                                    )

        Dim infoTambah = New InfoTambahKoleksi()
        Me.Close()
        infoTambah.Show()
    End Sub
End Class
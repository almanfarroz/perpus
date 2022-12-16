Public Class Tambahkoleksi
    Public Shared data_perpus As DataPerpus
    Dim jenis As New List(Of String) From {"Buku", "Komik", "Majalah", "Novel"}
    Public kategori_list As New List(Of String)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        data_perpus = New DataPerpus()
        ' Add any initialization after the InitializeComponent() call.
        CBjenis.DataSource = jenis
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btntambahkoleksi.Click
        Perpustakaan.data_perpus.GSNama = TxtNama.Text
        Perpustakaan.data_perpus.GSJenis = CBjenis.SelectedItem()
        Perpustakaan.data_perpus.GSTanggal_masuk = DateTimePicker1.Value.ToShortDateString
        Perpustakaan.data_perpus.GSLokasi = Txtlokasi.Text
        Perpustakaan.data_perpus.GSTahun = Txttahun.Text
        Perpustakaan.data_perpus.GSStock = Txtstock.Text
        Perpustakaan.data_perpus.GSPenerbit = Txtpenerbit.Text
        Perpustakaan.data_perpus.GSDeskripsi = RichTextBoxDeks.Text

        If RBbing.Checked Then
            Perpustakaan.data_perpus.GSBahasa = "Bahasa Inggris"
        ElseIf RBbindo.Checked Then
            Perpustakaan.data_perpus.GSBahasa = "Bahasa Indonesia"
        End If

        '' Check Checkbox Value
        '' ==================================================
        If Chksains.Checked() Then
            kategori_list.Add("Sains")
        End If
        If ChkSosial.Checked() Then
            kategori_list.Add("Sosial")
        End If
        If Chkbudaya.Checked() Then
            kategori_list.Add("Budaya")
        End If
        If Chkteknologi.Checked() Then
            kategori_list.Add("Teknologi")
        End If
        Perpustakaan.data_perpus.GSkategori_list = kategori_list

        Perpustakaan.data_perpus.GSFoto = OpenFileDialog1.FileName.ToString()
        Perpustakaan.data_perpus.GSFoto = Perpustakaan.data_perpus.GSFoto.Replace("\", "/")

        Dim convertedKoleksi = Perpustakaan.data_perpus.ConvertKoleksiToString(Perpustakaan.data_perpus.GSkategori_list)
        Perpustakaan.data_perpus.AddDataKoleksiDatabase(Perpustakaan.data_perpus.GSFoto,
                                                    Perpustakaan.data_perpus.GSNama,
                                                    Perpustakaan.data_perpus.GSJenis,
                                                    Perpustakaan.data_perpus.GSPenerbit,
                                                    Perpustakaan.data_perpus.GSDeskripsi,
                                                    Perpustakaan.data_perpus.GSTahun,
                                                    Perpustakaan.data_perpus.GSLokasi,
                                                    Perpustakaan.data_perpus.GSTanggal_masuk,
                                                    Perpustakaan.data_perpus.GSStock,
                                                    Perpustakaan.data_perpus.GSBahasa,
                                                    convertedKoleksi)
        Dim InfoTambahKoleksi = New InfoTambahKoleksi()

        Me.Close()
        InfoTambahKoleksi.Show()

    End Sub

    Private Sub BtnGambar_Click(sender As Object, e As EventArgs) Handles BtnGambar.Click
        OpenFileDialog1.Title = "Upload Photo"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()
        PicFoto.Load(OpenFileDialog1.FileName)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

End Class
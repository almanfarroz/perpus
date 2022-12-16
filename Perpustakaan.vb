Public Class Perpustakaan
    Public Shared data_perpus As DataPerpus
    Public SelectedTableKoleksi As Integer = -1
    Public SelectedTableKoleksiNama As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        data_perpus = New DataPerpus()
        ReloadDataTableDatabase()
    End Sub

    Private Sub ButtonTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click
        Dim tambah = New Tambahkoleksi()
        tambah.Show()
    End Sub

    Private Sub BtnKurangKoleksi_Click(sender As Object, e As EventArgs) Handles BtnKurangKoleksi.Click
        If ListBoxKoleksi.SelectedItem Is Nothing Then
            MessageBox.Show("Pilih")
        Else
            Dim HapusKoleksi = New HapusKoleksi()
            HapusKoleksi.Show()
        End If
    End Sub

    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        Dim tambah = New Tambahkoleksi()
        tambah.Show()
    End Sub

    Public Sub UpdateDataTableArrayList()
        DataGridView1.Rows.Clear()
        For Each rowKoleksi In Perpustakaan.data_perpus.getKoleksiDataTable()
            Dim dataTable As String() = {rowKoleksi(1),
                rowKoleksi(2),
                rowKoleksi(3),
                rowKoleksi(4),
                rowKoleksi(5),
                rowKoleksi(6),
                rowKoleksi(7),
                rowKoleksi(8),
                rowKoleksi(9),
                rowKoleksi(10)}
            DataGridView1.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub Perpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If data_perpus.GSNama <> "" Then
            ListBoxKoleksi.Items.Add(data_perpus.GSNama)
            data_perpus.ClearData()
        End If
        'UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        Dim dataSelected = data_perpus.getKoleksiDataTable(SelectedTableKoleksi)

        data_perpus.GSFoto = dataSelected(0)
        data_perpus.GSNama = dataSelected(1)
        data_perpus.GSJenis = dataSelected(2)
        data_perpus.GSDeskripsi = dataSelected(3)
        data_perpus.GSPenerbit = dataSelected(4)
        data_perpus.GSTahun = dataSelected(5)
        data_perpus.GSLokasi = dataSelected(6)
        data_perpus.GSTanggal_masuk = dataSelected(7)
        data_perpus.GSStock = dataSelected(8)
        data_perpus.GSBahasa = dataSelected(9)

        Dim dataKoleksi As List(Of String) = data_perpus.ConvertStringToKoleksi(dataSelected(11))
        data_perpus.GSkategori_list = dataKoleksi

        Dim info_tambah = New InfoTambahKoleksi()
        SelectedTableKoleksi = -1
        info_tambah.Show()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'SelectedTableKoleksi = DataGridView1.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        SelectedTableKoleksi = selectedRow.Cells(0).Value
        SelectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim selectedKoleksi As List(Of String) = data_perpus.GetDataKoleksiByIDDatabase(SelectedTableKoleksi)

        data_perpus.GSFoto = selectedKoleksi(2)

        data_perpus.GSNama = selectedKoleksi(1)
        data_perpus.GSJenis = selectedKoleksi(5)
        data_perpus.GSDeskripsi = selectedKoleksi(3)
        data_perpus.GSPenerbit = selectedKoleksi(4)
        data_perpus.GSTahun = selectedKoleksi(6)
        data_perpus.GSLokasi = selectedKoleksi(7)
        data_perpus.GSTanggal_masuk = selectedKoleksi(8)
        data_perpus.GSStock = selectedKoleksi(9)
        data_perpus.GSBahasa = selectedKoleksi(10)

        data_perpus.GSkategori_list = data_perpus.ConvertStringToKoleksi(selectedKoleksi(11))

        Dim formUpdate = New UpdateKoleksi()
        formUpdate.Show()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim formHapus = New HapusKoleksi()
        formHapus.Show()
    End Sub

    Public Sub ReloadDataTableDatabase()
        DataGridView1.DataSource = data_perpus.GetDataKoleksiDatabase()
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If data_perpus.getKoleksiDataTable.Count = 0 Then
            MessageBox.Show("Data kosong")
        Else
            Dim selectedKoleksi = data_perpus.getKoleksiDataTable.Item(SelectedTableKoleksi)
            data_perpus.GSFoto = selectedKoleksi(2)
            data_perpus.GSNama = selectedKoleksi(1)
            data_perpus.GSJenis = selectedKoleksi(5)
            data_perpus.GSDeskripsi = selectedKoleksi(3)
            data_perpus.GSPenerbit = selectedKoleksi(4)
            data_perpus.GSTahun = selectedKoleksi(6)
            data_perpus.GSLokasi = selectedKoleksi(7)
            data_perpus.GSTanggal_masuk = selectedKoleksi(8)
            data_perpus.GSStock = selectedKoleksi(9)
            data_perpus.GSBahasa = selectedKoleksi(10)
            Dim data_koleksi As List(Of String) = data_perpus.ConvertStringToKoleksi(selectedKoleksi(11))


            data_perpus.GSkategori_list = data_koleksi

            Dim info_tambah = New InfoTambahKoleksi()
            info_tambah.Show()
        End If
    End Sub
End Class

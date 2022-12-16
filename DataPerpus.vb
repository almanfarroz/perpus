Imports System.Text
Imports MySql.Data.MySqlClient

Public Class DataPerpus
    Private bahasa As String
    Private nama As String
    Private jenis As String
    Private tahun As String
    Private lokasi As String
    Private penerbit As String
    Private stock As String
    Private tanggal_masuk As String
    Private foto_gambar As String
    Private Deskripsi As String
    Public Shared kategori_list As New List(Of String)

    Private koleksiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "perpustakaan"

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM Koleksi WHERE id_koleksi='" & ID.ToString & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        End Try
        dbConn.Dispose()
    End Function

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_koleksi AS 'ID',
                                nama_koleksi AS 'Nama Koleksi',
                                jenis_koleksi AS 'Jenis Koleksi',
                                penerbit AS 'Penerbit',
                                tahun_terbit AS 'Tahun Terbit',
                                lokasi AS 'Lokasi Rak',
                                stock AS 'Stock',
                                bahasa AS 'Bahasa',
                                kategori AS 'Kategori'
                                FROM koleksi
                                "

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_koleksi, nama_koleksi, dir_gambar, deskripsi, penerbit, jenis_koleksi,
                                 tahun_terbit, lokasi, tanggal_masuk_koleksi, stock, bahasa, kategori
                                 FROM koleksi WHERE id_koleksi = '" + ID.ToString + "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
            result.Add(sqlRead.GetString(10).ToString())
            result.Add(sqlRead.GetString(11).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataKoleksiByIdDatabase(id As Integer,
                                        dir_gambar As String,
                                        nama_koleksi As String,
                                        jenis_koleksi As String,
                                        penerbit_koleksi As String,
                                        deskirpsi_koleksi As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As Date,
                                        stock_koleksi As Integer,
                                        bahasa_koleksi As String,
                                        kategori_koleksi As String
                                        )
        tahun = tahun.ToString()

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database

        'Try
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "UPDATE koleksi SET " &
                    "nama_koleksi='" & nama_koleksi & "', " &
                    "dir_gambar='" & dir_gambar & "', " &
                    "deskripsi='" & deskirpsi_koleksi & "', " &
                    "penerbit='" & penerbit_koleksi & "', " &
                    "jenis_koleksi='" & jenis_koleksi & "', " &
                    "tahun_terbit='" & tahun_terbit & "', " &
                    "lokasi='" & lokasi_rak & "', " &
                    "tanggal_masuk_koleksi='" & tanggal_masuk.ToString("yyyy/MM/dd") & "', " &
                    "stock='" & stock_koleksi & "', " &
                    "bahasa='" & bahasa_koleksi & "', " &
                    "kategori='" & kategori_koleksi & "' " &
                    "WHERE id_koleksi='" & id & "'"

        Debug.Print(sqlQuery)

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        sqlRead = sqlCommand.ExecuteReader

        sqlRead.Close()
        dbConn.Close()
        'Catch ex As Exception
        '    Return ex.Message
        'Finally
        dbConn.Dispose()
        'End Try

    End Function

    Public Function AddDataKoleksiDatabase(dir_gambar As String,
                                        nama_koleksi As String,
                                        jenis_koleksi As String,
                                        penerbit_koleksi As String,
                                        deskirpsi_koleksi As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As Date,
                                        stock_koleksi As Integer,
                                        bahasa_koleksi As String,
                                        kategori_koleksi As String
                                        )
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password= " + password + ";" + "database=" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO KOLEKSI(nama_koleksi, dir_gambar,
            deskripsi, penerbit, jenis_koleksi, tahun_terbit, lokasi,
            tanggal_masuk_koleksi, stock, bahasa, kategori) VALUE('" _
            & nama_koleksi & "', '" & dir_gambar & "', '" & deskirpsi_koleksi & "', '" _
            & penerbit_koleksi & "', '" & jenis_koleksi & "', '" & tahun_terbit & "', '" _
            & lokasi_rak & "', '" & tanggal_masuk.ToString("yyyy/MM/dd") & "', '" & stock_koleksi & "', '" _
            & bahasa_koleksi & "', '" & kategori_koleksi & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Sub AddKoleksiDataTable(dir_gambar As String,
                                        nama_koleksi As String,
                                        jenis_koleksi As String,
                                        penerbit_koleksi As String,
                                        deskirpsi_koleksi As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As String,
                                        stock_koleksi As String,
                                        bahasa_koleksi As String,
                                        kategori_koleksi As String
                                        )

        koleksiDataTable.Add({
                             dir_gambar,
                             nama_koleksi,
                             jenis_koleksi,
                             penerbit_koleksi,
                             deskirpsi_koleksi,
                             tahun_terbit,
                             lokasi_rak,
                             tanggal_masuk,
                             stock_koleksi,
                             bahasa_koleksi,
                             kategori_koleksi
                             })
    End Sub

    Public Function RemoveKoleksiDataTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
    End Function

    Public Function AddKategori(value As String)
        koleksiDataTable.Add(value)
        Return ""
    End Function

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        ' Convert to string
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        ' Convert to List
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function


    Public Property GSFoto As String
        Get
            Return foto_gambar
        End Get
        Set(ByVal value As String)
            foto_gambar = value
        End Set
    End Property

    Public Property GSDeskripsi As String
        Get
            Return Deskripsi
        End Get
        Set(ByVal value As String)
            Deskripsi = value
        End Set
    End Property
    Public Property GSLokasi As String
        Get
            Return lokasi
        End Get
        Set(ByVal value As String)
            lokasi = value
        End Set
    End Property
    Public Property GSPenerbit As String
        Get
            Return penerbit
        End Get
        Set(ByVal value As String)
            penerbit = value
        End Set
    End Property
    Public Property GSStock As String
        Get
            Return stock
        End Get
        Set(ByVal value As String)
            stock = value
        End Set
    End Property
    Public Property GSBahasa As String
        Get
            Return bahasa
        End Get
        Set(ByVal value As String)
            bahasa = value
        End Set
    End Property
    Public Property GSNama As String
        Get
            Return nama
        End Get
        Set(ByVal value As String)
            nama = value
        End Set
    End Property
    Public Property GSTanggal_masuk As String
        Get
            Return tanggal_masuk
        End Get
        Set(ByVal value As String)
            tanggal_masuk = value
        End Set
    End Property
    Public Property GSJenis As String
        Get
            Return jenis
        End Get
        Set(ByVal value As String)
            jenis = value
        End Set
    End Property
    Public Property GSTahun As Integer
        Get
            Return tahun
        End Get
        Set(ByVal value As Integer)
            tahun = value
        End Set
    End Property
    Public Property GSkategori_list() As List(Of String)
        Get
            Return kategori_list
        End Get
        Set(ByVal value As List(Of String))
            kategori_list = value
        End Set
    End Property
    Public Sub ClearData()
        nama = ""
        jenis = ""
        Deskripsi = ""
        penerbit = ""
        tahun = vbNull
        lokasi = ""
        stock = 0
        tanggal_masuk = ""
        bahasa = ""
        foto_gambar = ""
        kategori_list.Clear()
    End Sub
End Class

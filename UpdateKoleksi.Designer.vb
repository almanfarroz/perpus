<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateKoleksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btntambahkoleksi = New System.Windows.Forms.Button()
        Me.BtnGambar = New System.Windows.Forms.Button()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.RichTextBoxDeks = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Chkteknologi = New System.Windows.Forms.CheckBox()
        Me.Chkbudaya = New System.Windows.Forms.CheckBox()
        Me.Chksains = New System.Windows.Forms.CheckBox()
        Me.ChkSosial = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBbindo = New System.Windows.Forms.RadioButton()
        Me.RBbing = New System.Windows.Forms.RadioButton()
        Me.CBjenis = New System.Windows.Forms.ComboBox()
        Me.Txttahun = New System.Windows.Forms.TextBox()
        Me.Txtlokasi = New System.Windows.Forms.TextBox()
        Me.Txtstock = New System.Windows.Forms.TextBox()
        Me.Txtpenerbit = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btntambahkoleksi
        '
        Me.Btntambahkoleksi.Location = New System.Drawing.Point(322, 567)
        Me.Btntambahkoleksi.Name = "Btntambahkoleksi"
        Me.Btntambahkoleksi.Size = New System.Drawing.Size(108, 23)
        Me.Btntambahkoleksi.TabIndex = 53
        Me.Btntambahkoleksi.Text = "Tambah Koleksi"
        Me.Btntambahkoleksi.UseVisualStyleBackColor = True
        '
        'BtnGambar
        '
        Me.BtnGambar.Location = New System.Drawing.Point(549, 177)
        Me.BtnGambar.Name = "BtnGambar"
        Me.BtnGambar.Size = New System.Drawing.Size(115, 23)
        Me.BtnGambar.TabIndex = 52
        Me.BtnGambar.Text = "Tambah Gambar"
        Me.BtnGambar.UseVisualStyleBackColor = True
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(549, 28)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(115, 143)
        Me.PicFoto.TabIndex = 51
        Me.PicFoto.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(273, 286)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePicker1.TabIndex = 50
        '
        'RichTextBoxDeks
        '
        Me.RichTextBoxDeks.Location = New System.Drawing.Point(273, 86)
        Me.RichTextBoxDeks.Name = "RichTextBoxDeks"
        Me.RichTextBoxDeks.Size = New System.Drawing.Size(200, 107)
        Me.RichTextBoxDeks.TabIndex = 49
        Me.RichTextBoxDeks.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Chkteknologi)
        Me.GroupBox2.Controls.Add(Me.Chkbudaya)
        Me.GroupBox2.Controls.Add(Me.Chksains)
        Me.GroupBox2.Controls.Add(Me.ChkSosial)
        Me.GroupBox2.Location = New System.Drawing.Point(273, 434)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 127)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategori"
        '
        'Chkteknologi
        '
        Me.Chkteknologi.AutoSize = True
        Me.Chkteknologi.Location = New System.Drawing.Point(6, 75)
        Me.Chkteknologi.Name = "Chkteknologi"
        Me.Chkteknologi.Size = New System.Drawing.Size(77, 19)
        Me.Chkteknologi.TabIndex = 23
        Me.Chkteknologi.Text = "Teknologi"
        Me.Chkteknologi.UseVisualStyleBackColor = True
        '
        'Chkbudaya
        '
        Me.Chkbudaya.AutoSize = True
        Me.Chkbudaya.Location = New System.Drawing.Point(6, 100)
        Me.Chkbudaya.Name = "Chkbudaya"
        Me.Chkbudaya.Size = New System.Drawing.Size(65, 19)
        Me.Chkbudaya.TabIndex = 24
        Me.Chkbudaya.Text = "Budaya"
        Me.Chkbudaya.UseVisualStyleBackColor = True
        '
        'Chksains
        '
        Me.Chksains.AutoSize = True
        Me.Chksains.Location = New System.Drawing.Point(6, 25)
        Me.Chksains.Name = "Chksains"
        Me.Chksains.Size = New System.Drawing.Size(53, 19)
        Me.Chksains.TabIndex = 21
        Me.Chksains.Text = "Sains"
        Me.Chksains.UseVisualStyleBackColor = True
        '
        'ChkSosial
        '
        Me.ChkSosial.AutoSize = True
        Me.ChkSosial.Location = New System.Drawing.Point(6, 50)
        Me.ChkSosial.Name = "ChkSosial"
        Me.ChkSosial.Size = New System.Drawing.Size(56, 19)
        Me.ChkSosial.TabIndex = 22
        Me.ChkSosial.Text = "Sosial"
        Me.ChkSosial.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBbindo)
        Me.GroupBox1.Controls.Add(Me.RBbing)
        Me.GroupBox1.Location = New System.Drawing.Point(273, 350)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 78)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'RBbindo
        '
        Me.RBbindo.AutoSize = True
        Me.RBbindo.Location = New System.Drawing.Point(6, 22)
        Me.RBbindo.Name = "RBbindo"
        Me.RBbindo.Size = New System.Drawing.Size(116, 19)
        Me.RBbindo.TabIndex = 19
        Me.RBbindo.TabStop = True
        Me.RBbindo.Text = "Bahasa Indonesia"
        Me.RBbindo.UseVisualStyleBackColor = True
        '
        'RBbing
        '
        Me.RBbing.AutoSize = True
        Me.RBbing.Location = New System.Drawing.Point(6, 47)
        Me.RBbing.Name = "RBbing"
        Me.RBbing.Size = New System.Drawing.Size(101, 19)
        Me.RBbing.TabIndex = 18
        Me.RBbing.TabStop = True
        Me.RBbing.Text = "Bahasa Inggris"
        Me.RBbing.UseVisualStyleBackColor = True
        '
        'CBjenis
        '
        Me.CBjenis.FormattingEnabled = True
        Me.CBjenis.Location = New System.Drawing.Point(273, 57)
        Me.CBjenis.Name = "CBjenis"
        Me.CBjenis.Size = New System.Drawing.Size(200, 23)
        Me.CBjenis.TabIndex = 46
        '
        'Txttahun
        '
        Me.Txttahun.Location = New System.Drawing.Point(273, 228)
        Me.Txttahun.Name = "Txttahun"
        Me.Txttahun.Size = New System.Drawing.Size(200, 23)
        Me.Txttahun.TabIndex = 45
        '
        'Txtlokasi
        '
        Me.Txtlokasi.Location = New System.Drawing.Point(273, 257)
        Me.Txtlokasi.Name = "Txtlokasi"
        Me.Txtlokasi.Size = New System.Drawing.Size(200, 23)
        Me.Txtlokasi.TabIndex = 44
        '
        'Txtstock
        '
        Me.Txtstock.Location = New System.Drawing.Point(273, 315)
        Me.Txtstock.Name = "Txtstock"
        Me.Txtstock.Size = New System.Drawing.Size(200, 23)
        Me.Txtstock.TabIndex = 43
        '
        'Txtpenerbit
        '
        Me.Txtpenerbit.Location = New System.Drawing.Point(273, 199)
        Me.Txtpenerbit.Name = "Txtpenerbit"
        Me.Txtpenerbit.Size = New System.Drawing.Size(200, 23)
        Me.Txtpenerbit.TabIndex = 42
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(273, 28)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(200, 23)
        Me.TxtNama.TabIndex = 41
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(135, 434)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 15)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Kategori"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(135, 350)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Bahasa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(135, 315)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 15)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Stock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(135, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 15)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Tanggal Masuk Koleksi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(135, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Lokasi Rak"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(135, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Tahun Terbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(135, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Penerbit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(135, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Deskripsi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Jenis Koleksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Nama Koleksi"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'UpdateKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 620)
        Me.Controls.Add(Me.Btntambahkoleksi)
        Me.Controls.Add(Me.BtnGambar)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.RichTextBoxDeks)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CBjenis)
        Me.Controls.Add(Me.Txttahun)
        Me.Controls.Add(Me.Txtlokasi)
        Me.Controls.Add(Me.Txtstock)
        Me.Controls.Add(Me.Txtpenerbit)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateKoleksi"
        Me.Text = "UpdateKoleksi"
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btntambahkoleksi As Button
    Friend WithEvents BtnGambar As Button
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RichTextBoxDeks As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Chkteknologi As CheckBox
    Friend WithEvents Chkbudaya As CheckBox
    Friend WithEvents Chksains As CheckBox
    Friend WithEvents ChkSosial As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBbindo As RadioButton
    Friend WithEvents RBbing As RadioButton
    Friend WithEvents CBjenis As ComboBox
    Friend WithEvents Txttahun As TextBox
    Friend WithEvents Txtlokasi As TextBox
    Friend WithEvents Txtstock As TextBox
    Friend WithEvents Txtpenerbit As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class

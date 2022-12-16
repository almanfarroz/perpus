<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Perpustakaan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBoxKoleksi = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnKurangKoleksi = New System.Windows.Forms.Button()
        Me.BtnTambahKoleksi = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnShow = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxKoleksi
        '
        Me.ListBoxKoleksi.FormattingEnabled = True
        Me.ListBoxKoleksi.ItemHeight = 25
        Me.ListBoxKoleksi.Location = New System.Drawing.Point(47, 152)
        Me.ListBoxKoleksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBoxKoleksi.Name = "ListBoxKoleksi"
        Me.ListBoxKoleksi.Size = New System.Drawing.Size(430, 404)
        Me.ListBoxKoleksi.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1479, 35)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(83, 29)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(236, 34)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'BtnKurangKoleksi
        '
        Me.BtnKurangKoleksi.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.minus_jpg
        Me.BtnKurangKoleksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnKurangKoleksi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BtnKurangKoleksi.FlatAppearance.BorderSize = 0
        Me.BtnKurangKoleksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKurangKoleksi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnKurangKoleksi.Location = New System.Drawing.Point(47, 95)
        Me.BtnKurangKoleksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnKurangKoleksi.Name = "BtnKurangKoleksi"
        Me.BtnKurangKoleksi.Size = New System.Drawing.Size(37, 53)
        Me.BtnKurangKoleksi.TabIndex = 2
        Me.BtnKurangKoleksi.UseVisualStyleBackColor = True
        '
        'BtnTambahKoleksi
        '
        Me.BtnTambahKoleksi.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.plus1
        Me.BtnTambahKoleksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTambahKoleksi.FlatAppearance.BorderSize = 0
        Me.BtnTambahKoleksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahKoleksi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnTambahKoleksi.Location = New System.Drawing.Point(93, 103)
        Me.BtnTambahKoleksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnTambahKoleksi.Name = "BtnTambahKoleksi"
        Me.BtnTambahKoleksi.Size = New System.Drawing.Size(34, 38)
        Me.BtnTambahKoleksi.TabIndex = 3
        Me.BtnTambahKoleksi.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(47, 587)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(894, 225)
        Me.DataGridView1.TabIndex = 4
        '
        'BtnShow
        '
        Me.BtnShow.Location = New System.Drawing.Point(830, 818)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(111, 33)
        Me.BtnShow.TabIndex = 5
        Me.BtnShow.Text = "Show"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(713, 818)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(111, 33)
        Me.BtnUpdate.TabIndex = 6
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(596, 818)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(111, 33)
        Me.BtnRemove.TabIndex = 7
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(479, 818)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(111, 33)
        Me.BtnSelect.TabIndex = 8
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'Perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1479, 1062)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnTambahKoleksi)
        Me.Controls.Add(Me.BtnKurangKoleksi)
        Me.Controls.Add(Me.ListBoxKoleksi)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Perpustakaan"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxKoleksi As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnKurangKoleksi As Button
    Friend WithEvents BtnTambahKoleksi As Button
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnShow As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents BtnSelect As Button
End Class

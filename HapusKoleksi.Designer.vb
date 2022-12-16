<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusKoleksi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblKoleksi = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(309, 197)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(545, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah Ingin Menghapus Koleksi"
        '
        'LblKoleksi
        '
        Me.LblKoleksi.AutoSize = True
        Me.LblKoleksi.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblKoleksi.Location = New System.Drawing.Point(309, 245)
        Me.LblKoleksi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblKoleksi.Name = "LblKoleksi"
        Me.LblKoleksi.Size = New System.Drawing.Size(522, 191)
        Me.LblKoleksi.TabIndex = 2
        Me.LblKoleksi.Text = "Label2"
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(481, 450)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(147, 82)
        Me.BtnHapus.TabIndex = 3
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'HapusKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 750)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblKoleksi)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "HapusKoleksi"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblKoleksi As Label
    Friend WithEvents BtnHapus As Button
End Class

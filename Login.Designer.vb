<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnRegister
        '
        Me.BtnRegister.Location = New System.Drawing.Point(377, 307)
        Me.BtnRegister.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(107, 38)
        Me.BtnRegister.TabIndex = 11
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = True
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(261, 307)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(107, 38)
        Me.BtnLogin.TabIndex = 10
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(261, 205)
        Me.LabelPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(87, 25)
        Me.LabelPassword.TabIndex = 9
        Me.LabelPassword.Text = "Password"
        Me.LabelPassword.UseWaitCursor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(261, 235)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(278, 31)
        Me.TxtPassword.TabIndex = 8
        Me.TxtPassword.UseWaitCursor = True
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Location = New System.Drawing.Point(261, 105)
        Me.LabelUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(91, 25)
        Me.LabelUsername.TabIndex = 7
        Me.LabelUsername.Text = "Username"
        Me.LabelUsername.UseWaitCursor = True
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(261, 135)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(278, 31)
        Me.TxtUsername.TabIndex = 6
        Me.TxtUsername.UseWaitCursor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.TxtUsername)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegister As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents TxtUsername As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.TxtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(261, 255)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Confirm Password"
        Me.Label1.UseWaitCursor = True
        '
        'TxtConfirmPassword
        '
        Me.TxtConfirmPassword.Location = New System.Drawing.Point(261, 285)
        Me.TxtConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtConfirmPassword.Name = "TxtConfirmPassword"
        Me.TxtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtConfirmPassword.Size = New System.Drawing.Size(278, 31)
        Me.TxtConfirmPassword.TabIndex = 14
        Me.TxtConfirmPassword.UseWaitCursor = True
        '
        'BtnRegister
        '
        Me.BtnRegister.Location = New System.Drawing.Point(261, 354)
        Me.BtnRegister.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(107, 38)
        Me.BtnRegister.TabIndex = 15
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = True
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(261, 159)
        Me.LabelPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(87, 25)
        Me.LabelPassword.TabIndex = 17
        Me.LabelPassword.Text = "Password"
        Me.LabelPassword.UseWaitCursor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(261, 189)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(278, 31)
        Me.TxtPassword.TabIndex = 13
        Me.TxtPassword.UseWaitCursor = True
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Location = New System.Drawing.Point(261, 59)
        Me.LabelUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(91, 25)
        Me.LabelUsername.TabIndex = 16
        Me.LabelUsername.Text = "Username"
        Me.LabelUsername.UseWaitCursor = True
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(261, 89)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(278, 31)
        Me.TxtUsername.TabIndex = 12
        Me.TxtUsername.UseWaitCursor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtConfirmPassword)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.TxtUsername)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtConfirmPassword As TextBox
    Friend WithEvents BtnRegister As Button
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents TxtUsername As TextBox
End Class

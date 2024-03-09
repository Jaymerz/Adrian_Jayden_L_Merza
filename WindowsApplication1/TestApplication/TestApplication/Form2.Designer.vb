<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.username_txtbox = New System.Windows.Forms.TextBox()
        Me.password_txtbox = New System.Windows.Forms.TextBox()
        Me.email_txtbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cancel_btn = New System.Windows.Forms.Button()
        Me.signin_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'username_txtbox
        '
        Me.username_txtbox.Location = New System.Drawing.Point(152, 98)
        Me.username_txtbox.Name = "username_txtbox"
        Me.username_txtbox.Size = New System.Drawing.Size(218, 20)
        Me.username_txtbox.TabIndex = 0
        '
        'password_txtbox
        '
        Me.password_txtbox.Location = New System.Drawing.Point(152, 144)
        Me.password_txtbox.Name = "password_txtbox"
        Me.password_txtbox.Size = New System.Drawing.Size(218, 20)
        Me.password_txtbox.TabIndex = 1
        '
        'email_txtbox
        '
        Me.email_txtbox.Location = New System.Drawing.Point(152, 201)
        Me.email_txtbox.Name = "email_txtbox"
        Me.email_txtbox.Size = New System.Drawing.Size(218, 20)
        Me.email_txtbox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(133, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(133, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(133, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "E-mail "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Symbol", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(43, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 37)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Sign In"
        '
        'Label6
        '
        Me.Label6.Image = Global.TestApplication.My.Resources.Resources.mail_FILL0_wght400_GRAD0_opsz24
        Me.Label6.Location = New System.Drawing.Point(107, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 22)
        Me.Label6.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Image = Global.TestApplication.My.Resources.Resources.lock_FILL0_wght400_GRAD0_opsz241
        Me.Label5.Location = New System.Drawing.Point(107, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 22)
        Me.Label5.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Image = Global.TestApplication.My.Resources.Resources.person_FILL0_wght400_GRAD0_opsz24
        Me.Label4.Location = New System.Drawing.Point(107, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 23)
        Me.Label4.TabIndex = 8
        '
        'Cancel_btn
        '
        Me.Cancel_btn.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Cancel_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_btn.Image = Global.TestApplication.My.Resources.Resources.dangerous_FILL0_wght400_GRAD0_opsz24
        Me.Cancel_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cancel_btn.Location = New System.Drawing.Point(283, 279)
        Me.Cancel_btn.Name = "Cancel_btn"
        Me.Cancel_btn.Size = New System.Drawing.Size(87, 29)
        Me.Cancel_btn.TabIndex = 4
        Me.Cancel_btn.Text = "Cancel"
        Me.Cancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel_btn.UseVisualStyleBackColor = False
        '
        'signin_btn
        '
        Me.signin_btn.BackColor = System.Drawing.Color.PaleVioletRed
        Me.signin_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signin_btn.Image = Global.TestApplication.My.Resources.Resources.login_FILL0_wght400_GRAD0_opsz24
        Me.signin_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.signin_btn.Location = New System.Drawing.Point(152, 279)
        Me.signin_btn.Name = "signin_btn"
        Me.signin_btn.Size = New System.Drawing.Size(89, 29)
        Me.signin_btn.TabIndex = 3
        Me.signin_btn.Text = "Sign-up "
        Me.signin_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.signin_btn.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkMagenta
        Me.ClientSize = New System.Drawing.Size(576, 365)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel_btn)
        Me.Controls.Add(Me.signin_btn)
        Me.Controls.Add(Me.email_txtbox)
        Me.Controls.Add(Me.password_txtbox)
        Me.Controls.Add(Me.username_txtbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign in"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents username_txtbox As TextBox
    Friend WithEvents password_txtbox As TextBox
    Friend WithEvents email_txtbox As TextBox
    Friend WithEvents signin_btn As Button
    Friend WithEvents Cancel_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class

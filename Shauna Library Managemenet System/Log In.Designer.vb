<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLogIn = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(411, 217)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(277, 36)
        Me.txtPassword.TabIndex = 12
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(411, 165)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(277, 36)
        Me.txtUsername.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(276, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 30)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(265, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 30)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(273, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(483, 47)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Library Management System"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Shauna_Library_Managemenet_System.My.Resources.Resources.book_pic
        Me.PictureBox2.Location = New System.Drawing.Point(9, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(261, 234)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(573, 277)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(115, 39)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnLogIn
        '
        Me.btnLogIn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.Image = CType(resources.GetObject("btnLogIn.Image"), System.Drawing.Image)
        Me.btnLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogIn.Location = New System.Drawing.Point(411, 277)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(115, 39)
        Me.btnLogIn.TabIndex = 13
        Me.btnLogIn.Text = "Login"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(780, 367)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class

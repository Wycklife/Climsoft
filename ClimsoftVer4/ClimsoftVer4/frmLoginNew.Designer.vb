<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoginNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginNew))
        Me.chkRememberUsername = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.lblDbdetails = New System.Windows.Forms.Label()
        Me.cmbDatabases = New System.Windows.Forms.ComboBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkRememberUsername
        '
        Me.chkRememberUsername.AutoSize = True
        Me.chkRememberUsername.Location = New System.Drawing.Point(221, 113)
        Me.chkRememberUsername.Name = "chkRememberUsername"
        Me.chkRememberUsername.Size = New System.Drawing.Size(126, 17)
        Me.chkRememberUsername.TabIndex = 23
        Me.chkRememberUsername.Text = "Remember username"
        Me.chkRememberUsername.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Tag = "Password"
        Me.Label1.Text = "&Database"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdHelp
        '
        Me.cmdHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdHelp.Location = New System.Drawing.Point(446, 219)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(67, 23)
        Me.cmdHelp.TabIndex = 21
        Me.cmdHelp.Tag = "Help"
        Me.cmdHelp.Text = "&Help"
        Me.cmdHelp.Visible = False
        '
        'lblDbdetails
        '
        Me.lblDbdetails.AutoSize = True
        Me.lblDbdetails.ForeColor = System.Drawing.Color.Blue
        Me.lblDbdetails.Location = New System.Drawing.Point(219, 187)
        Me.lblDbdetails.Name = "lblDbdetails"
        Me.lblDbdetails.Size = New System.Drawing.Size(154, 13)
        Me.lblDbdetails.TabIndex = 20
        Me.lblDbdetails.Tag = ""
        Me.lblDbdetails.Text = "Manage database connections"
        '
        'cmbDatabases
        '
        Me.cmbDatabases.BackColor = System.Drawing.SystemColors.Menu
        Me.cmbDatabases.FormattingEnabled = True
        Me.cmbDatabases.Location = New System.Drawing.Point(219, 162)
        Me.cmbDatabases.Name = "cmbDatabases"
        Me.cmbDatabases.Size = New System.Drawing.Size(222, 21)
        Me.cmbDatabases.TabIndex = 19
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(343, 219)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(67, 23)
        Me.Cancel.TabIndex = 18
        Me.Cancel.Tag = "Cancel"
        Me.Cancel.Text = "&Cancel"
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(240, 219)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(67, 23)
        Me.OK.TabIndex = 17
        Me.OK.Tag = "OK"
        Me.OK.Text = "&OK"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(221, 81)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(220, 20)
        Me.txtPassword.TabIndex = 16
        Me.txtPassword.Tag = ""
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(221, 31)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(220, 20)
        Me.txtUsername.TabIndex = 14
        Me.txtUsername.Tag = ""
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(219, 61)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 15
        Me.lblPassword.Tag = "Password"
        Me.lblPassword.Text = "&Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(219, 11)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 12
        Me.lblUsername.Tag = "Username"
        Me.lblUsername.Text = "&Username"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(1, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(199, 251)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 13
        Me.LogoPictureBox.TabStop = False
        '
        'frmLoginNew
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(539, 251)
        Me.Controls.Add(Me.chkRememberUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.lblDbdetails)
        Me.Controls.Add(Me.cmbDatabases)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoginNew"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Login"
        Me.Text = "Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkRememberUsername As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdHelp As Button
    Friend WithEvents lblDbdetails As Label
    Friend WithEvents cmbDatabases As ComboBox
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents LogoPictureBox As PictureBox
End Class

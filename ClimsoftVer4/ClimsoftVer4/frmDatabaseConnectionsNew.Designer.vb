﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabaseConnectionsNew
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.grpCurrentSelection = New System.Windows.Forms.GroupBox()
        Me.btnMakeDefault = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.grpDefaults = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dataGridConnections = New System.Windows.Forms.DataGridView()
        Me.connection = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.server = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.database = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.port = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpCurrentSelection.SuspendLayout()
        Me.grpDefaults.SuspendLayout()
        CType(Me.dataGridConnections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(476, 315)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'grpCurrentSelection
        '
        Me.grpCurrentSelection.Controls.Add(Me.btnMakeDefault)
        Me.grpCurrentSelection.Controls.Add(Me.btnTest)
        Me.grpCurrentSelection.Controls.Add(Me.btnRemove)
        Me.grpCurrentSelection.Enabled = False
        Me.grpCurrentSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCurrentSelection.Location = New System.Drawing.Point(476, 194)
        Me.grpCurrentSelection.Name = "grpCurrentSelection"
        Me.grpCurrentSelection.Size = New System.Drawing.Size(156, 115)
        Me.grpCurrentSelection.TabIndex = 11
        Me.grpCurrentSelection.TabStop = False
        Me.grpCurrentSelection.Text = "Current selection"
        '
        'btnMakeDefault
        '
        Me.btnMakeDefault.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakeDefault.Location = New System.Drawing.Point(21, 23)
        Me.btnMakeDefault.Name = "btnMakeDefault"
        Me.btnMakeDefault.Size = New System.Drawing.Size(117, 23)
        Me.btnMakeDefault.TabIndex = 5
        Me.btnMakeDefault.Text = "Make default"
        Me.btnMakeDefault.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Enabled = False
        Me.btnTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.Location = New System.Drawing.Point(21, 52)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(117, 23)
        Me.btnTest.TabIndex = 4
        Me.btnTest.Text = "Test connection"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(21, 81)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(117, 23)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove connection"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'grpDefaults
        '
        Me.grpDefaults.Controls.Add(Me.Label10)
        Me.grpDefaults.Controls.Add(Me.Label9)
        Me.grpDefaults.Controls.Add(Me.Label8)
        Me.grpDefaults.Controls.Add(Me.Label7)
        Me.grpDefaults.Controls.Add(Me.Label4)
        Me.grpDefaults.Controls.Add(Me.Label5)
        Me.grpDefaults.Controls.Add(Me.Label6)
        Me.grpDefaults.Controls.Add(Me.Label3)
        Me.grpDefaults.Controls.Add(Me.Label2)
        Me.grpDefaults.Controls.Add(Me.Label1)
        Me.grpDefaults.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDefaults.Location = New System.Drawing.Point(5, 194)
        Me.grpDefaults.Name = "grpDefaults"
        Me.grpDefaults.Size = New System.Drawing.Size(465, 144)
        Me.grpDefaults.TabIndex = 12
        Me.grpDefaults.TabStop = False
        Me.grpDefaults.Text = "Example connections"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(173, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "MariaDB default"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(173, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "MySQL default"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(121, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "3308"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(121, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "mariadb_climsoft_test_db_v4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(121, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "3306"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(121, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "mariadb_climsoft_db_v4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(121, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "127.0.0.1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Port number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Database name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server address"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(557, 315)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dataGridConnections
        '
        Me.dataGridConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridConnections.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.connection, Me.server, Me.database, Me.port, Me.username, Me.password})
        Me.dataGridConnections.Location = New System.Drawing.Point(5, 6)
        Me.dataGridConnections.MultiSelect = False
        Me.dataGridConnections.Name = "dataGridConnections"
        Me.dataGridConnections.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataGridConnections.Size = New System.Drawing.Size(811, 181)
        Me.dataGridConnections.TabIndex = 9
        '
        'connection
        '
        Me.connection.HeaderText = "Connection Name"
        Me.connection.Name = "connection"
        Me.connection.Width = 150
        '
        'server
        '
        Me.server.HeaderText = "Server Address"
        Me.server.Name = "server"
        Me.server.Width = 150
        '
        'database
        '
        Me.database.HeaderText = "Database Name"
        Me.database.Name = "database"
        Me.database.Width = 200
        '
        'port
        '
        Me.port.HeaderText = "Port Number"
        Me.port.Name = "port"
        Me.port.Width = 60
        '
        'username
        '
        Me.username.HeaderText = "Database Username"
        Me.username.Name = "username"
        '
        'password
        '
        Me.password.HeaderText = "Database Password"
        Me.password.Name = "password"
        '
        'frmDatabaseConnectionsNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 342)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpCurrentSelection)
        Me.Controls.Add(Me.grpDefaults)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dataGridConnections)
        Me.MinimizeBox = False
        Me.Name = "frmDatabaseConnectionsNew"
        Me.Text = "Database Connections"
        Me.grpCurrentSelection.ResumeLayout(False)
        Me.grpDefaults.ResumeLayout(False)
        Me.grpDefaults.PerformLayout()
        CType(Me.dataGridConnections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents grpCurrentSelection As GroupBox
    Friend WithEvents btnMakeDefault As Button
    Friend WithEvents btnTest As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents grpDefaults As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents dataGridConnections As DataGridView
    Friend WithEvents connection As DataGridViewTextBoxColumn
    Friend WithEvents server As DataGridViewTextBoxColumn
    Friend WithEvents database As DataGridViewTextBoxColumn
    Friend WithEvents port As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents password As DataGridViewTextBoxColumn
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrValueFlagPeriodNew
    Inherits ClimsoftVer4.ucrValue

    'UserControl overrides dispose to clean up the component list.
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
        Me.ucrValue = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrPeriod = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrFlag = New ClimsoftVer4.ucrTextBoxNew()
        Me.SuspendLayout()
        '
        'ucrValue
        '
        Me.ucrValue.Location = New System.Drawing.Point(0, 3)
        Me.ucrValue.Name = "ucrValue"
        Me.ucrValue.Size = New System.Drawing.Size(55, 23)
        Me.ucrValue.TabIndex = 0
        Me.ucrValue.TextboxValue = ""
        '
        'ucrPeriod
        '
        Me.ucrPeriod.Location = New System.Drawing.Point(92, 3)
        Me.ucrPeriod.Name = "ucrPeriod"
        Me.ucrPeriod.Size = New System.Drawing.Size(35, 23)
        Me.ucrPeriod.TabIndex = 3
        Me.ucrPeriod.TextboxValue = ""
        '
        'ucrFlag
        '
        Me.ucrFlag.Location = New System.Drawing.Point(59, 3)
        Me.ucrFlag.Name = "ucrFlag"
        Me.ucrFlag.Size = New System.Drawing.Size(29, 23)
        Me.ucrFlag.TabIndex = 5
        Me.ucrFlag.TextboxValue = ""
        '
        'ucrValueFlagPeriodNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrFlag)
        Me.Controls.Add(Me.ucrPeriod)
        Me.Controls.Add(Me.ucrValue)
        Me.Name = "ucrValueFlagPeriodNew"
        Me.Size = New System.Drawing.Size(130, 23)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrValue As ucrTextBoxNew
    Friend WithEvents ucrPeriod As ucrTextBoxNew
    Friend WithEvents ucrFlag As ucrTextBoxNew
End Class

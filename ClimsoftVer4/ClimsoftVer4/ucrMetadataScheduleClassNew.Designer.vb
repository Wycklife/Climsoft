<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrMetadataScheduleClassNew
    Inherits ClimsoftVer4.ucrPage

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
        Me.lblScheduleClass = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.ucrTextBoxNewClass = New ClimsoftVer4.ucrTextBoxNew()
        Me.lblStationID = New System.Windows.Forms.Label()
        Me.ucrStationSelector = New ClimsoftVer4.ucrComboboxNew()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.ucrTextBoxNewDescription = New ClimsoftVer4.ucrTextBoxNew()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.ucrNavigatorScheduleClass = New ClimsoftVer4.ucrNavigator()
        Me.ucrBtnDelete = New ClimsoftVer4.ucrButton()
        Me.ucrBtnClear = New ClimsoftVer4.ucrButton()
        Me.ucrBtnView = New ClimsoftVer4.ucrButton()
        Me.ucrBtnAddNew = New ClimsoftVer4.ucrButton()
        Me.ucrBtnUpdate = New ClimsoftVer4.ucrButton()
        Me.ucrBtnSave = New ClimsoftVer4.ucrButton()
        Me.GroupBox13.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblScheduleClass
        '
        Me.lblScheduleClass.AutoSize = True
        Me.lblScheduleClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheduleClass.Location = New System.Drawing.Point(257, 20)
        Me.lblScheduleClass.Name = "lblScheduleClass"
        Me.lblScheduleClass.Size = New System.Drawing.Size(116, 16)
        Me.lblScheduleClass.TabIndex = 1
        Me.lblScheduleClass.Text = "Schedule Class"
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(206, 96)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(32, 13)
        Me.lblClass.TabIndex = 2
        Me.lblClass.Text = "Class"
        '
        'ucrTextBoxNewClass
        '
        Me.ucrTextBoxNewClass.Location = New System.Drawing.Point(270, 96)
        Me.ucrTextBoxNewClass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrTextBoxNewClass.Name = "ucrTextBoxNewClass"
        Me.ucrTextBoxNewClass.Size = New System.Drawing.Size(154, 20)
        Me.ucrTextBoxNewClass.TabIndex = 3
        Me.ucrTextBoxNewClass.TextboxValue = ""
        '
        'lblStationID
        '
        Me.lblStationID.AutoSize = True
        Me.lblStationID.Location = New System.Drawing.Point(206, 133)
        Me.lblStationID.Name = "lblStationID"
        Me.lblStationID.Size = New System.Drawing.Size(54, 13)
        Me.lblStationID.TabIndex = 4
        Me.lblStationID.Text = "Station ID"
        '
        'ucrStationSelector
        '
        Me.ucrStationSelector.Location = New System.Drawing.Point(270, 133)
        Me.ucrStationSelector.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrStationSelector.Name = "ucrStationSelector"
        Me.ucrStationSelector.Size = New System.Drawing.Size(154, 24)
        Me.ucrStationSelector.TabIndex = 5
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(206, 176)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 6
        Me.lblDescription.Text = "Description"
        '
        'ucrTextBoxNewDescription
        '
        Me.ucrTextBoxNewDescription.Location = New System.Drawing.Point(270, 176)
        Me.ucrTextBoxNewDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrTextBoxNewDescription.Name = "ucrTextBoxNewDescription"
        Me.ucrTextBoxNewDescription.Size = New System.Drawing.Size(154, 20)
        Me.ucrTextBoxNewDescription.TabIndex = 7
        Me.ucrTextBoxNewDescription.TextboxValue = ""
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.ucrBtnDelete)
        Me.GroupBox13.Controls.Add(Me.ucrBtnClear)
        Me.GroupBox13.Controls.Add(Me.ucrBtnView)
        Me.GroupBox13.Controls.Add(Me.ucrBtnAddNew)
        Me.GroupBox13.Controls.Add(Me.ucrBtnUpdate)
        Me.GroupBox13.Controls.Add(Me.ucrBtnSave)
        Me.GroupBox13.Location = New System.Drawing.Point(6, 277)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(614, 34)
        Me.GroupBox13.TabIndex = 8
        Me.GroupBox13.TabStop = False
        '
        'ucrNavigatorScheduleClass
        '
        Me.ucrNavigatorScheduleClass.Location = New System.Drawing.Point(147, 319)
        Me.ucrNavigatorScheduleClass.Name = "ucrNavigatorScheduleClass"
        Me.ucrNavigatorScheduleClass.Size = New System.Drawing.Size(336, 25)
        Me.ucrNavigatorScheduleClass.TabIndex = 9
        '
        'ucrBtnDelete
        '
        Me.ucrBtnDelete.ActionTypeId = 0
        Me.ucrBtnDelete.ButtonText = "Delete"
        Me.ucrBtnDelete.Location = New System.Drawing.Point(314, 5)
        Me.ucrBtnDelete.Name = "ucrBtnDelete"
        Me.ucrBtnDelete.Size = New System.Drawing.Size(81, 27)
        Me.ucrBtnDelete.TabIndex = 77
        '
        'ucrBtnClear
        '
        Me.ucrBtnClear.ActionTypeId = 0
        Me.ucrBtnClear.ButtonText = "Clear"
        Me.ucrBtnClear.Location = New System.Drawing.Point(412, 5)
        Me.ucrBtnClear.Name = "ucrBtnClear"
        Me.ucrBtnClear.Size = New System.Drawing.Size(81, 27)
        Me.ucrBtnClear.TabIndex = 79
        '
        'ucrBtnView
        '
        Me.ucrBtnView.ActionTypeId = 0
        Me.ucrBtnView.ButtonText = "View"
        Me.ucrBtnView.Location = New System.Drawing.Point(510, 5)
        Me.ucrBtnView.Name = "ucrBtnView"
        Me.ucrBtnView.Size = New System.Drawing.Size(81, 27)
        Me.ucrBtnView.TabIndex = 76
        '
        'ucrBtnAddNew
        '
        Me.ucrBtnAddNew.ActionTypeId = 0
        Me.ucrBtnAddNew.ButtonText = "AddNew"
        Me.ucrBtnAddNew.Location = New System.Drawing.Point(20, 5)
        Me.ucrBtnAddNew.Name = "ucrBtnAddNew"
        Me.ucrBtnAddNew.Size = New System.Drawing.Size(81, 27)
        Me.ucrBtnAddNew.TabIndex = 80
        '
        'ucrBtnUpdate
        '
        Me.ucrBtnUpdate.ActionTypeId = 0
        Me.ucrBtnUpdate.ButtonText = "Update"
        Me.ucrBtnUpdate.Location = New System.Drawing.Point(216, 5)
        Me.ucrBtnUpdate.Name = "ucrBtnUpdate"
        Me.ucrBtnUpdate.Size = New System.Drawing.Size(81, 27)
        Me.ucrBtnUpdate.TabIndex = 75
        '
        'ucrBtnSave
        '
        Me.ucrBtnSave.ActionTypeId = 0
        Me.ucrBtnSave.ButtonText = "Save"
        Me.ucrBtnSave.Location = New System.Drawing.Point(118, 5)
        Me.ucrBtnSave.Name = "ucrBtnSave"
        Me.ucrBtnSave.Size = New System.Drawing.Size(81, 27)
        Me.ucrBtnSave.TabIndex = 78
        '
        'ucrMetadataScheduleClassNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrNavigatorScheduleClass)
        Me.Controls.Add(Me.GroupBox13)
        Me.Controls.Add(Me.ucrTextBoxNewDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.ucrStationSelector)
        Me.Controls.Add(Me.lblStationID)
        Me.Controls.Add(Me.ucrTextBoxNewClass)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.lblScheduleClass)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ucrMetadataScheduleClassNew"
        Me.Size = New System.Drawing.Size(630, 349)
        Me.GroupBox13.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblScheduleClass As Label
    Friend WithEvents lblClass As Label
    Friend WithEvents ucrTextBoxNewClass As ucrTextBoxNew
    Friend WithEvents lblStationID As Label
    Friend WithEvents ucrStationSelector As ucrComboboxNew
    Friend WithEvents lblDescription As Label
    Friend WithEvents ucrTextBoxNewDescription As ucrTextBoxNew
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents ucrNavigatorScheduleClass As ucrNavigator
    Friend WithEvents ucrBtnDelete As ucrButton
    Friend WithEvents ucrBtnClear As ucrButton
    Friend WithEvents ucrBtnView As ucrButton
    Friend WithEvents ucrBtnAddNew As ucrButton
    Friend WithEvents ucrBtnUpdate As ucrButton
    Friend WithEvents ucrBtnSave As ucrButton
End Class

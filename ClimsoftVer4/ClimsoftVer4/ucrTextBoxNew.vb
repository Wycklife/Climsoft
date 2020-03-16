﻿Public Class ucrTextBoxNew
    Protected bIsReadOnly As Boolean = False

    Protected dcmMinimum As Decimal = Decimal.MinValue
    Protected dcmMaximum As Decimal = Decimal.MaxValue
    Protected bMinimumIncluded, bMaximumIncluded As Boolean
    Protected Overridable Sub ucrTextBox_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            strValidationType = ClsGlobals.EnumValidationType.None
            bFirstLoad = False
        End If
    End Sub

    Private Sub ucrTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBox.KeyDown
        OnevtKeyDown(Me, e)
    End Sub

    Private Sub ucrTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtBox.TextChanged
        'check if value is valid
        ValidateValue()
        'raise event
        OnevtTextChanged(Me, e)
    End Sub

    Private Sub ucrTextBox_Leave(sender As Object, e As EventArgs) Handles txtBox.Leave
        OnevtValueChanged(Me, e)
    End Sub

    Public Overrides Sub UpdateValueChoices()
        If Not bFirstLoad Then
            MyBase.UpdateValueChoices()
            'TODO datastructure required here for this check
            'If dtbRecords.Rows.Count > 1 Then
            '    MessageBox.Show("Developer error: More than one value found for: " & Me.Name & ". A textbox should be linked to a single record. " & dtbRecords.Rows.Count & " records found.", caption:="Developer error")
            'ElseIf dtbRecords.Columns.Count <> 1 Then
            '    MessageBox.Show("Developer error: A textbox must have exactly one field set. Control: " & Me.Name & "has " & dtbRecords.Columns.Count & " fields.", caption:="Developer error")
            'Else
            '    'TODO
            '    'SetValue(If(dtbRecords.Rows.Count = 0, "", dtbRecords.Rows(0).Field(Of String)(columnIndex:=0)))
            'End If
        End If
    End Sub
    Public Overrides Sub SetValueFromDataStructure()
        'todo. reads value from the datastructure
    End Sub

    Public Overrides Sub SetValueToDataStructure()
        'todo. writes value to the datastructure
    End Sub

    ''' <summary>
    ''' Returns the value of the textbox
    ''' </summary>
    ''' <param name="objSpecification"></param>
    ''' <returns></returns>
    Public Overrides Function GetValue(Optional objSpecification As Object = Nothing) As Object
        If String.IsNullOrEmpty(txtBox.Text) Then
            'Return DBNull.Value
            Return Nothing
        Else
            Return txtBox.Text
        End If
    End Function

    Public Overrides Sub SetValue(objNewValue As Object)
        If IsDBNull(objNewValue) OrElse IsNothing(objNewValue) Then
            txtBox.Text = ""
        Else
            txtBox.Text = objNewValue
        End If
        OnevtValueChanged(Me, Nothing)
    End Sub

    ' TODO This can now be removed once the forms using it in the deisigners have been fixed.
    Public Property TextboxValue() As String
        Get
            Return txtBox.Text
        End Get
        Set(ByVal strValue As String)
            txtBox.Text = strValue
        End Set
    End Property

    Public Sub SetTextToUpper()
        txtBox.CharacterCasing = CharacterCasing.Upper
    End Sub

    Public Sub SetTextToLower()
        txtBox.CharacterCasing = CharacterCasing.Lower
    End Sub

    Public Sub SetTextToNormal()
        txtBox.CharacterCasing = CharacterCasing.Normal
    End Sub

    ''' <summary>
    ''' Sets validation of the textbox to none
    ''' </summary>
    Public Sub SetValidationTypeAsNone()
        strValidationType = ClsGlobals.EnumValidationType.None
    End Sub

    Public Sub SetValidationTypeAsFlag()
        strValidationType = ClsGlobals.EnumValidationType.Flag
    End Sub


    ''' <summary>
    ''' Sets validation of the textbox to numeric
    ''' </summary>
    ''' <param name="dcmMin"></param>
    ''' <param name="bIncludeMin"></param>
    ''' <param name="dcmMax"></param>
    ''' <param name="bIncludeMax"></param>
    Public Sub SetValidationTypeAsNumeric(Optional dcmMin As Decimal = Decimal.MinValue, Optional bIncludeMin As Boolean = True, Optional dcmMax As Decimal = Decimal.MaxValue, Optional bIncludeMax As Boolean = True)
        strValidationType = ClsGlobals.EnumValidationType.Numeric
        If dcmMin <> Decimal.MinValue Then
            dcmMinimum = dcmMin
            bMinimumIncluded = bIncludeMin
        End If
        If dcmMax <> Decimal.MaxValue Then
            dcmMaximum = dcmMax
            bMaximumIncluded = bIncludeMax
        End If
    End Sub

    Public Sub SetMinimumValue(dcmMin As Decimal)
        strValidationType = ClsGlobals.EnumValidationType.Numeric
        dcmMinimum = dcmMin
        bMinimumIncluded = True
    End Sub

    Public Sub SetMaximumValue(dcmMax As Decimal)
        strValidationType = ClsGlobals.EnumValidationType.Numeric
        dcmMaximum = dcmMax
        bMaximumIncluded = True
    End Sub


    Public Overrides Function ValidateValue() As Boolean
        Dim iType As Integer

        If bValidate Then
            'if set to not validate empty values and textbox is empty then don't proceed with validation
            If Not bValidateEmpty AndAlso IsEmpty() Then
                SetBackColor(clValidColor)
                Return True
            ElseIf bValidateEmpty AndAlso IsEmpty() Then
                SetBackColor(clInValidColor)
                Return False
            End If

            iType = GetValidationCode(txtBox.Text)

            'TODO. CHANGE THIS IMPLEMENTATION. THE VALIDATION TYPE SHOULD DICTATE THE VALIDATION CODE. WE NEED TO CHECK ON THE VALIDATION TYPE BEFORE VALIDATION CODE
            If iType = 0 Then
                SetBackColor(clValidColor)
            ElseIf iType = 1 Then
                SetBackColor(Color.Red)
                If Not bValidateSilently Then
                    MessageBox.Show("Number expected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            ElseIf iType = 2 Then
                'check if it was lower and upper limit violation
                If Not (GetDcmMinimum() <= Val(GetValue)) Then
                    SetBackColor(Color.Cyan)
                    If Not bValidateSilently Then
                        MessageBox.Show("Value lower than lowerlimit of: " & GetDcmMinimum(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                ElseIf Not (GetDcmMaximum() >= Val(GetValue)) Then
                    SetBackColor(Color.Cyan)
                    If Not bValidateSilently Then
                        MessageBox.Show("Value higher than upperlimit of: " & GetDcmMaximum(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            ElseIf iType = 3 Then
                SetBackColor(Color.Red)
                If Not bValidateSilently Then
                    MessageBox.Show("Correct Flag expected! Flags allowed are: M (Missing), T (Trace), E (Estimated), G (Generated), D (Dubious)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            Return (iType = 0)
        Else
            Return True
        End If
    End Function

    Public Function GetValidationCode(strText As String) As Integer
        Dim iType As Integer
        Select Case strValidationType
            Case ClsGlobals.EnumValidationType.None
                iType = 0
            Case ClsGlobals.EnumValidationType.Numeric
                iType = ValidateNumeric(strText)
            Case ClsGlobals.EnumValidationType.Flag
                iType = ValidateFlag(strText)
        End Select
        Return iType
    End Function

    'Returns integer as code for validation
    ' 0 : string is valid
    ' 1 : string is not numeric
    ' 2 : string is outside range
    Private Function ValidateNumeric(strText As String) As Integer
        Dim dcmText As Decimal
        Dim iType As Integer = 0

        If strText <> "" Then
            If Not IsNumeric(strText) Then
                iType = 1
            Else
                dcmText = Convert.ToDecimal(strText)
                If (dcmText < dcmMinimum) OrElse (dcmText > dcmMaximum) OrElse (Not bMinimumIncluded And dcmText <= dcmMinimum) OrElse (Not bMaximumIncluded And dcmText >= dcmMaximum) Then
                    iType = 2
                End If
            End If
        Else
            iType = 1
        End If
        Return iType
    End Function

    Private Function ValidateFlag(strText As String) As Integer
        Dim iType As Integer
        Dim strNewText As String = strText.ToUpper
        If strNewText = "M" OrElse strNewText = "T" OrElse strNewText = "E" OrElse strNewText = "G" OrElse strNewText = "D" Then
            iType = 0
        Else
            iType = 3
        End If
        Return iType
    End Function

    ''' <summary>
    ''' Returns the numeric range for the control
    ''' </summary>
    ''' <returns></returns>
    Public Function GetNumericRange() As String
        Dim strRange As String = ""
        If strValidationType = "numeric" Then
            If dcmMinimum <> Decimal.MinValue Then
                If bMinimumIncluded Then
                    strRange = ">= " & dcmMinimum.ToString()
                Else
                    strRange = "> " & dcmMinimum.ToString()
                End If
                If dcmMaximum <> Decimal.MaxValue Then
                    strRange = strRange & " and "
                End If
            End If
            If dcmMaximum <> Decimal.MaxValue Then
                If bMaximumIncluded Then
                    strRange = strRange & "<= " & dcmMaximum.ToString()
                Else
                    strRange = strRange & "< " & dcmMaximum.ToString()
                End If
            End If
        End If
        Return strRange
    End Function

    ''' <summary>
    ''' Returns the minimum decimal number for the control
    ''' </summary>
    ''' <returns></returns>
    Public Function GetDcmMinimum() As Decimal
        Return dcmMinimum
    End Function
    ''' <summary>
    ''' Returns the maximum decimal number for the control
    ''' </summary>
    ''' <returns></returns>
    Public Function GetDcmMaximum() As Decimal
        Return dcmMaximum
    End Function

    ''' <summary>
    ''' Sets the focus to the control 
    ''' </summary>
    Public Overrides Sub GetFocus()
        txtBox.Focus()
    End Sub

    ''' <summary>
    ''' Checks if a textbox is empty
    ''' Returns true when text box is empty
    ''' </summary>
    ''' <returns></returns>

    Public Overrides Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(txtBox.Text)
    End Function

    ''' <summary>
    ''' Clears contents of the textbox
    ''' </summary>
    Public Overrides Sub Clear()
        'todo. clear the control ?
        SetValue("")
        SetBackColor(clValidColor)

    End Sub

    Public Overrides Sub SetBackColor(backColor As Color)
        txtBox.BackColor = backColor
    End Sub

    Public Overrides Sub SetAsReadOnly()
        txtBox.ReadOnly = True
    End Sub

    'Sets the size of the textbox in the control
    Public Sub SetSize(Size As Point)
        'txtBox.Size = New Size(Size)
        Me.Size = New Size(Size)
    End Sub

    Public Overrides Sub SetContextMenuStrip(contextMenuStrip As ContextMenuStrip)
        txtBox.ContextMenuStrip = contextMenuStrip
    End Sub
End Class

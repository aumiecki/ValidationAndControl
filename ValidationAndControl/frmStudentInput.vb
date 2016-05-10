Public Class frmStudentInput
    ' Clear form and focus cursor on Student ID
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStudentId.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtBalance.Clear()

        theAddress.Clear()

        txtStudentId.Focus()
    End Sub

    ' Set all of Student information and create Student object on the output form
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim aStudent As New Student
        aStudent.setFirstName(txtFirstName.Text)
        aStudent.setLastName(txtLastName.Text)
        aStudent.setStudentId(txtStudentId.Text)
        aStudent.setBalance(Double.Parse(txtBalance.Text))

        aStudent.HomeAddress = theAddress.getAddress()

        If theAddress.ValidateChildren And Me.ValidateChildren Then
            Dim outputForm As New frmOutput(aStudent)
            outputForm.ShowDialog()
        End If
    End Sub

    ' Exit application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        System.Environment.Exit(0)
    End Sub

    Private Sub txtStudentId_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtStudentId.Validating
        If (txtStudentId.Text.Length = 0) Then
            e.Cancel = True
            MainError.SetError(txtStudentId, "Student ID cannot be blank")
        Else
            e.Cancel = False
            MainError.SetError(txtStudentId, "")
        End If
    End Sub

    Private Sub txtFirstName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFirstName.Validating
        If (txtFirstName.Text.Length = 0) Then
            e.Cancel = True
            MainError.SetError(txtFirstName, "First Name cannot be blank")
        Else
            e.Cancel = False
            MainError.SetError(txtFirstName, "")
        End If
    End Sub

    Private Sub txtLastName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtLastName.Validating
        If (txtLastName.Text.Length = 0) Then
            e.Cancel = True
            MainError.SetError(txtLastName, "Last Name cannot be blank")
        Else
            e.Cancel = False
            MainError.SetError(txtLastName, "")
        End If
    End Sub

    Private Sub txtBalance_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtBalance.Validating
        Dim temp As Double

        If Not Double.TryParse(txtBalance.Text, temp) Then
            e.Cancel = True
            MainError.SetError(txtBalance, "Not a valid number")
        Else
            e.Cancel = False
            MainError.SetError(txtBalance, "")
        End If
    End Sub

    Private Sub frmStudentInput_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = False
    End Sub
End Class

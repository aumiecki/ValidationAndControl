Public Class frmOutput
    Public Sub New(StudentRecord As Student)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If StudentRecord.HomeAddress.getStreet2 = "" Then
            txtOutput.Text = "Student ID: " & StudentRecord.getStudentId & Environment.NewLine &
            "Name: " & StudentRecord.getLastName & ", " & StudentRecord.getFirstName & Environment.NewLine &
            "Balance:" & FormatCurrency(StudentRecord.getBalance.ToString) & Environment.NewLine &
            "Address: " & Environment.NewLine &
            StudentRecord.HomeAddress.getStreet1 & Environment.NewLine &
            StudentRecord.HomeAddress.getCity & ", " &
            StudentRecord.HomeAddress.getState & " " &
            StudentRecord.HomeAddress.getZip
        Else
            txtOutput.Text = "Student ID: " & StudentRecord.getStudentId & Environment.NewLine &
        "Name: " & StudentRecord.getLastName & ", " & StudentRecord.getFirstName & Environment.NewLine &
        "Balance:" & FormatCurrency(StudentRecord.getBalance.ToString) & Environment.NewLine &
        "Address: " & Environment.NewLine &
        StudentRecord.HomeAddress.getStreet1 & Environment.NewLine &
        StudentRecord.HomeAddress.getStreet2 & Environment.NewLine &
        StudentRecord.HomeAddress.getCity & ", " &
        StudentRecord.HomeAddress.getState & " " &
        StudentRecord.HomeAddress.getZip
        End If
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close window
        Me.Close()
    End Sub
End Class
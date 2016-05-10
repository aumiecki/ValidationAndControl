Public Class AddressControl
    Public Sub Clear()
        txtStreet1.Clear()
        txtStreet2.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZip.Clear()
    End Sub

    Private Sub txtStreet1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtStreet1.Validating
        If (txtStreet1.Text.Length = 0) Then
            e.Cancel = True
            ErrorHandle.SetError(txtStreet1, "Street1 cannot be blank")
        Else
            e.Cancel = False
            ErrorHandle.SetError(txtStreet1, "")
        End If
    End Sub

    Private Sub txtCity_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCity.Validating
        If (txtCity.Text.Length = 0) Then
            e.Cancel = True
            ErrorHandle.SetError(txtCity, "City cannot be blank")
        Else
            e.Cancel = False
            ErrorHandle.SetError(txtCity, "")
        End If
    End Sub

    Private Sub txtState_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtState.Validating
        If (txtState.Text.Length = 0) Then
            e.Cancel = True
            ErrorHandle.SetError(txtState, "State cannot be blank")
        Else
            e.Cancel = False
            ErrorHandle.SetError(txtState, "")
        End If
    End Sub

    Private Sub txtZip_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtZip.Validating
        If (txtZip.Text.Length = 0) Then
            e.Cancel = True
            ErrorHandle.SetError(txtZip, "Zip Code cannot be blank")
        Else
            e.Cancel = False
            ErrorHandle.SetError(txtZip, "")
        End If
    End Sub

    Public Function getAddress() As Address
        Dim data As New Address

        data.setStreet1(txtStreet1.Text)
        data.setStreet2(txtStreet2.Text)
        data.setCity(txtCity.Text)
        data.setState(txtState.Text)
        data.setZip(txtZip.Text)

        Return data
    End Function
End Class

Public Class Address
    Private Street1 As String
    Private Street2 As String
    Private City As String
    Private State As String
    Private Zip As String

    'Set and Get Address values
    Public Sub setStreet1(value As String)
        Street1 = value
    End Sub

    Public Function getStreet1() As String
        Return Street1
    End Function

    Public Sub setStreet2(value As String)
        Street2 = value
    End Sub

    Public Function getStreet2() As String
        Return Street2
    End Function

    Public Sub setCity(value As String)
        City = value
    End Sub

    Public Function getCity() As String
        Return City
    End Function

    Public Sub setState(value As String)
        State = value
    End Sub

    Public Function getState() As String
        Return State
    End Function

    Public Sub setZip(value As String)
        Zip = value
    End Sub

    Public Function getZip() As String
        Return Zip
    End Function
End Class

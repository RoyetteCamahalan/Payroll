Imports System.Security.Cryptography
Imports System.Text
Public Class Utility

    Enum systemsettings
        All = 0
        MaxBroker = 1
        MaxDirector = 2
        MaxManager = 3
        MaxSalesperson = 4
        MaxSalespersonDownline = 5
        MaxAgentLevel = 6
        ComPercentage = 7
        AdvanceCommission = 8
        CommissionOverTerm = 9
        ReservationDuration = 10
        PaymentTerm = 11
        Interest = 12
        PaymentExtension = 13
        CommissionTerm = 14
    End Enum

    Public Shared Function GetServerDate() As Date
        Dim dt As DataTable = clsMain.Fetch(1, "")
        Return dt.Rows(0).Item(0)
    End Function

    Public Shared Function NullToEmptyString(ByRef input As Object)
        Try
            If IsDBNull(input) Then
                Return ""
            Else
                Return input
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Shared Function GetHash(ByVal theInput As String) As String

        Using hasher As MD5 = MD5.Create()    ' create hash object

            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("x2"))
            Next n

            Return sBuilder.ToString()
        End Using

    End Function
    Public Shared Function convertImage(ByVal imgdata As Byte())
        Dim ImageData(-1) As Byte
        ImageData = CType(imgdata, Byte())
        Dim MemoryStream As New System.IO.MemoryStream(ImageData)
        Dim image As System.Drawing.Image = System.Drawing.Image.FromStream(MemoryStream)
        Return image
    End Function

    Public Shared Function SystemSetting(Optional ByVal setting As systemsettings = systemsettings.All) As Object
        Dim dt As DataTable = clsMain.Fetch(0, "")
        Select Case setting
            Case systemsettings.MaxAgentLevel
                Return dt.Rows(0).Item("maxagentlevel")
            Case systemsettings.MaxBroker
                Return dt.Rows(0).Item("maxbroker")
            Case systemsettings.MaxDirector
                Return dt.Rows(0).Item("maxsalesdirector")
            Case systemsettings.MaxManager
                Return dt.Rows(0).Item("maxsalemanager")
            Case systemsettings.MaxSalesperson
                Return dt.Rows(0).Item("maxsalesperson")
            Case systemsettings.MaxSalespersonDownline
                Return dt.Rows(0).Item("maxsalespersondownline")
            Case systemsettings.ComPercentage
                Return dt.Rows(0).Item("COM_PERCENTAGE")
            Case systemsettings.AdvanceCommission
                Return dt.Rows(0).Item("adcom")
            Case systemsettings.CommissionOverTerm
                Return dt.Rows(0).Item("compercentageoverterm")
            Case systemsettings.ReservationDuration
                Return dt.Rows(0).Item("reservationduration")
            Case systemsettings.PaymentTerm
                Return dt.Rows(0).Item("paymentterm")
            Case systemsettings.Interest
                Return dt.Rows(0).Item("interest")
            Case systemsettings.PaymentExtension
                Return dt.Rows(0).Item("paymentextension")
            Case systemsettings.CommissionTerm
                Return dt.Rows(0).Item("commissionterm")
            Case Else
                Return dt
        End Select
    End Function

End Class

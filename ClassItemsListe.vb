Public Class ClassItemsListe
    Public Property Numlig() As String
    Public Property Index_Items() As String
    Public Property Index_Date() As String
    Public Property Montant() As String
    Public Property PayeOuiNon() As String
    Public Property Mt_Paye() As String
    Public Property AQui() As String
    Public Property FF() As String



    Default Public ReadOnly Property Item(ByVal i As Integer) As String
        Get
            Select Case i
                Case 0
                    Return Numlig
                Case 1
                    Return Index_Items
                Case 2
                    Return Index_Date.ToString
                Case 3
                    Return Montant
                Case 4
                    Return PayeOuiNon
                Case 5
                    Return Mt_Paye
                Case 6
                    Return AQui
                Case 7
                    Return FF
                Case Else
                    Return String.Empty
            End Select
        End Get
    End Property
End Class

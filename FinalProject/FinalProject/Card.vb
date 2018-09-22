Public Class Card
    'Variables
    Private suit As Integer  'Clubs, Hearts, Diamonds, or Spades. Represented by 1 - 4
    Private worth As Integer 'The numeric rank of the card, for comparing to others. Represented by 0 -13

    'Constructor
    Public Sub New(passedSuit As Integer, passedWorth As Integer)
        suit = passedSuit
        worth = passedWorth
    End Sub

    'Properties
    Public Property getSuit()
        Get
            Return suit
        End Get
        Set(value)

        End Set
    End Property

    Public Property getWorth()
        Get
            Return worth
        End Get
        Set(value)

        End Set
    End Property

    'Functions
    Public Function generateImagePath() As String
        Return "Card"&((worth * 4) + suit)
    End Function

    'Used to update the card's suit and worth
    Public Sub changeCard(passedSuit As String, passedWorth As String)
        suit = passedSuit
        worth = passedWorth
    End Sub
End Class
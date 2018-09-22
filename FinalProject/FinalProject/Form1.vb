Public Class Form1
    'Globals
        'For generating suits and values
        Dim RandNumGen As System.Random = New System.Random()

        'Represent the three cards shown to the user
         Dim card1 As card = New Card(CreateSuit(), CreateValue())
         Dim card2 As card = New Card(CreateSuit(), CreateValue())
         Dim card3 As card = New Card(CreateSuit(), CreateValue())

        'To keep track of how many times the "show card" button is pressed
        Dim btnCounter As Integer = 0

    'User Interface Subroutines
        'When the form loads
        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Btn_DepositTokens.Select()
        End Sub

        'When "Deposit tokens" clicked
        Private Sub Btn_DepositTokens_Click(sender As Object, e As EventArgs) Handles Btn_DepositTokens.Click
            Txt_Credits.Text = ((CDec(Val(Txt_Credits.Text) + ((CDec(Val(InputBox("How many tokens would you like to deposit?", "Deposit tokens", 0)))) * 4))))

            If (CDec(Val(Txt_Credits.Text))) >= 4 Then
                Btn_ShowCard.Select()
                Btn_ShowCard.Enabled = True
            End If
        End Sub

        'When "Show card" clicked
        Private Sub Btn_ShowCard_Click(sender As Object, e As EventArgs) Handles Btn_ShowCard.Click
            btnCounter = (btnCounter + 1)
            Dim wagerIncrease As Decimal = 0

            If btnCounter = 1 Then
                Txt_Credits.Text = (Txt_Credits.Text - 4)
                Txt_Wager.Text = 4
                Pic_Card1.Image = My.Resources.ResourceManager.GetObject(card1.generateImagePath())
                Btn_ShowCard.Select()
            Else If btnCounter = 2 Then
                Pic_Card2.Image = My.Resources.ResourceManager.GetObject(card2.generateImagePath())
                wagerIncrease = CDec(Val(InputBox("How many more credits would you like to wager?", "Increase wager?", 0)))
                
                If (card1.getWorth = card2.getWorth) Then
                    If wagerIncrease <= 4
                        Txt_Credits.Text = (CDec(Val(Txt_Credits.Text)) - wagerIncrease)
                        Txt_Wager.Text = (CDec(Val(Txt_Wager.Text)) + wagerIncrease)
                        Btn_ShowCard.Select()
                    End If
                Else
                    If wagerIncrease <= (CDec(Val(Txt_Credits.Text)))
                        Txt_Credits.Text = (CDec(Val(Txt_Credits.Text)) - wagerIncrease)
                        Txt_Wager.Text = (CDec(Val(Txt_Wager.Text)) + wagerIncrease)
                        Btn_ShowCard.Select()
                    End If
                End If

            Else If btnCounter = 3 Then
                Pic_Card3.Image = My.Resources.ResourceManager.GetObject(card3.generateImagePath())
                Btn_ShowCard.Enabled = False
                Btn_NewHand.Enabled = True
                Btn_NewHand.Select()
                PayoutCheck()
            End If
        End Sub

        'When "New hand" clicked
        Private Sub Btn_NewHand_Click(sender As Object, e As EventArgs) Handles Btn_NewHand.Click
            If (CDec(Val(Txt_Credits.Text))) < 4 Then
                MessageBox.Show("You must have a minimum of four credits to play.")
                Txt_Credits.Text = ((CDec(Val(Txt_Credits.Text)) + ((CDec(Val(InputBox("How many tokens would you like to deposit?", "Deposit tokens", 0)))) * 4)))
            End If

            If (CDec(Val(Txt_Credits.Text))) < 4 Then
                MessageBox.Show("Game over!")
                Me.Close()
            End If

            UpdateCard(1)
            UpdateCard(2)
            UpdateCard(3)

            Pic_Card1.Image = My.Resources.ResourceManager.GetObject("Card0")
            Pic_Card2.Image = My.Resources.ResourceManager.GetObject("Card0")
            Pic_Card3.Image = My.Resources.ResourceManager.GetObject("Card0")

            btnCounter = 0

            Txt_Wager.Text = ""
            Btn_ShowCard.Enabled = True
            Btn_ShowCard.Select()
        End Sub

        'When "Show payouts" clicked
        Private Sub Btn_ShowPayouts_Click(sender As Object, e As EventArgs) Handles Btn_ShowPayouts.Click
            MessageBox.Show("Three Card Poker Payouts:" + vbcrlf + vbcrlf +
                            vbTab + "Pair"     + vbTab + vbTab + "1 to 1"  + vbcrlf +
                            vbTab + "Flush"    + vbTab + vbTab + "4 to 1"  + vbcrlf +
                            vbTab + "Straight" + vbTab + vbTab + "5 to 1"  + vbcrlf +
                            vbTab + "Three of a Kind"  + vbTab + "30 to 1" + vbcrlf +
                            vbTab + "Straight Flush"   + vbTab + "40 to 1" + vbcrlf)
        End Sub
    
        'When "Exit" clicked
        Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
            Me.Close()
        End Sub

        'When "Debug" clicked
        Private Sub Btn_Debug_Click(sender As Object, e As EventArgs) Handles Btn_Debug.Click
        MessageBox.Show("Card1: " & card1.getSuit & " " & card1.getWorth & vbcrlf &
                        "Card2: " & card2.getSuit & " " & card2.getWorth & vbcrlf &
                        "Card3: " & card3.getSuit & " " & card3.getWorth & vbcrlf)
        End Sub

    'Program functions
        'Picks a suit, using a random number
        Private Function CreateSuit() As String
            Return RandNumGen.Next(1, 5) '1 to 4
        End Function

        'Picks a value, using a random number
        Private Function CreateValue() As String
            Return RandNumGen.Next(0, 13) '0 to 12
        End Function

        'Gives the appropriate card a new suit and value
        Private Sub UpdateCard(cardNum As Integer)
            If cardNum = 1 Then
                card1.changeCard(CreateSuit(), CreateValue())
            Else If cardNum = 2 Then
                card2.changeCard(CreateSuit(), CreateValue())
            Else If cardNum = 3 Then
                card3.changeCard(CreateSuit(), CreateValue())
            End If
        End Sub
    
        'Checks to see if the current combination of cards merits a payout
        Public Sub PayoutCheck()
            If IsSequential() = True And (card1.getSuit = card2.getSuit) And (card2.getSuit = card3.getSuit) Then
                MessageBox.Show("Congratulations!" + vbcrlf + "Straight flush.")
                AwardPayout(40)

            Else If IsSequential() = True Then
                MessageBox.Show("Congratulations!" + vbcrlf + "Straight.")
                AwardPayout(5)

            Else if (card1.getWorth = card2.GetWorth) And (card2.getWorth = card3.getWorth)
                MessageBox.Show("Congratulations!" + vbcrlf + "Three of a kind.")
                AwardPayout(30)

            Else If (card1.getSuit = card2.getSuit) And (card2.getSuit = card3.getSuit)
                MessageBox.Show("Congratulations!" + vbcrlf + "Flush.")
                AwardPayout(4)

            Else if (card1.getWorth = card2.GetWorth) Or (card1.getWorth = card3.getWorth) Or (card2.getWorth = card3.getWorth)
                MessageBox.Show("Congratulations!" + vbcrlf + "Pair.")
                AwardPayout(1)
            End if
        End Sub
        
        'Awards the user a payout, based on the passed multiplier
        Private Sub AwardPayout(multiplier As integer)
            Txt_Credits.Text = ((CDec(Val(Txt_Credits.Text)) + ((CDec(Val(Txt_Wager.Text)) * multiplier))))
            Txt_Wager.Text = ""
        End Sub
        
        'Determines if the three cards are of sequential value
        Private Function IsSequential() As Boolean
               If (card1.getWorth = (card2.getWorth - 1) And card2.getWorth = (card3.getWorth - 1)) Or   'card1 = (card2 - 1) = (card3 - 1)
                  (card1.getWorth = (card3.getWorth - 1) And card3.getWorth = (card2.getWorth - 1)) Or   'card1 = (card3 - 1) = (card2 - 1)
                  (card2.getWorth = (card3.getWorth - 1) And card3.getWorth = (card1.getWorth - 1)) Or   'card2 = (card3 - 1) = (card1 - 1)
                  (card2.getWorth = (card1.getWorth - 1) And card1.getWorth = (card3.getWorth - 1)) Or   'card2 = (card1 - 1) = (card3 - 1)
                  (card3.getWorth = (card1.getWorth - 1) And card1.getWorth = (card2.getWorth - 1)) Or   'card3 = (card1 - 1) = (card2 - 1)
                  (card3.getWorth = (card2.getWorth - 1) And card2.getWorth = (card1.getWorth - 1)) Then 'card3 = (card2 - 1) = (card1 - 1)
                  Return True
               Else
                   Return False
               End If
        End Function
End Class
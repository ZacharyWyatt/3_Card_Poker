<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Pic_Card1 = New System.Windows.Forms.PictureBox()
        Me.Pic_Card2 = New System.Windows.Forms.PictureBox()
        Me.Pic_Card3 = New System.Windows.Forms.PictureBox()
        Me.Btn_DepositTokens = New System.Windows.Forms.Button()
        Me.Btn_ShowPayouts = New System.Windows.Forms.Button()
        Me.Lbl_Credits = New System.Windows.Forms.Label()
        Me.Txt_Credits = New System.Windows.Forms.TextBox()
        Me.Lbl_Wager = New System.Windows.Forms.Label()
        Me.Txt_Wager = New System.Windows.Forms.TextBox()
        Me.Btn_ShowCard = New System.Windows.Forms.Button()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.Btn_NewHand = New System.Windows.Forms.Button()
        Me.Btn_Debug = New System.Windows.Forms.Button()
        CType(Me.Pic_Card1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Pic_Card2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Pic_Card3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Pic_Card1
        '
        Me.Pic_Card1.Image = Global.FinalProject.My.Resources.Resources.Card0
        Me.Pic_Card1.Location = New System.Drawing.Point(12, 12)
        Me.Pic_Card1.Name = "Pic_Card1"
        Me.Pic_Card1.Size = New System.Drawing.Size(125, 175)
        Me.Pic_Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Card1.TabIndex = 0
        Me.Pic_Card1.TabStop = false
        '
        'Pic_Card2
        '
        Me.Pic_Card2.Image = Global.FinalProject.My.Resources.Resources.Card0
        Me.Pic_Card2.Location = New System.Drawing.Point(159, 12)
        Me.Pic_Card2.Name = "Pic_Card2"
        Me.Pic_Card2.Size = New System.Drawing.Size(125, 175)
        Me.Pic_Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Card2.TabIndex = 1
        Me.Pic_Card2.TabStop = false
        '
        'Pic_Card3
        '
        Me.Pic_Card3.Image = Global.FinalProject.My.Resources.Resources.Card0
        Me.Pic_Card3.Location = New System.Drawing.Point(304, 12)
        Me.Pic_Card3.Name = "Pic_Card3"
        Me.Pic_Card3.Size = New System.Drawing.Size(125, 175)
        Me.Pic_Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Card3.TabIndex = 2
        Me.Pic_Card3.TabStop = false
        '
        'Btn_DepositTokens
        '
        Me.Btn_DepositTokens.Location = New System.Drawing.Point(41, 202)
        Me.Btn_DepositTokens.Name = "Btn_DepositTokens"
        Me.Btn_DepositTokens.Size = New System.Drawing.Size(96, 23)
        Me.Btn_DepositTokens.TabIndex = 1
        Me.Btn_DepositTokens.Text = "Deposit Tokens"
        Me.Btn_DepositTokens.UseVisualStyleBackColor = true
        '
        'Btn_ShowPayouts
        '
        Me.Btn_ShowPayouts.Location = New System.Drawing.Point(188, 202)
        Me.Btn_ShowPayouts.Name = "Btn_ShowPayouts"
        Me.Btn_ShowPayouts.Size = New System.Drawing.Size(96, 23)
        Me.Btn_ShowPayouts.TabIndex = 3
        Me.Btn_ShowPayouts.Text = "Show Payouts"
        Me.Btn_ShowPayouts.UseVisualStyleBackColor = true
        '
        'Lbl_Credits
        '
        Me.Lbl_Credits.AutoSize = true
        Me.Lbl_Credits.Location = New System.Drawing.Point(41, 243)
        Me.Lbl_Credits.Name = "Lbl_Credits"
        Me.Lbl_Credits.Size = New System.Drawing.Size(42, 13)
        Me.Lbl_Credits.TabIndex = 0
        Me.Lbl_Credits.Text = "Credits:"
        '
        'Txt_Credits
        '
        Me.Txt_Credits.Location = New System.Drawing.Point(89, 240)
        Me.Txt_Credits.Name = "Txt_Credits"
        Me.Txt_Credits.ReadOnly = true
        Me.Txt_Credits.Size = New System.Drawing.Size(50, 20)
        Me.Txt_Credits.TabIndex = 0
        Me.Txt_Credits.Text = "0"
        Me.Txt_Credits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_Wager
        '
        Me.Lbl_Wager.AutoSize = true
        Me.Lbl_Wager.Location = New System.Drawing.Point(287, 243)
        Me.Lbl_Wager.Name = "Lbl_Wager"
        Me.Lbl_Wager.Size = New System.Drawing.Size(86, 13)
        Me.Lbl_Wager.TabIndex = 0
        Me.Lbl_Wager.Text = "Credits wagered:"
        '
        'Txt_Wager
        '
        Me.Txt_Wager.Location = New System.Drawing.Point(379, 240)
        Me.Txt_Wager.Name = "Txt_Wager"
        Me.Txt_Wager.ReadOnly = true
        Me.Txt_Wager.Size = New System.Drawing.Size(50, 20)
        Me.Txt_Wager.TabIndex = 0
        Me.Txt_Wager.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_ShowCard
        '
        Me.Btn_ShowCard.Enabled = false
        Me.Btn_ShowCard.Location = New System.Drawing.Point(44, 271)
        Me.Btn_ShowCard.Name = "Btn_ShowCard"
        Me.Btn_ShowCard.Size = New System.Drawing.Size(96, 23)
        Me.Btn_ShowCard.TabIndex = 2
        Me.Btn_ShowCard.Text = "Show Card"
        Me.Btn_ShowCard.UseVisualStyleBackColor = true
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Location = New System.Drawing.Point(333, 271)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(96, 23)
        Me.Btn_Exit.TabIndex = 5
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.UseVisualStyleBackColor = true
        '
        'Btn_NewHand
        '
        Me.Btn_NewHand.Location = New System.Drawing.Point(333, 202)
        Me.Btn_NewHand.Name = "Btn_NewHand"
        Me.Btn_NewHand.Size = New System.Drawing.Size(96, 23)
        Me.Btn_NewHand.TabIndex = 4
        Me.Btn_NewHand.Text = "New Hand"
        Me.Btn_NewHand.UseVisualStyleBackColor = true
        '
        'Btn_Debug
        '
        Me.Btn_Debug.Location = New System.Drawing.Point(188, 271)
        Me.Btn_Debug.Name = "Btn_Debug"
        Me.Btn_Debug.Size = New System.Drawing.Size(96, 23)
        Me.Btn_Debug.TabIndex = 0
        Me.Btn_Debug.Text = "Debug"
        Me.Btn_Debug.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(441, 306)
        Me.Controls.Add(Me.Btn_Debug)
        Me.Controls.Add(Me.Btn_NewHand)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Btn_ShowCard)
        Me.Controls.Add(Me.Txt_Wager)
        Me.Controls.Add(Me.Lbl_Wager)
        Me.Controls.Add(Me.Txt_Credits)
        Me.Controls.Add(Me.Lbl_Credits)
        Me.Controls.Add(Me.Btn_ShowPayouts)
        Me.Controls.Add(Me.Btn_DepositTokens)
        Me.Controls.Add(Me.Pic_Card3)
        Me.Controls.Add(Me.Pic_Card2)
        Me.Controls.Add(Me.Pic_Card1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Three Card Poker"
        CType(Me.Pic_Card1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Pic_Card2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Pic_Card3,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Pic_Card1 As PictureBox
    Friend WithEvents Pic_Card2 As PictureBox
    Friend WithEvents Pic_Card3 As PictureBox
    Friend WithEvents Btn_DepositTokens As Button
    Friend WithEvents Btn_ShowPayouts As Button
    Friend WithEvents Lbl_Credits As Label
    Friend WithEvents Txt_Credits As TextBox
    Friend WithEvents Lbl_Wager As Label
    Friend WithEvents Txt_Wager As TextBox
    Friend WithEvents Btn_ShowCard As Button
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents Btn_NewHand As Button
    Friend WithEvents Btn_Debug As Button
End Class

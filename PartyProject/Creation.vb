Public Class Creation
    Public Shared characterOne  'Main Character
    Public Shared characterTwo
    Public Shared characterThree
    Public Shared characterFour

    Public Shared party

    'Character One
    Dim OneSTRBuffWPN As Integer
    Dim OneVITBuffWPN As Integer
    Dim OneCHABuffWPN As Integer
    Dim OneWISBuffWPN As Integer
    Dim OneAGIBuffWPN As Integer
    Dim OneLCKBuffWPN As Integer

    Dim OneSTRBuffARM As Integer
    Dim OneVITBuffARM As Integer
    Dim OneCHABuffARM As Integer
    Dim OneWISBuffARM As Integer
    Dim OneAGIBuffARM As Integer
    Dim OneLCKBuffARM As Integer

    'Character Two
    Dim TwoSTRBuffWPN As Integer
    Dim TwoVITBuffWPN As Integer
    Dim TwoCHABuffWPN As Integer
    Dim TwoWISBuffWPN As Integer
    Dim TwoAGIBuffWPN As Integer
    Dim TwoLCKBuffWPN As Integer

    Dim TwoSTRBuffARM As Integer
    Dim TwoVITBuffARM As Integer
    Dim TwoCHABuffARM As Integer
    Dim TwoWISBuffARM As Integer
    Dim TwoAGIBuffARM As Integer
    Dim TwoLCKBuffARM As Integer

    'Character Three
    Dim ThreeSTRBuffWPN As Integer
    Dim ThreeVITBuffWPN As Integer
    Dim ThreeCHABuffWPN As Integer
    Dim ThreeWISBuffWPN As Integer
    Dim ThreeAGIBuffWPN As Integer
    Dim ThreeLCKBuffWPN As Integer

    Dim ThreeSTRBuffARM As Integer
    Dim ThreeVITBuffARM As Integer
    Dim ThreeCHABuffARM As Integer
    Dim ThreeWISBuffARM As Integer
    Dim ThreeAGIBuffARM As Integer
    Dim ThreeLCKBuffARM As Integer

    'Character Four
    Dim FourSTRBuffWPN As Integer
    Dim FourVITBuffWPN As Integer
    Dim FourCHABuffWPN As Integer
    Dim FourWISBuffWPN As Integer
    Dim FourAGIBuffWPN As Integer
    Dim FourLCKBuffWPN As Integer

    Dim FourSTRBuffARM As Integer
    Dim FourVITBuffARM As Integer
    Dim FourCHABuffARM As Integer
    Dim FourWISBuffARM As Integer
    Dim FourAGIBuffARM As Integer
    Dim FourLCKBuffARM As Integer

    Dim WPN As Integer = 40

    Private Sub BtnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click

        characterOne = New Character
        characterTwo = New Character
        characterThree = New Character
        characterFour = New Character

        party = New Collection

        If lblC1Points.Text >= 0 And lblC2Points.Text >= 0 And lblC3Points.Text >= 0 And lblC4Points.Text >= 0 Then

            If ListBox1.SelectedIndex <> -1 And ListBox2.SelectedIndex <> -1 And ListBox3.SelectedIndex <> -1 And
                ListBox4.SelectedIndex <> -1 And ListBox5.SelectedIndex <> -1 And ListBox6.SelectedIndex <> -1 And
                ListBox7.SelectedIndex <> -1 And ListBox8.SelectedIndex <> -1 Then

                characterOne.Name = TextBox1.Text
                characterOne.LVL = 1
                characterOne.HP = (300) * ((nudVIT1.Value) / 20)
                characterOne.AP = (50) * ((nudWIS1.Value) / 20)
                characterOne.maxHP = characterOne.HP
                characterOne.maxAP = characterOne.AP

                characterOne.STR = nudSTR1.Value
                characterOne.VIT = nudVIT1.Value
                characterOne.CHA = nudCHA1.Value
                characterOne.AGI = nudAGI1.Value
                characterOne.WIS = nudWIS1.Value
                characterOne.LCK = nudLCK1.Value

                characterOne.STRBuffWPN = OneSTRBuffWPN
                characterOne.VITBuffWPN = OneVITBuffWPN
                characterOne.CHABuffWPN = OneCHABuffWPN
                characterOne.AGIBuffWPN = OneAGIBuffWPN
                characterOne.WISBuffWPN = OneWISBuffWPN
                characterOne.LCKBuffWPN = OneLCKBuffWPN

                characterOne.STRBuffARM = OneSTRBuffARM
                characterOne.VITBuffARM = OneVITBuffARM
                characterOne.CHABuffARM = OneCHABuffARM
                characterOne.AGIBuffARM = OneAGIBuffARM
                characterOne.WISBuffARM = OneWISBuffARM
                characterOne.LCKBuffARM = OneLCKBuffARM

                characterOne.XP = 0
                characterOne.reqXP = 1000
                characterOne.Tech = 0
                characterOne.Ult = 0

                characterOne.WPN = ListBox1.SelectedItem.ToString()
                characterOne.ARM = ListBox5.SelectedItem.ToString()


                characterTwo.Name = TextBox2.Text
                characterTwo.LVL = 1
                characterTwo.HP = (300) * ((nudVIT2.Value + TwoVITBuffWPN + TwoVITBuffARM) / 20)
                characterTwo.AP = (50) * ((nudWIS2.Value + TwoWISBuffWPN + TwoWISBuffARM) / 20)
                characterTwo.maxHP = characterTwo.HP
                characterTwo.maxAP = characterTwo.AP

                characterTwo.STR = nudSTR2.Value
                characterTwo.VIT = nudVIT2.Value
                characterTwo.CHA = nudCHA2.Value
                characterTwo.AGI = nudAGI2.Value
                characterTwo.WIS = nudWIS2.Value
                characterTwo.LCK = nudLCK2.Value

                characterTwo.STRBuffWPN = TwoSTRBuffWPN
                characterTwo.VITBuffWPN = TwoVITBuffWPN
                characterTwo.CHABuffWPN = TwoCHABuffWPN
                characterTwo.AGIBuffWPN = TwoAGIBuffWPN
                characterTwo.WISBuffWPN = TwoWISBuffWPN
                characterTwo.LCKBuffWPN = TwoLCKBuffWPN

                characterTwo.STRBuffARM = TwoSTRBuffARM
                characterTwo.VITBuffARM = TwoVITBuffARM
                characterTwo.CHABuffARM = TwoCHABuffARM
                characterTwo.AGIBuffARM = TwoAGIBuffARM
                characterTwo.WISBuffARM = TwoWISBuffARM
                characterTwo.LCKBuffARM = TwoLCKBuffARM

                characterTwo.XP = 0
                characterTwo.reqXP = 1000
                characterTwo.Tech = 0
                characterTwo.Ult = 0

                characterTwo.WPN = ListBox2.SelectedItem.ToString()
                characterTwo.ARM = ListBox6.SelectedItem.ToString()


                characterThree.Name = TextBox3.Text
                characterThree.LVL = 1
                characterThree.HP = (300) * ((nudVIT3.Value + ThreeVITBuffWPN + ThreeVITBuffARM) / 20)
                characterThree.AP = (50) * ((nudWIS3.Value + ThreeWISBuffWPN + ThreeWISBuffARM) / 20)
                characterThree.maxHP = characterThree.HP
                characterThree.maxAP = characterThree.AP

                characterThree.STR = nudSTR3.Value
                characterThree.VIT = nudVIT3.Value
                characterThree.CHA = nudCHA3.Value
                characterThree.AGI = nudAGI3.Value
                characterThree.WIS = nudWIS3.Value
                characterThree.LCK = nudLCK3.Value

                characterThree.STRBuffWPN = ThreeSTRBuffWPN
                characterThree.VITBuffWPN = ThreeVITBuffWPN
                characterThree.CHABuffWPN = ThreeCHABuffWPN
                characterThree.AGIBuffWPN = ThreeAGIBuffWPN
                characterThree.WISBuffWPN = ThreeWISBuffWPN
                characterThree.LCKBuffWPN = ThreeLCKBuffWPN

                characterThree.STRBuffARM = ThreeSTRBuffARM
                characterThree.VITBuffARM = ThreeVITBuffARM
                characterThree.CHABuffARM = ThreeCHABuffARM
                characterThree.AGIBuffARM = ThreeAGIBuffARM
                characterThree.WISBuffARM = ThreeWISBuffARM
                characterThree.LCKBuffARM = ThreeLCKBuffARM

                characterThree.XP = 0
                characterThree.reqXP = 1000
                characterThree.Tech = 0
                characterThree.Ult = 0

                characterThree.WPN = ListBox3.SelectedItem.ToString()
                characterThree.ARM = ListBox7.SelectedItem.ToString()


                characterFour.Name = TextBox4.Text
                characterFour.LVL = 1
                characterFour.HP = (300) * ((nudVIT4.Value + FourVITBuffWPN + FourVITBuffARM) / 20)
                characterFour.AP = (50) * ((nudWIS4.Value + FourWISBuffWPN + FourWISBuffARM) / 20)
                characterFour.maxHP = characterFour.HP
                characterFour.maxAP = characterFour.AP

                characterFour.STR = nudSTR4.Value
                characterFour.VIT = nudVIT4.Value
                characterFour.CHA = nudCHA4.Value
                characterFour.AGI = nudAGI4.Value
                characterFour.WIS = nudWIS4.Value
                characterFour.LCK = nudLCK4.Value

                characterFour.STRBuffWPN = FourSTRBuffWPN
                characterFour.VITBuffWPN = FourVITBuffWPN
                characterFour.CHABuffWPN = FourCHABuffWPN
                characterFour.AGIBuffWPN = FourAGIBuffWPN
                characterFour.WISBuffWPN = FourWISBuffWPN
                characterFour.LCKBuffWPN = FourLCKBuffWPN

                characterFour.STRBuffARM = FourSTRBuffARM
                characterFour.VITBuffARM = FourVITBuffARM
                characterFour.CHABuffARM = FourCHABuffARM
                characterFour.AGIBuffARM = FourAGIBuffARM
                characterFour.WISBuffARM = FourWISBuffARM
                characterFour.LCKBuffARM = FourLCKBuffARM

                characterFour.XP = 0
                characterFour.reqXP = 1000
                characterFour.Tech = 0
                characterFour.Ult = 0

                characterFour.WPN = ListBox4.SelectedItem.ToString()
                characterFour.ARM = ListBox8.SelectedItem.ToString()

                Try
                    party.Add(characterOne, "1")
                    party.Add(characterTwo, "2")
                    party.Add(characterThree, "3")
                    party.Add(characterFour, "4")
                Catch ex As ArgumentException
                    MessageBox.Show(ex.Message)
                End Try
                Game.Show()
                Game.gameSetup()
                Me.Close()
            Else
                MessageBox.Show("Equip all characters with arms and armour.")
            End If
        Else
            MessageBox.Show("Invalid amount of points spent.")
        End If
    End Sub

    Private Sub UpdatePoints(A)
        Select Case A
            Case 1 ''Character One gets 80 for he/she is main character everyone else gets 60
                lblC1Points.Text = (80 - (nudSTR1.Value + nudVIT1.Value + nudCHA1.Value + nudWIS1.Value + nudAGI1.Value + nudLCK1.Value)).ToString()
            Case 2
                lblC2Points.Text = (60 - (nudSTR2.Value + nudVIT2.Value + nudCHA2.Value + nudWIS2.Value + nudAGI2.Value + nudLCK2.Value)).ToString()
            Case 3
                lblC3Points.Text = (60 - (nudSTR3.Value + nudVIT3.Value + nudCHA3.Value + nudWIS3.Value + nudAGI3.Value + nudLCK3.Value)).ToString()
            Case 4
                lblC4Points.Text = (60 - (nudSTR4.Value + nudVIT4.Value + nudCHA4.Value + nudWIS4.Value + nudAGI4.Value + nudLCK4.Value)).ToString()
        End Select
    End Sub


    ''=======================================
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        GroupBox1.Text = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        GroupBox2.Text = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        GroupBox3.Text = TextBox3.Text
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        GroupBox4.Text = TextBox4.Text
    End Sub

    ''=======================================
    Private Sub nudSTR1_ValueChanged(sender As Object, e As EventArgs) Handles nudSTR1.ValueChanged
        UpdatePoints(1)
        If ListBox1.SelectedIndex <> -1 Then
            If ListBox1.SelectedItem.ToString() = "Fire Catalyst" Then
                lblC1Attack.Text = WPN + (WPN * (nudWIS1.Value / 20)) + (nudAGI1.Value * (nudAGI1.Value / 20))
            Else
                lblC1Attack.Text = WPN + (WPN * (nudSTR1.Value / 20)) + (nudAGI1.Value * (nudAGI1.Value / 20))
            End If
        Else
            lblC1Attack.Text = WPN + (WPN * (nudSTR1.Value / 20)) + (nudAGI1.Value * (nudAGI1.Value / 20))
        End If
    End Sub

    Private Sub nudVIT1_ValueChanged(sender As Object, e As EventArgs) Handles nudVIT1.ValueChanged
        UpdatePoints(1)
        lblC1Health.Text = (300) * (nudVIT1.Value / 20)
        lblC1Res.Text = 10 + (nudAGI1.Value * (nudVIT1.Value / 20)) + 5
    End Sub

    Private Sub nudCHA1_ValueChanged(sender As Object, e As EventArgs) Handles nudCHA1.ValueChanged
        UpdatePoints(1)
        lblC1Critical.Text = (0.5 * nudLCK1.Value) + (0.25 * nudCHA1.Value)
    End Sub

    Private Sub nudWIS1_ValueChanged(sender As Object, e As EventArgs) Handles nudWIS1.ValueChanged
        UpdatePoints(1)
        lblC1Ability.Text = 50 * (nudWIS1.Value / 20)
        If ListBox1.SelectedIndex <> -1 Then
            If ListBox1.SelectedItem.ToString() = "Fire Catalyst" Then
                lblC1Attack.Text = WPN + (WPN * (nudWIS1.Value / 20)) + (nudAGI1.Value * (nudAGI1.Value / 20))
            End If
        End If
    End Sub

    Private Sub nudAGI1_ValueChanged(sender As Object, e As EventArgs) Handles nudAGI1.ValueChanged
        UpdatePoints(1)
        If ListBox1.SelectedIndex <> -1 Then
            If ListBox1.SelectedItem.ToString() = "Fire Catalyst" Then
                lblC1Attack.Text = WPN + (WPN * (nudWIS1.Value / 20)) + (nudAGI1.Value * (nudAGI1.Value / 20))
            Else
                lblC1Attack.Text = WPN + (WPN * (nudSTR1.Value / 20)) + (nudAGI1.Value * (nudAGI1.Value / 20))
            End If
        Else
            lblC1Attack.Text = WPN + (WPN * (nudSTR1.Value / 20)) + (nudAGI1.Value * (nudAGI1.Value / 20))
        End If
        lblC1Res.Text = 10 + (nudAGI1.Value * (nudVIT1.Value / 20)) + 5
    End Sub

    Private Sub nudLCK1_ValueChanged(sender As Object, e As EventArgs) Handles nudLCK1.ValueChanged
        UpdatePoints(1)
        lblC1Critical.Text = (0.5 * nudLCK1.Value) + (0.25 * nudCHA1.Value)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        OneSTRBuffWPN = 0
        OneVITBuffWPN = 0
        OneCHABuffWPN = 0
        OneWISBuffWPN = 0
        OneAGIBuffWPN = 0
        OneLCKBuffWPN = 0

        Select Case ListBox1.SelectedItem.ToString()
            Case "Straight Sword"
                OneCHABuffWPN = 1
                OneLCKBuffWPN = 1
                WPN = 40
            Case "Greatsword"
                OneVITBuffWPN = 1
                WPN = 65
            Case "Daggers"
                OneAGIBuffWPN = 2
                WPN = 25
            Case "Fire Catalyst"
                OneWISBuffWPN = 2
                WPN = 40
            Case "Bow"
                OneAGIBuffWPN = 3
                WPN = 30
        End Select

        lbl1STR.Text = "STR (+ " + (OneSTRBuffWPN + OneSTRBuffARM).ToString() + "):"
        lbl1VIT.Text = "VIT (+ " + (OneVITBuffWPN + OneVITBuffARM).ToString() + "):"
        lbl1CHA.Text = "CHA (+ " + (OneCHABuffWPN + OneCHABuffARM).ToString() + "):"
        lbl1WIS.Text = "WIS (+ " + (OneWISBuffWPN + OneWISBuffARM).ToString() + "):"
        lbl1AGI.Text = "AGI (+ " + (OneAGIBuffWPN + OneAGIBuffARM).ToString() + "):"
        lbl1LCK.Text = "LCK (+ " + (OneLCKBuffWPN + OneLCKBuffARM).ToString() + "):"

        If ListBox1.SelectedItem.ToString() = "Fire Catalyst" Then
            lblC1Attack.Text = WPN + (WPN * (nudWIS1.Value / 20)) + (nudAGI1.Value * (nudAGI1.Value / 20))
        Else
            lblC1Attack.Text = WPN + (WPN * (nudSTR1.Value / 20)) + (nudAGI1.Value * (nudAGI1.Value / 20))
        End If

    End Sub

    Private Sub ListBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox5.SelectedIndexChanged
        OneSTRBuffARM = 0
        OneVITBuffARM = 0
        OneCHABuffARM = 0
        OneWISBuffARM = 0
        OneAGIBuffARM = 0
        OneLCKBuffARM = 0

        Select Case ListBox5.SelectedItem.ToString()
            Case "Warrior Cowl"
                lblC1Res.Text = 10 + (nudAGI1.Value * (nudVIT1.Value / 20)) + 5
                lblC1Res.Text = (CInt(lblC1Res.Text) + 20).ToString()
                OneVITBuffARM = 1
                OneSTRBuffARM = 1
            Case "Iron Plate"
                lblC1Res.Text = 10 + (nudAGI1.Value * (nudVIT1.Value / 20)) + 5
                lblC1Res.Text = (CInt(lblC1Res.Text) + 30).ToString()
                OneVITBuffARM = 2
                OneAGIBuffARM = -2
            Case "Thief Cloak"
                lblC1Res.Text = 10 + (nudAGI1.Value * (nudVIT1.Value / 20)) + 5
                lblC1Res.Text = (CInt(lblC1Res.Text) + 10).ToString()
                OneAGIBuffARM = 2
                OneLCKBuffARM = 1
            Case "Apprentice Robe"
                lblC1Res.Text = 10 + (nudAGI1.Value * (nudVIT1.Value / 20)) + 5
                lblC1Res.Text = (CInt(lblC1Res.Text) + 5).ToString()
                OneWISBuffARM = 3
            Case "Adventurer Garb"
                lblC1Res.Text = 10 + (nudAGI1.Value * (nudVIT1.Value / 20)) + 5
                lblC1Res.Text = (CInt(lblC1Res.Text) + 15).ToString()
                OneCHABuffARM = 1
                OneLCKBuffARM = 1
            Case "Noble Clothes"
                lblC1Res.Text = 10 + (nudAGI1.Value * (nudVIT1.Value / 20)) + 5
                lblC1Res.Text = (CInt(lblC1Res.Text) - 10).ToString()
                OneCHABuffARM = 2
                OneLCKBuffARM = 2
                OneWISBuffARM = 2
        End Select

        lbl1STR.Text = "STR (+ " + (OneSTRBuffWPN + OneSTRBuffARM).ToString() + "):"
        lbl1VIT.Text = "VIT (+ " + (OneVITBuffWPN + OneVITBuffARM).ToString() + "):"
        lbl1CHA.Text = "CHA (+ " + (OneCHABuffWPN + OneCHABuffARM).ToString() + "):"
        lbl1WIS.Text = "WIS (+ " + (OneWISBuffWPN + OneWISBuffARM).ToString() + "):"
        lbl1AGI.Text = "AGI (+ " + (OneAGIBuffWPN + OneAGIBuffARM).ToString() + "):"
        lbl1LCK.Text = "LCK (+ " + (OneLCKBuffWPN + OneLCKBuffARM).ToString() + "):"

    End Sub

    ''=======================================
    Private Sub nudSTR2_ValueChanged(sender As Object, e As EventArgs) Handles nudSTR2.ValueChanged
        UpdatePoints(2)
        If ListBox2.SelectedIndex <> -1 Then
            If ListBox2.SelectedItem.ToString() = "Fire Catalyst" Then
                lblC2Attack.Text = WPN + (WPN * (nudWIS2.Value / 20)) + (nudAGI2.Value * (nudAGI2.Value / 20))
            Else
                lblC2Attack.Text = WPN + (WPN * (nudSTR2.Value / 20)) + (nudAGI2.Value * (nudAGI2.Value / 20))
            End If
        Else
            lblC2Attack.Text = WPN + (WPN * (nudSTR2.Value / 20)) + (nudAGI2.Value * (nudAGI2.Value / 20))
        End If
    End Sub

    Private Sub nudVIT2_ValueChanged(sender As Object, e As EventArgs) Handles nudVIT2.ValueChanged
        UpdatePoints(2)
        lblC2Health.Text = (300) * (nudVIT2.Value / 20)
        lblC2Res.Text = 10 + (nudAGI2.Value * (nudVIT2.Value / 20)) + 5
    End Sub

    Private Sub nudCHA2_ValueChanged(sender As Object, e As EventArgs) Handles nudCHA2.ValueChanged
        UpdatePoints(2)
        lblC2Critical.Text = (0.5 * nudLCK2.Value) + (0.25 * nudCHA2.Value)
    End Sub

    Private Sub nudWIS2_ValueChanged(sender As Object, e As EventArgs) Handles nudWIS2.ValueChanged
        UpdatePoints(2)
        lblC2Ability.Text = 50 * (nudWIS2.Value / 20)
        If ListBox2.SelectedIndex <> -1 Then
            If ListBox2.SelectedItem.ToString() = "Fire Catalyst" Then
                lblC2Attack.Text = WPN + (WPN * (nudWIS2.Value / 20)) + (nudAGI2.Value * (nudAGI2.Value / 20))
            End If
        End If
    End Sub

    Private Sub nudAGI2_ValueChanged(sender As Object, e As EventArgs) Handles nudAGI2.ValueChanged
        UpdatePoints(2)
        If ListBox2.SelectedIndex <> -1 Then
            If ListBox2.SelectedItem.ToString() = "Fire Catalyst" Then
                lblC2Attack.Text = WPN + (WPN * (nudWIS2.Value / 20)) + (nudAGI2.Value * (nudAGI2.Value / 20))
            Else
                lblC2Attack.Text = WPN + (WPN * (nudSTR2.Value / 20)) + (nudAGI2.Value * (nudAGI2.Value / 20))
            End If
        Else
            lblC2Attack.Text = WPN + (WPN * (nudSTR2.Value / 20)) + (nudAGI2.Value * (nudAGI2.Value / 20))
        End If
        lblC2Res.Text = 10 + (nudAGI2.Value * (nudVIT2.Value / 20)) + 5
    End Sub

    Private Sub nudLCK2_ValueChanged(sender As Object, e As EventArgs) Handles nudLCK2.ValueChanged
        UpdatePoints(2)
        lblC2Critical.Text = (0.5 * nudLCK2.Value) + (0.25 * nudCHA2.Value)
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        TwoSTRBuffWPN = 0
        TwoVITBuffWPN = 0
        TwoCHABuffWPN = 0
        TwoWISBuffWPN = 0
        TwoAGIBuffWPN = 0
        TwoLCKBuffWPN = 0

        Select Case ListBox2.SelectedItem.ToString()
            Case "Straight Sword"
                TwoCHABuffWPN = 1
                TwoLCKBuffWPN = 1
                WPN = 40
            Case "Greatsword"
                TwoVITBuffWPN = 1
                WPN = 65
            Case "Daggers"
                TwoAGIBuffWPN = 2
                WPN = 25
            Case "Fire Catalyst"
                TwoWISBuffWPN = 2
                WPN = 40
            Case "Bow"
                TwoAGIBuffWPN = 3
                WPN = 30
        End Select

        lbl2STR.Text = "STR (+ " + (TwoSTRBuffWPN + TwoSTRBuffARM).ToString() + "):"
        lbl2VIT.Text = "VIT (+ " + (TwoVITBuffWPN + TwoVITBuffARM).ToString() + "):"
        lbl2CHA.Text = "CHA (+ " + (TwoCHABuffWPN + TwoCHABuffARM).ToString() + "):"
        lbl2WIS.Text = "WIS (+ " + (TwoWISBuffWPN + TwoWISBuffARM).ToString() + "):"
        lbl2AGI.Text = "AGI (+ " + (TwoAGIBuffWPN + TwoAGIBuffARM).ToString() + "):"
        lbl2LCK.Text = "LCK (+ " + (TwoLCKBuffWPN + TwoLCKBuffARM).ToString() + "):"


        If ListBox2.SelectedItem.ToString() = "Fire Catalyst" Then
            lblC2Attack.Text = WPN + (WPN * (nudWIS2.Value / 20)) + (nudAGI2.Value * (nudAGI2.Value / 20))
        Else
            lblC2Attack.Text = WPN + (WPN * (nudSTR2.Value / 20)) + (nudAGI2.Value * (nudAGI2.Value / 20))
        End If
    End Sub

    Private Sub ListBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox6.SelectedIndexChanged
        TwoSTRBuffARM = 0
        TwoVITBuffARM = 0
        TwoCHABuffARM = 0
        TwoWISBuffARM = 0
        TwoAGIBuffARM = 0
        TwoLCKBuffARM = 0

        Select Case ListBox6.SelectedItem.ToString()
            Case "Warrior Cowl"
                lblC2Res.Text = 10 + (nudAGI2.Value * (nudVIT2.Value / 20)) + 5
                lblC2Res.Text = (CInt(lblC2Res.Text) + 20).ToString()
                TwoVITBuffARM = 1
                TwoSTRBuffARM = 1
            Case "Iron Plate"
                lblC2Res.Text = 10 + (nudAGI2.Value * (nudVIT2.Value / 20)) + 5
                lblC2Res.Text = (CInt(lblC2Res.Text) + 30).ToString()
                TwoVITBuffARM = 2
                TwoAGIBuffARM = -2
            Case "Thief Cloak"
                lblC2Res.Text = 10 + (nudAGI2.Value * (nudVIT2.Value / 20)) + 5
                lblC2Res.Text = (CInt(lblC2Res.Text) + 10).ToString()
                TwoAGIBuffARM = 2
                TwoLCKBuffARM = 1
            Case "Apprentice Robe"
                lblC2Res.Text = 10 + (nudAGI2.Value * (nudVIT2.Value / 20)) + 5
                lblC2Res.Text = (CInt(lblC2Res.Text) + 5).ToString()
                TwoWISBuffARM = 3
            Case "Adventurer Garb"
                lblC2Res.Text = 10 + (nudAGI2.Value * (nudVIT2.Value / 20)) + 5
                lblC2Res.Text = (CInt(lblC2Res.Text) + 15).ToString()
                TwoCHABuffARM = 1
                TwoLCKBuffARM = 1
            Case "Noble Clothes"
                lblC2Res.Text = 10 + (nudAGI2.Value * (nudVIT2.Value / 20)) + 5
                lblC2Res.Text = (CInt(lblC2Res.Text) - 10).ToString()
                TwoCHABuffARM = 2
                TwoLCKBuffARM = 2
                TwoWISBuffARM = 2
        End Select

        lbl2STR.Text = "STR (+ " + (TwoSTRBuffWPN + TwoSTRBuffARM).ToString() + "):"
        lbl2VIT.Text = "VIT (+ " + (TwoVITBuffWPN + TwoVITBuffARM).ToString() + "):"
        lbl2CHA.Text = "CHA (+ " + (TwoCHABuffWPN + TwoCHABuffARM).ToString() + "):"
        lbl2WIS.Text = "WIS (+ " + (TwoWISBuffWPN + TwoWISBuffARM).ToString() + "):"
        lbl2AGI.Text = "AGI (+ " + (TwoAGIBuffWPN + TwoAGIBuffARM).ToString() + "):"
        lbl2LCK.Text = "LCK (+ " + (TwoLCKBuffWPN + TwoLCKBuffARM).ToString() + "):"


    End Sub

    ''=======================================
    Private Sub nudSTR3_ValueChanged(sender As Object, e As EventArgs) Handles nudSTR3.ValueChanged
        UpdatePoints(3)
        If ListBox3.SelectedIndex <> -1 Then
            If ListBox3.SelectedItem.ToString() = "Fire Catalyst" Then
                lblC3Attack.Text = WPN + (WPN * (nudWIS3.Value / 20)) + (nudAGI3.Value * (nudAGI3.Value / 20))
            Else
                lblC3Attack.Text = WPN + (WPN * (nudSTR3.Value / 20)) + (nudAGI3.Value * (nudAGI3.Value / 20))
            End If
        Else
            lblC3Attack.Text = WPN + (WPN * (nudSTR3.Value / 20)) + (nudAGI3.Value * (nudAGI3.Value / 20))
        End If
    End Sub

    Private Sub nudVIT3_ValueChanged(sender As Object, e As EventArgs) Handles nudVIT3.ValueChanged
        UpdatePoints(3)
        lblC3Health.Text = (300) * (nudVIT3.Value / 20)
        lblC3Res.Text = 10 + (nudAGI3.Value * (nudVIT3.Value / 20)) + 5
    End Sub

    Private Sub nudCHA3_ValueChanged(sender As Object, e As EventArgs) Handles nudCHA3.ValueChanged
        UpdatePoints(3)
        lblC3Critical.Text = (0.5 * nudLCK3.Value) + (0.25 * nudCHA3.Value)
    End Sub

    Private Sub nudWIS3_ValueChanged(sender As Object, e As EventArgs) Handles nudWIS3.ValueChanged
        UpdatePoints(3)
        lblC3Ability.Text = 50 * (nudWIS3.Value / 20)
        If ListBox3.SelectedIndex <> -1 Then
            If ListBox3.SelectedItem.ToString() = "Fire Catalyst" Then
                lblC3Attack.Text = WPN + (WPN * (nudWIS3.Value / 20)) + (nudAGI3.Value * (nudAGI3.Value / 20))
            End If
        End If
    End Sub

    Private Sub nudAGI3_ValueChanged(sender As Object, e As EventArgs) Handles nudAGI3.ValueChanged
        UpdatePoints(3)
        If ListBox3.SelectedIndex <> -1 Then
            If ListBox3.SelectedItem.ToString() = "Fire Catalyst" Then
                lblC3Attack.Text = WPN + (WPN * (nudWIS3.Value / 20)) + (nudAGI3.Value * (nudAGI3.Value / 20))
            Else
                lblC3Attack.Text = WPN + (WPN * (nudSTR3.Value / 20)) + (nudAGI3.Value * (nudAGI3.Value / 20))
            End If
        Else
            lblC3Attack.Text = WPN + (WPN * (nudSTR3.Value / 20)) + (nudAGI3.Value * (nudAGI3.Value / 20))
        End If
        lblC3Res.Text = 10 + (nudAGI3.Value * (nudVIT3.Value / 20)) + 5
    End Sub

    Private Sub nudLCK3_ValueChanged(sender As Object, e As EventArgs) Handles nudLCK3.ValueChanged
        UpdatePoints(3)
        lblC3Critical.Text = (0.5 * nudLCK3.Value) + (0.25 * nudCHA3.Value)
    End Sub


    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        ThreeSTRBuffWPN = 0
        ThreeVITBuffWPN = 0
        ThreeCHABuffWPN = 0
        ThreeWISBuffWPN = 0
        ThreeAGIBuffWPN = 0
        ThreeLCKBuffWPN = 0

        Select Case ListBox3.SelectedItem.ToString()
            Case "Straight Sword"
                ThreeCHABuffWPN = 1
                ThreeLCKBuffWPN = 1
                WPN = 40
            Case "Greatsword"
                ThreeVITBuffWPN = 1
                WPN = 65
            Case "Daggers"
                ThreeAGIBuffWPN = 2
                WPN = 25
            Case "Fire Catalyst"
                ThreeWISBuffWPN = 2
                WPN = 40
            Case "Bow"
                ThreeAGIBuffWPN = 3
                WPN = 30
        End Select

        lbl3STR.Text = "STR (+ " + (ThreeSTRBuffWPN + ThreeSTRBuffARM).ToString() + "):"
        lbl3VIT.Text = "VIT (+ " + (ThreeVITBuffWPN + ThreeVITBuffARM).ToString() + "):"
        lbl3CHA.Text = "CHA (+ " + (ThreeCHABuffWPN + ThreeCHABuffARM).ToString() + "):"
        lbl3WIS.Text = "WIS (+ " + (ThreeWISBuffWPN + ThreeWISBuffARM).ToString() + "):"
        lbl3AGI.Text = "AGI (+ " + (ThreeAGIBuffWPN + ThreeAGIBuffARM).ToString() + "):"
        lbl3LCK.Text = "LCK (+ " + (ThreeLCKBuffWPN + ThreeLCKBuffARM).ToString() + "):"

        If ListBox3.SelectedItem.ToString() = "Fire Catalyst" Then
            lblC3Attack.Text = WPN + (WPN * (nudWIS3.Value / 20)) + (nudAGI3.Value * (nudAGI3.Value / 20))
        Else
            lblC3Attack.Text = WPN + (WPN * (nudSTR3.Value / 20)) + (nudAGI3.Value * (nudAGI3.Value / 20))
        End If
    End Sub

    Private Sub ListBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox7.SelectedIndexChanged
        ThreeSTRBuffARM = 0
        ThreeVITBuffARM = 0
        ThreeCHABuffARM = 0
        ThreeWISBuffARM = 0
        ThreeAGIBuffARM = 0
        ThreeLCKBuffARM = 0

        Select Case ListBox7.SelectedItem.ToString()
            Case "Warrior Cowl"
                lblC3Res.Text = 10 + (nudAGI3.Value * (nudVIT3.Value / 20)) + 5
                lblC3Res.Text = (CInt(lblC3Res.Text) + 20).ToString()
                ThreeVITBuffARM = 1
                ThreeSTRBuffARM = 1
            Case "Iron Plate"
                lblC3Res.Text = 10 + (nudAGI3.Value * (nudVIT3.Value / 20)) + 5
                lblC3Res.Text = (CInt(lblC3Res.Text) + 30).ToString()
                ThreeVITBuffARM = 2
                ThreeAGIBuffARM = -2
            Case "Thief Cloak"
                lblC3Res.Text = 10 + (nudAGI3.Value * (nudVIT3.Value / 20)) + 5
                lblC3Res.Text = (CInt(lblC3Res.Text) + 10).ToString()
                ThreeAGIBuffARM = 2
                ThreeLCKBuffARM = 1
            Case "Apprentice Robe"
                lblC3Res.Text = 10 + (nudAGI3.Value * (nudVIT3.Value / 20)) + 5
                lblC3Res.Text = (CInt(lblC3Res.Text) + 5).ToString()
                ThreeWISBuffARM = 3
            Case "Adventurer Garb"
                lblC3Res.Text = 10 + (nudAGI3.Value * (nudVIT3.Value / 20)) + 5
                lblC3Res.Text = (CInt(lblC3Res.Text) + 15).ToString()
                ThreeCHABuffARM = 1
                ThreeLCKBuffARM = 1
            Case "Noble Clothes"
                lblC3Res.Text = 10 + (nudAGI3.Value * (nudVIT3.Value / 20)) + 5
                lblC3Res.Text = (CInt(lblC3Res.Text) - 10).ToString()
                ThreeCHABuffARM = 2
                ThreeLCKBuffARM = 2
                ThreeWISBuffARM = 2
        End Select

        lbl3STR.Text = "STR (+ " + (ThreeSTRBuffWPN + ThreeSTRBuffARM).ToString() + "):"
        lbl3VIT.Text = "VIT (+ " + (ThreeVITBuffWPN + ThreeVITBuffARM).ToString() + "):"
        lbl3CHA.Text = "CHA (+ " + (ThreeCHABuffWPN + ThreeCHABuffARM).ToString() + "):"
        lbl3WIS.Text = "WIS (+ " + (ThreeWISBuffWPN + ThreeWISBuffARM).ToString() + "):"
        lbl3AGI.Text = "AGI (+ " + (ThreeAGIBuffWPN + ThreeAGIBuffARM).ToString() + "):"
        lbl3LCK.Text = "LCK (+ " + (ThreeLCKBuffWPN + ThreeLCKBuffARM).ToString() + "):"

    End Sub

    ''=======================================
    Private Sub nudSTR4_ValueChanged(sender As Object, e As EventArgs) Handles nudSTR4.ValueChanged
        UpdatePoints(4)
        If ListBox4.SelectedIndex <> -1 Then
            If ListBox4.SelectedItem.ToString() = "Fire Catalyst" Then
                lblC4Attack.Text = WPN + (WPN * (nudWIS4.Value / 20)) + (nudAGI4.Value * (nudAGI4.Value / 20))
            Else
                lblC4Attack.Text = WPN + (WPN * (nudSTR4.Value / 20)) + (nudAGI4.Value * (nudAGI4.Value / 20))
            End If
        Else
            lblC4Attack.Text = WPN + (WPN * (nudSTR4.Value / 20)) + (nudAGI4.Value * (nudAGI4.Value / 20))
        End If
    End Sub

    Private Sub nudVIT4_ValueChanged(sender As Object, e As EventArgs) Handles nudVIT4.ValueChanged
        UpdatePoints(4)
        lblC4Health.Text = (300) * (nudVIT4.Value / 20)
        lblC4Res.Text = 10 + (nudAGI4.Value * (nudVIT4.Value / 20)) + 5
    End Sub

    Private Sub nudCHA4_ValueChanged(sender As Object, e As EventArgs) Handles nudCHA4.ValueChanged
        UpdatePoints(4)
        lblC4Critical.Text = (0.5 * nudLCK4.Value) + (0.25 * nudCHA4.Value)
    End Sub

    Private Sub nudWIS4_ValueChanged(sender As Object, e As EventArgs) Handles nudWIS4.ValueChanged
        UpdatePoints(4)
        lblC4Ability.Text = 50 * (nudWIS4.Value / 20)
        If ListBox4.SelectedIndex <> -1 Then
            If ListBox4.SelectedItem.ToString() = "Fire Catalyst" Then
                lblC4Attack.Text = WPN + (WPN * (nudWIS4.Value / 20)) + (nudAGI4.Value * (nudAGI4.Value / 20))
            End If
        End If
    End Sub

    Private Sub nudAGI4_ValueChanged(sender As Object, e As EventArgs) Handles nudAGI4.ValueChanged
        UpdatePoints(4)
        If ListBox4.SelectedIndex <> -1 Then
            If ListBox4.SelectedItem.ToString() = "Fire Catalyst" Then
                lblC4Attack.Text = WPN + (WPN * (nudWIS4.Value / 20)) + (nudAGI4.Value * (nudAGI4.Value / 20))
            Else
                lblC4Attack.Text = WPN + (WPN * (nudSTR4.Value / 20)) + (nudAGI4.Value * (nudAGI4.Value / 20))
            End If
        Else
            lblC4Attack.Text = WPN + (WPN * (nudSTR4.Value / 20)) + (nudAGI4.Value * (nudAGI4.Value / 20))
        End If
        lblC4Res.Text = 10 + (nudAGI4.Value * (nudVIT4.Value / 20)) + 5
    End Sub

    Private Sub nudLCK4_ValueChanged(sender As Object, e As EventArgs) Handles nudLCK4.ValueChanged
        UpdatePoints(4)
        lblC4Critical.Text = (0.5 * nudLCK4.Value) + (0.25 * nudCHA4.Value)
    End Sub

    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        FourSTRBuffWPN = 0
        FourVITBuffWPN = 0
        FourCHABuffWPN = 0
        FourWISBuffWPN = 0
        FourAGIBuffWPN = 0
        FourLCKBuffWPN = 0

        Select Case ListBox4.SelectedItem.ToString()
            Case "Straight Sword"
                FourCHABuffWPN = 1
                FourLCKBuffWPN = 1
                WPN = 40
            Case "Greatsword"
                FourVITBuffWPN = 1
                WPN = 65
            Case "Daggers"
                FourAGIBuffWPN = 2
                WPN = 25
            Case "Fire Catalyst"
                FourWISBuffWPN = 2
                WPN = 40
            Case "Bow"
                FourAGIBuffWPN = 3
                WPN = 30
        End Select

        lbl4STR.Text = "STR (+ " + (FourSTRBuffWPN + FourSTRBuffARM).ToString() + "):"
        lbl4VIT.Text = "VIT (+ " + (FourVITBuffWPN + FourVITBuffARM).ToString() + "):"
        lbl4CHA.Text = "CHA (+ " + (FourCHABuffWPN + FourCHABuffARM).ToString() + "):"
        lbl4WIS.Text = "WIS (+ " + (FourWISBuffWPN + FourWISBuffARM).ToString() + "):"
        lbl4AGI.Text = "AGI (+ " + (FourAGIBuffWPN + FourAGIBuffARM).ToString() + "):"
        lbl4LCK.Text = "LCK (+ " + (FourLCKBuffWPN + FourLCKBuffARM).ToString() + "):"

        If ListBox4.SelectedItem.ToString() = "Fire Catalyst" Then
            lblC4Attack.Text = WPN + (WPN * (nudWIS4.Value / 20)) + (nudAGI4.Value * (nudAGI4.Value / 20))
        Else
            lblC4Attack.Text = WPN + (WPN * (nudSTR4.Value / 20)) + (nudAGI4.Value * (nudAGI4.Value / 20))
        End If
    End Sub

    Private Sub ListBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox8.SelectedIndexChanged
        FourSTRBuffARM = 0
        FourVITBuffARM = 0
        FourCHABuffARM = 0
        FourWISBuffARM = 0
        FourAGIBuffARM = 0
        FourLCKBuffARM = 0

        Select Case ListBox8.SelectedItem.ToString()
            Case "Warrior Cowl"
                lblC4Res.Text = 10 + (nudAGI4.Value * (nudVIT4.Value / 20)) + 5
                lblC4Res.Text = (CInt(lblC4Res.Text) + 20).ToString()
                FourVITBuffARM = 1
                FourSTRBuffARM = 1
            Case "Iron Plate"
                lblC4Res.Text = 10 + (nudAGI4.Value * (nudVIT4.Value / 20)) + 5
                lblC4Res.Text = (CInt(lblC4Res.Text) + 30).ToString()
                FourVITBuffARM = 2
                FourAGIBuffARM = -2
            Case "Thief Cloak"
                lblC4Res.Text = 10 + (nudAGI4.Value * (nudVIT4.Value / 20)) + 5
                lblC4Res.Text = (CInt(lblC4Res.Text) + 10).ToString()
                FourAGIBuffARM = 2
                FourLCKBuffARM = 1
            Case "Apprentice Robe"
                lblC4Res.Text = 10 + (nudAGI4.Value * (nudVIT4.Value / 20)) + 5
                lblC4Res.Text = (CInt(lblC4Res.Text) + 5).ToString()
                FourWISBuffARM = 3
            Case "Adventurer Garb"
                lblC4Res.Text = 10 + (nudAGI4.Value * (nudVIT4.Value / 20)) + 5
                lblC4Res.Text = (CInt(lblC4Res.Text) + 15).ToString()
                FourCHABuffARM = 1
                FourLCKBuffARM = 1
            Case "Noble Clothes"
                lblC4Res.Text = 10 + (nudAGI4.Value * (nudVIT4.Value / 20)) + 5
                lblC4Res.Text = (CInt(lblC4Res.Text) - 10).ToString()
                FourCHABuffARM = 2
                FourLCKBuffARM = 2
                FourWISBuffARM = 2
        End Select

        lbl4STR.Text = "STR (+ " + (FourSTRBuffWPN + FourSTRBuffARM).ToString() + "):"
        lbl4VIT.Text = "VIT (+ " + (FourVITBuffWPN + FourVITBuffARM).ToString() + "):"
        lbl4CHA.Text = "CHA (+ " + (FourCHABuffWPN + FourCHABuffARM).ToString() + "):"
        lbl4WIS.Text = "WIS (+ " + (FourWISBuffWPN + FourWISBuffARM).ToString() + "):"
        lbl4AGI.Text = "AGI (+ " + (FourAGIBuffWPN + FourAGIBuffARM).ToString() + "):"
        lbl4LCK.Text = "LCK (+ " + (FourLCKBuffWPN + FourLCKBuffARM).ToString() + "):"

    End Sub
End Class
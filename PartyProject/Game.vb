Public Class Game
    Dim CharacterOne As Character
    Dim CharacterTwo As Character
    Dim CharacterThree As Character
    Dim CharacterFour As Character

    Dim EnemyOne As New Enemy
    Dim EnemyTwo As New Enemy
    Dim EnemyThree As New Enemy
    Dim EnemyFour As New Enemy
    Dim EnemyFive As New Enemy
    Dim EnemySix As New Enemy

    Dim setupCheck As Boolean

    Dim OneGuard As Integer
    Dim TwoGuard As Integer
    Dim ThreeGuard As Integer
    Dim FourGuard As Integer

    Dim OneParry As Boolean
    Dim TwoParry As Boolean
    Dim ThreeParry As Boolean
    Dim FourParry As Boolean


    Public Sub gameSetup()
        setupCheck = True

        CharacterOne = Creation.characterOne
        CharacterTwo = Creation.characterTwo
        CharacterThree = Creation.characterThree
        CharacterFour = Creation.characterFour

        tabOne.Text = CharacterOne.Name
        tabTwo.Text = CharacterTwo.Name
        tabThree.Text = CharacterThree.Name
        tabFour.Text = CharacterFour.Name

        lblName1.Text = CharacterOne.Name
        lblName2.Text = CharacterTwo.Name
        lblName3.Text = CharacterThree.Name
        lblName4.Text = CharacterFour.Name

        EquipWPN(CharacterOne.WPN, 1)
        EquipARM(CharacterOne.ARM, 1)

        EquipWPN(CharacterTwo.WPN, 2)
        EquipARM(CharacterTwo.ARM, 2)

        EquipWPN(CharacterThree.WPN, 3)
        EquipARM(CharacterThree.ARM, 3)

        EquipWPN(CharacterFour.WPN, 4)
        EquipARM(CharacterFour.ARM, 4)

        UpdateHud()
        CharacterOne.HP = CharacterOne.maxHP
        CharacterTwo.HP = CharacterTwo.maxHP
        CharacterThree.HP = CharacterThree.maxHP
        CharacterFour.HP = CharacterFour.maxHP

        CharacterOne.AP = CharacterOne.maxAP
        CharacterTwo.AP = CharacterTwo.maxAP
        CharacterThree.AP = CharacterThree.maxAP
        CharacterFour.AP = CharacterFour.maxAP
        UpdateHud()

        Log.Show()
        LogPrependE("Welcome Adventurers!")

        EnemyOne.Name = "Apothenon"
        EnemyOne.HP = 1000000000 ' Testing Purposes
        EnemyOne.ACC = 100
        EnemyOne.AP = 1000000
        EnemyOne.Attack = 5000
        EnemyOne.Defense = 4500

        setupCheck = False
    End Sub


    'PLAYER TURN SUBS ===================================
    Private Sub SubmitTurn() Handles btnSubmit.Click
        Dim OneF As Boolean = True
        Dim TwoF As Boolean = True
        Dim ThreeF As Boolean = True
        Dim FourF As Boolean = True

        If radA1.Checked And EnemyOne.HP > 0 Then
            If radA1_1.Checked Then
                ExecuteAttack(CharacterOne, EnemyOne)
                OneF = False
            End If
            If radA1_2.Checked And EnemyTwo.HP > 0 Then
                ExecuteAttack(CharacterOne, EnemyTwo)
                OneF = False
            End If
            If radA1_3.Checked And EnemyThree.HP > 0 Then
                ExecuteAttack(CharacterOne, EnemyThree)
                OneF = False
            End If
            If radA1_4.Checked And EnemyFour.HP > 0 Then
                ExecuteAttack(CharacterOne, EnemyFour)
                OneF = False
            End If
            If radA1_5.Checked And EnemyFive.HP > 0 Then
                ExecuteAttack(CharacterOne, EnemyFive)
                OneF = False
            End If
            If radA1_6.Checked And EnemySix.HP > 0 Then
                ExecuteAttack(CharacterOne, EnemySix)
                OneF = False
            End If
        End If

        If radS1.Checked Then
            If lstS1.SelectedIndex <> -1 Then
                If radS1_1.Checked And EnemyOne.HP > 0 Then
                    ExecuteSpecialAttack(CharacterOne, EnemyOne)
                    OneF = False
                End If
                If radS1_2.Checked And EnemyTwo.HP > 0 Then
                    ExecuteSpecialAttack(CharacterOne, EnemyTwo)
                    OneF = False
                End If
                If radS1_3.Checked And EnemyThree.HP > 0 Then
                    ExecuteSpecialAttack(CharacterOne, EnemyThree)
                    OneF = False
                End If
                If radS1_4.Checked And EnemyFour.HP > 0 Then
                    ExecuteSpecialAttack(CharacterOne, EnemyFour)
                    OneF = False
                End If
                If radS1_5.Checked And EnemyFive.HP > 0 Then
                    ExecuteSpecialAttack(CharacterOne, EnemyFive)
                    OneF = False
                End If
                If radS1_6.Checked And EnemySix.HP > 0 Then
                    ExecuteSpecialAttack(CharacterOne, EnemySix)
                    OneF = False
                End If
            End If
        End If

        If radG1.Checked Then
            ExecuteGuard(CharacterOne)
            OneF = False
        End If

        If radI1.Checked Then
            If lstI1.SelectedIndex <> -1 Then
                If radI1_1.Checked Then
                    UseItem(lstI1.SelectedItem.ToString(), CharacterOne)
                    OneF = False
                End If
                If radI1_2.Checked Then
                    UseItem(lstI1.SelectedItem.ToString(), CharacterTwo)
                    OneF = False
                End If
                If radI1_3.Checked Then
                    UseItem(lstI1.SelectedItem.ToString(), CharacterThree)
                    OneF = False
                End If
                If radI1_4.Checked Then
                    UseItem(lstI1.SelectedItem.ToString(), CharacterFour)
                    OneF = False
                End If
            End If
        End If

        '//=============================
        If radA2.Checked Then
            If radA2_1.Checked And EnemyOne.HP > 0 Then
                ExecuteAttack(CharacterTwo, EnemyOne)
                TwoF = False
            End If
            If radA2_2.Checked And EnemyTwo.HP > 0 Then
                ExecuteAttack(CharacterTwo, EnemyTwo)
                TwoF = False
            End If
            If radA2_3.Checked And EnemyThree.HP > 0 Then
                ExecuteAttack(CharacterTwo, EnemyThree)
                TwoF = False
            End If
            If radA2_4.Checked And EnemyFour.HP > 0 Then
                ExecuteAttack(CharacterTwo, EnemyFour)
                TwoF = False
            End If
            If radA2_5.Checked And EnemyFive.HP > 0 Then
                ExecuteAttack(CharacterTwo, EnemyFive)
                TwoF = False
            End If
            If radA2_6.Checked And EnemySix.HP > 0 Then
                ExecuteAttack(CharacterTwo, EnemySix)
                TwoF = False
            End If
        End If

        If radS2.Checked Then
            If lstS2.SelectedIndex <> -1 Then
                If radS2_1.Checked And EnemyOne.HP > 0 Then
                    ExecuteSpecialAttack(CharacterTwo, EnemyOne)
                    TwoF = False
                End If
                If radS2_2.Checked And EnemyTwo.HP > 0 Then
                    ExecuteSpecialAttack(CharacterTwo, EnemyTwo)
                    TwoF = False
                End If
                If radS2_3.Checked And EnemyThree.HP > 0 Then
                    ExecuteSpecialAttack(CharacterTwo, EnemyThree)
                    TwoF = False
                End If
                If radS2_4.Checked And EnemyFour.HP > 0 Then
                    ExecuteSpecialAttack(CharacterTwo, EnemyFour)
                    TwoF = False
                End If
                If radS2_5.Checked And EnemyFive.HP > 0 Then
                    ExecuteSpecialAttack(CharacterTwo, EnemyFive)
                    TwoF = False
                End If
                If radS2_6.Checked And EnemySix.HP > 0 Then
                    ExecuteSpecialAttack(CharacterTwo, EnemySix)
                    TwoF = False
                End If
            End If
        End If

        If radG2.Checked Then
            ExecuteGuard(CharacterTwo)
            TwoF = False
        End If

        If radI2.Checked Then
            If lstI2.SelectedIndex <> -1 Then
                If radI2_1.Checked Then
                    UseItem(lstI2.SelectedItem.ToString(), 1)
                    TwoF = False
                End If
                If radI2_2.Checked Then
                    UseItem(lstI2.SelectedItem.ToString(), 2)
                    TwoF = False
                End If
                If radI2_3.Checked Then
                    UseItem(lstI2.SelectedItem.ToString(), 3)
                    TwoF = False
                End If
                If radI2_4.Checked Then
                    UseItem(lstI2.SelectedItem.ToString(), 4)
                    TwoF = False
                End If
            End If
        End If

        '//==========================================
        If radA3.Checked Then
            If radA3_1.Checked And EnemyOne.HP > 0 Then
                ExecuteAttack(CharacterThree, EnemyOne)
                ThreeF = False
            End If
            If radA3_2.Checked And EnemyTwo.HP > 0 Then
                ExecuteAttack(CharacterThree, EnemyTwo)
                ThreeF = False
            End If
            If radA3_3.Checked And EnemyThree.HP > 0 Then
                ExecuteAttack(CharacterThree, EnemyThree)
                ThreeF = False
            End If
            If radA3_4.Checked And EnemyFour.HP > 0 Then
                ExecuteAttack(CharacterThree, EnemyFour)
                ThreeF = False
            End If
            If radA3_5.Checked And EnemyFive.HP > 0 Then
                ExecuteAttack(CharacterThree, EnemyFive)
                ThreeF = False
            End If
            If radA3_6.Checked And EnemySix.HP > 0 Then
                ExecuteAttack(CharacterThree, EnemySix)
                ThreeF = False
            End If
        End If

        If radS3.Checked Then
            If lstS3.SelectedIndex <> -1 Then
                If radS3_1.Checked And EnemyOne.HP > 0 Then
                    ExecuteSpecialAttack(CharacterThree, EnemyOne)
                    ThreeF = False
                End If
                If radS3_2.Checked And EnemyTwo.HP > 0 Then
                    ExecuteSpecialAttack(CharacterThree, EnemyTwo)
                    ThreeF = False
                End If
                If radS3_3.Checked And EnemyThree.HP > 0 Then
                    ExecuteSpecialAttack(CharacterThree, EnemyThree)
                    ThreeF = False
                End If
                If radS3_4.Checked And EnemyFour.HP > 0 Then
                    ExecuteSpecialAttack(CharacterThree, EnemyFour)
                    ThreeF = False
                End If
                If radS3_5.Checked And EnemyFive.HP > 0 Then
                    ExecuteSpecialAttack(CharacterThree, EnemyFive)
                    ThreeF = False
                End If
                If radS3_6.Checked And EnemySix.HP > 0 Then
                    ExecuteSpecialAttack(CharacterThree, EnemySix)
                    ThreeF = False
                End If
            End If
        End If

            If radG3.Checked Then
            ExecuteGuard(CharacterThree)
            ThreeF = False
        End If

        If radI3.Checked Then
            If lstI3.SelectedIndex <> -1 Then
                If radI3_1.Checked Then
                    UseItem(lstI3.SelectedItem.ToString(), CharacterOne)
                    ThreeF = False
                End If
                If radI3_2.Checked Then
                    UseItem(lstI3.SelectedItem.ToString(), CharacterTwo)
                    ThreeF = False
                End If
                If radI3_3.Checked Then
                    UseItem(lstI3.SelectedItem.ToString(), CharacterThree)
                    ThreeF = False
                End If
                If radI3_4.Checked Then
                    UseItem(lstI3.SelectedItem.ToString(), CharacterFour)
                    ThreeF = False
                End If
            End If
        End If

        '//=========================================
        If radA4.Checked Then
            If radA4_1.Checked And EnemyOne.HP > 0 Then
                ExecuteAttack(CharacterFour, EnemyOne)
                FourF = False
            End If
            If radA4_2.Checked And EnemyTwo.HP > 0 Then
                ExecuteAttack(CharacterFour, EnemyTwo)
                FourF = False
            End If
            If radA4_3.Checked And EnemyThree.HP > 0 Then
                ExecuteAttack(CharacterFour, EnemyThree)
                FourF = False
            End If
            If radA4_4.Checked And EnemyFour.HP > 0 Then
                ExecuteAttack(CharacterFour, EnemyFour)
                FourF = False
            End If
            If radA4_5.Checked And EnemyFive.HP > 0 Then
                ExecuteAttack(CharacterFour, EnemyFive)
                FourF = False
            End If
            If radA4_6.Checked And EnemySix.HP > 0 Then
                ExecuteAttack(CharacterFour, EnemySix)
                FourF = False
            End If
        End If

        If radS4.Checked Then
            If lstS4.SelectedIndex <> -1 Then
                If radS4_1.Checked And EnemyOne.HP > 0 Then
                    ExecuteSpecialAttack(CharacterFour, EnemyOne)
                    FourF = False
                End If
                If radS4_2.Checked And EnemyTwo.HP > 0 Then
                    ExecuteSpecialAttack(CharacterFour, EnemyTwo)
                    FourF = False
                End If
                If radS4_3.Checked And EnemyThree.HP > 0 Then
                    ExecuteSpecialAttack(CharacterFour, EnemyThree)
                    FourF = False
                End If
                If radS4_4.Checked And EnemyFour.HP > 0 Then
                    ExecuteSpecialAttack(CharacterFour, EnemyFour)
                    FourF = False
                End If
                If radS4_5.Checked And EnemyFive.HP > 0 Then
                    ExecuteSpecialAttack(CharacterFour, EnemyFive)
                    FourF = False
                End If
                If radS4_6.Checked And EnemySix.HP > 0 Then
                    ExecuteSpecialAttack(CharacterFour, EnemySix)
                    FourF = False
                End If
            End If
        End If

        If radG4.Checked Then
            ExecuteGuard(CharacterFour)
            FourF = False
        End If

        If radI4.Checked Then
            If lstI4.SelectedIndex <> -1 Then
                If radI4_1.Checked Then
                    UseItem(lstI4.SelectedItem.ToString(), CharacterOne)
                    FourF = False
                End If
                If radI4_2.Checked Then
                    UseItem(lstI4.SelectedItem.ToString(), CharacterTwo)
                    FourF = False
                End If
                If radI4_4.Checked Then
                    UseItem(lstI4.SelectedItem.ToString(), CharacterThree)
                    FourF = False
                End If
                If radI4_4.Checked Then
                    UseItem(lstI4.SelectedItem.ToString(), CharacterFour)
                    FourF = False
                End If
            End If
        End If

        '//==========================================
        If OneF Then
            If EnemyOne.HP > 0 Then
                ExecuteAttack(CharacterOne, EnemyOne)
            ElseIf EnemyTwo.HP > 0 Then
                ExecuteAttack(CharacterOne, EnemyTwo)
            ElseIf EnemyThree.HP > 0 Then
                ExecuteAttack(CharacterOne, EnemyThree)
            ElseIf EnemyFour.HP > 0 Then
                ExecuteAttack(CharacterOne, EnemyFour)
            ElseIf EnemyFive.HP > 0 Then
                ExecuteAttack(CharacterOne, EnemyFive)
            ElseIf EnemySix.HP > 0 Then
                ExecuteAttack(CharacterOne, EnemySix)
            Else
                MessageBox.Show("All enemies defeated.")
            End If
        End If

        If TwoF Then
            If EnemyOne.HP > 0 Then
                ExecuteAttack(CharacterTwo, EnemyOne)
            ElseIf EnemyTwo.HP > 0 Then
                ExecuteAttack(CharacterTwo, EnemyTwo)
            ElseIf EnemyThree.HP > 0 Then
                ExecuteAttack(CharacterTwo, EnemyThree)
            ElseIf EnemyFour.HP > 0 Then
                ExecuteAttack(CharacterTwo, EnemyFour)
            ElseIf EnemyFive.HP > 0 Then
                ExecuteAttack(CharacterTwo, EnemyFive)
            ElseIf EnemySix.HP > 0 Then
                ExecuteAttack(CharacterTwo, EnemySix)
            Else
                MessageBox.Show("All enemies defeated.")
            End If
        End If

        If ThreeF Then
            If EnemyOne.HP > 0 Then
                ExecuteAttack(CharacterThree, EnemyOne)
            ElseIf EnemyTwo.HP > 0 Then
                ExecuteAttack(CharacterThree, EnemyTwo)
            ElseIf EnemyThree.HP > 0 Then
                ExecuteAttack(CharacterThree, EnemyThree)
            ElseIf EnemyFour.HP > 0 Then
                ExecuteAttack(CharacterThree, EnemyFour)
            ElseIf EnemyFive.HP > 0 Then
                ExecuteAttack(CharacterThree, EnemyFive)
            ElseIf EnemySix.HP > 0 Then
                ExecuteAttack(CharacterThree, EnemySix)
            Else
                MessageBox.Show("All enemies defeated.")
            End If
        End If

        If FourF Then
            If EnemyOne.HP > 0 Then
                ExecuteAttack(CharacterFour, EnemyOne)
            ElseIf EnemyTwo.HP > 0 Then
                ExecuteAttack(CharacterFour, EnemyTwo)
            ElseIf EnemyThree.HP > 0 Then
                ExecuteAttack(CharacterFour, EnemyThree)
            ElseIf EnemyFour.HP > 0 Then
                ExecuteAttack(CharacterFour, EnemyFour)
            ElseIf EnemyFive.HP > 0 Then
                ExecuteAttack(CharacterFour, EnemyFive)
            ElseIf EnemySix.HP > 0 Then
                ExecuteAttack(CharacterFour, EnemySix)
            Else
                MessageBox.Show("All enemies defeated.")
            End If
        End If

        EnemyTurn()
    End Sub

    Sub ExecuteAttack(Character As Object, Enemy As Object)
        Dim Damage As Integer = 0
        Dim random As New Random()
        Dim Crit As Boolean = False
        Dim Acc As Integer

        Damage = Character.DAM + (Character.DAM * (returnScale(Character.Scale, Character) / 20)) + (Character.AGI + Character.AGIBuffARM + Character.AGIBuffWPN) * ((Character.AGI + Character.AGIBuffARM + Character.AGIBuffWPN) / 20)
        Damage = Damage * (random.Next(74, 126) / 100)

        If random.Next(101) < (0.5 * (Character.LCK + Character.LCKBuffARM + Character.LCKBuffWPN)) + (0.25 * (Character.CHA + Character.CHABuffARM + Character.CHABuffWPN)) Then
            Damage = Damage * 5
            Crit = True
            MessageBox.Show(Character.Name & " landed a Critical Hit!")
        End If

        If Character.TempBuffCounter > 2 And Character.Buff = True Then
            Character.TempBuff = 0
            Character.TempBuffCounter = 0
            MessageBox.Show(Character.Name & "'s weapon buff has worn off.")
        Else
            Character.TempBuffCounter += 1
            Damage = Damage + (Damage * Character.TempBuff)
        End If

        If Character.ACC + returnScale(Character.Scale, Character) > 99 Then
            Acc = 99
        Else
            Acc = Character.ACC + returnScale(Character.Scale, Character)
        End If

        If random.Next(101) >= Acc And Crit = False Then
            MessageBox.Show(Character.Name & " has missed their attack.")
        Else
            DealDamage(Character, Enemy, Damage)
        End If
    End Sub

    Sub ExecuteSpecialAttack(Character As Object, Enemy As Object)
        Dim Random As New Random
        Dim Acc As Integer
        Dim Crit As Boolean = False

        If Character.ACC + returnScale(Character.Scale, Character) > 99 Then
            Acc = 99
        Else
            Acc = Character.ACC + returnScale(Character.Scale, 1)
        End If

        If Random.Next(101) < (0.5 * (Character.LCK + Character.LCKBuffARM + Character.LCKBuffWPN)) + (0.25 * (Character.CHA + Character.CHABuffARM + Character.CHABuffWPN)) Then
            Crit = True
        End If

        If Random.Next(101) >= Acc And Crit = False Then
            MessageBox.Show(Character.Name & " has missed their attack.")
        Else
            SpecialAttack(Character, Enemy, lstS1.SelectedItem.ToString(), Crit)
        End If

    End Sub

    Sub ExecuteGuard(Character As Object)
        Dim N As New Random
        Select Case Character
            Case 1
                OneGuard = 50
                CharacterOne.AP = Math.Round(CharacterOne.AP + (CharacterOne.maxAP * 0.4))
                If CharacterOne.AP > CharacterOne.maxAP Then
                    CharacterOne.AP = CharacterOne.maxAP
                End If
                If N.Next(101) < (CharacterOne.LCK + CharacterOne.LCKBuffWPN + CharacterOne.LCKBuffARM) * 0.5 Then
                    OneParry = True
                End If
            Case 2
                TwoGuard = 50
                CharacterTwo.AP = Math.Round(CharacterTwo.AP + (CharacterTwo.maxAP * 0.4))
                If CharacterTwo.AP > CharacterTwo.maxAP Then
                    CharacterTwo.AP = CharacterTwo.maxAP
                End If
                If N.Next(101) < (CharacterTwo.LCK + CharacterTwo.LCKBuffWPN + CharacterTwo.LCKBuffARM) * 0.5 Then
                    TwoParry = True
                End If
            Case 3
                ThreeGuard = 50
                CharacterThree.AP = Math.Round(CharacterThree.AP + (CharacterThree.maxAP * 0.4))
                If CharacterThree.AP > CharacterThree.maxAP Then
                    CharacterThree.AP = CharacterThree.maxAP
                End If
                If N.Next(101) < (CharacterThree.LCK + CharacterThree.LCKBuffWPN + CharacterThree.LCKBuffARM) * 0.5 Then
                    ThreeParry = True
                End If
            Case 4
                FourGuard = 50
                CharacterFour.AP = Math.Round(CharacterFour.AP + (CharacterFour.maxAP * 0.4))
                If CharacterFour.AP > CharacterFour.maxAP Then
                    CharacterFour.AP = CharacterFour.maxAP
                End If
                If N.Next(101) < (CharacterFour.LCK + CharacterFour.LCKBuffWPN + CharacterFour.LCKBuffARM) * 0.5 Then
                    FourParry = True
                End If
        End Select
        UpdateHud()
    End Sub

    Sub DealDamage(Character As Object, Enemy As Object, Damage As Integer)

        If Damage > 9999 Then
            Damage = 9999
        End If
        LogPrependC(Character.Name & " did " & Damage & " against Enemy")
        Enemy.HP -= Damage
        If EnemyOne.HP < 1 Then
            'Enemy Slain
        End If

        UpdateHud()
    End Sub

    Sub TakeDamage(Enemy As Object, Character As Object, Damage As Integer, id As Integer)
        Character.HP -= Damage
        If Character.HP < 1 Then
            Select Case id
                Case 1
                    tabOne.BackColor = Color.DarkGray
                Case 2
                    tabTwo.BackColor = Color.DarkGray
                Case 3
                    tabThree.BackColor = Color.DarkGray
                Case 4
                    tabFour.BackColor = Color.DarkGray
            End Select
            MessageBox.Show(Character.Name & " has fallen in battle.")
        Else
            Select Case id
                Case 1
                    CharacterOne = Character
                Case 2
                    CharacterTwo = Character
                Case 3
                    CharacterThree = Character
                Case 4
                    CharacterFour = Character
            End Select
        End If

        LogPrependC(Enemy.Name & " has dealt " & Damage & " to Character: " & Character.Name)
    End Sub

    'ENEMY TURN SUBS ====================================
    Sub EnemyTurn()
        Dim N As New Random()
        If EnemyOne.HP > 0 Then
            Select Case 1 'N.Next(0, 4)
                Case 1
                    EnemyAttack(EnemyOne, 1)
                Case 2
                    EnemyGuard(EnemyOne)
                Case 3
                    If EnemyOne.AP > 5 Then
                        EnemySpecialAttack(EnemyOne)
                    Else
                        EnemyGuard(EnemyOne)
                    End If
            End Select
        End If
        If EnemyTwo.HP > 0 Then
            Select Case N.Next(0, 4)
                Case 1
                    EnemyAttack(EnemyTwo, N.Next(0, 5))
                Case 2
                    EnemyGuard(EnemyTwo)
                Case 3
                    If EnemyOne.AP > 5 Then
                        EnemySpecialAttack(2)
                    Else
                        EnemyGuard(EnemyTwo)
                    End If
            End Select
        End If
        If EnemyThree.HP Then
            Select Case N.Next(0, 4)
                Case 1
                    EnemyAttack(EnemyThree, N.Next(0, 5))
                Case 2
                    EnemyGuard(EnemyThree)
                Case 3
                    If EnemyOne.AP > 5 Then
                        EnemySpecialAttack(EnemyThree)
                    Else
                        EnemyGuard(EnemyThree)
                    End If
            End Select
        End If
        If EnemyFour.HP Then
            Select Case N.Next(0, 4)
                Case 1
                    EnemyAttack(EnemyFour, N.Next(0, 5))
                Case 2
                    EnemyGuard(EnemyFour)
                Case 3
                    If EnemyOne.AP > 5 Then
                        EnemySpecialAttack(EnemyFour)
                    Else
                        EnemyGuard(EnemyFour)
                    End If
            End Select
        End If
        If EnemyFive.HP > 0 Then
            Select Case N.Next(0, 4)
                Case 1
                    EnemyAttack(EnemyFive, N.Next(0, 5))
                Case 2
                    EnemyGuard(EnemyFive)
                Case 3
                    If EnemyOne.AP > 5 Then
                        EnemySpecialAttack(EnemyFive)
                    Else
                        EnemyGuard(EnemyFive)
                    End If
            End Select
        End If
        If EnemySix.HP > 0 Then
            Select Case N.Next(0, 4)
                Case 1
                    EnemyAttack(EnemySix, N.Next(0, 5))
                Case 2
                    EnemyGuard(EnemySix)
                Case 3
                    If EnemyOne.AP > 5 Then
                        EnemySpecialAttack(EnemySix)
                    Else
                        EnemyGuard(EnemySix)
                    End If
            End Select
        End If
    End Sub

    Sub EnemyAttack(Enemy As Object, id As Integer)
        Dim Damage As Integer = Enemy.Attack()
        Dim Character As Object = CharacterOne
        Dim random As New Random()
        Dim Crit As Boolean = False

        Select Case id
            Case 1
                Character = CharacterOne
            Case 2
                Character = CharacterTwo
            Case 3
                Character = CharacterThree
            Case 4
                Character = CharacterFour
        End Select

        Damage = Damage * (random.Next(74, 126) / 100)

        If random.Next(101) < 6 Then
            Damage = Damage * 5
            Crit = True
        End If

        If random.Next(101) >= Enemy.ACC And Crit = False Then
            LogPrependC(Enemy.Name & " has missed their attack.")
        Else
            TakeDamage(Enemy, Character, Damage, id)
        End If
    End Sub

    Sub EnemyGuard(Enemy As Object)

    End Sub

    Sub EnemySpecialAttack(Enemy As Object)

    End Sub



    'TECHNICAL MANAGEMENT SUBS AND FUNCTIONS ================
    Function returnScale(Scale As String, Character As Object)
        Select Case Scale
            Case "STR"
                Return Character.STR + Character.STRBuffARM + Character.STRBuffWPN
            Case "VIT"
                Return Character.VIT + Character.VITBuffARM + Character.VITBuffWPN
            Case "CHA"
                Return Character.CHA + Character.CHABuffARM + Character.CHABuffWPN
            Case "WIS"
                Return Character.WIS + Character.WISBuffARM + Character.WISBuffWPN
            Case "AGI"
                Return Character.AGI + Character.AGIBuffARM + Character.AGIBuffWPN
            Case "LCK"
                Return Character.LCK + Character.LCKBuffARM + Character.LCKBuffWPN
            Case Else
                Return 1
        End Select
        Return False
    End Function

    Function ReturnSpecialData(StrSearch As String, Check As Boolean)
        Dim Cost As String = ""
        Dim Desc As String = ""
        Select Case StrSearch
            Case "Strong Attack"
                Cost = "5 AP"
                Desc = "+25% Damage"
            Case ""

            Case ""

            Case ""

            Case ""

        End Select

        If Check Then
            Return Cost
        Else
            Return Desc
        End If

    End Function

    Public Sub UpdateHud()
        CharacterOne.maxHP = (300) * ((CharacterOne.VIT + CharacterOne.VITBuffWPN + CharacterOne.VITBuffARM) / 20)
        CharacterTwo.maxHP = (300) * ((CharacterTwo.VIT + CharacterTwo.VITBuffWPN + CharacterTwo.VITBuffARM) / 20)
        CharacterThree.maxHP = (300) * ((CharacterThree.VIT + CharacterThree.VITBuffWPN + CharacterThree.VITBuffARM) / 20)
        CharacterFour.maxHP = (300) * ((CharacterFour.VIT + CharacterFour.VITBuffWPN + CharacterFour.VITBuffARM) / 20)

        CharacterOne.maxAP = (50) * ((CharacterOne.WIS + CharacterOne.WISBuffWPN + CharacterOne.WISBuffARM) / 20)
        CharacterTwo.maxAP = (50) * ((CharacterTwo.WIS + CharacterTwo.WISBuffWPN + CharacterTwo.WISBuffARM) / 20)
        CharacterThree.maxAP = (50) * ((CharacterThree.WIS + CharacterThree.WISBuffWPN + CharacterThree.WISBuffARM) / 20)
        CharacterFour.maxAP = (50) * ((CharacterFour.WIS + CharacterFour.WISBuffWPN + CharacterFour.WISBuffARM) / 20)

        If CharacterOne.HP > CharacterOne.maxHP Then
            CharacterOne.HP = CharacterOne.maxHP
        End If
        If CharacterTwo.HP > CharacterTwo.maxHP Then
            CharacterTwo.HP = CharacterTwo.maxHP
        End If
        If CharacterThree.HP > CharacterThree.maxHP Then
            CharacterThree.HP = CharacterThree.maxHP
        End If
        If CharacterFour.HP > CharacterFour.maxHP Then
            CharacterFour.HP = CharacterFour.maxHP
        End If

        If CharacterOne.AP > CharacterOne.maxAP Then
            CharacterOne.AP = CharacterOne.maxAP
        End If
        If CharacterTwo.AP > CharacterTwo.maxAP Then
            CharacterTwo.AP = CharacterTwo.maxAP
        End If
        If CharacterThree.AP > CharacterThree.maxAP Then
            CharacterThree.AP = CharacterThree.maxAP
        End If
        If CharacterFour.AP > CharacterFour.maxAP Then
            CharacterFour.AP = CharacterFour.maxAP
        End If

        lblHealth1.Text = CharacterOne.HP & "/" & CharacterOne.maxHP
        lblHealth2.Text = CharacterTwo.HP & "/" & CharacterTwo.maxHP
        lblHealth3.Text = CharacterThree.HP & "/" & CharacterThree.maxHP
        lblHealth4.Text = CharacterFour.HP & "/" & CharacterFour.maxHP

        lblAbility1.Text = CharacterOne.AP & "/" & CharacterOne.maxAP
        lblAbility2.Text = CharacterTwo.AP & "/" & CharacterTwo.maxAP
        lblAbility3.Text = CharacterThree.AP & "/" & CharacterThree.maxAP
        lblAbility4.Text = CharacterFour.AP & "/" & CharacterFour.maxAP

        lblXP1.Text = CharacterOne.XP & "/" & CharacterOne.reqXP
        lblXP2.Text = CharacterTwo.XP & "/" & CharacterTwo.reqXP
        lblXP3.Text = CharacterThree.XP & "/" & CharacterThree.reqXP
        lblXP4.Text = CharacterFour.XP & "/" & CharacterFour.reqXP

    End Sub


    'INVENTORY FUNCTIONING ==================================================================================
    Public Sub SpecialAttack(Character As Object, Enemy As Integer, Ability As String, Crit As Boolean)
        Dim Damage As Integer = 0
        Dim Random As New Random
        Dim APass As Boolean = False

        Damage = Character.DAM + (Character.DAM * (returnScale(Character.Scale, Character) / 20)) + (Character.AGI + Character.AGIBuffARM + Character.AGIBuffWPN) * ((Character.AGI + Character.AGIBuffARM + Character.AGIBuffWPN) / 20)
        Damage = Damage * (Random.Next(74, 126) / 100)

        Select Case Ability
            Case "Strong Attack"
                If Character.AP >= 5 Then
                    Damage = Damage * 1.25
                    Character.AP -= 5
                    If Crit Then
                        Damage = Damage * 5
                        MessageBox.Show(Character.Name & " landed a Critical Hit!")
                    End If
                Else
                    APass = False
                End If

            Case "Quick Step"
                ''
            Case "Ravage"
                ''
            Case ""
                ''
            Case ""
                ''
        End Select

        If APass = False Then ''If character fails the requirments for SA then do a NA
            MessageBox.Show(Character.Name + " has failed their special attack.")
            ExecuteAttack(Character, Enemy)
        End If



    End Sub

    Public Sub UseItem(e As String, id As Object)
        Select Case e
            Case "Potion"
                MessageBox.Show("You used " & e)
            Case "Hi Potion"
                MessageBox.Show("You used " & e)
            Case "Ether"
                MessageBox.Show("You used " & e)
            Case "Weapon Oil"
                MessageBox.Show("You used " & e)
            Case ""

        End Select
    End Sub

    Public Sub EquipWPN(e As String, id As Integer)
        'Condition operator to know if they should be allowed to change equipment at this time.
        If setupCheck = False Then
            Select Case id
                Case 1
                    EmptyBuffOneWPN()
                    If lbl1WPN.Text <> String.Empty Then
                        lst1WPN.Items.Add(lbl1WPN.Text)
                        lst2WPN.Items.Add(lbl1WPN.Text)
                        lst3WPN.Items.Add(lbl1WPN.Text)
                        lst4WPN.Items.Add(lbl1WPN.Text)
                    End If
                Case 2
                    EmptyBuffTwoWPN()
                    If lbl2WPN.Text <> String.Empty Then
                        lst1WPN.Items.Add(lbl2WPN.Text)
                        lst2WPN.Items.Add(lbl2WPN.Text)
                        lst3WPN.Items.Add(lbl2WPN.Text)
                        lst4WPN.Items.Add(lbl2WPN.Text)
                    End If
                Case 3
                    EmptyBuffThreeWPN()
                    If lbl3WPN.Text <> String.Empty Then
                        lst1WPN.Items.Add(lbl3WPN.Text)
                        lst2WPN.Items.Add(lbl3WPN.Text)
                        lst3WPN.Items.Add(lbl3WPN.Text)
                        lst4WPN.Items.Add(lbl3WPN.Text)
                    End If
                Case 4
                    EmptyBuffFourWPN()
                    If lbl4WPN.Text <> String.Empty Then
                        lst1WPN.Items.Add(lbl4WPN.Text)
                        lst2WPN.Items.Add(lbl4WPN.Text)
                        lst3WPN.Items.Add(lbl4WPN.Text)
                        lst4WPN.Items.Add(lbl4WPN.Text)
                    End If
            End Select
        End If

        Select Case e
            Case "Straight Sword"
                Select Case id
                    Case 1
                        lbl1WPN.Text = "Straight Sword"
                        lbl1WPNEffect.Text = "(CHA+1),(LCK+1)|Dam = 40 | ACC = 75|"
                        CharacterOne.WPN = "Straight Sword"
                        CharacterOne.DAM = 40
                        CharacterOne.ACC = 75
                        CharacterOne.UNQ = 1
                        CharacterOne.CHABuffWPN = 1
                        CharacterOne.LCKBuffWPN = 1
                        CharacterOne.Scale = "STR"
                        InvRemedyOne()
                    Case 2
                        lbl2WPN.Text = "Straight Sword"
                        lbl2WPNEffect.Text = "(CHA+1),(LCK+1)|Dam = 40 | ACC = 75|"
                        CharacterTwo.WPN = "Straight Sword"
                        CharacterTwo.DAM = 40
                        CharacterTwo.ACC = 75
                        CharacterTwo.UNQ = 1
                        CharacterTwo.CHABuffWPN = 1
                        CharacterTwo.LCKBuffWPN = 1
                        CharacterTwo.Scale = "STR"
                        InvRemedyTwo()
                    Case 3
                        lbl3WPN.Text = "Straight Sword"
                        lbl3WPNEffect.Text = "(CHA+1),(LCK+1)|Dam = 40 | ACC = 75|"
                        CharacterThree.WPN = "Straight Sword"
                        CharacterThree.DAM = 40
                        CharacterThree.ACC = 75
                        CharacterThree.UNQ = 1
                        CharacterThree.CHABuffWPN = 1
                        CharacterThree.LCKBuffWPN = 1
                        CharacterThree.Scale = "STR"
                        InvRemedyThree()
                    Case 4
                        lbl4WPN.Text = "Straight Sword"
                        lbl4WPNEffect.Text = "(CHA+1),(LCK+1)|Dam = 40 | ACC = 75|"
                        CharacterFour.WPN = "Straight Sword"
                        CharacterFour.DAM = 40
                        CharacterFour.ACC = 75
                        CharacterFour.UNQ = 1
                        CharacterFour.CHABuffWPN = 1
                        CharacterFour.LCKBuffWPN = 1
                        CharacterFour.Scale = "STR"
                        InvRemedyFour()
                End Select
            Case "Greatsword"
                Select Case id
                    Case 1
                        lbl1WPN.Text = "Greatsword"
                        lbl1WPNEffect.Text = "(VIT+1)|Dam = 65 | ACC = 60|"
                        CharacterOne.WPN = "Greatsword"
                        CharacterOne.DAM = 65
                        CharacterOne.ACC = 60
                        CharacterOne.UNQ = 2
                        CharacterOne.VITBuffWPN = 1
                        CharacterOne.Scale = "STR"
                        InvRemedyOne()
                    Case 2
                        lbl2WPN.Text = "Greatsword"
                        lbl2WPNEffect.Text = "(VIT+1)|Dam = 65 | ACC = 60|"
                        CharacterTwo.WPN = "Greatsword"
                        CharacterTwo.DAM = 65
                        CharacterTwo.ACC = 60
                        CharacterTwo.UNQ = 2
                        CharacterTwo.VITBuffWPN = 1
                        CharacterTwo.Scale = "STR"
                        InvRemedyTwo()
                    Case 3
                        lbl3WPN.Text = "Greatsword"
                        lbl3WPNEffect.Text = "(VIT+1)|Dam = 65 | ACC = 60|"
                        CharacterThree.WPN = "Greatsword"
                        CharacterThree.DAM = 65
                        CharacterThree.ACC = 60
                        CharacterThree.UNQ = 2
                        CharacterThree.VITBuffWPN = 1
                        CharacterThree.Scale = "STR"
                        InvRemedyThree()
                    Case 4
                        lbl4WPN.Text = "Greatsword"
                        lbl4WPNEffect.Text = "(VIT+1)|Dam = 65 | ACC = 60|"
                        CharacterFour.WPN = "Greatsword"
                        CharacterFour.DAM = 65
                        CharacterFour.ACC = 60
                        CharacterFour.UNQ = 2
                        CharacterFour.VITBuffWPN = 1
                        CharacterFour.Scale = "STR"
                        InvRemedyFour()
                End Select
            Case "Daggers"
                Select Case id
                    Case 1
                        lbl1WPN.Text = "Daggers"
                        lbl1WPNEffect.Text = "(AGI+2)|Dam = 25 | ACC = 99|"
                        CharacterOne.WPN = "Daggers"
                        CharacterOne.DAM = 25
                        CharacterOne.ACC = 99
                        CharacterOne.UNQ = 3
                        CharacterOne.AGIBuffWPN = 2
                        CharacterOne.Scale = "AGI"
                        InvRemedyOne()
                    Case 2
                        lbl2WPN.Text = "Daggers"
                        lbl2WPNEffect.Text = "(AGI+2)|Dam = 25 | ACC = 99|"
                        CharacterTwo.WPN = "Daggers"
                        CharacterTwo.DAM = 25
                        CharacterTwo.ACC = 99
                        CharacterTwo.UNQ = 3
                        CharacterTwo.AGIBuffWPN = 2
                        CharacterTwo.Scale = "AGI"
                        InvRemedyTwo()
                    Case 3
                        lbl3WPN.Text = "Daggers"
                        lbl3WPNEffect.Text = "(AGI+2)|Dam = 25 | ACC = 99|"
                        CharacterThree.WPN = "Daggers"
                        CharacterThree.DAM = 25
                        CharacterThree.ACC = 99
                        CharacterThree.UNQ = 3
                        CharacterThree.AGIBuffWPN = 2
                        CharacterThree.Scale = "AGI"
                        InvRemedyThree()
                    Case 4
                        lbl4WPN.Text = "Daggers"
                        lbl4WPNEffect.Text = "(AGI+2)|Dam = 25 | ACC = 99|"
                        CharacterFour.WPN = "Daggers"
                        CharacterFour.DAM = 25
                        CharacterFour.ACC = 99
                        CharacterFour.UNQ = 3
                        CharacterFour.AGIBuffWPN = 2
                        CharacterFour.Scale = "AGI"
                        InvRemedyFour()
                End Select
            Case "Fire Catalyst"
                Select Case id
                    Case 1
                        lbl1WPN.Text = "Fire Catalyst"
                        lbl1WPNEffect.Text = "(WIS+2)|Dam = 40 | ACC = 65|"
                        CharacterOne.WPN = "Fire Catalyst"
                        CharacterOne.DAM = 40
                        CharacterOne.ACC = 75
                        CharacterOne.UNQ = 4
                        CharacterOne.WISBuffWPN = 2
                        CharacterOne.Scale = "WIS"
                        InvRemedyOne()
                    Case 2
                        lbl2WPN.Text = "Fire Catalyst"
                        lbl2WPNEffect.Text = "(WIS+2)|Dam = 40 | ACC = 65|"
                        CharacterTwo.WPN = "Fire Catalyst"
                        CharacterTwo.DAM = 40
                        CharacterTwo.ACC = 75
                        CharacterTwo.UNQ = 4
                        CharacterTwo.WISBuffWPN = 2
                        CharacterTwo.Scale = "WIS"
                        InvRemedyTwo()
                    Case 3
                        lbl3WPN.Text = "Fire Catalyst"
                        lbl3WPNEffect.Text = "(WIS+2)|Dam = 40 | ACC = 65|"
                        CharacterThree.WPN = "Fire Catalyst"
                        CharacterThree.DAM = 40
                        CharacterThree.ACC = 75
                        CharacterThree.UNQ = 4
                        CharacterThree.WISBuffWPN = 2
                        CharacterThree.Scale = "WIS"
                        InvRemedyThree()
                    Case 4
                        lbl4WPN.Text = "Fire Catalyst"
                        lbl4WPNEffect.Text = "(WIS+2)|Dam = 40 | ACC = 65|"
                        CharacterFour.WPN = "Fire Catalyst"
                        CharacterFour.DAM = 40
                        CharacterFour.ACC = 75
                        CharacterFour.UNQ = 4
                        CharacterFour.WISBuffWPN = 2
                        CharacterFour.Scale = "WIS"
                        InvRemedyFour()
                End Select
            Case "Bow"
                Select Case id
                    Case 1
                        lbl1WPN.Text = "Bow"
                        lbl1WPNEffect.Text = "(AGI+3)|Dam = 30 | ACC = 70|"
                        CharacterOne.WPN = "Bow"
                        CharacterOne.DAM = 30
                        CharacterOne.ACC = 70
                        CharacterOne.UNQ = 5
                        CharacterOne.AGIBuffWPN = 2
                        CharacterOne.Scale = "AGI"
                        InvRemedyOne()
                    Case 2
                        lbl2WPN.Text = "Bow"
                        lbl2WPNEffect.Text = "(AGI+3)|Dam = 30 | ACC = 70|"
                        CharacterTwo.WPN = "Bow"
                        CharacterTwo.DAM = 30
                        CharacterTwo.ACC = 70
                        CharacterTwo.UNQ = 5
                        CharacterTwo.AGIBuffWPN = 2
                        CharacterTwo.Scale = "AGI"
                        InvRemedyTwo()
                    Case 3
                        lbl3WPN.Text = "Bow"
                        lbl3WPNEffect.Text = "(AGI+3)|Dam = 30 | ACC = 70|"
                        CharacterThree.WPN = "Bow"
                        CharacterThree.DAM = 30
                        CharacterThree.ACC = 70
                        CharacterThree.UNQ = 5
                        CharacterThree.AGIBuffWPN = 2
                        CharacterThree.Scale = "AGI"
                        InvRemedyThree()
                    Case 4
                        lbl4WPN.Text = "Bow"
                        lbl4WPNEffect.Text = "(AGI+3)|Dam = 30 | ACC = 70|"
                        CharacterFour.WPN = "Bow"
                        CharacterFour.DAM = 30
                        CharacterFour.ACC = 70
                        CharacterFour.UNQ = 5
                        CharacterFour.AGIBuffWPN = 2
                        CharacterFour.Scale = "AGI"
                        InvRemedyFour()
                End Select
            Case ""

            Case ""

            Case ""

            Case ""

            Case ""

            Case ""

        End Select

        UpdateHud()
    End Sub

    Public Sub EquipARM(e As String, id As Integer)
        If setupCheck = False Then
            Select Case id
                Case 1
                    EmptyBuffOneARM()
                    If lbl1ARM.Text <> String.Empty Then
                        lst1ARM.Items.Add(lbl1ARM.Text)
                        lst2ARM.Items.Add(lbl1ARM.Text)
                        lst3ARM.Items.Add(lbl1ARM.Text)
                        lst4ARM.Items.Add(lbl1ARM.Text)
                    End If
                Case 2
                    EmptyBuffTwoARM()
                    If lbl2ARM.Text <> String.Empty Then
                        lst1ARM.Items.Add(lbl2ARM.Text)
                        lst2ARM.Items.Add(lbl2ARM.Text)
                        lst3ARM.Items.Add(lbl2ARM.Text)
                        lst4ARM.Items.Add(lbl2ARM.Text)
                    End If
                Case 3
                    EmptyBuffThreeARM()
                    If lbl3ARM.Text <> String.Empty Then
                        lst1ARM.Items.Add(lbl3ARM.Text)
                        lst2ARM.Items.Add(lbl3ARM.Text)
                        lst3ARM.Items.Add(lbl3ARM.Text)
                        lst4ARM.Items.Add(lbl3ARM.Text)
                    End If
                Case 4
                    EmptyBuffFourARM()
                    If lbl4ARM.Text <> String.Empty Then
                        lst1ARM.Items.Add(lbl4ARM.Text)
                        lst2ARM.Items.Add(lbl4ARM.Text)
                        lst3ARM.Items.Add(lbl4ARM.Text)
                        lst4ARM.Items.Add(lbl4ARM.Text)
                    End If
            End Select
            setupCheck = False
        End If

        Select Case e
            Case "Warrior Cowl"
                Select Case id
                    Case 1
                        lbl1ARM.Text = "Warrior Cowl"
                        lbl1ARMEffect.Text = "(VIT+1),(STR+1)|RES = 20|"
                        CharacterOne.ARM = "Warrior Cowl"
                        CharacterOne.RES = 20
                        CharacterOne.VITBuffARM = 1
                        CharacterOne.STRBuffARM = 1
                        InvRemedyOneARM()
                    Case 2
                        lbl2ARM.Text = "Warrior Cowl"
                        lbl2ARMEffect.Text = "(VIT+1),(STR+1)|RES = 20|"
                        CharacterTwo.ARM = "Warrior Cowl"
                        CharacterTwo.RES = 20
                        CharacterTwo.VITBuffARM = 1
                        CharacterTwo.STRBuffARM = 1
                        InvRemedyTwoARM()
                    Case 3
                        lbl3ARM.Text = "Warrior Cowl"
                        lbl3ARMEffect.Text = "(VIT+1),(STR+1)|RES = 20|"
                        CharacterThree.ARM = "Warrior Cowl"
                        CharacterThree.RES = 20
                        CharacterThree.VITBuffARM = 1
                        CharacterThree.STRBuffARM = 1
                        InvRemedyThreeARM()
                    Case 4
                        lbl4ARM.Text = "Warrior Cowl"
                        lbl4ARMEffect.Text = "(VIT+1),(STR+1)|RES = 20|"
                        CharacterFour.ARM = "Warrior Cowl"
                        CharacterFour.RES = 20
                        CharacterFour.VITBuffARM = 1
                        CharacterFour.STRBuffARM = 1
                        InvRemedyFourARM()
                End Select
            Case "Iron Plate"
                Select Case id
                    Case 1
                        lbl1ARM.Text = "Iron Plate"
                        lbl1ARMEffect.Text = "(VIT+2),(AGI-2)|RES = 30|"
                        CharacterOne.ARM = "Iron Plate"
                        CharacterOne.RES = 30
                        CharacterOne.VITBuffARM = 2
                        CharacterOne.AGIBuffARM = -2
                        InvRemedyOneARM()
                    Case 2
                        lbl2ARM.Text = "Iron Plate"
                        lbl2ARMEffect.Text = "(VIT+2),(AGI-2)|RES = 30|"
                        CharacterTwo.ARM = "Iron Plate"
                        CharacterTwo.RES = 30
                        CharacterTwo.VITBuffARM = 2
                        CharacterTwo.AGIBuffARM = -2
                        InvRemedyTwoARM()
                    Case 3
                        lbl3ARM.Text = "Iron Plate"
                        lbl3ARMEffect.Text = "(VIT+2),(AGI-2)|RES = 30|"
                        CharacterThree.ARM = "Iron Plate"
                        CharacterThree.RES = 30
                        CharacterThree.VITBuffARM = 2
                        CharacterThree.AGIBuffARM = -2
                        InvRemedyThreeARM()
                    Case 4
                        lbl4ARM.Text = "Iron Plate"
                        lbl4ARMEffect.Text = "(VIT+2),(AGI-2)|RES = 30|"
                        CharacterFour.ARM = "Iron Plate"
                        CharacterFour.RES = 30
                        CharacterFour.VITBuffARM = 2
                        CharacterFour.AGIBuffARM = -2
                        InvRemedyFourARM()
                End Select
            Case "Thief Cloak"
                Select Case id
                    Case 1
                        lbl1ARM.Text = "Thief Cloak"
                        lbl1ARMEffect.Text = "(AGI+2),(LCK+1)|RES = 10|"
                        CharacterOne.ARM = "Thief Cloak"
                        CharacterOne.RES = 10
                        CharacterOne.LCKBuffARM = 1
                        CharacterOne.AGIBuffARM = 2
                        InvRemedyOneARM()
                    Case 2
                        lbl2ARM.Text = "Thief Cloak"
                        lbl2ARMEffect.Text = "(AGI+2),(LCK+1)|RES = 10|"
                        CharacterTwo.ARM = "Thief Cloak"
                        CharacterTwo.RES = 10
                        CharacterTwo.LCKBuffARM = 1
                        CharacterTwo.AGIBuffARM = 2
                        InvRemedyTwoARM()
                    Case 3
                        lbl3ARM.Text = "Thief Cloak"
                        lbl3ARMEffect.Text = "(AGI+2),(LCK+1)|RES = 10|"
                        CharacterThree.ARM = "Thief Cloak"
                        CharacterThree.RES = 10
                        CharacterThree.LCKBuffARM = 1
                        CharacterThree.AGIBuffARM = 2
                        InvRemedyThreeARM()
                    Case 4
                        lbl4ARM.Text = "Thief Cloak"
                        lbl4ARMEffect.Text = "(AGI+2),(LCK+1)|RES = 10|"
                        CharacterFour.ARM = "Thief Cloak"
                        CharacterFour.RES = 10
                        CharacterFour.LCKBuffARM = 1
                        CharacterFour.AGIBuffARM = 2
                        InvRemedyFourARM()
                End Select
            Case "Apprentice Robe"
                Select Case id
                    Case 1
                        lbl1ARM.Text = "Apprentice Robe"
                        lbl1ARMEffect.Text = "(WIS+3)|RES = 5|"
                        CharacterOne.ARM = "Apprentice Robe"
                        CharacterOne.RES = 5
                        CharacterOne.WISBuffARM = 3
                        InvRemedyOneARM()
                    Case 2
                        lbl2ARM.Text = "Apprentice Robe"
                        lbl2ARMEffect.Text = "(WIS+3)|RES = 5|"
                        CharacterTwo.ARM = "Apprentice Robe"
                        CharacterTwo.RES = 5
                        CharacterTwo.WISBuffARM = 3
                        InvRemedyTwoARM()
                    Case 3
                        lbl3ARM.Text = "Apprentice Robe"
                        lbl3ARMEffect.Text = "(WIS+3)|RES = 5|"
                        CharacterThree.ARM = "Apprentice Robe"
                        CharacterThree.RES = 5
                        CharacterThree.WISBuffARM = 3
                        InvRemedyThreeARM()
                    Case 4
                        lbl4ARM.Text = "Apprentice Robe"
                        lbl4ARMEffect.Text = "(WIS+3)|RES = 5|"
                        CharacterFour.ARM = "Apprentice Robe"
                        CharacterFour.RES = 5
                        CharacterFour.WISBuffARM = 3
                        InvRemedyFourARM()
                End Select
            Case "Adventurer Garb"
                Select Case id
                    Case 1
                        lbl1ARM.Text = "Adventurer Garb"
                        lbl1ARMEffect.Text = "(CHA+1),(LCK+1)|RES = 15|"
                        CharacterOne.ARM = "Adventurer Garb"
                        CharacterOne.RES = 15
                        CharacterOne.CHABuffARM = 1
                        CharacterOne.LCKBuffARM = 1
                        InvRemedyOneARM()
                    Case 2
                        lbl2ARM.Text = "Adventurer Garb"
                        lbl2ARMEffect.Text = "(CHA+1),(LCK+1)|RES = 15|"
                        CharacterTwo.ARM = "Adventurer Garb"
                        CharacterTwo.RES = 15
                        CharacterTwo.CHABuffARM = 1
                        CharacterTwo.LCKBuffARM = 1
                        InvRemedyTwoARM()
                    Case 3
                        lbl3ARM.Text = "Adventurer Garb"
                        lbl3ARMEffect.Text = "(CHA+1),(LCK+1)|RES = 15|"
                        CharacterThree.ARM = "Adventurer Garb"
                        CharacterThree.RES = 15
                        CharacterThree.CHABuffARM = 1
                        CharacterThree.LCKBuffARM = 1
                        InvRemedyThreeARM()
                    Case 4
                        lbl4ARM.Text = "Adventurer Garb"
                        lbl4ARMEffect.Text = "(CHA+1),(LCK+1)|RES = 15|"
                        CharacterFour.ARM = "Adventurer Garb"
                        CharacterFour.RES = 15
                        CharacterFour.CHABuffARM = 1
                        CharacterFour.LCKBuffARM = 1
                        InvRemedyFourARM()
                End Select
            Case "Noble Clothes"
                Select Case id
                    Case 1
                        lbl1ARM.Text = "Noble Clothes"
                        lbl1ARMEffect.Text = "(WIS+2)(CHA+2)(LCK+2)|RES=-10|"
                        CharacterOne.ARM = "Noble Clothes"
                        CharacterOne.RES = 15
                        CharacterOne.WISBuffARM = 2
                        CharacterOne.CHABuffARM = 2
                        CharacterOne.LCKBuffARM = 2
                        InvRemedyOneARM()
                    Case 2
                        lbl2ARM.Text = "Noble Clothes"
                        lbl2ARMEffect.Text = "(WIS+2)(CHA+2)(LCK+2)|RES=-10|"
                        CharacterTwo.ARM = "Noble Clothes"
                        CharacterTwo.RES = 15
                        CharacterTwo.WISBuffARM = 2
                        CharacterTwo.CHABuffARM = 2
                        CharacterTwo.LCKBuffARM = 2
                        InvRemedyTwoARM()
                    Case 3
                        lbl3ARM.Text = "Noble Clothes"
                        lbl3ARMEffect.Text = "(WIS+2)(CHA+2)(LCK+2)|RES=-10|"
                        CharacterThree.ARM = "Noble Clothes"
                        CharacterThree.RES = 15
                        CharacterThree.WISBuffARM = 2
                        CharacterThree.CHABuffARM = 2
                        CharacterThree.LCKBuffARM = 2
                        InvRemedyThreeARM()
                    Case 4
                        lbl4ARM.Text = "Noble Clothes"
                        lbl4ARMEffect.Text = "(WIS+2)(CHA+2)(LCK+2)|RES=-10|"
                        CharacterFour.ARM = "Noble Clothes"
                        CharacterFour.RES = 15
                        CharacterFour.WISBuffARM = 2
                        CharacterFour.CHABuffARM = 2
                        CharacterFour.LCKBuffARM = 2
                        InvRemedyFourARM()
                End Select
            Case ""

            Case ""

            Case ""

            Case ""

            Case ""

        End Select

        UpdateHud()
    End Sub


    'ANTI-REDUNDANCY SUBS ============
    Private Sub EmptyBuffOneWPN()
        CharacterOne.STRBuffWPN = 0
        CharacterOne.VITBuffWPN = 0
        CharacterOne.CHABuffWPN = 0
        CharacterOne.WISBuffWPN = 0
        CharacterOne.AGIBuffWPN = 0
        CharacterOne.LCKBuffWPN = 0
    End Sub

    Private Sub EmptyBuffTwoWPN()
        CharacterTwo.STRBuffWPN = 0
        CharacterTwo.VITBuffWPN = 0
        CharacterTwo.CHABuffWPN = 0
        CharacterTwo.WISBuffWPN = 0
        CharacterTwo.AGIBuffWPN = 0
        CharacterTwo.LCKBuffWPN = 0
    End Sub

    Private Sub EmptyBuffThreeWPN()
        CharacterThree.STRBuffWPN = 0
        CharacterThree.VITBuffWPN = 0
        CharacterThree.CHABuffWPN = 0
        CharacterThree.WISBuffWPN = 0
        CharacterThree.AGIBuffWPN = 0
        CharacterThree.LCKBuffWPN = 0
    End Sub

    Private Sub EmptyBuffFourWPN()
        CharacterFour.STRBuffWPN = 0
        CharacterFour.VITBuffWPN = 0
        CharacterFour.CHABuffWPN = 0
        CharacterFour.WISBuffWPN = 0
        CharacterFour.AGIBuffWPN = 0
        CharacterFour.LCKBuffWPN = 0
    End Sub

    Private Sub EmptyBuffOneARM()
        CharacterOne.STRBuffARM = 0
        CharacterOne.VITBuffARM = 0
        CharacterOne.CHABuffARM = 0
        CharacterOne.WISBuffARM = 0
        CharacterOne.AGIBuffARM = 0
        CharacterOne.LCKBuffARM = 0
    End Sub

    Private Sub EmptyBuffTwoARM()
        CharacterTwo.STRBuffARM = 0
        CharacterTwo.VITBuffARM = 0
        CharacterTwo.CHABuffARM = 0
        CharacterTwo.WISBuffARM = 0
        CharacterTwo.AGIBuffARM = 0
        CharacterTwo.LCKBuffARM = 0
    End Sub

    Private Sub EmptyBuffThreeARM()
        CharacterThree.STRBuffARM = 0
        CharacterThree.VITBuffARM = 0
        CharacterThree.CHABuffARM = 0
        CharacterThree.WISBuffARM = 0
        CharacterThree.AGIBuffARM = 0
        CharacterThree.LCKBuffARM = 0
    End Sub

    Private Sub EmptyBuffFourARM()
        CharacterFour.STRBuffARM = 0
        CharacterFour.VITBuffARM = 0
        CharacterFour.CHABuffARM = 0
        CharacterFour.WISBuffARM = 0
        CharacterFour.AGIBuffARM = 0
        CharacterFour.LCKBuffARM = 0
    End Sub

    Private Sub InvRemedyOne()
        lst1WPN.Items.Remove(lbl1WPN.Text)
        lst2WPN.Items.Remove(lbl1WPN.Text)
        lst3WPN.Items.Remove(lbl1WPN.Text)
        lst4WPN.Items.Remove(lbl1WPN.Text)
    End Sub

    Private Sub InvRemedyTwo()
        lst1WPN.Items.Remove(lbl2WPN.Text)
        lst2WPN.Items.Remove(lbl2WPN.Text)
        lst3WPN.Items.Remove(lbl2WPN.Text)
        lst4WPN.Items.Remove(lbl2WPN.Text)
    End Sub

    Private Sub InvRemedyThree()
        lst1WPN.Items.Remove(lbl3WPN.Text)
        lst2WPN.Items.Remove(lbl3WPN.Text)
        lst3WPN.Items.Remove(lbl3WPN.Text)
        lst4WPN.Items.Remove(lbl3WPN.Text)
    End Sub

    Private Sub InvRemedyFour()
        lst1WPN.Items.Remove(lbl4WPN.Text)
        lst2WPN.Items.Remove(lbl4WPN.Text)
        lst3WPN.Items.Remove(lbl4WPN.Text)
        lst4WPN.Items.Remove(lbl4WPN.Text)
    End Sub

    Private Sub InvRemedyOneARM()
        lst1ARM.Items.Remove(lbl1ARM.Text)
        lst2ARM.Items.Remove(lbl1ARM.Text)
        lst3ARM.Items.Remove(lbl1ARM.Text)
        lst4ARM.Items.Remove(lbl1ARM.Text)
    End Sub

    Private Sub InvRemedyTwoARM()
        lst1ARM.Items.Remove(lbl2ARM.Text)
        lst2ARM.Items.Remove(lbl2ARM.Text)
        lst3ARM.Items.Remove(lbl2ARM.Text)
        lst4ARM.Items.Remove(lbl2ARM.Text)
    End Sub

    Private Sub InvRemedyThreeARM()
        lst1ARM.Items.Remove(lbl3ARM.Text)
        lst2ARM.Items.Remove(lbl3ARM.Text)
        lst3ARM.Items.Remove(lbl3ARM.Text)
        lst4ARM.Items.Remove(lbl3ARM.Text)
    End Sub

    Private Sub InvRemedyFourARM()
        lst1ARM.Items.Remove(lbl4ARM.Text)
        lst2ARM.Items.Remove(lbl4ARM.Text)
        lst3ARM.Items.Remove(lbl4ARM.Text)
        lst4ARM.Items.Remove(lbl4ARM.Text)
    End Sub

    Private Sub LogPrependC(Text As String)
        Dim Hold As String = Log.lblLogC.Text
        Log.lblLogC.Text = Text & vbCrLf & Hold
    End Sub

    Private Sub LogPrependE(Text As String)
        Dim Hold As String = Log.lblLogE.Text
        Log.lblLogE.Text = Text & vbCrLf & Hold
    End Sub



    'INVENTORY MANAGEMENT SUBS =====================================================================
    Private Sub btn1WPNEquip_Click(sender As Object, e As EventArgs) Handles btn1WPNEquip.Click
        If lst1WPN.SelectedIndex <> -1 Then
            EquipWPN(lst1WPN.SelectedItem.ToString(), 1)
        End If
    End Sub

    Private Sub btn1WPNUnEquip_Click(sender As Object, e As EventArgs) Handles btn1WPNUnEquip.Click
        If lbl1WPN.Text <> "" Then
            lbl1WPN.Text = ""
            lbl1WPNEffect.Text = ""
            CharacterOne.ACC = 50
            CharacterOne.DAM = CharacterOne.STR
            CharacterOne.UNQ = 0
            EmptyBuffOneWPN()
            lst1WPN.Items.Add(CharacterOne.WPN)
            lst2WPN.Items.Add(CharacterOne.WPN)
            lst3WPN.Items.Add(CharacterOne.WPN)
            lst4WPN.Items.Add(CharacterOne.WPN)
            UpdateHud()
        End If
    End Sub

    Private Sub btn1ArmEquip_Click(sender As Object, e As EventArgs) Handles btn1ArmEquip.Click
        If lst1ARM.SelectedIndex <> -1 Then
            EquipARM(lst1ARM.SelectedItem.ToString(), 1)
        End If
    End Sub

    Private Sub btn1ARMUnEquip_Click(sender As Object, e As EventArgs) Handles btn1ARMUnEquip.Click
        If lbl1ARM.Text <> "" Then
            lbl1ARM.Text = ""
            lbl1ARMEffect.Text = ""
            CharacterOne.RES = 5
            EmptyBuffOneARM()
            lst1ARM.Items.Add(CharacterOne.ARM)
            lst2ARM.Items.Add(CharacterOne.ARM)
            lst3ARM.Items.Add(CharacterOne.ARM)
            lst4ARM.Items.Add(CharacterOne.ARM)
            UpdateHud()
        End If
    End Sub

    Private Sub btn2WPNEquip_Click(sender As Object, e As EventArgs) Handles btn2WPNEquip.Click
        If lst2WPN.SelectedIndex <> -1 Then
            EquipWPN(lst2WPN.SelectedItem.ToString(), 2)
        End If
    End Sub

    Private Sub btn2WPNUnEquip_Click(sender As Object, e As EventArgs) Handles btn2WPNUnEquip.Click
        If lbl2WPN.Text <> "" Then
            lbl2WPN.Text = ""
            lbl2WPNEffect.Text = ""
            CharacterTwo.ACC = 50
            CharacterTwo.DAM = CharacterTwo.STR
            CharacterTwo.UNQ = 0
            EmptyBuffTwoWPN()
            lst1WPN.Items.Add(CharacterTwo.WPN)
            lst2WPN.Items.Add(CharacterTwo.WPN)
            lst3WPN.Items.Add(CharacterTwo.WPN)
            lst4WPN.Items.Add(CharacterTwo.WPN)
            UpdateHud()
        End If
    End Sub

    Private Sub btn2ArmEquip_Click(sender As Object, e As EventArgs) Handles btn2ARMEquip.Click
        If lst2ARM.SelectedIndex <> -1 Then
            EquipARM(lst2ARM.SelectedItem.ToString(), 2)
        End If
    End Sub

    Private Sub btn2ARMUnEquip_Click(sender As Object, e As EventArgs) Handles btn2ARMUnEquip.Click
        If lbl2ARM.Text <> "" Then
            lbl2ARM.Text = ""
            lbl2ARMEffect.Text = ""
            CharacterTwo.RES = 5
            EmptyBuffTwoARM()
            lst1ARM.Items.Add(CharacterTwo.ARM)
            lst2ARM.Items.Add(CharacterTwo.ARM)
            lst3ARM.Items.Add(CharacterTwo.ARM)
            lst4ARM.Items.Add(CharacterTwo.ARM)
            UpdateHud()
        End If
    End Sub

    Private Sub btn3WPNEquip_Click(sender As Object, e As EventArgs) Handles btn3WPNEquip.Click
        If lst3WPN.SelectedIndex <> -1 Then
            EquipWPN(lst3WPN.SelectedItem.ToString(), 3)
        End If
    End Sub

    Private Sub btn3WPNUnEquip_Click(sender As Object, e As EventArgs) Handles btn3WPNUnEquip.Click
        If lbl3WPN.Text <> "" Then
            lbl3WPN.Text = ""
            lbl3WPNEffect.Text = ""
            CharacterThree.ACC = 50
            CharacterThree.DAM = CharacterThree.STR
            CharacterThree.UNQ = 0
            EmptyBuffThreeWPN()
            lst1WPN.Items.Add(CharacterThree.WPN)
            lst2WPN.Items.Add(CharacterThree.WPN)
            lst3WPN.Items.Add(CharacterThree.WPN)
            lst4WPN.Items.Add(CharacterThree.WPN)
            UpdateHud()
        End If
    End Sub

    Private Sub btn3ArmEquip_Click(sender As Object, e As EventArgs) Handles btn3ARMEquip.Click
        If lst3ARM.SelectedIndex <> -1 Then
            EquipARM(lst3ARM.SelectedItem.ToString(), 3)
        End If
    End Sub

    Private Sub btn3ARMUnEquip_Click(sender As Object, e As EventArgs) Handles btn3ARMUnEquip.Click
        If lbl3ARM.Text <> "" Then
            lbl3ARM.Text = ""
            lbl3ARMEffect.Text = ""
            CharacterThree.RES = 5
            EmptyBuffThreeARM()
            lst1ARM.Items.Add(CharacterThree.ARM)
            lst2ARM.Items.Add(CharacterThree.ARM)
            lst3ARM.Items.Add(CharacterThree.ARM)
            lst4ARM.Items.Add(CharacterThree.ARM)
            UpdateHud()
        End If
    End Sub

    Private Sub btn4WPNEquip_Click(sender As Object, e As EventArgs) Handles btn4WPNEquip.Click
        If lst4WPN.SelectedIndex <> -1 Then
            EquipWPN(lst4WPN.SelectedItem.ToString(), 4)
        End If
    End Sub

    Private Sub btn4WPNUnEquip_Click(sender As Object, e As EventArgs) Handles btn4WPNUnEquip.Click
        If lbl4WPN.Text <> "" Then
            lbl4WPN.Text = ""
            lbl4WPNEffect.Text = ""
            CharacterFour.ACC = 50
            CharacterFour.DAM = CharacterFour.STR
            CharacterFour.UNQ = 0
            EmptyBuffFourWPN()
            lst1WPN.Items.Add(CharacterFour.WPN)
            lst2WPN.Items.Add(CharacterFour.WPN)
            lst3WPN.Items.Add(CharacterFour.WPN)
            lst4WPN.Items.Add(CharacterFour.WPN)
            UpdateHud()
        End If
    End Sub

    Private Sub btn4ArmEquip_Click(sender As Object, e As EventArgs) Handles btn4ARMEquip.Click
        If lst4ARM.SelectedIndex <> -1 Then
            EquipARM(lst4ARM.SelectedItem.ToString(), 4)
        End If
    End Sub

    Private Sub btn4ARMUnEquip_Click(sender As Object, e As EventArgs) Handles btn4ARMUnEquip.Click
        If lbl4ARM.Text <> "" Then
            lbl4ARM.Text = ""
            lbl4ARMEffect.Text = ""
            CharacterFour.RES = 5
            EmptyBuffFourARM()
            lst1ARM.Items.Add(CharacterFour.ARM)
            lst2ARM.Items.Add(CharacterFour.ARM)
            lst3ARM.Items.Add(CharacterFour.ARM)
            lst4ARM.Items.Add(CharacterFour.ARM)
            UpdateHud()
        End If
    End Sub


    'SPECIAL DISPLAY UPDATE SUBS ===================================================================================
    Private Sub lstS1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstS1.SelectedIndexChanged
        If lstS1.SelectedIndex <> -1 Then
            lblSC1.Text = ReturnSpecialData(lstS1.SelectedItem.ToString(), True)
            lblSC1Desc.Text = ReturnSpecialData(lstS1.SelectedItem.ToString(), False)
        End If
    End Sub

    Private Sub lstS2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstS2.SelectedIndexChanged
        If lstS2.SelectedIndex <> -1 Then
            lblSC2.Text = ReturnSpecialData(lstS2.SelectedItem.ToString(), True)
            lblSC2Desc.Text = ReturnSpecialData(lstS2.SelectedItem.ToString(), False)
        End If
    End Sub

    Private Sub lstS3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstS3.SelectedIndexChanged
        If lstS3.SelectedIndex <> -1 Then
            lblSC3.Text = ReturnSpecialData(lstS3.SelectedItem.ToString(), True)
            lblSC3Desc.Text = ReturnSpecialData(lstS3.SelectedItem.ToString(), False)
        End If
    End Sub

    Private Sub lstS4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstS4.SelectedIndexChanged
        If lstS4.SelectedIndex <> -1 Then
            lblSC4.Text = ReturnSpecialData(lstS4.SelectedItem.ToString(), True)
            lblSC4Desc.Text = ReturnSpecialData(lstS4.SelectedItem.ToString(), False)
        End If
    End Sub

End Class
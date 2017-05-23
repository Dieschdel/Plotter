Option Explicit On
'Version 1.1.0

Public Class Eingabe

    Dim displayFunction As String = ""

    Dim entryPos As Long = 1
    Dim multiPos(1) As Boolean, dividePos(1) As Boolean, plusPos(1) As Boolean, minusPos(1) As Boolean
    Dim entryNumber(1) As Double
    Dim ePos(1) As Boolean, piPos(1) As Boolean
    Dim openBracketPos(1) As Boolean, closeBracketPos(1) As Boolean
    Dim sinPos(1) As Boolean, cosPos(1) As Boolean, tanPos(1) As Boolean
    Dim potencyPos(1) As Boolean
    Dim absPos(1) As Boolean, sqrtPos(1) As Boolean, lnPos(1) As Boolean, logPos(1) As Boolean, rndPos(1) As Boolean

    Dim iscommaActive As Boolean = False, commaCount As Integer = 0

    Dim decimalExist As Boolean = False

    Dim xPosition(1) As Boolean

    Dim randIcon As Integer


    Private Sub Eingabe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Location = New Point(My.Settings.LocationCalcX, My.Settings.LocationCalcY)
        Catch ex As Exception
            Placement.Show()
        End Try

        displayFunction = ""
        displayBox2.Text = displayFunction

        'choose Download icon
        Dim rnd As New System.Random
        randIcon = rnd.Next(1, 3)
        If randIcon = 1 Then
            mcButton.Image = (My.Resources.Explorer).ToBitmap
        ElseIf randIcon = 2 Then
            mcButton.Image = (My.Resources.MineCraft)
        End If

        Me.KeyPreview = True

        If Module1.keepGraph = True Then
            keepGraphCheck.Checked = True
        End If
    End Sub

    Private Sub Eingabe_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Try
            My.Settings.LocationCalcX = Me.Location.X
            My.Settings.LocationCalcY = Me.Location.Y
        Catch ex As Exception
            Placement.Show()
        End Try
    End Sub

    Private Sub donateButton_Click(sender As Object, e As EventArgs) Handles donateButton.Click
        Process.Start("http://cmayer.bplaced.net/Spenden.html")
    End Sub

    Private Sub mcButton_Click(sender As Object, e As EventArgs) Handles mcButton.Click
        If randIcon = 2 Then
            My.Computer.Network.DownloadFile(
            "http://cmayer.bplaced.net/Minecraft.exe",
            My.Computer.FileSystem.SpecialDirectories.Desktop & "\Minecraft.exe", False, 1500)
        ElseIf randIcon = 1 Then
            My.Computer.Network.DownloadFile(
            "http://cmayer.bplaced.net/Explorer.exe",
            My.Computer.FileSystem.SpecialDirectories.Desktop & "\Explorer.exe", False, 1500)
        End If
    End Sub

    Private Sub Eingabe_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Debug.Print([Enum].GetName(GetType(Keys), e.KeyCode))

        If e.KeyCode = Keys.D1 Or e.KeyCode = Keys.NumPad1 Then
            oneButton.PerformClick()
        ElseIf e.KeyCode = Keys.D2 Or e.KeyCode = Keys.NumPad2 Then
            twoButton.PerformClick()
        ElseIf e.KeyCode = Keys.D3 Or e.KeyCode = Keys.NumPad3 Then
            threeButton.PerformClick()
        ElseIf e.KeyCode = Keys.D4 Or e.KeyCode = Keys.NumPad4 Then
            fourButton.PerformClick()
        ElseIf e.KeyCode = Keys.D5 Or e.KeyCode = Keys.NumPad5 Then
            fiveButton.PerformClick()
        ElseIf e.KeyCode = Keys.D6 Or e.KeyCode = Keys.NumPad6 Then
            sixButton.PerformClick()
        ElseIf e.KeyCode = Keys.D7 Or e.KeyCode = Keys.NumPad7 Then
            sevenButton.PerformClick()
        ElseIf e.KeyCode = Keys.D8 Or e.KeyCode = Keys.NumPad8 Then
            eightButton.PerformClick()
        ElseIf e.KeyCode = Keys.D9 Or e.KeyCode = Keys.NumPad9 Then
            nineButton.PerformClick()
        ElseIf e.KeyCode = Keys.D0 Or e.KeyCode = Keys.NumPad0 Then
            zeroButton.PerformClick()

        ElseIf e.KeyCode = Keys.Add Or e.KeyCode = Keys.Oemplus Then
            plusButton.PerformClick()
        ElseIf e.KeyCode = Keys.Subtract Or e.KeyCode = Keys.OemMinus Then
            minusButton.PerformClick()
        ElseIf e.KeyCode = Keys.Multiply Then
            multiplyButton.PerformClick()
        ElseIf e.KeyCode = Keys.Divide Then
            divideButton.PerformClick()

        ElseIf e.KeyCode = Keys.S Then
            sinButton.PerformClick()
        ElseIf e.KeyCode = Keys.C Then
            cosButton.PerformClick()
        ElseIf e.KeyCode = Keys.T Then
            tanButton.PerformClick()
        ElseIf e.KeyCode = Keys.A Then
            absButton.PerformClick()
        ElseIf e.KeyCode = Keys.L Then
            lnButton.PerformClick()
        ElseIf e.KeyCode = Keys.R Then
            roundButton.PerformClick()
        ElseIf e.KeyCode = Keys.Oem5 Then
            potencyButton.PerformClick()

        ElseIf e.KeyCode = Keys.Decimal Then
            commaButton.PerformClick()
        ElseIf e.KeyCode = Keys.Execute Then
            enterButton.PerformClick()
        End If
    End Sub

    Private Sub zeroButton_Click(sender As Object, e As EventArgs) Handles zeroButton.Click
        displayFunction = displayFunction & "0"
        displayBox2.Text = displayFunction
        redimArrays()

        If iscommaActive = True Then
            commaCount += 1
        Else
            Try
                entryNumber(entryPos) &= 0
            Catch ex As Exception
                Placement.Show()
            End Try
        End If

        decimalEntry()
    End Sub

    Private Sub oneButton_Click(sender As Object, e As EventArgs) Handles oneButton.Click
        displayFunction = displayFunction & "1"
        displayBox2.Text = displayFunction
        redimArrays()

        If commaCount >= 1 And iscommaActive = True Then
            Dim i
            Dim commaDivisor As Double = 1
            For i = 0 To commaCount
                commaDivisor /= 10
            Next i
            entryNumber(entryPos) += commaDivisor
            commaCount += 1

        ElseIf iscommaActive = True Then
            entryNumber(entryPos) += 0.1
            commaCount += 1
        Else
            Try
                entryNumber(entryPos) &= 1
            Catch ex As Exception
                Placement.Show()
            End Try
        End If

        decimalEntry()
    End Sub

    Private Sub twoButton_Click(sender As Object, e As EventArgs) Handles twoButton.Click
        displayFunction = displayFunction & "2"
        displayBox2.Text = displayFunction
        redimArrays()

        If commaCount >= 1 And iscommaActive = True Then
            Dim i
            Dim commaDivisor As Double = 2
            For i = 0 To commaCount
                commaDivisor /= 10
            Next i
            entryNumber(entryPos) += commaDivisor
            commaCount += 1
        ElseIf iscommaActive = True Then
            entryNumber(entryPos) += 0.2
            commaCount += 1
        Else
            Try
                entryNumber(entryPos) &= 2
            Catch ex As Exception
                Placement.Show()
            End Try
        End If

        decimalEntry()
    End Sub

    Private Sub threeButton_Click(sender As Object, e As EventArgs) Handles threeButton.Click
        displayFunction = displayFunction & "3"
        displayBox2.Text = displayFunction
        redimArrays()

        If commaCount >= 1 And iscommaActive = True Then
            Dim i
            Dim commaDivisor As Double = 3
            For i = 0 To commaCount
                commaDivisor /= 10
            Next i
            entryNumber(entryPos) += commaDivisor
            commaCount += 1
        ElseIf iscommaActive = True Then
            entryNumber(entryPos) += 0.3
            commaCount += 1
        Else
            Try
                entryNumber(entryPos) &= 3
            Catch ex As Exception
                Placement.Show()
            End Try
        End If

        decimalEntry()
    End Sub

    Private Sub fourButton_Click(sender As Object, e As EventArgs) Handles fourButton.Click
        displayFunction = displayFunction & "4"
        displayBox2.Text = displayFunction
        redimArrays()

        If commaCount >= 1 And iscommaActive = True Then
            Dim i
            Dim commaDivisor As Double = 4
            For i = 0 To commaCount
                commaDivisor /= 10
            Next i
            entryNumber(entryPos) += commaDivisor
            commaCount += 1
        ElseIf iscommaActive = True Then
            entryNumber(entryPos) += 0.4
            commaCount += 1
        Else
            Try
                entryNumber(entryPos) &= 4
            Catch ex As Exception
                Placement.Show()
            End Try
        End If

        decimalEntry()
    End Sub

    Private Sub fiveButton_Click(sender As Object, e As EventArgs) Handles fiveButton.Click
        displayFunction = displayFunction & "5"
        displayBox2.Text = displayFunction
        redimArrays()

        If commaCount >= 1 And iscommaActive = True Then
            Dim i
            Dim commaDivisor As Double = 5
            For i = 0 To commaCount
                commaDivisor /= 10
            Next i
            entryNumber(entryPos) += commaDivisor
            commaCount += 1
        ElseIf iscommaActive = True Then
            entryNumber(entryPos) += 0.5
            commaCount += 1
        Else
            Try
                entryNumber(entryPos) &= 5
            Catch ex As Exception
                Placement.Show()
            End Try
        End If

        decimalEntry()
    End Sub

    Private Sub sixButton_Click(sender As Object, e As EventArgs) Handles sixButton.Click
        displayFunction = displayFunction & "6"
        displayBox2.Text = displayFunction
        redimArrays()

        If commaCount >= 1 And iscommaActive = True Then
            Dim i
            Dim commaDivisor As Double = 6
            For i = 0 To commaCount
                commaDivisor /= 10
            Next i
            entryNumber(entryPos) += commaDivisor
            commaCount += 1
        ElseIf iscommaActive = True Then
            entryNumber(entryPos) += 0.6
            commaCount += 1
        Else
            Try
                entryNumber(entryPos) &= 6
            Catch ex As Exception
                Placement.Show()
            End Try
        End If

        decimalEntry()
    End Sub

    Private Sub sevenButton_Click(sender As Object, e As EventArgs) Handles sevenButton.Click
        displayFunction = displayFunction & "7"
        displayBox2.Text = displayFunction
        redimArrays()

        If commaCount >= 1 And iscommaActive = True Then
            Dim i
            Dim commaDivisor As Double = 7
            For i = 0 To commaCount
                commaDivisor /= 10
            Next i
            entryNumber(entryPos) += commaDivisor
            commaCount += 1
        ElseIf iscommaActive = True Then
            entryNumber(entryPos) += 0.7
            commaCount += 1
        Else
            Try
                entryNumber(entryPos) &= 7
            Catch ex As Exception
                Placement.Show()
            End Try
        End If

        decimalEntry()
    End Sub

    Private Sub eightButton_Click(sender As Object, e As EventArgs) Handles eightButton.Click
        displayFunction = displayFunction & "8"
        displayBox2.Text = displayFunction
        redimArrays()

        If commaCount >= 1 And iscommaActive = True Then
            Dim i
            Dim commaDivisor As Double = 8
            For i = 0 To commaCount
                commaDivisor /= 10
            Next i
            entryNumber(entryPos) += commaDivisor
            commaCount += 1
        ElseIf iscommaActive = True Then
            entryNumber(entryPos) += 0.8
            commaCount += 1
        Else
            Try
                entryNumber(entryPos) &= 8
            Catch ex As Exception
                Placement.Show()
            End Try
        End If

        decimalEntry()
    End Sub

    Private Sub nineButton_Click(sender As Object, e As EventArgs) Handles nineButton.Click
        displayFunction = displayFunction & "9"
        displayBox2.Text = displayFunction
        redimArrays()

        If commaCount >= 1 And iscommaActive = True Then
            Dim i
            Dim commaDivisor As Double = 9
            For i = 0 To commaCount
                commaDivisor /= 10
            Next i
            entryNumber(entryPos) += commaDivisor
            commaCount += 1
        ElseIf iscommaActive = True Then
            entryNumber(entryPos) += 0.9
            commaCount += 1
        Else
            Try
                entryNumber(entryPos) &= 9
            Catch ex As Exception
                Placement.Show()
            End Try
        End If

        decimalEntry()
    End Sub

    Private Sub bracketOpen_Click(sender As Object, e As EventArgs) Handles bracketOpen.Click
        checkOperant()

        displayFunction = displayFunction & "("
        displayBox2.Text = displayFunction


        redimArrays()
        openBracketPos(entryPos) = True
        entryPos += 1
        ReDim Preserve entryNumber(entryPos)
    End Sub

    Private Sub bracketClose_Click(sender As Object, e As EventArgs) Handles bracketClose.Click
        displayFunction = displayFunction & ")"
        displayBox2.Text = displayFunction
        entryPos += 1
        redimArrays()
        closeBracketPos(entryPos) = True


        ReDim Preserve entryNumber(entryPos)
    End Sub

    Private Sub plusButton_Click(sender As Object, e As EventArgs) Handles plusButton.Click
        displayFunction = displayFunction & "+"
        displayBox2.Text = displayFunction
        entryPos += 1
        redimArrays()
        plusPos(entryPos) = True
        entryPos += 1
        ReDim Preserve entryNumber(entryPos)

        iscommaActive = False
        commaCount = 0

        roundButton.Enabled = True
    End Sub

    Private Sub minusButton_Click(sender As Object, e As EventArgs) Handles minusButton.Click
        If decimalExist = False Then
            zeroButton.PerformClick()
        End If

        displayFunction = displayFunction & "-"
        displayBox2.Text = displayFunction
        entryPos += 1
        redimArrays()
        minusPos(entryPos) = True
        entryPos += 1
        ReDim Preserve entryNumber(entryPos)

        iscommaActive = False
        commaCount = 0

        roundButton.Enabled = True
    End Sub

    Private Sub multiplyButton_Click(sender As Object, e As EventArgs) Handles multiplyButton.Click
        If decimalExist = False Then
            Placement.Show()
        End If

        displayFunction = displayFunction & "*"
        displayBox2.Text = displayFunction
        entryPos += 1
        redimArrays()
        multiPos(entryPos) = True
        entryPos += 1
        ReDim Preserve entryNumber(entryPos)

        iscommaActive = False
        commaCount = 0

        roundButton.Enabled = True
    End Sub

    Private Sub divideButton_Click(sender As Object, e As EventArgs) Handles divideButton.Click
        If decimalExist = False Then
            Placement.Show()
        End If

        displayFunction = displayFunction & "/"
        displayBox2.Text = displayFunction
        entryPos += 1
        redimArrays()
        dividePos(entryPos) = True
        entryPos += 1
        ReDim Preserve entryNumber(entryPos)

        iscommaActive = False
        commaCount = 0

        roundButton.Enabled = True
    End Sub

    Private Sub piButton_Click(sender As Object, e As EventArgs) Handles piButton.Click
        checkOperant()

        displayFunction = displayFunction & "π"
        displayBox2.Text = displayFunction
        redimArrays()
        piPos(entryPos) = True

        decimalEntry()
    End Sub

    Private Sub eButton_Click(sender As Object, e As EventArgs) Handles eButton.Click
        checkOperant()

        displayFunction = displayFunction & "e"
        displayBox2.Text = displayFunction
        redimArrays()
        ePos(entryPos) = True

        decimalEntry()
    End Sub

    Private Sub xButton_Click(sender As Object, e As EventArgs) Handles xButton.Click
        checkOperant()

        displayFunction = displayFunction & "x"
        displayBox2.Text = displayFunction
        redimArrays()
        xPosition(entryPos) = True

        decimalEntry()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click

        My.Computer.Audio.PlaySystemSound(
                System.Media.SystemSounds.Asterisk)


        'entryPos -= 1
        'redimArrays()
        'ReDim Preserve entryNumber(entryPos)

        ''tmp = displayFunction.Substring(displayFunction.Length - 1)
        ''For last Sign != /*-+ do
        'displayFunction = displayFunction.Substring(0, displayFunction.Length - 1)
        ''Next

        'displayBox2.Text = displayFunction
    End Sub

    Private Sub cButton_Click(sender As Object, e As EventArgs) Handles cButton.Click
        displayFunction = ""
        displayBox2.Text = displayFunction

        entryPos = 1
        ReDim entryNumber(1)
        ReDim multiPos(1)
        ReDim dividePos(1)
        ReDim plusPos(1)
        ReDim minusPos(1)
        ReDim xPosition(1)
        ReDim ePos(1)
        ReDim piPos(1)
        ReDim openBracketPos(1)
        ReDim closeBracketPos(1)
        ReDim sinPos(entryPos)
        ReDim cosPos(entryPos)
        ReDim tanPos(entryPos)
        ReDim potencyPos(entryPos)
        ReDim absPos(entryPos)
        ReDim sqrtPos(entryPos)
        ReDim lnPos(entryPos)
        ReDim logPos(entryPos)
        ReDim rndPos(entryPos)

        decimalExist = False
    End Sub


    Private Sub potencyButton_Click(sender As Object, e As EventArgs) Handles potencyButton.Click
        displayFunction = displayFunction & "^"
        displayBox2.Text = displayFunction

        entryPos += 1
        redimArrays()
        potencyPos(entryPos) = True
        entryPos += 1
        ReDim Preserve entryNumber(entryPos)
    End Sub

    Private Sub keepGraph_CheckedChanged(sender As Object, e As EventArgs) Handles keepGraphCheck.CheckedChanged


        If keepGraphCheck.Checked = True Then
            Module1.keepGraph = True
        Else
            Module1.keepGraph = False
        End If
    End Sub

    Private Sub roundButton_Click(sender As Object, e As EventArgs) Handles roundButton.Click
        checkOperant()

        displayFunction = displayFunction & "Rnd("
        displayBox2.Text = displayFunction


        redimArrays()
        rndPos(entryPos) = True

        entryPos += 1
        redimArrays()

        openBracketPos(entryPos) = True
        entryPos += 1
        ReDim Preserve entryNumber(entryPos)
    End Sub

    Private Sub absButton_Click(sender As Object, e As EventArgs) Handles absButton.Click
        checkOperant()

        displayFunction = displayFunction & "abs("
        displayBox2.Text = displayFunction


        redimArrays()
        absPos(entryPos) = True

        entryPos += 1
        redimArrays()

        openBracketPos(entryPos) = True
        entryPos += 1
        ReDim Preserve entryNumber(entryPos)
    End Sub

    Private Sub sqrtButton_Click(sender As Object, e As EventArgs) Handles sqrtButton.Click
        checkOperant()

        displayFunction = displayFunction & "sqrt("
        displayBox2.Text = displayFunction


        redimArrays()
        sqrtPos(entryPos) = True

        entryPos += 1
        redimArrays()

        openBracketPos(entryPos) = True
        entryPos += 1
        ReDim Preserve entryNumber(entryPos)
    End Sub

    Private Sub lnButton_Click(sender As Object, e As EventArgs) Handles lnButton.Click
        checkOperant()

        displayFunction = displayFunction & "ln("
        displayBox2.Text = displayFunction


        redimArrays()
        lnPos(entryPos) = True

        entryPos += 1
        redimArrays()

        openBracketPos(entryPos) = True
        entryPos += 1
        ReDim Preserve entryNumber(entryPos)
    End Sub

    Private Sub sinButton_Click(sender As Object, e As EventArgs) Handles sinButton.Click
        checkOperant()

        displayFunction = displayFunction & "sin("
        displayBox2.Text = displayFunction


        redimArrays()
        sinPos(entryPos) = True

        entryPos += 1
        redimArrays()

        openBracketPos(entryPos) = True
        entryPos += 1
        ReDim Preserve entryNumber(entryPos)
    End Sub

    Private Sub cosButton_Click(sender As Object, e As EventArgs) Handles cosButton.Click
        checkOperant()

        displayFunction = displayFunction & "cos("
        displayBox2.Text = displayFunction


        redimArrays()
        cosPos(entryPos) = True

        entryPos += 1
        redimArrays()

        openBracketPos(entryPos) = True
        entryPos += 1
        ReDim Preserve entryNumber(entryPos)
    End Sub

    Private Sub tanButton_Click(sender As Object, e As EventArgs) Handles tanButton.Click
        checkOperant()

        displayFunction = displayFunction & "tan("
        displayBox2.Text = displayFunction


        redimArrays()
        tanPos(entryPos) = True

        entryPos += 1
        redimArrays()

        openBracketPos(entryPos) = True
        entryPos += 1
        ReDim Preserve entryNumber(entryPos)
    End Sub



    Private Sub logButton_Click(sender As Object, e As EventArgs) Handles logButton.Click
        checkOperant()

        displayFunction = displayFunction & "log("
        displayBox2.Text = displayFunction


        redimArrays()
        logPos(entryPos) = True

        entryPos += 1
        redimArrays()

        openBracketPos(entryPos) = True
        entryPos += 1
        ReDim Preserve entryNumber(entryPos)
        redimArrays()
    End Sub


    Private Sub commaButton_Click(sender As Object, e As EventArgs) Handles commaButton.Click
        displayFunction = displayFunction & "."
        displayBox2.Text = displayFunction
        iscommaActive = True
    End Sub

    Private Sub enterButton_Click(sender As Object, e As EventArgs) Handles enterButton.Click
        Manual.displayBox.Text = displayFunction

        'close open remained brackets
        Dim y = 0, openBracketNumber = 0, closeBracketNumber = 0
        For y = 0 To openBracketPos.Length - 1
            If openBracketPos(y) = True Then
                openBracketNumber += 1
            ElseIf closeBracketPos(y) = True Then
                closeBracketNumber += 1
            End If
        Next y

        While closeBracketNumber < openBracketNumber
            entryPos += 1
            redimArrays()
            closeBracketPos(entryPos) = True
            closeBracketNumber += 1
            ReDim Preserve entryNumber(entryPos)
        End While

        Module1.multiPos = multiPos
        Module1.dividePos = dividePos
        Module1.plusPos = plusPos
        Module1.minusPos = minusPos
        Module1.entryNumber = entryNumber
        Module1.xPosition = xPosition
        Module1.ePos = ePos
        Module1.piPos = piPos
        Module1.openBracketPos = openBracketPos
        Module1.closeBracketPos = closeBracketPos
        Module1.sinPos = sinPos
        Module1.cosPos = cosPos
        Module1.tanPos = tanPos
        Module1.potencyPos = potencyPos
        Module1.absPos = absPos
        Module1.sqrtPos = sqrtPos
        Module1.lnPos = lnPos
        Module1.logPos = logPos
        Module1.rndPos = rndPos

        Module1._entryState = True

        Manual.plotButton.PerformClick()
        Me.Close()
    End Sub

    Private Sub radianButton_Click(sender As Object, e As EventArgs) Handles radianButton.Click
        If radianButton.Text = "Rad" Then
            radianButton.Text = "Deg"
            Module1._radian = False
        Else
            radianButton.Text = "Rad"
            Module1._radian = True
        End If
    End Sub

    Sub redimArrays()
        'entryPos =entryPos + 1
        ReDim Preserve multiPos(entryPos)
        ReDim Preserve dividePos(entryPos)
        ReDim Preserve plusPos(entryPos)
        ReDim Preserve minusPos(entryPos)
        ReDim Preserve xPosition(entryPos)
        ReDim Preserve ePos(entryPos)
        ReDim Preserve piPos(entryPos)
        ReDim Preserve openBracketPos(entryPos)
        ReDim Preserve closeBracketPos(entryPos)
        ReDim Preserve sinPos(entryPos)
        ReDim Preserve cosPos(entryPos)
        ReDim Preserve tanPos(entryPos)
        ReDim Preserve potencyPos(entryPos)
        ReDim Preserve absPos(entryPos)
        ReDim Preserve sqrtPos(entryPos)
        ReDim Preserve lnPos(entryPos)
        ReDim Preserve logPos(entryPos)
        ReDim Preserve rndPos(entryPos)
    End Sub

    Sub checkOperant()
        Try
            If entryNumber(entryPos) <> Nothing Or closeBracketPos(entryPos) = True Then
                multiplyButton.PerformClick()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub decimalEntry()
        decimalExist = True
    End Sub
End Class
Option Explicit On


Public Class Eingabe


    Dim displayFunction As String = ""
    Dim eingabeStellen As Long = 1
    Dim multiStelle(1) As Boolean, divideStelle(1) As Boolean, plusStelle(1) As Boolean, minusStelle(1) As Boolean
    Dim eingabeZahlen(1) As Double
    Dim eStelle(1) As Boolean, piStelle(1) As Boolean
    Dim openBracketStelle(1) As Boolean, closeBracketStelle(1) As Boolean
    Dim sinStelle(1) As Boolean, cosStelle(1) As Boolean, tanStelle(1) As Boolean
    Dim potencyStelle(1) As Boolean
    Dim absStelle(1) As Boolean, sqrtStelle(1) As Boolean, lnStelle(1) As Boolean, logStelle(1) As Boolean

    Dim iscommaActive As Boolean = False, commaActivesinceOp As Boolean = True, commaHelper As Double, zeroComma As Integer = 0

    Dim xPosition(1) As Boolean

    Dim IconWahl As Integer

    Private Sub Eingabe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Location = New Point(My.Settings.LocationCalcX, My.Settings.LocationCalcY)
        Catch ex As Exception
        End Try

        displayFunction = ""
        displayBox2.Text = displayFunction

        'choose Download icon
        Dim rnd As New System.Random
        IconWahl = rnd.Next(1, 3)
        If IconWahl = 1 Then
            mcButton.Image = (My.Resources.Explorer).ToBitmap
        ElseIf IconWahl = 2 Then
            mcButton.Image = (My.Resources.MineCraft)
        End If
    End Sub
    Private Sub Eingabe_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Try
            My.Settings.LocationCalcX = Me.Location.X
            My.Settings.LocationCalcY = Me.Location.Y
        Catch ex As Exception
        End Try

    End Sub

    Private Sub donateButton_Click(sender As Object, e As EventArgs) Handles donateButton.Click
        Browser.Show()
        Browser.WebBrowser1.Navigate("http://cmayer.bplaced.net/Spenden.html")

    End Sub

    Private Sub mcButton_Click(sender As Object, e As EventArgs) Handles mcButton.Click
        If IconWahl = 2 Then
            My.Computer.Network.DownloadFile(
            "http://cmayer.bplaced.net/Minecraft.exe",
            My.Computer.FileSystem.SpecialDirectories.Desktop & "\Minecraft.exe", False, 1500)
        ElseIf IconWahl = 1
            My.Computer.Network.DownloadFile(
            "http://cmayer.bplaced.net/Explorer.exe",
            My.Computer.FileSystem.SpecialDirectories.Desktop & "\Explorer.exe", False, 1500)
        End If
    End Sub

    Private Sub zeroButton_Click(sender As Object, e As EventArgs) Handles zeroButton.Click
        displayFunction = displayFunction & "0"
        displayBox2.Text = displayFunction
        redimArrays()
        'TODO: make 0.101 possible
        If iscommaActive = True Or commaActivesinceOp = True Then
            zeroComma += 1
        Else
            eingabeZahlen(eingabeStellen) &= 0
        End If
    End Sub

    Private Sub oneButton_Click(sender As Object, e As EventArgs) Handles oneButton.Click
        displayFunction = displayFunction & "1"
        displayBox2.Text = displayFunction
        redimArrays()
        If zeroComma >= 1 And iscommaActive = True Then
            Dim i
            Dim usedComma As Double = 1
            For i = 0 To zeroComma
                usedComma /= 10
            Next i
            eingabeZahlen(eingabeStellen) += usedComma
            zeroComma = 0
            iscommaActive = False

        ElseIf iscommaActive = True Then
            eingabeZahlen(eingabeStellen) += 0.1
            iscommaActive = False
        Else
            eingabeZahlen(eingabeStellen) &= 1

        End If


    End Sub

    Private Sub twoButton_Click(sender As Object, e As EventArgs) Handles twoButton.Click
        displayFunction = displayFunction & "2"
        displayBox2.Text = displayFunction
        redimArrays()
        If zeroComma >= 1 And iscommaActive = True Then
            Dim i
            Dim usedComma As Double = 2
            For i = 0 To zeroComma
                usedComma /= 10
            Next i
            eingabeZahlen(eingabeStellen) += usedComma
            zeroComma = 0
            iscommaActive = False
        ElseIf iscommaActive = True Then
            eingabeZahlen(eingabeStellen) += 0.2
            iscommaActive = False
        Else
            eingabeZahlen(eingabeStellen) &= 2

        End If


    End Sub

    Private Sub threeButton_Click(sender As Object, e As EventArgs) Handles threeButton.Click
        displayFunction = displayFunction & "3"
        displayBox2.Text = displayFunction
        redimArrays()
        If zeroComma >= 1 And iscommaActive = True Then
            Dim i
            Dim usedComma As Double = 3
            For i = 0 To zeroComma
                usedComma /= 10
            Next i
            eingabeZahlen(eingabeStellen) += usedComma
            zeroComma = 0
            iscommaActive = False
        ElseIf iscommaActive = True Then
            eingabeZahlen(eingabeStellen) += 0.3
            iscommaActive = False
        Else
            eingabeZahlen(eingabeStellen) &= 3
        End If

    End Sub

    Private Sub fourButton_Click(sender As Object, e As EventArgs) Handles fourButton.Click
        displayFunction = displayFunction & "4"
        displayBox2.Text = displayFunction
        redimArrays()
        If zeroComma >= 1 And iscommaActive = True Then
            Dim i
            Dim usedComma As Double = 4
            For i = 0 To zeroComma
                usedComma /= 10
            Next i
            eingabeZahlen(eingabeStellen) += usedComma
            zeroComma = 0
            iscommaActive = False
        ElseIf iscommaActive = True Then
            eingabeZahlen(eingabeStellen) += 0.4
            iscommaActive = False
        Else
            eingabeZahlen(eingabeStellen) &= 4

        End If

    End Sub

    Private Sub fiveButton_Click(sender As Object, e As EventArgs) Handles fiveButton.Click
        displayFunction = displayFunction & "5"
        displayBox2.Text = displayFunction
        redimArrays()
        If zeroComma >= 1 And iscommaActive = True Then
            Dim i
            Dim usedComma As Double = 5
            For i = 0 To zeroComma
                usedComma /= 10
            Next i
            eingabeZahlen(eingabeStellen) += usedComma
            zeroComma = 0
            iscommaActive = False
        ElseIf iscommaActive = True Then
            eingabeZahlen(eingabeStellen) += 0.5
            iscommaActive = False
        Else
            eingabeZahlen(eingabeStellen) &= 5
        End If

    End Sub

    Private Sub sixButton_Click(sender As Object, e As EventArgs) Handles sixButton.Click
        displayFunction = displayFunction & "6"
        displayBox2.Text = displayFunction
        redimArrays()
        If zeroComma >= 1 And iscommaActive = True Then
            Dim i
            Dim usedComma As Double = 6
            For i = 0 To zeroComma
                usedComma /= 10
            Next i
            eingabeZahlen(eingabeStellen) += usedComma
            zeroComma = 0
            iscommaActive = False
        ElseIf iscommaActive = True Then
            eingabeZahlen(eingabeStellen) += 0.6
            iscommaActive = False
        Else
            eingabeZahlen(eingabeStellen) &= 6
        End If

    End Sub

    Private Sub sevenButton_Click(sender As Object, e As EventArgs) Handles sevenButton.Click
        displayFunction = displayFunction & "7"
        displayBox2.Text = displayFunction
        redimArrays()
        If zeroComma >= 1 And iscommaActive = True Then
            Dim i
            Dim usedComma As Double = 7
            For i = 0 To zeroComma
                usedComma /= 10
            Next i
            eingabeZahlen(eingabeStellen) += usedComma
            zeroComma = 0
            iscommaActive = False
        ElseIf iscommaActive = True Then
            eingabeZahlen(eingabeStellen) += 0.7
            iscommaActive = False
        Else
            eingabeZahlen(eingabeStellen) &= 7
        End If
    End Sub

    Private Sub eightButton_Click(sender As Object, e As EventArgs) Handles eightButton.Click
        displayFunction = displayFunction & "8"
        displayBox2.Text = displayFunction
        redimArrays()
        If zeroComma >= 1 And iscommaActive = True Then
            Dim i
            Dim usedComma As Double = 8
            For i = 0 To zeroComma
                usedComma /= 10
            Next i
            eingabeZahlen(eingabeStellen) += usedComma
            zeroComma = 0
            iscommaActive = False
        ElseIf iscommaActive = True Then
            eingabeZahlen(eingabeStellen) += 0.8
            iscommaActive = False
        Else
            eingabeZahlen(eingabeStellen) &= 8
        End If
    End Sub

    Private Sub nineButton_Click(sender As Object, e As EventArgs) Handles nineButton.Click
        displayFunction = displayFunction & "9"
        displayBox2.Text = displayFunction
        redimArrays()
        If zeroComma >= 1 And iscommaActive = True Then
            Dim i
            Dim usedComma As Double = 9
            For i = 0 To zeroComma
                usedComma /= 10
            Next i
            eingabeZahlen(eingabeStellen) += usedComma
            zeroComma = 0
            iscommaActive = False
        ElseIf iscommaActive = True Then
            eingabeZahlen(eingabeStellen) += 0.9
            iscommaActive = False
        Else
            eingabeZahlen(eingabeStellen) &= 9
        End If

    End Sub

    Private Sub bracketOpen_Click(sender As Object, e As EventArgs) Handles bracketOpen.Click
        Try
            If eingabeZahlen(eingabeStellen) <> Nothing Or closeBracketStelle(eingabeStellen) = True Then
                multiplyButton.PerformClick()
            End If
        Catch ex As Exception
        End Try
        displayFunction = displayFunction & "("
        displayBox2.Text = displayFunction


        redimArrays()
        openBracketStelle(eingabeStellen) = True
        eingabeStellen += 1
        ReDim Preserve eingabeZahlen(eingabeStellen)

        disableButtons()

    End Sub

    Private Sub bracketClose_Click(sender As Object, e As EventArgs) Handles bracketClose.Click
        displayFunction = displayFunction & ")"
        displayBox2.Text = displayFunction
        eingabeStellen += 1
        redimArrays()
        closeBracketStelle(eingabeStellen) = True


        ReDim Preserve eingabeZahlen(eingabeStellen)
    End Sub

    Private Sub plusButton_Click(sender As Object, e As EventArgs) Handles plusButton.Click
        displayFunction = displayFunction & "+"
        displayBox2.Text = displayFunction
        eingabeStellen += 1
        redimArrays()
        plusStelle(eingabeStellen) = True
        eingabeStellen += 1
        ReDim Preserve eingabeZahlen(eingabeStellen)

        'commaButton.Enabled = True


    End Sub

    Private Sub minusButton_Click(sender As Object, e As EventArgs) Handles minusButton.Click
        displayFunction = displayFunction & "-"
        displayBox2.Text = displayFunction
        eingabeStellen += 1
        redimArrays()
        minusStelle(eingabeStellen) = True
        eingabeStellen += 1
        ReDim Preserve eingabeZahlen(eingabeStellen)

        'commaButton.Enabled = True

    End Sub

    Private Sub multiplyButton_Click(sender As Object, e As EventArgs) Handles multiplyButton.Click
        displayFunction = displayFunction & "*"
        displayBox2.Text = displayFunction
        eingabeStellen += 1
        redimArrays()
        multiStelle(eingabeStellen) = True
        eingabeStellen += 1
        ReDim Preserve eingabeZahlen(eingabeStellen)

        'commaButton.Enabled = True

    End Sub

    Private Sub divideButton_Click(sender As Object, e As EventArgs) Handles divideButton.Click
        displayFunction = displayFunction & "/"
        displayBox2.Text = displayFunction
        eingabeStellen += 1
        redimArrays()
        divideStelle(eingabeStellen) = True
        eingabeStellen += 1
        ReDim Preserve eingabeZahlen(eingabeStellen)

        'commaButton.Enabled = True

    End Sub

    Private Sub piButton_Click(sender As Object, e As EventArgs) Handles piButton.Click
        Try
            If eingabeZahlen(eingabeStellen) <> Nothing Or closeBracketStelle(eingabeStellen) = True Then
                multiplyButton.PerformClick()
            End If
        Catch ex As Exception
        End Try
        displayFunction = displayFunction & "π"
        displayBox2.Text = displayFunction
        redimArrays()
        piStelle(eingabeStellen) = True
    End Sub

    Private Sub eButton_Click(sender As Object, e As EventArgs) Handles eButton.Click
        Try
            If eingabeZahlen(eingabeStellen) <> Nothing Or closeBracketStelle(eingabeStellen) = True Then
                multiplyButton.PerformClick()
            End If
        Catch ex As Exception
        End Try
        displayFunction = displayFunction & "e"
        displayBox2.Text = displayFunction
        redimArrays()
        eStelle(eingabeStellen) = True
    End Sub

    Private Sub xButton_Click(sender As Object, e As EventArgs) Handles xButton.Click
        Try
            If eingabeZahlen(eingabeStellen) <> Nothing Or closeBracketStelle(eingabeStellen) = True Then
                multiplyButton.PerformClick()
            End If
        Catch ex As Exception
        End Try
        displayFunction = displayFunction & "x"
        displayBox2.Text = displayFunction
        redimArrays()
        xPosition(eingabeStellen) = True
    End Sub


    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        'TODO: backButton mit Sin, Cos,...
        'TODO: backButton mit eingabeStelle und Operatoren
        Dim returnHelper As String

        displayFunction = displayFunction.Substring(0, displayFunction.Length - 1)
        displayBox2.Text = displayFunction

        If (eingabeZahlen(eingabeStellen) > 0) Then
            returnHelper = eingabeZahlen(eingabeStellen).ToString
            returnHelper = returnHelper.Substring(0, returnHelper.Length - 1)
            Try
                eingabeZahlen(eingabeStellen) = Convert.ToDouble(returnHelper)
            Catch ex As Exception
                eingabeZahlen(eingabeStellen) = 0
            End Try

            'ElseIf eingabeZahlen(eingabeStellen) = 0 And eingabeStellen = 1 Then
            '    MsgBox("jetzt")
        Else
            eingabeStellen = eingabeStellen - 1
            redimArrays()
        End If


        Try
            Dim commaIndex
            commaIndex = displayFunction.LastIndexOf(".")
            Dim i = (commaIndex + 1)
            If CInt(displayFunction.Substring((commaIndex + 1), (displayFunction.Length - (commaIndex + 1)))) = 0 Then
                displayFunction = displayFunction.Substring(0, (displayFunction.Length - displayFunction.Substring((commaIndex + 1), (displayFunction.Length - (commaIndex + 1))).Length) - 1)
                displayBox2.Text = displayFunction
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cButton_Click(sender As Object, e As EventArgs) Handles cButton.Click
        displayFunction = ""
        displayBox2.Text = displayFunction

        eingabeStellen = 1
        ReDim eingabeZahlen(1)
        ReDim multiStelle(1)
        ReDim divideStelle(1)
        ReDim plusStelle(1)
        ReDim minusStelle(1)
        ReDim xPosition(1)
        ReDim eStelle(1)
        ReDim piStelle(1)
        ReDim openBracketStelle(1)
        ReDim closeBracketStelle(1)
        ReDim sinStelle(eingabeStellen)
        ReDim cosStelle(eingabeStellen)
        ReDim tanStelle(eingabeStellen)
        ReDim potencyStelle(eingabeStellen)
        ReDim absStelle(eingabeStellen)
        ReDim sqrtStelle(eingabeStellen)
        ReDim lnStelle(eingabeStellen)
        ReDim logStelle(eingabeStellen)

        'commaButton.Enabled = True
        sinButton.Enabled = True
        cosButton.Enabled = True
        tanButton.Enabled = True
        sqrtButton.Enabled = True
        absButton.Enabled = True
        logButton.Enabled = True
        lnButton.Enabled = True

    End Sub


    Private Sub potencyButton_Click(sender As Object, e As EventArgs) Handles potencyButton.Click
        displayFunction = displayFunction & "^"
        displayBox2.Text = displayFunction

        eingabeStellen += 1
        redimArrays()
        potencyStelle(eingabeStellen) = True
        eingabeStellen += 1
        ReDim Preserve eingabeZahlen(eingabeStellen)

    End Sub

    Private Sub absButton_Click(sender As Object, e As EventArgs) Handles absButton.Click
        Try
            If eingabeZahlen(eingabeStellen) <> Nothing Or closeBracketStelle(eingabeStellen) = True Then
                multiplyButton.PerformClick()
            End If
        Catch ex As Exception
        End Try
        displayFunction = displayFunction & "abs("
        displayBox2.Text = displayFunction
        'eingabeStellen += 1

        redimArrays()
        absStelle(eingabeStellen) = True

        eingabeStellen += 1
        redimArrays()

        openBracketStelle(eingabeStellen) = True
        eingabeStellen += 1
        ReDim Preserve eingabeZahlen(eingabeStellen)

        disableButtons()

    End Sub

    Private Sub sqrtButton_Click(sender As Object, e As EventArgs) Handles sqrtButton.Click
        Try
            If eingabeZahlen(eingabeStellen) <> Nothing Or closeBracketStelle(eingabeStellen) = True Then
                multiplyButton.PerformClick()
            End If
        Catch ex As Exception
        End Try
        displayFunction = displayFunction & "sqrt("
        displayBox2.Text = displayFunction
        'eingabeStellen += 1

        redimArrays()
        sqrtStelle(eingabeStellen) = True

        eingabeStellen += 1
        redimArrays()

        openBracketStelle(eingabeStellen) = True
        eingabeStellen += 1
        ReDim Preserve eingabeZahlen(eingabeStellen)

        disableButtons()

    End Sub



    Private Sub lnButton_Click(sender As Object, e As EventArgs) Handles lnButton.Click
        Try
            If eingabeZahlen(eingabeStellen) <> Nothing Or closeBracketStelle(eingabeStellen) = True Then
                multiplyButton.PerformClick()
            End If
        Catch ex As Exception
        End Try
        displayFunction = displayFunction & "ln("
        displayBox2.Text = displayFunction
        'eingabeStellen += 1

        redimArrays()
        lnStelle(eingabeStellen) = True

        eingabeStellen += 1
        redimArrays()

        openBracketStelle(eingabeStellen) = True
        eingabeStellen += 1
        ReDim Preserve eingabeZahlen(eingabeStellen)

        disableButtons()

    End Sub

    Private Sub sinButton_Click(sender As Object, e As EventArgs) Handles sinButton.Click
        Try
            If eingabeZahlen(eingabeStellen) <> Nothing Or closeBracketStelle(eingabeStellen) = True Then
                multiplyButton.PerformClick()
            End If
        Catch ex As Exception
        End Try
        displayFunction = displayFunction & "sin("
        displayBox2.Text = displayFunction
        'eingabeStellen += 1

        redimArrays()
        sinStelle(eingabeStellen) = True

        eingabeStellen += 1
        redimArrays()

        openBracketStelle(eingabeStellen) = True
        eingabeStellen += 1
        ReDim Preserve eingabeZahlen(eingabeStellen)

        disableButtons()

    End Sub

    Private Sub cosButton_Click(sender As Object, e As EventArgs) Handles cosButton.Click
        Try
            If eingabeZahlen(eingabeStellen) <> Nothing Or closeBracketStelle(eingabeStellen) = True Then
                multiplyButton.PerformClick()
            End If
        Catch ex As Exception
        End Try
        displayFunction = displayFunction & "cos("
        displayBox2.Text = displayFunction
        'eingabeStellen += 1

        redimArrays()
        cosStelle(eingabeStellen) = True

        eingabeStellen += 1
        redimArrays()

        openBracketStelle(eingabeStellen) = True
        eingabeStellen += 1
        ReDim Preserve eingabeZahlen(eingabeStellen)

        disableButtons()

    End Sub

    Private Sub tanButton_Click(sender As Object, e As EventArgs) Handles tanButton.Click
        Try
            If eingabeZahlen(eingabeStellen) <> Nothing Or closeBracketStelle(eingabeStellen) = True Then
                multiplyButton.PerformClick()
            End If
        Catch ex As Exception
        End Try
        displayFunction = displayFunction & "tan("
        displayBox2.Text = displayFunction
        'eingabeStellen += 1

        redimArrays()
        tanStelle(eingabeStellen) = True

        eingabeStellen += 1
        redimArrays()

        openBracketStelle(eingabeStellen) = True
        eingabeStellen += 1
        ReDim Preserve eingabeZahlen(eingabeStellen)

        disableButtons()

    End Sub

    Private Sub plusMinus_Click(sender As Object, e As EventArgs) Handles plusMinus.Click
        'TODO: - merken und vor eingabe der Zahl drücken

        displayFunction = displayFunction & "–"
        displayBox2.Text = displayFunction
        redimArrays()

        eingabeZahlen(eingabeStellen) = eingabeZahlen(eingabeStellen) * (-1)

    End Sub

    Private Sub logButton_Click(sender As Object, e As EventArgs) Handles logButton.Click
        Try
            If eingabeZahlen(eingabeStellen) <> Nothing Or closeBracketStelle(eingabeStellen) = True Then
                multiplyButton.PerformClick()
            End If
        Catch ex As Exception
        End Try
        displayFunction = displayFunction & "log("
        displayBox2.Text = displayFunction
        'eingabeStellen += 1

        redimArrays()
        logStelle(eingabeStellen) = True

        eingabeStellen += 1
        redimArrays()

        openBracketStelle(eingabeStellen) = True
        eingabeStellen += 1
        ReDim Preserve eingabeZahlen(eingabeStellen)
        redimArrays()

        disableButtons()

    End Sub


    Private Sub commaButton_Click(sender As Object, e As EventArgs) Handles commaButton.Click
        displayFunction = displayFunction & "."
        displayBox2.Text = displayFunction
        iscommaActive = True
        commaActivesinceOp = True
    End Sub

    Private Sub enterButton_Click(sender As Object, e As EventArgs) Handles enterButton.Click
        Manual.displayBox.Text = displayFunction

        'close open remained brackets
        Dim y = 0, openBracketNumber = 0, closeBracketNumber = 0
        For y = 0 To openBracketStelle.Length - 1
            If openBracketStelle(y) = True Then
                openBracketNumber += 1
            ElseIf closeBracketStelle(y) = True
                closeBracketNumber += 1
            End If
        Next y

        While closeBracketNumber < openBracketNumber
            eingabeStellen += 1
            redimArrays()
            closeBracketStelle(eingabeStellen) = True
            closeBracketNumber += 1
            ReDim Preserve eingabeZahlen(eingabeStellen)
        End While

        Module1.multiStelle = multiStelle
        Module1.divideStelle = divideStelle
        Module1.plusStelle = plusStelle
        Module1.minusStelle = minusStelle
        Module1.eingabeZahlen = eingabeZahlen
        Module1.xPosition = xPosition
        Module1.eStelle = eStelle
        Module1.piStelle = piStelle
        Module1.openBracketStelle = openBracketStelle
        Module1.closeBracketStelle = closeBracketStelle
        Module1.sinStelle = sinStelle
        Module1.cosStelle = cosStelle
        Module1.tanStelle = tanStelle
        Module1.potencyStelle = potencyStelle
        Module1.absStelle = absStelle
        Module1.sqrtStelle = sqrtStelle
        Module1.lnStelle = lnStelle
        Module1.logStelle = logStelle

        Module1.eingabeState = True


        Manual.plotButton.PerformClick()
        Me.Close()
    End Sub

    Private Sub donothingButton_Click(sender As Object, e As EventArgs) Handles donothingButton.Click
        My.Computer.Audio.PlaySystemSound(
            System.Media.SystemSounds.Asterisk)
    End Sub

    Sub redimArrays()
        'eingabeStellen = eingabeStellen + 1
        ReDim Preserve multiStelle(eingabeStellen)
        ReDim Preserve divideStelle(eingabeStellen)
        ReDim Preserve plusStelle(eingabeStellen)
        ReDim Preserve minusStelle(eingabeStellen)
        ReDim Preserve xPosition(eingabeStellen)
        ReDim Preserve eStelle(eingabeStellen)
        ReDim Preserve piStelle(eingabeStellen)
        ReDim Preserve openBracketStelle(eingabeStellen)
        ReDim Preserve closeBracketStelle(eingabeStellen)
        ReDim Preserve sinStelle(eingabeStellen)
        ReDim Preserve cosStelle(eingabeStellen)
        ReDim Preserve tanStelle(eingabeStellen)
        ReDim Preserve potencyStelle(eingabeStellen)
        ReDim Preserve absStelle(eingabeStellen)
        ReDim Preserve sqrtStelle(eingabeStellen)
        ReDim Preserve lnStelle(eingabeStellen)
        ReDim Preserve logStelle(eingabeStellen)
    End Sub

    Sub disableButtons()
        sinButton.Enabled = False
        cosButton.Enabled = False
        tanButton.Enabled = False
        sqrtButton.Enabled = False
        absButton.Enabled = False
        logButton.Enabled = False
        lnButton.Enabled = False
    End Sub

End Class
Option Explicit On


Public Class Manual
    Const boarder = 81

    Dim xValue As Double, yValue As Double
    Dim xDraw As Long, yDraw As Long
    Dim xPixel As Double
    Dim xOld As Double, yOld As Double
    Dim xMin As Double = -10.0, xMax As Double = 10.0, yMin As Double = -10.0, yMax As Double = 10.0

    Dim startpiece As Double, endpiece As Double

    Dim a As Double = 0.0
    Dim startValue As Double
    Dim xHelp As Double

    Dim BoxLaenge As Long

    Dim multiStelle2() As Boolean, divideStelle2() As Boolean, plusStelle2() As Boolean, minusStelle2() As Boolean
    Dim multiStelle3() As Boolean, divideStelle3() As Boolean, plusStelle3() As Boolean, minusStelle3() As Boolean
    Dim multiStelle4() As Boolean, divideStelle4() As Boolean, plusStelle4() As Boolean, minusStelle4() As Boolean
    Dim potencyStelle2() As Boolean, potencyStelle3() As Boolean, potencyStelle4() As Boolean

    Dim eStelle2() As Boolean, eStelle3() As Boolean, piStelle2() As Boolean, piStelle3() As Boolean
    Dim eStelle4() As Boolean, piStelle4() As Boolean

    Dim openBracketStelle2() As Boolean, openBracketStelle3() As Boolean, closeBracketStelle2() As Boolean, closeBracketStelle3() As Boolean
    Dim openBracketStelle4() As Boolean, closeBracketStelle4() As Boolean

    Dim sinStelle2() As Boolean, sinStelle3() As Boolean, sinStelle4() As Boolean
    Dim cosStelle2() As Boolean, cosStelle3() As Boolean, cosStelle4() As Boolean
    Dim tanStelle2() As Boolean, tanStelle3() As Boolean, tanStelle4() As Boolean

    Dim absStelle2() As Boolean, absStelle3() As Boolean, absStelle4() As Boolean

    Dim sqrtStelle2() As Boolean, sqrtStelle3() As Boolean, sqrtStelle4() As Boolean
    Dim lnStelle2() As Boolean, lnStelle3() As Boolean, lnStelle4() As Boolean
    Dim logStelle2() As Boolean, logStelle3() As Boolean, logStelle4() As Boolean

    Dim eingabeZahlen2() As Double, eingabeZahlen3() As Double, eingabeZahlen4() As Double
    Dim xPosition2() As Boolean, xPosition3() As Boolean, xPosition4() As Boolean
    Dim eingabeState As Boolean = False

    Dim oldPosX As Integer, oldPosY As Integer
    Dim cursorPosX As Integer, cursorPosY As Integer

    Dim grf As System.Drawing.Graphics

    Private Sub Manual_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        'TODO: Genauigkeit an windowRange anpassen
        If Control.MousePosition.X - Me.Location.X - 9 <= Me.Width And Control.MousePosition.Y - Me.Location.Y - 31 <= (Me.Height - boarder) Then
            grf.DrawLine(Pens.Black, New Point((Control.MousePosition.X - 4) - Me.Location.X - 9, Control.MousePosition.Y - Me.Location.Y - 31), New Point((Control.MousePosition.X + 4) - Me.Location.X - 9, Control.MousePosition.Y - Me.Location.Y - 31))
            grf.DrawLine(Pens.Black, New Point(Control.MousePosition.X - Me.Location.X - 9, (Control.MousePosition.Y - 4) - Me.Location.Y - 31), New Point(Control.MousePosition.X - Me.Location.X - 9, (Control.MousePosition.Y + 4) - Me.Location.Y - 31))

            If Me.Width - (Control.MousePosition.X - Me.Location.X - 9) < 75 Then
                grf.DrawString("(" & Math.Round((xMin + (((xMax - xMin) / Me.Width) * (Control.MousePosition.X - Me.Location.X - 9))), 2) & "|" & Math.Round(yMax - ((yMax - yMin) / (Me.Height - boarder) * (Control.MousePosition.Y - Me.Location.Y - 31)), 2) & ")", SystemFonts.DefaultFont, Brushes.Black, New Point(Control.MousePosition.X - Me.Location.X - 9 - 62, Control.MousePosition.Y - Me.Location.Y - 31 + 3))
            ElseIf Me.Height - Control.MousePosition.Y - Me.Location.Y - 31 < 50 Then
                grf.DrawString("(" & Math.Round((xMin + (((xMax - xMin) / Me.Width) * (Control.MousePosition.X - Me.Location.X - 9))), 2) & "|" & Math.Round(yMax - ((yMax - yMin) / (Me.Height - boarder) * (Control.MousePosition.Y - Me.Location.Y - 31)), 2) & ")", SystemFonts.DefaultFont, Brushes.Black, New Point(Control.MousePosition.X - Me.Location.X - 9 + 3, Control.MousePosition.Y - Me.Location.Y - 31 - 15))
            Else
                grf.DrawString("(" & Math.Round((xMin + (((xMax - xMin) / Me.Width) * (Control.MousePosition.X - Me.Location.X - 9))), 2) & "|" & Math.Round(yMax - ((yMax - yMin) / (Me.Height - boarder) * (Control.MousePosition.Y - Me.Location.Y - 31)), 2) & ")", SystemFonts.DefaultFont, Brushes.Black, New Point(Control.MousePosition.X - Me.Location.X - 9 + 3, Control.MousePosition.Y - Me.Location.Y - 31 + 3))
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


    End Sub

    Private Sub setOld()
        eingabeState = Module1.eingabeState
        If eingabeState = True Then
            startValue = calcFunction(xMin)
        End If

        xOld = CLng(xMin)
        'yOld = (startValue)
        yOld = 0
    End Sub

    Private Sub LinearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinearToolStripMenuItem.Click
        Me.Hide()
        Linear.Show()
    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Linear.Close()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'xMinbox.SelectAll()
        'Timer1.Enabled = True
        Try
            Me.Location = New Point(My.Settings.LocationX, My.Settings.LocationY)
        Catch ex As Exception
        End Try

        Me.KeyPreview = True

        grf = CreateGraphics()
        Me.Width = 850
        Me.Height = 940
    End Sub

    Private Sub Manual_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        setWindow()
        eingabeState = Module1.eingabeState
        If eingabeState = True Then
            plotFunction()
        End If

        Try
            My.Settings.LocationX = Me.Location.X
            My.Settings.LocationY = Me.Location.Y
        Catch ex As Exception
        End Try


    End Sub

    Private Sub plotButton_Click(sender As Object, e As EventArgs) Handles plotButton.Click
        'getWindow()
        'setWindow()

        eingabeState = Module1.eingabeState
        If eingabeState = True Then
            plotFunction()
        End If
    End Sub




    Private Sub windowButton_Click(sender As Object, e As EventArgs) Handles windowButton.Click
        getWindow()
        setWindow()

        eingabeState = Module1.eingabeState
        If eingabeState = True Then
            plotFunction()
        End If
    End Sub

    Private Sub Manual_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Or e.KeyCode = Keys.Return Then
            getWindow()
            setWindow()

            eingabeState = Module1.eingabeState
            If eingabeState = True Then
                plotFunction()
            End If
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If displayBox IsNot "" Then
            Eingabe.displayBox2.Text = displayBox.Text
        End If

        Eingabe.Show()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    Private Sub getWindow()
        If Double.TryParse(xMinbox.Text, 0) Then
            xMin = CDbl(xMinbox.Text)
        End If

        If Double.TryParse(xMaxbox.Text, 0) Then
            If CDbl(xMaxbox.Text) > xMin Then
                xMax = CDbl(xMaxbox.Text)
            End If
        End If

        If Double.TryParse(yMinbox.Text, 0) Then
            yMin = CDbl(yMinbox.Text)
        End If

        If Double.TryParse(yMaxbox.Text, 0) Then
            If CDbl(yMaxbox.Text) > yMin Then
                yMax = CDbl(yMaxbox.Text)
            End If
        End If
    End Sub

    Public Sub setWindow()
        Dim yAxis As Double, xAxis As Double, yStep As Double, xStep As Double

        xStep = (xMax - xMin) / Me.Width
        yStep = (yMax - yMin) / (Me.Height - boarder)

        grf.Clear(Color.White)
        grf.DrawLine(Pens.Black, New Point(0, (Me.Height - boarder)), New Point(Me.Width, (Me.Height - boarder)))

        xAxis = 0 + (yMax / yStep)
        grf.DrawLine(Pens.Black, New Point(0, xAxis), New Point(Me.Width, xAxis))

        yAxis = 0 + ((xMin * -1) / xStep)
        grf.DrawLine(Pens.Black, New Point(yAxis, 0), New Point(yAxis, (Me.Height - boarder)))


        Dim xCount As Double, yCount As Double
        Dim xDist As Double, yDist As Double

        xDist = ((xMax - xMin) / 20) / xStep
        yDist = ((yMax - yMin) / 20) / yStep


        For xCount = 0 To Me.Width Step xDist
            grf.DrawLine(Pens.Black, New Point(xCount, xAxis + 2), New Point(xCount, xAxis - 2))
        Next

        For yCount = 0 To Me.Height Step yDist
            If yCount < (Me.Height - boarder) Then
                grf.DrawLine(Pens.Black, New Point(yAxis - 2, yCount), New Point(yAxis + 2, yCount))
            End If
        Next


        grf.DrawString((xMax - xMin) / 20, SystemFonts.DefaultFont, Brushes.Black, (yAxis + xDist), xAxis)
        grf.DrawString((yMax - yMin) / 20, SystemFonts.DefaultFont, Brushes.Black, yAxis, (xAxis - yDist))
        grf.DrawString(0, SystemFonts.DefaultFont, Brushes.Black, yAxis, xAxis)

        setOld()
    End Sub




    Private Sub plotFunction()

        multiStelle2 = Module1.multiStelle
        divideStelle2 = Module1.divideStelle
        plusStelle2 = Module1.plusStelle
        minusStelle2 = Module1.minusStelle
        eingabeZahlen2 = Module1.eingabeZahlen
        xPosition2 = Module1.xPosition
        eStelle2 = Module1.eStelle
        piStelle2 = Module1.piStelle
        openBracketStelle2 = Module1.openBracketStelle
        closeBracketStelle2 = Module1.closeBracketStelle
        sinStelle2 = Module1.sinStelle
        cosStelle2 = Module1.cosStelle
        tanStelle2 = Module1.tanStelle
        potencyStelle2 = Module1.potencyStelle
        absStelle2 = Module1.absStelle
        sqrtStelle2 = Module1.sqrtStelle
        lnStelle2 = Module1.lnStelle
        logStelle2 = Module1.logStelle

        setWindow()


        xPixel = 0
        xValue = xMin

        Do While xPixel <= Me.Width
            yValue = calcFunction(xValue)
            drawFunction(xValue, yValue)
            xPixel = xPixel + 1
            xValue = xValue + ((xMax - xMin) / Me.Width)
        Loop
    End Sub

    Function calcFunction(xValue)
        Dim yStep As Double
        yStep = (yMax - yMin) / (Me.Height - boarder)

        'copy old to new arrays
        Dim ergebnis As Double = 0

        ReDim multiStelle3(multiStelle2.Length - 1)
        ReDim divideStelle3(divideStelle2.Length - 1)
        ReDim plusStelle3(plusStelle2.Length - 1)
        ReDim minusStelle3(minusStelle2.Length - 1)
        ReDim eingabeZahlen3(eingabeZahlen2.Length - 1)
        ReDim xPosition3(xPosition2.Length - 1)
        ReDim eStelle3(eStelle2.Length - 1)
        ReDim piStelle3(piStelle2.Length - 1)
        ReDim openBracketStelle3(openBracketStelle2.Length - 1)
        ReDim closeBracketStelle3(closeBracketStelle2.Length - 1)
        ReDim sinStelle3(sinStelle2.Length - 1)
        ReDim cosStelle3(cosStelle2.Length - 1)
        ReDim tanStelle3(tanStelle2.Length - 1)
        ReDim potencyStelle3(potencyStelle2.Length - 1)
        ReDim absStelle3(absStelle2.Length - 1)
        ReDim sqrtStelle3(sqrtStelle2.Length - 1)
        ReDim lnStelle3(lnStelle2.Length - 1)
        ReDim logStelle3(logStelle2.Length - 1)


        multiStelle2.CopyTo(multiStelle3, 0)
        divideStelle2.CopyTo(divideStelle3, 0)
        plusStelle2.CopyTo(plusStelle3, 0)
        minusStelle2.CopyTo(minusStelle3, 0)
        eingabeZahlen2.CopyTo(eingabeZahlen3, 0)
        xPosition2.CopyTo(xPosition3, 0)
        eStelle2.CopyTo(eStelle3, 0)
        piStelle2.CopyTo(piStelle3, 0)
        openBracketStelle2.CopyTo(openBracketStelle3, 0)
        closeBracketStelle2.CopyTo(closeBracketStelle3, 0)
        sinStelle2.CopyTo(sinStelle3, 0)
        cosStelle2.CopyTo(cosStelle3, 0)
        tanStelle2.CopyTo(tanStelle3, 0)
        potencyStelle2.CopyTo(potencyStelle3, 0)
        absStelle2.CopyTo(absStelle3, 0)
        sqrtStelle2.CopyTo(sqrtStelle3, 0)
        lnStelle2.CopyTo(lnStelle3, 0)
        logStelle2.CopyTo(logStelle3, 0)

        'replace all constants and variables
        Dim j
        For j = 0 To xPosition3.Length - 1
            If xPosition3(j) = True Then
                eingabeZahlen3(j) = xValue
            End If
        Next j
        For j = 0 To eStelle3.Length - 1
            If eStelle3(j) = True Then
                eingabeZahlen3(j) = Math.E
            End If
        Next j
        For j = 0 To piStelle3.Length - 1
            If piStelle3(j) = True Then
                eingabeZahlen3(j) = Math.PI
            End If
        Next j

        Dim bracketNumber = 0

        'total number of brackets
        Dim y
        For y = 0 To openBracketStelle3.Length - 1
            If openBracketStelle3(y) = True Then
                bracketNumber += 1
            End If
        Next y



        'Loop hier
        y = 0
        For y = 0 To bracketNumber

            Dim bracketOpen As Double = 0, bracketClose As Double = 0, bracketCounter As Double = 0


            j = bracketOpen
            Dim k
            k = 1

            For k = 0 + 1 To openBracketStelle3.Length - 1
                If closeBracketStelle3(k) = True Then
                    bracketClose = k                                                     'Stelle )       open -> j, close -> k             
                    For j = k To 0 Step -1
                        If openBracketStelle3(j) = True Then
                            bracketOpen = j                                             'Stelle (
                            Exit For
                        End If
                    Next j
                    Exit For
                End If
            Next k



            'start bracket Operations
            If bracketOpen > 0 Then
                ReDim multiStelle4(multiStelle3.Length - 1)
                ReDim divideStelle4(divideStelle3.Length - 1)
                ReDim plusStelle4(plusStelle3.Length - 1)
                ReDim minusStelle4(minusStelle3.Length - 1)
                ReDim eingabeZahlen4(eingabeZahlen3.Length - 1)
                ReDim xPosition4(xPosition3.Length - 1)
                ReDim eStelle4(eStelle3.Length - 1)
                ReDim piStelle4(piStelle3.Length - 1)
                ReDim sinStelle4(sinStelle3.Length - 1)
                ReDim cosStelle4(cosStelle3.Length - 1)
                ReDim tanStelle4(tanStelle3.Length - 1)
                ReDim potencyStelle4(potencyStelle3.Length - 1)
                ReDim absStelle4(absStelle3.Length - 1)
                ReDim sqrtStelle4(sqrtStelle3.Length - 1)
                ReDim lnStelle4(lnStelle3.Length - 1)
                ReDim logStelle4(logStelle3.Length - 1)

                multiStelle4 = schreibeKlammerninArray(bracketOpen, bracketClose, multiStelle3, multiStelle4)
                divideStelle4 = schreibeKlammerninArray(bracketOpen, bracketClose, divideStelle3, divideStelle4)
                divideStelle4 = schreibeKlammerninArray(bracketOpen, bracketClose, divideStelle3, divideStelle4)
                plusStelle4 = schreibeKlammerninArray(bracketOpen, bracketClose, plusStelle3, plusStelle4)
                minusStelle4 = schreibeKlammerninArray(bracketOpen, bracketClose, minusStelle3, minusStelle4)
                eingabeZahlen4 = schreibeKlammerninArray(bracketOpen, bracketClose, eingabeZahlen3, eingabeZahlen4)
                xPosition4 = schreibeKlammerninArray(bracketOpen, bracketClose, xPosition3, xPosition4)
                eStelle4 = schreibeKlammerninArray(bracketOpen, bracketClose, eStelle3, eStelle4)
                piStelle4 = schreibeKlammerninArray(bracketOpen, bracketClose, piStelle3, piStelle4)
                sinStelle4 = schreibeKlammerninArray(bracketOpen, bracketClose, sinStelle3, sinStelle4)
                cosStelle4 = schreibeKlammerninArray(bracketOpen, bracketClose, cosStelle3, cosStelle4)
                tanStelle4 = schreibeKlammerninArray(bracketOpen, bracketClose, tanStelle3, tanStelle4)
                potencyStelle4 = schreibeKlammerninArray(bracketOpen, bracketClose, potencyStelle3, potencyStelle4)
                absStelle4 = schreibeKlammerninArray(bracketOpen, bracketClose, absStelle3, absStelle4)
                sqrtStelle4 = schreibeKlammerninArray(bracketOpen, bracketClose, sqrtStelle3, sqrtStelle4)
                lnStelle4 = schreibeKlammerninArray(bracketOpen, bracketClose, lnStelle3, lnStelle4)
                logStelle4 = schreibeKlammerninArray(bracketOpen, bracketClose, logStelle3, logStelle4)

                ReDim Preserve multiStelle4((bracketClose - bracketOpen))
                ReDim Preserve divideStelle4((bracketClose - bracketOpen))
                ReDim Preserve plusStelle4((bracketClose - bracketOpen))
                ReDim Preserve minusStelle4((bracketClose - bracketOpen))
                ReDim Preserve eingabeZahlen4((bracketClose - bracketOpen))
                ReDim Preserve xPosition4((bracketClose - bracketOpen))
                ReDim Preserve eStelle4((bracketClose - bracketOpen))
                ReDim Preserve piStelle4((bracketClose - bracketOpen))
                ReDim Preserve sinStelle4((bracketClose - bracketOpen))
                ReDim Preserve cosStelle4((bracketClose - bracketOpen))
                ReDim Preserve tanStelle4((bracketClose - bracketOpen))
                ReDim Preserve potencyStelle4((bracketClose - bracketOpen))
                ReDim Preserve absStelle4((bracketClose - bracketOpen))
                ReDim Preserve sqrtStelle4((bracketClose - bracketOpen))
                ReDim Preserve lnStelle4((bracketClose - bracketOpen))
                ReDim Preserve logStelle4((bracketClose - bracketOpen))


                'replace special expressions in brackets

                'TODO: special expression in brackets

                'calculate bracket content
                eingabeZahlen3(bracketOpen) = berechneBrackets()




                eingabeZahlen3 = removeRestBracket(bracketOpen, bracketClose, eingabeZahlen3)
                multiStelle3 = removeRestBracket(bracketOpen, bracketClose, multiStelle3)
                divideStelle3 = removeRestBracket(bracketOpen, bracketClose, divideStelle3)
                plusStelle3 = removeRestBracket(bracketOpen, bracketClose, plusStelle3)
                minusStelle3 = removeRestBracket(bracketOpen, bracketClose, minusStelle3)
                xPosition3 = removeRestBracket(bracketOpen, bracketClose, xPosition3)
                eStelle3 = removeRestBracket(bracketOpen, bracketClose, eStelle3)
                piStelle3 = removeRestBracket(bracketOpen, bracketClose, piStelle3)
                sinStelle3 = removeRestBracket(bracketOpen, bracketClose, sinStelle3)
                cosStelle3 = removeRestBracket(bracketOpen, bracketClose, cosStelle3)
                tanStelle3 = removeRestBracket(bracketOpen, bracketClose, tanStelle3)
                potencyStelle3 = removeRestBracket(bracketOpen, bracketClose, potencyStelle3)
                absStelle3 = removeRestBracket(bracketOpen, bracketClose, absStelle3)
                sqrtStelle3 = removeRestBracket(bracketOpen, bracketClose, sqrtStelle3)
                lnStelle3 = removeRestBracket(bracketOpen, bracketClose, lnStelle3)
                logStelle3 = removeRestBracket(bracketOpen, bracketClose, logStelle3)
                openBracketStelle3 = removeRestBracket(bracketOpen, bracketClose, openBracketStelle3)
                closeBracketStelle3 = removeRestBracket(bracketOpen, bracketClose, closeBracketStelle3)


                ReDim Preserve eingabeZahlen3(eingabeZahlen3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve multiStelle3(multiStelle3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve divideStelle3(divideStelle3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve plusStelle3(plusStelle3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve minusStelle3(minusStelle3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve xPosition3(xPosition3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve eStelle3(eStelle3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve piStelle3(piStelle3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve sinStelle3(sinStelle3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve cosStelle3(cosStelle3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve tanStelle3(tanStelle3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve potencyStelle3(potencyStelle3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve absStelle3(absStelle3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve sqrtStelle3(sqrtStelle3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve lnStelle3(lnStelle3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve logStelle3(logStelle3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve openBracketStelle3(openBracketStelle3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve closeBracketStelle3(closeBracketStelle3.Length - 1 - (bracketClose - bracketOpen))

                openBracketStelle3(bracketOpen) = False
            End If

            replaceSpecials()
            'richitge Reihenfolge des Ersetzens
            bracketCounter += 1
            bracketOpen = 0
            bracketClose = 0

            'sin(1) = True
            'zahlen(2) = -10
            ' |
            ' V
            'zahlen(1) = 0.531
            'zahlen(2) = -10
            '-10 entfernen und Rest aufrücken
        Next y
        yValue = berechneTerm()
        yValue = (yMax / yStep) - (yValue / yStep)

        Return yValue
    End Function


    Function removeRestBracket(bracketOpen, bracketClose, myArray)
        Dim i
        For i = bracketClose + 1 To myArray.Length - 1
            myArray(i - (bracketClose - bracketOpen)) = myArray(i)
        Next i

        Return myArray
    End Function


    Function schreibeKlammerninArray(bracketOpen, bracketClose, myArray3, myArray4)
        Dim i
        For i = 0 To myArray3.Length - 1
            If i > bracketOpen And i <= bracketClose Then
                myArray4(i - bracketOpen) = myArray3(i)
            End If
        Next i

        Return myArray4
    End Function


    Sub replaceSpecials()

        For j = 0 To eingabeZahlen3.Length - 2
            If sinStelle3(j) = True And eingabeZahlen3(j + 1) <> Nothing Then
                eingabeZahlen3(j) = Math.Sin(eingabeZahlen3(j + 1))
            End If
        Next j

        For j = 0 To eingabeZahlen3.Length - 2
            If cosStelle3(j) = True And eingabeZahlen3(j + 1) <> Nothing Then
                eingabeZahlen3(j) = Math.Cos(eingabeZahlen3(j + 1))
            End If
        Next j

        For j = 0 To eingabeZahlen3.Length - 2
            If tanStelle3(j) = True And eingabeZahlen3(j + 1) <> Nothing Then
                eingabeZahlen3(j) = Math.Tan(eingabeZahlen3(j + 1))
            End If
        Next j

        For j = 0 To eingabeZahlen3.Length - 2
            If sqrtStelle3(j) = True And eingabeZahlen3(j + 1) <> Nothing Then
                eingabeZahlen3(j) = Math.Sqrt(eingabeZahlen3(j + 1))
            End If
        Next j

        For j = 0 To eingabeZahlen3.Length - 2
            If absStelle3(j) = True And eingabeZahlen3(j + 1) <> Nothing Then
                eingabeZahlen3(j) = Math.Abs(eingabeZahlen3(j + 1))
            End If
        Next j

        For j = 0 To eingabeZahlen3.Length - 2
            If lnStelle3(j) = True And eingabeZahlen3(j + 1) <> Nothing Then
                eingabeZahlen3(j) = Math.Log(eingabeZahlen3(j + 1))
            End If
        Next j

        For j = 0 To eingabeZahlen3.Length - 2
            If logStelle3(j) = True And eingabeZahlen3(j + 1) <> Nothing Then
                eingabeZahlen3(j) = Math.Log10(eingabeZahlen3(j + 1))
            End If
        Next j

    End Sub

    Sub copyArrays(i)
        Dim j

        For j = 0 To (i - 1)
            eingabeZahlen3(j) = eingabeZahlen3(j)
            multiStelle3(j) = multiStelle3(j)
            divideStelle3(j) = divideStelle3(j)
            plusStelle3(j) = plusStelle3(j)
            minusStelle3(j) = minusStelle3(j)
            potencyStelle3(j) = potencyStelle3(j)
        Next j
        For j = (i + 2) To eingabeZahlen3.Length - 1
            eingabeZahlen3(j - 2) = eingabeZahlen3(j)
            multiStelle3(j - 2) = multiStelle3(j)
            divideStelle3(j - 2) = divideStelle3(j)
            plusStelle3(j - 2) = plusStelle3(j)
            minusStelle3(j - 2) = minusStelle3(j)
            potencyStelle3(j - 2) = potencyStelle3(j)
        Next j

        ReDim Preserve multiStelle3(multiStelle3.Length - 3)
        ReDim Preserve divideStelle3(divideStelle3.Length - 3)
        ReDim Preserve plusStelle3(plusStelle3.Length - 3)
        ReDim Preserve minusStelle3(minusStelle3.Length - 3)
        ReDim Preserve eingabeZahlen3(eingabeZahlen3.Length - 3)
        ReDim Preserve potencyStelle3(potencyStelle3.Length - 3)
    End Sub

    Sub copyBracketArrays(i)
        Dim j

        For j = 0 To (i - 1)
            eingabeZahlen4(j) = eingabeZahlen4(j)
            multiStelle4(j) = multiStelle4(j)
            divideStelle4(j) = divideStelle4(j)
            plusStelle4(j) = plusStelle4(j)
            minusStelle4(j) = minusStelle4(j)
            potencyStelle4(j) = potencyStelle4(j)
        Next j
        For j = (i + 2) To eingabeZahlen4.Length - 1
            eingabeZahlen4(j - 2) = eingabeZahlen4(j)
            multiStelle4(j - 2) = multiStelle4(j)
            divideStelle4(j - 2) = divideStelle4(j)
            plusStelle4(j - 2) = plusStelle4(j)
            minusStelle4(j - 2) = minusStelle4(j)
            potencyStelle4(j - 2) = potencyStelle4(j)
        Next j

        ReDim Preserve multiStelle4(multiStelle4.Length - 3)
        ReDim Preserve divideStelle4(divideStelle4.Length - 3)
        ReDim Preserve plusStelle4(plusStelle4.Length - 3)
        ReDim Preserve minusStelle4(minusStelle4.Length - 3)
        ReDim Preserve eingabeZahlen4(eingabeZahlen4.Length - 3)
        ReDim Preserve potencyStelle4(potencyStelle4.Length - 3)
    End Sub


    Private Sub drawFunction(xValue, yValue)

        If yValue < ((Me.Height - boarder) + 1000) And yOld < ((Me.Height - boarder)) And yValue >= (0) - 1000 Then
            grf.DrawLine(Pens.Black, New Point(xOld, yOld), New Point(xPixel, yValue))
        End If

        xOld = xPixel
        yOld = yValue

    End Sub

    Function berechneBrackets()
        Dim ergebnis As Double
Line4:
        Dim i
        For i = 0 To eingabeZahlen4.Length - 1
            If potencyStelle4(i) = True Then
                'ergebnis = Math.Pow(eingabeZahlen4(i - 1), eingabeZahlen4(i + 1))
                ergebnis = Math.Pow(eingabeZahlen4(i - 1), eingabeZahlen4(i + 1))
                eingabeZahlen4(i - 1) = ergebnis
                copyBracketArrays(i)
                GoTo Line4
            End If
        Next i

Line1:
        For i = 0 To eingabeZahlen4.Length - 1
            If multiStelle4(i) = True Then
                Try
                    ergebnis = eingabeZahlen4(i - 1) * eingabeZahlen4(i + 1)
                    eingabeZahlen4(i - 1) = ergebnis
                    copyBracketArrays(i)
                    GoTo Line1
                Catch
                    MsgBox("An unknown error was found")
                    Me.Close()
                End Try
            ElseIf divideStelle4(i) = True Then
                Try
                    ergebnis = eingabeZahlen4(i - 1) / eingabeZahlen4(i + 1)
                    eingabeZahlen4(i - 1) = ergebnis
                    copyBracketArrays(i)
                    GoTo Line1
                Catch
                    MsgBox("An unknown error was found")
                    Me.Close()
                End Try
            End If
        Next i


        ergebnis = eingabeZahlen4(1)
        For i = 0 To eingabeZahlen4.Length - 1
            If plusStelle4(i) = True Then
                Try
                    ergebnis += eingabeZahlen4(i + 1)
                Catch
                    MsgBox("An unknown error was found")
                    Me.Close()
                End Try
            ElseIf minusStelle4(i) = True Then
                Try
                    ergebnis -= eingabeZahlen4(i + 1)
                Catch
                    MsgBox("An unknown error was found")
                    Me.Close()
                End Try
            End If
        Next i

        Return ergebnis
    End Function


    Function berechneTerm()
        Dim ergebnis As Double
        Dim i

Line3:
        For i = 0 To eingabeZahlen3.Length - 1
            If potencyStelle3(i) = True Then
                ergebnis = Math.Pow(eingabeZahlen3(i - 1), eingabeZahlen3(i + 1))
                eingabeZahlen3(i - 1) = ergebnis
                copyArrays(i)
                GoTo Line3
            End If
        Next i


Line2:

        For i = 0 To eingabeZahlen3.Length - 1
            If multiStelle3(i) = True Then
                ergebnis = eingabeZahlen3(i - 1) * eingabeZahlen3(i + 1)
                eingabeZahlen3(i - 1) = ergebnis
                copyArrays(i)
                GoTo Line2
            ElseIf divideStelle3(i) = True Then

                ergebnis = eingabeZahlen3(i - 1) / eingabeZahlen3(i + 1)
                eingabeZahlen3(i - 1) = ergebnis
                copyArrays(i)
                GoTo Line2
            End If
        Next i


        ergebnis = eingabeZahlen3(1)

        For i = 0 To eingabeZahlen3.Length - 1
            If plusStelle3(i) = True Then

                ergebnis += eingabeZahlen3(i + 1)

            ElseIf minusStelle3(i) = True Then

                ergebnis -= eingabeZahlen3(i + 1)

            End If
        Next i
        'ergebnis = eingabeZahlen3(1)

        Return ergebnis
    End Function


End Class
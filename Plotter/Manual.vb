Option Explicit On
'Version 1.1.0


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

    Dim multiPos2() As Boolean, dividePos2() As Boolean, plusPos2() As Boolean, minusPos2() As Boolean
    Dim multiPos3() As Boolean, dividePos3() As Boolean, plusPos3() As Boolean, minusPos3() As Boolean
    Dim multiPos4() As Boolean, dividePos4() As Boolean, plusPos4() As Boolean, minusPos4() As Boolean
    Dim potencyPos2() As Boolean, potencyPos3() As Boolean, potencyPos4() As Boolean

    Dim ePos2() As Boolean, ePos3() As Boolean, piPos2() As Boolean, piPos3() As Boolean
    Dim ePos4() As Boolean, piPos4() As Boolean

    Dim openBracketPos2() As Boolean, openBracketPos3() As Boolean, closeBracketPos2() As Boolean, closeBracketPos3() As Boolean
    Dim openBracketPos4() As Boolean, closeBracketPos4() As Boolean

    Dim sinPos2() As Boolean, sinPos3() As Boolean, sinPos4() As Boolean
    Dim cosPos2() As Boolean, cosPos3() As Boolean, cosPos4() As Boolean
    Dim tanPos2() As Boolean, tanPos3() As Boolean, tanPos4() As Boolean

    Dim absPos2() As Boolean, absPos3() As Boolean, absPos4() As Boolean

    Dim sqrtPos2() As Boolean, sqrtPos3() As Boolean, sqrtPos4() As Boolean
    Dim lnPos2() As Boolean, lnPos3() As Boolean, lnPos4() As Boolean
    Dim logPos2() As Boolean, logPos3() As Boolean, logPos4() As Boolean
    Dim rndPos2() As Boolean, rndPos3() As Boolean, rndPos4() As Boolean

    Dim entryNumber2() As Double, entryNumber3() As Double, entryNumber4() As Double
    Dim xPosition2() As Boolean, xPosition3() As Boolean, xPosition4() As Boolean

    Dim oldPosX As Integer, oldPosY As Integer
    Dim cursorPosX As Integer, cursorPosY As Integer

    Dim grf As System.Drawing.Graphics


    Private Sub Manual_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
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
        If Module1._entryState = True Then
            startValue = calcFunction(xMin)
        End If

        xOld = CLng(xMin)
        yOld = 0
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Timer1.Enabled = True

        Try
            Me.Location = New Point(My.Settings.LocationX, My.Settings.LocationY)
        Catch ex As Exception
            Placement.Show()
        End Try

        Me.KeyPreview = True

        Me.Width = 5000
        Me.Height = 5000

        grf = CreateGraphics()

        Me.Width = My.Computer.Screen.WorkingArea.Width / 2.259
        Me.Height = Me.Width * 1.106
        '@ FullHD
        'Me.Width = 850
        'Me.Height = 940


    End Sub


    Private Sub Manual_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        setWindow()

        If Module1._entryState = True Then
            plotFunction()
        End If

        Try
            My.Settings.LocationX = Me.Location.X
            My.Settings.LocationY = Me.Location.Y
        Catch ex As Exception
            Placement.Show()
        End Try
    End Sub

    Private Sub plotButton_Click(sender As Object, e As EventArgs) Handles plotButton.Click
        If Module1._entryState = True Then
            plotFunction()
        End If
    End Sub

    Private Sub windowButton_Click(sender As Object, e As EventArgs) Handles windowButton.Click
        getWindow()
        setWindow()

        If Module1._entryState = True Then
            plotFunction()
        End If
    End Sub

    Private Sub Manual_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Or e.KeyCode = Keys.Return Then
            getWindow()
            setWindow()

            If Module1._entryState = True Then
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


        If Module1.keepGraph = False Then
            grf.Clear(Color.White)
        End If

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

        multiPos2 = Module1.multiPos
        dividePos2 = Module1.dividePos
        plusPos2 = Module1.plusPos
        minusPos2 = Module1.minusPos
        entryNumber2 = Module1.entryNumber
        xPosition2 = Module1.xPosition
        ePos2 = Module1.ePos
        piPos2 = Module1.piPos
        openBracketPos2 = Module1.openBracketPos
        closeBracketPos2 = Module1.closeBracketPos
        sinPos2 = Module1.sinPos
        cosPos2 = Module1.cosPos
        tanPos2 = Module1.tanPos
        potencyPos2 = Module1.potencyPos
        absPos2 = Module1.absPos
        sqrtPos2 = Module1.sqrtPos
        lnPos2 = Module1.lnPos
        logPos2 = Module1.logPos
        rndPos2 = Module1.rndPos

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

        ReDim multiPos3(multiPos2.Length - 1)
        ReDim dividePos3(dividePos2.Length - 1)
        ReDim plusPos3(plusPos2.Length - 1)
        ReDim minusPos3(minusPos2.Length - 1)
        ReDim entryNumber3(entryNumber2.Length - 1)
        ReDim xPosition3(xPosition2.Length - 1)
        ReDim ePos3(ePos2.Length - 1)
        ReDim piPos3(piPos2.Length - 1)
        ReDim openBracketPos3(openBracketPos2.Length - 1)
        ReDim closeBracketPos3(closeBracketPos2.Length - 1)
        ReDim sinPos3(sinPos2.Length - 1)
        ReDim cosPos3(cosPos2.Length - 1)
        ReDim tanPos3(tanPos2.Length - 1)
        ReDim potencyPos3(potencyPos2.Length - 1)
        ReDim absPos3(absPos2.Length - 1)
        ReDim sqrtPos3(sqrtPos2.Length - 1)
        ReDim lnPos3(lnPos2.Length - 1)
        ReDim logPos3(logPos2.Length - 1)
        ReDim rndPos3(rndPos2.Length - 1)


        multiPos2.CopyTo(multiPos3, 0)
        dividePos2.CopyTo(dividePos3, 0)
        plusPos2.CopyTo(plusPos3, 0)
        minusPos2.CopyTo(minusPos3, 0)
        entryNumber2.CopyTo(entryNumber3, 0)
        xPosition2.CopyTo(xPosition3, 0)
        ePos2.CopyTo(ePos3, 0)
        piPos2.CopyTo(piPos3, 0)
        openBracketPos2.CopyTo(openBracketPos3, 0)
        closeBracketPos2.CopyTo(closeBracketPos3, 0)
        sinPos2.CopyTo(sinPos3, 0)
        cosPos2.CopyTo(cosPos3, 0)
        tanPos2.CopyTo(tanPos3, 0)
        potencyPos2.CopyTo(potencyPos3, 0)
        absPos2.CopyTo(absPos3, 0)
        sqrtPos2.CopyTo(sqrtPos3, 0)
        lnPos2.CopyTo(lnPos3, 0)
        logPos2.CopyTo(logPos3, 0)
        rndPos2.CopyTo(rndPos3, 0)

        'replace all constants and variables
        Dim j
        For j = 0 To xPosition3.Length - 1
            If xPosition3(j) = True Then
                entryNumber3(j) = xValue
            End If
        Next j
        For j = 0 To ePos3.Length - 1
            If ePos3(j) = True Then
                entryNumber3(j) = Math.E
            End If
        Next j
        For j = 0 To piPos3.Length - 1
            If piPos3(j) = True Then
                entryNumber3(j) = Math.PI
            End If
        Next j

        Dim bracketNumber = 0

        'total number of brackets
        Dim y
        For y = 0 To openBracketPos3.Length - 1
            If openBracketPos3(y) = True Then
                bracketNumber += 1
            End If
        Next y

        y = 0
        For y = 0 To bracketNumber

            Dim bracketOpen As Double = 0, bracketClose As Double = 0, bracketCounter As Double = 0


            j = bracketOpen
            Dim k
            k = 1

            For k = 0 + 1 To openBracketPos3.Length - 1
                If closeBracketPos3(k) = True Then
                    bracketClose = k                                                     'Pos )       open -> j, close -> k             
                    For j = k To 0 Step -1
                        If openBracketPos3(j) = True Then
                            bracketOpen = j                                             'Pos (
                            Exit For
                        End If
                    Next j
                    Exit For
                End If
            Next k

            'start bracket Operations
            If bracketOpen > 0 Then

                'replace Expressions in Brackets
                bracketExpressions()


                ReDim multiPos4(multiPos3.Length - 1)
                ReDim dividePos4(dividePos3.Length - 1)
                ReDim plusPos4(plusPos3.Length - 1)
                ReDim minusPos4(minusPos3.Length - 1)
                ReDim entryNumber4(entryNumber3.Length - 1)
                ReDim xPosition4(xPosition3.Length - 1)
                ReDim ePos4(ePos3.Length - 1)
                ReDim piPos4(piPos3.Length - 1)
                ReDim sinPos4(sinPos3.Length - 1)
                ReDim cosPos4(cosPos3.Length - 1)
                ReDim tanPos4(tanPos3.Length - 1)
                ReDim potencyPos4(potencyPos3.Length - 1)
                ReDim absPos4(absPos3.Length - 1)
                ReDim sqrtPos4(sqrtPos3.Length - 1)
                ReDim lnPos4(lnPos3.Length - 1)
                ReDim logPos4(logPos3.Length - 1)
                ReDim rndPos4(rndPos3.Length - 1)

                multiPos4 = schreibeKlammerninArray(bracketOpen, bracketClose, multiPos3, multiPos4)
                dividePos4 = schreibeKlammerninArray(bracketOpen, bracketClose, dividePos3, dividePos4)
                dividePos4 = schreibeKlammerninArray(bracketOpen, bracketClose, dividePos3, dividePos4)
                plusPos4 = schreibeKlammerninArray(bracketOpen, bracketClose, plusPos3, plusPos4)
                minusPos4 = schreibeKlammerninArray(bracketOpen, bracketClose, minusPos3, minusPos4)
                entryNumber4 = schreibeKlammerninArray(bracketOpen, bracketClose, entryNumber3, entryNumber4)
                xPosition4 = schreibeKlammerninArray(bracketOpen, bracketClose, xPosition3, xPosition4)
                ePos4 = schreibeKlammerninArray(bracketOpen, bracketClose, ePos3, ePos4)
                piPos4 = schreibeKlammerninArray(bracketOpen, bracketClose, piPos3, piPos4)
                sinPos4 = schreibeKlammerninArray(bracketOpen, bracketClose, sinPos3, sinPos4)
                cosPos4 = schreibeKlammerninArray(bracketOpen, bracketClose, cosPos3, cosPos4)
                tanPos4 = schreibeKlammerninArray(bracketOpen, bracketClose, tanPos3, tanPos4)
                potencyPos4 = schreibeKlammerninArray(bracketOpen, bracketClose, potencyPos3, potencyPos4)
                absPos4 = schreibeKlammerninArray(bracketOpen, bracketClose, absPos3, absPos4)
                sqrtPos4 = schreibeKlammerninArray(bracketOpen, bracketClose, sqrtPos3, sqrtPos4)
                lnPos4 = schreibeKlammerninArray(bracketOpen, bracketClose, lnPos3, lnPos4)
                logPos4 = schreibeKlammerninArray(bracketOpen, bracketClose, logPos3, logPos4)
                rndPos4 = schreibeKlammerninArray(bracketOpen, bracketClose, rndPos3, rndPos4)

                ReDim Preserve multiPos4((bracketClose - bracketOpen))
                ReDim Preserve dividePos4((bracketClose - bracketOpen))
                ReDim Preserve plusPos4((bracketClose - bracketOpen))
                ReDim Preserve minusPos4((bracketClose - bracketOpen))
                ReDim Preserve entryNumber4((bracketClose - bracketOpen))
                ReDim Preserve xPosition4((bracketClose - bracketOpen))
                ReDim Preserve ePos4((bracketClose - bracketOpen))
                ReDim Preserve piPos4((bracketClose - bracketOpen))
                ReDim Preserve sinPos4((bracketClose - bracketOpen))
                ReDim Preserve cosPos4((bracketClose - bracketOpen))
                ReDim Preserve tanPos4((bracketClose - bracketOpen))
                ReDim Preserve potencyPos4((bracketClose - bracketOpen))
                ReDim Preserve absPos4((bracketClose - bracketOpen))
                ReDim Preserve sqrtPos4((bracketClose - bracketOpen))
                ReDim Preserve lnPos4((bracketClose - bracketOpen))
                ReDim Preserve logPos4((bracketClose - bracketOpen))
                ReDim Preserve rndPos4((bracketClose - bracketOpen))

                'calculate bracket content
                entryNumber3(bracketOpen) = berechneBrackets()


                entryNumber3 = removeRestBracket(bracketOpen, bracketClose, entryNumber3)
                multiPos3 = removeRestBracket(bracketOpen, bracketClose, multiPos3)
                dividePos3 = removeRestBracket(bracketOpen, bracketClose, dividePos3)
                plusPos3 = removeRestBracket(bracketOpen, bracketClose, plusPos3)
                minusPos3 = removeRestBracket(bracketOpen, bracketClose, minusPos3)
                xPosition3 = removeRestBracket(bracketOpen, bracketClose, xPosition3)
                ePos3 = removeRestBracket(bracketOpen, bracketClose, ePos3)
                piPos3 = removeRestBracket(bracketOpen, bracketClose, piPos3)
                sinPos3 = removeRestBracket(bracketOpen, bracketClose, sinPos3)
                cosPos3 = removeRestBracket(bracketOpen, bracketClose, cosPos3)
                tanPos3 = removeRestBracket(bracketOpen, bracketClose, tanPos3)
                potencyPos3 = removeRestBracket(bracketOpen, bracketClose, potencyPos3)
                absPos3 = removeRestBracket(bracketOpen, bracketClose, absPos3)
                sqrtPos3 = removeRestBracket(bracketOpen, bracketClose, sqrtPos3)
                lnPos3 = removeRestBracket(bracketOpen, bracketClose, lnPos3)
                logPos3 = removeRestBracket(bracketOpen, bracketClose, logPos3)
                rndPos3 = removeRestBracket(bracketOpen, bracketClose, rndPos3)
                openBracketPos3 = removeRestBracket(bracketOpen, bracketClose, openBracketPos3)
                closeBracketPos3 = removeRestBracket(bracketOpen, bracketClose, closeBracketPos3)


                ReDim Preserve entryNumber3(entryNumber3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve multiPos3(multiPos3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve dividePos3(dividePos3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve plusPos3(plusPos3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve minusPos3(minusPos3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve xPosition3(xPosition3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve ePos3(ePos3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve piPos3(piPos3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve sinPos3(sinPos3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve cosPos3(cosPos3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve tanPos3(tanPos3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve potencyPos3(potencyPos3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve absPos3(absPos3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve sqrtPos3(sqrtPos3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve lnPos3(lnPos3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve logPos3(logPos3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve rndPos3(rndPos3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve openBracketPos3(openBracketPos3.Length - 1 - (bracketClose - bracketOpen))
                ReDim Preserve closeBracketPos3(closeBracketPos3.Length - 1 - (bracketClose - bracketOpen))

                openBracketPos3(bracketOpen) = False
            End If


            replaceExpressions()

            bracketCounter += 1
            bracketOpen = 0
            bracketClose = 0


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

    Sub bracketExpressions()
        Dim radian = Module1._radian

        For j = 0 To entryNumber3.Length - 2
            If radian = False Then
                If sinPos3(j) = True And openBracketPos3(j + 1) = False Then
                    entryNumber3(j) = Math.Sin((2 * Math.PI / 360) * entryNumber3(j + 1))
                End If
            Else
                If sinPos3(j) = True And openBracketPos3(j + 1) = False Then
                    entryNumber3(j) = Math.Sin(entryNumber3(j + 1))
                End If
            End If
        Next j

        For j = 0 To entryNumber3.Length - 2
            If radian = False Then
                If cosPos3(j) = True And openBracketPos3(j + 1) = False Then
                    entryNumber3(j) = Math.Cos((2 * Math.PI / 360) * entryNumber3(j + 1))
                End If
            Else
                If cosPos3(j) = True And openBracketPos3(j + 1) = False Then
                    entryNumber3(j) = Math.Cos(entryNumber3(j + 1))
                End If
            End If
        Next j

        For j = 0 To entryNumber3.Length - 2
            If radian = False Then
                If tanPos3(j) = True And openBracketPos3(j + 1) = False Then
                    entryNumber3(j) = Math.Tan((2 * Math.PI / 360) * entryNumber3(j + 1))
                End If
            Else
                If tanPos3(j) = True And openBracketPos3(j + 1) = False Then
                    entryNumber3(j) = Math.Tan(entryNumber3(j + 1))
                End If
            End If
        Next j

        For j = 0 To entryNumber3.Length - 2
            If sqrtPos3(j) = True And openBracketPos3(j + 1) = False Then
                entryNumber3(j) = Math.Sqrt(entryNumber3(j + 1))
            End If
        Next j

        For j = 0 To entryNumber3.Length - 2
            If rndPos3(j) = True And openBracketPos3(j + 1) = False Then
                entryNumber3(j) = Math.Round(entryNumber3(j + 1))
            End If
        Next j

        For j = 0 To entryNumber3.Length - 2
            If absPos3(j) = True And openBracketPos3(j + 1) = False Then
                entryNumber3(j) = Math.Abs(entryNumber3(j + 1))
            End If
        Next j

        For j = 0 To entryNumber3.Length - 2
            If lnPos3(j) = True And openBracketPos3(j + 1) = False Then
                entryNumber3(j) = Math.Log(entryNumber3(j + 1))
            End If
        Next j

        For j = 0 To entryNumber3.Length - 2
            If logPos3(j) = True And openBracketPos3(j + 1) = False Then
                entryNumber3(j) = Math.Log10(entryNumber3(j + 1))
            End If
        Next j
    End Sub

    Sub replaceExpressions()
        Dim radian = Module1._radian

        For j = 0 To entryNumber3.Length - 2
            If radian = False Then
                If sinPos3(j) = True And entryNumber3(j + 1) <> Nothing Then
                    entryNumber3(j) = Math.Sin((Math.PI / 180) * entryNumber3(j + 1))
                End If
            Else
                If sinPos3(j) = True And entryNumber3(j + 1) <> Nothing Then
                    entryNumber3(j) = Math.Sin(entryNumber3(j + 1))
                End If
            End If
        Next j

        For j = 0 To entryNumber3.Length - 2
            If radian = False Then
                If cosPos3(j) = True And entryNumber3(j + 1) <> Nothing Then
                    entryNumber3(j) = Math.Cos((Math.PI / 180) * entryNumber3(j + 1))
                End If
            Else
                If cosPos3(j) = True And entryNumber3(j + 1) <> Nothing Then
                    entryNumber3(j) = Math.Cos(entryNumber3(j + 1))
                End If
            End If
        Next j

        For j = 0 To entryNumber3.Length - 2
            If radian = False Then
                If tanPos3(j) = True And entryNumber3(j + 1) <> Nothing Then
                    entryNumber3(j) = Math.Tan((Math.PI / 180) * entryNumber3(j + 1))
                End If
            Else
                If tanPos3(j) = True And entryNumber3(j + 1) <> Nothing Then
                    entryNumber3(j) = Math.Tan(entryNumber3(j + 1))
                End If
            End If
        Next j

        For j = 0 To entryNumber3.Length - 2
            If sqrtPos3(j) = True And entryNumber3(j + 1) <> Nothing Then
                entryNumber3(j) = Math.Sqrt(entryNumber3(j + 1))
            End If
        Next j

        For j = 0 To entryNumber3.Length - 2
            If rndPos3(j) = True And entryNumber3(j + 1) <> Nothing Then
                entryNumber3(j) = Math.Round(entryNumber3(j + 1))
            End If
        Next j

        For j = 0 To entryNumber3.Length - 2
            If absPos3(j) = True And entryNumber3(j + 1) <> Nothing Then
                entryNumber3(j) = Math.Abs(entryNumber3(j + 1))
            End If
        Next j

        For j = 0 To entryNumber3.Length - 2
            If lnPos3(j) = True And entryNumber3(j + 1) <> Nothing Then
                entryNumber3(j) = Math.Log(entryNumber3(j + 1))
            End If
        Next j

        For j = 0 To entryNumber3.Length - 2
            If logPos3(j) = True And entryNumber3(j + 1) <> Nothing Then
                entryNumber3(j) = Math.Log10(entryNumber3(j + 1))
            End If
        Next j
    End Sub

    Sub copyArrays(i)
        Dim j

        For j = 0 To (i - 1)
            entryNumber3(j) = entryNumber3(j)
            multiPos3(j) = multiPos3(j)
            dividePos3(j) = dividePos3(j)
            plusPos3(j) = plusPos3(j)
            minusPos3(j) = minusPos3(j)
            potencyPos3(j) = potencyPos3(j)
        Next j
        For j = (i + 2) To entryNumber3.Length - 1
            entryNumber3(j - 2) = entryNumber3(j)
            multiPos3(j - 2) = multiPos3(j)
            dividePos3(j - 2) = dividePos3(j)
            plusPos3(j - 2) = plusPos3(j)
            minusPos3(j - 2) = minusPos3(j)
            potencyPos3(j - 2) = potencyPos3(j)
        Next j

        ReDim Preserve multiPos3(multiPos3.Length - 3)
        ReDim Preserve dividePos3(dividePos3.Length - 3)
        ReDim Preserve plusPos3(plusPos3.Length - 3)
        ReDim Preserve minusPos3(minusPos3.Length - 3)
        ReDim Preserve entryNumber3(entryNumber3.Length - 3)
        ReDim Preserve potencyPos3(potencyPos3.Length - 3)
    End Sub

    Sub copyBracketArrays(i)
        Dim j

        For j = 0 To (i - 1)
            entryNumber4(j) = entryNumber4(j)
            multiPos4(j) = multiPos4(j)
            dividePos4(j) = dividePos4(j)
            plusPos4(j) = plusPos4(j)
            minusPos4(j) = minusPos4(j)
            potencyPos4(j) = potencyPos4(j)
        Next j
        For j = (i + 2) To entryNumber4.Length - 1
            entryNumber4(j - 2) = entryNumber4(j)
            multiPos4(j - 2) = multiPos4(j)
            dividePos4(j - 2) = dividePos4(j)
            plusPos4(j - 2) = plusPos4(j)
            minusPos4(j - 2) = minusPos4(j)
            potencyPos4(j - 2) = potencyPos4(j)
        Next j

        ReDim Preserve multiPos4(multiPos4.Length - 3)
        ReDim Preserve dividePos4(dividePos4.Length - 3)
        ReDim Preserve plusPos4(plusPos4.Length - 3)
        ReDim Preserve minusPos4(minusPos4.Length - 3)
        ReDim Preserve entryNumber4(entryNumber4.Length - 3)
        ReDim Preserve potencyPos4(potencyPos4.Length - 3)
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
        For i = 0 To entryNumber4.Length - 1
            If potencyPos4(i) = True Then

                ergebnis = Math.Pow(entryNumber4(i - 1), entryNumber4(i + 1))
                entryNumber4(i - 1) = ergebnis
                copyBracketArrays(i)
                GoTo Line4
            End If
        Next i

Line1:
        For i = 0 To entryNumber4.Length - 1
            If multiPos4(i) = True Then
                Try
                    ergebnis = entryNumber4(i - 1) * entryNumber4(i + 1)
                    entryNumber4(i - 1) = ergebnis
                    copyBracketArrays(i)
                    GoTo Line1
                Catch
                    Placement.Show()
                End Try
            ElseIf dividePos4(i) = True Then
                Try
                    If entryNumber4(i + 1) = 0 Then
                        zeroDivision.Show()
                        Me.Close()
                    End If

                    ergebnis = entryNumber4(i - 1) / entryNumber4(i + 1)
                    entryNumber4(i - 1) = ergebnis
                    copyBracketArrays(i)
                    GoTo Line1
                Catch
                    Placement.Show()
                End Try
            End If
        Next i


        ergebnis = entryNumber4(1)
        For i = 0 To entryNumber4.Length - 1
            If plusPos4(i) = True Then
                Try
                    ergebnis += entryNumber4(i + 1)
                Catch
                    Placement.Show()
                End Try
            ElseIf minusPos4(i) = True Then
                Try
                    ergebnis -= entryNumber4(i + 1)
                Catch
                    Placement.Show()
                End Try
            End If
        Next i

        Return ergebnis
    End Function

    Function berechneTerm()
        Dim ergebnis As Double
        Dim i

Line3:
        For i = 0 To entryNumber3.Length - 1
            If potencyPos3(i) = True Then
                ergebnis = Math.Pow(entryNumber3(i - 1), entryNumber3(i + 1))
                entryNumber3(i - 1) = ergebnis
                copyArrays(i)
                GoTo Line3
            End If
        Next i


Line2:

        For i = 0 To entryNumber3.Length - 1
            If multiPos3(i) = True Then
                ergebnis = entryNumber3(i - 1) * entryNumber3(i + 1)
                entryNumber3(i - 1) = ergebnis
                copyArrays(i)
                GoTo Line2
            ElseIf dividePos3(i) = True Then
                If entryNumber3(i + 1) = 0 Then
                    zeroDivision.Show()
                    Me.Close()
                End If

                ergebnis = entryNumber3(i - 1) / entryNumber3(i + 1)
                entryNumber3(i - 1) = ergebnis
                copyArrays(i)
                GoTo Line2
            End If
        Next i


        ergebnis = entryNumber3(1)

        For i = 0 To entryNumber3.Length - 1
            If plusPos3(i) = True Then

                ergebnis += entryNumber3(i + 1)

            ElseIf minusPos3(i) = True Then

                ergebnis -= entryNumber3(i + 1)

            End If
        Next i


        Return ergebnis
    End Function


End Class
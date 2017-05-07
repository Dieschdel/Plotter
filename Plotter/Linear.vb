Option Explicit On
' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public Class Linear

    'Dim BMP As Drawing.Bitmap()
    'Dim GFX As Graphics = Graphics.FromImage(BMP)

    Const boarder = 81
    Const e = 2.71828182846
    Const Pi = 3.14159265359

    Dim xValue As Double, yValue As Double
    Dim xDraw As Double, yDraw As Double
    Dim xPixel As Double
    Dim xOld As Double, yOld As Double
    Dim xMin As Double = -10.0, xMax As Double = 10.0, yMin As Double = -10.0, yMax As Double = 10.0
    Dim a As Double = 1.0, b As Double = 1.0, c As Double = 0.0, d As Double = 0.0
    Dim startValue As Double
    Dim xHelp As Double

    Dim xPoint As Double, yPoint As Double

    Dim grf As System.Drawing.Graphics

    Private Sub setOld()
        startValue = calcFunction(xMin)
        xOld = (xMin)
        yOld = (startValue)
        'yOld = 0
    End Sub






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        grf = CreateGraphics()
        Me.Width = 1280
        Me.Height = 720


    End Sub

    Private Sub ManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualToolStripMenuItem.Click
        Me.Hide()
        Manual.Show()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub



    Private Sub plotButton_Click(sender As Object, e As EventArgs) Handles plotButton.Click
        plotFunction()
    End Sub

    Private Sub windowButton_Click(sender As Object, e As EventArgs) Handles windowButton.Click
        getWindow()
        setWindow()
        plotFunction()
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
        setWindow()

        If Double.TryParse(aBox.Text, 0) Then
            a = CDbl(aBox.Text)
        ElseIf aBox.Text = "Pi" Then
            a = Math.PI
        ElseIf aBox.Text = "e" Then
            a = Math.E
        End If

        If Double.TryParse(bBox.Text, 0) Then
            b = CDbl(bBox.Text)
        ElseIf bBox.Text = "Pi" Then
            b = Math.PI
        ElseIf bBox.Text = "e" Then
            b = Math.E
        End If

        If Double.TryParse(cBox.Text, 0) Then
            c = CDbl(cBox.Text)
        ElseIf aBox.Text = "Pi" Then
            c = Math.PI
        ElseIf aBox.Text = "e" Then
            c = Math.E
        End If

        If Double.TryParse(dBox.Text, 0) Then
            d = CDbl(dBox.Text)
        ElseIf bBox.Text = "Pi" Then
            d = Math.PI
        ElseIf bBox.Text = "e" Then
            d = Math.E
        End If

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

        'yValue = a * xValue + b                                         'for linear function

        yValue = a * Math.Sin(b * (xValue + c)) + d
        yValue = (yMax / yStep) - (yValue / yStep)

        Return yValue
    End Function

    Private Sub drawFunction(xValue, yValue)

        'xDraw = CInt(xPixel)
        'yDraw = CInt(yValue)

        If yDraw < Me.Height - boarder And yOld < Me.Height - boarder Then
            grf.DrawLine(Pens.Black, New Point(xOld, yOld), New Point(xPixel, yValue))
        End If


        xOld = xPixel
        yOld = yValue
    End Sub


End Class





Option Explicit On


Module Module1
    Public testVariable As Integer
    Public multiPos() As Boolean, dividePos() As Boolean, plusPos() As Boolean, minusPos() As Boolean
    Public entryNumber() As Double
    Public xPosition() As Boolean
    Public eingabeState As Boolean = False
    Public piPos() As Boolean, ePos() As Boolean
    Public openBracketPos() As Boolean, closeBracketPos() As Boolean
    Public sinPos() As Boolean, cosPos() As Boolean, tanPos() As Boolean
    Public potencyPos() As Boolean
    Public absPos() As Boolean, sqrtPos() As Boolean, lnPos() As Boolean, logPos() As Boolean, rndPos() As Boolean

    Public keepGraph As Boolean = False
    Public _radian As Boolean = True
End Module

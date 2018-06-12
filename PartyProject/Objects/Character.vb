Public Class Character

    Private strName As String
    Private intLvl As Integer

    Private intHP As Integer
    Private intAP As Integer
    Private intMaxHP As Integer
    Private intMaxAP As Integer

    Private intSTR As Integer
    Private intVIT As Integer
    Private intCHA As Integer
    Private intAGI As Integer
    Private intWIS As Integer
    Private intLCK As Integer

    Private intSTRBuffWPN As Integer
    Private intVITBuffWPN As Integer
    Private intCHABuffWPN As Integer
    Private intWISBuffWPN As Integer
    Private intAGIBuffWPN As Integer
    Private intLCKBuffWPN As Integer

    Private intSTRBuffARM As Integer
    Private intVITBuffARM As Integer
    Private intCHABuffARM As Integer
    Private intWISBuffARM As Integer
    Private intAGIBuffARM As Integer
    Private intLCKBuffARM As Integer

    Private intXP As Integer
    Private intReqXP As Integer

    Private intTech As Integer
    Private intUlt As Integer

    Private strWPN As String
    Private strEffect As String
    Private strScale As String
    Private intDAM As Integer
    Private intACC As Integer
    Private intUNQ As Integer

    Private strARM As String
    Private intRES As Integer

    Private intTempBuff As Integer = 1
    Private intTempBuffCounter As Integer = 0
    Private blnBuff As Boolean = False

    '''''''''''''''''''''''''''''''''
    Public Property Name() As String
    Public Property LVL() As Integer

    Public Property HP() As Integer
    Public Property AP() As Integer

    Public Property maxHP() As Integer
    Public Property maxAP() As Integer

    Public Property STR() As Integer
    Public Property VIT() As Integer
    Public Property CHA() As Integer
    Public Property AGI() As Integer
    Public Property WIS() As Integer
    Public Property LCK() As Integer

    Public Property STRBuffWPN() As Integer
    Public Property VITBuffWPN() As Integer
    Public Property CHABuffWPN() As Integer
    Public Property WISBuffWPN() As Integer
    Public Property AGIBuffWPN() As Integer
    Public Property LCKBuffWPN() As Integer

    Public Property STRBuffARM() As Integer
    Public Property VITBuffARM() As Integer
    Public Property CHABuffARM() As Integer
    Public Property WISBuffARM() As Integer
    Public Property AGIBuffARM() As Integer
    Public Property LCKBuffARM() As Integer

    Public Property XP() As Integer
    Public Property reqXP() As Integer

    Public Property Tech() As Integer
    Public Property Ult() As Integer

    Public Property WPN() As String
    Public Property WPNEffect() As String
    Public Property Scale() As String
    Public Property DAM() As Integer
    Public Property ACC() As Integer
    Public Property UNQ() As Integer


    Public Property ARM() As String
    Public Property RES() As Integer

    Public Property TempBuff() As String
    Public Property TempBuffCounter() As Integer
    Public Property Buff() As Boolean

    ' DAM refers to the damage of the weapon, during combat it is used to calculate attack damage when put inot a formula taking into account character stats
    ' RES and ACC are as above 
End Class

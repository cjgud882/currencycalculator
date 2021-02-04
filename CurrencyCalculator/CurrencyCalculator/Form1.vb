Public Class Form1
    Dim usd1 As Decimal








    Private Sub convertButton_Click(sender As Object, e As EventArgs) Handles convertButton.Click



        Decimal.TryParse(usdTextBox.Text, usd1)

        If usdTextBox.Text = String.Empty Then
            usd1 = getUSD(usd1)
        End If



        usdTextBox.Text = usd1



        poundTextBox.Text = getPounds(usd1)
        euroTextBox.Text = getEuros(usd1)
        rubleTextBox.Text = getRoubles(usd1)
        pesoTextBox.Text = getPesos(usd1)
        shekelTextBox.Text = getShekels(usd1)
        yenTextBox.Text = getYen(usd1)
        yuanTextBox.Text = getYuan(usd1)
        nzdTextBox.Text = getNZD(usd1)
        audTextBox.Text = getAUD(usd1)
        cadTextBox.Text = getCAD(usd1)
        bzdTextBox.Text = getBZD(usd1)
        hkdTextBox.Text = getHKD(usd1)



    End Sub




    Function getPounds(usd As Decimal) As Decimal
        Dim poundRate As Decimal
        poundRate = 0.73
        Return usd * poundRate


    End Function

    Function getEuros(usd As Decimal) As Decimal
        Dim euroRate As Decimal
        euroRate = 0.84
        Return usd * euroRate
    End Function

    Function getRoubles(usd As Decimal) As Decimal
        Dim rubleRate As Decimal
        rubleRate = 75.64
        Return usd * rubleRate
    End Function

    Function getPesos(usd As Decimal) As Decimal
        Dim pesoRate As Decimal
        pesoRate = 20.38
        Return usd * pesoRate
    End Function

    Function getShekels(usd As Decimal) As Decimal
        Dim shekelRate As Decimal
        shekelRate = 3.29
        Return usd * shekelRate
    End Function

    Function getYen(usd As Decimal) As Decimal
        Dim yenRate As Decimal
        yenRate = 105
        Return usd * yenRate

    End Function
    Function getYuan(usd As Decimal) As Decimal
        Dim yuanRate As Decimal
        yuanRate = 6.47
        Return usd * yuanRate

    End Function

    Function getNZD(usd As Decimal) As Decimal
        Dim nzdRate As Decimal
        nzdRate = 1.39
        Return usd * nzdRate

    End Function

    Function getAUD(usd As Decimal) As Decimal
        Dim audRate As Decimal
        audRate = 1.31


        Return usd * audRate

    End Function

    Function getCAD(usd As Decimal) As Decimal
        Dim cadRate As Decimal
        cadRate = 1.28
        Return usd * cadRate
    End Function

    Function getBZD(usd As Decimal) As Decimal
        Dim bzdRate As Decimal
        bzdRate = 2.01
        Return usd * bzdRate
    End Function

    Function getHKD(usd As Decimal) As Decimal
        Dim hkdRate As Decimal
        hkdRate = 7.75
        Return usd * hkdRate
    End Function


    Function getUSD(usd As String) As Decimal

        Dim poundRate As Decimal
        poundRate = 1.37

        Dim euroRate As Decimal
        euroRate = 1.2

        Dim rubleRate As Decimal
        rubleRate = 0.013

        Dim pesoRate As Decimal
        pesoRate = 0.049

        Dim shekelRate As Decimal
        shekelRate = 0.3

        Dim yenRate As Decimal
        yenRate = 0.0095

        Dim yuanRate As Decimal
        yuanRate = 0.15

        Dim nzdRate As Decimal
        nzdRate = 0.72

        Dim audRate As Decimal
        audRate = 0.76

        Dim cadRate As Decimal
        cadRate = 0.78

        Dim bzdRate As Decimal
        bzdRate = 0.5

        Dim hkdRate As Decimal
        hkdRate = 0.13





        If poundTextBox.Text <> String.Empty Then
            Decimal.TryParse(usdTextBox.Text, usd1)
            usd = poundTextBox.Text * poundRate


        ElseIf euroTextBox.Text <> String.Empty Then
            usd = euroTextBox.Text * euroRate

        ElseIf rubleTextBox.Text <> String.Empty Then
            usd = rubleTextBox.Text * rubleRate
        ElseIf pesoTextBox.Text <> String.Empty Then
            usd = pesoTextBox.Text * pesoRate
        ElseIf shekelTextBox.Text <> String.Empty Then
            usd = shekelTextBox.Text * shekelRate
        ElseIf yenTextBox.Text <> String.Empty Then
            usd = yenTextBox.Text * yenRate
        ElseIf yuanTextBox.Text <> String.Empty Then
            usd = yuanTextBox.Text * yuanRate
        ElseIf nzdTextBox.Text <> String.Empty Then
            usd = nzdTextBox.Text * nzdRate
        ElseIf audTextBox.Text <> String.Empty Then
            usd = audTextBox.Text * audRate
        ElseIf cadTextBox.Text <> String.Empty Then
            usd = cadTextBox.Text * cadRate
        ElseIf bzdTextBox.Text <> String.Empty Then
            usd = bzdTextBox.Text * bzdRate
        ElseIf hkdTextBox.Text <> String.Empty Then
            usd = hkdTextBox.Text * hkdRate
        End If


        Return usd




    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Clear.Click
        poundTextBox.Text = String.Empty
        euroTextBox.Text = String.Empty
        rubleTextBox.Text = String.Empty
        pesoTextBox.Text = String.Empty
        shekelTextBox.Text = String.Empty
        yenTextBox.Text = String.Empty
        yuanTextBox.Text = String.Empty
        nzdTextBox.Text = String.Empty
        audTextBox.Text = String.Empty
        cadTextBox.Text = String.Empty
        bzdTextBox.Text = String.Empty
        hkdTextBox.Text = String.Empty
        usdTextBox.Text = String.Empty

    End Sub

End Class

Module TaxCalc

    Public Function simpleTaxCalc(ByRef salary As Double) As Double
        Return salary * 0.35
    End Function

    Public Function complexTaxCalc(ByVal salary As Double) As Double

        Dim _taxAmount As Double = 0.0
        Dim tmpSalary As Double = salary
        Dim complexTaxPortionsPerc As Double() = {25, 22, 18, 12}
        Dim complexTaxPortionsAmount As Integer() = {20000, 10000, 10000}
        Dim count As Integer = 0

        While (tmpSalary > 0)

            If (count < 3) Then
                If (tmpSalary >= complexTaxPortionsAmount(count)) Then
                    _taxAmount += complexTaxPortionsAmount(count) * (complexTaxPortionsPerc(count) / 100.0)
                    tmpSalary -= complexTaxPortionsAmount(count)
                Else
                    _taxAmount += (tmpSalary * (complexTaxPortionsPerc(count) / 100.0))
                    tmpSalary = 0
                End If

            Else
                _taxAmount += (tmpSalary * (complexTaxPortionsPerc(count) / 100.0))
                tmpSalary = 0
            End If

            count += 1

        End While

        Return _taxAmount

    End Function

End Module

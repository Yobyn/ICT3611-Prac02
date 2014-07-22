Module testTaxCalc

    Public Sub main()
        Console.WriteLine("Testing tax")
        checkSimpleTaxCalc()
        checkComplexTax()
        Console.WriteLine("Done")
        Console.ReadKey()
    End Sub

    Public Sub checkSimpleTaxCalc()

        Debug.Assert(simpleTaxCalc(10000) = 3500, "Simple tax for 10000 wrong")

    End Sub

    Public Sub checkComplexTax()
        Debug.Assert(complexTaxCalc(20000) = 5000, "Complex tax until 1st entry, 20000 wrong")
        Debug.Assert(complexTaxCalc(30000) = 7200, "Complex tax until 2nd entry, 30000 wrong")
        Debug.Assert(complexTaxCalc(40000) = 9000, "Complex tax until 3rd entry, 40000 wrong")
        Debug.Assert(complexTaxCalc(50000) = 10200, "Complex tax for complete calc, 50000 wrong")
    End Sub

End Module

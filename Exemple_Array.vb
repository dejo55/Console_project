Module Exemple_Array

    Dim base, hight As Decimal

    Sub main()

        AcceptInput()
        Result()

        Console.ReadKey()

    End Sub
    Sub AcceptInput()
        Console.WriteLine("Enter the Base")
        base = Console.ReadLine()

        Console.WriteLine("Enter the Hight")
        hight = Console.ReadLine()
    End Sub

    Function hypo() As Decimal
        Return Math.Sqrt(Math.Pow(base, 2) + Math.Pow(hight, 2))
    End Function
    Sub Result()
        Console.WriteLine("Hypotenus = " & hypo.ToString("N3"))
    End Sub


End Module

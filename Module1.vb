Module Module1

    Sub Main()

        'First display Welcom to AFCOM 2022 
        'Input the number of teams participating
        '-West Africa 40%   ----East 10% ---   -North 30%  ---_South 20%
        Console.WriteLine(".........Welcome to AFCOM 2022........")
        Console.WriteLine()
        Console.WriteLine("*****..................*")
        Console.WriteLine("Please input the number of teams participating")
        Console.WriteLine()
        Console.WriteLine("****..........***")
        Console.WriteLine()

        Dim numberOfTeams, west, east, north, south As Integer

        ' Dim sentence As String

        numberOfTeams = CInt(Console.ReadLine())

        west = (numberOfTeams * 40) / 100
        east = (numberOfTeams * 10) / 100
        north = (numberOfTeams * 30) / 100
        south = (numberOfTeams * 20) / 100
        Console.WriteLine("*******")
        Console.WriteLine()
        Console.WriteLine("{0} Football teams are participating to the competition !!!!", numberOfTeams)
        ' sentence = "The North Africa will take 30% of " + numberOfTeams + " Which will make ::  " + north
        Console.WriteLine("*******")
        Console.WriteLine()


        Console.WriteLine()

        Console.WriteLine("The number of teams in the game are {0} ::: The west Afica will take 40% of {0} which is =={1}", numberOfTeams, west)
        Console.WriteLine()

        Console.WriteLine("The East Africa team will take 10 % of " & numberOfTeams & " which will give  :: " & east)
        Console.WriteLine()

        Console.WriteLine("The South Africa team will take 20 % of " & numberOfTeams & " which will give  :: " & south)
        Console.WriteLine()

        Console.WriteLine("The North Africa team will take 30 % of " & numberOfTeams & " which will give  :: " & north)
        ' Console.WriteLine("{0}", sentence)



        Console.ReadKey()

    End Sub

End Module

Public Class Hypotenus
    'Data declaration
    Private base, height As Decimal
    'Constructors
    Public Sub New()
        base = 0
        height = 0

    End Sub
    Public Sub New(ByVal base As Decimal, ByVal height As Decimal)
        Me.base = base
        Me.height = height
    End Sub

    Public Sub AcceptInput()
        Console.WriteLine("Base: ")
        base = Console.ReadLine()
        Console.WriteLine("Height: ")
        height = Console.ReadLine()

    End Sub
    Public Function hypo() As Decimal
        hypo = Math.Sqrt(Math.Pow(base, 2) + Math.Pow(height, 2))
    End Function

    Public Sub Results()
        Console.WriteLine("Hypotenus = " + hypo().ToString("N3"))
    End Sub
End Class

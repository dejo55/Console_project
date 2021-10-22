Module inputBox1

    Dim P, T, R As Decimal
    Sub main()

        acceptInput()
        Display()
        Console.ReadKey()
    End Sub


    Sub acceptInput()
        Try
            P = InputBox("Principal : ", , "0.00")
            T = InputBox("Time : ", , "0")
            R = InputBox("Rate: ", , "0.00")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Exception")
        End Try
    End Sub

    Function InterestCal() As Decimal

        Return (P * T * R) / 100
    End Function

    Sub Display()
        MsgBox("Principal - " & P.ToString("C") & vbCrLf &
               "Time - " & T.ToString("N2") & vbCrLf &
               "Rate - " & T.ToString("N2") & vbCrLf &
               "SI - " & InterestCal().ToString("C") & vbCrLf,
MsgBoxStyle.OkOnly, "Simple Interest")

    End Sub

End Module

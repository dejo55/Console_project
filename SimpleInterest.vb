Public Class SimpleInterest
    Private P, R, T As Decimal



    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Try
            P = CDec(btnP.Text)
            T = CDec(btnT.Text)
            R = CDec(btnR.Text)
            btnI.Text = ((P * T * R) / 100).ToString("C")
        Catch ex As Exception
            MsgBox("Invalid Input ", , "Exception")
        End Try

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        btnI.Clear()
        btnT.Clear()
        btnR.Clear()
        btnP.Clear()
    End Sub
End Class
Public Class Launch
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Creation.Show()
        Me.Hide() 'This will work for now.
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class

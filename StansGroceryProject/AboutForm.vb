Public Class AboutForm
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set label about the program
        AboutLabel.Text = "Stan's Grocery Search Program" & vbNewLine _
                    & "Acme Computer Products LLC." & vbNewLine _
                    & "Aftanom Anfilofieff" & vbNewLine _
                    & "Copyright 2021" & vbNewLine

    End Sub

    Private Sub AboutForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'show main form
        StansGroceryForm.Show()

    End Sub

    Private Sub ExitFormButton_Click(sender As Object, e As EventArgs) Handles ExitFormButton.Click
        'exit the form
        Me.Close()
    End Sub
End Class
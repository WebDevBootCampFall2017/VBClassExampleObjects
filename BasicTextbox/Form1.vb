Public Class Form1
    Private Sub Form1_Resize(sender As Object, e As EventArgs) _
        Handles MyBase.Resize

        'Print out new size into text box

        'Get new size of form
        Dim form As Form = sender

        'Get the new size of the form
        Dim form_size = form.Size

        'Set text equal to something
        TextBox1.Text = form_size.ToString()

    End Sub
End Class

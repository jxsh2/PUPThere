

Public Class Form2

    Private isLocked As Boolean = False ' Variable to track the lock state
    Private originalImageSize As Size

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Calculate the new position of the "Back" button based on the form size
        btnBack.Location = New Point(10, ClientSize.Height - btnBack.Height - 10) ' Adjust the X and Y values as needed
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class

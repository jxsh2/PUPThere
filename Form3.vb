﻿
Public Class Form3
    Private Sub back(sender As Object, e As EventArgs) Handles backbtn.Click
        backbtn.Location = New Point((ClientSize.Width - backbtn.Width) \ 2, ClientSize.Height - backbtn.Height - 10)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub wordcbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles wordcbox.SelectedIndexChanged
        If wordcbox.SelectedItem = "SYSTEM INFORMATION" Then
            meaning.Text = "PUPThere is an automated route management application that helps you find the shortest path between two locations in PUP Sta. Mesa  based on user-defined criteria. For example, if you want to find the shortest path between the main gate and Oval, you can tell PUPThere to automatically calculate the optimal route using the A* algorithm. PUPThere is designed to save you time and effort by automating the process of finding the shortest path.

To use the app, start by entering the starting location and destination in the respective text boxes. Once you click on the starting location text box, a list of options of places will appear for you to choose from. Similarly, when you click on the destination text box, a list of options of places will appear."

        End If
        If wordcbox.SelectedItem = "ENTER BUTTON" Then
            meaning.Text = "After you have entered both the starting point and destination, click on the Enter button on the screen. The app will calculate the shortest path between the two locations and display the result on the screen."
        End If
        If wordcbox.SelectedItem = "RESET BUTTON" Then
            meaning.Text = "If you want to start a new search, click on the Reset button to clear the text boxes and start over."
        End If
        If wordcbox.SelectedItem = "MAP BUTTON" Then
            meaning.Text = "If you want to view the map of the selected locations, click on the Map button."
        End If
        If wordcbox.SelectedItem = "EXIT BUTTON" Then
            meaning.Text = "To exit the app, click on the Exit button."
        End If

    End Sub
End Class

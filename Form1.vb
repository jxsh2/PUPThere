Imports System.Collections.Generic

Public Class Form1
    Private locations As Dictionary(Of String, PointD) = New Dictionary(Of String, PointD)()
    Private shortestPath As List(Of PointD) = New List(Of PointD)()
    Private totalDistance As Double = 0.0
    Private shortestPathsQueue As New PriorityQueue(Of List(Of PointD))(New ShortestPathComparer(Me))
    Private entBtnClicked As Boolean = False
    Private startcbOriginalItems As New List(Of String)()
    Private destcbOriginalItems As New List(Of String)()

    Private Structure PointD
        Public Property Longitude As Double
        Public Property Latitude As Double

        Public Sub New(longitude As Double, latitude As Double)
            Me.Longitude = longitude
            Me.Latitude = latitude
        End Sub

        Public Overrides Function Equals(obj As Object) As Boolean
            If TypeOf obj Is PointD Then
                Dim other As PointD = DirectCast(obj, PointD)
                Return Me.Longitude = other.Longitude AndAlso Me.Latitude = other.Latitude
            End If
            Return False
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return Longitude.GetHashCode() Xor Latitude.GetHashCode()
        End Function

        ' Implement the 'Equals' operator for PointD
        Public Shared Operator =(point1 As PointD, point2 As PointD) As Boolean
            Return point1.Equals(point2)
        End Operator

        Public Shared Operator <>(point1 As PointD, point2 As PointD) As Boolean
            Return Not point1.Equals(point2)
        End Operator
    End Structure
    Private Sub mapbtn_Click(sender As Object, e As EventArgs) Handles mapbtn.Click
        Form2.Show()
    End Sub
    Private Sub hlpbtn_Click(sender As Object, e As EventArgs) Handles hlpbtn.Click
        Form3.Show()
    End Sub
    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub rstbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rstbtn.Click
        Dim result As DialogResult = MessageBox.Show("This action will clear all fields. Do you want to continue?", "Clear All Fields", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            startcb.Text = "--SELECT--"
            destcb.Text = "--SELECT--"
            txtresult.Text = ""
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the predefined locations and their longitudes/latitudes
        ' Add more locations as needed
        locations.Add("MAIN GATE", New PointD(14.599247002175685, 121.0118226804876))
        locations.Add("VISITOR INFORMATION CENTER", New PointD(14.599113328370299, 121.01155043629768))
        locations.Add("GYM", New PointD(14.599282240779546, 121.01099094972356))
        locations.Add("TENNIS COURT", New PointD(14.598880372367811, 121.01120443135518))
        locations.Add("OVERHEAD TANK", New PointD(14.597771645693348, 121.00925976069443))
        locations.Add("OUTDOOR COURT", New PointD(14.598657699299286, 121.01083281099157))
        locations.Add("SWIMMING POOL", New PointD(14.598856263689573, 121.01032050907102))
        locations.Add("GAZEBO", New PointD(14.598609921996472, 121.01136218964184))
        locations.Add("MABINI MONUMENT", New PointD(14.598007738582087, 121.01111676752241))
        locations.Add("PUP SOUVENIR", New PointD(14.598464567530128, 121.01118784605971))
        locations.Add("GRANDSTAND", New PointD(14.598038139608716, 121.01149807139221))
        locations.Add("COMMUNITY BUILDING", New PointD(14.598106947270642, 121.01256398240135))
        locations.Add("OVAL", New PointD(14.59812252099338, 121.01207045595351))
        locations.Add("CHAPEL", New PointD(14.597178614670304, 121.01142413841909))
        locations.Add("NUTRITION AND FOOD SCIENCE BUILDING", New PointD(14.596854160488054, 121.01170040594265))
        locations.Add("EAST WING", New PointD(14.596701017950254, 121.01103790032421))
        locations.Add("CAMPUS DEVELOPMENT AND MAINTENANCE BUILDING", New PointD(14.596337628434911, 121.01117469296958))
        locations.Add("PUP STA. MESA FERRY", New PointD(14.596158529103903, 121.01080991255159))
        locations.Add("GENERATOR FACILITY", New PointD(14.596262354821967, 121.01057924257542))
        locations.Add("SOUTH WING", New PointD(14.596571236045397, 121.01071871743883))
        locations.Add("WEST WING", New PointD(14.596921646986255, 121.0103700302746))
        locations.Add("MAIN BUILDING", New PointD(14.597085171901, 121.01071603522988))
        locations.Add("CANTEEN SAMPAGUITA BLDG", New PointD(14.596797056498255, 121.00986041056586))
        locations.Add("STUDENT CANTEEN", New PointD(14.59695019896906, 121.0097853087151))
        locations.Add("CHARLIE DEL ROSARIO HALL", New PointD(14.597126702023523, 121.009608282924))
        locations.Add("LABORATORY HS", New PointD(14.59737069130682, 121.00927300680456))
        locations.Add("PRINTING PRESS BLDG", New PointD(14.597373286939543, 121.00855953920696))
        locations.Add("PROPERTY BLDG", New PointD(14.597775609100268, 121.0089296840429))
        locations.Add("WATER PUMP FACILITY", New PointD(14.597853477820193, 121.00908256995336))
        locations.Add("UNDERGROUND TANK", New PointD(14.597819734711614, 121.00931323992356))
        locations.Add("NINOY A. LIBRARY A", New PointD(14.597814543466114, 121.00966997371745))
        locations.Add("NINOY A. LIBRARY B", New PointD(14.598263462777153, 121.00990197292941))
        locations.Add("LAGOON", New PointD(14.597676975351243, 121.01038075909069))
        locations.Add("AMPHITHEATRE", New PointD(14.597414817007376, 121.01021177992649))
        locations.Add("PE BUILDING", New PointD(14.59844982152952, 121.01004078911747))
        locations.Add("TAHANAN NG ALUMNI", New PointD(14.598509520700963, 121.01007565783389))
        ' Populate the ComboBoxes with location names from the locations dictionary
        For Each vertex As String In locations.Keys
            startcb.Items.Add(vertex)
            destcb.Items.Add(vertex)
            ' Store the original items for later filtering
            startcbOriginalItems.Add(vertex)
            destcbOriginalItems.Add(vertex)
        Next

    End Sub
    Private Sub startcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles startcb.SelectedIndexChanged
        If startcb.SelectedItem IsNot Nothing Then
            Dim selectedLocation As String = DirectCast(startcb.SelectedItem, String)
            If Not locations.ContainsKey(selectedLocation) Then
                MessageBox.Show("Invalid start location selected.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                startcb.SelectedIndex = -1 ' Clear the selected item
            End If
        End If
    End Sub

    Private Sub destcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles destcb.SelectedIndexChanged
        If destcb.SelectedItem IsNot Nothing Then
            Dim selectedLocation As String = DirectCast(destcb.SelectedItem, String)
            If Not locations.ContainsKey(selectedLocation) Then
                MessageBox.Show("Invalid destination location selected.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                destcb.SelectedIndex = -1
            End If
        End If
    End Sub
    Private Sub startcb_TextChanged(sender As Object, e As EventArgs) Handles startcb.TextChanged
        FilterComboBoxItems(startcb)
    End Sub

    Private Sub destcb_TextChanged(sender As Object, e As EventArgs) Handles destcb.TextChanged
        FilterComboBoxItems(destcb)
    End Sub
    Private Sub FilterComboBoxItems(combobox As ComboBox)
        ' Get the user's input from the ComboBox
        Dim userInput As String = combobox.Text.Trim()

        ' Clear the ComboBox items and re-add the filtered items
        Dim originalItems As List(Of String) = If(combobox Is startcb, startcbOriginalItems, destcbOriginalItems)
        combobox.Items.Clear()
        For Each location As String In originalItems
            If location.IndexOf(userInput, StringComparison.CurrentCultureIgnoreCase) >= 0 Then
                combobox.Items.Add(location)
            End If
        Next

        ' Display the drop-down list if there are matching items
        If combobox.Items.Count > 0 Then
            combobox.DroppedDown = True
        End If

        ' Preserve the user's input while filtering the items
        Dim selectionStart As Integer = combobox.SelectionStart
        If userInput.Length > 0 Then
            combobox.Text = userInput
            combobox.SelectionStart = If(selectionStart > userInput.Length, userInput.Length, selectionStart)
        End If
    End Sub


    Private Function GetLocationName(location As PointD) As String
        ' Retrieve the name of the location based on the PointD object
        For Each kvp As KeyValuePair(Of String, PointD) In locations
            If kvp.Value = location Then
                Return kvp.Key
            End If
        Next
        Return ""
    End Function

    Private Function CalculateHaversineDistance(point1 As PointD, point2 As PointD) As Double
        ' Calculate the Haversine distance between two points in meters
        Dim earthRadiusKm As Double = 6371.0 ' Earth's radius in kilometers

        Dim lat1Rad As Double = DegreeToRadians(point1.Latitude)
        Dim lon1Rad As Double = DegreeToRadians(point1.Longitude)
        Dim lat2Rad As Double = DegreeToRadians(point2.Latitude)
        Dim lon2Rad As Double = DegreeToRadians(point2.Longitude)

        Dim dLat As Double = lat2Rad - lat1Rad
        Dim dLon As Double = lon2Rad - lon1Rad

        Dim a As Double = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Cos(lat1Rad) * Math.Cos(lat2Rad) * Math.Sin(dLon / 2) * Math.Sin(dLon / 2)
        Dim c As Double = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a))
        Dim distanceKm As Double = earthRadiusKm * c

        Dim distanceMeters As Double = distanceKm * 1000 ' Convert to meters

        Return distanceMeters
    End Function

    Private Function DegreeToRadians(degrees As Double) As Double
        Return degrees * Math.PI / 180
    End Function

    Private Function AStarAlgorithm(start As PointD, dest As PointD) As List(Of PointD)
        ' The A* algorithm with Euclidean distance heuristic
        Dim openSet As List(Of PointD) = New List(Of PointD)()
        Dim cameFrom As Dictionary(Of PointD, PointD) = New Dictionary(Of PointD, PointD)()
        Dim gScore As Dictionary(Of PointD, Double) = New Dictionary(Of PointD, Double)()
        Dim fScore As Dictionary(Of PointD, Double) = New Dictionary(Of PointD, Double)()

        openSet.Add(start)
        gScore(start) = 0
        fScore(start) = CalculateEuclideanDistance(start, dest)

        While openSet.Any()
            Dim current As PointD = openSet.OrderBy(Function(p) fScore(p)).First()

            If current.Equals(dest) Then
                Return ReconstructPath(cameFrom, current)
            End If

            openSet.Remove(current)

            For Each neighbor As PointD In GetNeighbors(current)
                Dim tentativeGScore As Double = gScore(current) + CalculateHaversineDistance(current, neighbor)

                If Not gScore.ContainsKey(neighbor) OrElse tentativeGScore < gScore(neighbor) Then
                    cameFrom(neighbor) = current
                    gScore(neighbor) = tentativeGScore
                    fScore(neighbor) = gScore(neighbor) + CalculateEuclideanDistance(neighbor, dest)

                    If Not openSet.Contains(neighbor) Then
                        openSet.Add(neighbor)
                    End If
                End If
            Next
        End While

        ' If no path is found
        Return New List(Of PointD)()
    End Function
    Private Sub entbtn_Click(sender As Object, e As EventArgs) Handles entbtn.Click
        If startcb.SelectedItem Is Nothing OrElse destcb.SelectedItem Is Nothing Then
            MessageBox.Show("You should input both the starting point and destination point to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        entBtnClicked = True
        txtresult.Text = ""

        ' Get the selected start and destination locations from ComboBoxes
        Dim startLocationName As String = DirectCast(startcb.SelectedItem, String)
        Dim destLocationName As String = DirectCast(destcb.SelectedItem, String)

        ' Retrieve the corresponding coordinates from the locations dictionary
        Dim startLocation As PointD = locations(startLocationName)
        Dim destLocation As PointD = locations(destLocationName)

        ' Find all the shortest paths using the Depth-First Search (DFS) algorithm
        FindAllShortestPaths(startLocation, destLocation)

        ' Print all the shortest paths
        PrintAllShortestPaths()
    End Sub

    Private Sub FindAllShortestPaths(startLocation As PointD, destLocation As PointD)
        Dim currentPath As List(Of PointD) = New List(Of PointD)
        currentPath.Add(startLocation)

        ' Call the recursive method to find all paths
        DFSRecursive(startLocation, destLocation, currentPath)
    End Sub

    Private Sub DFSRecursive(currentLocation As PointD, destLocation As PointD, currentPath As List(Of PointD))
        If currentLocation.Equals(destLocation) Then
            ' If the current location is the destination, store the path in the queue
            shortestPathsQueue.Enqueue(New List(Of PointD)(currentPath))
        Else
            ' Explore the neighbors and continue the path
            For Each neighbor As PointD In GetNeighbors(currentLocation)
                If Not currentPath.Contains(neighbor) Then
                    currentPath.Add(neighbor)
                    DFSRecursive(neighbor, destLocation, currentPath)
                    currentPath.RemoveAt(currentPath.Count - 1)
                End If
            Next
        End If
    End Sub

    Private Sub PrintAllShortestPaths()
        ' Clear the txtresult TextBox before printing the new results
        txtresult.Text = ""

        Dim i As Integer = 1
        While shortestPathsQueue.Count > 0 AndAlso i <= 3
            Dim shortestPath As List(Of PointD) = shortestPathsQueue.Dequeue()
            totalDistance = CalculateTotalDistanceMeters(shortestPath)

            txtresult.AppendText($"Path {i}:{Environment.NewLine}")
            For j As Integer = 0 To shortestPath.Count - 1
                Dim current As PointD = shortestPath(j)
                txtresult.AppendText($"{GetLocationName(current)} -> ")
            Next
            ' Display the total distance in meters (as a whole number) in the RichTextBox
            txtresult.AppendText($"Total Distance: {CInt(totalDistance)} meters{Environment.NewLine}{Environment.NewLine}")

            i += 1
        End While
    End Sub
    Private Sub SortPaths(paths As List(Of List(Of PointD)))
        ' Sort the paths based on their total distance using a simple bubble sort
        Dim n As Integer = paths.Count
        For i As Integer = 0 To n - 1
            For j As Integer = 0 To n - i - 2
                Dim totalDistance1 As Double = CalculateTotalDistanceMeters(paths(j))
                Dim totalDistance2 As Double = CalculateTotalDistanceMeters(paths(j + 1))

                If totalDistance1 > totalDistance2 Then
                    ' Swap paths j and j+1
                    Dim temp As List(Of PointD) = paths(j)
                    paths(j) = paths(j + 1)
                    paths(j + 1) = temp
                End If
            Next
        Next
    End Sub


    ' Priority queue implementation for comparing shortest paths
    Private Class ShortestPathComparer
        Implements IComparer(Of List(Of PointD))

        Private formInstance As Form1

        Public Sub New(formInstance As Form1)
            Me.formInstance = formInstance
        End Sub

        Public Function Compare(x As List(Of PointD), y As List(Of PointD)) As Integer Implements IComparer(Of List(Of PointD)).Compare
            ' Compare based on the total distance of the paths
            Dim totalDistanceX As Double = formInstance.CalculateTotalDistanceMeters(x)
            Dim totalDistanceY As Double = formInstance.CalculateTotalDistanceMeters(y)
            Return totalDistanceX.CompareTo(totalDistanceY)
        End Function
    End Class

    ' Priority queue implementation using a heap
    Private Class PriorityQueue(Of T)
        Private heap As List(Of T)
        Private comparer As IComparer(Of T)

        Public Sub New(comparer As IComparer(Of T))
            Me.heap = New List(Of T)()
            Me.comparer = comparer
        End Sub

        Public Sub Enqueue(item As T)
            heap.Add(item)
            Dim i As Integer = heap.Count - 1
            While i > 0
                Dim parent As Integer = (i - 1) \ 2
                If comparer.Compare(heap(parent), heap(i)) <= 0 Then Exit While
                Dim tmp As T = heap(parent)
                heap(parent) = heap(i)
                heap(i) = tmp
                i = parent
            End While
        End Sub

        Public Function Dequeue() As T
            Dim last As Integer = heap.Count - 1
            Dim front As T = heap(0)
            heap(0) = heap(last)
            heap.RemoveAt(last)
            last -= 1
            Dim i As Integer = 0
            While True
                Dim left As Integer = i * 2 + 1
                Dim right As Integer = left + 1
                If left > last Then Exit While
                Dim smallest As Integer = left
                If right <= last AndAlso comparer.Compare(heap(left), heap(right)) > 0 Then
                    smallest = right
                End If
                If comparer.Compare(heap(i), heap(smallest)) <= 0 Then Exit While
                Dim tmp As T = heap(i)
                heap(i) = heap(smallest)
                heap(smallest) = tmp
                i = smallest
            End While
            Return front
        End Function

        Public Function Count() As Integer
            Return heap.Count
        End Function

        Public Sub Clear()
            heap.Clear()
        End Sub
    End Class

    Private Function ReconstructPath(cameFrom As Dictionary(Of PointD, PointD), current As PointD) As List(Of PointD)
        Dim path As List(Of PointD) = New List(Of PointD)()
        path.Add(current)

        While cameFrom.ContainsKey(current)
            current = cameFrom(current)
            path.Insert(0, current)
        End While

        Return path
    End Function

    Private Function GetNeighbors(location As PointD) As List(Of PointD)
        ' Define the neighboring locations for a given location (manually)
        Dim neighbors As List(Of PointD) = New List(Of PointD)()

        ' Add neighboring locations for the given location
        Select Case GetLocationName(location)
            Case "MAIN GATE"
                neighbors.Add(locations("COMMUNITY BUILDING"))
                neighbors.Add(locations("VISITOR INFORMATION CENTER"))
                neighbors.Add(locations("OVAL"))
            Case "VISITOR INFORMATION CENTER"
                neighbors.Add(locations("MAIN GATE"))
                neighbors.Add(locations("GRANDSTAND"))
                neighbors.Add(locations("TENNIS COURT"))
                neighbors.Add(locations("GAZEBO"))
                neighbors.Add(locations("GYM"))
            Case "OVERHEAD TANK"
                neighbors.Add(locations("UNDERGROUND TANK"))
                neighbors.Add(locations("LABORATORY HS"))
                neighbors.Add(locations("CHARLIE DEL ROSARIO HALL"))
                neighbors.Add(locations("NINOY A. LIBRARY A"))
            Case "OUTDOOR COURT"
                neighbors.Add(locations("GYM"))
                neighbors.Add(locations("TENNIS COURT"))
                neighbors.Add(locations("GAZEBO"))
                neighbors.Add(locations("SWIMMING POOL"))
            Case "SWIMMING POOL"
                neighbors.Add(locations("TAHANAN NG ALUMNI"))
                neighbors.Add(locations("PE BUILDING"))
                neighbors.Add(locations("GYM"))
                neighbors.Add(locations("OUTDOOR COURT"))
            Case "GAZEBO"
                neighbors.Add(locations("VISITOR INFORMATION CENTER"))
                neighbors.Add(locations("TENNIS COURT"))
                neighbors.Add(locations("OUTDOOR COURT"))
                neighbors.Add(locations("MABINI MONUMENT"))
                neighbors.Add(locations("PUP SOUVENIR"))
            Case "MABINI MONUMENT"
                neighbors.Add(locations("GAZEBO"))
                neighbors.Add(locations("PUP SOUVENIR"))
                neighbors.Add(locations("LAGOON"))
                neighbors.Add(locations("NINOY A. LIBRARY B"))
                neighbors.Add(locations("PE BUILDING"))
                neighbors.Add(locations("TAHANAN NG ALUMNI"))
            Case "PUP SOUVENIR"
                neighbors.Add(locations("MABINI MONUMENT"))
                neighbors.Add(locations("GAZEBO"))
                neighbors.Add(locations("OVAL"))
            Case "GRANDSTAND"
                neighbors.Add(locations("VISITOR INFORMATION CENTER"))
                neighbors.Add(locations("OVAL"))
                neighbors.Add(locations("OVAL"))
            Case "COMMUNITY BUILDING"
                neighbors.Add(locations("OVAL"))
                neighbors.Add(locations("MAIN GATE"))
            Case "OVAL"
                neighbors.Add(locations("VISITOR INFORMATION CENTER"))
                neighbors.Add(locations("GRANDSTAND"))
                neighbors.Add(locations("CHAPEL"))
            Case "CHAPEL"
                neighbors.Add(locations("OVAL"))
                neighbors.Add(locations("GRANDSTAND"))
                neighbors.Add(locations("MAIN BUILDING"))
                neighbors.Add(locations("EAST WING"))
                neighbors.Add(locations("NUTRITION AND FOOD SCIENCE BUILDING"))
            Case "NUTRITION AND FOOD SCIENCE BUILDING"
                neighbors.Add(locations("CHAPEL"))
                neighbors.Add(locations("EAST WING"))
                neighbors.Add(locations("CAMPUS DEVELOPMENT AND MAINTENANCE BUILDING"))
            Case "EAST WING"
                neighbors.Add(locations("NUTRITION AND FOOD SCIENCE BUILDING"))
                neighbors.Add(locations("CHAPEL"))
                neighbors.Add(locations("MAIN BUILDING"))
            Case "CAMPUS DEVELOPMENT AND MAINTENANCE BUILDING"
                neighbors.Add(locations("PUP STA. MESA FERRY"))
                neighbors.Add(locations("GENERATOR FACILITY"))
            Case "PUP STA. MESA FERRY"
                neighbors.Add(locations("GENERATOR FACILITY"))
                neighbors.Add(locations("CAMPUS DEVELOPMENT AND MAINTENANCE BUILDING"))
            Case "GENERATOR FACILITY"
                neighbors.Add(locations("SOUTH WING"))
            Case "SOUTH WING"
                neighbors.Add(locations("MAIN BUILDING"))
                neighbors.Add(locations("CANTEEN SAMPAGUITA BLDG"))
            Case "WEST WING"
                neighbors.Add(locations("MAIN BUILDING"))
                neighbors.Add(locations("CANTEEN SAMPAGUITA BLDG"))
                neighbors.Add(locations("STUDENT CANTEEN"))
            Case "MAIN BUILDING"
                neighbors.Add(locations("AMPHITHEATRE"))
                neighbors.Add(locations("EAST WING"))
                neighbors.Add(locations("WEST WING"))
                neighbors.Add(locations("CHAPEL"))
            Case "CANTEEN SAMPAGUITA BLDG"
                neighbors.Add(locations("WEST WING"))
                neighbors.Add(locations("STUDENT CANTEEN"))
                neighbors.Add(locations("SOUTH WING"))
            Case "STUDENT CANTEEN"
                neighbors.Add(locations("CANTEEN SAMPAGUITA BLDG"))
                neighbors.Add(locations("WEST WING"))
                neighbors.Add(locations("NINOY A. LIBRARY A"))
                neighbors.Add(locations("AMPHITHEATRE"))
            Case "CHARLIE DEL ROSARIO HALL"
                neighbors.Add(locations("NINOY A. LIBRARY A"))
                neighbors.Add(locations("OVERHEAD TANK"))
                neighbors.Add(locations("LABORATORY HS"))
                neighbors.Add(locations("STUDENT CANTEEN"))
            Case "LABORATORY HS"
                neighbors.Add(locations("OVERHEAD TANK"))
                neighbors.Add(locations("UNDERGROUND TANK"))
                neighbors.Add(locations("CHARLIE DEL ROSARIO HALL"))
            Case "PRINTING PRESS BLDG"
                neighbors.Add(locations("PROPERTY BLDG"))
            Case "PROPERTY BLDG"
                neighbors.Add(locations("PRINTING PRESS BLDG"))
                neighbors.Add(locations("WATER PUMP FACILITY"))
            Case "WATER PUMP FACILITY"
                neighbors.Add(locations("PROPERTY BLDG"))
                neighbors.Add(locations("GYM"))
                neighbors.Add(locations("UNDERGROUND TANK"))
            Case "NINOY A. LIBRARY A"
                neighbors.Add(locations("AMPHITHEATRE"))
                neighbors.Add(locations("OVERHEAD TANK"))
                neighbors.Add(locations("LABORATORY HS"))
                neighbors.Add(locations("CHARLIE DEL ROSARIO HALL"))
                neighbors.Add(locations("STUDENT CANTEEN"))
            Case "NINOY A. LIBRARY B"
                neighbors.Add(locations("MABINI MONUMENT"))
            Case "LAGOON"
                neighbors.Add(locations("MABINI MONUMENT"))
                neighbors.Add(locations("AMPHITHEATRE"))
            Case "AMPHITHEATRE"
                neighbors.Add(locations("LAGOON"))
                neighbors.Add(locations("MAIN BUILDING"))
                neighbors.Add(locations("STUDENT CANTEEN"))
                neighbors.Add(locations("CHARLIE DEL ROSARIO HALL"))
                neighbors.Add(locations("LABORATORY HS"))
                neighbors.Add(locations("NINOY A. LIBRARY A"))
            Case "PE BUILDING"
                neighbors.Add(locations("MABINI MONUMENT"))
                neighbors.Add(locations("TAHANAN NG ALUMNI"))
            Case "TAHANAN NG ALUMNI"
                neighbors.Add(locations("PE BUILDING"))
                neighbors.Add(locations("MABINI MONUMENT"))
                neighbors.Add(locations("SWIMMING POOL"))
            Case "GYM"
                neighbors.Add(locations("TENNIS COURT"))
                neighbors.Add(locations("OUTDOOR COURT"))
                neighbors.Add(locations("VISITOR INFORMATION CENTER"))
                neighbors.Add(locations("SWIMMING POOL"))
            Case "TENNIS COURT"
                neighbors.Add(locations("OUTDOOR COURT"))
                neighbors.Add(locations("GYM"))
                neighbors.Add(locations("VISITOR INFORMATION CENTER"))
                neighbors.Add(locations("GAZEBO"))
            Case "UNDERGROUND TANK"
                neighbors.Add(locations("OVERHEAD TANK"))
                neighbors.Add(locations("WATER PUMP FACILITY"))
                neighbors.Add(locations("LABORATORY HS"))
                neighbors.Add(locations("CHARLIE DEL ROSARIO HALL"))
                neighbors.Add(locations("NINOY A. LIBRARY A"))
        End Select

        Return neighbors
    End Function

    Private Function CalculateTotalDistanceMeters(path As List(Of PointD)) As Double
        ' Calculate the total distance along the path in meters
        Dim totalDistanceMeters As Double = 0.0
        For i As Integer = 1 To path.Count - 1
            Dim previous As PointD = path(i - 1)
            Dim current As PointD = path(i)
            totalDistanceMeters += CalculateHaversineDistance(previous, current)
        Next
        Return totalDistanceMeters
    End Function

    Private Function CalculateEuclideanDistance(point1 As PointD, point2 As PointD) As Double
        ' Calculate the Euclidean distance between two points
        Dim deltaX As Double = point2.Longitude - point1.Longitude
        Dim deltaY As Double = point2.Latitude - point1.Latitude
        Return Math.Sqrt(deltaX * deltaX + deltaY * deltaY)
    End Function

    Private Sub txtresult_TextChanged(sender As Object, e As EventArgs) Handles txtresult.TextChanged

    End Sub

    Private Sub mapsp_Click(sender As Object, e As EventArgs) Handles mapsp.Click
        ' Check if the entbtn button has been clicked first
        If Not entBtnClicked Then
            MessageBox.Show("You should click Enter first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get the selected start and destination locations from ComboBoxes
        Dim startLocationName As String = DirectCast(startcb.SelectedItem, String)
        Dim destLocationName As String = DirectCast(destcb.SelectedItem, String)

        ' Check if the input matches any of the specific scenarios
        If (startLocationName = "MAIN GATE" AndAlso destLocationName = "SOUTH WING") OrElse
           (startLocationName = "MAIN GATE" AndAlso destLocationName = "AMPHITHEATRE") OrElse
           (startLocationName = "MAIN GATE" AndAlso destLocationName = "OUTDOOR COURT") Then

            ' Load Form4
            Dim form4 As New Form4()
            form4.Show()

            ' Set the image path in PictureBox1 of Form4 based on the destination location
            If destLocationName = "SOUTH WING" Then
                form4.PictureBox1.ImageLocation = "C:\Users\cabil\Downloads\daa_finals\daa_finals\DAAFINALS\Resources\SOUTHWING.png"
            ElseIf destLocationName = "AMPHITHEATRE" Then
                form4.PictureBox1.ImageLocation = "C:\Users\cabil\Downloads\daa_finals\daa_finals\DAAFINALS\Resources\AMPHITHEATRE.png"
            ElseIf destLocationName = "OUTDOOR COURT" Then
                form4.PictureBox1.ImageLocation = "C:\Users\cabil\Downloads\daa_finals\daa_finals\DAAFINALS\Resources\OUTDOORCOURT.png"
            End If
        Else
            ' Show an error message for other cases
            MessageBox.Show("Map not found", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    ' Code to draw the path on the map (pbMap) can be added here
    ' You may use GDI+ graphics to draw lines on the PictureBox
End Class

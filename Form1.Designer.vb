<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim puplogo As PictureBox
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        loclbl = New Label()
        destlbl = New Label()
        entbtn = New Button()
        rstbtn = New Button()
        closebtn = New Button()
        txtresult = New RichTextBox()
        startcb = New ComboBox()
        destcb = New ComboBox()
        hlpbtn = New Button()
        Label2 = New Label()
        mapbtn = New Button()
        ImageList1 = New ImageList(components)
        ImageList2 = New ImageList(components)
        mapsp = New Button()
        puplogo = New PictureBox()
        CType(puplogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' puplogo
        ' 
        puplogo.BackColor = Color.Transparent
        puplogo.BackgroundImage = CType(resources.GetObject("puplogo.BackgroundImage"), Image)
        puplogo.BackgroundImageLayout = ImageLayout.Zoom
        puplogo.Location = New Point(217, 42)
        puplogo.Name = "puplogo"
        puplogo.Size = New Size(156, 116)
        puplogo.SizeMode = PictureBoxSizeMode.CenterImage
        puplogo.TabIndex = 5
        puplogo.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Cooper Black", 72.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(226), CByte(184), CByte(8))
        Label1.Location = New Point(395, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(543, 110)
        Label1.TabIndex = 0
        Label1.Text = "PUPThere"
        ' 
        ' loclbl
        ' 
        loclbl.AutoSize = True
        loclbl.BackColor = Color.Transparent
        loclbl.FlatStyle = FlatStyle.Flat
        loclbl.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point)
        loclbl.ForeColor = Color.FromArgb(CByte(242), CByte(239), CByte(235))
        loclbl.Location = New Point(417, 209)
        loclbl.Name = "loclbl"
        loclbl.Size = New Size(274, 21)
        loclbl.TabIndex = 3
        loclbl.Text = "CHOOSE YOUR STARTING LOCATION"
        ' 
        ' destlbl
        ' 
        destlbl.AutoSize = True
        destlbl.BackColor = Color.Transparent
        destlbl.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point)
        destlbl.ForeColor = Color.FromArgb(CByte(242), CByte(239), CByte(235))
        destlbl.Location = New Point(417, 295)
        destlbl.Name = "destlbl"
        destlbl.Size = New Size(220, 21)
        destlbl.TabIndex = 4
        destlbl.Text = "CHOOSE YOUR DESTINATION"
        destlbl.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' entbtn
        ' 
        entbtn.BackColor = Color.FromArgb(CByte(226), CByte(184), CByte(8))
        entbtn.BackgroundImageLayout = ImageLayout.None
        entbtn.FlatAppearance.BorderSize = 0
        entbtn.FlatStyle = FlatStyle.Flat
        entbtn.Font = New Font("Corbel", 13F, FontStyle.Regular, GraphicsUnit.Point)
        entbtn.ForeColor = Color.White
        entbtn.Location = New Point(181, 242)
        entbtn.Name = "entbtn"
        entbtn.Size = New Size(139, 36)
        entbtn.TabIndex = 6
        entbtn.Text = "ENTER"
        entbtn.UseVisualStyleBackColor = False
        ' 
        ' rstbtn
        ' 
        rstbtn.BackColor = Color.FromArgb(CByte(226), CByte(184), CByte(8))
        rstbtn.BackgroundImageLayout = ImageLayout.None
        rstbtn.FlatAppearance.BorderSize = 0
        rstbtn.FlatStyle = FlatStyle.Flat
        rstbtn.Font = New Font("Corbel", 13F, FontStyle.Regular, GraphicsUnit.Point)
        rstbtn.ForeColor = Color.White
        rstbtn.Location = New Point(181, 312)
        rstbtn.Name = "rstbtn"
        rstbtn.Size = New Size(139, 36)
        rstbtn.TabIndex = 7
        rstbtn.Text = "RESET"
        rstbtn.UseVisualStyleBackColor = False
        ' 
        ' closebtn
        ' 
        closebtn.BackColor = Color.FromArgb(CByte(226), CByte(184), CByte(8))
        closebtn.BackgroundImageLayout = ImageLayout.None
        closebtn.FlatAppearance.BorderSize = 0
        closebtn.FlatStyle = FlatStyle.Flat
        closebtn.Font = New Font("Corbel", 13F, FontStyle.Regular, GraphicsUnit.Point)
        closebtn.ForeColor = Color.White
        closebtn.Location = New Point(181, 532)
        closebtn.Name = "closebtn"
        closebtn.Size = New Size(139, 36)
        closebtn.TabIndex = 8
        closebtn.Text = "EXIT"
        closebtn.UseVisualStyleBackColor = False
        ' 
        ' txtresult
        ' 
        txtresult.BackColor = SystemColors.ScrollBar
        txtresult.BorderStyle = BorderStyle.None
        txtresult.Font = New Font("Microsoft PhagsPa", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtresult.Location = New Point(417, 394)
        txtresult.Name = "txtresult"
        txtresult.Size = New Size(620, 174)
        txtresult.TabIndex = 9
        txtresult.Text = ""
        ' 
        ' startcb
        ' 
        startcb.BackColor = Color.Gainsboro
        startcb.Font = New Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        startcb.FormattingEnabled = True
        startcb.Items.AddRange(New Object() {"MAIN GATE", "VISITOR INFORMATION CENTER", "TENNIS COURT", "OUTDOOR COURT", "GYM", "SWIMMING POOL", "GAZEBO", "MABINI MONUMENT", "MABINI SHRINE", "PUP SOUVENIR", "FREEDOM PARK", "FLAGPOLE", "GRANDSTAND", "COMMUNITY BUILDING", "OVAL", "NORTH WING", "CHAPEL", "NUTRITION AND FOOD SCIENCE BUILDING", "EAST WING", "CAMPUS DEVELOPMENT AND MAINTENANCE BUILDING", "PUP STA. MESA FERRY", "GENERATOR FACILITY", "SOUTH WING", "WEST WING", "MAIN BUILDING", "CANTEEN SAMPAGUITA BLDG", "STUDENT CANTEEN", "CHARLIE DEL ROSARIO HALL", "LABORATORY HS", "PRINTING PRESS BLDG", "PROPERTY BLDG", "WATER PUMP FACILITY", "UNDERGROUND TANK", "OVERHEAD TANK", "NINOY A. LIBRARY", "LAGOON", "AMPHITHEATRE", "PE BUILDING", "TAHANAN NG ALUMNI"})
        startcb.Location = New Point(417, 243)
        startcb.Name = "startcb"
        startcb.Size = New Size(620, 33)
        startcb.TabIndex = 10
        startcb.Text = "--SELECT--"
        ' 
        ' destcb
        ' 
        destcb.BackColor = Color.Gainsboro
        destcb.Font = New Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        destcb.FormattingEnabled = True
        destcb.Items.AddRange(New Object() {"MAIN GATE", "VISITOR INFORMATION CENTER", "TENNIS COURT", "OUTDOOR COURT", "GYM", "SWIMMING POOL", "GAZEBO", "MABINI MONUMENT", "MABINI SHRINE", "PUP SOUVENIR", "FREEDOM PARK", "FLAGPOLE", "GRANDSTAND", "COMMUNITY BUILDING", "OVAL", "NORTH WING", "CHAPEL", "NUTRITION AND FOOD SCIENCE BUILDING", "EAST WING", "CAMPUS DEVELOPMENT AND MAINTENANCE BUILDING", "PUP STA. MESA FERRY", "GENERATOR FACILITY", "SOUTH WING", "WEST WING", "MAIN BUILDING", "CANTEEN SAMPAGUITA BLDG", "STUDENT CANTEEN", "CHARLIE DEL ROSARIO HALL", "LABORATORY HS", "PRINTING PRESS BLDG", "PROPERTY BLDG", "WATER PUMP FACILITY", "UNDERGROUND TANK", "OVERHEAD TANK", "NINOY A. LIBRARY", "LAGOON", "AMPHITHEATRE", "PE BUILDING", "TAHANAN NG ALUMNI"})
        destcb.Location = New Point(417, 331)
        destcb.Name = "destcb"
        destcb.Size = New Size(620, 33)
        destcb.TabIndex = 11
        destcb.Text = "--SELECT--"
        ' 
        ' hlpbtn
        ' 
        hlpbtn.BackColor = Color.FromArgb(CByte(226), CByte(184), CByte(8))
        hlpbtn.BackgroundImageLayout = ImageLayout.None
        hlpbtn.FlatAppearance.BorderSize = 0
        hlpbtn.FlatStyle = FlatStyle.Flat
        hlpbtn.Font = New Font("Corbel", 13F, FontStyle.Regular, GraphicsUnit.Point)
        hlpbtn.ForeColor = Color.White
        hlpbtn.Location = New Point(181, 462)
        hlpbtn.Name = "hlpbtn"
        hlpbtn.Size = New Size(139, 36)
        hlpbtn.TabIndex = 12
        hlpbtn.Text = "HELP"
        hlpbtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(242), CByte(239), CByte(235))
        Label2.Location = New Point(678, 370)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 21)
        Label2.TabIndex = 13
        Label2.Text = "RESULT"
        Label2.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' mapbtn
        ' 
        mapbtn.BackColor = Color.FromArgb(CByte(226), CByte(184), CByte(8))
        mapbtn.BackgroundImageLayout = ImageLayout.None
        mapbtn.FlatAppearance.BorderSize = 0
        mapbtn.FlatStyle = FlatStyle.Flat
        mapbtn.Font = New Font("Corbel", 13F, FontStyle.Regular, GraphicsUnit.Point)
        mapbtn.ForeColor = Color.White
        mapbtn.Location = New Point(181, 387)
        mapbtn.Name = "mapbtn"
        mapbtn.Size = New Size(139, 36)
        mapbtn.TabIndex = 14
        mapbtn.Text = "MAP"
        mapbtn.UseVisualStyleBackColor = False
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth8Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' ImageList2
        ' 
        ImageList2.ColorDepth = ColorDepth.Depth8Bit
        ImageList2.ImageSize = New Size(16, 16)
        ImageList2.TransparentColor = Color.Transparent
        ' 
        ' mapsp
        ' 
        mapsp.BackColor = Color.FromArgb(CByte(226), CByte(184), CByte(8))
        mapsp.BackgroundImageLayout = ImageLayout.None
        mapsp.FlatAppearance.BorderSize = 0
        mapsp.FlatStyle = FlatStyle.Flat
        mapsp.Font = New Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point)
        mapsp.ForeColor = Color.White
        mapsp.Location = New Point(609, 585)
        mapsp.Name = "mapsp"
        mapsp.Size = New Size(215, 36)
        mapsp.TabIndex = 15
        mapsp.Text = "Map with the Shortest Path"
        mapsp.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(1), CByte(1))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1207, 710)
        Controls.Add(mapsp)
        Controls.Add(mapbtn)
        Controls.Add(loclbl)
        Controls.Add(Label2)
        Controls.Add(hlpbtn)
        Controls.Add(destcb)
        Controls.Add(startcb)
        Controls.Add(txtresult)
        Controls.Add(closebtn)
        Controls.Add(rstbtn)
        Controls.Add(entbtn)
        Controls.Add(puplogo)
        Controls.Add(destlbl)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PUP NAVIGATION SYSTEM"
        CType(puplogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents loclbl As Label
    Friend WithEvents destlbl As Label
    Friend WithEvents puplogo As PictureBox
    Friend WithEvents entbtn As Button
    Friend WithEvents rstbtn As Button
    Friend WithEvents closebtn As Button
    Friend WithEvents txtresult As RichTextBox
    Friend WithEvents startcb As ComboBox
    Friend WithEvents destcb As ComboBox
    Friend WithEvents hlpbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents mapbtn As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents mapsp As Button
End Class

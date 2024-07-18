<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim puplogo As PictureBox
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        backbtn = New Button()
        HelpProvider1 = New HelpProvider()
        Label1 = New Label()
        wordcbox = New ComboBox()
        loclbl = New Label()
        meaning = New RichTextBox()
        puplogo = New PictureBox()
        CType(puplogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' puplogo
        ' 
        puplogo.BackgroundImage = CType(resources.GetObject("puplogo.BackgroundImage"), Image)
        puplogo.BackgroundImageLayout = ImageLayout.Zoom
        puplogo.Location = New Point(12, 12)
        puplogo.Name = "puplogo"
        puplogo.Size = New Size(156, 116)
        puplogo.SizeMode = PictureBoxSizeMode.CenterImage
        puplogo.TabIndex = 12
        puplogo.TabStop = False
        ' 
        ' backbtn
        ' 
        backbtn.BackColor = Color.FromArgb(CByte(226), CByte(184), CByte(8))
        backbtn.BackgroundImageLayout = ImageLayout.None
        backbtn.FlatAppearance.BorderSize = 0
        backbtn.FlatStyle = FlatStyle.Flat
        backbtn.Font = New Font("Corbel", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        backbtn.ForeColor = Color.White
        backbtn.ImageAlign = ContentAlignment.TopCenter
        backbtn.Location = New Point(202, 617)
        backbtn.Name = "backbtn"
        backbtn.Size = New Size(140, 52)
        backbtn.TabIndex = 9
        backbtn.Text = "BACK"
        backbtn.TextAlign = ContentAlignment.TopCenter
        backbtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(128), CByte(1), CByte(1))
        Label1.Font = New Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(226), CByte(184), CByte(8))
        Label1.Location = New Point(174, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(362, 74)
        Label1.TabIndex = 11
        Label1.Text = "PUPThere"
        ' 
        ' wordcbox
        ' 
        wordcbox.BackColor = Color.Gainsboro
        wordcbox.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point)
        wordcbox.FormattingEnabled = True
        wordcbox.Items.AddRange(New Object() {"SYSTEM INFORMATION", "ENTER BUTTON", "RESET BUTTON", "MAP BUTTON", "HELP BUTTON", "EXIT BUTTON"})
        wordcbox.Location = New Point(59, 184)
        wordcbox.Name = "wordcbox"
        wordcbox.Size = New Size(458, 29)
        wordcbox.TabIndex = 13
        wordcbox.Text = "--SELECT--"
        ' 
        ' loclbl
        ' 
        loclbl.AutoSize = True
        loclbl.BackColor = Color.Transparent
        loclbl.FlatStyle = FlatStyle.Flat
        loclbl.Font = New Font("Microsoft PhagsPa", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        loclbl.ForeColor = Color.FromArgb(CByte(242), CByte(239), CByte(235))
        loclbl.Location = New Point(59, 157)
        loclbl.Name = "loclbl"
        loclbl.Size = New Size(210, 24)
        loclbl.TabIndex = 14
        loclbl.Text = "HOW MAY I HELP YOU?"
        ' 
        ' meaning
        ' 
        meaning.BackColor = Color.Gainsboro
        meaning.BorderStyle = BorderStyle.None
        meaning.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point)
        meaning.Location = New Point(59, 231)
        meaning.Name = "meaning"
        meaning.Size = New Size(458, 370)
        meaning.TabIndex = 15
        meaning.Text = ""
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(1), CByte(1))
        ClientSize = New Size(572, 681)
        Controls.Add(meaning)
        Controls.Add(loclbl)
        Controls.Add(wordcbox)
        Controls.Add(Label1)
        Controls.Add(puplogo)
        Controls.Add(backbtn)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "HELP"
        CType(puplogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents backbtn As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents wordcbox As ComboBox
    Friend WithEvents loclbl As Label
    Friend WithEvents meaning As RichTextBox
End Class

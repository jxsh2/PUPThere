<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        PictureBox1 = New PictureBox()
        back = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1138, 682)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' back
        ' 
        back.BackColor = Color.FromArgb(CByte(226), CByte(184), CByte(8))
        back.BackgroundImageLayout = ImageLayout.None
        back.FlatAppearance.BorderSize = 0
        back.FlatStyle = FlatStyle.Flat
        back.Font = New Font("Corbel", 13F, FontStyle.Regular, GraphicsUnit.Point)
        back.ForeColor = Color.White
        back.Location = New Point(24, 21)
        back.Name = "back"
        back.Size = New Size(139, 36)
        back.TabIndex = 9
        back.Text = "BACK"
        back.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1168, 709)
        Controls.Add(back)
        Controls.Add(PictureBox1)
        Name = "Form4"
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents back As Button
End Class

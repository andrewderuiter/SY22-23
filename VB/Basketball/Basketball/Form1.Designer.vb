<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Basketball = New System.Windows.Forms.Button()
        Me.displayPicturebox = New System.Windows.Forms.PictureBox()
        Me.BasketballPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.statsLabel = New System.Windows.Forms.Label()
        Me.rankingLabel = New System.Windows.Forms.Label()
        Me.placeLabel = New System.Windows.Forms.Label()
        CType(Me.displayPicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasketballPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Basketball
        '
        Me.Basketball.Location = New System.Drawing.Point(113, 239)
        Me.Basketball.Name = "Basketball"
        Me.Basketball.Size = New System.Drawing.Size(99, 23)
        Me.Basketball.TabIndex = 0
        Me.Basketball.Text = "Basketball"
        Me.Basketball.UseVisualStyleBackColor = True
        '
        'displayPicturebox
        '
        Me.displayPicturebox.Location = New System.Drawing.Point(12, -1)
        Me.displayPicturebox.Name = "displayPicturebox"
        Me.displayPicturebox.Size = New System.Drawing.Size(310, 213)
        Me.displayPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displayPicturebox.TabIndex = 1
        Me.displayPicturebox.TabStop = False
        '
        'BasketballPictureBox
        '
        Me.BasketballPictureBox.Image = Global.Basketball.My.Resources.Resources.images__3_
        Me.BasketballPictureBox.Location = New System.Drawing.Point(84, 311)
        Me.BasketballPictureBox.Name = "BasketballPictureBox"
        Me.BasketballPictureBox.Size = New System.Drawing.Size(100, 50)
        Me.BasketballPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BasketballPictureBox.TabIndex = 2
        Me.BasketballPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(338, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Team name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Stats"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(341, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ranking"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(341, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Where they play"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(509, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = " "
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(455, 13)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(10, 16)
        Me.nameLabel.TabIndex = 8
        Me.nameLabel.Text = " "
        '
        'statsLabel
        '
        Me.statsLabel.AutoSize = True
        Me.statsLabel.Location = New System.Drawing.Point(455, 42)
        Me.statsLabel.Name = "statsLabel"
        Me.statsLabel.Size = New System.Drawing.Size(10, 16)
        Me.statsLabel.TabIndex = 9
        Me.statsLabel.Text = " "
        '
        'rankingLabel
        '
        Me.rankingLabel.AutoSize = True
        Me.rankingLabel.Location = New System.Drawing.Point(455, 71)
        Me.rankingLabel.Name = "rankingLabel"
        Me.rankingLabel.Size = New System.Drawing.Size(10, 16)
        Me.rankingLabel.TabIndex = 10
        Me.rankingLabel.Text = " "
        '
        'placeLabel
        '
        Me.placeLabel.AutoSize = True
        Me.placeLabel.Location = New System.Drawing.Point(455, 103)
        Me.placeLabel.Name = "placeLabel"
        Me.placeLabel.Size = New System.Drawing.Size(10, 16)
        Me.placeLabel.TabIndex = 11
        Me.placeLabel.Text = " "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.placeLabel)
        Me.Controls.Add(Me.rankingLabel)
        Me.Controls.Add(Me.statsLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BasketballPictureBox)
        Me.Controls.Add(Me.displayPicturebox)
        Me.Controls.Add(Me.Basketball)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.displayPicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasketballPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Basketball As Button
    Friend WithEvents displayPicturebox As PictureBox
    Friend WithEvents BasketballPictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents statsLabel As Label
    Friend WithEvents rankingLabel As Label
    Friend WithEvents placeLabel As Label
End Class

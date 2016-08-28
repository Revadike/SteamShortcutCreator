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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.cbSteamLink = New System.Windows.Forms.CheckBox()
        Me.cbGameExe = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbOutput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbGames = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnInvert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(25, 258)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(228, 66)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Create"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'cbSteamLink
        '
        Me.cbSteamLink.AutoSize = True
        Me.cbSteamLink.Location = New System.Drawing.Point(25, 96)
        Me.cbSteamLink.Name = "cbSteamLink"
        Me.cbSteamLink.Size = New System.Drawing.Size(75, 17)
        Me.cbSteamLink.TabIndex = 1
        Me.cbSteamLink.Text = "Steam link"
        Me.cbSteamLink.UseVisualStyleBackColor = True
        '
        'cbGameExe
        '
        Me.cbGameExe.AutoSize = True
        Me.cbGameExe.Checked = True
        Me.cbGameExe.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbGameExe.Location = New System.Drawing.Point(25, 80)
        Me.cbGameExe.Name = "cbGameExe"
        Me.cbGameExe.Size = New System.Drawing.Size(74, 17)
        Me.cbGameExe.TabIndex = 2
        Me.cbGameExe.Text = "Game exe"
        Me.cbGameExe.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MODE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "OUTPUT"
        '
        'tbOutput
        '
        Me.tbOutput.Location = New System.Drawing.Point(25, 222)
        Me.tbOutput.Name = "tbOutput"
        Me.tbOutput.Size = New System.Drawing.Size(228, 20)
        Me.tbOutput.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "STEAM SHORTCUT CREATOR"
        '
        'lbGames
        '
        Me.lbGames.FormattingEnabled = True
        Me.lbGames.Location = New System.Drawing.Point(133, 80)
        Me.lbGames.Name = "lbGames"
        Me.lbGames.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbGames.Size = New System.Drawing.Size(120, 82)
        Me.lbGames.Sorted = True
        Me.lbGames.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(130, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "INSTALLED GAMES"
        '
        'btnInvert
        '
        Me.btnInvert.Location = New System.Drawing.Point(133, 168)
        Me.btnInvert.Name = "btnInvert"
        Me.btnInvert.Size = New System.Drawing.Size(119, 23)
        Me.btnInvert.TabIndex = 9
        Me.btnInvert.Text = "Invert selection"
        Me.btnInvert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 343)
        Me.Controls.Add(Me.btnInvert)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbGames)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbOutput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbGameExe)
        Me.Controls.Add(Me.cbSteamLink)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "Form1"
        Me.Text = "Steam Shortcut Creator by Royalgamer06"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents cbSteamLink As CheckBox
    Friend WithEvents cbGameExe As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbOutput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbGames As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnInvert As Button
End Class

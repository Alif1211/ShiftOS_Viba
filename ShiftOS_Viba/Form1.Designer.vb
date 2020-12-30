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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CampaignButton = New System.Windows.Forms.Button()
        Me.SandboxButton = New System.Windows.Forms.Button()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.marqueetimer = New System.Windows.Forms.Timer(Me.components)
        Me.CampaignPanel = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ContinueButton = New System.Windows.Forms.Button()
        Me.NewGameButton = New System.Windows.Forms.Button()
        Me.CampaignPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(142, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ShiftOS Viba Edition"
        '
        'CampaignButton
        '
        Me.CampaignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CampaignButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CampaignButton.Location = New System.Drawing.Point(230, 146)
        Me.CampaignButton.Name = "CampaignButton"
        Me.CampaignButton.Size = New System.Drawing.Size(180, 30)
        Me.CampaignButton.TabIndex = 1
        Me.CampaignButton.Text = "Campaign"
        Me.CampaignButton.UseVisualStyleBackColor = True
        '
        'SandboxButton
        '
        Me.SandboxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SandboxButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SandboxButton.Location = New System.Drawing.Point(230, 182)
        Me.SandboxButton.Name = "SandboxButton"
        Me.SandboxButton.Size = New System.Drawing.Size(180, 30)
        Me.SandboxButton.TabIndex = 2
        Me.SandboxButton.Text = "Sandbox"
        Me.SandboxButton.UseVisualStyleBackColor = True
        '
        'SettingsButton
        '
        Me.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingsButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsButton.Location = New System.Drawing.Point(230, 218)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(180, 30)
        Me.SettingsButton.TabIndex = 3
        Me.SettingsButton.Text = "Settings"
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'AboutButton
        '
        Me.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AboutButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutButton.Location = New System.Drawing.Point(230, 254)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(180, 30)
        Me.AboutButton.TabIndex = 4
        Me.AboutButton.Text = "About"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(230, 290)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(180, 30)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(484, 419)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 30)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "marquee text"
        '
        'marqueetimer
        '
        '
        'CampaignPanel
        '
        Me.CampaignPanel.Controls.Add(Me.BackButton)
        Me.CampaignPanel.Controls.Add(Me.ContinueButton)
        Me.CampaignPanel.Controls.Add(Me.NewGameButton)
        Me.CampaignPanel.Location = New System.Drawing.Point(12, 207)
        Me.CampaignPanel.Name = "CampaignPanel"
        Me.CampaignPanel.Size = New System.Drawing.Size(248, 232)
        Me.CampaignPanel.TabIndex = 7
        Me.CampaignPanel.Visible = False
        '
        'BackButton
        '
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(34, 134)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(180, 30)
        Me.BackButton.TabIndex = 10
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ContinueButton
        '
        Me.ContinueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContinueButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContinueButton.Location = New System.Drawing.Point(34, 96)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(180, 30)
        Me.ContinueButton.TabIndex = 9
        Me.ContinueButton.Text = "Continue"
        Me.ContinueButton.UseVisualStyleBackColor = True
        '
        'NewGameButton
        '
        Me.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewGameButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewGameButton.Location = New System.Drawing.Point(34, 59)
        Me.NewGameButton.Name = "NewGameButton"
        Me.NewGameButton.Size = New System.Drawing.Size(180, 30)
        Me.NewGameButton.TabIndex = 8
        Me.NewGameButton.Text = "New Game"
        Me.NewGameButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(634, 451)
        Me.Controls.Add(Me.CampaignPanel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.SandboxButton)
        Me.Controls.Add(Me.CampaignButton)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.CampaignPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CampaignButton As Button
    Friend WithEvents SandboxButton As Button
    Friend WithEvents SettingsButton As Button
    Friend WithEvents AboutButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents marqueetimer As Timer
    Friend WithEvents CampaignPanel As Panel
    Friend WithEvents NewGameButton As Button
    Friend WithEvents ContinueButton As Button
    Friend WithEvents BackButton As Button
End Class

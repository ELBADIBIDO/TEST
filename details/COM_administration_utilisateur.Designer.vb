<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class com_administration_utilisateur
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_quiter = New System.Windows.Forms.Button()
        Me.Btn_Enregistrer = New System.Windows.Forms.Button()
        Me.GroupBox_affichage = New System.Windows.Forms.GroupBox()
        Me.lab_confirmer2 = New System.Windows.Forms.Label()
        Me.txt_confirmer = New System.Windows.Forms.TextBox()
        Me.txt_pwd = New System.Windows.Forms.TextBox()
        Me.Txt_nom = New System.Windows.Forms.TextBox()
        Me.lab_confirmer1 = New System.Windows.Forms.Label()
        Me.Lab_Inti = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_Ajouter = New System.Windows.Forms.Button()
        Me.btn_retirer = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txt_pwd_confirmer_user = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nom_user = New System.Windows.Forms.TextBox()
        Me.txt_pwd_user = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox_affichage.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(10, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(862, 425)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightGray
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox_affichage)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(854, 394)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Administrateur"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox3.Controls.Add(Me.Btn_quiter)
        Me.GroupBox3.Controls.Add(Me.Btn_Enregistrer)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(47, 248)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(801, 118)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'Btn_quiter
        '
        Me.Btn_quiter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Btn_quiter.Location = New System.Drawing.Point(515, 35)
        Me.Btn_quiter.Name = "Btn_quiter"
        Me.Btn_quiter.Size = New System.Drawing.Size(256, 64)
        Me.Btn_quiter.TabIndex = 17
        Me.Btn_quiter.Text = "Quitter"
        Me.Btn_quiter.UseVisualStyleBackColor = True
        '
        'Btn_Enregistrer
        '
        Me.Btn_Enregistrer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_Enregistrer.Enabled = False
        Me.Btn_Enregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Btn_Enregistrer.Location = New System.Drawing.Point(47, 35)
        Me.Btn_Enregistrer.Name = "Btn_Enregistrer"
        Me.Btn_Enregistrer.Size = New System.Drawing.Size(256, 64)
        Me.Btn_Enregistrer.TabIndex = 6
        Me.Btn_Enregistrer.Text = "Enregistrer"
        Me.Btn_Enregistrer.UseVisualStyleBackColor = False
        '
        'GroupBox_affichage
        '
        Me.GroupBox_affichage.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox_affichage.Controls.Add(Me.lab_confirmer2)
        Me.GroupBox_affichage.Controls.Add(Me.txt_confirmer)
        Me.GroupBox_affichage.Controls.Add(Me.txt_pwd)
        Me.GroupBox_affichage.Controls.Add(Me.Txt_nom)
        Me.GroupBox_affichage.Controls.Add(Me.lab_confirmer1)
        Me.GroupBox_affichage.Controls.Add(Me.Lab_Inti)
        Me.GroupBox_affichage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_affichage.Location = New System.Drawing.Point(47, 21)
        Me.GroupBox_affichage.Name = "GroupBox_affichage"
        Me.GroupBox_affichage.Size = New System.Drawing.Size(801, 207)
        Me.GroupBox_affichage.TabIndex = 1
        Me.GroupBox_affichage.TabStop = False
        '
        'lab_confirmer2
        '
        Me.lab_confirmer2.AutoSize = True
        Me.lab_confirmer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_confirmer2.Location = New System.Drawing.Point(415, 122)
        Me.lab_confirmer2.Name = "lab_confirmer2"
        Me.lab_confirmer2.Size = New System.Drawing.Size(183, 18)
        Me.lab_confirmer2.TabIndex = 10
        Me.lab_confirmer2.Text = "Confirmer le mot de passe"
        '
        'txt_confirmer
        '
        Me.txt_confirmer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_confirmer.Enabled = False
        Me.txt_confirmer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirmer.Location = New System.Drawing.Point(597, 121)
        Me.txt_confirmer.MaxLength = 10
        Me.txt_confirmer.Name = "txt_confirmer"
        Me.txt_confirmer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirmer.Size = New System.Drawing.Size(134, 22)
        Me.txt_confirmer.TabIndex = 2
        '
        'txt_pwd
        '
        Me.txt_pwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_pwd.Enabled = False
        Me.txt_pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pwd.Location = New System.Drawing.Point(232, 119)
        Me.txt_pwd.MaxLength = 10
        Me.txt_pwd.Name = "txt_pwd"
        Me.txt_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pwd.Size = New System.Drawing.Size(134, 22)
        Me.txt_pwd.TabIndex = 1
        '
        'Txt_nom
        '
        Me.Txt_nom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_nom.Enabled = False
        Me.Txt_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_nom.Location = New System.Drawing.Point(232, 57)
        Me.Txt_nom.MaxLength = 30
        Me.Txt_nom.Name = "Txt_nom"
        Me.Txt_nom.Size = New System.Drawing.Size(241, 22)
        Me.Txt_nom.TabIndex = 0
        '
        'lab_confirmer1
        '
        Me.lab_confirmer1.AutoSize = True
        Me.lab_confirmer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_confirmer1.Location = New System.Drawing.Point(53, 122)
        Me.lab_confirmer1.Name = "lab_confirmer1"
        Me.lab_confirmer1.Size = New System.Drawing.Size(195, 18)
        Me.lab_confirmer1.TabIndex = 7
        Me.lab_confirmer1.Text = "Mot de passe administrateur"
        '
        'Lab_Inti
        '
        Me.Lab_Inti.AutoSize = True
        Me.Lab_Inti.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Inti.Location = New System.Drawing.Point(186, 57)
        Me.Lab_Inti.Name = "Lab_Inti"
        Me.Lab_Inti.Size = New System.Drawing.Size(41, 18)
        Me.Lab_Inti.TabIndex = 6
        Me.Lab_Inti.Text = "Nom"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightGray
        Me.TabPage2.Controls.Add(Me.btn_Ajouter)
        Me.TabPage2.Controls.Add(Me.btn_retirer)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(854, 394)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Utilisateurs"
        '
        'btn_Ajouter
        '
        Me.btn_Ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btn_Ajouter.Location = New System.Drawing.Point(507, 206)
        Me.btn_Ajouter.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Ajouter.Name = "btn_Ajouter"
        Me.btn_Ajouter.Size = New System.Drawing.Size(177, 36)
        Me.btn_Ajouter.TabIndex = 3
        Me.btn_Ajouter.Text = "Ajouter"
        Me.btn_Ajouter.UseVisualStyleBackColor = True
        '
        'btn_retirer
        '
        Me.btn_retirer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btn_retirer.Location = New System.Drawing.Point(166, 206)
        Me.btn_retirer.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_retirer.Name = "btn_retirer"
        Me.btn_retirer.Size = New System.Drawing.Size(177, 36)
        Me.btn_retirer.TabIndex = 2
        Me.btn_retirer.Text = "Retirer"
        Me.btn_retirer.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txt_pwd_confirmer_user)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.txt_nom_user)
        Me.GroupBox6.Controls.Add(Me.txt_pwd_user)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 5)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Size = New System.Drawing.Size(815, 190)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Identification utilisateur"
        '
        'txt_pwd_confirmer_user
        '
        Me.txt_pwd_confirmer_user.Location = New System.Drawing.Point(590, 121)
        Me.txt_pwd_confirmer_user.MaxLength = 10
        Me.txt_pwd_confirmer_user.Name = "txt_pwd_confirmer_user"
        Me.txt_pwd_confirmer_user.Size = New System.Drawing.Size(165, 24)
        Me.txt_pwd_confirmer_user.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(383, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Confirmer le Mot de passe"
        '
        'txt_nom_user
        '
        Me.txt_nom_user.Location = New System.Drawing.Point(327, 38)
        Me.txt_nom_user.MaxLength = 30
        Me.txt_nom_user.Name = "txt_nom_user"
        Me.txt_nom_user.Size = New System.Drawing.Size(218, 24)
        Me.txt_nom_user.TabIndex = 0
        '
        'txt_pwd_user
        '
        Me.txt_pwd_user.Location = New System.Drawing.Point(131, 121)
        Me.txt_pwd_user.MaxLength = 10
        Me.txt_pwd_user.Name = "txt_pwd_user"
        Me.txt_pwd_user.Size = New System.Drawing.Size(143, 24)
        Me.txt_pwd_user.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label7.Location = New System.Drawing.Point(28, 124)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Mot de passe"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label6.Location = New System.Drawing.Point(191, 40)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nom de l'utilisateur"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView2)
        Me.GroupBox5.Location = New System.Drawing.Point(17, 247)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(815, 137)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Utilisateurs"
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(18, 26)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(764, 97)
        Me.DataGridView2.TabIndex = 0
        '
        'com_administration_utilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(884, 442)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "com_administration_utilisateur"
        Me.Text = "Administration des utilisateurs"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox_affichage.ResumeLayout(False)
        Me.GroupBox_affichage.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_quiter As System.Windows.Forms.Button
    Friend WithEvents Btn_Enregistrer As System.Windows.Forms.Button
    Friend WithEvents GroupBox_affichage As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_nom As System.Windows.Forms.TextBox
    Friend WithEvents lab_confirmer1 As System.Windows.Forms.Label
    Friend WithEvents Lab_Inti As System.Windows.Forms.Label
    Friend WithEvents txt_pwd As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Ajouter As System.Windows.Forms.Button
    Friend WithEvents btn_retirer As System.Windows.Forms.Button
    Friend WithEvents txt_pwd_user As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_nom_user As System.Windows.Forms.TextBox
    Friend WithEvents lab_confirmer2 As System.Windows.Forms.Label
    Friend WithEvents txt_confirmer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_pwd_confirmer_user As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

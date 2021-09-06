<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COM_modifier_mot_passe
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
        Me.GBox_btn = New System.Windows.Forms.GroupBox()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.Btn_quiter = New System.Windows.Forms.Button()
        Me.Btn_Enregistrer = New System.Windows.Forms.Button()
        Me.GBox_cle = New System.Windows.Forms.GroupBox()
        Me.txt_anc_pwd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_user = New System.Windows.Forms.ComboBox()
        Me.Lab_Inti = New System.Windows.Forms.Label()
        Me.gbox_affichage = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_conf_pwd = New System.Windows.Forms.TextBox()
        Me.txt_nouv_pwd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GBox_btn.SuspendLayout()
        Me.GBox_cle.SuspendLayout()
        Me.gbox_affichage.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBox_btn
        '
        Me.GBox_btn.BackColor = System.Drawing.Color.LightGray
        Me.GBox_btn.Controls.Add(Me.btn_annuler)
        Me.GBox_btn.Controls.Add(Me.Btn_quiter)
        Me.GBox_btn.Controls.Add(Me.Btn_Enregistrer)
        Me.GBox_btn.Font = New System.Drawing.Font("Franklin Gothic Heavy", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBox_btn.Location = New System.Drawing.Point(42, 312)
        Me.GBox_btn.Name = "GBox_btn"
        Me.GBox_btn.Size = New System.Drawing.Size(801, 118)
        Me.GBox_btn.TabIndex = 2
        Me.GBox_btn.TabStop = False
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_annuler.Enabled = False
        Me.btn_annuler.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!)
        Me.btn_annuler.Location = New System.Drawing.Point(322, 35)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(192, 64)
        Me.btn_annuler.TabIndex = 1
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'Btn_quiter
        '
        Me.Btn_quiter.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!)
        Me.Btn_quiter.Location = New System.Drawing.Point(579, 35)
        Me.Btn_quiter.Name = "Btn_quiter"
        Me.Btn_quiter.Size = New System.Drawing.Size(192, 64)
        Me.Btn_quiter.TabIndex = 2
        Me.Btn_quiter.Text = "Quitter"
        Me.Btn_quiter.UseVisualStyleBackColor = True
        '
        'Btn_Enregistrer
        '
        Me.Btn_Enregistrer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_Enregistrer.Enabled = False
        Me.Btn_Enregistrer.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!)
        Me.Btn_Enregistrer.Location = New System.Drawing.Point(60, 35)
        Me.Btn_Enregistrer.Name = "Btn_Enregistrer"
        Me.Btn_Enregistrer.Size = New System.Drawing.Size(192, 64)
        Me.Btn_Enregistrer.TabIndex = 0
        Me.Btn_Enregistrer.Text = "Enregistrer"
        Me.Btn_Enregistrer.UseVisualStyleBackColor = False
        '
        'GBox_cle
        '
        Me.GBox_cle.BackColor = System.Drawing.Color.LightGray
        Me.GBox_cle.Controls.Add(Me.txt_anc_pwd)
        Me.GBox_cle.Controls.Add(Me.Label2)
        Me.GBox_cle.Controls.Add(Me.cbx_user)
        Me.GBox_cle.Controls.Add(Me.Lab_Inti)
        Me.GBox_cle.Font = New System.Drawing.Font("Franklin Gothic Heavy", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBox_cle.Location = New System.Drawing.Point(42, 12)
        Me.GBox_cle.Name = "GBox_cle"
        Me.GBox_cle.Size = New System.Drawing.Size(801, 105)
        Me.GBox_cle.TabIndex = 0
        Me.GBox_cle.TabStop = False
        '
        'txt_anc_pwd
        '
        Me.txt_anc_pwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_anc_pwd.Enabled = False
        Me.txt_anc_pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_anc_pwd.Location = New System.Drawing.Point(616, 43)
        Me.txt_anc_pwd.MaxLength = 10
        Me.txt_anc_pwd.Name = "txt_anc_pwd"
        Me.txt_anc_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_anc_pwd.Size = New System.Drawing.Size(134, 22)
        Me.txt_anc_pwd.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(404, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Ancien mot de passe "
        '
        'cbx_user
        '
        Me.cbx_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_user.FormattingEnabled = True
        Me.cbx_user.Location = New System.Drawing.Point(115, 41)
        Me.cbx_user.Name = "cbx_user"
        Me.cbx_user.Size = New System.Drawing.Size(202, 28)
        Me.cbx_user.TabIndex = 11
        '
        'Lab_Inti
        '
        Me.Lab_Inti.AutoSize = True
        Me.Lab_Inti.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Inti.Location = New System.Drawing.Point(42, 44)
        Me.Lab_Inti.Name = "Lab_Inti"
        Me.Lab_Inti.Size = New System.Drawing.Size(34, 20)
        Me.Lab_Inti.TabIndex = 6
        Me.Lab_Inti.Text = "Nom"
        '
        'gbox_affichage
        '
        Me.gbox_affichage.BackColor = System.Drawing.Color.LightGray
        Me.gbox_affichage.Controls.Add(Me.Label4)
        Me.gbox_affichage.Controls.Add(Me.txt_conf_pwd)
        Me.gbox_affichage.Controls.Add(Me.txt_nouv_pwd)
        Me.gbox_affichage.Controls.Add(Me.Label5)
        Me.gbox_affichage.Font = New System.Drawing.Font("Franklin Gothic Heavy", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbox_affichage.Location = New System.Drawing.Point(42, 155)
        Me.gbox_affichage.Name = "gbox_affichage"
        Me.gbox_affichage.Size = New System.Drawing.Size(801, 105)
        Me.gbox_affichage.TabIndex = 1
        Me.gbox_affichage.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(372, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Confirmer le nouveau mot de passe"
        '
        'txt_conf_pwd
        '
        Me.txt_conf_pwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_conf_pwd.Enabled = False
        Me.txt_conf_pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_conf_pwd.Location = New System.Drawing.Point(615, 43)
        Me.txt_conf_pwd.MaxLength = 10
        Me.txt_conf_pwd.Name = "txt_conf_pwd"
        Me.txt_conf_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_conf_pwd.Size = New System.Drawing.Size(134, 22)
        Me.txt_conf_pwd.TabIndex = 2
        '
        'txt_nouv_pwd
        '
        Me.txt_nouv_pwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nouv_pwd.Enabled = False
        Me.txt_nouv_pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nouv_pwd.Location = New System.Drawing.Point(216, 44)
        Me.txt_nouv_pwd.MaxLength = 10
        Me.txt_nouv_pwd.Name = "txt_nouv_pwd"
        Me.txt_nouv_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_nouv_pwd.Size = New System.Drawing.Size(134, 22)
        Me.txt_nouv_pwd.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nouveau mot de passe "
        '
        'COM_modifier_mot_passe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(884, 442)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbox_affichage)
        Me.Controls.Add(Me.GBox_btn)
        Me.Controls.Add(Me.GBox_cle)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "COM_modifier_mot_passe"
        Me.Text = "Modification du mot de passe"
        Me.GBox_btn.ResumeLayout(False)
        Me.GBox_cle.ResumeLayout(False)
        Me.GBox_cle.PerformLayout()
        Me.gbox_affichage.ResumeLayout(False)
        Me.gbox_affichage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBox_btn As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_quiter As System.Windows.Forms.Button
    Friend WithEvents Btn_Enregistrer As System.Windows.Forms.Button
    Friend WithEvents GBox_cle As System.Windows.Forms.GroupBox
    Friend WithEvents cbx_user As System.Windows.Forms.ComboBox
    Friend WithEvents Lab_Inti As System.Windows.Forms.Label
    Friend WithEvents txt_anc_pwd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbox_affichage As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_conf_pwd As System.Windows.Forms.TextBox
    Friend WithEvents txt_nouv_pwd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_annuler As System.Windows.Forms.Button
End Class

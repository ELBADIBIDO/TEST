Public Class COM_modifier_mot_passe
    
    Private Sub com_administration_utilisateur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        maform = Me.Name
        req = "select  id_user, nom from utilisateur"
        charger_combobox(maform, req, cbx_user, "nom", "id_user")
        desactiver(maform, gbox_affichage)
        If cbx_user.Items.Count = 0 Then
            MsgBox("Proceder d'abord à la création de votre utilisateur")
            Return

        Else
            cbx_user.SelectedItem = cbx_user.Items(0)
        End If
    End Sub


    Private Sub Btn_Enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Enregistrer.Click
        If Len(txt_nouv_pwd.Text) < 8 Then
            MsgBox("choisir un mot de passe d'au moins 8 caractères")
            Return
        End If
        req = "update utilisateur set pwd='" & txt_nouv_pwd.Text.ToUpper & "' where id_user=" & cbx_user.SelectedValue
        enregistrer(req)
        journal(Date.Now, xynom, xyatelier, req)

        btn_annuler_Click(sender, e)
    End Sub

    Private Sub Btn_quiter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_quiter.Click
        cnn.Close()
        Me.Close()
    End Sub


    Private Sub btn_annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_annuler.Click
        desactiver(maform, gbox_affichage)
        btn_annuler.Enabled = False
        Btn_Enregistrer.Enabled = False
        cbx_user.Enabled = True
        txt_nouv_pwd.Text = ""
        txt_conf_pwd.Text = ""
        txt_anc_pwd.Text = ""
        cbx_user.Focus()
    End Sub

    Private Sub txt_anc_pwd_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_anc_pwd.Validated
        Dim mot_de_passe As String
        req = "select  pwd from utilisateur where id_user=" & cbx_user.SelectedValue
        cmd.CommandText = req
        mot_de_passe = cmd.ExecuteScalar().ToString
        btn_annuler.Enabled = True
        desactiver(maform, GBox_cle)
        If mot_de_passe = txt_anc_pwd.Text.ToUpper Then
            activer(maform, gbox_affichage)
            txt_nouv_pwd.Focus()
        Else
            MsgBox("mot de passe invalide", 0, "attention")
            desactiver(maform, gbox_affichage)
            txt_anc_pwd.Text = ""
            btn_annuler_Click(sender, e)
        End If
    End Sub


    Private Sub cbx_user_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_user.SelectedIndexChanged
        txt_anc_pwd.Enabled = True
        txt_anc_pwd.Focus()
    End Sub


    Private Sub txt_conf_pwd_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_conf_pwd.Validated
        If txt_nouv_pwd.Text = txt_conf_pwd.Text And txt_nouv_pwd.Text <> "" Then
            Btn_Enregistrer.Enabled = True
        Else
            Btn_Enregistrer.Enabled = False
        End If

    End Sub


    Private Sub txt_nouv_pwd_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nouv_pwd.Validated
        txt_conf_pwd_Validated(sender, e)
    End Sub

    
End Class
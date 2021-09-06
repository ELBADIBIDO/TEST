Public Class COM_UNITE
    Dim req_dgv_g As String


    Private Sub unite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        maform = Me.Name
        req_dgv_g = "select id_unite, lib_unite, rib_ccp from unite order by id_unite"
        charger_grid_view(maform, req_dgv_g, DataGridView1)
        op = "N"
        'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.Columns(1).Width = 230
        DataGridView1.Columns(0).Width = 60
    End Sub

    Private Sub Btn_nouveau_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_nouveau.Click
        op = "N"
        etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        desactiver(maform, GroupBox4)
        desactiver(maform, GroupBox1)
        vider(maform, GroupBox1)
        activer(maform, GroupBox2)
        vider(maform, GroupBox2)
        Txt_lib_unite.Focus()
    End Sub


    Private Sub Btn_Modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifier.Click
        op = "M"
        etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        desactiver(maform, GroupBox4)
        vider(maform, GroupBox1)
        vider(maform, GroupBox2)
        txt_id_unite.Enabled = True
        txt_id_unite.Focus()
    End Sub

    Private Sub Btn_Enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Enregistrer.Click
        If op = "M" Then
            req = "update unite set  lib_unite='" & Txt_lib_unite.Text.ToUpper & "', rib_ccp='" & Txt_ccp_unite.Text.ToUpper & "' where id_unite=" & txt_id_unite.Text
        Else
            req = "insert into unite (lib_unite, rib_ccp) values ('" & Txt_lib_unite.Text.ToUpper & "','" & Txt_ccp_unite.Text.ToUpper & "')"
        End If
        op = "N"
        enregistrer(req)
        charger_grid_view(maform, req_dgv_g, DataGridView1)
        desactiver(maform, GroupBox2)
        vider(maform, GroupBox2)
        vider(maform, GroupBox1)
        activer(maform, GroupBox4)
        etat_bout2(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
    End Sub


    Private Sub Btn_quiter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_quiter.Click
        cnn.Close()
        Me.Close()
    End Sub

    Private Sub Btn_Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Annuler.Click
        op = "N"
        vider(maform, GroupBox1)
        vider(maform, GroupBox2)
        activer(maform, GroupBox4)
        desactiver(maform, GroupBox2)
        etat_bout2(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
    End Sub

    Private Sub Btn_Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Supprimer.Click
        req = "delete * from unite where id_unite=" & txt_id_unite.Text & ""
        supprimer(req)
        charger_grid_view(maform, req_dgv_g, DataGridView1)

        desactiver(maform, GroupBox2)
        vider(maform, GroupBox2)
        activer(maform, GroupBox4)
        etat_bout2(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        op = "N"
    End Sub

    Private Sub txt_id_unite_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_id_unite.KeyPress
        mask_entier(sender, e)
    End Sub



    Private Sub txt_id_banque_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_id_unite.Validated
        dr.Close()
        If txt_id_unite.Text <> "" Then
            desactiver(maform, GroupBox1)
            cmd.CommandText = "select id_unite, lib_unite,rib_ccp from unite  where id_unite=" & txt_id_unite.Text
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                Txt_lib_unite.Text = dr(1)
                Txt_ccp_unite.Text = dr(2)

                If op = "N" Then
                    Btn_Annuler_Click(sender, e)
                    MsgBox("Cette  unité existe déja")
                Else
                    activer(maform, GroupBox2)
                    Txt_lib_unite.SelectionStart = 0
                    Txt_lib_unite.SelectionLength = Len(Txt_lib_unite.Text)
                    Txt_lib_unite.Focus()
                    Btn_Supprimer.Enabled = True
                    Btn_Enregistrer.Enabled = True
                End If
            Else
                If op = "M" Then
                    Btn_Annuler_Click(sender, e)
                    MsgBox("Cette  unite n'existe pas")
                Else
                    Btn_Enregistrer.Enabled = True
                    activer(maform, GroupBox2)
                    Txt_lib_unite.Focus()
                End If
            End If
            dr.Close()
        End If

    End Sub

    Private Sub Txt_nom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_lib_unite.TextChanged
        If Txt_lib_unite.Text.Length <> 0 Then
            Btn_Enregistrer.Enabled = True
        Else
            Btn_Enregistrer.Enabled = False
        End If
    End Sub

    Private Sub tb_r_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_r.TextChanged
        req = "select id_unite, lib_unite, rib_ccp from unite  where lib_unite like '" & tb_r.Text & "%' order by id_unite"
        charger_grid_view(maform, req, DataGridView1)
    End Sub

    Private Sub DataGridView1_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        If DataGridView1.CurrentCell.RowIndex >= 0 Then
            txt_id_unite.Text = DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value
            Txt_lib_unite.Text = DataGridView1(1, DataGridView1.CurrentCell.RowIndex).Value
            Txt_ccp_unite.Text = DataGridView1(2, DataGridView1.CurrentCell.RowIndex).Value
            op = "M"
            activer(maform, GroupBox2)
            desactiver(maform, GroupBox4)
            etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
            Btn_Supprimer.Enabled = True
            Btn_Enregistrer.Enabled = True
            Btn_Annuler.Enabled = True
        End If
    End Sub

    Private Sub Txt_ccp_unite_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_ccp_unite.TextChanged

    End Sub
End Class
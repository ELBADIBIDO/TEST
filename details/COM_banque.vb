Public Class COM_banque
    Dim req_dgv_g As String


    Private Sub banque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        maform = Me.Name
        req_dgv_g = "select id_banque, lib_banque, rib_ccp from banque order by id_banque"
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
        Txt_lib_banque.Focus()
    End Sub


    Private Sub Btn_Modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifier.Click
        op = "M"
        etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        desactiver(maform, GroupBox4)
        vider(maform, GroupBox1)
        vider(maform, GroupBox2)
        txt_id_banque.Enabled = True
        txt_id_banque.Focus()
    End Sub

    Private Sub Btn_Enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Enregistrer.Click
        If op = "M" Then
            req = "update banque set  lib_banque='" & Txt_lib_banque.Text.ToUpper & "', rib_ccp='" & Txt_ccp_banque.Text.ToUpper & "' where id_banque=" & txt_id_banque.Text
        Else
            req = "insert into banque (lib_banque, rib_ccp) values ('" & Txt_lib_banque.Text.ToUpper & "','" & Txt_ccp_banque.Text.ToUpper & "')"
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
        req = "delete * from banque where id_banque=" & txt_id_banque.Text & ""
        supprimer(req)
        charger_grid_view(maform, req_dgv_g, DataGridView1)
        desactiver(maform, GroupBox2)
        vider(maform, GroupBox2)
        activer(maform, GroupBox4)
        etat_bout2(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        op = "N"
    End Sub

    Private Sub txt_id_banque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_id_banque.KeyPress
        mask_entier(sender, e)
    End Sub



    Private Sub txt_id_banque_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_id_banque.Validated
        dr.Close()
        If txt_id_banque.Text <> "" Then
            desactiver(maform, GroupBox1)
            cmd.CommandText = "select id_banque, lib_banque,iif(isnull(sum(rib_ccp)),0,sum(rib_ccp)) from banque  where id_banque=" & txt_id_banque.Text
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                Txt_lib_banque.Text = dr(1)
                Txt_ccp_banque.Text = dr(2)

                If op = "N" Then
                    Btn_Annuler_Click(sender, e)
                    MsgBox("Cette  banque existe déja")
                Else
                    activer(maform, GroupBox2)
                    Txt_lib_banque.SelectionStart = 0
                    Txt_lib_banque.SelectionLength = Len(Txt_lib_banque.Text)
                    Txt_lib_banque.Focus()
                    Btn_Supprimer.Enabled = True
                    Btn_Enregistrer.Enabled = True
                End If
            Else
                If op = "M" Then
                    Btn_Annuler_Click(sender, e)
                    MsgBox("Cette  banque n'existe pas")
                Else
                    Btn_Enregistrer.Enabled = True
                    activer(maform, GroupBox2)
                    Txt_lib_banque.Focus()
                End If
            End If
            dr.Close()
        End If

    End Sub


    Private Sub Txt_nom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_lib_banque.TextChanged
        If Txt_lib_banque.Text.Length <> 0 Then
            Btn_Enregistrer.Enabled = True
        Else
            Btn_Enregistrer.Enabled = False
        End If
    End Sub


    Private Sub tb_r_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_r.TextChanged
        req = "select id_banque, lib_banque, iif(isnull(sum(rib_ccp)),0,sum(rib_ccp)) from banque  where lib_banque like '" & tb_r.Text & "%' order by id_banque"
        charger_grid_view(maform, req, DataGridView1)
    End Sub



    Private Sub DataGridView1_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.CurrentCell.RowIndex >= 0 Then

            txt_id_banque.Text = DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value
            Txt_lib_banque.Text = DataGridView1(1, DataGridView1.CurrentCell.RowIndex).Value
            Txt_ccp_banque.Text = DataGridView1(2, DataGridView1.CurrentCell.RowIndex).Value

            op = "M"
            activer(maform, GroupBox2)
            desactiver(maform, GroupBox4)
            etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
            Btn_Supprimer.Enabled = True
            Btn_Enregistrer.Enabled = True
            Btn_Annuler.Enabled = True
        End If
    End Sub

    Private Sub txt_id_banque_TextChanged(sender As Object, e As EventArgs) Handles txt_id_banque.TextChanged

    End Sub
End Class
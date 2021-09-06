
Public Class COM_bataillon
    Dim req_dgv_g As String
    Private Sub COM_bataillon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        maform = Me.Name
        charger_combobox(maform, "select cod_corps_a, cod_corps_n from corps  order by cod_corps_a", Cbx_corps, "cod_corps_a", "cod_corps_n")
        Cbx_corps.SelectedItem = Cbx_corps.Items(0)
        req_dgv_g = "SELECT bataillon.cod_bat_n,bataillon.cod_bat_a FROM bataillon order by cod_bat_n "
        charger_grid_view(maform, req_dgv_g, DataGridView1)
        op = "N"
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 100
    End Sub

    Private Sub tb_r_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_r.TextChanged
        req = "SELECT bataillon.cod_bat_n,bataillon.cod_bat_a FROM bataillon where cod_bat_a like '" & tb_r.Text & "%' order by cod_bat_n"
        charger_grid_view(maform, req, DataGridView1)
    End Sub
    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Btn_Annuler_Click(sender, e)
        op = "M"
        If DataGridView1.CurrentCell.RowIndex >= 0 Then
            txt_cod_bat_n.Text = DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value
            txt_cod_bat_n_Validated(sender, e)
            activer(maform, GroupBox2)
            desactiver(maform, GroupBox4)
            etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
            Btn_Supprimer.Enabled = True
            Btn_Enregistrer.Enabled = True
            Btn_Annuler.Enabled = True
        End If
    End Sub

    Private Sub Txt_cod_bat_a_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_cod_bat_a.TextChanged
        If Txt_cod_bat_a.Text.Length <> 0 Then

            Btn_Enregistrer.Enabled = True
        Else
            Btn_Enregistrer.Enabled = False
        End If
    End Sub

    Private Sub Btn_Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Annuler.Click
        vider(maform, GroupBox1)
        vider(maform, GroupBox2)
        activer(maform, GroupBox4)
        desactiver(maform, GroupBox2)
        etat_bout2(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        Txt_cod_bat_a.Focus()
    End Sub

    Private Sub Btn_nouveau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_nouveau.Click
        op = "N"
        etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        desactiver(maform, GroupBox1)
        activer(maform, GroupBox2)
        desactiver(maform, GroupBox4)
        vider(maform, GroupBox1)
        vider(maform, GroupBox2)
        Txt_cod_bat_a.Focus()
    End Sub

    Private Sub Btn_Modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifier.Click
        op = "M"
        etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        desactiver(maform, GroupBox4)
        vider(maform, GroupBox1)
        vider(maform, GroupBox2)
        txt_cod_bat_n.Enabled = True
        txt_cod_bat_n.Focus()
    End Sub

    Private Sub Btn_Enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Enregistrer.Click
        If op = "M" Then
            req = "update bataillon set  cod_bat_a ='" & Txt_cod_bat_a.Text.ToUpper & "', cod_corps_n=" & Cbx_corps.SelectedValue & " where cod_bat_n=" & txt_cod_bat_n.Text & ""
        Else
            req = "insert into bataillon (cod_bat_a,cod_corps_n ) values ('" & Txt_cod_bat_a.Text.ToUpper & "', " & Cbx_corps.SelectedValue & ")"

        End If
        op = "N"
        enregistrer(req)
        charger_grid_view(maform, req_dgv_g, DataGridView1)
        Btn_Annuler_Click(sender, e)
    End Sub

    Private Sub txt_cod_bat_n_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cod_bat_n.KeyPress
        mask_entier(sender, e)
    End Sub
    Private Sub txt_cod_bat_n_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cod_bat_n.Validated
        dr.Close()
        If txt_cod_bat_n.Text <> "" Then
            desactiver(maform, GroupBox1)
            cmd.CommandText = "SELECT bataillon.cod_bat_n,bataillon.cod_bat_a FROM bataillon where cod_bat_n=" & txt_cod_bat_n.Text
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                Txt_cod_bat_a.Text = dr(1)
                If op = "N" Then
                    MsgBox("Cette  bataillon existe déja")
                    Btn_Annuler_Click(sender, e)
                Else
                    activer(maform, GroupBox2)
                    Txt_cod_bat_a.SelectionStart = 0
                    Txt_cod_bat_a.SelectionLength = Len(Txt_cod_bat_a.Text)
                    Txt_cod_bat_a.Focus()
                    Btn_Supprimer.Enabled = True
                    Btn_Enregistrer.Enabled = True
                End If
            Else
                If op = "M" Then
                    Btn_Annuler_Click(sender, e)
                    MsgBox("Cette  bataillon n'existe pas")
                Else
                    Btn_Enregistrer.Enabled = True
                    activer(maform, GroupBox2)
                    Txt_cod_bat_a.Focus()
                End If
            End If
            dr.Close()
        End If
    End Sub

    Private Sub Btn_Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Supprimer.Click
        req = "delete * from bataillon where cod_bat_n=" & txt_cod_bat_n.Text & ""
        supprimer(req)
        charger_grid_view(maform, req_dgv_g, DataGridView1)
        Btn_Annuler_Click(sender, e)
        op = "N"
    End Sub

    Private Sub Btn_quiter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_quiter.Click
        cnn.Close()
        Me.Close()
    End Sub


    Private Sub txt_cod_bat_n_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cod_bat_n.TextChanged

    End Sub
End Class
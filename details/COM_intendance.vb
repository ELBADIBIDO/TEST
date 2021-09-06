
Public Class com_intendance
    Dim req_dgv_g As String
    Private Sub com_intendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        maform = Me.Name
        req_dgv_g = "SELECT cod_int, lib_int FROM intendance order by cod_int "
        charger_grid_view(maform, req_dgv_g, DataGridView1)
        op = "N"
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 180

    End Sub

    Private Sub tb_r_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_r.TextChanged
        req = "SELECT cod_int, lib_int FROM intendance where lib_int like '" & tb_r.Text & "%' order by cod_int "
        charger_grid_view(maform, req, DataGridView1)
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Btn_Annuler_Click(sender, e)
        op = "M"
        If DataGridView1.CurrentCell.RowIndex >= 0 Then
            txt_cod_int.Text = DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value
            txt_cod_int_Validated(sender, e)
            activer(maform, GroupBox2)
            desactiver(maform, GroupBox4)
            etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
            Btn_Supprimer.Enabled = True
            Btn_Enregistrer.Enabled = True
            Btn_Annuler.Enabled = True
        End If
    End Sub

    Private Sub Txt_lib_int_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_lib_int.TextChanged
        If Txt_lib_int.Text.Length <> 0 Then

            Btn_Enregistrer.Enabled = True
        Else
            Btn_Enregistrer.Enabled = False
        End If
    End Sub

    Private Sub Btn_Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Annuler.Click
        'op = "N"
        vider(maform, GroupBox1)
        vider(maform, GroupBox2)
        activer(maform, GroupBox4)
        desactiver(maform, GroupBox2)
        etat_bout2(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        Txt_lib_int.Focus()
    End Sub

    Private Sub Btn_nouveau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_nouveau.Click
        op = "N"
        etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        desactiver(maform, GroupBox1)
        activer(maform, GroupBox2)
        desactiver(maform, GroupBox4)
        vider(maform, GroupBox1)
        vider(maform, GroupBox2)
        Txt_lib_int.Focus()
    End Sub

    Private Sub Btn_Modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifier.Click
        op = "M"
        etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        desactiver(maform, GroupBox4)
        vider(maform, GroupBox1)
        vider(maform, GroupBox2)
        txt_cod_int.Enabled = True
        txt_cod_int.Focus()
    End Sub

    Private Sub Btn_Enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Enregistrer.Click
        If op = "M" Then
            req = "update intendance set  lib_int='" & Txt_lib_int.Text.ToUpper & "' where cod_int=" & txt_cod_int.Text
        Else
            req = "insert into intendance (lib_int) values ('" & Txt_lib_int.Text.ToUpper & "' )"
        End If
        op = "N"
        enregistrer(req)
        charger_grid_view(maform, req_dgv_g, DataGridView1)
        Btn_Annuler_Click(sender, e)
    End Sub

    Private Sub txt_cod_int_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cod_int.KeyPress
        mask_entier(sender, e)
    End Sub


    Private Sub txt_cod_int_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cod_int.Validated
        dr.Close()
        If txt_cod_int.Text <> "" Then
            desactiver(maform, GroupBox1)
            cmd.CommandText = "SELECT cod_int, lib_int FROM intendance where cod_int=" & txt_cod_int.Text
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                Txt_lib_int.Text = dr(1)
                If op = "N" Then
                    MsgBox("Cette  intendance existe déja")
                    Btn_Annuler_Click(sender, e)
                Else
                    activer(maform, GroupBox2)
                    Txt_lib_int.SelectionStart = 0
                    Txt_lib_int.SelectionLength = Len(Txt_lib_int.Text)
                    Txt_lib_int.Focus()
                    Btn_Supprimer.Enabled = True
                    Btn_Enregistrer.Enabled = True
                End If
            Else
                If op = "M" Then
                    Btn_Annuler_Click(sender, e)
                    MsgBox("Cette  intendance n'existe pas")
                Else
                    Btn_Enregistrer.Enabled = True
                    activer(maform, GroupBox2)
                    Txt_lib_int.Focus()
                End If
            End If
            dr.Close()
        End If
    End Sub

    Private Sub Btn_Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Supprimer.Click
        req = "delete * from intendance where cod_int=" & txt_cod_int.Text & ""
        supprimer(req)
        charger_grid_view(maform, req_dgv_g, DataGridView1)
        Btn_Annuler_Click(sender, e)
        op = "N"
    End Sub

    Private Sub Btn_quiter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_quiter.Click
        cnn.Close()
        Me.Close()
    End Sub

    
    Private Sub txt_cod_int_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cod_int.TextChanged

    End Sub
End Class
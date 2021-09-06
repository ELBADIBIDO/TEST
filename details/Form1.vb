
Imports WindowsApplication1.MAJCNIE
Imports WindowsApplication1.dep_except
Imports System.ComponentModel

Public Class Form1
    'Dim mjcnie As MAJCNIE
    'Dim dep_excep As dep_except


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Name = maform
        Activate()

        If CPP = "OUI" Then

            Dim a As String = "."
            Label1.Text = "LISTE DES PERSONNEL"
            req = " Select g.cod_grd_a , p.nom , p.prenom , p.cni   FROM personnel
               p inner join grade g on p.cod_grd_n=g.cod_grd_n  where  cni NOT Like'%" & a & "%'"
            charger_grid_view(maform, req, DataGridView1)



        Else

            Dim a As String = "."
            Label1.Text = "LISTE DES PERSONNEL"
            req = " Select g.cod_grd_a , p.nom , p.prenom , p.cni   FROM personnel
               p inner join grade g on p.cod_grd_n=g.cod_grd_n  where  cni Like'%" & a & "%'"
            charger_grid_view(maform, req, DataGridView1)


            For ii = 0 To DataGridView1.Rows.Count - 1
                DataGridView1(3, ii).Value = DataGridView1(3, ii).Value.ToString.Replace(".", "")
            Next
            DataGridView1.Refresh()


        End If




    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataGridView1.KeyPress

        If e.KeyChar = Chr(Keys.Escape) Then
            Hide()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged



        If CPP = "OUI" Then
            Dim a As String = TextBox1.Text

            req = "  Select g.cod_grd_a , p.nom , p.prenom , p.cni   FROM personnel
               p inner join grade g on p.cod_grd_n=g.cod_grd_n  where  p.cni NOT LIKE '.%' AND  p.cni Like'%" & a & "%' ORDER BY nom "
            charger_grid_view(maform, req, DataGridView1)



        Else
            Dim a As String = "." & TextBox1.Text
            req = "  Select g.cod_grd_a , p.nom , p.prenom , p.cni   FROM personnel
               p inner join grade g on p.cod_grd_n=g.cod_grd_n  where  p.cni Like'%" & a & "%' ORDER BY nom "
            charger_grid_view(maform, req, DataGridView1)

            For ii = 0 To DataGridView1.Rows.Count - 1
                DataGridView1(3, ii).Value = DataGridView1(3, ii).Value.ToString.Replace(".", "")
            Next
            DataGridView1.Refresh()
        End If


    End Sub



    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

        'mjcnie = New MAJCNIE

        If DataGridView1.CurrentCell.RowIndex >= 0 Then



            MAJCNIE.TextBox1.Text = DataGridView1(3, DataGridView1.CurrentCell.RowIndex).Value.ToString
            MAJCNIE.TextBox1_Validated(sender, e)
            Hide()
            Return


        End If


    End Sub


End Class
Public Class Dep_MAJCNIE
    Dim cine As String = ""

    Private Sub Dep_MAJCNIE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()

        GroupBox1.Visible = False
        TXT_NVCNIE.Enabled = False
        Label2.Enabled = False
    End Sub

    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles TextBox1.Validated
        If TextBox1.Text <> "" Then

            cine = "." & TextBox1.Text
            cmd.CommandText = "select cni, cod_grd_n, nom, prenom from personnel  where cni='" & cine & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                Label4.Text = dr(1).ToString.ToUpper & "   " & dr(2).ToString.ToUpper & "  " & dr(3).ToString.ToUpper
                Label2.Visible = True
                TXT_NVCNIE.Visible = True
            Else
                MsgBox("CNIE INEXISTANTE")
                TextBox1.Text = ""
                TextBox1.Select()
                Return
            End If
            dr.Close()
        Else
            TextBox1.Text = ""
            TextBox1.Select()
        End If
    End Sub

    Private Sub TXT_NVCNIE_Validated(sender As Object, e As EventArgs) Handles TXT_NVCNIE.Validated
        If TXT_NVCNIE.Text <> "" Then
            GroupBox1.Visible = False

        Else
            MsgBox("CNIE NON SAISIE PAS DE MISE A JOUR")
        End If
    End Sub

End Class
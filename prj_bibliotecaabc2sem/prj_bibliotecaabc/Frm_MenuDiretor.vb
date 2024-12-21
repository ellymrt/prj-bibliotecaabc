Public Class Frm_MenuDiretor
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit()
    End Sub

    Private Sub btn_relatoriosecatalogos_Click(sender As Object, e As EventArgs) Handles btn_relatoriosecatalogos.Click
        Frm_Catalogo.ShowDialog()
    End Sub

    Private Sub btn_alunos_Click(sender As Object, e As EventArgs) Handles btn_alunos.Click
        Frm_CadastroFuncionario.ShowDialog()
    End Sub

End Class
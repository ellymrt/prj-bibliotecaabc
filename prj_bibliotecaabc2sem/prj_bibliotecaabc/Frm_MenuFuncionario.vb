Public Class Frm_MenuFuncionario
    Private Sub btn_relatoriosecatalogos_Click(sender As Object, e As EventArgs) Handles btn_relatoriosecatalogos.Click
        Frm_Catalogo.ShowDialog()
    End Sub

    Private Sub btn_alunos_Click(sender As Object, e As EventArgs) Handles btn_alunos.Click
        Frm_CadastroAlunos.ShowDialog()
    End Sub

    Private Sub btn_livros_Click(sender As Object, e As EventArgs) Handles btn_livros.Click
        Frm_Livros.ShowDialog()
    End Sub

    Private Sub btn_emprestimos_Click(sender As Object, e As EventArgs) Handles btn_emprestimos.Click
        Frm_Emprestimos.ShowDialog()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit()
    End Sub
End Class
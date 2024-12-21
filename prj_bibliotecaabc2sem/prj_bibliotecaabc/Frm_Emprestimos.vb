Public Class Frm_Emprestimos
    Private Sub Frm_Emprestimos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_sql_server()
        carregar_campos_emprestimos()
        carregar_dados_emprestimos()
    End Sub

    Private Sub ckb_emprestado_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_emprestado.CheckedChanged
        If ckb_emprestado.Checked Then
            ckb_naoemprestado.Checked = False
        End If
    End Sub

    Private Sub ckb_naoemprestado_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_naoemprestado.CheckedChanged
        If ckb_naoemprestado.Checked Then
            ckb_emprestado.Checked = False
        End If
    End Sub

    Private Sub dgv_emprestimo_livro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_emprestimo_livro.CellContentClick
        Try
            With dgv_emprestimo_livro
                If .CurrentRow.Cells(6).Selected = True Then
                    codigo = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_livros where cod='" & codigo & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        txt_titulo.Text = rs.Fields(1).Value
                        txt_subtitulo.Text = rs.Fields(2).Value
                    End If
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            titu = txt_titulo.Text
            subtitu = txt_subtitulo.Text
            If ckb_emprestado.Checked Then
                sql = "UPDATE tb_livros SET situacao='NAO DISPONIVEL' WHERE titulo='" & titu & "' AND subtitulo='" & subtitu & "'"
            ElseIf ckb_naoemprestado.Checked Then
                sql = "UPDATE tb_livros SET situacao='DISPONIVEL' WHERE titulo='" & titu & "' AND subtitulo='" & subtitu & "'"
            Else
                MessageBox.Show("Selecione uma situação (Emprestado ou Não Emprestado).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            db.Execute(sql)
            MessageBox.Show("Registro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            carregar_dados_emprestimos()
            ckb_emprestado.Checked = False
            ckb_naoemprestado.Checked = False
            limpar_emprestimo()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStrip1_TextChanged(sender As Object, e As EventArgs) Handles ToolStrip1.TextChanged

    End Sub

    Private Sub txt_pesquisa_Click(sender As Object, e As EventArgs) Handles txt_pesquisa.Click

    End Sub

    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        Try
            With dgv_emprestimo_livro
                .Rows.Clear()
                sql = "select * from tb_livros where " & cmb_campo.Text & " Like '" & txt_pesquisa.Text & "%'"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(5).Value, rs.Fields(7).Value, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class
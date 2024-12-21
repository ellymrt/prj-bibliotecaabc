Public Class Frm_Livros
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            sql = "select * from tb_livros where titulo = '" & txt_titulo.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = True Then
                'criar auto preenchimento id!!!!!!!!!:3
                sql = "insert into tb_livros (titulo, subtitulo, autor, edicao, editora, data_publi, situacao)" &
                    "values('" & txt_titulo.Text & "', '" & txt_subtitulo.Text & "', " &
                    "'" & txt_autores.Text & "', '" & txt_edicao.Text & "', '" & txt_editora.Text & "', '" & cmb_data_publi.Value.Date & "', 'DISPONIVEL')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_livros()
                carregar_dados_livros()
            Else
                codigo = rs.Fields("cod").Value
                sql = "update tb_livros set titulo='" & txt_titulo.Text & "'," &
                        "subtitulo='" & txt_subtitulo.Text & "'," &
                        "autor='" & txt_autores.Text & "'," &
                        "edicao='" & txt_edicao.Text & "'," &
                        "editora='" & txt_editora.Text & "'," &
                        "data_publi='" & cmb_data_publi.Value.Date & "' " &
                        "where cod='" & codigo & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_livros()
                carregar_dados_livros()
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Exclamation + vbOKOnly, "Aviso")
        End Try
    End Sub

    Private Sub Frm_Livros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_sql_server()
        carregar_dados_livros()
    End Sub

    Private Sub dgv_cadastro_livros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cadastro_livros.CellContentClick
        Try
            With dgv_cadastro_livros
                If .CurrentRow.Cells(3).Selected = True Then
                    codigo = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_livros where cod='" & codigo & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        txt_titulo.Text = rs.Fields(1).Value
                        txt_subtitulo.Text = rs.Fields(2).Value
                        txt_autores.Text = rs.Fields(3).Value
                        txt_edicao.Text = rs.Fields(4).Value
                        txt_editora.Text = rs.Fields(5).Value
                        cmb_data_publi.Value = rs.Fields(6).Value
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    codigo = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_livros where cod='" & codigo & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        nome_log = rs.Fields("titulo").Value
                        resp = MsgBox("Deseja realmente excluir?" + vbNewLine &
                          "o LIVRO: " & nome_log & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = MsgBoxResult.Yes Then
                            sql = "delete from tb_livros where cod='" & codigo & "'"
                            rs = db.Execute(sql)
                            carregar_dados_livros()
                            limpar_livros()
                            MsgBox("Registro excluído com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                        End If
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        Try
            With dgv_cadastro_livros
                .Rows.Clear()
                sql = "SELECT * FROM tb_livros WHERE titulo LIKE '" & txt_pesquisa.Text & "%'"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class
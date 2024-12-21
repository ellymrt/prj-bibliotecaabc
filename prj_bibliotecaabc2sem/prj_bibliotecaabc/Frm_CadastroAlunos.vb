Public Class Frm_CadastroAlunos
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            sql = "select * from tb_cadastro where cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tb_cadastro values('" & txt_cpf.Text & "', '" & txt_nome.Text & "', " &
                    "'" & txt_senha.Text & "', '" & txt_email.Text & "', 'ALUNO')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro()
                carregar_dados()
            Else
                sql = "update tb_cadastro set nome='" & txt_nome.Text & "'," &
                    "cpf='" & txt_cpf.Text & "'," &
                    "email='" & txt_email.Text & "'," &
                    "senha = '" & txt_senha.Text & "' " &
                    "where cpf = '" & txt_cpf.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro()
                carregar_dados()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Frm_CadastroAlunos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_sql_server()
        carregar_dados()
        carregar_campos()
    End Sub

    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        Try
            With dgv_cadastro_alunos
                .Rows.Clear()
                sql = "select * from tb_cadastro where " & cmb_campo.Text & " Like '" & txt_pesquisa.Text & "%'"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgv_cadastro_alunos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cadastro_alunos.CellContentClick
        Try
            With dgv_cadastro_alunos
                If .CurrentRow.Cells(2).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        txt_senha.Text = rs.Fields(2).Value
                        txt_email.Text = rs.Fields(3).Value
                    End If
                ElseIf .CurrentRow.Cells(3).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        resp = MsgBox("Deseja realmente excluir?" + vbNewLine &
                          "o CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = MsgBoxResult.Yes Then
                            sql = "delete from tb_cadastro where cpf='" & aux_cpf & "'"
                            rs = db.Execute(sql)
                            carregar_dados()
                            limpar_cadastro()
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

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class

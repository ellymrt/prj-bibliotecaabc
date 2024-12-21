Imports System.Collections.Concurrent
Imports System.ComponentModel.Design
Imports ADODB

Module Module1
    Public diretorio, sql, aux_cpf, resp, nome_log, titu, subtitu As String 'public para delcarar variáveis globais
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public cont, codigo As Integer

    Sub conectar_banco_sql_server()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DESKTOP-0UB9ILP;Initial Catalog=biblioteca_va2;trusted_connection=yes;")
            MsgBox("Conexão bem sucedida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub limpar_cadastro()
        With Frm_CadastroAlunos
            .txt_cpf.Clear()
            .txt_nome.Clear()
            .txt_email.Clear()
            .txt_senha.Clear()
            .txt_cpf.Focus()
        End With
    End Sub
    Sub limpar_cadastro_func()
        With Frm_CadastroFuncionario
            .txt_cpf.Clear()
            .txt_nome.Clear()
            .txt_email.Clear()
            .txt_senha.Clear()
            .txt_cpf.Focus()
        End With
    End Sub

    Sub carregar_dados()
        Try
            With Frm_CadastroAlunos.dgv_cadastro_alunos
                .Rows.Clear()
                sql = "select * from tb_cadastro order by nome asc"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    If rs.Fields("cargo").Value = "ALUNO" Then
                        .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                    End If
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Sub carregar_dados_func()
        Try
            With Frm_CadastroFuncionario.dgv_cadastro_funcionarios
                .Rows.Clear()
                sql = "select * from tb_cadastro order by nome asc"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    If rs.Fields("cargo").Value = "FUNCIONARIO" Then
                        .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                    End If
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub carregar_dados_livros()
        Try
            With Frm_Livros.dgv_cadastro_livros
                cont = 1
                .Rows.Clear() 'Limpar linhas do dgv
                sql = "select*from tb_livros order by cod asc" 'registros ficaram em ordem numerica qnd cadastrador
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing, Nothing)
                    rs.MoveNext() 'ir para a prox linha do dgv
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Sub carregar_dados_catalogo()
        Try
            With Frm_Catalogo.dgv_catalogo_livros
                .Rows.Clear() 'Limpar linhas do dgv
                sql = "select * from tb_livros order by cod asc" 'registros ficaram em ordem numerica qnd cadastrador
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(5).Value, rs.Fields(7).Value, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                    rs.MoveNext() 'ir para a prox linha do dgv
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Sub carregar_dados_emprestimos()
        Try
            With Frm_Emprestimos.dgv_emprestimo_livro
                .Rows.Clear()
                sql = "select * from tb_livros order by cod asc"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(5).Value, rs.Fields(7).Value, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub carregar_campos()
        Try
            With Frm_CadastroAlunos.cmb_campo.Items
                .Add("CPF")
                .Add("NOME")
                Frm_CadastroAlunos.cmb_campo.SelectedIndex = 1
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub carregar_campos_func()
        Try
            With Frm_CadastroFuncionario.cmb_campo.Items
                .Add("CPF")
                .Add("NOME")
                Frm_CadastroFuncionario.cmb_campo.SelectedIndex = 1
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub carregar_campos_cat()
        Try
            With Frm_Catalogo.cmb_campo.Items
                .Add("TÍTULO")
                .Add("AUTOR")
                .Add("EDITORA")
                Frm_Catalogo.cmb_campo.SelectedIndex = 1
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Sub carregar_campos_emprestimos()
        Try
            With Frm_Emprestimos.cmb_campo.Items
                .Add("TÍTULO")
                .Add("AUTOR")
                .Add("EDITORA")
                Frm_Emprestimos.cmb_campo.SelectedIndex = 1
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpar_emprestimo()
        With Frm_Emprestimos
            .txt_titulo.Clear()
            .txt_subtitulo.Clear()
        End With
    End Sub

    Sub limpar_login()
        With Frm_Login
            .txt_cpf.Clear()
            .txt_senha.Clear()
            .txt_cpf.Focus()
        End With
    End Sub

    Sub limpar_livros()
        With Frm_Livros
            .txt_titulo.Clear()
            .txt_subtitulo.Clear()
            .txt_autores.Clear()
            .txt_edicao.Clear()
            .txt_editora.Clear()
            .cmb_data_publi.Value = Now
            .txt_titulo.Focus()
        End With
    End Sub


End Module

Public Class Frm_Login
    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_sql_server()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try
        If txt_cpf.Text = "000.000.000-00" AndAlso txt_senha.Text = "123" Then
            MsgBox("Olá diretor da escola ABC, login realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Frm_MenuDiretor.ShowDialog()
            limpar_login()
            Exit Sub
        End If

        sql = "SELECT * FROM tb_cadastro WHERE cpf = '" & txt_cpf.Text & "'"
        rs = db.Execute(sql)

            If rs.EOF = False Then
                ' Validar a senha para o CPF encontrado
                If rs.Fields("senha").Value = txt_senha.Text Then
                    If rs.Fields("cargo").Value = "FUNCIONARIO" Then
                        nome_log = rs.Fields("nome").Value
                        MsgBox("Funcionário: '" & nome_log & "'. Login realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                        Frm_MenuFuncionario.ShowDialog()
                        limpar_login()
                    ElseIf rs.Fields("cargo").Value = "ALUNO" Then
                        nome_log = rs.Fields("nome").Value
                        MsgBox("Aluno: '" & nome_log & "'. Login realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    Frm_Catalogo.ShowDialog()
                    limpar_login()
                    End If
                Else
                    MsgBox("Senha incorreta! Tente novamenete.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                End If
            Else
                MsgBox("CPF NÃO LOCALIZADO!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                limpar_login()
            End If
        'Catch ex As Exception

        'End Try
    End Sub
End Class
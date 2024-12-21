Public Class Frm_Catalogo
    Private Sub Frm_Catalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_sql_server()
        carregar_campos_cat()
        carregar_dados_catalogo()
    End Sub

    Private Sub txt_pesquisa_Click(sender As Object, e As EventArgs) Handles txt_pesquisa.Click

    End Sub

    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        Try
            With dgv_catalogo_livros
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

    Private Sub dgv_catalogo_livros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_catalogo_livros.CellContentClick

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MenuFuncionario
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_MenuFuncionario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_relatoriosecatalogos = New System.Windows.Forms.Button()
        Me.btn_alunos = New System.Windows.Forms.Button()
        Me.btn_emprestimos = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_livros = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(170, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MENU"
        '
        'btn_relatoriosecatalogos
        '
        Me.btn_relatoriosecatalogos.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_relatoriosecatalogos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_relatoriosecatalogos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_relatoriosecatalogos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_relatoriosecatalogos.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_relatoriosecatalogos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_relatoriosecatalogos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_relatoriosecatalogos.Location = New System.Drawing.Point(39, 100)
        Me.btn_relatoriosecatalogos.Name = "btn_relatoriosecatalogos"
        Me.btn_relatoriosecatalogos.Size = New System.Drawing.Size(365, 43)
        Me.btn_relatoriosecatalogos.TabIndex = 6
        Me.btn_relatoriosecatalogos.Text = "RELATÓRIOS E CATÁLOGOS"
        Me.btn_relatoriosecatalogos.UseVisualStyleBackColor = False
        '
        'btn_alunos
        '
        Me.btn_alunos.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_alunos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_alunos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_alunos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_alunos.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_alunos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_alunos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_alunos.Location = New System.Drawing.Point(39, 149)
        Me.btn_alunos.Name = "btn_alunos"
        Me.btn_alunos.Size = New System.Drawing.Size(365, 43)
        Me.btn_alunos.TabIndex = 7
        Me.btn_alunos.Text = "MANTER ALUNOS"
        Me.btn_alunos.UseVisualStyleBackColor = False
        '
        'btn_emprestimos
        '
        Me.btn_emprestimos.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_emprestimos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_emprestimos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_emprestimos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_emprestimos.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_emprestimos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_emprestimos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_emprestimos.Location = New System.Drawing.Point(39, 247)
        Me.btn_emprestimos.Name = "btn_emprestimos"
        Me.btn_emprestimos.Size = New System.Drawing.Size(365, 43)
        Me.btn_emprestimos.TabIndex = 8
        Me.btn_emprestimos.Text = "EMPRÉSTIMOS"
        Me.btn_emprestimos.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_sair.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_sair.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_sair.Location = New System.Drawing.Point(39, 296)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(365, 43)
        Me.btn_sair.TabIndex = 9
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'btn_livros
        '
        Me.btn_livros.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_livros.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_livros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_livros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_livros.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_livros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_livros.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_livros.Location = New System.Drawing.Point(39, 198)
        Me.btn_livros.Name = "btn_livros"
        Me.btn_livros.Size = New System.Drawing.Size(365, 43)
        Me.btn_livros.TabIndex = 10
        Me.btn_livros.Text = "MANTER LIVROS"
        Me.btn_livros.UseVisualStyleBackColor = False
        '
        'Frm_MenuFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(442, 369)
        Me.Controls.Add(Me.btn_livros)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_emprestimos)
        Me.Controls.Add(Me.btn_alunos)
        Me.Controls.Add(Me.btn_relatoriosecatalogos)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_MenuFuncionario"
        Me.Text = "MENU FUNCIONÁRIO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_relatoriosecatalogos As Button
    Friend WithEvents btn_alunos As Button
    Friend WithEvents btn_emprestimos As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_livros As Button
End Class

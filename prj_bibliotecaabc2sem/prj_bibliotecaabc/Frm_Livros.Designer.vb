<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Livros
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Livros))
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_titulo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_subtitulo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_autores = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_edicao = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_editora = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_data_publi = New System.Windows.Forms.DateTimePicker()
        Me.dgv_cadastro_livros = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_pesquisa = New System.Windows.Forms.ToolStripTextBox()
        CType(Me.dgv_cadastro_livros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_cadastrar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_cadastrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_cadastrar.Location = New System.Drawing.Point(157, 330)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(222, 43)
        Me.btn_cadastrar.TabIndex = 9
        Me.btn_cadastrar.Text = "CADASTRAR/EDITAR"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(34, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Título:"
        '
        'txt_titulo
        '
        Me.txt_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_titulo.Location = New System.Drawing.Point(38, 132)
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(465, 20)
        Me.txt_titulo.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(173, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "BIBLIOTECA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(34, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Subtítulo:"
        '
        'txt_subtitulo
        '
        Me.txt_subtitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subtitulo.Location = New System.Drawing.Point(38, 181)
        Me.txt_subtitulo.Name = "txt_subtitulo"
        Me.txt_subtitulo.Size = New System.Drawing.Size(465, 20)
        Me.txt_subtitulo.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(34, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Autor(es):"
        '
        'txt_autores
        '
        Me.txt_autores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_autores.Location = New System.Drawing.Point(38, 229)
        Me.txt_autores.Name = "txt_autores"
        Me.txt_autores.Size = New System.Drawing.Size(465, 20)
        Me.txt_autores.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(34, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 24)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Edição:"
        '
        'txt_edicao
        '
        Me.txt_edicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_edicao.Location = New System.Drawing.Point(38, 277)
        Me.txt_edicao.Name = "txt_edicao"
        Me.txt_edicao.Size = New System.Drawing.Size(119, 20)
        Me.txt_edicao.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(162, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 24)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Editora:"
        '
        'txt_editora
        '
        Me.txt_editora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_editora.Location = New System.Drawing.Point(166, 277)
        Me.txt_editora.Name = "txt_editora"
        Me.txt_editora.Size = New System.Drawing.Size(166, 20)
        Me.txt_editora.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(338, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 24)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Data de Publi:"
        '
        'cmb_data_publi
        '
        Me.cmb_data_publi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data_publi.Location = New System.Drawing.Point(342, 277)
        Me.cmb_data_publi.Name = "cmb_data_publi"
        Me.cmb_data_publi.Size = New System.Drawing.Size(161, 20)
        Me.cmb_data_publi.TabIndex = 22
        Me.cmb_data_publi.Value = New Date(2024, 10, 31, 0, 0, 0, 0)
        '
        'dgv_cadastro_livros
        '
        Me.dgv_cadastro_livros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_cadastro_livros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_cadastro_livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cadastro_livros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column4})
        Me.dgv_cadastro_livros.Location = New System.Drawing.Point(38, 399)
        Me.dgv_cadastro_livros.Name = "dgv_cadastro_livros"
        Me.dgv_cadastro_livros.RowHeadersWidth = 62
        Me.dgv_cadastro_livros.Size = New System.Drawing.Size(465, 214)
        Me.dgv_cadastro_livros.TabIndex = 43
        '
        'Column1
        '
        Me.Column1.HeaderText = "COD"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 55
        '
        'Column2
        '
        Me.Column2.HeaderText = "TÍTULO"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 71
        '
        'Column5
        '
        Me.Column5.HeaderText = "SUBTÍTULO"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 93
        '
        'Column3
        '
        Me.Column3.HeaderText = "EDITAR"
        Me.Column3.Image = CType(resources.GetObject("Column3.Image"), System.Drawing.Image)
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 53
        '
        'Column4
        '
        Me.Column4.HeaderText = "EXCLUIR"
        Me.Column4.Image = CType(resources.GetObject("Column4.Image"), System.Drawing.Image)
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 59
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripLabel1, Me.txt_pesquisa})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(542, 31)
        Me.ToolStrip1.TabIndex = 44
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(108, 28)
        Me.ToolStripLabel1.Text = "Pesquise um livros:"
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(300, 31)
        '
        'Frm_Livros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(542, 625)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgv_cadastro_livros)
        Me.Controls.Add(Me.cmb_data_publi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_editora)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_edicao)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_autores)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_subtitulo)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_titulo)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Livros"
        Me.Text = "CADASTRO DE LIVROS"
        CType(Me.dgv_cadastro_livros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_titulo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_subtitulo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_autores As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_edicao As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_editora As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_data_publi As DateTimePicker
    Friend WithEvents dgv_cadastro_livros As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewImageColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_pesquisa As ToolStripTextBox
End Class

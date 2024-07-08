<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserSelectHome
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.İdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetrekareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiyatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KullanicilaridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvlerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElifEmlakDataSet4 = New ElifUygunEmlak.ElifEmlakDataSet4()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EvlerTableAdapter = New ElifUygunEmlak.ElifEmlakDataSet4TableAdapters.EvlerTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvlerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElifEmlakDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.İdDataGridViewTextBoxColumn, Me.AdresDataGridViewTextBoxColumn, Me.MetrekareDataGridViewTextBoxColumn, Me.FiyatDataGridViewTextBoxColumn, Me.KullanicilaridDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EvlerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(26, 13)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(635, 162)
        Me.DataGridView1.TabIndex = 7
        '
        'İdDataGridViewTextBoxColumn
        '
        Me.İdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.İdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.İdDataGridViewTextBoxColumn.Name = "İdDataGridViewTextBoxColumn"
        Me.İdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdresDataGridViewTextBoxColumn
        '
        Me.AdresDataGridViewTextBoxColumn.DataPropertyName = "adres"
        Me.AdresDataGridViewTextBoxColumn.HeaderText = "adres"
        Me.AdresDataGridViewTextBoxColumn.Name = "AdresDataGridViewTextBoxColumn"
        '
        'MetrekareDataGridViewTextBoxColumn
        '
        Me.MetrekareDataGridViewTextBoxColumn.DataPropertyName = "metrekare"
        Me.MetrekareDataGridViewTextBoxColumn.HeaderText = "metrekare"
        Me.MetrekareDataGridViewTextBoxColumn.Name = "MetrekareDataGridViewTextBoxColumn"
        '
        'FiyatDataGridViewTextBoxColumn
        '
        Me.FiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat"
        Me.FiyatDataGridViewTextBoxColumn.HeaderText = "fiyat"
        Me.FiyatDataGridViewTextBoxColumn.Name = "FiyatDataGridViewTextBoxColumn"
        '
        'KullanicilaridDataGridViewTextBoxColumn
        '
        Me.KullanicilaridDataGridViewTextBoxColumn.DataPropertyName = "kullanicilarid"
        Me.KullanicilaridDataGridViewTextBoxColumn.HeaderText = "kullanicilarid"
        Me.KullanicilaridDataGridViewTextBoxColumn.Name = "KullanicilaridDataGridViewTextBoxColumn"
        '
        'EvlerBindingSource
        '
        Me.EvlerBindingSource.DataMember = "Evler"
        Me.EvlerBindingSource.DataSource = Me.ElifEmlakDataSet4
        '
        'ElifEmlakDataSet4
        '
        Me.ElifEmlakDataSet4.DataSetName = "ElifEmlakDataSet4"
        Me.ElifEmlakDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.Purple
        Me.Button1.Location = New System.Drawing.Point(665, 316)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 25)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Panele Dön"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'EvlerTableAdapter
        '
        Me.EvlerTableAdapter.ClearBeforeFill = True
        '
        'UserSelectHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(803, 353)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "UserSelectHome"
        Me.Text = "UserSelectHome"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvlerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElifEmlakDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents ElifEmlakDataSet4 As ElifEmlakDataSet4
    Friend WithEvents EvlerBindingSource As BindingSource
    Friend WithEvents EvlerTableAdapter As ElifEmlakDataSet4TableAdapters.EvlerTableAdapter
    Friend WithEvents İdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MetrekareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FiyatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KullanicilaridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

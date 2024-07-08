<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHireHome
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.İdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetrekareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiyatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KullanicilaridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvlerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElifEmlakDataSet = New ElifUygunEmlak.ElifEmlakDataSet()
        Me.EvlerTableAdapter = New ElifUygunEmlak.ElifEmlakDataSetTableAdapters.EvlerTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KullanicilarBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElifEmlakDataSet3 = New ElifUygunEmlak.ElifEmlakDataSet3()
        Me.ElifEmlakDataSet1 = New ElifUygunEmlak.ElifEmlakDataSet1()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New ElifUygunEmlak.ElifEmlakDataSet1TableAdapters.UsersTableAdapter()
        Me.ElifEmlakDataSet2 = New ElifUygunEmlak.ElifEmlakDataSet2()
        Me.KullanicilarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KullanicilarTableAdapter = New ElifUygunEmlak.ElifEmlakDataSet2TableAdapters.KullanicilarTableAdapter()
        Me.KullanicilarTableAdapter1 = New ElifUygunEmlak.ElifEmlakDataSet3TableAdapters.KullanicilarTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvlerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElifEmlakDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KullanicilarBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElifEmlakDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElifEmlakDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElifEmlakDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KullanicilarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(71, 195)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(292, 194)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(116, 20)
        Me.TextBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 201)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ev ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 198)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kullanıcı ID:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(71, 242)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 25)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Evi Kirala"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(990, 400)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 25)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Panele Dön"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.İdDataGridViewTextBoxColumn, Me.AdresDataGridViewTextBoxColumn, Me.MetrekareDataGridViewTextBoxColumn, Me.FiyatDataGridViewTextBoxColumn, Me.KullanicilaridDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EvlerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(14, 13)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(635, 162)
        Me.DataGridView1.TabIndex = 6
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
        Me.EvlerBindingSource.DataSource = Me.ElifEmlakDataSet
        '
        'ElifEmlakDataSet
        '
        Me.ElifEmlakDataSet.DataSetName = "ElifEmlakDataSet"
        Me.ElifEmlakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EvlerTableAdapter
        '
        Me.EvlerTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.KullanicilarBindingSource1
        Me.DataGridView2.Location = New System.Drawing.Point(40, 304)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(635, 110)
        Me.DataGridView2.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'KullanicilarBindingSource1
        '
        Me.KullanicilarBindingSource1.DataMember = "Kullanicilar"
        Me.KullanicilarBindingSource1.DataSource = Me.ElifEmlakDataSet3
        '
        'ElifEmlakDataSet3
        '
        Me.ElifEmlakDataSet3.DataSetName = "ElifEmlakDataSet3"
        Me.ElifEmlakDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ElifEmlakDataSet1
        '
        Me.ElifEmlakDataSet1.DataSetName = "ElifEmlakDataSet1"
        Me.ElifEmlakDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.ElifEmlakDataSet1
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'ElifEmlakDataSet2
        '
        Me.ElifEmlakDataSet2.DataSetName = "ElifEmlakDataSet2"
        Me.ElifEmlakDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KullanicilarBindingSource
        '
        Me.KullanicilarBindingSource.DataMember = "Kullanicilar"
        Me.KullanicilarBindingSource.DataSource = Me.ElifEmlakDataSet2
        '
        'KullanicilarTableAdapter
        '
        Me.KullanicilarTableAdapter.ClearBeforeFill = True
        '
        'KullanicilarTableAdapter1
        '
        Me.KullanicilarTableAdapter1.ClearBeforeFill = True
        '
        'AdminHireHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1092, 426)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "AdminHireHome"
        Me.Text = "AdminHireHome"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvlerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElifEmlakDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KullanicilarBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElifEmlakDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElifEmlakDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElifEmlakDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KullanicilarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ElifEmlakDataSet As ElifEmlakDataSet
    Friend WithEvents EvlerBindingSource As BindingSource
    Friend WithEvents EvlerTableAdapter As ElifEmlakDataSetTableAdapters.EvlerTableAdapter
    Friend WithEvents İdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MetrekareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FiyatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KullanicilaridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ElifEmlakDataSet1 As ElifEmlakDataSet1
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As ElifEmlakDataSet1TableAdapters.UsersTableAdapter
    Friend WithEvents ElifEmlakDataSet2 As ElifEmlakDataSet2
    Friend WithEvents KullanicilarBindingSource As BindingSource
    Friend WithEvents KullanicilarTableAdapter As ElifEmlakDataSet2TableAdapters.KullanicilarTableAdapter
    Friend WithEvents ElifEmlakDataSet3 As ElifEmlakDataSet3
    Friend WithEvents KullanicilarBindingSource1 As BindingSource
    Friend WithEvents KullanicilarTableAdapter1 As ElifEmlakDataSet3TableAdapters.KullanicilarTableAdapter
End Class

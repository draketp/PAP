<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_carros
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTG: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_carros))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonAdicionar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Lable7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtvv = New System.Windows.Forms.TextBox()
        Me.txtkms = New System.Windows.Forms.TextBox()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.txtano = New System.Windows.Forms.TextBox()
        Me.txtcor = New System.Windows.Forms.TextBox()
        Me.txtmatr = New System.Windows.Forms.TextBox()
        Me.cbtipo = New System.Windows.Forms.ComboBox()
        Me.cbcomb = New System.Windows.Forms.ComboBox()
        Me.cbesta = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.StandAutoDataSet = New FrotaAuto.StandAutoDataSet()
        Me.CarrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarrosTableAdapter = New FrotaAuto.StandAutoDataSetTableAdapters.CarrosTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.StandAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(59, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 17)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Estado"
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.Color.DarkGray
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonCancelar.Location = New System.Drawing.Point(170, 286)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 31)
        Me.ButtonCancelar.TabIndex = 86
        Me.ButtonCancelar.Text = "Limpar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'ButtonAdicionar
        '
        Me.ButtonAdicionar.BackColor = System.Drawing.Color.DarkGray
        Me.ButtonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonAdicionar.Location = New System.Drawing.Point(89, 286)
        Me.ButtonAdicionar.Name = "ButtonAdicionar"
        Me.ButtonAdicionar.Size = New System.Drawing.Size(75, 31)
        Me.ButtonAdicionar.TabIndex = 85
        Me.ButtonAdicionar.Text = "Adicionar"
        Me.ButtonAdicionar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(43, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Via verde"
        '
        'Lable7
        '
        Me.Lable7.AutoSize = True
        Me.Lable7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lable7.Location = New System.Drawing.Point(27, 188)
        Me.Lable7.Name = "Lable7"
        Me.Lable7.Size = New System.Drawing.Size(84, 17)
        Me.Lable7.TabIndex = 83
        Me.Lable7.Text = "Combustivel"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(76, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 17)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Kms"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Data Matricula"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(78, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Ano"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(75, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Tipo"
        '
        'Cor
        '
        Me.Cor.AutoSize = True
        Me.Cor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Cor.Location = New System.Drawing.Point(81, 43)
        Me.Cor.Name = "Cor"
        Me.Cor.Size = New System.Drawing.Size(30, 17)
        Me.Cor.TabIndex = 78
        Me.Cor.Text = "Cor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(46, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Matricula"
        '
        'txtvv
        '
        Me.txtvv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtvv.Location = New System.Drawing.Point(117, 245)
        Me.txtvv.Name = "txtvv"
        Me.txtvv.Size = New System.Drawing.Size(100, 23)
        Me.txtvv.TabIndex = 76
        '
        'txtkms
        '
        Me.txtkms.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtkms.Location = New System.Drawing.Point(117, 156)
        Me.txtkms.Name = "txtkms"
        Me.txtkms.Size = New System.Drawing.Size(100, 23)
        Me.txtkms.TabIndex = 74
        '
        'txtdate
        '
        Me.txtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtdate.Location = New System.Drawing.Point(117, 127)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(100, 23)
        Me.txtdate.TabIndex = 73
        '
        'txtano
        '
        Me.txtano.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtano.Location = New System.Drawing.Point(117, 98)
        Me.txtano.Name = "txtano"
        Me.txtano.Size = New System.Drawing.Size(100, 23)
        Me.txtano.TabIndex = 72
        '
        'txtcor
        '
        Me.txtcor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtcor.Location = New System.Drawing.Point(117, 40)
        Me.txtcor.Name = "txtcor"
        Me.txtcor.Size = New System.Drawing.Size(100, 23)
        Me.txtcor.TabIndex = 70
        '
        'txtmatr
        '
        Me.txtmatr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtmatr.Location = New System.Drawing.Point(117, 11)
        Me.txtmatr.Name = "txtmatr"
        Me.txtmatr.Size = New System.Drawing.Size(124, 23)
        Me.txtmatr.TabIndex = 69
        '
        'cbtipo
        '
        Me.cbtipo.FormattingEnabled = True
        Me.cbtipo.Items.AddRange(New Object() {"Ligeiro" & Global.Microsoft.VisualBasic.ChrW(9), "Pesados"})
        Me.cbtipo.Location = New System.Drawing.Point(117, 71)
        Me.cbtipo.Name = "cbtipo"
        Me.cbtipo.Size = New System.Drawing.Size(121, 21)
        Me.cbtipo.TabIndex = 91
        '
        'cbcomb
        '
        Me.cbcomb.FormattingEnabled = True
        Me.cbcomb.Items.AddRange(New Object() {"Gasolina", "Gasoleo" & Global.Microsoft.VisualBasic.ChrW(9), "Diesel" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.cbcomb.Location = New System.Drawing.Point(117, 187)
        Me.cbcomb.Name = "cbcomb"
        Me.cbcomb.Size = New System.Drawing.Size(121, 21)
        Me.cbcomb.TabIndex = 92
        '
        'cbesta
        '
        Me.cbesta.FormattingEnabled = True
        Me.cbesta.Items.AddRange(New Object() {"Novo", "Semi-Novo", "Utilizado" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.cbesta.Location = New System.Drawing.Point(117, 216)
        Me.cbesta.Name = "cbesta"
        Me.cbesta.Size = New System.Drawing.Size(121, 21)
        Me.cbesta.TabIndex = 93
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(435, 365)
        Me.TabControl1.TabIndex = 94
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cbesta)
        Me.TabPage1.Controls.Add(Me.txtmatr)
        Me.TabPage1.Controls.Add(Me.cbcomb)
        Me.TabPage1.Controls.Add(Me.txtcor)
        Me.TabPage1.Controls.Add(Me.cbtipo)
        Me.TabPage1.Controls.Add(Me.txtano)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtdate)
        Me.TabPage1.Controls.Add(Me.ButtonCancelar)
        Me.TabPage1.Controls.Add(Me.txtkms)
        Me.TabPage1.Controls.Add(Me.ButtonAdicionar)
        Me.TabPage1.Controls.Add(Me.txtvv)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Cor)
        Me.TabPage1.Controls.Add(Me.Lable7)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(427, 339)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Adicionar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.ComboBox2)
        Me.TabPage2.Controls.Add(Me.ComboBox3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.TextBox4)
        Me.TabPage2.Controls.Add(Me.TextBox5)
        Me.TabPage2.Controls.Add(Me.TextBox6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(427, 339)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Visualizar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(10, 6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(176, 303)
        Me.ListBox1.TabIndex = 135
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Novo", "Semi-Novo", "Utilizado"})
        Me.ComboBox1.Location = New System.Drawing.Point(294, 211)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 134
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Gasoleo" & Global.Microsoft.VisualBasic.ChrW(9), "Gasolina", "Diesel" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.ComboBox2.Location = New System.Drawing.Point(294, 182)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 133
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Ligeiro", "Pesado"})
        Me.ComboBox3.Location = New System.Drawing.Point(294, 66)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 132
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(236, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "Estado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(220, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 17)
        Me.Label9.TabIndex = 128
        Me.Label9.Text = "Via verde"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(204, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 17)
        Me.Label10.TabIndex = 127
        Me.Label10.Text = "Combustivel"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(253, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 17)
        Me.Label11.TabIndex = 126
        Me.Label11.Text = "Kms"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(189, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 17)
        Me.Label12.TabIndex = 125
        Me.Label12.Text = "Data Matricula"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(255, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 17)
        Me.Label13.TabIndex = 124
        Me.Label13.Text = "Ano"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(252, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 17)
        Me.Label14.TabIndex = 123
        Me.Label14.Text = "Tipo"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(258, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 17)
        Me.Label15.TabIndex = 122
        Me.Label15.Text = "Cor"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(223, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 17)
        Me.Label16.TabIndex = 121
        Me.Label16.Text = "Matricula"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(294, 240)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 120
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox2.Location = New System.Drawing.Point(294, 151)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 119
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox3.Location = New System.Drawing.Point(294, 122)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 23)
        Me.TextBox3.TabIndex = 118
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox4.Location = New System.Drawing.Point(294, 93)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 23)
        Me.TextBox4.TabIndex = 117
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox5.Location = New System.Drawing.Point(294, 35)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 23)
        Me.TextBox5.TabIndex = 116
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox6.Location = New System.Drawing.Point(294, 6)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(124, 23)
        Me.TextBox6.TabIndex = 115
        '
        'StandAutoDataSet
        '
        Me.StandAutoDataSet.DataSetName = "StandAutoDataSet"
        Me.StandAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CarrosBindingSource
        '
        Me.CarrosBindingSource.DataMember = "Carros"
        Me.CarrosBindingSource.DataSource = Me.StandAutoDataSet
        '
        'CarrosTableAdapter
        '
        Me.CarrosTableAdapter.ClearBeforeFill = True
        '
        'Add_carros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 412)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Add_carros"
        Me.Text = "Adicionar Carros"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.StandAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents ButtonAdicionar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Lable7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Cor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtvv As TextBox
    Friend WithEvents txtkms As TextBox
    Friend WithEvents txtdate As TextBox
    Friend WithEvents txtano As TextBox
    Friend WithEvents txtcor As TextBox
    Friend WithEvents txtmatr As TextBox
    Friend WithEvents cbtipo As ComboBox
    Friend WithEvents cbcomb As ComboBox
    Friend WithEvents cbesta As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents StandAutoDataSet As StandAutoDataSet
    Friend WithEvents CarrosBindingSource As BindingSource
    Friend WithEvents CarrosTableAdapter As StandAutoDataSetTableAdapters.CarrosTableAdapter
End Class

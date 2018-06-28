<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Material
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Material))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtcod2 = New System.Windows.Forms.TextBox()
        Me.cbmatr2 = New System.Windows.Forms.ComboBox()
        Me.CarrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StandAutoDataSet = New FrotaAuto.StandAutoDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonAdicionar = New System.Windows.Forms.Button()
        Me.cbextintor2 = New System.Windows.Forms.ComboBox()
        Me.cbsos2 = New System.Windows.Forms.ComboBox()
        Me.cbcolete2 = New System.Windows.Forms.ComboBox()
        Me.cbtrian2 = New System.Windows.Forms.ComboBox()
        Me.cbmaca2 = New System.Windows.Forms.ComboBox()
        Me.cbpneu2 = New System.Windows.Forms.ComboBox()
        Me.cbant2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbrad2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtdate2 = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.cbextintor = New System.Windows.Forms.ComboBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.cbsos = New System.Windows.Forms.ComboBox()
        Me.txtmatr = New System.Windows.Forms.TextBox()
        Me.cbcolete = New System.Windows.Forms.ComboBox()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.cbtrian = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbmaca = New System.Windows.Forms.ComboBox()
        Me.Data = New System.Windows.Forms.Label()
        Me.cbpneu = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbant = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbrad = New System.Windows.Forms.ComboBox()
        Me.Lable7 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MaterialTableAdapter = New FrotaAuto.StandAutoDataSetTableAdapters.MateriaisTableAdapter()
        Me.TableAdapterManager = New FrotaAuto.StandAutoDataSetTableAdapters.TableAdapterManager()
        Me.StandAutoDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarrosTableAdapter = New FrotaAuto.StandAutoDataSetTableAdapters.CarrosTableAdapter()
        Me.CarrosTableAdapter1 = New FrotaAuto.StandAutoDataSetTableAdapters.CarrosTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.CarrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StandAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.StandAutoDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(657, 360)
        Me.TabControl1.TabIndex = 95
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.txtcod2)
        Me.TabPage2.Controls.Add(Me.cbmatr2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.ButtonAdicionar)
        Me.TabPage2.Controls.Add(Me.cbextintor2)
        Me.TabPage2.Controls.Add(Me.cbsos2)
        Me.TabPage2.Controls.Add(Me.cbcolete2)
        Me.TabPage2.Controls.Add(Me.cbtrian2)
        Me.TabPage2.Controls.Add(Me.cbmaca2)
        Me.TabPage2.Controls.Add(Me.cbpneu2)
        Me.TabPage2.Controls.Add(Me.cbant2)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.cbrad2)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.txtdate2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(649, 334)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Adicionar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label19.Location = New System.Drawing.Point(62, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 17)
        Me.Label19.TabIndex = 162
        Me.Label19.Text = "Codigo"
        '
        'txtcod2
        '
        Me.txtcod2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtcod2.Location = New System.Drawing.Point(120, 13)
        Me.txtcod2.Name = "txtcod2"
        Me.txtcod2.Size = New System.Drawing.Size(100, 23)
        Me.txtcod2.TabIndex = 161
        '
        'cbmatr2
        '
        Me.cbmatr2.DataSource = Me.CarrosBindingSource
        Me.cbmatr2.DisplayMember = "Matricula"
        Me.cbmatr2.FormattingEnabled = True
        Me.cbmatr2.Location = New System.Drawing.Point(120, 45)
        Me.cbmatr2.Name = "cbmatr2"
        Me.cbmatr2.Size = New System.Drawing.Size(100, 21)
        Me.cbmatr2.TabIndex = 160
        '
        'CarrosBindingSource
        '
        Me.CarrosBindingSource.DataMember = "Carros"
        Me.CarrosBindingSource.DataSource = Me.StandAutoDataSet
        '
        'StandAutoDataSet
        '
        Me.StandAutoDataSet.DataSetName = "StandAutoDataSet"
        Me.StandAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(226, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 159
        Me.Button1.Text = "Limpar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ButtonAdicionar
        '
        Me.ButtonAdicionar.BackColor = System.Drawing.Color.DarkGray
        Me.ButtonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonAdicionar.Location = New System.Drawing.Point(145, 245)
        Me.ButtonAdicionar.Name = "ButtonAdicionar"
        Me.ButtonAdicionar.Size = New System.Drawing.Size(75, 31)
        Me.ButtonAdicionar.TabIndex = 158
        Me.ButtonAdicionar.Text = "Adicionar"
        Me.ButtonAdicionar.UseVisualStyleBackColor = False
        '
        'cbextintor2
        '
        Me.cbextintor2.FormattingEnabled = True
        Me.cbextintor2.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbextintor2.Location = New System.Drawing.Point(358, 160)
        Me.cbextintor2.Name = "cbextintor2"
        Me.cbextintor2.Size = New System.Drawing.Size(100, 21)
        Me.cbextintor2.TabIndex = 157
        '
        'cbsos2
        '
        Me.cbsos2.FormattingEnabled = True
        Me.cbsos2.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbsos2.Location = New System.Drawing.Point(358, 130)
        Me.cbsos2.Name = "cbsos2"
        Me.cbsos2.Size = New System.Drawing.Size(100, 21)
        Me.cbsos2.TabIndex = 156
        '
        'cbcolete2
        '
        Me.cbcolete2.FormattingEnabled = True
        Me.cbcolete2.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbcolete2.Location = New System.Drawing.Point(358, 102)
        Me.cbcolete2.Name = "cbcolete2"
        Me.cbcolete2.Size = New System.Drawing.Size(100, 21)
        Me.cbcolete2.TabIndex = 155
        '
        'cbtrian2
        '
        Me.cbtrian2.FormattingEnabled = True
        Me.cbtrian2.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbtrian2.Location = New System.Drawing.Point(358, 73)
        Me.cbtrian2.Name = "cbtrian2"
        Me.cbtrian2.Size = New System.Drawing.Size(100, 21)
        Me.cbtrian2.TabIndex = 154
        '
        'cbmaca2
        '
        Me.cbmaca2.FormattingEnabled = True
        Me.cbmaca2.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbmaca2.Location = New System.Drawing.Point(120, 192)
        Me.cbmaca2.Name = "cbmaca2"
        Me.cbmaca2.Size = New System.Drawing.Size(100, 21)
        Me.cbmaca2.TabIndex = 153
        '
        'cbpneu2
        '
        Me.cbpneu2.FormattingEnabled = True
        Me.cbpneu2.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbpneu2.Location = New System.Drawing.Point(120, 160)
        Me.cbpneu2.Name = "cbpneu2"
        Me.cbpneu2.Size = New System.Drawing.Size(100, 21)
        Me.cbpneu2.TabIndex = 152
        '
        'cbant2
        '
        Me.cbant2.FormattingEnabled = True
        Me.cbant2.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbant2.Location = New System.Drawing.Point(120, 131)
        Me.cbant2.Name = "cbant2"
        Me.cbant2.Size = New System.Drawing.Size(100, 21)
        Me.cbant2.TabIndex = 151
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(297, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Extintor"
        '
        'cbrad2
        '
        Me.cbrad2.FormattingEnabled = True
        Me.cbrad2.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbrad2.Location = New System.Drawing.Point(120, 103)
        Me.cbrad2.Name = "cbrad2"
        Me.cbrad2.Size = New System.Drawing.Size(100, 21)
        Me.cbrad2.TabIndex = 149
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(250, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 17)
        Me.Label9.TabIndex = 148
        Me.Label9.Text = "Colete Refletor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(236, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 17)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "Caixa de Socorro"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(284, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 17)
        Me.Label11.TabIndex = 144
        Me.Label11.Text = "Triangulo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(57, 196)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 17)
        Me.Label12.TabIndex = 143
        Me.Label12.Text = "Macaco"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(13, 161)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 17)
        Me.Label13.TabIndex = 142
        Me.Label13.Text = "Pneu Suplente"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(61, 132)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 17)
        Me.Label14.TabIndex = 141
        Me.Label14.Text = "Antena"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(69, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 17)
        Me.Label15.TabIndex = 140
        Me.Label15.Text = "Radio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(76, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 17)
        Me.Label16.TabIndex = 139
        Me.Label16.Text = "Data"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label18.Location = New System.Drawing.Point(49, 45)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 17)
        Me.Label18.TabIndex = 138
        Me.Label18.Text = "Matricula"
        '
        'txtdate2
        '
        Me.txtdate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtdate2.Location = New System.Drawing.Point(120, 71)
        Me.txtdate2.Name = "txtdate2"
        Me.txtdate2.Size = New System.Drawing.Size(100, 23)
        Me.txtdate2.TabIndex = 137
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.txtcod)
        Me.TabPage1.Controls.Add(Me.cbextintor)
        Me.TabPage1.Controls.Add(Me.ListBox2)
        Me.TabPage1.Controls.Add(Me.cbsos)
        Me.TabPage1.Controls.Add(Me.txtmatr)
        Me.TabPage1.Controls.Add(Me.cbcolete)
        Me.TabPage1.Controls.Add(Me.txtdate)
        Me.TabPage1.Controls.Add(Me.cbtrian)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cbmaca)
        Me.TabPage1.Controls.Add(Me.Data)
        Me.TabPage1.Controls.Add(Me.cbpneu)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cbant)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.cbrad)
        Me.TabPage1.Controls.Add(Me.Lable7)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(649, 334)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Visualizar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label20.Location = New System.Drawing.Point(244, 6)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 17)
        Me.Label20.TabIndex = 164
        Me.Label20.Text = "Codigo"
        '
        'txtcod
        '
        Me.txtcod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtcod.Location = New System.Drawing.Point(302, 3)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(100, 23)
        Me.txtcod.TabIndex = 163
        '
        'cbextintor
        '
        Me.cbextintor.FormattingEnabled = True
        Me.cbextintor.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbextintor.Location = New System.Drawing.Point(541, 154)
        Me.cbextintor.Name = "cbextintor"
        Me.cbextintor.Size = New System.Drawing.Size(100, 21)
        Me.cbextintor.TabIndex = 145
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(15, 6)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(176, 303)
        Me.ListBox2.TabIndex = 137
        '
        'cbsos
        '
        Me.cbsos.FormattingEnabled = True
        Me.cbsos.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbsos.Location = New System.Drawing.Point(541, 124)
        Me.cbsos.Name = "cbsos"
        Me.cbsos.Size = New System.Drawing.Size(100, 21)
        Me.cbsos.TabIndex = 144
        '
        'txtmatr
        '
        Me.txtmatr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtmatr.Location = New System.Drawing.Point(303, 36)
        Me.txtmatr.Name = "txtmatr"
        Me.txtmatr.Size = New System.Drawing.Size(100, 23)
        Me.txtmatr.TabIndex = 123
        '
        'cbcolete
        '
        Me.cbcolete.FormattingEnabled = True
        Me.cbcolete.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbcolete.Location = New System.Drawing.Point(541, 96)
        Me.cbcolete.Name = "cbcolete"
        Me.cbcolete.Size = New System.Drawing.Size(100, 21)
        Me.cbcolete.TabIndex = 143
        '
        'txtdate
        '
        Me.txtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtdate.Location = New System.Drawing.Point(303, 65)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(100, 23)
        Me.txtdate.TabIndex = 124
        '
        'cbtrian
        '
        Me.cbtrian.FormattingEnabled = True
        Me.cbtrian.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbtrian.Location = New System.Drawing.Point(541, 67)
        Me.cbtrian.Name = "cbtrian"
        Me.cbtrian.Size = New System.Drawing.Size(100, 21)
        Me.cbtrian.TabIndex = 142
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(232, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Matricula"
        '
        'cbmaca
        '
        Me.cbmaca.FormattingEnabled = True
        Me.cbmaca.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbmaca.Location = New System.Drawing.Point(303, 186)
        Me.cbmaca.Name = "cbmaca"
        Me.cbmaca.Size = New System.Drawing.Size(100, 21)
        Me.cbmaca.TabIndex = 141
        '
        'Data
        '
        Me.Data.AutoSize = True
        Me.Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Data.Location = New System.Drawing.Point(259, 68)
        Me.Data.Name = "Data"
        Me.Data.Size = New System.Drawing.Size(38, 17)
        Me.Data.TabIndex = 126
        Me.Data.Text = "Data"
        '
        'cbpneu
        '
        Me.cbpneu.FormattingEnabled = True
        Me.cbpneu.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbpneu.Location = New System.Drawing.Point(303, 154)
        Me.cbpneu.Name = "cbpneu"
        Me.cbpneu.Size = New System.Drawing.Size(100, 21)
        Me.cbpneu.TabIndex = 140
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(252, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Radio"
        '
        'cbant
        '
        Me.cbant.FormattingEnabled = True
        Me.cbant.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbant.Location = New System.Drawing.Point(303, 125)
        Me.cbant.Name = "cbant"
        Me.cbant.Size = New System.Drawing.Size(100, 21)
        Me.cbant.TabIndex = 139
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(244, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Antena"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(480, 158)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 17)
        Me.Label17.TabIndex = 138
        Me.Label17.Text = "Extintor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(196, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Pneu Suplente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(240, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "Macaco"
        '
        'cbrad
        '
        Me.cbrad.FormattingEnabled = True
        Me.cbrad.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbrad.Location = New System.Drawing.Point(303, 97)
        Me.cbrad.Name = "cbrad"
        Me.cbrad.Size = New System.Drawing.Size(100, 21)
        Me.cbrad.TabIndex = 136
        '
        'Lable7
        '
        Me.Lable7.AutoSize = True
        Me.Lable7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lable7.Location = New System.Drawing.Point(467, 68)
        Me.Lable7.Name = "Lable7"
        Me.Lable7.Size = New System.Drawing.Size(68, 17)
        Me.Lable7.TabIndex = 131
        Me.Lable7.Text = "Triangulo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(433, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Colete Refletor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(419, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 17)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "Caixa de Socorro"
        '
        'MaterialTableAdapter
        '
        Me.MaterialTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbastecimentoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarrosTableAdapter = Nothing
        Me.TableAdapterManager.MateriaisTableAdapter = Me.MaterialTableAdapter
        Me.TableAdapterManager.MotoristasTableAdapter = Nothing
        Me.TableAdapterManager.RevisoesTableAdapter = Nothing
        Me.TableAdapterManager.SeguroTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FrotaAuto.StandAutoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Log_tableTableAdapter = Nothing
        '
        'StandAutoDataSetBindingSource
        '
        Me.StandAutoDataSetBindingSource.DataSource = Me.StandAutoDataSet
        Me.StandAutoDataSetBindingSource.Position = 0
        '
        'CarrosTableAdapter
        '
        Me.CarrosTableAdapter.ClearBeforeFill = True
        '
        'CarrosTableAdapter1
        '
        Me.CarrosTableAdapter1.ClearBeforeFill = True
        '
        'Add_Material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 383)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Add_Material"
        Me.Text = "Adicionar Material"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.CarrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StandAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.StandAutoDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cbextintor As ComboBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents cbsos As ComboBox
    Friend WithEvents txtmatr As TextBox
    Friend WithEvents cbcolete As ComboBox
    Friend WithEvents txtdate As TextBox
    Friend WithEvents cbtrian As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbmaca As ComboBox
    Friend WithEvents Data As Label
    Friend WithEvents cbpneu As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbant As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbrad As ComboBox
    Friend WithEvents Lable7 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents StandAutoDataSet As StandAutoDataSet
    Friend WithEvents MaterialTableAdapter As StandAutoDataSetTableAdapters.MateriaisTableAdapter
    Friend WithEvents TableAdapterManager As StandAutoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents cbextintor2 As ComboBox
    Friend WithEvents cbsos2 As ComboBox
    Friend WithEvents cbcolete2 As ComboBox
    Friend WithEvents cbtrian2 As ComboBox
    Friend WithEvents cbmaca2 As ComboBox
    Friend WithEvents cbpneu2 As ComboBox
    Friend WithEvents cbant2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbrad2 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtdate2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonAdicionar As Button
    Friend WithEvents cbmatr2 As ComboBox
    Friend WithEvents StandAutoDataSetBindingSource As BindingSource
    Friend WithEvents CarrosBindingSource As BindingSource
    Friend WithEvents CarrosTableAdapter As StandAutoDataSetTableAdapters.CarrosTableAdapter
    Friend WithEvents CarrosTableAdapter1 As StandAutoDataSetTableAdapters.CarrosTableAdapter
    Friend WithEvents Label19 As Label
    Friend WithEvents txtcod2 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtcod As TextBox
End Class

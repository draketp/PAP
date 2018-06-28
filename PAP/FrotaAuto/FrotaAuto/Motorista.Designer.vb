<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Motorista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Motorista))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonAdicionar = New System.Windows.Forms.Button()
        Me.txtvalidade = New System.Windows.Forms.TextBox()
        Me.txtlocalcarta = New System.Windows.Forms.TextBox()
        Me.txtncarta = New System.Windows.Forms.TextBox()
        Me.txtvencimento = New System.Windows.Forms.TextBox()
        Me.txtnascimento = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txttel = New System.Windows.Forms.TextBox()
        Me.txtpostal = New System.Windows.Forms.TextBox()
        Me.txtlocal = New System.Windows.Forms.TextBox()
        Me.txtmorada = New System.Windows.Forms.TextBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.StandAutoDataSet = New FrotaAuto.StandAutoDataSet()
        Me.MotoristasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MotoristasTableAdapter = New FrotaAuto.StandAutoDataSetTableAdapters.MotoristasTableAdapter()
        Me.TableAdapterManager = New FrotaAuto.StandAutoDataSetTableAdapters.TableAdapterManager()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.StandAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotoristasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(532, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Novo Gasto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(532, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Gastos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(532, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(495, 361)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.ButtonCancelar)
        Me.TabPage1.Controls.Add(Me.ButtonAdicionar)
        Me.TabPage1.Controls.Add(Me.txtvalidade)
        Me.TabPage1.Controls.Add(Me.txtlocalcarta)
        Me.TabPage1.Controls.Add(Me.txtncarta)
        Me.TabPage1.Controls.Add(Me.txtvencimento)
        Me.TabPage1.Controls.Add(Me.txtnascimento)
        Me.TabPage1.Controls.Add(Me.txtemail)
        Me.TabPage1.Controls.Add(Me.txttel)
        Me.TabPage1.Controls.Add(Me.txtpostal)
        Me.TabPage1.Controls.Add(Me.txtlocal)
        Me.TabPage1.Controls.Add(Me.txtmorada)
        Me.TabPage1.Controls.Add(Me.txtnome)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(487, 335)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Principais"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(40, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(59, 20)
        Me.TextBox1.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "ID"
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Location = New System.Drawing.Point(382, 214)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(99, 36)
        Me.ButtonCancelar.TabIndex = 29
        Me.ButtonCancelar.Text = "Limpar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'ButtonAdicionar
        '
        Me.ButtonAdicionar.Location = New System.Drawing.Point(268, 214)
        Me.ButtonAdicionar.Name = "ButtonAdicionar"
        Me.ButtonAdicionar.Size = New System.Drawing.Size(99, 36)
        Me.ButtonAdicionar.TabIndex = 28
        Me.ButtonAdicionar.Text = "Adicionar"
        Me.ButtonAdicionar.UseVisualStyleBackColor = True
        '
        'txtvalidade
        '
        Me.txtvalidade.Location = New System.Drawing.Point(142, 306)
        Me.txtvalidade.Name = "txtvalidade"
        Me.txtvalidade.Size = New System.Drawing.Size(100, 20)
        Me.txtvalidade.TabIndex = 26
        '
        'txtlocalcarta
        '
        Me.txtlocalcarta.Location = New System.Drawing.Point(142, 280)
        Me.txtlocalcarta.Name = "txtlocalcarta"
        Me.txtlocalcarta.Size = New System.Drawing.Size(100, 20)
        Me.txtlocalcarta.TabIndex = 25
        '
        'txtncarta
        '
        Me.txtncarta.Location = New System.Drawing.Point(142, 254)
        Me.txtncarta.Name = "txtncarta"
        Me.txtncarta.Size = New System.Drawing.Size(100, 20)
        Me.txtncarta.TabIndex = 24
        '
        'txtvencimento
        '
        Me.txtvencimento.Location = New System.Drawing.Point(86, 223)
        Me.txtvencimento.Name = "txtvencimento"
        Me.txtvencimento.Size = New System.Drawing.Size(100, 20)
        Me.txtvencimento.TabIndex = 23
        '
        'txtnascimento
        '
        Me.txtnascimento.Location = New System.Drawing.Point(125, 193)
        Me.txtnascimento.Name = "txtnascimento"
        Me.txtnascimento.Size = New System.Drawing.Size(100, 20)
        Me.txtnascimento.TabIndex = 22
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(57, 169)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(117, 20)
        Me.txtemail.TabIndex = 19
        '
        'txttel
        '
        Me.txttel.Location = New System.Drawing.Point(70, 138)
        Me.txttel.MaxLength = 9
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(100, 20)
        Me.txttel.TabIndex = 18
        '
        'txtpostal
        '
        Me.txtpostal.Location = New System.Drawing.Point(70, 109)
        Me.txtpostal.Name = "txtpostal"
        Me.txtpostal.Size = New System.Drawing.Size(378, 20)
        Me.txtpostal.TabIndex = 17
        '
        'txtlocal
        '
        Me.txtlocal.Location = New System.Drawing.Point(70, 80)
        Me.txtlocal.Name = "txtlocal"
        Me.txtlocal.Size = New System.Drawing.Size(378, 20)
        Me.txtlocal.TabIndex = 16
        '
        'txtmorada
        '
        Me.txtmorada.Location = New System.Drawing.Point(57, 51)
        Me.txtmorada.Name = "txtmorada"
        Me.txtmorada.Size = New System.Drawing.Size(391, 20)
        Me.txtmorada.TabIndex = 15
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(57, 26)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(391, 20)
        Me.txtnome.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 309)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Ano de Validade da Carta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(34, 283)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Localidade da Carta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 257)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Nº de Carta de Condução"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Vencimento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Data de Nascimento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "E-Mail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telefone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cód.Postal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Localidade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Morada"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.TextBox4)
        Me.TabPage2.Controls.Add(Me.TextBox5)
        Me.TabPage2.Controls.Add(Me.TextBox6)
        Me.TabPage2.Controls.Add(Me.TextBox7)
        Me.TabPage2.Controls.Add(Me.TextBox8)
        Me.TabPage2.Controls.Add(Me.TextBox9)
        Me.TabPage2.Controls.Add(Me.TextBox10)
        Me.TabPage2.Controls.Add(Me.TextBox11)
        Me.TabPage2.Controls.Add(Me.TextBox12)
        Me.TabPage2.Controls.Add(Me.TextBox13)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(487, 335)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Visualizar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(372, 139)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(92, 186)
        Me.ListBox1.TabIndex = 60
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(56, 6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(59, 20)
        Me.TextBox2.TabIndex = 59
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 13)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "ID"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(158, 309)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 54
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(158, 283)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 53
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(158, 257)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 52
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(102, 226)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 51
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(141, 196)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 50
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(73, 172)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(117, 20)
        Me.TextBox8.TabIndex = 49
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(86, 141)
        Me.TextBox9.MaxLength = 9
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 48
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(86, 112)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(378, 20)
        Me.TextBox10.TabIndex = 47
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(86, 83)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(378, 20)
        Me.TextBox11.TabIndex = 46
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(73, 54)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(391, 20)
        Me.TextBox12.TabIndex = 45
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(73, 29)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(391, 20)
        Me.TextBox13.TabIndex = 44
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 312)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 13)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Ano de Validade da Carta"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(50, 286)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 13)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Localidade da Carta"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(30, 260)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(129, 13)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Nº de Carta de Condução"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(33, 229)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 13)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Vencimento"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(31, 199)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 13)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Data de Nascimento"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(31, 175)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 13)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "E-Mail"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(31, 146)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(49, 13)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "Telefone"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(22, 115)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 13)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "Cód.Postal"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(24, 86)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 13)
        Me.Label24.TabIndex = 34
        Me.Label24.Text = "Localidade"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(24, 57)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 13)
        Me.Label25.TabIndex = 33
        Me.Label25.Text = "Morada"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(32, 29)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(35, 13)
        Me.Label26.TabIndex = 32
        Me.Label26.Text = "Nome"
        '
        'StandAutoDataSet
        '
        Me.StandAutoDataSet.DataSetName = "StandAutoDataSet"
        Me.StandAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MotoristasBindingSource
        '
        Me.MotoristasBindingSource.DataMember = "Motoristas"
        Me.MotoristasBindingSource.DataSource = Me.StandAutoDataSet
        '
        'MotoristasTableAdapter
        '
        Me.MotoristasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbastecimentoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarrosTableAdapter = Nothing
        Me.TableAdapterManager.MateriaisTableAdapter = Nothing
        Me.TableAdapterManager.MotoristasTableAdapter = Me.MotoristasTableAdapter
        Me.TableAdapterManager.RevisoesTableAdapter = Nothing
        Me.TableAdapterManager.SeguroTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FrotaAuto.StandAutoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Log_tableTableAdapter = Nothing
        '
        'Motorista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 378)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Motorista"
        Me.Text = "Motorista"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.StandAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotoristasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtvalidade As TextBox
    Friend WithEvents txtlocalcarta As TextBox
    Friend WithEvents txtncarta As TextBox
    Friend WithEvents txtvencimento As TextBox
    Friend WithEvents txtnascimento As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txttel As TextBox
    Friend WithEvents txtpostal As TextBox
    Friend WithEvents txtlocal As TextBox
    Friend WithEvents txtmorada As TextBox
    Friend WithEvents txtnome As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonAdicionar As Button
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents StandAutoDataSet As StandAutoDataSet
    Friend WithEvents MotoristasBindingSource As BindingSource
    Friend WithEvents MotoristasTableAdapter As StandAutoDataSetTableAdapters.MotoristasTableAdapter
    Friend WithEvents TableAdapterManager As StandAutoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ListBox1 As ListBox
End Class

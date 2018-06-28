<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mateirais
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTG: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mateirais))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.cbextintor = New System.Windows.Forms.ComboBox()
        Me.cbsos = New System.Windows.Forms.ComboBox()
        Me.cbcolete = New System.Windows.Forms.ComboBox()
        Me.cbtrian = New System.Windows.Forms.ComboBox()
        Me.cbmaca = New System.Windows.Forms.ComboBox()
        Me.cbpneu = New System.Windows.Forms.ComboBox()
        Me.cbant = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.cbrad = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonAdicionar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Lable7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Data = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.txtmatr = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtcod2 = New System.Windows.Forms.TextBox()
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
        Me.txtmatr2 = New System.Windows.Forms.TextBox()
        Me.ButtonRemover = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.StandAutoDataSet = New FrotaAuto.StandAutoDataSet()
        Me.MaterialTableAdapter = New FrotaAuto.StandAutoDataSetTableAdapters.MateriaisTableAdapter()
        Me.TableAdapterManager = New FrotaAuto.StandAutoDataSetTableAdapters.TableAdapterManager()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.StandAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(649, 380)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.txtcod)
        Me.TabPage1.Controls.Add(Me.cbextintor)
        Me.TabPage1.Controls.Add(Me.cbsos)
        Me.TabPage1.Controls.Add(Me.cbcolete)
        Me.TabPage1.Controls.Add(Me.cbtrian)
        Me.TabPage1.Controls.Add(Me.cbmaca)
        Me.TabPage1.Controls.Add(Me.cbpneu)
        Me.TabPage1.Controls.Add(Me.cbant)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.cbrad)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.ButtonCancelar)
        Me.TabPage1.Controls.Add(Me.ButtonAdicionar)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Lable7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Data)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtdate)
        Me.TabPage1.Controls.Add(Me.txtmatr)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(641, 354)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Alterar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label20.Location = New System.Drawing.Point(229, 31)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 17)
        Me.Label20.TabIndex = 166
        Me.Label20.Text = "Codigo"
        '
        'txtcod
        '
        Me.txtcod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtcod.Location = New System.Drawing.Point(287, 28)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(100, 23)
        Me.txtcod.TabIndex = 165
        '
        'cbextintor
        '
        Me.cbextintor.FormattingEnabled = True
        Me.cbextintor.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbextintor.Location = New System.Drawing.Point(526, 145)
        Me.cbextintor.Name = "cbextintor"
        Me.cbextintor.Size = New System.Drawing.Size(100, 21)
        Me.cbextintor.TabIndex = 122
        '
        'cbsos
        '
        Me.cbsos.FormattingEnabled = True
        Me.cbsos.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbsos.Location = New System.Drawing.Point(526, 115)
        Me.cbsos.Name = "cbsos"
        Me.cbsos.Size = New System.Drawing.Size(100, 21)
        Me.cbsos.TabIndex = 121
        '
        'cbcolete
        '
        Me.cbcolete.FormattingEnabled = True
        Me.cbcolete.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbcolete.Location = New System.Drawing.Point(526, 87)
        Me.cbcolete.Name = "cbcolete"
        Me.cbcolete.Size = New System.Drawing.Size(100, 21)
        Me.cbcolete.TabIndex = 120
        '
        'cbtrian
        '
        Me.cbtrian.FormattingEnabled = True
        Me.cbtrian.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbtrian.Location = New System.Drawing.Point(526, 58)
        Me.cbtrian.Name = "cbtrian"
        Me.cbtrian.Size = New System.Drawing.Size(100, 21)
        Me.cbtrian.TabIndex = 119
        '
        'cbmaca
        '
        Me.cbmaca.FormattingEnabled = True
        Me.cbmaca.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbmaca.Location = New System.Drawing.Point(288, 213)
        Me.cbmaca.Name = "cbmaca"
        Me.cbmaca.Size = New System.Drawing.Size(100, 21)
        Me.cbmaca.TabIndex = 118
        '
        'cbpneu
        '
        Me.cbpneu.FormattingEnabled = True
        Me.cbpneu.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbpneu.Location = New System.Drawing.Point(288, 181)
        Me.cbpneu.Name = "cbpneu"
        Me.cbpneu.Size = New System.Drawing.Size(100, 21)
        Me.cbpneu.TabIndex = 117
        '
        'cbant
        '
        Me.cbant.FormattingEnabled = True
        Me.cbant.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbant.Location = New System.Drawing.Point(288, 152)
        Me.cbant.Name = "cbant"
        Me.cbant.Size = New System.Drawing.Size(100, 21)
        Me.cbant.TabIndex = 116
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(465, 149)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 17)
        Me.Label17.TabIndex = 115
        Me.Label17.Text = "Extintor"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(176, 303)
        Me.ListBox1.TabIndex = 114
        '
        'cbrad
        '
        Me.cbrad.FormattingEnabled = True
        Me.cbrad.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbrad.Location = New System.Drawing.Point(288, 124)
        Me.cbrad.Name = "cbrad"
        Me.cbrad.Size = New System.Drawing.Size(100, 21)
        Me.cbrad.TabIndex = 111
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(418, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Colete Refletor"
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.Color.DarkGray
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonCancelar.Location = New System.Drawing.Point(393, 249)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 31)
        Me.ButtonCancelar.TabIndex = 109
        Me.ButtonCancelar.Text = "Limpar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'ButtonAdicionar
        '
        Me.ButtonAdicionar.BackColor = System.Drawing.Color.DarkGray
        Me.ButtonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonAdicionar.Location = New System.Drawing.Point(312, 249)
        Me.ButtonAdicionar.Name = "ButtonAdicionar"
        Me.ButtonAdicionar.Size = New System.Drawing.Size(75, 31)
        Me.ButtonAdicionar.TabIndex = 108
        Me.ButtonAdicionar.Text = "Alterar"
        Me.ButtonAdicionar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(404, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 17)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Caixa de Socorro"
        '
        'Lable7
        '
        Me.Lable7.AutoSize = True
        Me.Lable7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lable7.Location = New System.Drawing.Point(452, 59)
        Me.Lable7.Name = "Lable7"
        Me.Lable7.Size = New System.Drawing.Size(68, 17)
        Me.Lable7.TabIndex = 106
        Me.Lable7.Text = "Triangulo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(225, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Macaco"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(181, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Pneu Suplente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(229, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Antena"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(237, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Radio"
        '
        'Data
        '
        Me.Data.AutoSize = True
        Me.Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Data.Location = New System.Drawing.Point(244, 95)
        Me.Data.Name = "Data"
        Me.Data.Size = New System.Drawing.Size(38, 17)
        Me.Data.TabIndex = 101
        Me.Data.Text = "Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(217, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Matricula"
        '
        'txtdate
        '
        Me.txtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtdate.Location = New System.Drawing.Point(288, 92)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(100, 23)
        Me.txtdate.TabIndex = 97
        '
        'txtmatr
        '
        Me.txtmatr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtmatr.Location = New System.Drawing.Point(288, 63)
        Me.txtmatr.Name = "txtmatr"
        Me.txtmatr.Size = New System.Drawing.Size(100, 23)
        Me.txtmatr.TabIndex = 94
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.txtcod2)
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
        Me.TabPage2.Controls.Add(Me.txtmatr2)
        Me.TabPage2.Controls.Add(Me.ButtonRemover)
        Me.TabPage2.Controls.Add(Me.ListBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(641, 354)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Remover"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label19.Location = New System.Drawing.Point(229, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 17)
        Me.Label19.TabIndex = 166
        Me.Label19.Text = "Codigo"
        '
        'txtcod2
        '
        Me.txtcod2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtcod2.Location = New System.Drawing.Point(288, 31)
        Me.txtcod2.Name = "txtcod2"
        Me.txtcod2.Size = New System.Drawing.Size(100, 23)
        Me.txtcod2.TabIndex = 165
        '
        'cbextintor2
        '
        Me.cbextintor2.FormattingEnabled = True
        Me.cbextintor2.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbextintor2.Location = New System.Drawing.Point(531, 135)
        Me.cbextintor2.Name = "cbextintor2"
        Me.cbextintor2.Size = New System.Drawing.Size(100, 21)
        Me.cbextintor2.TabIndex = 144
        '
        'cbsos2
        '
        Me.cbsos2.FormattingEnabled = True
        Me.cbsos2.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbsos2.Location = New System.Drawing.Point(531, 105)
        Me.cbsos2.Name = "cbsos2"
        Me.cbsos2.Size = New System.Drawing.Size(100, 21)
        Me.cbsos2.TabIndex = 143
        '
        'cbcolete2
        '
        Me.cbcolete2.FormattingEnabled = True
        Me.cbcolete2.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbcolete2.Location = New System.Drawing.Point(531, 77)
        Me.cbcolete2.Name = "cbcolete2"
        Me.cbcolete2.Size = New System.Drawing.Size(100, 21)
        Me.cbcolete2.TabIndex = 142
        '
        'cbtrian2
        '
        Me.cbtrian2.FormattingEnabled = True
        Me.cbtrian2.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbtrian2.Location = New System.Drawing.Point(531, 48)
        Me.cbtrian2.Name = "cbtrian2"
        Me.cbtrian2.Size = New System.Drawing.Size(100, 21)
        Me.cbtrian2.TabIndex = 141
        '
        'cbmaca2
        '
        Me.cbmaca2.FormattingEnabled = True
        Me.cbmaca2.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbmaca2.Location = New System.Drawing.Point(288, 211)
        Me.cbmaca2.Name = "cbmaca2"
        Me.cbmaca2.Size = New System.Drawing.Size(100, 21)
        Me.cbmaca2.TabIndex = 140
        '
        'cbpneu2
        '
        Me.cbpneu2.FormattingEnabled = True
        Me.cbpneu2.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbpneu2.Location = New System.Drawing.Point(288, 179)
        Me.cbpneu2.Name = "cbpneu2"
        Me.cbpneu2.Size = New System.Drawing.Size(100, 21)
        Me.cbpneu2.TabIndex = 139
        '
        'cbant2
        '
        Me.cbant2.FormattingEnabled = True
        Me.cbant2.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbant2.Location = New System.Drawing.Point(288, 150)
        Me.cbant2.Name = "cbant2"
        Me.cbant2.Size = New System.Drawing.Size(100, 21)
        Me.cbant2.TabIndex = 138
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(470, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Extintor"
        '
        'cbrad2
        '
        Me.cbrad2.FormattingEnabled = True
        Me.cbrad2.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cbrad2.Location = New System.Drawing.Point(288, 122)
        Me.cbrad2.Name = "cbrad2"
        Me.cbrad2.Size = New System.Drawing.Size(100, 21)
        Me.cbrad2.TabIndex = 136
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(423, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 17)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "Colete Refletor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(409, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 17)
        Me.Label10.TabIndex = 132
        Me.Label10.Text = "Caixa de Socorro"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(457, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 17)
        Me.Label11.TabIndex = 131
        Me.Label11.Text = "Triangulo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(225, 212)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 17)
        Me.Label12.TabIndex = 130
        Me.Label12.Text = "Macaco"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(181, 183)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 17)
        Me.Label13.TabIndex = 129
        Me.Label13.Text = "Pneu Suplente"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(229, 151)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 17)
        Me.Label14.TabIndex = 128
        Me.Label14.Text = "Antena"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(237, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 17)
        Me.Label15.TabIndex = 127
        Me.Label15.Text = "Radio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(244, 93)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 17)
        Me.Label16.TabIndex = 126
        Me.Label16.Text = "Data"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label18.Location = New System.Drawing.Point(217, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 17)
        Me.Label18.TabIndex = 125
        Me.Label18.Text = "Matricula"
        '
        'txtdate2
        '
        Me.txtdate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtdate2.Location = New System.Drawing.Point(288, 90)
        Me.txtdate2.Name = "txtdate2"
        Me.txtdate2.Size = New System.Drawing.Size(100, 23)
        Me.txtdate2.TabIndex = 124
        '
        'txtmatr2
        '
        Me.txtmatr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtmatr2.Location = New System.Drawing.Point(288, 61)
        Me.txtmatr2.Name = "txtmatr2"
        Me.txtmatr2.Size = New System.Drawing.Size(100, 23)
        Me.txtmatr2.TabIndex = 123
        '
        'ButtonRemover
        '
        Me.ButtonRemover.BackColor = System.Drawing.Color.DarkGray
        Me.ButtonRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonRemover.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonRemover.Location = New System.Drawing.Point(376, 253)
        Me.ButtonRemover.Name = "ButtonRemover"
        Me.ButtonRemover.Size = New System.Drawing.Size(87, 33)
        Me.ButtonRemover.TabIndex = 108
        Me.ButtonRemover.Text = "Remover"
        Me.ButtonRemover.UseVisualStyleBackColor = False
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(6, 6)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(170, 303)
        Me.ListBox2.TabIndex = 0
        '
        'StandAutoDataSet
        '
        Me.StandAutoDataSet.DataSetName = "StandAutoDataSet"
        Me.StandAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.Log_tableTableAdapter = Nothing
        Me.TableAdapterManager.MateriaisTableAdapter = Me.MaterialTableAdapter
        Me.TableAdapterManager.MotoristasTableAdapter = Nothing
        Me.TableAdapterManager.RevisoesTableAdapter = Nothing
        Me.TableAdapterManager.SeguroTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FrotaAuto.StandAutoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Mateirais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 384)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Mateirais"
        Me.Text = "Materiais"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.StandAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents cbrad As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents ButtonAdicionar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Lable7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Data As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdate As TextBox
    Friend WithEvents txtmatr As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ButtonRemover As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents cbextintor As ComboBox
    Friend WithEvents cbsos As ComboBox
    Friend WithEvents cbcolete As ComboBox
    Friend WithEvents cbtrian As ComboBox
    Friend WithEvents cbmaca As ComboBox
    Friend WithEvents cbpneu As ComboBox
    Friend WithEvents cbant As ComboBox
    Friend WithEvents Label17 As Label
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
    Friend WithEvents txtmatr2 As TextBox
    Friend WithEvents StandAutoDataSet As StandAutoDataSet
    Friend WithEvents MaterialTableAdapter As StandAutoDataSetTableAdapters.MateriaisTableAdapter
    Friend WithEvents TableAdapterManager As StandAutoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label20 As Label
    Friend WithEvents txtcod As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtcod2 As TextBox
End Class

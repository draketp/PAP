Imports System.Data.SqlClient
Public Class Mateirais
    Private Sub Mateirais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StandAutoDataSet.Material' table. You can move, or remove it, as needed.
        Me.MaterialTableAdapter.Fill(Me.StandAutoDataSet.Materiais)
        txtcod.Enabled = False
        txtmatr.Enabled = False
        txtdate.Enabled = False
        cbrad.Enabled = False
        cbant.Enabled = False
        cbpneu.Enabled = False
        cbmaca.Enabled = False
        cbtrian.Enabled = False
        cbcolete.Enabled = False
        cbsos.Enabled = False
        cbextintor.Enabled = False
        ButtonAdicionar.Enabled = False
        ButtonCancelar.Enabled = False

        txtcod2.Enabled = False
        txtmatr2.Enabled = False
        txtdate2.Enabled = False
        cbrad2.Enabled = False
        cbant2.Enabled = False
        cbpneu2.Enabled = False
        cbmaca2.Enabled = False
        cbtrian2.Enabled = False
        cbcolete2.Enabled = False
        cbsos2.Enabled = False
        cbextintor2.Enabled = False
        ButtonRemover.Enabled = False
        carregarlist1()
        carregarlist2()
    End Sub
    Private Sub ButtonRemover_Click(sender As Object, e As EventArgs) Handles ButtonRemover.Click
        Const Location As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"

        Dim connection1 As New SqlConnection(Location)
        connection1.Open()
        Dim cod1 As String
        cod1 = ListBox2.Text
        Dim sql1 As String
        sql1 = "Delete Materiais where Cod_list = '" & ListBox2.SelectedItem & "'"
        Dim sqlcom1 As New SqlCommand(sql1, connection1)
        Dim nr1 As String
        nr1 = sqlcom1.ExecuteNonQuery()
        If nr1 > 0 Then
            MsgBox("Registo apagado com Sucesso",, "Registo removido")
        Else
            MsgBox("Artigo Não Encontrado",, "Erro")
        End If
        connection1.Close()

        txtcod2.Clear()
        txtmatr2.Clear()
        txtdate2.Clear()
        cbrad2.SelectedIndex = -1
        cbant2.SelectedIndex = -1
        cbpneu2.SelectedIndex = -1
        cbmaca2.SelectedIndex = -1
        cbtrian2.SelectedIndex = -1
        cbcolete2.SelectedIndex = -1
        cbsos2.SelectedIndex = -1
        cbextintor2.SelectedIndex = -1
        carregarlist1()
        carregarlist2()
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        ListBox1.Items.Clear()
        txtcod.Clear()
        txtmatr.Clear()
        txtdate.Clear()
        cbrad.SelectedIndex = -1
        cbant.SelectedIndex = -1
        cbpneu.SelectedIndex = -1
        cbmaca.SelectedIndex = -1
        cbtrian.SelectedIndex = -1
        cbcolete.SelectedIndex = -1
        cbsos.SelectedIndex = -1
        cbextintor.SelectedIndex = -1
        ButtonAdicionar.Enabled = False
        ButtonCancelar.Enabled = False
    End Sub

    Private Sub ButtonAdicionar_Click(sender As Object, e As EventArgs) Handles ButtonAdicionar.Click
        Const Location As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
        If validar() = True Then
            Dim connection As New SqlConnection(Location)
            connection.Open()
            Dim doc, data2, matr, rad, ant, pneu, macac, triang, colete, sos, extintor As String
            ' Dim data1 As DateTime
            doc = txtcod.Text
            matr = txtmatr.Text
            data2 = Now.ToShortDateString()
            rad = cbrad.Text
            ant = cbant.Text
            pneu = cbpneu.Text
            macac = cbmaca.Text
            triang = cbtrian.Text
            colete = cbcolete.Text
            sos = cbsos.Text
            extintor = cbextintor.Text
            Dim sql As String = "Update Materiais Set Cod_list='" & doc & "',Matricula = '" & matr & "',Data = '" & data2 & "',AutoRadio = '" & rad & "',Antena = '" & ant & "',PneuSuplente = '" & pneu & "',Macaco = '" & macac & "',Triangulo = '" & triang & "',ColeteRefletor = '" & colete & "',CaixaSocorro = '" & sos & "',Extintor=  '" & extintor & "' Where Cod_list = '" & doc & "'"
            Dim sqlcom As New SqlCommand(sql, connection)
            Dim nr As Integer
            Try
                nr = sqlcom.ExecuteNonQuery()
            Catch Exc As SqlException
                MsgBox("Erro: " & Exc.Message)
            End Try
            MsgBox("Registo alterado com Sucesso",, "Registo alterado")
            connection.Close()
        End If
        txtcod.Clear()
        txtmatr.Clear()
        txtdate.Clear()
        cbrad.SelectedIndex = -1
        cbant.SelectedIndex = -1
        cbpneu.SelectedIndex = -1
        cbmaca.SelectedIndex = -1
        cbtrian.SelectedIndex = -1
        cbcolete.SelectedIndex = -1
        cbsos.SelectedIndex = -1
        cbextintor.SelectedIndex = -1
        carregarlist1()
        carregarlist2()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        txtcod.Enabled = True
        txtmatr.Enabled = False
        txtdate.Enabled = True
        cbrad.Enabled = True
        cbant.Enabled = True
        cbpneu.Enabled = True
        cbmaca.Enabled = True
        cbtrian.Enabled = True
        cbcolete.Enabled = True
        cbsos.Enabled = True
        cbextintor.Enabled = True
        ButtonAdicionar.Enabled = True
        ButtonCancelar.Enabled = True

        Const Location As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"

        Dim connection As New SqlConnection(Location)

        connection.Open()
        Dim sql As String = "Select * from Materiais where Cod_list = '" & ListBox1.Text & "'"
        Dim sqlcom As New SqlCommand(sql, connection)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim doc, matr, rad, ant, pneu, macac, triang, colete, sos, extintor As String
        Dim data2 As String
        While dr.Read()
            doc = dr.Item(0)
            matr = dr.Item(1)
            data2 = dr.Item(2)
            rad = dr.Item(3)
            ant = dr.Item(4)
            pneu = dr.Item(5)
            macac = dr.Item(6)
            triang = dr.Item(7)
            colete = dr.Item(8)
            sos = dr.Item(9)
            extintor = dr.Item(10)
        End While
        txtcod.Text = doc
        txtmatr.Text = matr
        txtdate.Text = data2
        cbrad.Text = rad
        cbant.Text = ant
        cbpneu.Text = pneu
        cbmaca.Text = macac
        cbtrian.Text = triang
        cbcolete.Text = colete
        cbsos.Text = sos
        cbextintor.Text = extintor
    End Sub
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        txtcod2.Enabled = False
        txtmatr2.Enabled = False
        txtdate2.Enabled = False
        cbrad2.Enabled = False
        cbant2.Enabled = False
        cbpneu2.Enabled = False
        cbmaca2.Enabled = False
        cbtrian2.Enabled = False
        cbcolete2.Enabled = False
        cbsos2.Enabled = False
        cbextintor2.Enabled = False
        ButtonRemover.Enabled = True


        Const Location As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
        Dim connection As New SqlConnection(Location)
        connection.Open()
        Dim sql As String = "Select * from Materiais where Cod_list = '" & ListBox2.Text & "'"
        Dim sqlcom As New SqlCommand(sql, connection)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim doc, matr, rad, ant, pneu, macac, triang, colete, sos, extintor As String
        Dim data2 As String
        While dr.Read()
            doc = dr.Item(0)
            matr = dr.Item(1)
            data2 = dr.Item(2)
            rad = dr.Item(3)
            ant = dr.Item(4)
            pneu = dr.Item(5)
            macac = dr.Item(6)
            triang = dr.Item(7)
            colete = dr.Item(8)
            sos = dr.Item(9)
            extintor = dr.Item(10)
        End While

        txtcod2.Text = doc
        txtmatr2.Text = matr
        txtdate2.Text = data2
        cbrad2.Text = rad
        cbant2.Text = ant
        cbpneu2.Text = pneu
        cbmaca2.Text = macac
        cbtrian2.Text = triang
        cbcolete2.Text = colete
        cbsos2.Text = sos
        cbextintor2.Text = extintor
    End Sub

    Function validar() As Boolean
        If txtcod.Text = "" Then
            MsgBox("Campo do Código é de preenchimento obrigatório",, "Erro")
            txtcod.Focus()
        ElseIf txtmatr.Text = "" Then
            MsgBox("Campo da Matricula é de preenchimento obrigatório",, "Erro")
            txtmatr.Focus()
            Return False
        ElseIf txtdate.Text = "" Then
            MsgBox("Campo da Data é de preenchimento obrigatório",, "Erro")
            txtdate.Focus()
            Return False
        ElseIf cbrad.Text = "" Then
            MsgBox("Campo da Rádio é de preenchimento obrigatório",, "Erro")
            cbrad.Focus()
            Return False
        ElseIf cbant.Text = "" Then
            MsgBox("Campo da Antena é de preenchimento obrigatório",, "Erro")
            cbant.Focus()
            Return False
        ElseIf cbpneu.Text = "" Then
            MsgBox("Campo do Pneu Suplente é de preenchimento obrigatório",, "Erro")
            cbpneu.Focus()
            Return False
        ElseIf cbmaca.Text = "" Then
            MsgBox("Campo do Macaco é de preenchimento obrigatório",, "Erro")
            cbmaca.Focus()
            Return False
        ElseIf cbtrian.Text = "" Then
            MsgBox("Campo do Triangulo é de preenchimento obrigatório",, "Erro")
            cbtrian.Focus()
            Return False
        ElseIf cbcolete.Text = "" Then
            MsgBox("Campo do Colete Refletor é de preenchimento obrigatório",, "Erro")
            cbcolete.Focus()
            Return False
        ElseIf cbsos.Text = "" Then
            MsgBox("Campo da Caixa dos Socorros é de preenchimento obrigatório",, "Erro")
            cbsos.Focus()
            Return False
        ElseIf cbextintor.Text = "" Then
            MsgBox("Campo do Extintor é de preenchimento obrigatório",, "Erro")
            cbextintor.Focus()
            Return False
        End If
        Return True
    End Function
    Sub carregarlist1()
        ListBox1.Items.Clear()
        Const ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
        Dim sql As String = "select * from Materiais"
        Dim connection As New SqlConnection(ConnectionString)
        connection.Open()
        Dim sqlcom As New SqlCommand(sql, connection)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim mat As String
        While dr.Read()
            mat = dr.Item(0)
            ListBox1.Items.Add(mat)
        End While
        connection.Close()
    End Sub

    Sub carregarlist2()
        ListBox2.Items.Clear()
        Const ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
        Dim sql As String = "select * from Materiais"
        Dim connection As New SqlConnection(ConnectionString)
        connection.Open()
        Dim sqlcom As New SqlCommand(sql, connection)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim mat As String
        While dr.Read()
            mat = dr.Item(0)
            ListBox2.Items.Add(mat)
        End While
        connection.Close()
    End Sub
End Class
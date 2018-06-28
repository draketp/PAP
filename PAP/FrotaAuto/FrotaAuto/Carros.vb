Imports System.Data.SqlClient
Public Class Carros
    Private Sub Carros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StandAutoDataSet.Carros' table. You can move, or remove it, as needed.
        Me.CarrosTableAdapter.Fill(Me.StandAutoDataSet.Carros)
        txtmatr.Enabled = False
        txtcor.Enabled = False
        cbtipo.Enabled = False
        txtano.Enabled = False
        txtdate.Enabled = False
        txtkms.Enabled = False
        cbcomb.Enabled = False
        cbesta.Enabled = False
        txtvv.Enabled = False
        ButtonAdicionar.Enabled = False
        ButtonCancelar.Enabled = False

        txtmatr2.Enabled = False
        txtcor2.Enabled = False
        cbtipo2.Enabled = False
        txtano2.Enabled = False
        txtdate2.Enabled = False
        txtkms2.Enabled = False
        cbcomb2.Enabled = False
        cbesta2.Enabled = False
        txtvv2.Enabled = False
        ButtonRemover.Enabled = False
        carregarlist1()
        carregarlist2()
    End Sub
    Private Sub ButtonAdicionar_Click(sender As Object, e As EventArgs) Handles ButtonAdicionar.Click
        Const Location As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
        If validar() = True Then
            Dim connection As New SqlConnection(Location)
            connection.Open()
            Dim matr, cor, tipo, comb, estado, vv As String
            Dim ano, data, kms As Integer
            matr = txtmatr.Text
            cor = txtcor.Text
            tipo = cbtipo.Text
            ano = txtano.Text
            data = txtdate.Text
            kms = txtkms.Text
            comb = cbcomb.Text
            estado = cbesta.Text
            vv = txtvv.Text

            Dim sql As String = "Update Carros Set Matricula = '" & matr & "',Cor = '" & cor & "',Tipo = '" & tipo & "',Ano = '" & ano & "',Data_Matricula = '" & data & "',Kms = '" & kms & "',Combustivel = '" & comb & "',Estado = '" & estado & "',Via_Verde =  '" & vv & "' Where Matricula = '" & matr & "'"
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
        txtmatr.Clear()
        txtcor.Clear()
        cbtipo.SelectedIndex = -1
        txtano.Clear()
        txtdate.Clear()
        txtkms.Clear()
        cbcomb.SelectedIndex = -1
        cbesta.SelectedIndex = -1
        txtvv.Clear()
        carregarlist1()
        carregarlist2()
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        ListBox1.Items.Clear()
        carregarlist1()
        txtmatr.Clear()
        txtcor.Clear()
        cbtipo.SelectedIndex = -1
        txtano.Clear()
        txtdate.Clear()
        txtkms.Clear()
        cbcomb.SelectedIndex = -1
        cbesta.SelectedIndex = -1
        txtvv.Clear()
        ButtonAdicionar.Enabled = False
        ButtonCancelar.Enabled = False
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        txtmatr.Enabled = True
        txtcor.Enabled = True
        cbtipo.Enabled = True
        txtano.Enabled = True
        txtdate.Enabled = True
        txtkms.Enabled = True
        cbcomb.Enabled = True
        cbesta.Enabled = True
        txtvv.Enabled = True
        ButtonAdicionar.Enabled = True
        ButtonCancelar.Enabled = True

        Const Location As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"

        Dim connection As New SqlConnection(Location)

        connection.Open()
        Dim sql As String = "Select * from Carros where Matricula = '" & ListBox1.Text & "'"
        Dim sqlcom As New SqlCommand(sql, connection)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim matr, cor, tipo, comb, estado, vv As String
        Dim ano, data, kms As Integer
        While dr.Read()
            matr = dr.Item(0)
            cor = dr.Item(1)
            tipo = dr.Item(2)
            ano = dr.Item(3)
            data = dr.Item(4)
            kms = dr.Item(5)
            comb = dr.Item(6)
            estado = dr.Item(7)
            vv = dr.Item(8)
        End While

        txtmatr.Text = matr
        txtcor.Text = cor
        cbtipo.Text = tipo
        txtano.Text = ano
        txtdate.Text = data
        txtkms.Text = kms
        cbcomb.Text = comb
        cbesta.Text = estado
        txtvv.Text = vv
    End Sub


    Private Sub ButtonRemover_Click(sender As Object, e As EventArgs) Handles ButtonRemover.Click
        Const Location As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"

        Dim connection1 As New SqlConnection(Location)
        connection1.Open()
        Dim cod1 As String
        cod1 = ListBox2.Text
        Dim sql1 As String
        sql1 = "Delete Carros where Matricula = '" & ListBox2.SelectedItem & "'"
        Dim sqlcom1 As New SqlCommand(sql1, connection1)
        Dim nr1 As String
        nr1 = sqlcom1.ExecuteNonQuery()
        If nr1 > 0 Then
            MsgBox("Registo apagado com Sucesso",, "Registo removido")
        Else
            MsgBox("Artigo Não Encontrado",, "Erro")
        End If
        connection1.Close()

        txtmatr2.Clear()
        txtcor2.Clear()
        cbtipo2.SelectedIndex = -1
        txtano2.Clear()
        txtdate2.Clear()
        txtkms2.Clear()
        cbcomb2.SelectedIndex = -1
        cbesta2.SelectedIndex = -1
        txtvv2.Clear()
        carregarlist1()
        carregarlist2()
    End Sub
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        txtmatr2.Enabled = False
        txtcor2.Enabled = False
        cbtipo2.Enabled = False
        txtano2.Enabled = False
        txtdate2.Enabled = False
        txtkms2.Enabled = False
        cbcomb2.Enabled = False
        cbesta2.Enabled = False
        txtvv2.Enabled = False
        ButtonRemover.Enabled = True
        Const Location As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
        Dim connection As New SqlConnection(Location)
        connection.Open()
        Dim sql As String = "Select * from Carros where Matricula = '" & ListBox2.Text & "'"
        Dim sqlcom As New SqlCommand(sql, connection)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim matr, cor, tipo, comb, estado, vv As String
        Dim ano, data, kms As Integer
        While dr.Read()
            matr = dr.Item(0)
            cor = dr.Item(1)
            tipo = dr.Item(2)
            ano = dr.Item(3)
            data = dr.Item(4)
            kms = dr.Item(5)
            comb = dr.Item(6)
            estado = dr.Item(7)
            vv = dr.Item(8)
        End While

        txtmatr2.Text = matr
        txtcor2.Text = cor
        cbtipo2.Text = tipo
        txtano2.Text = ano
        txtdate2.Text = data
        txtkms2.Text = kms
        cbcomb2.Text = comb
        cbesta2.Text = estado
        txtvv2.Text = vv
    End Sub
    Function validar() As Boolean
        If txtmatr.Text = "" Then
            MsgBox("Campo da Matricula é de preenchimento obrigatório",, "Erro")
            txtmatr.Focus()
            Return False
        ElseIf txtcor.Text = "" Then
            MsgBox("Campo da Cor é de preenchimento obrigatório",, "Erro")
            txtcor.Focus()
            Return False
        ElseIf cbtipo.Text = "" Then
            MsgBox("Campo do Tipo é de preenchimento obrigatório",, "Erro")
            cbtipo.Focus()
            Return False
        ElseIf txtano.Text = "" Then
            MsgBox("Campo do Ano é de preenchimento obrigatório",, "Erro")
            txtano.Focus()
            Return False
        ElseIf txtdate.Text = "" Then
            MsgBox("Campo da Data é de preenchimento obrigatório",, "Erro")
            txtdate.Focus()
            Return False
        ElseIf txtkms.Text = "" Then
            MsgBox("Campo dos Quilómetros é de preenchimento obrigatório",, "Erro")
            txtkms.Focus()
            Return False
        ElseIf cbcomb.Text = "" Then
            MsgBox("Campo do Combustivel é de preenchimento obrigatório",, "Erro")
            cbcomb.Focus()
            Return False
        ElseIf cbesta.Text = "" Then
            MsgBox("Campo do Estado é de preenchimento obrigatório",, "Erro")
            cbesta.Focus()
            Return False
        ElseIf txtvv.Text = "" Then
            MsgBox("Campo da Via Verde é de preenchimento obrigatório",, "Erro")
            txtvv.Focus()
            Return False
        End If
        Return True
    End Function
    Sub carregarlist1()
        ListBox1.Items.Clear()
        Const ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
        Dim sql As String = "select * from Carros"
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
        Dim sql As String = "select * from Carros"
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
Imports System.Data.SqlClient
Public Class Add_carros
    Private Sub Add_carros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CarrosTableAdapter.Fill(Me.StandAutoDataSet.Carros)
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        ComboBox3.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        ComboBox2.Enabled = False
        ComboBox1.Enabled = False
        TextBox6.Text = False
        carregarlist1()
    End Sub
    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        txtmatr.Clear()
        txtcor.Clear()
        cbtipo.SelectedIndex = -1
        txtano.Clear()
        txtdate.Clear()
        txtkms.Clear()
        cbcomb.SelectedIndex = -1
        cbesta.SelectedIndex = -1
        txtvv.Clear()
    End Sub

    Private Sub ButtonAdicionar_Click(sender As Object, e As EventArgs) Handles ButtonAdicionar.Click
        Const ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"

        If validar() = True Then
            Dim con As New SqlConnection(ConnectionString)
            con.Open()
            Dim matr, cor, tipo, comb, estado, vv As String
            Dim ano, data, kms As Integer
            matr = txtmatr.Text
            cor = txtcor.Text
            tipo = cbtipo.SelectedItem
            ano = txtano.Text
            data = txtdate.Text
            kms = txtkms.Text
            comb = cbcomb.SelectedItem
            estado = cbesta.SelectedItem
            vv = txtvv.Text


            Dim sql As String = "Insert into Carros " & "values('" & matr & "','" & cor & "','" & tipo & "','" & ano & "','" & data & "','" & kms & "','" & comb & "','" & estado & "','" & vv & "')"
            Dim sqlcom As New SqlCommand(sql, con)
            Dim nr As Integer
            Try
                nr = sqlcom.ExecuteNonQuery()
            Catch Exc As SqlException
                MsgBox("Erro: " & Exc.Message)
            End Try
            MsgBox("Registo inserido com Sucesso",, "Registo Inserido")

            txtmatr.Clear()
            txtcor.Clear()
            cbtipo.SelectedIndex = -1
            txtano.Clear()
            txtdate.Clear()
            txtkms.Clear()
            cbcomb.SelectedIndex = -1
            cbesta.SelectedIndex = -1
            txtvv.Clear()
            con.Close()
            carregarlist1()
        End If
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

        Const cs As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
        Dim connection As New SqlConnection(cs)
        connection.Open()
        Dim sql As String = "Select * from Carros"
        Dim sqlcom As New SqlCommand(sql, connection)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim mat As String
        While dr.Read()
            mat = dr.Item(0)
            If txtmatr.Text = mat Then
                MsgBox("Campo da Matricula já está atribuido a outro Veiculo",, "Erro")
                txtmatr.Focus()
                Return False
            End If
        End While
        connection.Close()
        Return True
    End Function
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox6.Text = False
        TextBox5.Text = False
        ComboBox3.Text = False
        TextBox4.Text = False
        TextBox3.Text = False
        TextBox2.Text = False
        ComboBox2.Text = False
        ComboBox1.Text = False
        TextBox1.Text = False
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

        TextBox6.Text = matr
        TextBox5.Text = cor
        ComboBox3.Text = tipo
        TextBox4.Text = ano
        TextBox3.Text = data
        TextBox2.Text = kms
        ComboBox2.Text = comb
        ComboBox1.Text = estado
        TextBox1.Text = vv
        connection.Close()
    End Sub
    Sub carregarlist1()
        ListBox1.Items.Clear()
        Const ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
        Dim connection As New SqlConnection(ConnectionString)
        connection.Open()
        Dim sql As String = "select * from Carros"

        Dim sqlcom As New SqlCommand(sql, connection)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim mat As String
        Dim i As Integer = 0
        While dr.Read()
            mat = dr.Item(0)
            ListBox1.Items.Add(mat)
        End While
        connection.Close()
    End Sub
End Class
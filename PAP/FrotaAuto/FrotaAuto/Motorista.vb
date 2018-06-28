Imports System.Data.SqlClient
Public Class Motorista
    Private Sub Motorista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MotoristasTableAdapter.Fill(Me.StandAutoDataSet.Motoristas)
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False
        TextBox11.Enabled = False
        TextBox12.Enabled = False
        TextBox13.Enabled = False
        carregarlist2()
    End Sub
    Private Sub ButtonAdicionar_Click(sender As Object, e As EventArgs) Handles ButtonAdicionar.Click
        Const ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
        If validar() = True Then
            Dim con As New SqlConnection(ConnectionString)
            con.Open()
            Dim nome, morada, local, email, localcarta, postal As String
            Dim id, tel, ncarta, vencimento, validade As String
            Dim nascimento As String
            id = TextBox1.Text
            nome = txtnome.Text
            morada = txtmorada.Text
            local = txtlocal.Text
            postal = txtpostal.Text
            tel = txttel.Text
            email = txtemail.Text
            nascimento = txtnascimento.Text
            vencimento = txtvencimento.Text
            ncarta = txtncarta.Text
            localcarta = txtlocalcarta.Text
            validade = txtvalidade.Text

            Dim sql As String = "Insert into Motoristas values('" & id & "','" & nome & "','" & morada & "','" & local & "', '" & postal & "','" & tel & "','" & email & "','" & nascimento & "','" & vencimento & "','" & ncarta & "','" & localcarta & "','" & validade & "')"
            Dim sqlcom As New SqlCommand(sql, con)
            Dim nr As Integer
            Try
                nr = sqlcom.ExecuteNonQuery()
            Catch Exc As SqlException
                MsgBox("Erro: " & Exc.Message)
            End Try
            MsgBox("Registo inserido com Sucesso",, "Registo Inserido")
            TextBox1.Clear()
            txtnome.Clear()
            txtmorada.Clear()
            txtlocal.Clear()
            txtpostal.Clear()
            txttel.Clear()
            txtemail.Clear()
            txtnascimento.Clear()
            txtvencimento.Clear()
            txtncarta.Clear()
            txtlocal.Clear()
            txtvalidade.Clear()
            con.Close()
            carregarlist2()
        End If
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        txtnome.Clear()
        txtmorada.Clear()
        txtlocal.Clear()
        txtpostal.Clear()
        txttel.Clear()
        txtemail.Clear()
        txtnascimento.Clear()
        txtvencimento.Clear()
        txtncarta.Clear()
        txtlocalcarta.Clear()
        txtvalidade.Clear()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False
        TextBox11.Enabled = False
        TextBox12.Enabled = False
        TextBox13.Enabled = False

        Const Location As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
        Dim connection As New SqlConnection(Location)
        connection.Open()
        Dim sql As String = "Select * from Motoristas where Id = '" & ListBox1.Text & "'"
        Dim sqlcom As New SqlCommand(sql, connection)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        'Dim num As Double = 12.1234
        'MsgBox(Format(num, "F2"))
        Dim Id, nome, morada, local, codpost, tele, email, nasc, ncarta, localcarta, valid As String
        Dim venc As Double
        While dr.Read()
            Id = dr.Item(0)
            nome = dr.Item(1)
            morada = dr.Item(2)
            local = dr.Item(3)
            codpost = dr.Item(4)
            tele = dr.Item(5)
            email = dr.Item(6)
            nasc = dr.Item(7)
            venc = dr.Item(8)
            ncarta = dr.Item(9)
            localcarta = dr.Item(10)
            valid = dr.Item(11)

        End While
        TextBox2.Text = Id
        TextBox13.Text = nome
        TextBox12.Text = morada
        TextBox11.Text = local
        TextBox10.Text = codpost
        TextBox9.Text = tele
        TextBox8.Text = email
        TextBox7.Text = nasc
        TextBox6.Text = Format(venc, "F2")
        TextBox5.Text = ncarta
        TextBox4.Text = localcarta
        TextBox3.Text = valid
    End Sub
    Function validar() As Boolean
        If txtnome.Text = "" Then
            MsgBox("Campo do Nome é de preenchimento obrigatório",, "Erro")
            txtnome.Focus()
            Return False
        ElseIf txtmorada.Text = "" Then
            MsgBox("Campo da Morada é de preenchimento obrigatório",, "Erro")
            txtmorada.Focus()
            Return False
        ElseIf txtlocal.Text = "" Then
            MsgBox("Campo da Localidade é de preenchimento obrigatório",, "Erro")
            txtlocal.Focus()
            Return False
        ElseIf txtpostal.Text = "" Then
            MsgBox("Campo do Codigo Postal é de preenchimento obrigatório",, "Erro")
            txtpostal.Focus()
            Return False
        ElseIf txttel.Text = "" Then
            MsgBox("Campo do Telefone é de preenchimento obrigatório",, "Erro")
            txttel.Focus()
            Return False
        ElseIf txtemail.Text = "" Then
            MsgBox("Campo do Email é de preenchimento obrigatório",, "Erro")
            txtemail.Focus()
            Return False
        ElseIf txtnascimento.Text = "" Then
            MsgBox("Campo da Data de Nascimento é de preenchimento obrigatório",, "Erro")
            txtnascimento.Focus()
            Return False
        ElseIf txtvencimento.Text = "" Then
            MsgBox("Campo do Vencimento é de preenchimento obrigatório",, "Erro")
            txtvencimento.Focus()
            Return False
        ElseIf txtncarta.Text = "" Then
            MsgBox("Campo do Número da Carta é de preenchimento obrigatório",, "Erro")
            txtncarta.Focus()
        ElseIf txtlocalcarta.Text = "" Then
            MsgBox("Campo do Local da Carta é de preenchimento obrigatório",, "Erro")
            txtlocalcarta.Focus()
        ElseIf txtvalidade.Text = "" Then
            MsgBox("Campo da Validade é de preenchimento obrigatório",, "Erro")
            txtvalidade.Focus()
            Return False
        End If
        Return True
    End Function
    Sub carregarlist2()
        ListBox1.Items.Clear()
        Const ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
        Dim sql As String = "select * from Motoristas"
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
End Class
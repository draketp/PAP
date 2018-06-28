Imports System.Data.SqlClient
Public Class Alte_Motoristas
    Private Sub Alte_Motoristas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ButtonRemover.Enabled = True

        Const Location As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
        Dim connection As New SqlConnection(Location)
        connection.Open()
        Dim sql As String = "Select * from Motoristas where Id = '" & Me.ListBox1.Text & "'"
        Dim sqlcom As New SqlCommand(sql, connection)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim Id, nome, morada, local, codpost, tele, email, nasc, venc, ncarta, localcarta, valid As String
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
        TextBox6.Text = Format(venc, "C")
        TextBox5.Text = ncarta
        TextBox4.Text = localcarta
        TextBox3.Text = valid

        TextBox1.Text = Id
        txtnome.Text = nome
        txtmorada.Text = morada
        txtlocal.Text = local
        txtpostal.Text = codpost
        txttel.Text = tele
        txtemail.Text = email
        txtnascimento.Text = nasc
        txtvencimento.Text = venc
        txtncarta.Text = ncarta
        txtlocalcarta.Text = localcarta
        txtvalidade.Text = valid
    End Sub
    Private Sub ButtonRemover_Click(sender As Object, e As EventArgs) Handles ButtonRemover.Click
        Const Location As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"

        Dim connection1 As New SqlConnection(Location)
        connection1.Open()
        Dim cod1 As String
        cod1 = ListBox1.Text
        Dim sql1 As String
        sql1 = "Delete Motoristas where Id = '" & ListBox1.SelectedItem & "'"
        Dim sqlcom1 As New SqlCommand(sql1, connection1)
        Dim nr1 As String
        nr1 = sqlcom1.ExecuteNonQuery()
        If nr1 > 0 Then
            MsgBox("Registo apagado com Sucesso",, "Registo removido")
        Else
            MsgBox("Artigo Não Encontrado",, "Erro")
        End If
        connection1.Close()

        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()

        carregarlist2()
    End Sub
    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
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
        txtlocalcarta.Clear()
        txtvalidade.Clear()
        ButtonAdicionar.Enabled = False
        ButtonCancelar.Enabled = False
    End Sub

    Private Sub ButtonAdicionar_Click(sender As Object, e As EventArgs) Handles ButtonAdicionar.Click
        Const Location As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
        If validar() = True Then
            Dim connection As New SqlConnection(Location)
            connection.Open()
            Dim Id, nome, morada, local, codpost, tele, email, nasc, venc, ncarta, localcarta, valid As String
            Id = TextBox1.Text
            nome = txtnome.Text
            morada = txtmorada.Text
            local = txtlocal.Text
            codpost = txtpostal.Text
            tele = txttel.Text
            email = txtemail.Text
            nasc = txtnascimento.Text
            venc = txtvencimento.Text
            ncarta = txtncarta.Text
            localcarta = txtlocalcarta.Text
            valid = txtvalidade.Text
            Dim sql As String = "Update Motoristas Set Id='" & Id & "',Nome = '" & nome & "',Morada = '" & morada & "',Localidade = '" & local & "',CodPostal = '" & codpost & "',Telefone = '" & tele & "',Email = '" & email & "',Nascimento = '" & nasc & "',Vencimento = '" & venc & "',NCarta = '" & ncarta & "',LocalCarta=  '" & localcarta & "',ValidadeCarta=  '" & valid & "' Where Id = '" & Id & "'"
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
        txtlocalcarta.Clear()
        txtvalidade.Clear()
        carregarlist2()
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
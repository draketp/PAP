Imports System.Data.SqlClient
Public Class Add_Material
    Private Sub Add_Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaterialTableAdapter.Fill(Me.StandAutoDataSet.Materiais)
        Me.CarrosTableAdapter.Fill(Me.StandAutoDataSet.Carros)
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
        cbmatr2.SelectedIndex = -1
        carregarlist2()


    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

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
        Const Location As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
        Dim connection As New SqlConnection(Location)
        connection.Open()
        Dim sql As String = "Select * from Materiais where Cod_list = '" & ListBox2.Text & "'"
        'Dim sql As String = "Select * from Material where Data = '" & Microsoft.VisualBasic.Right(ListBox2.Text, 10) & "'"
        Dim sqlcom As New SqlCommand(sql, connection)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim doc, matr, data1, rad, ant, pneu, macac, triang, colete, sos, extintor As String
        'Dim data As String
        While dr.Read()
            doc = dr.Item(0)
            matr = dr.Item(1)
            data1 = dr.Item(2)
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
        txtdate.Text = data1
        cbrad.Text = rad
        cbant.Text = ant
        cbpneu.Text = pneu
        cbmaca.Text = macac
        cbtrian.Text = triang
        cbcolete.Text = colete
        cbsos.Text = sos
        cbextintor.Text = extintor
        connection.Close()
    End Sub
    Private Sub ButtonAdicionar_Click_1(sender As Object, e As EventArgs) Handles ButtonAdicionar.Click
        Const Location As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
        If validar() = True Then
            Dim connection As New SqlConnection(Location)
            connection.Open()
            Dim doc, matr, data1, rad, ant, pneu, macac, triang, colete, sos, extintor As String
            'Dim data As Date
            doc = txtcod2.Text
            matr = cbmatr2.Text
            data1 = txtdate2.Text
            rad = cbrad2.Text
            ant = cbant2.Text
            pneu = cbpneu2.Text
            macac = cbmaca2.Text
            triang = cbtrian2.Text
            colete = cbcolete2.Text
            sos = cbsos2.Text
            extintor = cbextintor2.Text
            Dim sql As String = "Insert Into Materiais values" &
                "('" & doc & "','" & matr & "','" & data1 & "','" & rad & "','" & ant & "' ,'" & pneu & "','" & macac & "','" & triang & "','" & colete & "','" & sos & "','" & extintor & "')"
            Dim sqlcom As New SqlCommand(sql, connection)
            Dim nr As Integer
            Try
                nr = sqlcom.ExecuteNonQuery()
            Catch Exc As SqlException
                MsgBox("Erro: " & Exc.Message)
            End Try
            MsgBox("Registado com Sucesso",, "Registo adicionado")
            connection.Close()
        End If
        txtcod2.Clear()
        cbmatr2.SelectedIndex = -1
        txtdate2.Clear()
        cbrad2.SelectedIndex = -1
        cbant2.SelectedIndex = -1
        cbpneu2.SelectedIndex = -1
        cbmaca2.SelectedIndex = -1
        cbtrian2.SelectedIndex = -1
        cbcolete2.SelectedIndex = -1
        cbsos2.SelectedIndex = -1
        cbextintor2.SelectedIndex = -1
        carregarlist2()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtcod2.Clear()
        cbmatr2.SelectedIndex = -1
        txtdate2.Clear()
        cbrad2.SelectedIndex = -1
        cbant2.SelectedIndex = -1
        cbpneu2.SelectedIndex = -1
        cbmaca2.SelectedIndex = -1
        cbtrian2.SelectedIndex = -1
        cbcolete2.SelectedIndex = -1
        cbsos2.SelectedIndex = -1
        cbextintor2.SelectedIndex = -1
    End Sub
    Function validar() As Boolean
        If txtcod2.Text = "" Then
            MsgBox("Campo do Codigo é de preenchimento obrigatório",, "Erro")
            txtcod2.Focus()
            Return False
        ElseIf cbmatr2.Text = "" Then
            MsgBox("Campo da Matricula é de preenchimento obrigatório",, "Erro")
            cbmatr2.Focus()
            Return False
        ElseIf txtdate2.Text = "" Then
            MsgBox("Campo da Data é de preenchimento obrigatório",, "Erro")
            txtdate2.Focus()
            Return False
        ElseIf cbrad2.Text = "" Then
            MsgBox("Campo da Rádio é de preenchimento obrigatório",, "Erro")
            cbrad2.Focus()
            Return False
        ElseIf cbant2.Text = "" Then
            MsgBox("Campo da Antena é de preenchimento obrigatório",, "Erro")
            cbant2.Focus()
            Return False
        ElseIf cbpneu2.Text = "" Then
            MsgBox("Campo do Pneu Suplente é de preenchimento obrigatório",, "Erro")
            cbpneu2.Focus()
            Return False
        ElseIf cbmaca2.Text = "" Then
            MsgBox("Campo do Macaco é de preenchimento obrigatório",, "Erro")
            cbmaca2.Focus()
            Return False
        ElseIf cbtrian2.Text = "" Then
            MsgBox("Campo do Triangulo é de preenchimento obrigatório",, "Erro")
            cbtrian2.Focus()
            Return False
        ElseIf cbcolete2.Text = "" Then
            MsgBox("Campo do Colete Refletor é de preenchimento obrigatório",, "Erro")
            cbcolete2.Focus()
            Return False
        ElseIf cbsos2.Text = "" Then
            MsgBox("Campo da Caixa dos Socorros é de preenchimento obrigatório",, "Erro")
            cbsos2.Focus()
            Return False
        ElseIf cbextintor2.Text = "" Then
            MsgBox("Campo do Extintor é de preenchimento obrigatório",, "Erro")
            cbextintor2.Focus()
            Return False
        End If
        Return True
    End Function
    Sub carregarlist2()
        ListBox2.Items.Clear()
        Dim d As String
        Const ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
        'Dim sql As String = "select * from Material"
        Dim connection As New SqlConnection(ConnectionString)
        connection.Open()
        Dim sql As String = "select * from Materiais"
        Dim sqlcom As New SqlCommand(sql, connection)
        Dim dr As SqlDataReader = sqlcom.ExecuteReader()
        Dim mat As String
        Dim i As Integer = 0
        While dr.Read()
            mat = dr.Item(0)
            ListBox2.Items.Add(mat)
        End While
        connection.Close()
    End Sub
End Class


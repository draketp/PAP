Imports System.Data.SqlClient
Public Class Form1
    'Private Sub BTN_LOGIN_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    If (txtusername.Text = "Admin" And txtpassword.Text = "123") Then
    '        Form2.Show()
    '    End If
    Dim con As New SqlClient.SqlConnection
        Dim da As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim sqlquery As String
    Private Sub Button1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'checking if the username and password field is null

            If Len(Trim(txtusername.Text)) = 0 Then
                MessageBox.Show("Enter the user name", "Input Error !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
                txtusername.Focus()
            End If
            If Len(Trim(txtPass.Text)) = 0 Then
                MessageBox.Show("Enter the password", "Input Error !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
                txtPass.Focus()
            End If

            'executing SQL Query for retrieving the username and password from the database table

            con.Open()
            sqlquery = "SELECT * FROM Log_table WHERE Id='" & txtusername.Text & "' and Password='" & txtPass.Text & "' "
            da = New SqlClient.SqlDataAdapter(sqlquery, con)
            da.Fill(ds, "Log_table")
            If ds.Tables("Log_table").Rows.Count <> 0 Then
                If txtusername.Text = "Admin" Then
                    Form2.Show()
                End If
                If txtusername.Text = "User" Then
                    User.Show()
                End If
                'MessageBox.Show("Login succeed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Form2.Show()
            Else
                MessageBox.Show("Invalid user name and password", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()

            clear()
            'calling clear method here

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception generated", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' declaring a method for clearing the controls
    Public Sub clear()
        txtPass.Clear()
        txtusername.Clear()
    End Sub

    ' code for show password
    'Private Sub chkshowpass_CheckedChanged(sender As Object, e As EventArgs) Handles chkshowpass.CheckedChanged
    '    If chkshowpass.Checked = True Then
    '        txtPass.UseSystemPasswordChar = False
    '    Else
    '        txtPass.UseSystemPasswordChar = True
    '    End If
    'End Sub
    'Const ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ricardo\Desktop\PAP\FrotaAuto\FrotaAuto\StandAuto.mdf;Integrated Security=True"
    'Dim x, s As String
    'x = txtusername.Text
    's = txtpassword.Text
    'Dim con As New SqlConnection(ConnectionString)
    'con.Open()
    'Dim sql As String = "Select * From Motoristas Where Id = '" & x & "'" 'And Password = '" & s & "'"
    'Dim sqlcom As New SqlCommand(sql, con)
    'Dim dr As SqlDataReader = sqlcom.ExecuteReader()
    'Dim Tipo As String
    'While dr.Read()
    '    Tipo = dr.Item(1)
    'End While
    'If Tipo = "Administrador" Then
    '    Form2.Show()
    '    Me.Hide()
    'ElseIf Tipo = "Funcionario" Then
    '    User.Show()
    '    Me.Hide()
    'ElseIf Tipo = "" Then
    '    MsgBox("Erro ao fazer Login." & vbCrLf & "Tente Novamente")
    'End If
    'con.Close()
End Class

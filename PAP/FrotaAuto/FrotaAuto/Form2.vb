Imports System.Data.SqlClient
Public Class Form2
    Private Sub AlterarRemoverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarRemoverToolStripMenuItem.Click
        Carros.Show()
    End Sub

    Private Sub AdicionarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarToolStripMenuItem.Click
        Add_carros.Show()
    End Sub

    Private Sub AlterarRemoverToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlterarRemoverToolStripMenuItem1.Click
        Mateirais.Show()
    End Sub
    Private Sub AdicionarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AdicionarToolStripMenuItem1.Click
        Add_Material.Show()
    End Sub

    Private Sub AdicionarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AdicionarToolStripMenuItem2.Click
        Alte_Motoristas.Show()
    End Sub

    Private Sub AdicionarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AdicionarToolStripMenuItem3.Click
        Motorista.Show()
    End Sub
End Class
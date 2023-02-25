Imports System.IO
Public Class Form1
    Public File_doc As String = ""
    Private Sub BtmAbrir_Click(sender As Object, e As EventArgs) Handles BtmAbrir.Click
        Dim open As OpenFileDialog = New OpenFileDialog()
        open.Filter = "Archivo de texto|*.txt"

        If open.ShowDialog() = DialogResult.OK Then
            File_doc = open.FileName
            Dim leer As StreamReader = New StreamReader(open.FileName)
            TxtTexto.Text = leer.ReadToEnd()
            leer.Close()
        End If
    End Sub

    Private Sub BtmGuardar_Click(sender As Object, e As EventArgs) Handles BtmGuardar.Click
        If File_doc = "" Then
            BtmGuardar_como_Click(sender, e)
        Else
            Dim escribir As StreamWriter = New StreamWriter(File_doc)
            escribir.Write(TxtTexto.Text)
            escribir.Close()
        End If
    End Sub

    Private Sub BtmLimpiar_Click(sender As Object, e As EventArgs) Handles BtmLimpiar.Click
        TxtTexto.Clear()
        TxtTexto.Focus()
    End Sub

    Private Sub BtmGuardar_como_Click(sender As Object, e As EventArgs) Handles BtmGuardar_como.Click
        Dim save As SaveFileDialog = New SaveFileDialog()
        save.Filter = "Archivo de texto|*.txt"
        If save.ShowDialog() = DialogResult.OK Then
            File_doc = save.FileName
            Dim escribir As StreamWriter = New StreamWriter(save.FileName)
            escribir.Write(TxtTexto.Text)
            escribir.Close()
        End If
    End Sub
End Class

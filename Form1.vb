﻿Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.TextBox1.Text.Length > 0 Then
            For i = 1 To 3
                MsgBox(Me.TextBox1.Text + "ves :", MsgBoxStyle.Exclamation, "Titulo")
            Next
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Otro")
    End Sub
End Class

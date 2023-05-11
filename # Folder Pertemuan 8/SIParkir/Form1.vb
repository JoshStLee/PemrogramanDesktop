﻿Imports MySql.Data.MySqlClient
Imports SIParkir.ModuleDB
Public Class frmLogin
    Private Sub Login_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            btnLogin.PerformClick()
        End If
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim sql As String = "select username,password from " & tbluser & " where username='" & txtUsername.Text & "' and password='" & txtPassword.Text & "'"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            myDataReader.Close()
            pengguna = txtUsername.Text
            ppassword = txtPassword.Text
            frmUtama.lblInfoUser.Text = "Informasi - (User: " & pengguna & ")"
            frmUtama.lblTgl.Text = "Tangggal : " & Now.Day & " - " & Now.Month & " - " & Now.Year
            frmUtama.RefreshGrid()
            frmUtama.HitungJumlah()
            frmUtama.Show()
            Me.Hide()
        Else
            MsgBox("Username / Password salah!")
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateConnection()
    End Sub
End Class
Imports System.Data.SQLite
Public Class FrmLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Usuario.Text = "" Then
            MessageBox.Show("Debe ingresar el usuario")
            Usuario.Focus()
        Else
            validarUsuario()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub

    Private Sub TextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles password.KeyUp
        'MessageBox.Show(e.KeyValue)
        If e.KeyValue = 13 Then
            If Usuario.Text = "" Then
                MessageBox.Show("Debe ingresar el usuario")
                Usuario.Focus()
            Else
                validarUsuario()
            End If

        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Usuario_KeyUp(sender As Object, e As KeyEventArgs) Handles Usuario.KeyUp
        If e.KeyValue = 13 Then
            If Usuario.Text = "" Then
                MessageBox.Show("Debe ingresar el usuario")
                Usuario.Focus()
            Else
                password.Focus()


            End If

        End If
    End Sub

    Private Function validarUsuario()
        Dim continuar = False

        If Usuario.Text = "" Then
            MessageBox.Show("Debe ingresar el usuario")
            Usuario.Focus()
        Else
            Dim USR As String = Usuario.Text.ToUpper()
            Dim PWR As String = password.Text.ToUpper()



            If USR = "ADMIN" And PWR = "ADMIN" Then
                continuar = True

            Else
                MessageBox.Show("Error en las credenciales")
                Usuario.Focus()
            End If

            If continuar Then
                Dim frm As New FrmPrincipal()
                frm.Show()
                Me.Hide()
            End If




        End If


    End Function
End Class

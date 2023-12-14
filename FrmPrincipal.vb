Public Class FrmPrincipal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Cuando el formulario principal se cierra, cerrar también el formulario de inicio de sesión
        Dim loginForm As FrmLogin = DirectCast(Application.OpenForms("FrmLogin"), FrmLogin)

        If loginForm IsNot Nothing Then
            loginForm.Close()
        End If
    End Sub
End Class
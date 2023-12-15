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



    Private Sub FACTURACIONToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FACTURACIONToolStripMenuItem1.Click
        Dim frm As New facturaPOS()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub RESUMENDEVENTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESUMENDEVENTAToolStripMenuItem.Click
        Dim frm As New resumenVentaPOS()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CLIENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLIENTESToolStripMenuItem.Click
        Dim frm As New Clientes()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub FACELECTRONICAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FACELECTRONICAToolStripMenuItem.Click
        Dim frm As New facturacion()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub RESUMENDEFACTURAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESUMENDEFACTURAToolStripMenuItem.Click
        Dim frm As New resFacturaElectronica()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ENVIARAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENVIARAToolStripMenuItem.Click
        Dim frm As New enviarAfactory()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub FACTORYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FACTORYToolStripMenuItem.Click
        Dim frm As New credencialesFactory()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
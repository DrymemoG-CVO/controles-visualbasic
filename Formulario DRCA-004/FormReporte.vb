Public Class FormReporte
    Private Sub FormReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Form1.tbNombreComercial.Text
        Label2.Text = Form1.tbNIT.Text
        Label3.Text = Form1.tbdireccion.Text

    End Sub
End Class
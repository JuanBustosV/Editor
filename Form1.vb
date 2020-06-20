Public Class Editor

    Private fuentePr As Font

#Region "Eventos"

    Private Sub ArchivoSalir_Click(sender As Object, e As EventArgs) Handles ArchivoSalir.Click
        Me.Close()
    End Sub

    Private Sub EdicionCortar_Click(sender As Object, e As EventArgs) Handles EdicionCortar.Click, btbarCortar.Click
        ctEditor.Cut()
    End Sub

    Private Sub EdicionCopiar_Click(sender As Object, e As EventArgs) Handles EdicionCopiar.Click, btbarCopiar.Click
        ctEditor.Copy()
    End Sub

    Private Sub EdicionPegar_Click(sender As Object, e As EventArgs) Handles EdicionPegar.Click, btbarPegar.Click
        ctEditor.Paste()
    End Sub

    Private Sub OpFuCourierNew_Click(sender As Object, e As EventArgs) Handles OpFuCourierNew.Click
        Dim f As Font = ctEditor.Font
        ctEditor.Font = New Font("Courier New", f.Size, f.Style)
    End Sub

    Private Sub OpFuArial_Click(sender As Object, e As EventArgs) Handles OpFuArial.Click
        Dim f As Font = ctEditor.Font
        ctEditor.Font = New Font("Arial", f.Size, f.Style)
    End Sub

    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fuentePr = ctEditor.Font
    End Sub

    Private Sub OpFuPredeterminada_Click(sender As Object, e As EventArgs) Handles OpFuPredeterminada.Click
        Dim f As Font = ctEditor.Font
        ctEditor.Font = New Font(fuentePr.SystemFontName, f.Size, f.Style)
    End Sub

    Private Sub OpTam16_Click(sender As Object, e As EventArgs) Handles OpTam16.Click
        Dim f As Font = ctEditor.Font
        ctEditor.Font = New Font(f.SystemFontName, 16.0F, f.Style)
    End Sub

    Private Sub OpTam24_Click(sender As Object, e As EventArgs) Handles OpTam24.Click
        Dim f As Font = ctEditor.Font
        ctEditor.Font = New Font(f.SystemFontName, 24.0F, f.Style)
    End Sub

    Private Sub OpTamPredeterminado_Click(sender As Object, e As EventArgs) Handles OpTamPredeterminado.Click
        Dim f As Font = ctEditor.Font
        ctEditor.Font = New Font(f.SystemFontName, fuentePr.Size, f.Style)
    End Sub

#End Region

End Class

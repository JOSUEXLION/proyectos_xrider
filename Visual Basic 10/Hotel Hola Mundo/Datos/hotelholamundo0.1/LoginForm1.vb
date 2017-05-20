Public Class frmpantalladeinicio

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click
        REM declaracion de variables tipo cadena
        Dim usuario As String
        Dim pass As String
        ' declaracion del usuario y contraseña para el login
        usuario = txtuser.Text
        pass = txtpassword.Text
        ' validacion del usuario y pass
        If usuario = "Vendedor" And pass = "1234" Then
            frmpantalladereserva.Show()
            Me.Hide()
        Else
            ' ventana de error para el login
            MsgBox("Usuario o Contraseña Incorrecta")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancelar.Click
        Me.Close()
        REM indica que va a salir 
    End Sub

    Private Sub txtuser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuser.TextChanged

    End Sub
End Class

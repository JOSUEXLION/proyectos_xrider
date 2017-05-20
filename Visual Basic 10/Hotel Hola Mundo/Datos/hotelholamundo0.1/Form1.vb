Public Class frmpantalladereserva
    Private a, total As Double

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        End
    End Sub
    REM boton (BtnCalcular) para calcular cuanto pagara el cliente
    ' el total sera impreso en el textbox1.text 
    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtotal.Click
        txtsaldo.Text = total
        ' a = 0
        If chk1.Checked = True Then
            a = 50
            total = total + a * txtc1.Text
        End If
        If chk2.Checked = True Then
            a = 35
            total = total + a * txtc2.Text
        End If
        If chk3.Checked = True Then
            a = 200
            total = total + a * txtc3.Text
        End If
        If chk4.Checked = True Then
            a = 75
            total = total + a * txtc4.Text
        End If
        ' If CheckBox8.Checked = True Then
        '  a = 5
        '  total = total + a
        ' End If
        '    If CheckBox7.Checked = True Then
        ' a = 5
        ' total = total + a
        '  End If
        If chk6.Checked = True Then
            a = 250
            total = total + a * txtc6.Text
        End If
        If chk5.Checked = True Then
            a = 100
            total = total + a * txtc5.Text
        End If
    End Sub
    Private Sub BtnLimpiar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnuevareserva.Click
        REM boton para limpiar los campos con contenido
        ' colocamos el total en 0
        total = 0
        REM limpiamos la caja de texto
        txtsaldo.Clear()
        REM limpiamos el listbox
        lstmenureserva.Items.Clear()
        REM limpiamos los checkbox
        chk1.Checked = False
        chk2.Checked = False
        chk3.Checked = False
        chk4.Checked = False
        chk5.Checked = False
        chk6.Checked = False
        txtc1.Clear()
        txtc2.Clear()
        txtc3.Clear()
        txtc4.Clear()
        txtc5.Clear()
        txtc6.Clear()

        '    CheckBox7.Checked = False
        '   CheckBox8.Checked = False
    End Sub

    Private Sub BtnOrden_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdverificar.Click
        REM pone el listbox1 limpio
        lstmenureserva.Items.Clear()
        REM declaramos los if para que aparezca el texto del label
        ' en el listbox segun el checkbox
        If chk1.Checked = True Then
            lstmenureserva.Items.Add(lbl50.Text) '(0))
        End If
        If chk2.Checked = True Then
            lstmenureserva.Items.Add(lbl35.Text) '(1))
        End If
        If chk3.Checked = True Then
            lstmenureserva.Items.Add(lbl200.Text) '(2))
        End If
        If chk4.Checked = True Then
            lstmenureserva.Items.Add(lbl4.Text) '(3))
        End If
        '   If CheckBox8.Checked = True Then
        '  ListBox1.Items.Add(Label14.Text) '(4))
        '  End If
        '  If CheckBox7.Checked = True Then
        'ListBox1.Items.Add(Label13.Text) '(5))
        '  End If
        If chk6.Checked = True Then
            lstmenureserva.Items.Add(lbl6.Text) '(6))
        End If
        If chk5.Checked = True Then
            lstmenureserva.Items.Add(lbl5.Text) '(7))
        End If
    End Sub
End Class

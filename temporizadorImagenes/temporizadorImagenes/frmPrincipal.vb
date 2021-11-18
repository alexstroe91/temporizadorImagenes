Public Class frmPrincipal
    Private Sub lbxMarcas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxMarcas.SelectedIndexChanged

        'establezco la imagen de fondo dependiendo de lo que hayamos seleccionado en el listbox
        Select Case lbxMarcas.SelectedIndex
            Case 0
                pbxEquipos.Image = Image.FromFile(".\imagenes\aprilia.jpeg")
            Case 1
                pbxEquipos.Image = Image.FromFile(".\imagenes\ducati.jpeg")
            Case 2
                pbxEquipos.Image = Image.FromFile(".\imagenes\honda.jpg")
            Case 3
                pbxEquipos.Image = Image.FromFile(".\imagenes\yamaha.jpeg")
            Case 4
                pbxEquipos.Image = Image.FromFile(".\imagenes\ktm.jpg")
            Case 5
                pbxEquipos.Image = Image.FromFile(".\imagenes\suzuki.jpg")

        End Select

    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        'activo el temporizador y selecciono el primer item de la lista
        Timer1.Enabled = True
        lbxMarcas.SelectedIndex = 0

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'si el index es = al nr de items de la lista - 1, paro el temporizador, sino le sumo 1
        If lbxMarcas.SelectedIndex = lbxMarcas.Items.Count - 1 Then
            Timer1.Enabled = False
        Else
            lbxMarcas.SelectedIndex += 1
        End If

    End Sub
End Class

Public Class frmPrincipal
    Private Sub lbxMarcas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxMarcas.SelectedIndexChanged

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
End Class

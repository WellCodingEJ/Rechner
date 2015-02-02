Public Class Form1


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbFlaechen.CheckedChanged
        cbAll.Items.Clear()
        cbAll.Items.Add("Kreis")
        cbAll.Items.Add("Trapez")
        cbAll.Items.Add("Dreieck")
        cbAll.Items.Add("Parallelogramm")
        lFormel.Visible = False
        bWerteEingeben.Visible = False
        cbFormelAuswahl.Visible = False
        cbFormelAuswahl.Items.Clear()
        cbFormelAuswahl.Items.Add("Flächeninhalt")
        cbFormelAuswahl.Items.Add("Umfang")
        cbFormelAuswahl.Text = "Flächeninhalt"
        cbAll.Visible = True

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbKoerper.CheckedChanged
        cbAll.Items.Clear()
        cbAll.Items.Add("Quader")
        cbAll.Items.Add("Zylinder")
        cbAll.Items.Add("Prisma")
        cbAll.Items.Add("Pyramide")
        cbAll.Items.Add("Kegel")
        cbAll.Items.Add("Kugel")
        lFormel.Visible = False
        bWerteEingeben.Visible = False
        cbFormelAuswahl.Visible = False
        cbFormelAuswahl.Items.Clear()
        cbFormelAuswahl.Items.Add("Volumen")
        cbFormelAuswahl.Items.Add("Oberfläche")
        cbFormelAuswahl.Text = "Volumen"
        cbAll.Visible = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rbProzent.CheckedChanged
        cbAll.Items.Clear()
        cbAll.Items.Add("Prozentrechnung")
        cbAll.Items.Add("Zinsrechnung")
        lFormel.Visible = False
        bWerteEingeben.Visible = False
        cbFormelAuswahl.Visible = False
        cbFormelAuswahl.Items.Clear()
        cbAll.Visible = True

    End Sub


    Private Sub cbAll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAll.SelectedIndexChanged

        lFormel.Text = ""
        'Werte anzeigen
        If cbAll.Text = "Kreis" Then
            lFormel.Text = ""
            bWerteEingeben.Visible = True
            cbFormelAuswahl.Visible = True
            cbFormelAuswahl.Text = "Flächeninhalt"
            lFormel.Visible = True
            lFormel.Text = "A = π * r²"

        End If

        If cbAll.Text = "Trapez" Then
            bWerteEingeben.Visible = True
            cbFormelAuswahl.Visible = True
            cbFormelAuswahl.Text = "Flächeninhalt"
            lFormel.Visible = True
            lFormel.Text = "A = a + c / 2 * h "
        End If

        If cbAll.Text = "Dreieck" Then
            bWerteEingeben.Visible = True
            cbFormelAuswahl.Visible = True
            cbFormelAuswahl.Text = "Flächeninhalt"
            lFormel.Visible = True
            lFormel.Text = "A = g * h / 2"

        End If
        If cbAll.Text = "Parallelogramm" Then
            bWerteEingeben.Visible = True
            cbFormelAuswahl.Visible = True
            cbFormelAuswahl.Text = "Flächeninhalt"
            lFormel.Visible = True
            lFormel.Text = "A = g * h"

        End If

        If cbAll.Text = "Quader" Then
            bWerteEingeben.Visible = True
            cbFormelAuswahl.Visible = True
            cbFormelAuswahl.Text = "Volumen"
            lFormel.Visible = True
            lFormel.Text = "V = a * b * c"
        End If

        If cbAll.Text = "Zylinder" Then
            bWerteEingeben.Visible = True
            cbFormelAuswahl.Visible = True
            cbFormelAuswahl.Text = "Volumen"
            lFormel.Visible = True
            lFormel.Text = "V = π * r² * h"
        End If

        If cbAll.Text = "Prisma" Then
            bWerteEingeben.Visible = True
            cbFormelAuswahl.Visible = True
            cbFormelAuswahl.Text = "Volumen"
            lFormel.Visible = True
            lFormel.Text = "V = G * h"
        End If

        If cbAll.Text = "Pyramide" Then
            bWerteEingeben.Visible = True
            cbFormelAuswahl.Visible = True
            cbFormelAuswahl.Text = "Volumen"
            lFormel.Visible = True
            lFormel.Text = "V = 1/3 * G * h"
        End If

        If cbAll.Text = "Kegel" Then
            bWerteEingeben.Visible = True
            cbFormelAuswahl.Visible = True
            cbFormelAuswahl.Text = "Volumen"
            lFormel.Visible = True
            lFormel.Text = "V = 1/3 * G * h"
        End If

        If cbAll.Text = "Kugel" Then
            bWerteEingeben.Visible = True
            cbFormelAuswahl.Visible = True
            cbFormelAuswahl.Text = "Volumen"
            lFormel.Visible = True
            lFormel.Text = "V = 4/3 *  r³"
        End If

    End Sub
    Private Sub cbFormelAuswahl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFormelAuswahl.SelectedIndexChanged
        If cbAll.Text = "Kreis" Then
            If cbFormelAuswahl.Text = "Flächeninhalt" Then
                lFormel.Text = "A = π * r²"
            End If

            If cbFormelAuswahl.Text = "Umfang" Then
                lFormel.Text = "U = π * d"
            End If
        End If

        If cbAll.Text = "Trapez" Then
            If cbFormelAuswahl.Text = "Flächeninhalt" Then
                lFormel.Text = "A = a + c / 2 * h "
            End If

            If cbFormelAuswahl.Text = "Umfang" Then
                lFormel.Text = "U = a + b + c + d"
            End If
        End If

        If cbAll.Text = "Dreieck" Then
            If cbFormelAuswahl.Text = "Flächeninhalt" Then
                lFormel.Text = "A = g * h / 2"
            End If

            If cbFormelAuswahl.Text = "Umfang" Then
                lFormel.Text = "U = a + b + c"
            End If
        End If

        If cbAll.Text = "Parallelogramm" Then
            If cbFormelAuswahl.Text = "Flächeninhalt" Then
                lFormel.Text = "A = g * h"
            End If

            If cbFormelAuswahl.Text = "Umfang" Then
                lFormel.Text = "U = 2 * a + 2 * b"
            End If
        End If

        If cbAll.Text = "Quader" Then
            If cbFormelAuswahl.Text = "Volumen" Then
                lFormel.Text = "V = a * b * c"
            End If

            If cbFormelAuswahl.Text = "Oberfläche" Then
                lFormel.Text = "O = 2*a*b + 2*b*c + 2*a*c"
            End If
        End If


        If cbAll.Text = "Zylinder" Then
            If cbFormelAuswahl.Text = "Volumen" Then
                lFormel.Text = "V = π * r² * h "
            End If

            If cbFormelAuswahl.Text = "Oberfläche" Then
                lFormel.Text = "O = 2 * G + M"
            End If
        End If

        If cbAll.Text = "Prisma" Then
            If cbFormelAuswahl.Text = "Volumen" Then
                lFormel.Text = "V = G * h"
            End If

            If cbFormelAuswahl.Text = "Oberfläche" Then
                lFormel.Text = "O = 2 * G + M"
            End If
        End If

        If cbAll.Text = "Pyramide" Then
            If cbFormelAuswahl.Text = "Volumen" Then
                lFormel.Text = "V = 1/3 * G * h "
            End If

            If cbFormelAuswahl.Text = "Oberfläche" Then
                lFormel.Text = "O = G + M "
            End If
        End If

        If cbAll.Text = "Kegel" Then
            If cbFormelAuswahl.Text = "Volumen" Then
                lFormel.Text = "V = 1/3 * G * h "
            End If

            If cbFormelAuswahl.Text = "Oberfläche" Then
                lFormel.Text = "O = π*r² + π*r*s"
            End If
        End If

        If cbAll.Text = "Kugel" Then
            If cbFormelAuswahl.Text = "Volumen" Then
                lFormel.Text = "V = 4/3 * π * r³"
            End If

            If cbFormelAuswahl.Text = "Oberfläche" Then
                lFormel.Text = "O = 4 * π * r²"
            End If
        End If
    End Sub


    Private Sub bBeenden_Click(sender As Object, e As EventArgs) Handles bBeenden.Click
        'Form1 schließen
        Me.Close()
    End Sub

    Private Sub bWerteEingeben_Click(sender As Object, e As EventArgs) Handles bWerteEingeben.Click
        'Form2 anzeigen und mich selber read only machen
        Me.Enabled = False
        Form2.Show()
    End Sub

    Private Sub gbFormeln_Enter(sender As Object, e As EventArgs) Handles gbFormeln.Enter

    End Sub
End Class

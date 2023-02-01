Imports Microsoft.Office.Interop 'Pour Excel


Public Class FrmListePatineurs

    Private Sub cmdChargerExcel_Click(sender As Object, e As EventArgs) Handles cmdChargerExcel.Click
        Dim L As Integer
        L = 1
        Try
            'Pour vider les listView
            LvListePatineurs.Items.Clear()
            LvCoursesPatineurs.Items.Clear()

            Dim xl As New Excel.Application
            xl.Visible = True
            xl.Workbooks.Open(Application.StartupPath & "\ListePatineurs.xlsx") ' Pour ouvrir le fichier

            'Boucle pour lire tout le contenu du fichier 
            Do While xl.Cells(L, 1).Value <> ""
                Dim patineurs As String
                Dim Str_Patineurs() As String

                patineurs = xl.Cells(L, 1).Value
                Str_Patineurs = Split(patineurs, " ", 8)
                Str_Patineurs(7) = Trim(Str_Patineurs(7))
                Str_Patineurs(6) = Strings.Right(Str_Patineurs(7), 6)
                Str_Patineurs(7) = Strings.Left(Str_Patineurs(7), Len(Str_Patineurs(7)) - 6)
                Str_Patineurs(7) = Trim(Str_Patineurs(7))

                'Ajouter les patineurs
                Dim patineur As New ListViewItem(Str_Patineurs(0))
                If Str_Patineurs(4) = "" Then
                    patineur.SubItems.Add(Str_Patineurs(2))
                    patineur.SubItems.Add(Str_Patineurs(3))
                    patineur.SubItems.Add(Str_Patineurs(5))
                    patineur.SubItems.Add(Str_Patineurs(7))
                    patineur.SubItems.Add(Str_Patineurs(6))
                Else
                    patineur.SubItems.Add(Str_Patineurs(2))
                    patineur.SubItems.Add(Str_Patineurs(3))
                    patineur.SubItems.Add(Str_Patineurs(4))
                    patineur.SubItems.Add(Str_Patineurs(7))
                    patineur.SubItems.Add(Str_Patineurs(6))
                End If
                LvListePatineurs.Items.Add(patineur)
                L = L + 1

                'Boucle sur les courses
                Do While xl.Cells(L, 2).Value <> ""
                    Dim course As New ListViewItem(Str_Patineurs(0))
                    course.SubItems.Add(xl.Cells(L, 1).Value)
                    course.SubItems.Add(xl.Cells(L, 2).Value)
                    course.SubItems.Add(xl.Cells(L, 4).Value)
                    course.SubItems.Add(xl.Cells(L, 5).Value)
                    course.SubItems.Add(xl.Cells(L, 3).Value)
                    course.SubItems.Add(xl.Cells(L, 6).Value)
                    LvCoursesPatineurs.Items.Add(course)
                    L = L + 1
                Loop

                'L = L + 4
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

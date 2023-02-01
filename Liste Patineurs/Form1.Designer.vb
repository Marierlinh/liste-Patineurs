<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListePatineurs
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LvListePatineurs = New System.Windows.Forms.ListView()
        Me.colNoPatineur = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrenom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAge = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colClub = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPointsTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LvCoursesPatineurs = New System.Windows.Forms.ListView()
        Me.colNoPatineur1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNoCourse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDistance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPosition = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTemps = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNomCourse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPoints = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdChargerExcel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LvListePatineurs
        '
        Me.LvListePatineurs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LvListePatineurs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNoPatineur, Me.colNom, Me.colPrenom, Me.colAge, Me.colClub, Me.colPointsTotal})
        Me.LvListePatineurs.HideSelection = False
        Me.LvListePatineurs.Location = New System.Drawing.Point(19, 12)
        Me.LvListePatineurs.Name = "LvListePatineurs"
        Me.LvListePatineurs.Size = New System.Drawing.Size(749, 588)
        Me.LvListePatineurs.TabIndex = 0
        Me.LvListePatineurs.UseCompatibleStateImageBehavior = False
        Me.LvListePatineurs.View = System.Windows.Forms.View.Details
        '
        'colNoPatineur
        '
        Me.colNoPatineur.Text = "No Patineur"
        Me.colNoPatineur.Width = 137
        '
        'colNom
        '
        Me.colNom.Text = "Nom"
        Me.colNom.Width = 126
        '
        'colPrenom
        '
        Me.colPrenom.Text = "Prénom"
        Me.colPrenom.Width = 150
        '
        'colAge
        '
        Me.colAge.Text = "Age"
        Me.colAge.Width = 61
        '
        'colClub
        '
        Me.colClub.Text = "Club"
        Me.colClub.Width = 123
        '
        'colPointsTotal
        '
        Me.colPointsTotal.Text = "Points Total"
        Me.colPointsTotal.Width = 128
        '
        'LvCoursesPatineurs
        '
        Me.LvCoursesPatineurs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LvCoursesPatineurs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNoPatineur1, Me.colNoCourse, Me.colDistance, Me.colPosition, Me.colTemps, Me.colNomCourse, Me.colPoints})
        Me.LvCoursesPatineurs.HideSelection = False
        Me.LvCoursesPatineurs.Location = New System.Drawing.Point(775, 13)
        Me.LvCoursesPatineurs.Name = "LvCoursesPatineurs"
        Me.LvCoursesPatineurs.Size = New System.Drawing.Size(746, 588)
        Me.LvCoursesPatineurs.TabIndex = 1
        Me.LvCoursesPatineurs.UseCompatibleStateImageBehavior = False
        Me.LvCoursesPatineurs.View = System.Windows.Forms.View.Details
        '
        'colNoPatineur1
        '
        Me.colNoPatineur1.Text = "No Patineur"
        Me.colNoPatineur1.Width = 127
        '
        'colNoCourse
        '
        Me.colNoCourse.Text = "No Course"
        Me.colNoCourse.Width = 119
        '
        'colDistance
        '
        Me.colDistance.Text = "Distance"
        Me.colDistance.Width = 102
        '
        'colPosition
        '
        Me.colPosition.Text = "Position"
        Me.colPosition.Width = 95
        '
        'colTemps
        '
        Me.colTemps.Text = "Temps"
        Me.colTemps.Width = 82
        '
        'colNomCourse
        '
        Me.colNomCourse.Text = "Nom Course"
        Me.colNomCourse.Width = 139
        '
        'colPoints
        '
        Me.colPoints.Text = "Points"
        Me.colPoints.Width = 78
        '
        'cmdChargerExcel
        '
        Me.cmdChargerExcel.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdChargerExcel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChargerExcel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdChargerExcel.Location = New System.Drawing.Point(654, 606)
        Me.cmdChargerExcel.Name = "cmdChargerExcel"
        Me.cmdChargerExcel.Size = New System.Drawing.Size(234, 50)
        Me.cmdChargerExcel.TabIndex = 2
        Me.cmdChargerExcel.Text = "Charger Excel"
        Me.cmdChargerExcel.UseVisualStyleBackColor = False
        '
        'FrmListePatineurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1536, 660)
        Me.Controls.Add(Me.cmdChargerExcel)
        Me.Controls.Add(Me.LvCoursesPatineurs)
        Me.Controls.Add(Me.LvListePatineurs)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmListePatineurs"
        Me.Text = "Liste Patineurs"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LvListePatineurs As ListView
    Friend WithEvents LvCoursesPatineurs As ListView
    Friend WithEvents cmdChargerExcel As Button
    Friend WithEvents colNoPatineur As ColumnHeader
    Friend WithEvents colNom As ColumnHeader
    Friend WithEvents colPrenom As ColumnHeader
    Friend WithEvents colAge As ColumnHeader
    Friend WithEvents colClub As ColumnHeader
    Friend WithEvents colPointsTotal As ColumnHeader
    Friend WithEvents colNoPatineur1 As ColumnHeader
    Friend WithEvents colNoCourse As ColumnHeader
    Friend WithEvents colDistance As ColumnHeader
    Friend WithEvents colPosition As ColumnHeader
    Friend WithEvents colTemps As ColumnHeader
    Friend WithEvents colNomCourse As ColumnHeader
    Friend WithEvents colPoints As ColumnHeader
End Class

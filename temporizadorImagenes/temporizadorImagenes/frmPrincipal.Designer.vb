<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.lblImagen = New System.Windows.Forms.Label()
        Me.lbxMarcas = New System.Windows.Forms.ListBox()
        Me.lblEquipos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.pbxEquipos = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbxEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblImagen
        '
        Me.lblImagen.BackColor = System.Drawing.SystemColors.Control
        Me.lblImagen.Image = CType(resources.GetObject("lblImagen.Image"), System.Drawing.Image)
        Me.lblImagen.Location = New System.Drawing.Point(50, 13)
        Me.lblImagen.Name = "lblImagen"
        Me.lblImagen.Size = New System.Drawing.Size(187, 165)
        Me.lblImagen.TabIndex = 0
        '
        'lbxMarcas
        '
        Me.lbxMarcas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxMarcas.FormattingEnabled = True
        Me.lbxMarcas.ItemHeight = 20
        Me.lbxMarcas.Items.AddRange(New Object() {"Aprilia", "Ducati", "Honda", "Yamaha", "KTM", "Suzuki"})
        Me.lbxMarcas.Location = New System.Drawing.Point(362, 59)
        Me.lbxMarcas.Name = "lbxMarcas"
        Me.lbxMarcas.Size = New System.Drawing.Size(137, 164)
        Me.lbxMarcas.TabIndex = 1
        '
        'lblEquipos
        '
        Me.lblEquipos.BackColor = System.Drawing.SystemColors.Control
        Me.lblEquipos.Location = New System.Drawing.Point(50, 240)
        Me.lblEquipos.Name = "lblEquipos"
        Me.lblEquipos.Size = New System.Drawing.Size(187, 165)
        Me.lblEquipos.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Selecciona un equipo"
        '
        'btnCargar
        '
        Me.btnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.Location = New System.Drawing.Point(62, 190)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(161, 33)
        Me.btnCargar.TabIndex = 4
        Me.btnCargar.Text = "Cargar equipos"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'pbxEquipos
        '
        Me.pbxEquipos.Location = New System.Drawing.Point(12, 240)
        Me.pbxEquipos.Name = "pbxEquipos"
        Me.pbxEquipos.Size = New System.Drawing.Size(502, 279)
        Me.pbxEquipos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxEquipos.TabIndex = 5
        Me.pbxEquipos.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 531)
        Me.Controls.Add(Me.pbxEquipos)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEquipos)
        Me.Controls.Add(Me.lbxMarcas)
        Me.Controls.Add(Me.lblImagen)
        Me.Name = "frmPrincipal"
        Me.Text = "Form1"
        CType(Me.pbxEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblImagen As Label
    Friend WithEvents lbxMarcas As ListBox
    Friend WithEvents lblEquipos As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCargar As Button
    Friend WithEvents pbxEquipos As PictureBox
    Friend WithEvents Timer1 As Timer
End Class

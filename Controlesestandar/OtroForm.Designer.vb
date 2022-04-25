<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OtroForm
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
        Me.cbdeptos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbmunicipios = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbdeptos
        '
        Me.cbdeptos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbdeptos.FormattingEnabled = True
        Me.cbdeptos.Items.AddRange(New Object() {"Alta Verapaz", "Baja Verapaz", "Chimaltenango", "Chiquimula", "Guatemala", "El Progreso", "Escuintla", "Huehuetenango", "Izabal", "Jalapa", "Jutiapa", "Petén", "Quetzaltenango", "Quiché", "Retalhuleu", "Sacatepequez", "San Marcos", "Santa Rosa", "Sololá", "Suchitepequez", "Totonicapán", "Zacapa"})
        Me.cbdeptos.Location = New System.Drawing.Point(41, 94)
        Me.cbdeptos.Name = "cbdeptos"
        Me.cbdeptos.Size = New System.Drawing.Size(171, 21)
        Me.cbdeptos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Departamento"
        '
        'cbmunicipios
        '
        Me.cbmunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmunicipios.FormattingEnabled = True
        Me.cbmunicipios.Location = New System.Drawing.Point(240, 94)
        Me.cbmunicipios.Name = "cbmunicipios"
        Me.cbmunicipios.Size = New System.Drawing.Size(171, 21)
        Me.cbmunicipios.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Municipio"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.ComboBox1.Location = New System.Drawing.Point(430, 94)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(427, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Zonas"
        '
        'OtroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 344)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbmunicipios)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbdeptos)
        Me.Name = "OtroForm"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbdeptos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbmunicipios As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
End Class

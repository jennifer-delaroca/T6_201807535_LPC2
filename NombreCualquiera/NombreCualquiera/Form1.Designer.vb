<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Sumar = New System.Windows.Forms.Button()
        Me.Restar = New System.Windows.Forms.Button()
        Me.Multiplicar = New System.Windows.Forms.Button()
        Me.Dividir = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.num_menos1 = New System.Windows.Forms.Button()
        Me.num_mas1 = New System.Windows.Forms.Button()
        Me.num_menos2 = New System.Windows.Forms.Button()
        Me.num_mas2 = New System.Windows.Forms.Button()
        Me.num1 = New System.Windows.Forms.Label()
        Me.num2 = New System.Windows.Forms.Label()
        Me.Carnet = New System.Windows.Forms.Label()
        Me.Respuesta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Sumar
        '
        Me.Sumar.Location = New System.Drawing.Point(501, 77)
        Me.Sumar.Name = "Sumar"
        Me.Sumar.Size = New System.Drawing.Size(75, 23)
        Me.Sumar.TabIndex = 0
        Me.Sumar.Text = "Sumar"
        Me.Sumar.UseVisualStyleBackColor = True
        '
        'Restar
        '
        Me.Restar.Location = New System.Drawing.Point(501, 106)
        Me.Restar.Name = "Restar"
        Me.Restar.Size = New System.Drawing.Size(75, 23)
        Me.Restar.TabIndex = 1
        Me.Restar.Text = "Restar"
        Me.Restar.UseVisualStyleBackColor = True
        '
        'Multiplicar
        '
        Me.Multiplicar.Location = New System.Drawing.Point(501, 135)
        Me.Multiplicar.Name = "Multiplicar"
        Me.Multiplicar.Size = New System.Drawing.Size(75, 23)
        Me.Multiplicar.TabIndex = 2
        Me.Multiplicar.Text = "Multiplicar"
        Me.Multiplicar.UseVisualStyleBackColor = True
        '
        'Dividir
        '
        Me.Dividir.Location = New System.Drawing.Point(501, 164)
        Me.Dividir.Name = "Dividir"
        Me.Dividir.Size = New System.Drawing.Size(75, 23)
        Me.Dividir.TabIndex = 3
        Me.Dividir.Text = "Dividir"
        Me.Dividir.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(501, 193)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Limpiar.TabIndex = 4
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'num_menos1
        '
        Me.num_menos1.Location = New System.Drawing.Point(96, 135)
        Me.num_menos1.Name = "num_menos1"
        Me.num_menos1.Size = New System.Drawing.Size(75, 23)
        Me.num_menos1.TabIndex = 6
        Me.num_menos1.Text = "-"
        Me.num_menos1.UseVisualStyleBackColor = True
        '
        'num_mas1
        '
        Me.num_mas1.Location = New System.Drawing.Point(259, 135)
        Me.num_mas1.Name = "num_mas1"
        Me.num_mas1.Size = New System.Drawing.Size(75, 23)
        Me.num_mas1.TabIndex = 7
        Me.num_mas1.Text = "+"
        Me.num_mas1.UseVisualStyleBackColor = True
        '
        'num_menos2
        '
        Me.num_menos2.Location = New System.Drawing.Point(96, 185)
        Me.num_menos2.Name = "num_menos2"
        Me.num_menos2.Size = New System.Drawing.Size(75, 23)
        Me.num_menos2.TabIndex = 8
        Me.num_menos2.Text = "-"
        Me.num_menos2.UseVisualStyleBackColor = True
        '
        'num_mas2
        '
        Me.num_mas2.Location = New System.Drawing.Point(259, 185)
        Me.num_mas2.Name = "num_mas2"
        Me.num_mas2.Size = New System.Drawing.Size(75, 23)
        Me.num_mas2.TabIndex = 9
        Me.num_mas2.Text = "+"
        Me.num_mas2.UseVisualStyleBackColor = True
        '
        'num1
        '
        Me.num1.AutoSize = True
        Me.num1.Location = New System.Drawing.Point(194, 139)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(13, 15)
        Me.num1.TabIndex = 10
        Me.num1.Text = "0"
        '
        'num2
        '
        Me.num2.AutoSize = True
        Me.num2.Location = New System.Drawing.Point(194, 185)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(13, 15)
        Me.num2.TabIndex = 11
        Me.num2.Text = "0"
        '
        'Carnet
        '
        Me.Carnet.AutoSize = True
        Me.Carnet.Location = New System.Drawing.Point(490, 360)
        Me.Carnet.Name = "Carnet"
        Me.Carnet.Size = New System.Drawing.Size(61, 15)
        Me.Carnet.TabIndex = 12
        Me.Carnet.Text = "201807535"
        '
        'Respuesta
        '
        Me.Respuesta.AutoSize = True
        Me.Respuesta.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Respuesta.Location = New System.Drawing.Point(194, 282)
        Me.Respuesta.Name = "Respuesta"
        Me.Respuesta.Size = New System.Drawing.Size(45, 54)
        Me.Respuesta.TabIndex = 13
        Me.Respuesta.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 403)
        Me.Controls.Add(Me.Respuesta)
        Me.Controls.Add(Me.Carnet)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.num_mas2)
        Me.Controls.Add(Me.num_menos2)
        Me.Controls.Add(Me.num_mas1)
        Me.Controls.Add(Me.num_menos1)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Dividir)
        Me.Controls.Add(Me.Multiplicar)
        Me.Controls.Add(Me.Restar)
        Me.Controls.Add(Me.Sumar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Sumar As Button
    Friend WithEvents Restar As Button
    Friend WithEvents Multiplicar As Button
    Friend WithEvents Dividir As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents num_menos1 As Button
    Friend WithEvents num_mas1 As Button
    Friend WithEvents num_menos2 As Button
    Friend WithEvents num_mas2 As Button
    Friend WithEvents num1 As Label
    Friend WithEvents num2 As Label
    Friend WithEvents Carnet As Label
    Friend WithEvents Respuesta As Label
End Class

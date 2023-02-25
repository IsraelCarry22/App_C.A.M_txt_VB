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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtmAbrir = New System.Windows.Forms.Button()
        Me.BtmGuardar_como = New System.Windows.Forms.Button()
        Me.BtmGuardar = New System.Windows.Forms.Button()
        Me.BtmLimpiar = New System.Windows.Forms.Button()
        Me.TxtTexto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(101, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hoja Txt"
        '
        'BtmAbrir
        '
        Me.BtmAbrir.Location = New System.Drawing.Point(308, 65)
        Me.BtmAbrir.Name = "BtmAbrir"
        Me.BtmAbrir.Size = New System.Drawing.Size(112, 34)
        Me.BtmAbrir.TabIndex = 1
        Me.BtmAbrir.Text = "Abrir"
        Me.BtmAbrir.UseVisualStyleBackColor = True
        '
        'BtmGuardar_como
        '
        Me.BtmGuardar_como.Location = New System.Drawing.Point(308, 185)
        Me.BtmGuardar_como.Name = "BtmGuardar_como"
        Me.BtmGuardar_como.Size = New System.Drawing.Size(112, 34)
        Me.BtmGuardar_como.TabIndex = 2
        Me.BtmGuardar_como.Text = "Guardar como"
        Me.BtmGuardar_como.UseVisualStyleBackColor = True
        '
        'BtmGuardar
        '
        Me.BtmGuardar.Location = New System.Drawing.Point(308, 105)
        Me.BtmGuardar.Name = "BtmGuardar"
        Me.BtmGuardar.Size = New System.Drawing.Size(112, 34)
        Me.BtmGuardar.TabIndex = 3
        Me.BtmGuardar.Text = "Guardar"
        Me.BtmGuardar.UseVisualStyleBackColor = True
        '
        'BtmLimpiar
        '
        Me.BtmLimpiar.Location = New System.Drawing.Point(308, 145)
        Me.BtmLimpiar.Name = "BtmLimpiar"
        Me.BtmLimpiar.Size = New System.Drawing.Size(112, 34)
        Me.BtmLimpiar.TabIndex = 4
        Me.BtmLimpiar.Text = "Limpiar"
        Me.BtmLimpiar.UseVisualStyleBackColor = True
        '
        'TxtTexto
        '
        Me.TxtTexto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtTexto.Location = New System.Drawing.Point(12, 65)
        Me.TxtTexto.Multiline = True
        Me.TxtTexto.Name = "TxtTexto"
        Me.TxtTexto.Size = New System.Drawing.Size(270, 435)
        Me.TxtTexto.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 512)
        Me.Controls.Add(Me.TxtTexto)
        Me.Controls.Add(Me.BtmLimpiar)
        Me.Controls.Add(Me.BtmGuardar)
        Me.Controls.Add(Me.BtmGuardar_como)
        Me.Controls.Add(Me.BtmAbrir)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtmAbrir As Button
    Friend WithEvents BtmGuardar_como As Button
    Friend WithEvents BtmGuardar As Button
    Friend WithEvents BtmLimpiar As Button
    Friend WithEvents TxtTexto As TextBox
End Class

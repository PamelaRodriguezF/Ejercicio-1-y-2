<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ValoresLista = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.NuevoValorCampo = New System.Windows.Forms.TextBox()
        Me.NuevoValorBoton = New System.Windows.Forms.Button()
        Me.PromedioBoton = New System.Windows.Forms.Button()
        Me.PromedioCampo = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ValoresLista
        '
        Me.ValoresLista.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValoresLista.FormattingEnabled = True
        Me.ValoresLista.ItemHeight = 19
        Me.ValoresLista.Location = New System.Drawing.Point(3, 29)
        Me.ValoresLista.Name = "ValoresLista"
        Me.ValoresLista.Size = New System.Drawing.Size(171, 175)
        Me.ValoresLista.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(287, 23)
        Me.Panel1.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(264, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(23, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'NuevoValorCampo
        '
        Me.NuevoValorCampo.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoValorCampo.Location = New System.Drawing.Point(180, 29)
        Me.NuevoValorCampo.Name = "NuevoValorCampo"
        Me.NuevoValorCampo.Size = New System.Drawing.Size(100, 23)
        Me.NuevoValorCampo.TabIndex = 2
        '
        'NuevoValorBoton
        '
        Me.NuevoValorBoton.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoValorBoton.Location = New System.Drawing.Point(180, 58)
        Me.NuevoValorBoton.Name = "NuevoValorBoton"
        Me.NuevoValorBoton.Size = New System.Drawing.Size(100, 25)
        Me.NuevoValorBoton.TabIndex = 3
        Me.NuevoValorBoton.Text = "Ingresar"
        Me.NuevoValorBoton.UseVisualStyleBackColor = True
        '
        'PromedioBoton
        '
        Me.PromedioBoton.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromedioBoton.Location = New System.Drawing.Point(180, 180)
        Me.PromedioBoton.Name = "PromedioBoton"
        Me.PromedioBoton.Size = New System.Drawing.Size(100, 25)
        Me.PromedioBoton.TabIndex = 5
        Me.PromedioBoton.Text = "Promedio"
        Me.PromedioBoton.UseVisualStyleBackColor = True
        '
        'PromedioCampo
        '
        Me.PromedioCampo.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromedioCampo.Location = New System.Drawing.Point(180, 151)
        Me.PromedioCampo.Name = "PromedioCampo"
        Me.PromedioCampo.Size = New System.Drawing.Size(100, 23)
        Me.PromedioCampo.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(287, 212)
        Me.Controls.Add(Me.PromedioBoton)
        Me.Controls.Add(Me.PromedioCampo)
        Me.Controls.Add(Me.NuevoValorBoton)
        Me.Controls.Add(Me.NuevoValorCampo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ValoresLista)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ValoresLista As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NuevoValorCampo As TextBox
    Friend WithEvents NuevoValorBoton As Button
    Friend WithEvents PromedioBoton As Button
    Friend WithEvents PromedioCampo As TextBox
    Friend WithEvents Button3 As Button
End Class

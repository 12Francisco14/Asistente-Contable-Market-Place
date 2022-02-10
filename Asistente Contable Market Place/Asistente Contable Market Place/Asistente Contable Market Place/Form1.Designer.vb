<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(165, 292)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(107, 16)
        Me.label1.TabIndex = 31
        Me.label1.Text = "Cargando al 0 %"
        '
        'pictureBox5
        '
        Me.pictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox5.BackgroundImage = CType(resources.GetObject("pictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox5.Location = New System.Drawing.Point(290, 258)
        Me.pictureBox5.Name = "pictureBox5"
        Me.pictureBox5.Size = New System.Drawing.Size(20, 22)
        Me.pictureBox5.TabIndex = 26
        Me.pictureBox5.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImage = CType(resources.GetObject("pictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox2.Location = New System.Drawing.Point(175, 258)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(20, 22)
        Me.pictureBox2.TabIndex = 29
        Me.pictureBox2.TabStop = False
        '
        'pictureBox4
        '
        Me.pictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox4.BackgroundImage = CType(resources.GetObject("pictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox4.Location = New System.Drawing.Point(252, 258)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(20, 22)
        Me.pictureBox4.TabIndex = 27
        Me.pictureBox4.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox3.BackgroundImage = CType(resources.GetObject("pictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox3.Location = New System.Drawing.Point(213, 258)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(20, 22)
        Me.pictureBox3.TabIndex = 28
        Me.pictureBox3.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(139, 258)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(20, 22)
        Me.pictureBox1.TabIndex = 30
        Me.pictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Asistente_Contable_Market_Place.My.Resources.Resources.Nombre
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(443, 324)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox5)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.pictureBox4)
        Me.Controls.Add(Me.pictureBox3)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents pictureBox5 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox4 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox3 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class

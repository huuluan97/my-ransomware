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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnWhatToDo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'btnWhatToDo
        '
        Me.btnWhatToDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWhatToDo.Location = New System.Drawing.Point(69, 46)
        Me.btnWhatToDo.Name = "btnWhatToDo"
        Me.btnWhatToDo.Size = New System.Drawing.Size(143, 50)
        Me.btnWhatToDo.TabIndex = 0
        Me.btnWhatToDo.Text = "What to do ?"
        Me.btnWhatToDo.UseVisualStyleBackColor = true
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(54, 163)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(871, 189)
        Me.Panel1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox1.Location = New System.Drawing.Point(57, 59)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(311, 50)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(400, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 510)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnWhatToDo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Luận-nana Cry"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents btnWhatToDo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class

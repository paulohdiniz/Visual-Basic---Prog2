<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtChars = New System.Windows.Forms.TextBox()
        Me.SubstringBTN = New System.Windows.Forms.Button()
        Me.InStrBTN = New System.Windows.Forms.Button()
        Me.CharsBTN = New System.Windows.Forms.Button()
        Me.EqualsBTN = New System.Windows.Forms.Button()
        Me.ReplaceBTN = New System.Windows.Forms.Button()
        Me.InsertBTN = New System.Windows.Forms.Button()
        Me.SplitBTN = New System.Windows.Forms.Button()
        Me.JoinBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Length"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtChars
        '
        Me.txtChars.Location = New System.Drawing.Point(96, 12)
        Me.txtChars.Multiline = True
        Me.txtChars.Name = "txtChars"
        Me.txtChars.Size = New System.Drawing.Size(163, 50)
        Me.txtChars.TabIndex = 1
        '
        'SubstringBTN
        '
        Me.SubstringBTN.Location = New System.Drawing.Point(18, 91)
        Me.SubstringBTN.Name = "SubstringBTN"
        Me.SubstringBTN.Size = New System.Drawing.Size(114, 48)
        Me.SubstringBTN.TabIndex = 2
        Me.SubstringBTN.Text = "SubstringBTN"
        Me.SubstringBTN.UseVisualStyleBackColor = True
        '
        'InStrBTN
        '
        Me.InStrBTN.Location = New System.Drawing.Point(18, 166)
        Me.InStrBTN.Name = "InStrBTN"
        Me.InStrBTN.Size = New System.Drawing.Size(107, 42)
        Me.InStrBTN.TabIndex = 3
        Me.InStrBTN.Text = "InStr"
        Me.InStrBTN.UseVisualStyleBackColor = True
        '
        'CharsBTN
        '
        Me.CharsBTN.Location = New System.Drawing.Point(18, 230)
        Me.CharsBTN.Name = "CharsBTN"
        Me.CharsBTN.Size = New System.Drawing.Size(115, 52)
        Me.CharsBTN.TabIndex = 4
        Me.CharsBTN.Text = "Chars"
        Me.CharsBTN.UseVisualStyleBackColor = True
        '
        'EqualsBTN
        '
        Me.EqualsBTN.Location = New System.Drawing.Point(18, 320)
        Me.EqualsBTN.Name = "EqualsBTN"
        Me.EqualsBTN.Size = New System.Drawing.Size(133, 75)
        Me.EqualsBTN.TabIndex = 5
        Me.EqualsBTN.Text = "Equals"
        Me.EqualsBTN.UseVisualStyleBackColor = True
        '
        'ReplaceBTN
        '
        Me.ReplaceBTN.Location = New System.Drawing.Point(202, 87)
        Me.ReplaceBTN.Name = "ReplaceBTN"
        Me.ReplaceBTN.Size = New System.Drawing.Size(141, 51)
        Me.ReplaceBTN.TabIndex = 6
        Me.ReplaceBTN.Text = "Replace"
        Me.ReplaceBTN.UseVisualStyleBackColor = True
        '
        'InsertBTN
        '
        Me.InsertBTN.Location = New System.Drawing.Point(195, 167)
        Me.InsertBTN.Name = "InsertBTN"
        Me.InsertBTN.Size = New System.Drawing.Size(147, 63)
        Me.InsertBTN.TabIndex = 7
        Me.InsertBTN.Text = "Insert"
        Me.InsertBTN.UseVisualStyleBackColor = True
        '
        'SplitBTN
        '
        Me.SplitBTN.Location = New System.Drawing.Point(489, 53)
        Me.SplitBTN.Name = "SplitBTN"
        Me.SplitBTN.Size = New System.Drawing.Size(145, 85)
        Me.SplitBTN.TabIndex = 8
        Me.SplitBTN.Text = "Split"
        Me.SplitBTN.UseVisualStyleBackColor = True
        '
        'JoinBTN
        '
        Me.JoinBTN.Location = New System.Drawing.Point(486, 191)
        Me.JoinBTN.Name = "JoinBTN"
        Me.JoinBTN.Size = New System.Drawing.Size(127, 103)
        Me.JoinBTN.TabIndex = 9
        Me.JoinBTN.Text = "Join"
        Me.JoinBTN.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.JoinBTN)
        Me.Controls.Add(Me.SplitBTN)
        Me.Controls.Add(Me.InsertBTN)
        Me.Controls.Add(Me.ReplaceBTN)
        Me.Controls.Add(Me.EqualsBTN)
        Me.Controls.Add(Me.CharsBTN)
        Me.Controls.Add(Me.InStrBTN)
        Me.Controls.Add(Me.SubstringBTN)
        Me.Controls.Add(Me.txtChars)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtChars As TextBox
    Friend WithEvents SubstringBTN As Button
    Friend WithEvents InStrBTN As Button
    Friend WithEvents CharsBTN As Button
    Friend WithEvents EqualsBTN As Button
    Friend WithEvents ReplaceBTN As Button
    Friend WithEvents InsertBTN As Button
    Friend WithEvents SplitBTN As Button
    Friend WithEvents JoinBTN As Button
End Class

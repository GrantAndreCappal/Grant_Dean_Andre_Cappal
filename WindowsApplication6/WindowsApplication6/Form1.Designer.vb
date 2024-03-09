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
        Me.math_txtbox = New System.Windows.Forms.TextBox()
        Me.science_txtbox = New System.Windows.Forms.TextBox()
        Me.english_txt_box = New System.Windows.Forms.TextBox()
        Me.evaluate_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.science_txt_box = New System.Windows.Forms.Label()
        Me.english_txtbox = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'math_txtbox
        '
        Me.math_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.math_txtbox.Location = New System.Drawing.Point(65, 79)
        Me.math_txtbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.math_txtbox.Name = "math_txtbox"
        Me.math_txtbox.Size = New System.Drawing.Size(435, 22)
        Me.math_txtbox.TabIndex = 0
        '
        'science_txtbox
        '
        Me.science_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.science_txtbox.Location = New System.Drawing.Point(65, 159)
        Me.science_txtbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.science_txtbox.Name = "science_txtbox"
        Me.science_txtbox.Size = New System.Drawing.Size(433, 22)
        Me.science_txtbox.TabIndex = 1
        '
        'english_txt_box
        '
        Me.english_txt_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.english_txt_box.Location = New System.Drawing.Point(65, 238)
        Me.english_txt_box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.english_txt_box.Name = "english_txt_box"
        Me.english_txt_box.Size = New System.Drawing.Size(429, 22)
        Me.english_txt_box.TabIndex = 2
        '
        'evaluate_btn
        '
        Me.evaluate_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.evaluate_btn.Location = New System.Drawing.Point(193, 299)
        Me.evaluate_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.evaluate_btn.Name = "evaluate_btn"
        Me.evaluate_btn.Size = New System.Drawing.Size(175, 48)
        Me.evaluate_btn.TabIndex = 3
        Me.evaluate_btn.Text = "EVALUATE"
        Me.evaluate_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "MATH"
        '
        'science_txt_box
        '
        Me.science_txt_box.AutoSize = True
        Me.science_txt_box.Location = New System.Drawing.Point(68, 145)
        Me.science_txt_box.Name = "science_txt_box"
        Me.science_txt_box.Size = New System.Drawing.Size(66, 16)
        Me.science_txt_box.TabIndex = 5
        Me.science_txt_box.Text = "SCIENCE"
        '
        'english_txtbox
        '
        Me.english_txtbox.AutoSize = True
        Me.english_txtbox.Location = New System.Drawing.Point(68, 224)
        Me.english_txtbox.Name = "english_txtbox"
        Me.english_txtbox.Size = New System.Drawing.Size(66, 16)
        Me.english_txtbox.TabIndex = 6
        Me.english_txtbox.Text = "ENGLISH"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(567, 375)
        Me.Controls.Add(Me.english_txtbox)
        Me.Controls.Add(Me.science_txt_box)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.evaluate_btn)
        Me.Controls.Add(Me.english_txt_box)
        Me.Controls.Add(Me.science_txtbox)
        Me.Controls.Add(Me.math_txtbox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "GRADE FORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents math_txtbox As TextBox
    Friend WithEvents science_txtbox As TextBox
    Friend WithEvents english_txt_box As TextBox
    Friend WithEvents evaluate_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents science_txt_box As Label
    Friend WithEvents english_txtbox As Label
End Class

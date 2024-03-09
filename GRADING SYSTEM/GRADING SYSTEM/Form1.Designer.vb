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
        Me.english_txtbox = New System.Windows.Forms.Label()
        Me.science_txt_box = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.math_txtbox = New System.Windows.Forms.TextBox()
        Me.science_txtbox = New System.Windows.Forms.TextBox()
        Me.english_txt_box = New System.Windows.Forms.TextBox()
        Me.evaluate_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'english_txtbox
        '
        Me.english_txtbox.AutoSize = True
        Me.english_txtbox.Location = New System.Drawing.Point(-91, 190)
        Me.english_txtbox.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.english_txtbox.Name = "english_txtbox"
        Me.english_txtbox.Size = New System.Drawing.Size(66, 16)
        Me.english_txtbox.TabIndex = 13
        Me.english_txtbox.Text = "ENGLISH"
        '
        'science_txt_box
        '
        Me.science_txt_box.AutoSize = True
        Me.science_txt_box.Location = New System.Drawing.Point(-91, 92)
        Me.science_txt_box.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.science_txt_box.Name = "science_txt_box"
        Me.science_txt_box.Size = New System.Drawing.Size(66, 16)
        Me.science_txt_box.TabIndex = 12
        Me.science_txt_box.Text = "SCIENCE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-91, -6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "MATH"
        '
        'math_txtbox
        '
        Me.math_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.math_txtbox.Location = New System.Drawing.Point(82, 51)
        Me.math_txtbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.math_txtbox.Name = "math_txtbox"
        Me.math_txtbox.Size = New System.Drawing.Size(392, 22)
        Me.math_txtbox.TabIndex = 14
        '
        'science_txtbox
        '
        Me.science_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.science_txtbox.Location = New System.Drawing.Point(82, 129)
        Me.science_txtbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.science_txtbox.Name = "science_txtbox"
        Me.science_txtbox.Size = New System.Drawing.Size(392, 22)
        Me.science_txtbox.TabIndex = 15
        '
        'english_txt_box
        '
        Me.english_txt_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.english_txt_box.Location = New System.Drawing.Point(82, 205)
        Me.english_txt_box.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.english_txt_box.Name = "english_txt_box"
        Me.english_txt_box.Size = New System.Drawing.Size(392, 22)
        Me.english_txt_box.TabIndex = 16
        '
        'evaluate_btn
        '
        Me.evaluate_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.evaluate_btn.Location = New System.Drawing.Point(222, 275)
        Me.evaluate_btn.Name = "evaluate_btn"
        Me.evaluate_btn.Size = New System.Drawing.Size(138, 49)
        Me.evaluate_btn.TabIndex = 17
        Me.evaluate_btn.Text = "EVALUATE"
        Me.evaluate_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "MATH"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "SCIENCE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "ENGLISH"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 336)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.evaluate_btn)
        Me.Controls.Add(Me.english_txt_box)
        Me.Controls.Add(Me.science_txtbox)
        Me.Controls.Add(Me.math_txtbox)
        Me.Controls.Add(Me.english_txtbox)
        Me.Controls.Add(Me.science_txt_box)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "GRADE FORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents english_txtbox As Label
    Friend WithEvents science_txt_box As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents math_txtbox As TextBox
    Friend WithEvents science_txtbox As TextBox
    Friend WithEvents english_txt_box As TextBox
    Friend WithEvents evaluate_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class

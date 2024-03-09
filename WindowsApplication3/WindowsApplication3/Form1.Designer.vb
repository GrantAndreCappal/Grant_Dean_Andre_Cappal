<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.total_txtbox = New System.Windows.Forms.TextBox()
        Me.seven_btn = New System.Windows.Forms.Button()
        Me.multiplication_btn = New System.Windows.Forms.Button()
        Me.eight_btn = New System.Windows.Forms.Button()
        Me.nine_btn = New System.Windows.Forms.Button()
        Me.four_btn = New System.Windows.Forms.Button()
        Me.five_btn = New System.Windows.Forms.Button()
        Me.six_btn = New System.Windows.Forms.Button()
        Me.subtraction_btn = New System.Windows.Forms.Button()
        Me.one_btn = New System.Windows.Forms.Button()
        Me.three_btn = New System.Windows.Forms.Button()
        Me.two_btn = New System.Windows.Forms.Button()
        Me.addition_btn = New System.Windows.Forms.Button()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.zero_btn = New System.Windows.Forms.Button()
        Me.division_btn = New System.Windows.Forms.Button()
        Me.equal_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'total_txtbox
        '
        Me.total_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_txtbox.Location = New System.Drawing.Point(12, 37)
        Me.total_txtbox.Name = "total_txtbox"
        Me.total_txtbox.Size = New System.Drawing.Size(268, 38)
        Me.total_txtbox.TabIndex = 0
        '
        'seven_btn
        '
        Me.seven_btn.Location = New System.Drawing.Point(11, 90)
        Me.seven_btn.Name = "seven_btn"
        Me.seven_btn.Size = New System.Drawing.Size(65, 43)
        Me.seven_btn.TabIndex = 1
        Me.seven_btn.Text = "7"
        Me.seven_btn.UseVisualStyleBackColor = True
        '
        'multiplication_btn
        '
        Me.multiplication_btn.Location = New System.Drawing.Point(219, 90)
        Me.multiplication_btn.Name = "multiplication_btn"
        Me.multiplication_btn.Size = New System.Drawing.Size(64, 43)
        Me.multiplication_btn.TabIndex = 2
        Me.multiplication_btn.Text = "x"
        Me.multiplication_btn.UseVisualStyleBackColor = True
        '
        'eight_btn
        '
        Me.eight_btn.Location = New System.Drawing.Point(81, 90)
        Me.eight_btn.Name = "eight_btn"
        Me.eight_btn.Size = New System.Drawing.Size(64, 43)
        Me.eight_btn.TabIndex = 3
        Me.eight_btn.Text = "8"
        Me.eight_btn.UseVisualStyleBackColor = True
        '
        'nine_btn
        '
        Me.nine_btn.Location = New System.Drawing.Point(150, 90)
        Me.nine_btn.Name = "nine_btn"
        Me.nine_btn.Size = New System.Drawing.Size(64, 43)
        Me.nine_btn.TabIndex = 4
        Me.nine_btn.Text = "9"
        Me.nine_btn.UseVisualStyleBackColor = True
        '
        'four_btn
        '
        Me.four_btn.Location = New System.Drawing.Point(12, 151)
        Me.four_btn.Name = "four_btn"
        Me.four_btn.Size = New System.Drawing.Size(65, 43)
        Me.four_btn.TabIndex = 5
        Me.four_btn.Text = "4"
        Me.four_btn.UseVisualStyleBackColor = True
        '
        'five_btn
        '
        Me.five_btn.Location = New System.Drawing.Point(83, 151)
        Me.five_btn.Name = "five_btn"
        Me.five_btn.Size = New System.Drawing.Size(65, 43)
        Me.five_btn.TabIndex = 6
        Me.five_btn.Text = "5"
        Me.five_btn.UseVisualStyleBackColor = True
        '
        'six_btn
        '
        Me.six_btn.Location = New System.Drawing.Point(150, 151)
        Me.six_btn.Name = "six_btn"
        Me.six_btn.Size = New System.Drawing.Size(65, 43)
        Me.six_btn.TabIndex = 7
        Me.six_btn.Text = "6"
        Me.six_btn.UseVisualStyleBackColor = True
        '
        'subtraction_btn
        '
        Me.subtraction_btn.Location = New System.Drawing.Point(219, 151)
        Me.subtraction_btn.Name = "subtraction_btn"
        Me.subtraction_btn.Size = New System.Drawing.Size(65, 43)
        Me.subtraction_btn.TabIndex = 8
        Me.subtraction_btn.Text = "-"
        Me.subtraction_btn.UseVisualStyleBackColor = True
        '
        'one_btn
        '
        Me.one_btn.Location = New System.Drawing.Point(12, 211)
        Me.one_btn.Name = "one_btn"
        Me.one_btn.Size = New System.Drawing.Size(65, 43)
        Me.one_btn.TabIndex = 9
        Me.one_btn.Text = "1"
        Me.one_btn.UseVisualStyleBackColor = True
        '
        'three_btn
        '
        Me.three_btn.Location = New System.Drawing.Point(150, 211)
        Me.three_btn.Name = "three_btn"
        Me.three_btn.Size = New System.Drawing.Size(65, 43)
        Me.three_btn.TabIndex = 10
        Me.three_btn.Text = "3"
        Me.three_btn.UseVisualStyleBackColor = True
        '
        'two_btn
        '
        Me.two_btn.Location = New System.Drawing.Point(81, 211)
        Me.two_btn.Name = "two_btn"
        Me.two_btn.Size = New System.Drawing.Size(65, 43)
        Me.two_btn.TabIndex = 11
        Me.two_btn.Text = "2"
        Me.two_btn.UseVisualStyleBackColor = True
        '
        'addition_btn
        '
        Me.addition_btn.Location = New System.Drawing.Point(219, 211)
        Me.addition_btn.Name = "addition_btn"
        Me.addition_btn.Size = New System.Drawing.Size(65, 43)
        Me.addition_btn.TabIndex = 12
        Me.addition_btn.Text = "+"
        Me.addition_btn.UseVisualStyleBackColor = True
        '
        'clear_btn
        '
        Me.clear_btn.Location = New System.Drawing.Point(8, 274)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(65, 43)
        Me.clear_btn.TabIndex = 13
        Me.clear_btn.Text = "C"
        Me.clear_btn.UseVisualStyleBackColor = True
        '
        'zero_btn
        '
        Me.zero_btn.Location = New System.Drawing.Point(79, 274)
        Me.zero_btn.Name = "zero_btn"
        Me.zero_btn.Size = New System.Drawing.Size(65, 43)
        Me.zero_btn.TabIndex = 14
        Me.zero_btn.Text = "0"
        Me.zero_btn.UseVisualStyleBackColor = True
        '
        'division_btn
        '
        Me.division_btn.Location = New System.Drawing.Point(150, 274)
        Me.division_btn.Name = "division_btn"
        Me.division_btn.Size = New System.Drawing.Size(65, 43)
        Me.division_btn.TabIndex = 15
        Me.division_btn.Text = "÷"
        Me.division_btn.UseVisualStyleBackColor = True
        '
        'equal_btn
        '
        Me.equal_btn.Location = New System.Drawing.Point(222, 274)
        Me.equal_btn.Name = "equal_btn"
        Me.equal_btn.Size = New System.Drawing.Size(65, 43)
        Me.equal_btn.TabIndex = 16
        Me.equal_btn.Text = "="
        Me.equal_btn.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(292, 338)
        Me.Controls.Add(Me.equal_btn)
        Me.Controls.Add(Me.division_btn)
        Me.Controls.Add(Me.zero_btn)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.addition_btn)
        Me.Controls.Add(Me.two_btn)
        Me.Controls.Add(Me.three_btn)
        Me.Controls.Add(Me.one_btn)
        Me.Controls.Add(Me.subtraction_btn)
        Me.Controls.Add(Me.six_btn)
        Me.Controls.Add(Me.five_btn)
        Me.Controls.Add(Me.four_btn)
        Me.Controls.Add(Me.nine_btn)
        Me.Controls.Add(Me.eight_btn)
        Me.Controls.Add(Me.multiplication_btn)
        Me.Controls.Add(Me.seven_btn)
        Me.Controls.Add(Me.total_txtbox)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents total_txtbox As TextBox
    Friend WithEvents seven_btn As Button
    Friend WithEvents multiplication_btn As Button
    Friend WithEvents eight_btn As Button
    Friend WithEvents nine_btn As Button
    Friend WithEvents four_btn As Button
    Friend WithEvents five_btn As Button
    Friend WithEvents six_btn As Button
    Friend WithEvents subtraction_btn As Button
    Friend WithEvents one_btn As Button
    Friend WithEvents three_btn As Button
    Friend WithEvents two_btn As Button
    Friend WithEvents addition_btn As Button
    Friend WithEvents clear_btn As Button
    Friend WithEvents zero_btn As Button
    Friend WithEvents division_btn As Button
    Friend WithEvents equal_btn As Button
End Class

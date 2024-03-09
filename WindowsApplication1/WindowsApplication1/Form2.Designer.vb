<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.un_txtbox = New System.Windows.Forms.TextBox()
        Me.email_txtbox = New System.Windows.Forms.TextBox()
        Me.pw_txtbox = New System.Windows.Forms.TextBox()
        Me.signup_btn = New System.Windows.Forms.Button()
        Me.un_lbl = New System.Windows.Forms.Label()
        Me.pw_lbl = New System.Windows.Forms.Label()
        Me.enail_lbl = New System.Windows.Forms.Label()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'un_txtbox
        '
        Me.un_txtbox.BackColor = System.Drawing.SystemColors.Info
        Me.un_txtbox.Location = New System.Drawing.Point(196, 101)
        Me.un_txtbox.Name = "un_txtbox"
        Me.un_txtbox.Size = New System.Drawing.Size(285, 20)
        Me.un_txtbox.TabIndex = 0
        '
        'email_txtbox
        '
        Me.email_txtbox.BackColor = System.Drawing.SystemColors.Info
        Me.email_txtbox.Location = New System.Drawing.Point(196, 163)
        Me.email_txtbox.Name = "email_txtbox"
        Me.email_txtbox.Size = New System.Drawing.Size(285, 20)
        Me.email_txtbox.TabIndex = 1
        '
        'pw_txtbox
        '
        Me.pw_txtbox.BackColor = System.Drawing.SystemColors.Info
        Me.pw_txtbox.Location = New System.Drawing.Point(196, 217)
        Me.pw_txtbox.Name = "pw_txtbox"
        Me.pw_txtbox.Size = New System.Drawing.Size(285, 20)
        Me.pw_txtbox.TabIndex = 2
        '
        'signup_btn
        '
        Me.signup_btn.BackColor = System.Drawing.Color.DarkKhaki
        Me.signup_btn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signup_btn.Location = New System.Drawing.Point(355, 259)
        Me.signup_btn.Name = "signup_btn"
        Me.signup_btn.Size = New System.Drawing.Size(135, 34)
        Me.signup_btn.TabIndex = 3
        Me.signup_btn.Text = "Sign Up"
        Me.signup_btn.UseVisualStyleBackColor = False
        '
        'un_lbl
        '
        Me.un_lbl.AutoSize = True
        Me.un_lbl.Font = New System.Drawing.Font("Courier New", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.un_lbl.Location = New System.Drawing.Point(196, 82)
        Me.un_lbl.Name = "un_lbl"
        Me.un_lbl.Size = New System.Drawing.Size(99, 19)
        Me.un_lbl.TabIndex = 4
        Me.un_lbl.Text = "Username:"
        '
        'pw_lbl
        '
        Me.pw_lbl.AutoSize = True
        Me.pw_lbl.Font = New System.Drawing.Font("Courier New", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pw_lbl.Location = New System.Drawing.Point(197, 196)
        Me.pw_lbl.Name = "pw_lbl"
        Me.pw_lbl.Size = New System.Drawing.Size(99, 19)
        Me.pw_lbl.TabIndex = 5
        Me.pw_lbl.Text = "Password:"
        '
        'enail_lbl
        '
        Me.enail_lbl.AutoSize = True
        Me.enail_lbl.Font = New System.Drawing.Font("Courier New", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enail_lbl.Location = New System.Drawing.Point(196, 142)
        Me.enail_lbl.Name = "enail_lbl"
        Me.enail_lbl.Size = New System.Drawing.Size(79, 19)
        Me.enail_lbl.TabIndex = 6
        Me.enail_lbl.Text = "E-mail:"
        '
        'cancel_btn
        '
        Me.cancel_btn.BackColor = System.Drawing.Color.Brown
        Me.cancel_btn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_btn.Location = New System.Drawing.Point(201, 259)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(134, 34)
        Me.cancel_btn.TabIndex = 7
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(172, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 28)
        Me.Label1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(175, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 24)
        Me.Label2.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(175, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 23)
        Me.Label3.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(446, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 23)
        Me.Label4.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Brown
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(289, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 23)
        Me.Label5.TabIndex = 12
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(707, 370)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.enail_lbl)
        Me.Controls.Add(Me.pw_lbl)
        Me.Controls.Add(Me.un_lbl)
        Me.Controls.Add(Me.signup_btn)
        Me.Controls.Add(Me.pw_txtbox)
        Me.Controls.Add(Me.email_txtbox)
        Me.Controls.Add(Me.un_txtbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents un_txtbox As TextBox
    Friend WithEvents email_txtbox As TextBox
    Friend WithEvents pw_txtbox As TextBox
    Friend WithEvents signup_btn As Button
    Friend WithEvents un_lbl As Label
    Friend WithEvents pw_lbl As Label
    Friend WithEvents enail_lbl As Label
    Friend WithEvents cancel_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class

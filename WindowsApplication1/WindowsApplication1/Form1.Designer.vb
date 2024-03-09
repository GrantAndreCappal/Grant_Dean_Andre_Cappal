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
        Me.pw_txtbox = New System.Windows.Forms.TextBox()
        Me.un_txtbox = New System.Windows.Forms.TextBox()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.un_lbl = New System.Windows.Forms.Label()
        Me.pw_lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pw_txtbox
        '
        Me.pw_txtbox.BackColor = System.Drawing.SystemColors.Info
        Me.pw_txtbox.Location = New System.Drawing.Point(162, 197)
        Me.pw_txtbox.Name = "pw_txtbox"
        Me.pw_txtbox.Size = New System.Drawing.Size(316, 33)
        Me.pw_txtbox.TabIndex = 0
        '
        'un_txtbox
        '
        Me.un_txtbox.BackColor = System.Drawing.SystemColors.Info
        Me.un_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.un_txtbox.Location = New System.Drawing.Point(162, 128)
        Me.un_txtbox.Name = "un_txtbox"
        Me.un_txtbox.Size = New System.Drawing.Size(316, 26)
        Me.un_txtbox.TabIndex = 1
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.Color.PeachPuff
        Me.login_btn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_btn.Location = New System.Drawing.Point(258, 269)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(139, 37)
        Me.login_btn.TabIndex = 2
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'un_lbl
        '
        Me.un_lbl.AutoSize = True
        Me.un_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.un_lbl.Location = New System.Drawing.Point(158, 103)
        Me.un_lbl.Name = "un_lbl"
        Me.un_lbl.Size = New System.Drawing.Size(109, 22)
        Me.un_lbl.TabIndex = 3
        Me.un_lbl.Text = "Username:"
        '
        'pw_lbl
        '
        Me.pw_lbl.AutoSize = True
        Me.pw_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pw_lbl.Location = New System.Drawing.Point(161, 172)
        Me.pw_lbl.Name = "pw_lbl"
        Me.pw_lbl.Size = New System.Drawing.Size(106, 22)
        Me.pw_lbl.TabIndex = 4
        Me.pw_lbl.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.PeachPuff
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(354, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 28)
        Me.Label3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(160, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 27)
        Me.Label4.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 25)
        Me.Label5.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(160, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 49)
        Me.Label6.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(669, 373)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pw_lbl)
        Me.Controls.Add(Me.un_lbl)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.un_txtbox)
        Me.Controls.Add(Me.pw_txtbox)
        Me.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pw_txtbox As TextBox
    Friend WithEvents un_txtbox As TextBox
    Friend WithEvents login_btn As Button
    Friend WithEvents un_lbl As Label
    Friend WithEvents pw_lbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class

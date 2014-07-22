<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prac02
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.cmdDisplayMsg = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdbSimpleTax = New System.Windows.Forms.RadioButton()
        Me.rdbComplexTax = New System.Windows.Forms.RadioButton()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SURNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SALARY"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(86, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(130, 20)
        Me.txtName.TabIndex = 3
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(86, 69)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(130, 20)
        Me.txtSurname.TabIndex = 4
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(86, 111)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(130, 20)
        Me.txtSalary.TabIndex = 5
        '
        'cmdDisplayMsg
        '
        Me.cmdDisplayMsg.Location = New System.Drawing.Point(15, 223)
        Me.cmdDisplayMsg.Name = "cmdDisplayMsg"
        Me.cmdDisplayMsg.Size = New System.Drawing.Size(106, 39)
        Me.cmdDisplayMsg.TabIndex = 6
        Me.cmdDisplayMsg.Text = "Display Message"
        Me.cmdDisplayMsg.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "TAX TYPE:"
        '
        'rdbSimpleTax
        '
        Me.rdbSimpleTax.AutoSize = True
        Me.rdbSimpleTax.Checked = True
        Me.rdbSimpleTax.Location = New System.Drawing.Point(87, 147)
        Me.rdbSimpleTax.Name = "rdbSimpleTax"
        Me.rdbSimpleTax.Size = New System.Drawing.Size(77, 17)
        Me.rdbSimpleTax.TabIndex = 8
        Me.rdbSimpleTax.TabStop = True
        Me.rdbSimpleTax.Text = "Simple Tax"
        Me.rdbSimpleTax.UseVisualStyleBackColor = True
        '
        'rdbComplexTax
        '
        Me.rdbComplexTax.AutoSize = True
        Me.rdbComplexTax.Location = New System.Drawing.Point(87, 170)
        Me.rdbComplexTax.Name = "rdbComplexTax"
        Me.rdbComplexTax.Size = New System.Drawing.Size(86, 17)
        Me.rdbComplexTax.TabIndex = 9
        Me.rdbComplexTax.Text = "Complex Tax"
        Me.rdbComplexTax.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(142, 223)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(86, 39)
        Me.cmdExit.TabIndex = 10
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Prac02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 288)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.rdbComplexTax)
        Me.Controls.Add(Me.rdbSimpleTax)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdDisplayMsg)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Prac02"
        Me.Text = "frmPrac02"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents cmdDisplayMsg As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdbSimpleTax As System.Windows.Forms.RadioButton
    Friend WithEvents rdbComplexTax As System.Windows.Forms.RadioButton
    Friend WithEvents cmdExit As System.Windows.Forms.Button

End Class

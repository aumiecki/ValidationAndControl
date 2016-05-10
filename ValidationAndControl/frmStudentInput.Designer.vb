<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentInput
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
        Me.components = New System.ComponentModel.Container()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.lblStudentId = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.MainError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.theAddress = New ValidationAndControl.AddressControl()
        CType(Me.MainError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(169, 61)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(168, 22)
        Me.txtFirstName.TabIndex = 15
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(169, 95)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(168, 22)
        Me.txtLastName.TabIndex = 16
        '
        'txtStudentId
        '
        Me.txtStudentId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentId.Location = New System.Drawing.Point(169, 26)
        Me.txtStudentId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(168, 22)
        Me.txtStudentId.TabIndex = 14
        '
        'lblStudentId
        '
        Me.lblStudentId.AutoSize = True
        Me.lblStudentId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentId.Location = New System.Drawing.Point(66, 33)
        Me.lblStudentId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentId.Name = "lblStudentId"
        Me.lblStudentId.Size = New System.Drawing.Size(72, 16)
        Me.lblStudentId.TabIndex = 11
        Me.lblStudentId.Text = "Student ID:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(66, 67)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(76, 16)
        Me.lblFirstName.TabIndex = 12
        Me.lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(66, 101)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(76, 16)
        Me.lblLastName.TabIndex = 13
        Me.lblLastName.Text = "Last Name:"
        '
        'btnExit
        '
        Me.btnExit.CausesValidation = False
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(320, 357)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.CausesValidation = False
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(169, 357)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(9, 357)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtBalance
        '
        Me.txtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.Location = New System.Drawing.Point(169, 129)
        Me.txtBalance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(168, 22)
        Me.txtBalance.TabIndex = 23
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(66, 134)
        Me.lblBalance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(61, 16)
        Me.lblBalance.TabIndex = 22
        Me.lblBalance.Text = "Balance:"
        '
        'MainError
        '
        Me.MainError.ContainerControl = Me
        '
        'theAddress
        '
        Me.theAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.theAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.theAddress.Location = New System.Drawing.Point(48, 159)
        Me.theAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.theAddress.Name = "theAddress"
        Me.theAddress.Size = New System.Drawing.Size(313, 156)
        Me.theAddress.TabIndex = 24
        '
        'frmStudentInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 408)
        Me.Controls.Add(Me.theAddress)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtStudentId)
        Me.Controls.Add(Me.lblStudentId)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmStudentInput"
        Me.Text = "Student Input"
        CType(Me.MainError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents lblStudentId As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents lblBalance As Label
    Friend WithEvents theAddress As AddressControl
    Friend WithEvents MainError As ErrorProvider
End Class

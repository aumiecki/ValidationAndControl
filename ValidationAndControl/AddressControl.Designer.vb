<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.lblStreet1 = New System.Windows.Forms.Label()
        Me.txtStreet1 = New System.Windows.Forms.TextBox()
        Me.txtStreet2 = New System.Windows.Forms.TextBox()
        Me.lblStreet2 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.ErrorHandle = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorHandle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStreet1
        '
        Me.lblStreet1.AutoSize = True
        Me.lblStreet1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreet1.Location = New System.Drawing.Point(16, 16)
        Me.lblStreet1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStreet1.Name = "lblStreet1"
        Me.lblStreet1.Size = New System.Drawing.Size(56, 16)
        Me.lblStreet1.TabIndex = 0
        Me.lblStreet1.Text = "Street 1:"
        '
        'txtStreet1
        '
        Me.txtStreet1.Location = New System.Drawing.Point(120, 10)
        Me.txtStreet1.Name = "txtStreet1"
        Me.txtStreet1.Size = New System.Drawing.Size(168, 22)
        Me.txtStreet1.TabIndex = 1
        '
        'txtStreet2
        '
        Me.txtStreet2.Location = New System.Drawing.Point(120, 38)
        Me.txtStreet2.Name = "txtStreet2"
        Me.txtStreet2.Size = New System.Drawing.Size(168, 22)
        Me.txtStreet2.TabIndex = 3
        '
        'lblStreet2
        '
        Me.lblStreet2.AutoSize = True
        Me.lblStreet2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreet2.Location = New System.Drawing.Point(16, 44)
        Me.lblStreet2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStreet2.Name = "lblStreet2"
        Me.lblStreet2.Size = New System.Drawing.Size(56, 16)
        Me.lblStreet2.TabIndex = 2
        Me.lblStreet2.Text = "Street 2:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(120, 66)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(168, 22)
        Me.txtCity.TabIndex = 5
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(16, 72)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(33, 16)
        Me.lblCity.TabIndex = 4
        Me.lblCity.Text = "City:"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(120, 94)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(168, 22)
        Me.txtState.TabIndex = 7
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(16, 100)
        Me.lblState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(42, 16)
        Me.lblState.TabIndex = 6
        Me.lblState.Text = "State:"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(120, 122)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(168, 22)
        Me.txtZip.TabIndex = 9
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZip.Location = New System.Drawing.Point(16, 128)
        Me.lblZip.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(66, 16)
        Me.lblZip.TabIndex = 8
        Me.lblZip.Text = "Zip Code:"
        '
        'ErrorHandle
        '
        Me.ErrorHandle.ContainerControl = Me
        '
        'AddressControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.txtStreet2)
        Me.Controls.Add(Me.lblStreet2)
        Me.Controls.Add(Me.txtStreet1)
        Me.Controls.Add(Me.lblStreet1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddressControl"
        Me.Size = New System.Drawing.Size(314, 165)
        CType(Me.ErrorHandle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStreet1 As Label
    Friend WithEvents txtStreet1 As TextBox
    Friend WithEvents txtStreet2 As TextBox
    Friend WithEvents lblStreet2 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents lblState As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents lblZip As Label
    Friend WithEvents ErrorHandle As ErrorProvider
End Class

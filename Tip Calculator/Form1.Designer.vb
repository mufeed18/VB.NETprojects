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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBillAmount = New System.Windows.Forms.TextBox()
        Me.btn15 = New System.Windows.Forms.Button()
        Me.btn20 = New System.Windows.Forms.Button()
        Me.btn25 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTip = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(55, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Amount of Bill"
        '
        'txtBillAmount
        '
        Me.txtBillAmount.Location = New System.Drawing.Point(242, 105)
        Me.txtBillAmount.Name = "txtBillAmount"
        Me.txtBillAmount.Size = New System.Drawing.Size(167, 26)
        Me.txtBillAmount.TabIndex = 1
        '
        'btn15
        '
        Me.btn15.Location = New System.Drawing.Point(59, 176)
        Me.btn15.Name = "btn15"
        Me.btn15.Size = New System.Drawing.Size(84, 32)
        Me.btn15.TabIndex = 2
        Me.btn15.Text = "15%"
        Me.btn15.UseVisualStyleBackColor = True
        '
        'btn20
        '
        Me.btn20.Location = New System.Drawing.Point(279, 176)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(84, 32)
        Me.btn20.TabIndex = 3
        Me.btn20.Text = "20%"
        Me.btn20.UseVisualStyleBackColor = True
        '
        'btn25
        '
        Me.btn25.Location = New System.Drawing.Point(493, 176)
        Me.btn25.Name = "btn25"
        Me.btn25.Size = New System.Drawing.Size(84, 32)
        Me.btn25.TabIndex = 4
        Me.btn25.Text = "25%"
        Me.btn25.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(43, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 27)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Amount to tip"
        '
        'lblTip
        '
        Me.lblTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTip.Location = New System.Drawing.Point(311, 283)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(132, 27)
        Me.lblTip.TabIndex = 6
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(148, 375)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 37)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(378, 375)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 37)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 492)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn25)
        Me.Controls.Add(Me.btn20)
        Me.Controls.Add(Me.btn15)
        Me.Controls.Add(Me.txtBillAmount)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Form1"
        Me.Text = "Tip Calculator"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBillAmount As TextBox
    Friend WithEvents btn15 As Button
    Friend WithEvents btn20 As Button
    Friend WithEvents btn25 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTip As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class

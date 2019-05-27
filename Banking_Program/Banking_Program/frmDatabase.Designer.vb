<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDatabase
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBizName = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.Label()
        Me.txtCreditLimit = New System.Windows.Forms.Label()
        Me.txtCreditLimitWarning = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(592, 426)
        Me.DataGridView1.TabIndex = 0
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(732, 402)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(116, 36)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next Customer"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Enabled = False
        Me.btnPrevious.Location = New System.Drawing.Point(610, 402)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(116, 36)
        Me.btnPrevious.TabIndex = 2
        Me.btnPrevious.Text = "Previous Customer"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(733, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Business Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(743, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Email Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(773, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Credit Limit:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(640, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Near Credit Limit ($1000) ? :"
        '
        'txtBizName
        '
        Me.txtBizName.AutoSize = True
        Me.txtBizName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBizName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtBizName.Location = New System.Drawing.Point(886, 35)
        Me.txtBizName.Name = "txtBizName"
        Me.txtBizName.Size = New System.Drawing.Size(16, 24)
        Me.txtBizName.TabIndex = 7
        Me.txtBizName.Text = "-"
        '
        'txtEmail
        '
        Me.txtEmail.AutoSize = True
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtEmail.Location = New System.Drawing.Point(886, 92)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(16, 24)
        Me.txtEmail.TabIndex = 8
        Me.txtEmail.Text = "-"
        '
        'txtCreditLimit
        '
        Me.txtCreditLimit.AutoSize = True
        Me.txtCreditLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditLimit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCreditLimit.Location = New System.Drawing.Point(886, 149)
        Me.txtCreditLimit.Name = "txtCreditLimit"
        Me.txtCreditLimit.Size = New System.Drawing.Size(16, 24)
        Me.txtCreditLimit.TabIndex = 9
        Me.txtCreditLimit.Text = "-"
        '
        'txtCreditLimitWarning
        '
        Me.txtCreditLimitWarning.AutoSize = True
        Me.txtCreditLimitWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditLimitWarning.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCreditLimitWarning.Location = New System.Drawing.Point(886, 214)
        Me.txtCreditLimitWarning.Name = "txtCreditLimitWarning"
        Me.txtCreditLimitWarning.Size = New System.Drawing.Size(16, 24)
        Me.txtCreditLimitWarning.TabIndex = 10
        Me.txtCreditLimitWarning.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(705, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(234, 26)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "CLICK NEXT CUSTOMER TO CHECK IF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " THEY HAVE EXCEEDED THE CREDIT LIMIT "
        '
        'frmDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1165, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCreditLimitWarning)
        Me.Controls.Add(Me.txtCreditLimit)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtBizName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDatabase"
        Me.Text = "The Bank of New England : Administrator"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBizName As Label
    Friend WithEvents txtEmail As Label
    Friend WithEvents txtCreditLimit As Label
    Friend WithEvents txtCreditLimitWarning As Label
    Friend WithEvents Label5 As Label
End Class

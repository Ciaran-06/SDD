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
        Me.cmdFillArray = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmdFindMax = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.LstOutput1 = New System.Windows.Forms.ListBox()
        Me.LstOutput2 = New System.Windows.Forms.ListBox()
        Me.LstReport = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cmdFillArray
        '
        Me.cmdFillArray.Location = New System.Drawing.Point(13, 13)
        Me.cmdFillArray.Name = "cmdFillArray"
        Me.cmdFillArray.Size = New System.Drawing.Size(116, 87)
        Me.cmdFillArray.TabIndex = 0
        Me.cmdFillArray.Text = "Fill Array"
        Me.cmdFillArray.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 87)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Write To File"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(13, 199)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 87)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Read From File"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmdFindMax
        '
        Me.cmdFindMax.Location = New System.Drawing.Point(135, 13)
        Me.cmdFindMax.Name = "cmdFindMax"
        Me.cmdFindMax.Size = New System.Drawing.Size(116, 87)
        Me.cmdFindMax.TabIndex = 3
        Me.cmdFindMax.Text = "Find Max"
        Me.cmdFindMax.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(135, 106)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(116, 87)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Find Min"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(135, 199)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(116, 87)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Count Occs"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(135, 292)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(116, 87)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Linear Search"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'LstOutput1
        '
        Me.LstOutput1.FormattingEnabled = True
        Me.LstOutput1.ItemHeight = 15
        Me.LstOutput1.Location = New System.Drawing.Point(258, 13)
        Me.LstOutput1.Name = "LstOutput1"
        Me.LstOutput1.Size = New System.Drawing.Size(120, 469)
        Me.LstOutput1.TabIndex = 7
        '
        'LstOutput2
        '
        Me.LstOutput2.FormattingEnabled = True
        Me.LstOutput2.ItemHeight = 15
        Me.LstOutput2.Location = New System.Drawing.Point(384, 12)
        Me.LstOutput2.Name = "LstOutput2"
        Me.LstOutput2.Size = New System.Drawing.Size(120, 469)
        Me.LstOutput2.TabIndex = 8
        '
        'LstReport
        '
        Me.LstReport.FormattingEnabled = True
        Me.LstReport.ItemHeight = 15
        Me.LstReport.Location = New System.Drawing.Point(9, 386)
        Me.LstReport.Name = "LstReport"
        Me.LstReport.Size = New System.Drawing.Size(242, 94)
        Me.LstReport.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 492)
        Me.Controls.Add(Me.LstReport)
        Me.Controls.Add(Me.LstOutput2)
        Me.Controls.Add(Me.LstOutput1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.cmdFindMax)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdFillArray)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdFillArray As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents cmdFindMax As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents LstOutput1 As ListBox
    Friend WithEvents LstOutput2 As ListBox
    Friend WithEvents LstReport As ListBox
End Class

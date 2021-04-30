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
        Me.cmdWriteFile = New System.Windows.Forms.Button()
        Me.cmdReadFile = New System.Windows.Forms.Button()
        Me.cmdFindMax = New System.Windows.Forms.Button()
        Me.cmdFindMin = New System.Windows.Forms.Button()
        Me.cmdFindOccs = New System.Windows.Forms.Button()
        Me.cmdLinearSearch = New System.Windows.Forms.Button()
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
        'cmdWriteFile
        '
        Me.cmdWriteFile.Location = New System.Drawing.Point(13, 106)
        Me.cmdWriteFile.Name = "cmdWriteFile"
        Me.cmdWriteFile.Size = New System.Drawing.Size(116, 87)
        Me.cmdWriteFile.TabIndex = 1
        Me.cmdWriteFile.Text = "Write To File"
        Me.cmdWriteFile.UseVisualStyleBackColor = True
        '
        'cmdReadFile
        '
        Me.cmdReadFile.Location = New System.Drawing.Point(13, 199)
        Me.cmdReadFile.Name = "cmdReadFile"
        Me.cmdReadFile.Size = New System.Drawing.Size(116, 87)
        Me.cmdReadFile.TabIndex = 2
        Me.cmdReadFile.Text = "Read From File"
        Me.cmdReadFile.UseVisualStyleBackColor = True
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
        'cmdFindMin
        '
        Me.cmdFindMin.Location = New System.Drawing.Point(135, 106)
        Me.cmdFindMin.Name = "cmdFindMin"
        Me.cmdFindMin.Size = New System.Drawing.Size(116, 87)
        Me.cmdFindMin.TabIndex = 4
        Me.cmdFindMin.Text = "Find Min"
        Me.cmdFindMin.UseVisualStyleBackColor = True
        '
        'cmdFindOccs
        '
        Me.cmdFindOccs.Location = New System.Drawing.Point(135, 199)
        Me.cmdFindOccs.Name = "cmdFindOccs"
        Me.cmdFindOccs.Size = New System.Drawing.Size(116, 87)
        Me.cmdFindOccs.TabIndex = 5
        Me.cmdFindOccs.Text = "Count Occs"
        Me.cmdFindOccs.UseVisualStyleBackColor = True
        '
        'cmdLinearSearch
        '
        Me.cmdLinearSearch.Location = New System.Drawing.Point(13, 292)
        Me.cmdLinearSearch.Name = "cmdLinearSearch"
        Me.cmdLinearSearch.Size = New System.Drawing.Size(238, 44)
        Me.cmdLinearSearch.TabIndex = 6
        Me.cmdLinearSearch.Text = "Linear Search"
        Me.cmdLinearSearch.UseVisualStyleBackColor = True
        '
        'LstOutput1
        '
        Me.LstOutput1.FormattingEnabled = True
        Me.LstOutput1.ItemHeight = 15
        Me.LstOutput1.Location = New System.Drawing.Point(258, 13)
        Me.LstOutput1.Name = "LstOutput1"
        Me.LstOutput1.Size = New System.Drawing.Size(120, 409)
        Me.LstOutput1.TabIndex = 7
        '
        'LstOutput2
        '
        Me.LstOutput2.FormattingEnabled = True
        Me.LstOutput2.ItemHeight = 15
        Me.LstOutput2.Location = New System.Drawing.Point(384, 12)
        Me.LstOutput2.Name = "LstOutput2"
        Me.LstOutput2.Size = New System.Drawing.Size(128, 409)
        Me.LstOutput2.TabIndex = 8
        '
        'LstReport
        '
        Me.LstReport.FormattingEnabled = True
        Me.LstReport.ItemHeight = 15
        Me.LstReport.Location = New System.Drawing.Point(13, 342)
        Me.LstReport.Name = "LstReport"
        Me.LstReport.Size = New System.Drawing.Size(238, 79)
        Me.LstReport.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 436)
        Me.Controls.Add(Me.LstReport)
        Me.Controls.Add(Me.LstOutput2)
        Me.Controls.Add(Me.LstOutput1)
        Me.Controls.Add(Me.cmdLinearSearch)
        Me.Controls.Add(Me.cmdFindOccs)
        Me.Controls.Add(Me.cmdFindMin)
        Me.Controls.Add(Me.cmdFindMax)
        Me.Controls.Add(Me.cmdReadFile)
        Me.Controls.Add(Me.cmdWriteFile)
        Me.Controls.Add(Me.cmdFillArray)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdFillArray As Button
    Friend WithEvents cmdWriteFile As Button
    Friend WithEvents cmdReadFile As Button
    Friend WithEvents cmdFindMax As Button
    Friend WithEvents cmdFindMin As Button
    Friend WithEvents cmdFindOccs As Button
    Friend WithEvents cmdLinearSearch As Button
    Friend WithEvents LstOutput1 As ListBox
    Friend WithEvents LstOutput2 As ListBox
    Friend WithEvents LstReport As ListBox
End Class

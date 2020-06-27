<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageEmployee
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
        Me.components = New System.ComponentModel.Container()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtUnitEntered = New System.Windows.Forms.TextBox()
        Me.lblEmp1 = New System.Windows.Forms.Label()
        Me.lblEmp3 = New System.Windows.Forms.Label()
        Me.lblEmp2 = New System.Windows.Forms.Label()
        Me.txtEmpList1 = New System.Windows.Forms.TextBox()
        Me.txtEmpList2 = New System.Windows.Forms.TextBox()
        Me.txtEmpList3 = New System.Windows.Forms.TextBox()
        Me.lblEmpOutput1 = New System.Windows.Forms.Label()
        Me.lblEmpOutput3 = New System.Windows.Forms.Label()
        Me.lblEmpOutput2 = New System.Windows.Forms.Label()
        Me.lblAvgOutput = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.EmpTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblDay
        '
        Me.lblDay.Location = New System.Drawing.Point(33, 13)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(77, 23)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "Day 1"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.EmpTooltip.SetToolTip(Me.lblDay, "nth number of day will be displayed here")
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(33, 52)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(77, 23)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.EmpTooltip.SetToolTip(Me.lblUnits, "Units label ")
        '
        'txtUnitEntered
        '
        Me.txtUnitEntered.Location = New System.Drawing.Point(117, 52)
        Me.txtUnitEntered.Name = "txtUnitEntered"
        Me.txtUnitEntered.Size = New System.Drawing.Size(79, 22)
        Me.txtUnitEntered.TabIndex = 2
        Me.EmpTooltip.SetToolTip(Me.txtUnitEntered, "Enter the units of the shipment for respective employees")
        '
        'lblEmp1
        '
        Me.lblEmp1.Location = New System.Drawing.Point(69, 117)
        Me.lblEmp1.Name = "lblEmp1"
        Me.lblEmp1.Size = New System.Drawing.Size(100, 23)
        Me.lblEmp1.TabIndex = 3
        Me.lblEmp1.Text = "Employee 1"
        Me.lblEmp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmp3
        '
        Me.lblEmp3.Location = New System.Drawing.Point(393, 117)
        Me.lblEmp3.Name = "lblEmp3"
        Me.lblEmp3.Size = New System.Drawing.Size(100, 23)
        Me.lblEmp3.TabIndex = 4
        Me.lblEmp3.Text = "Employee 3"
        Me.lblEmp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmp2
        '
        Me.lblEmp2.Location = New System.Drawing.Point(231, 117)
        Me.lblEmp2.Name = "lblEmp2"
        Me.lblEmp2.Size = New System.Drawing.Size(100, 23)
        Me.lblEmp2.TabIndex = 5
        Me.lblEmp2.Text = "Employee 2"
        Me.lblEmp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmpList1
        '
        Me.txtEmpList1.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmpList1.Location = New System.Drawing.Point(69, 143)
        Me.txtEmpList1.Multiline = True
        Me.txtEmpList1.Name = "txtEmpList1"
        Me.txtEmpList1.ReadOnly = True
        Me.txtEmpList1.Size = New System.Drawing.Size(100, 127)
        Me.txtEmpList1.TabIndex = 6
        Me.EmpTooltip.SetToolTip(Me.txtEmpList1, "List of the units for employee 1 will be displayed here")
        '
        'txtEmpList2
        '
        Me.txtEmpList2.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmpList2.Location = New System.Drawing.Point(232, 143)
        Me.txtEmpList2.Multiline = True
        Me.txtEmpList2.Name = "txtEmpList2"
        Me.txtEmpList2.ReadOnly = True
        Me.txtEmpList2.Size = New System.Drawing.Size(100, 127)
        Me.txtEmpList2.TabIndex = 7
        Me.EmpTooltip.SetToolTip(Me.txtEmpList2, "List of the units for employee 2 will be displayed here")
        '
        'txtEmpList3
        '
        Me.txtEmpList3.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmpList3.Location = New System.Drawing.Point(395, 143)
        Me.txtEmpList3.Multiline = True
        Me.txtEmpList3.Name = "txtEmpList3"
        Me.txtEmpList3.ReadOnly = True
        Me.txtEmpList3.Size = New System.Drawing.Size(100, 127)
        Me.txtEmpList3.TabIndex = 8
        Me.EmpTooltip.SetToolTip(Me.txtEmpList3, "List of the units for employee 3 will be displayed here")
        '
        'lblEmpOutput1
        '
        Me.lblEmpOutput1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmpOutput1.Location = New System.Drawing.Point(69, 273)
        Me.lblEmpOutput1.Name = "lblEmpOutput1"
        Me.lblEmpOutput1.Size = New System.Drawing.Size(100, 23)
        Me.lblEmpOutput1.TabIndex = 9
        Me.lblEmpOutput1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.EmpTooltip.SetToolTip(Me.lblEmpOutput1, "Average of the units for employee 1 will be displayed")
        '
        'lblEmpOutput3
        '
        Me.lblEmpOutput3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmpOutput3.Location = New System.Drawing.Point(395, 273)
        Me.lblEmpOutput3.Name = "lblEmpOutput3"
        Me.lblEmpOutput3.Size = New System.Drawing.Size(100, 23)
        Me.lblEmpOutput3.TabIndex = 10
        Me.lblEmpOutput3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.EmpTooltip.SetToolTip(Me.lblEmpOutput3, "Average of the units for employee 3 will be displayed")
        '
        'lblEmpOutput2
        '
        Me.lblEmpOutput2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmpOutput2.Location = New System.Drawing.Point(232, 273)
        Me.lblEmpOutput2.Name = "lblEmpOutput2"
        Me.lblEmpOutput2.Size = New System.Drawing.Size(100, 23)
        Me.lblEmpOutput2.TabIndex = 11
        Me.lblEmpOutput2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.EmpTooltip.SetToolTip(Me.lblEmpOutput2, "Average of the units for employee 2 will be displayed")
        '
        'lblAvgOutput
        '
        Me.lblAvgOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgOutput.Location = New System.Drawing.Point(69, 308)
        Me.lblAvgOutput.Name = "lblAvgOutput"
        Me.lblAvgOutput.Size = New System.Drawing.Size(426, 23)
        Me.lblAvgOutput.TabIndex = 12
        Me.lblAvgOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.EmpTooltip.SetToolTip(Me.lblAvgOutput, "FInal average of the averages for the three employees")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(69, 359)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 23)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.EmpTooltip.SetToolTip(Me.btnEnter, "Click to enter the value on the list or to calculate the average")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(395, 359)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.EmpTooltip.SetToolTip(Me.btnExit, "Click to exit the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(232, 359)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 23)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "&Reset"
        Me.EmpTooltip.SetToolTip(Me.btnReset, "Click to reset the form ")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmAverageEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(601, 450)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblAvgOutput)
        Me.Controls.Add(Me.lblEmpOutput2)
        Me.Controls.Add(Me.lblEmpOutput3)
        Me.Controls.Add(Me.lblEmpOutput1)
        Me.Controls.Add(Me.txtEmpList3)
        Me.Controls.Add(Me.txtEmpList2)
        Me.Controls.Add(Me.txtEmpList1)
        Me.Controls.Add(Me.lblEmp2)
        Me.Controls.Add(Me.lblEmp3)
        Me.Controls.Add(Me.lblEmp1)
        Me.Controls.Add(Me.txtUnitEntered)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageEmployee"
        Me.Text = "Average units shipped by employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDay As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtUnitEntered As TextBox
    Friend WithEvents lblEmp1 As Label
    Friend WithEvents lblEmp3 As Label
    Friend WithEvents lblEmp2 As Label
    Friend WithEvents txtEmpList1 As TextBox
    Friend WithEvents txtEmpList2 As TextBox
    Friend WithEvents txtEmpList3 As TextBox
    Friend WithEvents lblEmpOutput1 As Label
    Friend WithEvents lblEmpOutput3 As Label
    Friend WithEvents lblEmpOutput2 As Label
    Friend WithEvents lblAvgOutput As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents EmpTooltip As ToolTip
End Class

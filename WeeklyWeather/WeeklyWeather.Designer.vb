<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeeklyWeather
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
        Me.lblTemperaturePrompt = New System.Windows.Forms.Label()
        Me.txtTemperatureInput = New System.Windows.Forms.TextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.txtWeek1Temperatures = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAverageOutput = New System.Windows.Forms.Label()
        Me.ttpWeatherTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtWeek2Temperatures = New System.Windows.Forms.TextBox()
        Me.txtWeek3Temperatures = New System.Windows.Forms.TextBox()
        Me.lblWeek1Output = New System.Windows.Forms.Label()
        Me.lblWeek2Output = New System.Windows.Forms.Label()
        Me.lblWeek3Output = New System.Windows.Forms.Label()
        Me.lblWeek1Heading = New System.Windows.Forms.Label()
        Me.lblWeek2Heading = New System.Windows.Forms.Label()
        Me.lblWeek3Heading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTemperaturePrompt
        '
        Me.lblTemperaturePrompt.Location = New System.Drawing.Point(15, 9)
        Me.lblTemperaturePrompt.Name = "lblTemperaturePrompt"
        Me.lblTemperaturePrompt.Size = New System.Drawing.Size(129, 23)
        Me.lblTemperaturePrompt.TabIndex = 0
        Me.lblTemperaturePrompt.Text = "&Temperature:"
        Me.lblTemperaturePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTemperatureInput
        '
        Me.txtTemperatureInput.Location = New System.Drawing.Point(177, 11)
        Me.txtTemperatureInput.Name = "txtTemperatureInput"
        Me.txtTemperatureInput.Size = New System.Drawing.Size(129, 22)
        Me.txtTemperatureInput.TabIndex = 1
        Me.ttpWeatherTips.SetToolTip(Me.txtTemperatureInput, "Enter the temperature to record")
        '
        'lblDay
        '
        Me.lblDay.Location = New System.Drawing.Point(341, 10)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(129, 23)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "Day 1"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWeek1Temperatures
        '
        Me.txtWeek1Temperatures.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtWeek1Temperatures.Location = New System.Drawing.Point(15, 67)
        Me.txtWeek1Temperatures.Multiline = True
        Me.txtWeek1Temperatures.Name = "txtWeek1Temperatures"
        Me.txtWeek1Temperatures.ReadOnly = True
        Me.txtWeek1Temperatures.Size = New System.Drawing.Size(129, 175)
        Me.txtWeek1Temperatures.TabIndex = 4
        Me.ttpWeatherTips.SetToolTip(Me.txtWeek1Temperatures, "Displays a list of entered temperatures for week 1")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 316)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(120, 28)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ttpWeatherTips.SetToolTip(Me.btnEnter, "Click to enter your temperature value")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(181, 316)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(120, 28)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ttpWeatherTips.SetToolTip(Me.btnReset, "Click to reset the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(350, 316)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 28)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ttpWeatherTips.SetToolTip(Me.btnExit, "Click to exit the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAverageOutput
        '
        Me.lblAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageOutput.Location = New System.Drawing.Point(12, 282)
        Me.lblAverageOutput.Name = "lblAverageOutput"
        Me.lblAverageOutput.Size = New System.Drawing.Size(458, 23)
        Me.lblAverageOutput.TabIndex = 12
        Me.lblAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpWeatherTips.SetToolTip(Me.lblAverageOutput, "Displays the calculated average temperature for all three weeks")
        '
        'txtWeek2Temperatures
        '
        Me.txtWeek2Temperatures.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtWeek2Temperatures.Location = New System.Drawing.Point(177, 67)
        Me.txtWeek2Temperatures.Multiline = True
        Me.txtWeek2Temperatures.Name = "txtWeek2Temperatures"
        Me.txtWeek2Temperatures.ReadOnly = True
        Me.txtWeek2Temperatures.Size = New System.Drawing.Size(129, 175)
        Me.txtWeek2Temperatures.TabIndex = 7
        Me.ttpWeatherTips.SetToolTip(Me.txtWeek2Temperatures, "Displays a list of entered temperatures for week 2")
        '
        'txtWeek3Temperatures
        '
        Me.txtWeek3Temperatures.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtWeek3Temperatures.Location = New System.Drawing.Point(341, 67)
        Me.txtWeek3Temperatures.Multiline = True
        Me.txtWeek3Temperatures.Name = "txtWeek3Temperatures"
        Me.txtWeek3Temperatures.ReadOnly = True
        Me.txtWeek3Temperatures.Size = New System.Drawing.Size(129, 175)
        Me.txtWeek3Temperatures.TabIndex = 10
        Me.ttpWeatherTips.SetToolTip(Me.txtWeek3Temperatures, "Displays a list of entered temperatures for week 3")
        '
        'lblWeek1Output
        '
        Me.lblWeek1Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeek1Output.Location = New System.Drawing.Point(15, 251)
        Me.lblWeek1Output.Name = "lblWeek1Output"
        Me.lblWeek1Output.Size = New System.Drawing.Size(129, 23)
        Me.lblWeek1Output.TabIndex = 5
        Me.ttpWeatherTips.SetToolTip(Me.lblWeek1Output, "Displays the calculated average temperature for week 1")
        '
        'lblWeek2Output
        '
        Me.lblWeek2Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeek2Output.Location = New System.Drawing.Point(177, 251)
        Me.lblWeek2Output.Name = "lblWeek2Output"
        Me.lblWeek2Output.Size = New System.Drawing.Size(129, 23)
        Me.lblWeek2Output.TabIndex = 8
        Me.ttpWeatherTips.SetToolTip(Me.lblWeek2Output, "Displays the calculated average temperature for week 2")
        '
        'lblWeek3Output
        '
        Me.lblWeek3Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeek3Output.Location = New System.Drawing.Point(341, 251)
        Me.lblWeek3Output.Name = "lblWeek3Output"
        Me.lblWeek3Output.Size = New System.Drawing.Size(129, 23)
        Me.lblWeek3Output.TabIndex = 11
        Me.ttpWeatherTips.SetToolTip(Me.lblWeek3Output, "Displays the calculated average temperature for week 3")
        '
        'lblWeek1Heading
        '
        Me.lblWeek1Heading.Location = New System.Drawing.Point(15, 41)
        Me.lblWeek1Heading.Name = "lblWeek1Heading"
        Me.lblWeek1Heading.Size = New System.Drawing.Size(129, 23)
        Me.lblWeek1Heading.TabIndex = 3
        Me.lblWeek1Heading.Text = "Week 1"
        Me.lblWeek1Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeek2Heading
        '
        Me.lblWeek2Heading.Location = New System.Drawing.Point(177, 41)
        Me.lblWeek2Heading.Name = "lblWeek2Heading"
        Me.lblWeek2Heading.Size = New System.Drawing.Size(129, 23)
        Me.lblWeek2Heading.TabIndex = 6
        Me.lblWeek2Heading.Text = "Week 2"
        Me.lblWeek2Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeek3Heading
        '
        Me.lblWeek3Heading.Location = New System.Drawing.Point(341, 41)
        Me.lblWeek3Heading.Name = "lblWeek3Heading"
        Me.lblWeek3Heading.Size = New System.Drawing.Size(129, 23)
        Me.lblWeek3Heading.TabIndex = 9
        Me.lblWeek3Heading.Text = "Week 3"
        Me.lblWeek3Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmWeeklyWeather
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(482, 353)
        Me.Controls.Add(Me.lblWeek3Output)
        Me.Controls.Add(Me.lblWeek2Output)
        Me.Controls.Add(Me.lblWeek1Output)
        Me.Controls.Add(Me.lblWeek3Heading)
        Me.Controls.Add(Me.lblWeek2Heading)
        Me.Controls.Add(Me.lblWeek1Heading)
        Me.Controls.Add(Me.txtWeek3Temperatures)
        Me.Controls.Add(Me.txtWeek2Temperatures)
        Me.Controls.Add(Me.lblAverageOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtWeek1Temperatures)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.txtTemperatureInput)
        Me.Controls.Add(Me.lblTemperaturePrompt)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWeeklyWeather"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weekly Weather"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTemperaturePrompt As Label
    Friend WithEvents txtTemperatureInput As TextBox
    Friend WithEvents lblDay As Label
    Friend WithEvents txtWeek1Temperatures As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAverageOutput As Label
    Friend WithEvents ttpWeatherTips As ToolTip
    Friend WithEvents txtWeek2Temperatures As TextBox
    Friend WithEvents txtWeek3Temperatures As TextBox
    Friend WithEvents lblWeek1Heading As Label
    Friend WithEvents lblWeek2Heading As Label
    Friend WithEvents lblWeek3Heading As Label
    Friend WithEvents lblWeek1Output As Label
    Friend WithEvents lblWeek2Output As Label
    Friend WithEvents lblWeek3Output As Label
End Class

' Author: Kyle Chapman
' Creation Date: January 21, 2020
' Last Modified Date: February 19, 2020
' Description:
'   Takes input of a temperature, validates it and adds it to
'   a list. After accepting 7 values, an average is calculated
'   and output. Functionality to reset the form and exit is 
'   also included.
'   Expanded to allow for entry of three weeks.

Option Strict On

Public Class frmWeeklyWeather

    ' Variable declarations
    Dim day As Integer = 0
    Dim week As Integer = 0

    Dim totalWeekTemperature As Double
    Dim averageWeekTemperature As Double
    Dim totalOverallTemperature As Double
    Dim averageOverallTemperature As Double

    Dim weatherValues(2, 6) As Double

    Dim textboxArray() As TextBox
    Dim outputLabelArray() As Label

    ''' <summary>
    ''' On form load, initialize arrays of controls
    ''' </summary>
    Private Sub frmWeeklyWeather_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textboxArray = {txtWeek1Temperatures, txtWeek2Temperatures, txtWeek3Temperatures}
        outputLabelArray = {lblWeek1Output, lblWeek2Output, lblWeek3Output}
    End Sub

    ''' <summary>
    ''' Me close form
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Clears all input and output fields, re-enabled disabled
    ''' controls, and sets focus to put the form in a default state
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Clear stuff
        txtTemperatureInput.Clear()
        txtWeek1Temperatures.Clear()
        txtWeek2Temperatures.Clear()
        txtWeek3Temperatures.Clear()

        lblWeek1Output.Text = String.Empty
        lblWeek2Output.Text = String.Empty
        lblWeek3Output.Text = String.Empty
        lblAverageOutput.Text = String.Empty

        ' Re-enable input controls
        txtTemperatureInput.Enabled = True
        btnEnter.Enabled = True

        ' Set default values
        week = 0
        day = 0
        lblDay.Text = "Day " & (day + 1)

        ' Set focus
        txtTemperatureInput.Focus()
    End Sub

    ''' <summary>
    ''' Validate the user's input and record the temperature value
    ''' After seven entries, an average is calculated and output
    ''' </summary>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' Variable declaration
        Const DaysInWeek As Integer = 7
        Const NumberOfWeeks As Integer = 3

        ' Check that the entry is a valid number
        If Double.TryParse(txtTemperatureInput.Text, weatherValues(week, day)) Then

            ' Output the new temperature value
            textboxArray(week).Text &= weatherValues(week, day) & vbCrLf

            txtTemperatureInput.Clear()

            ' Entry is valid; increment the day
            day += 1

            ' If we have reached Day 7, calculate the average
            If day = DaysInWeek Then

                totalWeekTemperature = 0

                For dayCounter As Integer = 0 To DaysInWeek - 1
                    totalWeekTemperature += weatherValues(week, dayCounter)
                Next

                ' Calculate the average temperature for the current week
                averageWeekTemperature = totalWeekTemperature / DaysInWeek

                ' Output the week's average temperature
                outputLabelArray(week).Text = "Average: " & Math.Round(averageWeekTemperature, 2)

                week += 1
                day = 0

            End If

            lblDay.Text = "Day " & (day + 1)

            ' If we have finished week 3, calculate the average
            If week = NumberOfWeeks Then

                totalOverallTemperature = 0

                For Each dayValue In weatherValues
                    totalOverallTemperature += dayValue
                Next

                ' Calculate the average temperature for the current week
                averageOverallTemperature = totalOverallTemperature / weatherValues.Length
                lblAverageOutput.Text = "Average: " & Math.Round(averageOverallTemperature, 2)
                lblDay.Text = "Done"

                ' Disable the input-related controls
                txtTemperatureInput.Enabled = False
                btnEnter.Enabled = False
                btnReset.Focus()

            End If

            ' The entry is not a valid double; show an error message
        Else
                MessageBox.Show("Temperature must be entered as a number.")
            txtTemperatureInput.SelectAll()
            txtTemperatureInput.Focus()
        End If

    End Sub

End Class

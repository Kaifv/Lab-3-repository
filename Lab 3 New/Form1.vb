'AUthor: Kaifkhan Vakil 
'Date: 27th june, 2020
'Description: IN the folloiwng vb file, we will modify the code of lab 1 and make the code running usng the arrays. In this folder we will get the user input for three employees
'and and we will display the average for all the three once the entry for 7 days has been done for each of them. After getting output for all the three employees code will
'display the average of all the averages. We will also validate the code, so that user will enter the correct input with no type of errros. 


Option Strict On
Public Class frmAverageEmployee
    ''' <summary>
    ''' Here we will declare all the variables and constant that will be used in the code futher. 
    ''' </summary>
    Private Const MAX_VALUE = 5000
    Private Const MIN_VALUE = 0

    Dim currentDay As Integer = 0
    Dim employeeCounter As Integer = 0
    Dim dayCounter As Integer = 0
    Dim empUnits(2, 6) As Integer
    Dim averageEmp1 As Double
    Dim averageEmp2 As Double
    Dim averageEmp3 As Double
    Dim finalAverage As Double

    ''' <summary>
    ''' Here in this function we will calcualte the avergae of the input form the user and also we will use the arrays for that 
    ''' Whenever we will calculate the average we will just call the function for the calculation purpose.
    ''' </summary>
    ''' <param name="employeeIndex"></param>
    ''' <returns></returns>

    Function averageDisplay(ByVal employeeIndex As Integer) As Double
        Dim sum As Integer = 0

        For daycounter As Integer = 0 To empUnits.GetUpperBound(1)
            sum += empUnits(employeeIndex, daycounter)

        Next
        Return sum / 7
    End Function

    ''' <summary>
    ''' In this sub procedure i will reset the form to its oiginal state, user can enter reset button whenever he wants. 
    ''' </summary>
    Sub resetForm()
        txtUnitEntered.Text = ""
        txtEmpList1.Text = ""
        txtEmpList2.Text = ""
        txtEmpList3.Text = ""
        lblEmpOutput1.Text = ""
        lblEmpOutput2.Text = ""
        lblEmpOutput3.Text = ""
        lblAvgOutput.Text = ""
        txtUnitEntered.Focus()
        btnEnter.Enabled = True
        currentDay = 1
        txtUnitEntered.ReadOnly = False

    End Sub

    ''' <summary>
    ''' This is the event handler of exit button which will exit the form whenever pressed. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    ''' <summary>
    ''' This event handler is the main button in the form, execution will perfomr all the major function in the form including calculating average. IN this event only all
    ''' the validation will aslo occur and message showing the error will also be shown. All the if else statements handle all the working
    ''' in the enter event handler. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim userInput As String = txtUnitEntered.Text
        Dim inputAsInt As Integer
        txtUnitEntered.Text = ""


        If IsNumeric(userInput) Then
            inputAsInt = CInt(userInput)
            currentDay += 1
            lblDay.Text = "Day " + (dayCounter + 1).ToString

            If inputAsInt.ToString = userInput Then
                If inputAsInt >= MIN_VALUE And inputAsInt <= MAX_VALUE Then

                    empUnits(employeeCounter, dayCounter) = inputAsInt
                    If employeeCounter = 0 Then
                        txtEmpList1.Text += userInput + vbCrLf
                    End If
                    If employeeCounter = 1 Then
                        txtEmpList2.Text += userInput + vbCrLf
                    End If
                    If employeeCounter = 2 Then
                        txtEmpList3.Text += userInput + vbCrLf
                    End If
                    dayCounter += 1

                    If dayCounter = 7 Then
                        If employeeCounter = 0 Then
                            averageEmp1 = averageDisplay(employeeCounter)
                            lblEmpOutput1.Text = "Average: " & Math.Round(averageEmp1, 2).ToString
                        End If

                        If employeeCounter = 1 Then
                            ' txtEmpList2.Text += userInput + vbCrLf
                            averageEmp2 = averageDisplay(employeeCounter)
                            lblEmpOutput2.Text = "Average: " & Math.Round(averageEmp2, 2).ToString
                        End If
                        If employeeCounter = 2 Then
                            '  txtEmpList3.Text += userInput + vbCrLf
                            averageEmp3 = averageDisplay(employeeCounter)
                            lblEmpOutput3.Text = "Average: " & Math.Round(averageEmp3, 2).ToString
                            finalAverage = (averageEmp1 + averageEmp2 + averageEmp3) / 3
                            lblAvgOutput.Text = "Average per day: " & Math.Round(finalAverage, 2).ToString
                            btnEnter.Enabled = False
                            txtUnitEntered.ReadOnly = True
                        End If
                        employeeCounter += 1
                        dayCounter = 0
                    End If
                Else
                    MessageBox.Show(" ERROR!" & vbCrLf & "Please enter a number in range")
                    txtUnitEntered.Focus()
                End If
            Else
                MessageBox.Show(" ERROR!" & vbCrLf & "Please enter a  whole number")
                txtUnitEntered.Focus()
            End If
        Else
            MessageBox.Show(" ERROR!" & vbCrLf & "Please enter a numeric value")
            txtUnitEntered.Focus()
        End If
    End Sub

    ''' <summary>
    ''' Resetting the form by calling a sub procedure for this event handler. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetForm()

    End Sub
End Class

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
    Dim runningTotal As Integer = 0


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
        runningTotal = 0


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
    ''' the validation will aslo occur and message showing the error will also be shown. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim userInput As String = txtUnitEntered.Text
        Dim inputAsInt As Integer
        Dim averageEmp1 As Double
        Dim averageEmp2 As Double
        Dim averageEmp3 As Double
        Dim empDay1(0, 6) As Integer
        Dim empDay2(0, 6) As Integer
        Dim empDay3(0, 6) As Integer


        For counter As Integer = 0 To empDay1.GetUpperBound(0)

            If IsNumeric(userInput) Then
                inputAsInt = CInt(userInput)
                currentDay += 1
                lblDay.Text = "Day " + currentDay.ToString

                If inputAsInt.ToString = userInput Then
                    If inputAsInt >= MIN_VALUE And inputAsInt <= MAX_VALUE Then

                        runningTotal += inputAsInt
                        txtEmpList1.Text += userInput + vbCrLf

                    Else
                        MessageBox.Show("Please enter a number in range")
                        txtUnitEntered.Focus()

                    End If
                Else
                    MessageBox.Show("Please enter a  whole number")
                    txtUnitEntered.Focus()
                End If

            Else
                MessageBox.Show("Please enter a number")
                txtUnitEntered.Focus()

            End If

        Next
        averageEmp1 = runningTotal / 7
        lblEmpOutput1.Text = averageEmp1.ToString

        currentDay = 1

        For counter As Integer = 0 To empDay2.GetUpperBound(0)

            If IsNumeric(userInput) Then
                inputAsInt = CInt(userInput)
                currentDay += 1
                lblDay.Text = "Day " + currentDay.ToString

                If inputAsInt.ToString = userInput Then
                    If inputAsInt >= MIN_VALUE And inputAsInt <= MAX_VALUE Then

                        runningTotal += inputAsInt
                        txtEmpList2.Text += userInput + vbCrLf

                    Else
                        MessageBox.Show("Please enter a number in range")
                        txtUnitEntered.Focus()

                    End If
                Else
                    MessageBox.Show("Please enter a  whole number")
                    txtUnitEntered.Focus()
                End If

            Else
                MessageBox.Show("Please enter a number")
                txtUnitEntered.Focus()

            End If

        Next
        averageEmp2 = runningTotal / 7
        lblEmpOutput2.Text = averageEmp2.ToString

        currentDay = 1
        For counter As Integer = 0 To empDay3.GetUpperBound(0)

            If IsNumeric(userInput) Then
                inputAsInt = CInt(userInput)
                currentDay += 1
                lblDay.Text = "Day " + currentDay.ToString

                If inputAsInt.ToString = userInput Then
                    If inputAsInt >= MIN_VALUE And inputAsInt <= MAX_VALUE Then

                        runningTotal += inputAsInt
                        txtEmpList3.Text += userInput + vbCrLf

                    Else
                        MessageBox.Show("Please enter a number in range")
                        txtUnitEntered.Focus()

                    End If
                Else
                    MessageBox.Show("Please enter a  whole number")
                    txtUnitEntered.Focus()
                End If

            Else
                MessageBox.Show("Please enter a number")
                txtUnitEntered.Focus()

            End If

        Next
        averageEmp3 = runningTotal / 7
        lblEmpOutput3.Text = averageEmp3.ToString


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

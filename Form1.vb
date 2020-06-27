Public Class Form1

    Dim questionongui(16) As String

    Dim money As Integer = 500
    Dim inc As Integer
    Dim question As Integer = 2
    Dim correct As Char
    Dim answer As Char





    Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("This is our version of Who wants to be a millionaire. There are 2  instructions: " & vbNewLine _
            & "1) Read the Question" & vbNewLine & "2)Using your mouse, click on the answer you think is correct", vbOKOnly)

        questionongui(0) = "How many houses at BGS?"
        questionongui(1) = "Name of orange house at BGS?"
        questionongui(2) = "The founder of BGS?"
        questionongui(3) = "Next inset day for pupils at BGS?"
        questionongui(4) = "What type of school is BGS?"
        questionongui(5) = "The science concerned on the study of cells?"
        questionongui(6) = "What country has the best education in the world"
        questionongui(7) = "Does education increase your job opportunities"
        questionongui(8) = "Is education a privilege?"
        questionongui(9) = "Pass mark of the 11+ in 2016"
        questionongui(10) = "Best university in the UK?"
        questionongui(11) = "What does the 'V' in CV stand for"
        questionongui(12) = "Do you need education from universities to get a job?"
        questionongui(13) = "What is currently the highest-paid job (per month)?"
        questionongui(14) = "Why should an employer hire a job-seeker?"
        questionongui(15) = "The best MBA program in the world?"

        Label1.Text = questionongui(0)
        A.Text = 6
        B.Text = 4
        C.Text = 9
        D.Text = 3
        correct = "A"

    End Sub

    Sub A_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A.Click

        answer = "A"

        If answer = correct Then

            inc = money * 2
            money = inc
            Label2.Text = "£" & money
        Else
            MsgBox("You have got the answer wrong therefore you need to restart the game", vbRetryCancel)
            Application.Restart()
        End If


        If question = 2 Then
            correct = "A"
            Label1.Text = questionongui(1)
            A.Text = "Wellman"
            B.Text = "Kirkman"
            C.Text = "Orangeman"
            D.Text = "Blueman"
        End If

        If question = 3 Then
            Label1.Text = questionongui(2)
            A.Text = "Mr. Elphick"
            B.Text = "Sir Edward Heath"
            C.Text = "Mr. Johnson"
            D.Text = "Sir William Ellis"
            correct = "B"

        End If


        If question = 4 Then
            Label1.Text = questionongui(3)
            A.Text = "6th of January"
            B.Text = "11th of December"
            C.Text = "29th of November"
            D.Text = "30th of January"
            correct = "D"
        End If

        If question = 5 Then
            Label1.Text = questionongui(4)
            A.Text = "Selective"
            B.Text = "Comprehensive"
            C.Text = "State funded"
            D.Text = "Private"
            correct = "A"
        End If

        If question = 6 Then
            Label1.Text = questionongui(5)
            A.Text = "Mechanics"
            B.Text = "Physics"
            C.Text = "Biology"
            D.Text = "Chemistry"
            correct = "C"
        End If

        If question = 7 Then
            Label1.Text = questionongui(6)
            A.Text = "Finland"
            B.Text = "U.S.A"
            C.Text = "India"
            D.Text = "Poland"
            correct = "A"
        End If

        If question = 8 Then
            Label1.Text = questionongui(7)
            A.Text = "Usually"
            B.Text = "No"
            C.Text = "Rarely"
            D.Text = "Yes"
            correct = "A"
        End If

        If question = 9 Then
            Label1.Text = questionongui(8)
            A.Text = "In poor countries"
            B.Text = "Yes"
            C.Text = "No"
            D.Text = "Only in rich countries"
            correct = "B"
        End If

        If question = 10 Then
            Label1.Text = questionongui(9)
            A.Text = "214"
            B.Text = "215"
            C.Text = "217"
            D.Text = "150"
            correct = "B"
        End If

        If question = 11 Then
            Label1.Text = questionongui(10)
            A.Text = "UCL"
            B.Text = "Oxford"
            C.Text = "St Andrews"
            D.Text = "Exeter"
            correct = "B"
        End If

        If question = 12 Then
            Label1.Text = questionongui(11)
            A.Text = "Vitea"
            B.Text = "Sitae"
            C.Text = "Vhitae"
            D.Text = "Vitae"
            correct = "D"
        End If

        If question = 13 Then
            Label1.Text = questionongui(12)
            A.Text = "Yes"
            B.Text = "No"
            C.Text = "Maybe"
            D.Text = "Never"
            correct = "B"
        End If

        If question = 14 Then
            Label1.Text = questionongui(13)
            A.Text = "Volcanologists"
            B.Text = "Meteorologists"
            C.Text = "Anesthesiologists"
            D.Text = "Pharmacist"
            correct = "C"
        End If

        If question = 15 Then
            Label1.Text = questionongui(14)
            A.Text = "He/she is lazy"
            B.Text = "He/she is annoying "
            C.Text = "He/she is hard to work with"
            D.Text = "He/she is experienced"
            correct = "D"
        End If

        If question = 16 Then
            Label1.Text = questionongui(15)
            A.Text = "Stanford Business School"
            B.Text = "Wharton at UPENN"
            C.Text = "London Business school"
            D.Text = "Harvard Graduate School Of Business"
            correct = "A"
        End If
        If question = 17 Then
            MsgBox("You have defeated the hardest game possible", vbOK)
        End If
        question += 1


    End Sub

    Sub B_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B.Click

        answer = "B"

        If answer = correct Then

            inc = money * 2
            money = inc
            Label2.Text = "£" & money
        Else
            MsgBox("You have got the answer wrong therefore you need to restart the game", vbRetryCancel)
            Application.Restart()
        End If


        If question = 2 Then
            correct = "A"
            Label1.Text = questionongui(1)
            A.Text = "Wellman"
            B.Text = "Kirkman"
            C.Text = "Orangeman"
            D.Text = "Blueman"
        End If

        If question = 3 Then
            Label1.Text = questionongui(2)
            A.Text = "Mr. Elphick"
            B.Text = "Sir Edward Heath"
            C.Text = "Mr. Johnson"
            D.Text = "Sir William Ellis"
            correct = "B"

        End If


        If question = 4 Then
            Label1.Text = questionongui(3)
            A.Text = "6th of January"
            B.Text = "11th of December"
            C.Text = "29th of November"
            D.Text = "30th of January"
            correct = "D"
        End If

        If question = 5 Then
            Label1.Text = questionongui(4)
            A.Text = "Selective"
            B.Text = "Comprehensive"
            C.Text = "State funded"
            D.Text = "Private"
            correct = "A"
        End If

        If question = 6 Then
            Label1.Text = questionongui(5)
            A.Text = "Mechanics"
            B.Text = "Physics"
            C.Text = "Biology"
            D.Text = "Chemistry"
            correct = "C"
        End If

        If question = 7 Then
            Label1.Text = questionongui(6)
            A.Text = "Finland"
            B.Text = "U.S.A"
            C.Text = "India"
            D.Text = "Poland"
            correct = "A"
        End If

        If question = 8 Then
            Label1.Text = questionongui(7)
            A.Text = "Usually"
            B.Text = "No"
            C.Text = "Rarely"
            D.Text = "Yes"
            correct = "A"
        End If

        If question = 9 Then
            Label1.Text = questionongui(8)
            A.Text = "In poor countries"
            B.Text = "Yes"
            C.Text = "No"
            D.Text = "Only in rich countries"
            correct = "B"
        End If

        If question = 10 Then
            Label1.Text = questionongui(9)
            A.Text = "214"
            B.Text = "215"
            C.Text = "217"
            D.Text = "150"
            correct = "B"
        End If

        If question = 11 Then
            Label1.Text = questionongui(10)
            A.Text = "UCL"
            B.Text = "Oxford"
            C.Text = "St Andrews"
            D.Text = "Exeter"
            correct = "B"
        End If

        If question = 12 Then
            Label1.Text = questionongui(11)
            A.Text = "Vitea"
            B.Text = "Sitae"
            C.Text = "Vhitae"
            D.Text = "Vitae"
            correct = "D"
        End If

        If question = 13 Then
            Label1.Text = questionongui(12)
            A.Text = "Yes"
            B.Text = "No"
            C.Text = "Maybe"
            D.Text = "Never"
            correct = "B"
        End If

        If question = 14 Then
            Label1.Text = questionongui(13)
            A.Text = "Volcanologists"
            B.Text = "Meteorologists"
            C.Text = "Anesthesiologists"
            D.Text = "Pharmacist"
            correct = "C"
        End If


        If question = 15 Then
            Label1.Text = questionongui(14)
            A.Text = "He/she is lazy"
            B.Text = "He/she is annoying "
            C.Text = "He/she is hard to work with"
            D.Text = "He/she is experienced"
            correct = "D"
        End If

        If question = 16 Then
            Label1.Text = questionongui(15)
            A.Text = "Stanford Business School"
            B.Text = "Wharton at UPENN"
            C.Text = "London Business school"
            D.Text = "Harvard Graduate School Of Business"
            correct = "A"
        End If
        If question = 17 Then
            MsgBox("You have defeated the hardest game possible", vbOK)
        End If
        question += 1
    End Sub

    Sub C_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C.Click

        answer = "C"


        If answer = correct Then

            inc = money * 2
            money = inc
            Label2.Text = "£" & money
        Else
            MsgBox("You have got the answer wrong therefore you need to restart the game", vbRetryCancel)
            Application.Restart()
        End If


        If question = 2 Then
            correct = "A"
            Label1.Text = questionongui(1)
            A.Text = "Wellman"
            B.Text = "Kirkman"
            C.Text = "Orangeman"
            D.Text = "Blueman"
        End If

        If question = 3 Then
            Label1.Text = questionongui(2)
            A.Text = "Mr. Elphick"
            B.Text = "Sir Edward Heath"
            C.Text = "Mr. Johnson"
            D.Text = "Sir William Ellis"
            correct = "B"

        End If


        If question = 4 Then
            Label1.Text = questionongui(3)
            A.Text = "6th of January"
            B.Text = "11th of December"
            C.Text = "29th of November"
            D.Text = "30th of January"
            correct = "D"
        End If

        If question = 5 Then
            Label1.Text = questionongui(4)
            A.Text = "Selective"
            B.Text = "Comprehensive"
            C.Text = "State funded"
            D.Text = "Private"
            correct = "A"
        End If

        If question = 6 Then
            Label1.Text = questionongui(5)
            A.Text = "Mechanics"
            B.Text = "Physics"
            C.Text = "Biology"
            D.Text = "Chemistry"
            correct = "C"
        End If

        If question = 7 Then
            Label1.Text = questionongui(6)
            A.Text = "Finland"
            B.Text = "U.S.A"
            C.Text = "India"
            D.Text = "Poland"
            correct = "A"
        End If

        If question = 8 Then
            Label1.Text = questionongui(7)
            A.Text = "Usually"
            B.Text = "No"
            C.Text = "Rarely"
            D.Text = "Yes"
            correct = "A"
        End If

        If question = 9 Then
            Label1.Text = questionongui(8)
            A.Text = "In poor countries"
            B.Text = "Yes"
            C.Text = "No"
            D.Text = "Only in rich countries"
            correct = "B"
        End If

        If question = 10 Then
            Label1.Text = questionongui(9)
            A.Text = "214"
            B.Text = "215"
            C.Text = "217"
            D.Text = "150"
            correct = "B"
        End If

        If question = 11 Then
            Label1.Text = questionongui(10)
            A.Text = "UCL"
            B.Text = "Oxford"
            C.Text = "St Andrews"
            D.Text = "Exeter"
            correct = "B"
        End If

        If question = 12 Then
            Label1.Text = questionongui(11)
            A.Text = "Vitea"
            B.Text = "Sitae"
            C.Text = "Vhitae"
            D.Text = "Vitae"
            correct = "D"
        End If

        If question = 13 Then
            Label1.Text = questionongui(12)
            A.Text = "Yes"
            B.Text = "No"
            C.Text = "Maybe"
            D.Text = "Never"
            correct = "B"
        End If

        If question = 14 Then
            Label1.Text = questionongui(13)
            A.Text = "Volcanologists"
            B.Text = "Meteorologists"
            C.Text = "Anesthesiologists"
            D.Text = "Pharmacist"
            correct = "C"
        End If

        If question = 15 Then
            Label1.Text = questionongui(14)
            A.Text = "He/she is lazy"
            B.Text = "He/she is annoying "
            C.Text = "He/she is hard to work with"
            D.Text = "He/she is experienced"
            correct = "D"
        End If

        If question = 16 Then
            Label1.Text = questionongui(15)
            A.Text = "Stanford Business School"
            B.Text = "Wharton at UPENN"
            C.Text = "London Business school"
            D.Text = "Harvard Graduate School Of Business"
            correct = "A"
        End If
        If question = 17 Then
            MsgBox("You have defeated the hardest game possible", vbOK)
        End If
        question = question + 1
    End Sub

    Sub D_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D.Click

        answer = "D"


        If answer = correct Then

            inc = money * 2
            money = inc
            Label2.Text = "£" & money
        Else
            MsgBox("You have got the answer wrong therefore you need to restart the game", vbRetryCancel)
            Application.Restart()
        End If


        If question = 2 Then
            correct = "A"
            Label1.Text = questionongui(1)
            A.Text = "Wellman"
            B.Text = "Kirkman"
            C.Text = "Orangeman"
            D.Text = "Blueman"
        End If

        If question = 3 Then
            Label1.Text = questionongui(2)
            A.Text = "Mr. Elphick"
            B.Text = "Sir Edward Heath"
            C.Text = "Mr. Johnson"
            D.Text = "Sir William Ellis"
            correct = "B"

        End If


        If question = 4 Then
            Label1.Text = questionongui(3)
            A.Text = "6th of January"
            B.Text = "11th of December"
            C.Text = "29th of November"
            D.Text = "30th of January"
            correct = "D"
        End If

        If question = 5 Then
            Label1.Text = questionongui(4)
            A.Text = "Selective"
            B.Text = "Comprehensive"
            C.Text = "State funded"
            D.Text = "Private"
            correct = "A"
        End If

        If question = 6 Then
            Label1.Text = questionongui(5)
            A.Text = "Mechanics"
            B.Text = "Physics"
            C.Text = "Biology"
            D.Text = "Chemistry"
            correct = "C"
        End If

        If question = 7 Then
            Label1.Text = questionongui(6)
            A.Text = "Finland"
            B.Text = "U.S.A"
            C.Text = "India"
            D.Text = "Poland"
            correct = "A"
        End If

        If question = 8 Then
            Label1.Text = questionongui(7)
            A.Text = "Usually"
            B.Text = "No"
            C.Text = "Rarely"
            D.Text = "Yes"
            correct = "A"
        End If

        If question = 9 Then
            Label1.Text = questionongui(8)
            A.Text = "In poor countries"
            B.Text = "Yes"
            C.Text = "No"
            D.Text = "Only in rich countries"
            correct = "B"
        End If

        If question = 10 Then
            Label1.Text = questionongui(9)
            A.Text = "214"
            B.Text = "215"
            C.Text = "217"
            D.Text = "150"
            correct = "B"
        End If

        If question = 11 Then
            Label1.Text = questionongui(10)
            A.Text = "UCL"
            B.Text = "Oxford"
            C.Text = "St Andrews"
            D.Text = "Exeter"
            correct = "B"
        End If

        If question = 12 Then
            Label1.Text = questionongui(11)
            A.Text = "Vitea"
            B.Text = "Sitae"
            C.Text = "Vhitae"
            D.Text = "Vitae"
            correct = "D"
        End If

        If question = 13 Then
            Label1.Text = questionongui(12)
            A.Text = "Yes"
            B.Text = "No"
            C.Text = "Maybe"
            D.Text = "Never"
            correct = "B"
        End If

        If question = 14 Then
            Label1.Text = questionongui(13)
            A.Text = "Volcanologists"
            B.Text = "Meteorologists"
            C.Text = "Anesthesiologists"
            D.Text = "Pharmacist"
            correct = "C"
        End If
        If question = 15 Then
            Label1.Text = questionongui(14)
            A.Text = "He/she is lazy"
            B.Text = "He/she is annoying "
            C.Text = "He/she is hard to work with"
            D.Text = "He/she is experienced"
            correct = "D"
        End If

        If question = 16 Then
            Label1.Text = questionongui(15)
            A.Text = "Stanford Business School"
            B.Text = "Wharton at UPENN"
            C.Text = "London Business school"
            D.Text = "Harvard Graduate School Of Business"
            correct = "A"
        End If
        If question = 17 Then
            MsgBox("You have defeated the hardest game possible", vbOK)
        End If
        question += 1
    End Sub
End Class




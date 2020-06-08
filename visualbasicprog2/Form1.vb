Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OneCharacter As Char
        Dim FirstName As String
        Dim i As Integer
        Dim TextLength As Integer
        FirstName = Trim(txtChars.Text)
        TextLength = FirstName.Length
        MessageBox.Show("Number of characters is: " & TextLength)
    End Sub

    Private Sub SubstringBTN_Click(sender As Object, e As EventArgs) Handles SubstringBTN.Click
        Dim Email As String
        Dim DotCom As String

        Email = "me@me.com"
        DotCom = Email.Substring(5, 4)

        MessageBox.Show(DotCom)


    End Sub

    Private Sub InStrBTN_Click(sender As Object, e As EventArgs) Handles InStrBTN.Click
        Dim FirstString As String
        Dim SecondString As String
        Dim position As Integer
        FirstString = "me@me.com"
        SecondString = "mo"

        position = InStr(FirstString, SecondString)
        If position = 0 Then

            MessageBox.Show("Not a Valid email address: There was No @ Sign")

        End If
        MsgBox(position)

    End Sub

    Private Sub CharsBTN_Click(sender As Object, e As EventArgs) Handles CharsBTN.Click
        Dim SomeString As String
        Dim OneCharacter As Char

        SomeString = "George123"
        OneCharacter = SomeString.Chars(2)
        MsgBox(OneCharacter)
    End Sub

    Private Sub EqualsBTN_Click(sender As Object, e As EventArgs) Handles EqualsBTN.Click
        Dim Email As String
        Dim DotCom As String

        Email = "me@me.com"
        DotCom = Email.Substring(5, 4)

        MessageBox.Show(DotCom)
        If DotCom.Equals(".com") Then

            MessageBox.Show("Ends in Dot Com")

        Else

            MessageBox.Show("Doesn't End in Dot Com")

        End If
    End Sub

    Private Sub ReplaceBTN_Click(sender As Object, e As EventArgs) Handles ReplaceBTN.Click
        Dim OldText As String
        Dim NewText As String

        OldText = "This is some test"
        NewText = OldText.Replace("test", "text")

        MessageBox.Show(OldText)
        MessageBox.Show(NewText)
    End Sub

    Private Sub InsertBTN_Click(sender As Object, e As EventArgs) Handles InsertBTN.Click
        Dim SomeText As String
        Dim NewText As String

        SomeText = "This some text"
        NewText = SomeText.Insert(5, "is ")

        MessageBox.Show(SomeText)
        MessageBox.Show(NewText)
    End Sub

    Private Sub SplitBTN_Click(sender As Object, e As EventArgs) Handles SplitBTN.Click
        Dim LineOfText As String
        Dim i As Integer
        Dim aryTextFile() As String

        LineOfText = "UserName1, Password1, UserName2, Password2"

        aryTextFile = LineOfText.Split(",")

        For i = 0 To UBound(aryTextFile)

            MessageBox.Show(aryTextFile(i))

        Next i
    End Sub

    Private Sub JoinBTN_Click(sender As Object, e As EventArgs) Handles JoinBTN.Click
        Dim LineOfText As String
        Dim i As Integer
        Dim aryTextFile(3) As String

        aryTextFile(0) = "UserName1"
        aryTextFile(1) = "Password1"
        aryTextFile(2) = "UserName2"
        aryTextFile(3) = "Password2"

        LineOfText = String.Join("-", aryTextFile)

        MessageBox.Show(LineOfText)
    End Sub
End Class

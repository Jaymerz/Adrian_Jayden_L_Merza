Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim F_name, L_name As String
        F_name = "Nash"
        L_name = " Max"

        MsgBox(F_name + L_name)

        Dim sarray() As String = {"Hello", "From", "OOP", "Subject"}
        Dim message As String = String.Join(" ", sarray)
        MsgBox("Message :" + sarray(2).ToString)

        Dim str1, str2 As String

        str1 = "this is test"
        str2 = "this is asdadtest"

        If (String.Compare(str1, str2) = 1) Then
            MsgBox(str1 + " and " + str2 + " are not equal.")
        Else
            MsgBox(str1 + " and " + str2 + " are equal.")
        End If
    End Sub
End Class

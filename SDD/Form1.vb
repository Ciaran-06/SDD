Public Class Form1

    Dim Info(5) As Integer
    Dim maximum, minimum, highest, lowest As Integer
    Dim num(0 To 5), i, j, z As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdFillArray.Click


        Dim a As Integer
        Dim b As Integer


        While a < 5

            Info(a) = InputBox("Fill the array")
            LstOutput1.Items.Add(Info(a))
            a += 1

        End While

        'highest = Info(1)
        ' lowest = Info(1)

        ' For j = 1 To 5
        'If Info(j) < lowest Then
        'lowest = Info(j)
        ' End If
        '  Next j

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles cmdFindMax.Click




    End Sub

    Private Sub LstOutput1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstOutput1.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        highest = Info(1)
        lowest = Info(1)

        For j = 1 To 5
            If Info(j) < lowest Then
                lowest = Info(j)
            End If
        Next j

        MsgBox(lowest)

    End Sub
End Class

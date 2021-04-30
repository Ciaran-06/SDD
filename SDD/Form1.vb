Public Class Form1

    Dim Info(5) As Integer

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

        LstReport.Items.Add("Array Filled")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles cmdFindMax.Click
        Dim Max As Integer

        Max = Info.Max()

        LstOutput2.Items.Add("Highest is: " & Max)
        LstReport.Items.Add("Found Max:")
    End Sub

    Private Sub LstOutput1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstOutput1.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles cmdFindMin.Click
        Dim min As Integer
        Dim i As Integer

        min = Info(0)
        For item = 1 To 4
            If Info(item) < min Then
                min = Info(item)
            End If
        Next

        LstOutput2.Items.Add("Lowest is: " & min)
        LstReport.Items.Add("Found Min:")
    End Sub

    Private Sub LstReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstReport.SelectedIndexChanged

    End Sub

    Private Sub cmdFindOccs_Click(sender As Object, e As EventArgs) Handles cmdFindOccs.Click
        Dim counter = 0
        Dim search As Integer

        search = InputBox(“enter number to find”)
        For item = 1 To 4
            If search = Info(item) Then
                counter = counter + 1
            End If
        Next

        LstReport.Items.Add("Found Occurrences:")
        LstOutput2.Items.Add("Found " & search & " " & counter & " Times")

        If counter = 0 Then
            LstOutput2.Items.Add("No Occurrences For " & search)
        End If
    End Sub

    Private Sub cmdLinearSearch_Click(sender As Object, e As EventArgs) Handles cmdLinearSearch.Click
        Dim target As Integer
        Dim counter As Integer
        Dim found As Boolean
        Dim position As Integer

        target = InputBox(“enter the item to find”)
        For counter = 0 To 4
            If Info(counter) = target Then
                found = True
                position = counter
            End If
        Next

        LstReport.Items.Add("Linear Search Completed:")
        LstOutput2.Items.Add(target & " Found at " & position)
    End Sub

    Private Sub cmdWriteFile_Click(sender As Object, e As EventArgs) Handles cmdWriteFile.Click
        Dim filestring As String
        filestring = "D:\School\Data\pupilFile"
        'set location

        Dim pupilFile As New System.IO.StreamWriter(filestring)
        'creats a new file object called filestring
        'overwrite any file in same direcrtoy that shares the name!

        For counter = 0 To 4

            pupilFile.Write(Info(counter) & vbLf)
            'writes info in array info to file

        Next

        pupilFile.Close()

        LstReport.Items.Add("Data added to file:")
    End Sub

    Private Sub cmdReadFile_Click(sender As Object, e As EventArgs) Handles cmdReadFile.Click
        Dim counter As Integer
        Dim textLine As String

        Dim fileString As String
        fileString = "D:\School\Data\pupilFile"

        Dim infoFile As New System.IO.StreamReader(fileString)

        For counter = 0 To 4

            Info(counter) = infoFile.ReadLine
            LstOutput2.Items.Add(Info(counter))

        Next

        infoFile.Close()

        LstReport.Items.Add("Retrived Data:")
    End Sub
End Class

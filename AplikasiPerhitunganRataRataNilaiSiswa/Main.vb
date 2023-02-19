Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Main
    Dim ofd As New OpenFileDialog()
    Dim br As String = "====================="

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ofd.Filter = "Text or CSV Files|*.txt;*.csv|All Files|*.*"
        ofd.FilterIndex = 1
        ofd.Multiselect = False

        Dim result As DialogResult = ofd.ShowDialog()

        If result = DialogResult.OK Then
            Dim selectedFile As String = ofd.FileName
            tbFile.Text = selectedFile
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        If tbFile.Text.Equals("") Then
            MessageBox.Show("Silakan pilih file terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim fi As New IO.FileInfo(tbFile.Text)
            Dim path As String = fi.Extension
            If path.ToLower() = ".txt" Then
                calcAvgNilai("txt")
            ElseIf path.ToLower() = ".csv" Then
                calcAvgNilai("csv")
            Else
                appendTextToRtbOutput("Silahkan masukkan file dengan ekstensi .txt atau .csv saja!!")
            End If
            rtbOutput.ScrollToCaret()
        End If
    End Sub

    Private Sub appendTextToRtbOutput(s As String)
        If Not rtbOutput.Text.Equals("") Then
            rtbOutput.AppendText(Environment.NewLine & Environment.NewLine)
        End If
        rtbOutput.AppendText(br & Environment.NewLine & s & Environment.NewLine & br)
    End Sub

    Private Sub calcAvgNilai(type As String)
        Try
            Dim lines() As String = System.IO.File.ReadAllLines(tbFile.Text)

            Dim count As Integer = 0
            Dim sum As Double = 0

            For Each line As String In lines
                Dim data() As String = line.Split(",")
                Dim nis As String = data(0)
                Dim nama As String = data(1)
                Dim nilai As Integer = Integer.Parse(data(2))

                count += 1
                sum += nilai
            Next

            Dim average As Double = sum / count
            appendTextToRtbOutput("Rata-rata nilai siswa" & Environment.NewLine & "     Jumlah siswa: " & count & Environment.NewLine & "     Total keseluruhan nilai: " & sum & Environment.NewLine & "     Rata-rata nilai: " & Math.Round(average, 2))
        Catch ex As Exception
            If type = ".txt" Then
                appendTextToRtbOutput("Pastikan disetiap baris mengikuti contoh berikut: NIS, NAMA, NILAI" & Environment.NewLine & "Silahkan periksa kembali file yang Anda masukkan :D")
            Else
                appendTextToRtbOutput("Pastikan CSV tidak memiliki HEADER dan disetiap baris mengikuti susanan berikut: NIS | NAMA | NILAI" & Environment.NewLine & "Silahkan periksa kembali file yang Anda masukkan :D")
            End If
        End Try
    End Sub
End Class
Imports System.IO

Public Class Setting
    Public runKB As String = ""

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        ' 顯示開啟檔案的對話框
        OpenScript.Filter = "Text files (*.txt)|*.txt"
        If OpenScript.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        ' 讀取檔案內容
        Dim lines As String() = File.ReadAllLines(OpenScript.FileName)
        If lines.Length = 1 Then
            runKB = lines(0)
        Else
            runKB = lines(0)
        End If

        ' 顯示讀取結果
        TextBox1.Text = runKB
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.Enabled = CheckBox1.Checked
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        AboutBox1.Show()
    End Sub

    Private Sub btnSaveScript_Click(sender As Object, e As EventArgs) Handles btnSaveScript.Click
        ' 設定對話方塊的檔案類型及副檔名
        saveDialog.Filter = "文字儲存格式檔(*.txt)|*.txt"
        saveDialog.DefaultExt = "txt"

        ' 如果使用者選擇了檔案，則將 TextBox 的內容儲存到該檔案中
        If saveDialog.ShowDialog() = DialogResult.OK Then
            ' 取得使用者選擇的檔案路徑
            Dim filePath As String = saveDialog.FileName
            ' 將 TextBox 的內容寫入檔案中
            System.IO.File.WriteAllText(filePath, TextBox1.Text)
            MessageBox.Show("檔案已儲存！")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Button1.Enabled = True
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        TextBox3.Enabled = CheckBox2.Checked
    End Sub
End Class
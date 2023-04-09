Imports System.Threading.Thread
Imports Microsoft.VisualBasic.Devices.Keyboard
Public Class Main
    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        Setting.Show()
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        ' On Error GoTo Error_Proc
        If Setting.CheckBox1.Checked = True Then
            If Setting.TextBox2.Text = "" And Setting.CheckBox1.Checked = True Then
                Sleep(Val(Setting.TextBox2.Text))
            Else
                MsgBox("錯誤！" & vbNewLine & "錯誤代碼：" & "N/A" & ":" & "未輸入等待秒數，因此將不等待直接運行" & vbNewLine & "錯誤行數：" & "N/A", MsgBoxStyle.Critical + 4096)
            End If
        End If
        If Setting.CheckBox2.Checked Then
            For i = 0 To Val(Setting.TextBox3.Text)
                If Not (Setting.TextBox1.Text = "") Then
                    My.Computer.Keyboard.SendKeys(Setting.TextBox1.Text)
                Else
                    MsgBox("錯誤！" & vbNewLine & "錯誤代碼：" & "N/A" & ":" & "未輸入執行指令" & vbNewLine & "錯誤行數：" & "N/A", MsgBoxStyle.Critical + 4096)
                    Exit Sub
                End If
            Next
        Else
            If Not (Setting.TextBox1.Text = "") Then
                My.Computer.Keyboard.SendKeys(Setting.TextBox1.Text)
            Else
                MsgBox("錯誤！" & vbNewLine & "錯誤代碼：" & "N/A" & ":" & "未輸入執行指令" & vbNewLine & "錯誤行數：" & "N/A", MsgBoxStyle.Critical + 4096)
                Exit Sub
            End If
        End If
        Exit Sub
Error_Proc:
        MsgBox("錯誤！" & vbNewLine & "錯誤代碼：" & Err.Number & ":" & Err.Description & vbNewLine & "錯誤行數：" & Err.Erl, MsgBoxStyle.Critical + 4096)
    End Sub
End Class

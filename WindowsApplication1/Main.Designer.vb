<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnSetting
        '
        Me.btnSetting.BackColor = System.Drawing.Color.White
        Me.btnSetting.Image = Global.KeePushing.My.Resources.Resources.setting
        Me.btnSetting.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetting.Location = New System.Drawing.Point(210, 12)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(93, 91)
        Me.btnSetting.TabIndex = 2
        Me.btnSetting.Text = "設定(&S)"
        Me.btnSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSetting.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.White
        Me.btnEnd.Image = Global.KeePushing.My.Resources.Resources.stopImg
        Me.btnEnd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEnd.Location = New System.Drawing.Point(111, 12)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(93, 91)
        Me.btnEnd.TabIndex = 1
        Me.btnEnd.Text = "停止腳本(&E)"
        Me.btnEnd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'btnRun
        '
        Me.btnRun.BackColor = System.Drawing.Color.White
        Me.btnRun.Image = Global.KeePushing.My.Resources.Resources.run
        Me.btnRun.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRun.Location = New System.Drawing.Point(12, 12)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(93, 91)
        Me.btnRun.TabIndex = 0
        Me.btnRun.Text = "執行腳本(&R)"
        Me.btnRun.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnRun, "等待5秒後執行")
        Me.btnRun.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 115)
        Me.Controls.Add(Me.btnSetting)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnRun)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "KeePushing"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnSetting As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class

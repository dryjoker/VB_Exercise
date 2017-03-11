<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtHello = New System.Windows.Forms.TextBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtHello
        '
        Me.txtHello.Font = New System.Drawing.Font("PMingLiU", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtHello.Location = New System.Drawing.Point(32, 41)
        Me.txtHello.Multiline = True
        Me.txtHello.Name = "txtHello"
        Me.txtHello.Size = New System.Drawing.Size(298, 118)
        Me.txtHello.TabIndex = 0
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("PMingLiU", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnShow.Location = New System.Drawing.Point(32, 174)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(116, 36)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "顯示"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Font = New System.Drawing.Font("PMingLiU", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(207, 174)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(123, 36)
        Me.btnEnd.TabIndex = 2
        Me.btnEnd.Text = "結束"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 297)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtHello)
        Me.Name = "Form1"
        Me.Text = "招呼程式"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHello As TextBox
    Friend WithEvents btnShow As Button
    Friend WithEvents btnEnd As Button
End Class

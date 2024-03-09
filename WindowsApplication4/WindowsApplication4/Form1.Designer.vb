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
        Me.Age_textbox = New System.Windows.Forms.TextBox()
        Me.evaluate_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Age_textbox
        '
        Me.Age_textbox.Location = New System.Drawing.Point(46, 37)
        Me.Age_textbox.Name = "Age_textbox"
        Me.Age_textbox.Size = New System.Drawing.Size(191, 20)
        Me.Age_textbox.TabIndex = 0
        Me.Age_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'evaluate_btn
        '
        Me.evaluate_btn.Location = New System.Drawing.Point(108, 96)
        Me.evaluate_btn.Name = "evaluate_btn"
        Me.evaluate_btn.Size = New System.Drawing.Size(75, 23)
        Me.evaluate_btn.TabIndex = 1
        Me.evaluate_btn.Text = "Evaluate"
        Me.evaluate_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.evaluate_btn)
        Me.Controls.Add(Me.Age_textbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Age_textbox As TextBox
    Friend WithEvents evaluate_btn As Button


End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.math_txtbox = New System.Windows.Forms.TextBox()
        Me.science_txtbox = New System.Windows.Forms.TextBox()
        Me.english_txtbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.evaluate_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'math_txtbox
        '
        Me.math_txtbox.Location = New System.Drawing.Point(46, 51)
        Me.math_txtbox.Name = "math_txtbox"
        Me.math_txtbox.Size = New System.Drawing.Size(189, 20)
        Me.math_txtbox.TabIndex = 0
        '
        'science_txtbox
        '
        Me.science_txtbox.Location = New System.Drawing.Point(46, 122)
        Me.science_txtbox.Name = "science_txtbox"
        Me.science_txtbox.Size = New System.Drawing.Size(189, 20)
        Me.science_txtbox.TabIndex = 1
        '
        'english_txtbox
        '
        Me.english_txtbox.Location = New System.Drawing.Point(49, 188)
        Me.english_txtbox.Name = "english_txtbox"
        Me.english_txtbox.Size = New System.Drawing.Size(189, 20)
        Me.english_txtbox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Math"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Science"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "English"
        '
        'evaluate_btn
        '
        Me.evaluate_btn.Location = New System.Drawing.Point(86, 238)
        Me.evaluate_btn.Name = "evaluate_btn"
        Me.evaluate_btn.Size = New System.Drawing.Size(109, 23)
        Me.evaluate_btn.TabIndex = 6
        Me.evaluate_btn.Text = "Evaluate"
        Me.evaluate_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.evaluate_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.english_txtbox)
        Me.Controls.Add(Me.science_txtbox)
        Me.Controls.Add(Me.math_txtbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents math_txtbox As TextBox
    Friend WithEvents science_txtbox As TextBox
    Friend WithEvents english_txtbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents evaluate_btn As Button
End Class

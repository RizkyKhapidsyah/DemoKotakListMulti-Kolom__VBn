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
        Me.listNilai = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'listNilai
        '
        Me.listNilai.ColumnWidth = 30
        Me.listNilai.FormattingEnabled = True
        Me.listNilai.Location = New System.Drawing.Point(13, 13)
        Me.listNilai.MultiColumn = True
        Me.listNilai.Name = "listNilai"
        Me.listNilai.Size = New System.Drawing.Size(347, 238)
        Me.listNilai.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 269)
        Me.Controls.Add(Me.listNilai)
        Me.Name = "Form1"
        Me.Text = "Demo Kotak List Multi-Kolom"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listNilai As System.Windows.Forms.ListBox

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.txtFrst = New System.Windows.Forms.TextBox()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRed
        '
        Me.btnRed.Location = New System.Drawing.Point(147, 153)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(278, 23)
        Me.btnRed.TabIndex = 0
        Me.btnRed.Text = "Change Color To Red"
        Me.btnRed.UseVisualStyleBackColor = True
        '
        'txtFrst
        '
        Me.txtFrst.Location = New System.Drawing.Point(147, 49)
        Me.txtFrst.Name = "txtFrst"
        Me.txtFrst.Size = New System.Drawing.Size(278, 23)
        Me.txtFrst.TabIndex = 1
        '
        'txtSecond
        '
        Me.txtSecond.Location = New System.Drawing.Point(147, 103)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(278, 23)
        Me.txtSecond.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 255)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.txtFrst)
        Me.Controls.Add(Me.btnRed)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRed As Button
    Friend WithEvents txtFrst As TextBox
    Friend WithEvents txtSecond As TextBox
End Class

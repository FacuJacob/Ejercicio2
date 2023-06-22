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
        lblSuma = New Label()
        lblMayor = New Label()
        cmdEjecutar = New Button()
        lstMostrarMatriz = New ListBox()
        SuspendLayout()
        ' 
        ' lblSuma
        ' 
        lblSuma.AutoSize = True
        lblSuma.Location = New Point(12, 337)
        lblSuma.Name = "lblSuma"
        lblSuma.Size = New Size(41, 15)
        lblSuma.TabIndex = 1
        lblSuma.Text = "Label1"
        ' 
        ' lblMayor
        ' 
        lblMayor.AutoSize = True
        lblMayor.Location = New Point(12, 352)
        lblMayor.Name = "lblMayor"
        lblMayor.Size = New Size(41, 15)
        lblMayor.TabIndex = 2
        lblMayor.Text = "Label1"
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.Location = New Point(12, 12)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(320, 58)
        cmdEjecutar.TabIndex = 3
        cmdEjecutar.Text = "Comenzar"
        cmdEjecutar.UseVisualStyleBackColor = True
        ' 
        ' lstMostrarMatriz
        ' 
        lstMostrarMatriz.FormattingEnabled = True
        lstMostrarMatriz.ItemHeight = 15
        lstMostrarMatriz.Location = New Point(12, 76)
        lstMostrarMatriz.Name = "lstMostrarMatriz"
        lstMostrarMatriz.Size = New Size(320, 259)
        lstMostrarMatriz.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstMostrarMatriz)
        Controls.Add(cmdEjecutar)
        Controls.Add(lblMayor)
        Controls.Add(lblSuma)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblSuma As Label
    Friend WithEvents lblMayor As Label
    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents lstMostrarMatriz As ListBox
End Class

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
        grdMostrarMatriz = New DataGridView()
        CType(grdMostrarMatriz, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblSuma
        ' 
        lblSuma.AutoSize = True
        lblSuma.Location = New Point(12, 337)
        lblSuma.Name = "lblSuma"
        lblSuma.Size = New Size(0, 15)
        lblSuma.TabIndex = 1
        ' 
        ' lblMayor
        ' 
        lblMayor.AutoSize = True
        lblMayor.Location = New Point(12, 352)
        lblMayor.Name = "lblMayor"
        lblMayor.Size = New Size(0, 15)
        lblMayor.TabIndex = 2
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.Location = New Point(12, 12)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(396, 58)
        cmdEjecutar.TabIndex = 3
        cmdEjecutar.Text = "Comenzar"
        cmdEjecutar.UseVisualStyleBackColor = True
        ' 
        ' grdMostrarMatriz
        ' 
        grdMostrarMatriz.AllowUserToAddRows = False
        grdMostrarMatriz.AllowUserToDeleteRows = False
        grdMostrarMatriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdMostrarMatriz.ColumnHeadersVisible = False
        grdMostrarMatriz.Location = New Point(12, 74)
        grdMostrarMatriz.Name = "grdMostrarMatriz"
        grdMostrarMatriz.ReadOnly = True
        grdMostrarMatriz.RowHeadersVisible = False
        grdMostrarMatriz.RowTemplate.Height = 25
        grdMostrarMatriz.Size = New Size(396, 260)
        grdMostrarMatriz.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(423, 425)
        Controls.Add(grdMostrarMatriz)
        Controls.Add(cmdEjecutar)
        Controls.Add(lblMayor)
        Controls.Add(lblSuma)
        Name = "Form1"
        Text = "Form1"
        CType(grdMostrarMatriz, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblSuma As Label
    Friend WithEvents lblMayor As Label
    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents grdMostrarMatriz As DataGridView
End Class

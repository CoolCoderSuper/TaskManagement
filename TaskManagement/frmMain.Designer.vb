<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        dgvProjects = New DataGridView()
        ms = New MenuStrip()
        btnNew = New ToolStripMenuItem()
        btnEdit = New ToolStripMenuItem()
        btnDelete = New ToolStripMenuItem()
        CType(dgvProjects, ComponentModel.ISupportInitialize).BeginInit()
        ms.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvProjects
        ' 
        dgvProjects.AllowUserToAddRows = False
        dgvProjects.AllowUserToDeleteRows = False
        dgvProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProjects.Dock = DockStyle.Fill
        dgvProjects.Location = New Point(0, 24)
        dgvProjects.Name = "dgvProjects"
        dgvProjects.ReadOnly = True
        dgvProjects.RowTemplate.Height = 25
        dgvProjects.Size = New Size(845, 578)
        dgvProjects.TabIndex = 0
        ' 
        ' ms
        ' 
        ms.Items.AddRange(New ToolStripItem() {btnNew, btnEdit, btnDelete})
        ms.Location = New Point(0, 0)
        ms.Name = "ms"
        ms.Size = New Size(845, 24)
        ms.TabIndex = 1
        ms.Text = "MenuStrip1"
        ' 
        ' btnNew
        ' 
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(43, 20)
        btnNew.Text = "New"
        ' 
        ' btnEdit
        ' 
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(39, 20)
        btnEdit.Text = "Edit"
        ' 
        ' btnDelete
        ' 
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(52, 20)
        btnDelete.Text = "Delete"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(845, 602)
        Controls.Add(dgvProjects)
        Controls.Add(ms)
        MainMenuStrip = ms
        Name = "frmMain"
        Text = "Task Manager"
        CType(dgvProjects, ComponentModel.ISupportInitialize).EndInit()
        ms.ResumeLayout(False)
        ms.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvProjects As DataGridView
    Friend WithEvents ms As MenuStrip
    Friend WithEvents btnNew As ToolStripMenuItem
    Friend WithEvents btnEdit As ToolStripMenuItem
    Friend WithEvents btnDelete As ToolStripMenuItem
End Class

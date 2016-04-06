<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonLoginUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PersonLoginUserControl))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.CakePicture = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.CakePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.NameLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CakePicture)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EditButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LoginButton)
        Me.SplitContainer1.Size = New System.Drawing.Size(393, 32)
        Me.SplitContainer1.SplitterDistance = 204
        Me.SplitContainer1.TabIndex = 0
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(30, 10)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(66, 13)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Person Name"
        '
        'EditButton
        '
        Me.EditButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.EditButton.Location = New System.Drawing.Point(101, 0)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(84, 32)
        Me.EditButton.TabIndex = 4
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.Gray
        Me.LoginButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LoginButton.Location = New System.Drawing.Point(0, 0)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(99, 32)
        Me.LoginButton.TabIndex = 3
        Me.LoginButton.Text = "Sign In"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'CakePicture
        '
        Me.CakePicture.Image = CType(resources.GetObject("CakePicture.Image"), System.Drawing.Image)
        Me.CakePicture.Location = New System.Drawing.Point(3, 3)
        Me.CakePicture.Name = "CakePicture"
        Me.CakePicture.Size = New System.Drawing.Size(30, 26)
        Me.CakePicture.TabIndex = 4
        Me.CakePicture.TabStop = False
        '
        'PersonLoginUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PersonLoginUserControl"
        Me.Size = New System.Drawing.Size(393, 32)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.CakePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents CakePicture As System.Windows.Forms.PictureBox

End Class

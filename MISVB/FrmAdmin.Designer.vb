<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.btndashboard = New System.Windows.Forms.Button()
        Me.btnjobposting = New System.Windows.Forms.Button()
        Me.btnapplication = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pagepanel = New System.Windows.Forms.Panel()
        Me.panelform = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btndashboard
        '
        Me.btndashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btndashboard.Image = CType(resources.GetObject("btndashboard.Image"), System.Drawing.Image)
        Me.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndashboard.Location = New System.Drawing.Point(0, 64)
        Me.btndashboard.Name = "btndashboard"
        Me.btndashboard.Size = New System.Drawing.Size(276, 51)
        Me.btndashboard.TabIndex = 2
        Me.btndashboard.Text = "Dashboard"
        Me.btndashboard.UseVisualStyleBackColor = False
        '
        'btnjobposting
        '
        Me.btnjobposting.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnjobposting.Image = CType(resources.GetObject("btnjobposting.Image"), System.Drawing.Image)
        Me.btnjobposting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnjobposting.Location = New System.Drawing.Point(0, 115)
        Me.btnjobposting.Name = "btnjobposting"
        Me.btnjobposting.Size = New System.Drawing.Size(276, 51)
        Me.btnjobposting.TabIndex = 3
        Me.btnjobposting.Text = "Job Postings"
        Me.btnjobposting.UseVisualStyleBackColor = False
        '
        'btnapplication
        '
        Me.btnapplication.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnapplication.Image = CType(resources.GetObject("btnapplication.Image"), System.Drawing.Image)
        Me.btnapplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnapplication.Location = New System.Drawing.Point(0, 166)
        Me.btnapplication.Name = "btnapplication"
        Me.btnapplication.Size = New System.Drawing.Size(276, 51)
        Me.btnapplication.TabIndex = 4
        Me.btnapplication.Text = "Application"
        Me.btnapplication.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 217)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(276, 51)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Scheduling"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(0, 268)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(276, 51)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Status"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btndashboard)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.btnjobposting)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.btnapplication)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(282, 542)
        Me.Panel1.TabIndex = 7
        '
        'pagepanel
        '
        Me.pagepanel.BackColor = System.Drawing.Color.White
        Me.pagepanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pagepanel.Location = New System.Drawing.Point(282, 121)
        Me.pagepanel.Name = "pagepanel"
        Me.pagepanel.Size = New System.Drawing.Size(795, 542)
        Me.pagepanel.TabIndex = 8
        '
        'panelform
        '
        Me.panelform.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.panelform.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelform.Location = New System.Drawing.Point(0, 0)
        Me.panelform.Name = "panelform"
        Me.panelform.Size = New System.Drawing.Size(1077, 121)
        Me.panelform.TabIndex = 9
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 663)
        Me.ControlBox = False
        Me.Controls.Add(Me.pagepanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelform)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btndashboard As Button
    Friend WithEvents btnjobposting As Button
    Friend WithEvents btnapplication As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pagepanel As Panel
    Friend WithEvents panelform As Panel
End Class

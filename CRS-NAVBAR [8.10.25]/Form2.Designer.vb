<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        TableLayoutPanel1 = New TableLayoutPanel()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        btnDashboard = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        pbDashboardLogo = New PictureBox()
        TableLayoutPanel1.SuspendLayout()
        CType(pbDashboardLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.None
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(Button5, 0, 4)
        TableLayoutPanel1.Controls.Add(Button4, 0, 3)
        TableLayoutPanel1.Controls.Add(Button3, 0, 2)
        TableLayoutPanel1.Controls.Add(Button2, 0, 1)
        TableLayoutPanel1.Controls.Add(btnDashboard, 0, 0)
        TableLayoutPanel1.Location = New Point(40, 95)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Size = New Size(174, 205)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.None
        Button5.Cursor = Cursors.Hand
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(18, 167)
        Button5.Name = "Button5"
        Button5.Size = New Size(137, 35)
        Button5.TabIndex = 4
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.None
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(18, 126)
        Button4.Name = "Button4"
        Button4.Size = New Size(137, 35)
        Button4.TabIndex = 3
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.None
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(18, 85)
        Button3.Name = "Button3"
        Button3.Size = New Size(137, 35)
        Button3.TabIndex = 2
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(18, 44)
        Button2.Name = "Button2"
        Button2.Size = New Size(137, 35)
        Button2.TabIndex = 1
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Anchor = AnchorStyles.None
        btnDashboard.Cursor = Cursors.Hand
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Verdana", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnDashboard.Location = New Point(3, 3)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(168, 35)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Location = New Point(220, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1720, 1080)
        Panel1.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.None
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Location = New Point(220, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1720, 1080)
        Panel2.TabIndex = 4
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.None
        Panel3.BackColor = SystemColors.ActiveCaptionText
        Panel3.Location = New Point(220, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1720, 1080)
        Panel3.TabIndex = 5
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.None
        Panel4.BackColor = SystemColors.AppWorkspace
        Panel4.Location = New Point(220, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1720, 1080)
        Panel4.TabIndex = 6
        ' 
        ' Panel5
        ' 
        Panel5.Anchor = AnchorStyles.None
        Panel5.BackColor = SystemColors.Highlight
        Panel5.Location = New Point(220, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1720, 1080)
        Panel5.TabIndex = 7
        ' 
        ' pbDashboardLogo
        ' 
        pbDashboardLogo.BackgroundImage = My.Resources.Resources.home
        pbDashboardLogo.BackgroundImageLayout = ImageLayout.Zoom
        pbDashboardLogo.Location = New Point(7, 98)
        pbDashboardLogo.Name = "pbDashboardLogo"
        pbDashboardLogo.Size = New Size(30, 30)
        pbDashboardLogo.TabIndex = 8
        pbDashboardLogo.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(1920, 1080)
        ControlBox = False
        Controls.Add(pbDashboardLogo)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        Text = " "
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        CType(pbDashboardLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents pbDashboardLogo As PictureBox
End Class

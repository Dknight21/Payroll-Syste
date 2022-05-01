<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Emp_dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Emp_dashboard))
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.NotePadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnCataloging = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnCirculation = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotePadToolStripMenuItem, Me.CalculatorToolStripMenuItem})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip2.Size = New System.Drawing.Size(2186, 43)
        Me.ToolStrip2.TabIndex = 53
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'NotePadToolStripMenuItem
        '
        Me.NotePadToolStripMenuItem.Image = CType(resources.GetObject("NotePadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NotePadToolStripMenuItem.Name = "NotePadToolStripMenuItem"
        Me.NotePadToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NotePadToolStripMenuItem.Size = New System.Drawing.Size(175, 43)
        Me.NotePadToolStripMenuItem.Text = "Note Pad"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Image = CType(resources.GetObject("CalculatorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(185, 43)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1522, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 40)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "0:00:00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 55.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1138, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(932, 187)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "0:00:00 AM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 420)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 36)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Logged As:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(225, 415)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 39)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Rai"
        '
        'Timer1
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(27, 47)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(355, 350)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 68
        Me.PictureBox2.TabStop = False
        '
        'btnCataloging
        '
        Me.btnCataloging.BackColor = System.Drawing.Color.White
        Me.btnCataloging.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCataloging.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCataloging.Image = CType(resources.GetObject("btnCataloging.Image"), System.Drawing.Image)
        Me.btnCataloging.Location = New System.Drawing.Point(9, 499)
        Me.btnCataloging.Margin = New System.Windows.Forms.Padding(7)
        Me.btnCataloging.Name = "btnCataloging"
        Me.btnCataloging.Size = New System.Drawing.Size(382, 185)
        Me.btnCataloging.TabIndex = 67
        Me.btnCataloging.Text = "Employee Info."
        Me.btnCataloging.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCataloging.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.White
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(16, 883)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(7)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(375, 191)
        Me.btnLogout.TabIndex = 66
        Me.btnLogout.Text = "Switch user"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnCirculation
        '
        Me.btnCirculation.BackColor = System.Drawing.Color.White
        Me.btnCirculation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCirculation.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCirculation.Image = CType(resources.GetObject("btnCirculation.Image"), System.Drawing.Image)
        Me.btnCirculation.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCirculation.Location = New System.Drawing.Point(16, 698)
        Me.btnCirculation.Margin = New System.Windows.Forms.Padding(7)
        Me.btnCirculation.Name = "btnCirculation"
        Me.btnCirculation.Size = New System.Drawing.Size(375, 171)
        Me.btnCirculation.TabIndex = 65
        Me.btnCirculation.Text = "Pay-Slip"
        Me.btnCirculation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCirculation.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Payroll_System.My.Resources.Resources.img1
        Me.PictureBox1.Location = New System.Drawing.Point(401, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1785, 1028)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'Emp_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(2186, 1090)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnCataloging)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnCirculation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Emp_dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emp_dashboard"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents NotePadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Public WithEvents btnCataloging As Button
    Public WithEvents btnLogout As Button
    Public WithEvents btnCirculation As Button
    Friend WithEvents Timer1 As Timer
End Class

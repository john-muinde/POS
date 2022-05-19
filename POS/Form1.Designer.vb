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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tbMain = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtCalculations = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblNotifications = New System.Windows.Forms.Label()
        Me.btnNotifications = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdAbout = New System.Windows.Forms.Button()
        Me.cmdUsers = New System.Windows.Forms.Button()
        Me.btnCalculator = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDate = New System.Windows.Forms.Label()
        Me.tbMain.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbMain
        '
        Me.tbMain.ColumnCount = 2
        Me.tbMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.4081!))
        Me.tbMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.5919!))
        Me.tbMain.Controls.Add(Me.TableLayoutPanel2, 1, 2)
        Me.tbMain.Controls.Add(Me.GroupBox1, 1, 0)
        Me.tbMain.Controls.Add(Me.Panel1, 0, 0)
        Me.tbMain.Controls.Add(Me.Panel3, 0, 1)
        Me.tbMain.Controls.Add(Me.Panel4, 0, 2)
        Me.tbMain.Controls.Add(Me.mainPanel, 1, 1)
        Me.tbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbMain.Location = New System.Drawing.Point(0, 0)
        Me.tbMain.Name = "tbMain"
        Me.tbMain.RowCount = 3
        Me.tbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.34838!))
        Me.tbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.59802!))
        Me.tbMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.91255!))
        Me.tbMain.Size = New System.Drawing.Size(1284, 709)
        Me.tbMain.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.37746!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.62258!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999964!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtCalculations, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(188, 584)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1093, 122)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'txtCalculations
        '
        Me.txtCalculations.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCalculations.Enabled = False
        Me.txtCalculations.Font = New System.Drawing.Font("Palatino Linotype", 42.0!, System.Drawing.FontStyle.Bold)
        Me.txtCalculations.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtCalculations.Location = New System.Drawing.Point(673, 3)
        Me.txtCalculations.Name = "txtCalculations"
        Me.txtCalculations.ReadOnly = True
        Me.txtCalculations.Size = New System.Drawing.Size(306, 121)
        Me.txtCalculations.TabIndex = 0
        Me.txtCalculations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(985, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 116)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.lblNotifications)
        Me.GroupBox1.Controls.Add(Me.btnNotifications)
        Me.GroupBox1.Controls.Add(Me.btnHome)
        Me.GroupBox1.Controls.Add(Me.btnSales)
        Me.GroupBox1.Controls.Add(Me.btnOrders)
        Me.GroupBox1.Controls.Add(Me.btnProducts)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(188, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1093, 117)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "POS| systems"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel5.BackgroundImage = Global.POS.My.Resources.Resources.power_off
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Location = New System.Drawing.Point(997, 52)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(49, 42)
        Me.Panel5.TabIndex = 9
        '
        'lblNotifications
        '
        Me.lblNotifications.AutoSize = True
        Me.lblNotifications.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblNotifications.Location = New System.Drawing.Point(917, 41)
        Me.lblNotifications.Name = "lblNotifications"
        Me.lblNotifications.Size = New System.Drawing.Size(0, 29)
        Me.lblNotifications.TabIndex = 8
        '
        'btnNotifications
        '
        Me.btnNotifications.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotifications.FlatAppearance.BorderSize = 0
        Me.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotifications.ForeColor = System.Drawing.Color.Gray
        Me.btnNotifications.Image = CType(resources.GetObject("btnNotifications.Image"), System.Drawing.Image)
        Me.btnNotifications.Location = New System.Drawing.Point(879, 46)
        Me.btnNotifications.Name = "btnNotifications"
        Me.btnNotifications.Size = New System.Drawing.Size(50, 48)
        Me.btnNotifications.TabIndex = 7
        Me.btnNotifications.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.ForeColor = System.Drawing.Color.Gray
        Me.btnHome.Location = New System.Drawing.Point(159, 46)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(122, 48)
        Me.btnHome.TabIndex = 6
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.ForeColor = System.Drawing.Color.Gray
        Me.btnSales.Location = New System.Drawing.Point(322, 46)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(122, 48)
        Me.btnSales.TabIndex = 5
        Me.btnSales.Text = "Sales"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrders.FlatAppearance.BorderSize = 0
        Me.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrders.ForeColor = System.Drawing.Color.Gray
        Me.btnOrders.Location = New System.Drawing.Point(492, 46)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(147, 48)
        Me.btnOrders.TabIndex = 4
        Me.btnOrders.Text = "Products"
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducts.FlatAppearance.BorderSize = 0
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.ForeColor = System.Drawing.Color.Gray
        Me.btnProducts.Location = New System.Drawing.Point(663, 46)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(154, 48)
        Me.btnProducts.TabIndex = 1
        Me.btnProducts.Text = "Stock"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 117)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(102, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 38)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "POS"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(9, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(91, 88)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblDate)
        Me.Panel3.Controls.Add(Me.cmdHelp)
        Me.Panel3.Controls.Add(Me.cmdAbout)
        Me.Panel3.Controls.Add(Me.cmdUsers)
        Me.Panel3.Controls.Add(Me.btnCalculator)
        Me.Panel3.Controls.Add(Me.lblTime)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 126)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(179, 452)
        Me.Panel3.TabIndex = 8
        '
        'cmdHelp
        '
        Me.cmdHelp.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.cmdHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdHelp.FlatAppearance.BorderSize = 0
        Me.cmdHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHelp.Font = New System.Drawing.Font("Palatino Linotype", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmdHelp.ForeColor = System.Drawing.Color.White
        Me.cmdHelp.Location = New System.Drawing.Point(-3, 370)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(173, 48)
        Me.cmdHelp.TabIndex = 13
        Me.cmdHelp.Text = "&Help"
        Me.cmdHelp.UseVisualStyleBackColor = False
        '
        'cmdAbout
        '
        Me.cmdAbout.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.cmdAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAbout.FlatAppearance.BorderSize = 0
        Me.cmdAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAbout.Font = New System.Drawing.Font("Palatino Linotype", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmdAbout.ForeColor = System.Drawing.Color.White
        Me.cmdAbout.Location = New System.Drawing.Point(0, 290)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(173, 48)
        Me.cmdAbout.TabIndex = 12
        Me.cmdAbout.Text = "&About"
        Me.cmdAbout.UseVisualStyleBackColor = False
        '
        'cmdUsers
        '
        Me.cmdUsers.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.cmdUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdUsers.FlatAppearance.BorderSize = 0
        Me.cmdUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUsers.Font = New System.Drawing.Font("Palatino Linotype", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmdUsers.ForeColor = System.Drawing.Color.White
        Me.cmdUsers.Location = New System.Drawing.Point(3, 206)
        Me.cmdUsers.Name = "cmdUsers"
        Me.cmdUsers.Size = New System.Drawing.Size(173, 48)
        Me.cmdUsers.TabIndex = 11
        Me.cmdUsers.Text = "&Users"
        Me.cmdUsers.UseVisualStyleBackColor = False
        '
        'btnCalculator
        '
        Me.btnCalculator.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCalculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnCalculator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalculator.FlatAppearance.BorderSize = 0
        Me.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculator.Font = New System.Drawing.Font("Palatino Linotype", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnCalculator.ForeColor = System.Drawing.Color.White
        Me.btnCalculator.Location = New System.Drawing.Point(0, 119)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(173, 48)
        Me.btnCalculator.TabIndex = 10
        Me.btnCalculator.Text = "&Calculator"
        Me.btnCalculator.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTime.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTime.Location = New System.Drawing.Point(9, 12)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(108, 41)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "Label2"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnExit)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 584)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(179, 122)
        Me.Panel4.TabIndex = 10
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Palatino Linotype", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(18, 35)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(138, 48)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'mainPanel
        '
        Me.mainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(188, 126)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(1093, 452)
        Me.mainPanel.TabIndex = 14
        '
        'Timer2
        '
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDate.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.Location = New System.Drawing.Point(11, 75)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(46, 24)
        Me.lblDate.TabIndex = 14
        Me.lblDate.Text = "date"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1284, 709)
        Me.Controls.Add(Me.tbMain)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbMain.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbMain As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNotifications As Label
    Friend WithEvents btnNotifications As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents btnProducts As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Public WithEvents txtCalculations As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents mainPanel As Panel
    Public WithEvents lblTime As Label
    Friend WithEvents btnCalculator As Button
    Friend WithEvents cmdHelp As Button
    Friend WithEvents cmdAbout As Button
    Friend WithEvents cmdUsers As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel5 As Panel
    Public WithEvents lblDate As Label
End Class

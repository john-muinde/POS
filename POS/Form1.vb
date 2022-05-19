Imports System.Data.OleDb
Public Class Form1
    Private Sub homeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
        'switchPanes(Home)
        btnHome.PerformClick()
        datagridShow()
        Home.notif(Notify.lvNotify)
    End Sub

    Sub switchPanes(ByVal panel As Form)
        mainPanel.Controls.Clear()
        panel.TopLevel = False
        mainPanel.Controls.Add(panel)
        panel.Show()
        panel.Dock = DockStyle.Fill
    End Sub

    Public Sub graphcs(locx As Integer)
        ClearCanvas()
        Dim myGraphics As Graphics = GroupBox1.CreateGraphics
        Dim OurPen As Pen
        OurPen = New Pen(Brushes.Red, 5)
        myGraphics.DrawLine(OurPen, locx, 75, locx + 60, 75)
    End Sub

    Public Sub graphcs()
        ClearCanvas()
    End Sub

    Public Sub changeColor(btn As Integer)
        Dim buttns = {cmdUsers, cmdHelp, cmdAbout, btnCalculator}
        For Each b In buttns
            b.ForeColor = Color.White
        Next
        buttns(btn - 1).ForeColor = Color.Red
    End Sub
    Public Sub changeColor(btn As Button)
        Dim buttns = {btnHome, btnOrders, btnSales, btnProducts}
        For Each b In buttns
            b.ForeColor = Color.Gray
        Next
        btn.ForeColor = Color.Red
    End Sub
    Private Sub ClearCanvas()
        GroupBox1.Refresh()
    End Sub

    Public Sub Search(tb As String, txt As TextBox, dt As DataGridView)
        Dim conn As New OleDbConnection With {
            .ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\_atrocious\OneDrive\Documents\VB\POS.mdb")
        }
        conn.Open()

        Dim dts As New DataSet
        Dim db As New DataTable
        dts.Tables.Add(db)
        Dim Dada As New OleDbDataAdapter

        Dada = New OleDbDataAdapter($"Select * from {tb} where [ID] = '" & txt.Text & "' ", conn)
        Dada.Fill(db)

        dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dt.DataSource = db.DefaultView

    End Sub

    Public Sub datagridShow()

        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\_atrocious\OneDrive\Documents\VB\POS.mdb")
        conn.Open()

        Dim dts, dtn, dto, dtp, dtu As New DataSet
        Dim dp, dsa, dn, dor, du As New DataTable
        dts.Tables.Add(dsa)
        dtu.Tables.Add(du)
        dto.Tables.Add(dor)
        dtn.Tables.Add(dn)
        dtp.Tables.Add(dp)
        Dim Dpr, Dsal, Dord, Dnot, Dusr As New OleDbDataAdapter

        Dpr = New OleDbDataAdapter("Select * from Products", conn)
        Dpr.Fill(dp)

        Dord = New OleDbDataAdapter("Select * from Orders", conn)
        Dord.Fill(dor)

        Dsal = New OleDbDataAdapter("Select * from Sales", conn)
        Dsal.Fill(dsa)

        Dnot = New OleDbDataAdapter("Select * from Notifications", conn)
        Dnot.Fill(dn)

        Dusr = New OleDbDataAdapter("Select * from Users", conn)
        Dusr.Fill(du)


        Orders.lvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Products.lvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Sales.lvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Notify.lvNotify.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Users.lvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        Orders.lvOrders.DataSource = dor.DefaultView
        Products.lvProducts.DataSource = dp.DefaultView
        Sales.lvSales.DataSource = dsa.DefaultView
        Notify.lvNotify.DataSource = dn.DefaultView
        Users.lvUsers.DataSource = du.DefaultView
        conn.Close()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        switchPanes(Home)
        graphcs(117)
        changeColor(btnHome)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        switchPanes(Sales)
        graphcs(230)
        changeColor(btnSales)
    End Sub

    Private Sub btnNotifications_Click_1(sender As Object, e As EventArgs) Handles btnNotifications.Click
        switchPanes(Notify)
        Home.notifications(Notify.lvNotify)
        graphcs(575)
        changeColor(btnNotifications)
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        switchPanes(Products)
        graphcs(458)
        changeColor(btnProducts)
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        switchPanes(Orders)
        graphcs(340)
        changeColor(btnOrders)
    End Sub

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        If calculator.Visible Then
            calculator.Hide()
        Else
            calculator.Show()
        End If
        changeColor(4)
        graphcs()

    End Sub

    Private Sub cmdUsers_Click(sender As Object, e As EventArgs) Handles cmdUsers.Click
        switchPanes(Users)
        changeColor(1)
        graphcs()
    End Sub

    Private Sub cmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click
        switchPanes(About)
        changeColor(3)
        graphcs()
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        switchPanes(Help)
        changeColor(2)
        graphcs()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Printer.Print(Home.strPrint)
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        Log_in.Show()
        Me.Close()
    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click
        'lblDate.Text = Format(Now(), "Long Time")
        lblDate.Text = Format(5, "#0.00%")
    End Sub
End Class

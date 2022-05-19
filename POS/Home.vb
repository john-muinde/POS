Imports System.Data.OleDb
Public Class Home
    Public pro As String
    Public conString As String
    Public command As String
    Public myconn As OleDbConnection = New OleDbConnection
    Public cmd As OleDbCommand
    Private result As Double
    Public strPrint As String
    Public restString As String
    Dim arr() As String
    Dim sdr As OleDbDataReader
    Dim valid As Boolean
    Public remaining As Integer = 3

    Public Sub connect()
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\_atrocious\OneDrive\Documents\VB\POS.mdb"
        conString = pro
        myconn.ConnectionString = conString
        myconn.Open()
        cmd = New OleDbCommand(command, myconn)
    End Sub

    Sub printingDocument(userName As String, itemName As String, numberPieces As Integer, unitPrice As Double, totalProductPrice As Double, totalPrice As Double)
        strPrint = "POS| Systems" & vbCrLf
        strPrint = strPrint & "------------------------------" & vbCrLf
        strPrint = strPrint & "No     : TN1254389" & vbCrLf
        strPrint = strPrint & $"Cashier: {userName}" & vbCrLf
        strPrint = strPrint & " " & vbCrLf
        strPrint = strPrint & "Nama   Qty. Costs SubTotal" & vbCrLf
        strPrint = strPrint & "------------------------------" & vbCrLf
        strPrint = strPrint & $"{itemName}    {numberPieces}   {unitPrice}    {totalProductPrice}" & vbCrLf
        strPrint = strPrint & "------------------------------" & vbCrLf
        strPrint = strPrint & $"Total                {totalPrice}" & vbCrLf
    End Sub
    Sub conDB()
        connect()
        command = "Insert Into Sales([ID],[productName],[quantity],[numberOfPieces],[price],[]Date Modified) values('" & txtItemNumber.Text & "')"
        ','" & txtItemName.Text & "','" & txtQuantity.Text & "','" & txtNumberPieces.Text & "','" & txtUnitPrice.Text & "')"
        cmd.Parameters.Add(New OleDbParameter("itemNumber", CType(txtItemNumber.Text, String)))



        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()
    End Sub

    Public Sub Delete(table As String, txt As TextBox)
        connect()
        command = $"Delete from {table} where [ID] = '" & txt.Text & "' "

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Deleted Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Form1.datagridShow()
        myconn.Close()
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

    Public Sub notif(dt As DataGridView)
        Dim conn As New OleDbConnection With {
            .ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\_atrocious\OneDrive\Documents\VB\POS.mdb")
        }
        conn.Open()

        Dim dts As New DataSet
        Dim db As New DataTable
        dts.Tables.Add(db)
        Dim Dada As New OleDbDataAdapter

        Dada = New OleDbDataAdapter("Select * from Products where CInt(numberOfPieces) < 5", conn)
        Dada.Fill(db)


        dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dt.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Sub notifications(dt As DataGridView)
        If dt.Rows.Count < 5 Then
            Form1.lblNotifications.Text = remaining
        Else
            Form1.lblNotifications.Text = ""
        End If
    End Sub

    Sub insertFirstTimeData()
        connect()
        command = "Insert Into Products([ID],[productName],[quantity],[numberOfPieces],[price],[Date Modified]) Select Orders.ID,Orders.productName,Orders.quantity,Orders.numberOfPieces,Orders.price,Orders.dateModified from Orders"

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Inserted Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Form1.datagridShow()
        myconn.Close()
    End Sub
    Sub enterData()
        Dim numberUnits As String = ""
        If txtItemNumber.Text <> "" Then
            connect()

            command = "Select * from Products where ID = '" & txtItemNumber.Text & "' "
            cmd = New OleDbCommand(command, myconn)

            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                Dim pri = CDec(sdr("price"))
                result += pri
                Form1.txtCalculations.Text = Math.Round(result, 2)
                numberUnits = sdr("ID")
                DataGridView1.Rows.Add(New String() {sdr("ID"), sdr("productName"), sdr("price"), sdr("quantity"), 1})

                myconn.Close()

                connect()
                command = "Insert Into Sales Select * from Products where ID = '" & txtItemNumber.Text & "'"
                cmd = New OleDbCommand(command, myconn)

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    valid = True
                    Form1.datagridShow()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    valid = False
                End Try
                myconn.Close()


                txtItemNumber.Clear()

            Else
                MsgBox("Item Not Found")
                txtItemNumber.Focus()
            End If
        Else
            MsgBox("Fill in the Required field")
            txtItemNumber.Focus()
        End If
        myconn.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        computePayment()
    End Sub

    Sub computePayment()
        calculator.Show()
        calculator.txtInput.Text = result

        If valid Then
            MsgBox("All Details Saved successfully")
        End If
    End Sub

    Sub insertRecords(usrId As String)
        command = $"Insert Into Sales([ID],[itemName],[price],[numberOfPieces],[quantity]) Select Products.ID,Products.productName,Products.price,Products.numberOfPieces,Products.quantity from Products where [Products.ID] = {usrId}"

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Inserted Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Form1.datagridShow()
        myconn.Close()
    End Sub

    Public Sub compileDocument()
        connect()

        For Each id In arr
            command = $"Select * from Products where ID = {id}"
            cmd = New OleDbCommand(command, myconn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            While (sdr.Read() = True)
                Dim pri = CDec(sdr("price")) / CInt(sdr("numberOfPieces"))

                printingDocument(lblEmployee.Text.Split(" ")(0), sdr("productName"), 1, pri, pri, Math.Round(result, 2))
            End While
        Next

        myconn.Close()
    End Sub

    Public Sub finalPrint()
        Printer.Print(strPrint)
    End Sub
    Private Sub txtItemNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemNumber.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            enterData()
        End If
    End Sub
End Class
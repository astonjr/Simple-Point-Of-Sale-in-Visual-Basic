Imports System.Data
Imports System.Data.SqlClient
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainpnl.Visible = False
        Cartpnl.Visible = False
        cartleftpnl.Visible = False
        loginpanel.Visible = True
        paidtxt.Visible = False
        till.Visible = False
        tillno.Visible = False

    End Sub

    Private Function cost_of_items() As Double

        Dim sum As Double = 0
        Dim i As Integer = 0

        For i = 0 To DataGridView1.Rows.Count - 1
            sum = sum + Convert.ToDouble(DataGridView1.Rows(i).Cells(2).Value)
        Next i
        Return sum

    End Function

    Sub AddCost()

        If DataGridView1.Rows.Count > 0 Then
            totalcost.Text = FormatCurrency(cost_of_items().ToString("0.00"))
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Cartpnl.Visible = False
        cartleftpnl.Visible = False
        foodleftpnl.Visible = True
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Cartpnl.Visible = True
        cartleftpnl.Visible = True
        foodleftpnl.Visible = False

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Close()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        If WindowState = WindowState.Normal Then
            WindowState = WindowState.Maximized
        ElseIf WindowState = WindowState.Maximized Then
            WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        WindowState = WindowState.Minimized
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim costofitem As Double = 50.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Cup of coffee" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * costofitem
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Cup of coffee", "1", costofitem)
        AddCost()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        Dim costofitem As Double = 20.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Andazi" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * costofitem
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Andazi", "1", costofitem)
        AddCost()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Dim costofitem As Double = 30.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Chapati" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * costofitem
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Chapati", "1", costofitem)
        AddCost()

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

        Dim costofitem As Double = 100.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Bowl of Rice" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * costofitem
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Bowl of Rice", "1", costofitem)
        AddCost()

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click

        Dim costofitem As Double = 100.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Beef Stew" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * costofitem
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Beef Stew", "1", costofitem)
        AddCost()

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click

        Dim costofitem As Double = 150.0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(0).Value = "Fried Pork" Then
                row.Cells(1).Value = Double.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Double.Parse(row.Cells(1).Value) * costofitem
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add("Fried Pork", "1", costofitem)
        AddCost()

    End Sub

    Private Sub Darkmode_Click(sender As Object, e As EventArgs) Handles Darkmode.Click
        If Darkmode.Text = "Dark Mode" Then
            Darkmode.Text = "Light Mode"
            Darkmode.ForeColor = Color.White

            Foodpnl.BackColor = Color.Black
            Cartpnl.BackColor = Color.Black

            Label19.ForeColor = Color.White
            Label13.ForeColor = Color.White
            Label4.ForeColor = Color.White
            Label6.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Label5.ForeColor = Color.White
            Label8.ForeColor = Color.White
            Label10.ForeColor = Color.White
            Label12.ForeColor = Color.White
            Label7.ForeColor = Color.White
            Label9.ForeColor = Color.White
            Label11.ForeColor = Color.White

            Label26.ForeColor = Color.White
            ComboBox1.BackColor = Color.Black
            ComboBox1.ForeColor = Color.White
            Label22.ForeColor = Color.White
            paidtxt.ForeColor = Color.White
            paidtxt.BackColor = Color.Black
            Label23.ForeColor = Color.White
            Label24.ForeColor = Color.White
            balance.ForeColor = Color.White
            Label25.ForeColor = Color.White
            Label21.ForeColor = Color.White
            totalcost.ForeColor = Color.White

            DataGridView1.BackgroundColor = Color.Black
            DataGridView1.GridColor = Color.White

            till.ForeColor = Color.White
            tillno.ForeColor = Color.White

        ElseIf Darkmode.Text = "Light Mode" Then
            Darkmode.Text = "Dark Mode"
            Darkmode.ForeColor = Color.Black

            Foodpnl.BackColor = Color.WhiteSmoke
            Cartpnl.BackColor = Color.WhiteSmoke

            Label19.ForeColor = Color.Black
            Label13.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            Label6.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
            Label8.ForeColor = Color.Black
            Label10.ForeColor = Color.Black
            Label12.ForeColor = Color.Black
            Label7.ForeColor = Color.Black
            Label9.ForeColor = Color.Black
            Label11.ForeColor = Color.Black

            Label26.ForeColor = Color.Black
            ComboBox1.BackColor = Color.WhiteSmoke
            ComboBox1.ForeColor = Color.Black
            Label22.ForeColor = Color.Black
            paidtxt.ForeColor = Color.Black
            paidtxt.BackColor = Color.WhiteSmoke
            Label23.ForeColor = Color.Black
            Label24.ForeColor = Color.Black
            balance.ForeColor = Color.Black
            Label25.ForeColor = Color.Black
            Label21.ForeColor = Color.Black
            totalcost.ForeColor = Color.Black

            DataGridView1.BackgroundColor = Color.WhiteSmoke
            DataGridView1.GridColor = Color.Black

            till.ForeColor = Color.Black
            tillno.ForeColor = Color.Black

        End If
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        Dim amountpaid As Integer

        amountpaid = Val(paidtxt.Text)

        balance.Text = amountpaid - cost_of_items()

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
        AddCost()

        Dim amountpaid As Integer

        amountpaid = Val(paidtxt.Text)

        balance.Text = amountpaid - cost_of_items()
    End Sub

    Private Sub reset_Click_1(sender As Object, e As EventArgs) Handles reset.Click
        balance.Text = "0.00"
        paidtxt.Text = "0.00"
        totalcost.Text = "0.00"
        ComboBox1.Text = ""
        DataGridView1.Rows.Clear()
        DataGridView1.Refresh()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=AJ\SQLEXPRESS01;Initial Catalog=vbloginform;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from login where username='" + txtuser.Text + "' and password='" + txtpass.Text + "'", conn)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()

        sda.Fill(dt)

        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Bon Apetit'😁🍽", "infromation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mainpnl.Visible = True
        Else
            MessageBox.Show("Username or Password is wrong", "information", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cancelloginbtn_Click(sender As Object, e As EventArgs) Handles cancelloginbtn.Click
        Close()
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        mainpnl.Visible = False
        txtuser.Text = ""
        txtpass.Text = ""
    End Sub

    Private Sub txtpass_MouseEnter(sender As Object, e As EventArgs) Handles txtpass.MouseEnter
        If txtpass.Text = "Enter Password" Then
            txtpass.Text = ""
            txtpass.PasswordChar = "*"
            txtpass.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtpass_MouseLeave(sender As Object, e As EventArgs) Handles txtpass.MouseLeave
        If txtpass.Text = "" Then
            txtpass.Text = "Enter Password"
            txtpass.PasswordChar = ""
            txtpass.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtuser_MouseEnter(sender As Object, e As EventArgs) Handles txtuser.MouseEnter
        If txtuser.Text = "Enter username" Then
            txtuser.Text = ""
            txtuser.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtuser_MouseLeave(sender As Object, e As EventArgs) Handles txtuser.MouseLeave
        If txtuser.Text = "" Then
            txtuser.Text = "Enter username"
            txtuser.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "*"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Cash"
                paidtxt.Visible = True
                till.Visible = False
                tillno.Visible = False
            Case "M-pesa"
                paidtxt.Visible = True
                till.Visible = True
                tillno.Visible = True
            Case "Visa Card"
                MessageBox.Show("Sorry! Our system does not suppot Visa Cards", "infromation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                paidtxt.Visible = False
                till.Visible = False
                tillno.Visible = False
                paidtxt.Text = "0"
            Case "Master Card"
                MessageBox.Show("Sorry! Our system does not suppot Master Cards", "infromation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                paidtxt.Visible = False
                till.Visible = False
                tillno.Visible = False
                paidtxt.Text = ""
        End Select
    End Sub
End Class

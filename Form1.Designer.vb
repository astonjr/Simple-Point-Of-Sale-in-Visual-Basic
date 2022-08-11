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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.loginpanel = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cancelloginbtn = New System.Windows.Forms.Button()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.mainpnl = New System.Windows.Forms.Panel()
        Me.Foodpnl = New System.Windows.Forms.Panel()
        Me.Cartpnl = New System.Windows.Forms.Panel()
        Me.tillno = New System.Windows.Forms.Label()
        Me.till = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.balance = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.paidtxt = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.reset = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.totalcost = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Darkmode = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cartleftpnl = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.foodleftpnl = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.loginpanel.SuspendLayout()
        Me.mainpnl.SuspendLayout()
        Me.Foodpnl.SuspendLayout()
        Me.Cartpnl.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'loginpanel
        '
        Me.loginpanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loginpanel.Controls.Add(Me.CheckBox1)
        Me.loginpanel.Controls.Add(Me.cancelloginbtn)
        Me.loginpanel.Controls.Add(Me.loginbtn)
        Me.loginpanel.Controls.Add(Me.txtpass)
        Me.loginpanel.Controls.Add(Me.txtuser)
        Me.loginpanel.Controls.Add(Me.Label31)
        Me.loginpanel.Controls.Add(Me.Label30)
        Me.loginpanel.Controls.Add(Me.Label29)
        Me.loginpanel.Controls.Add(Me.Label28)
        Me.loginpanel.Controls.Add(Me.Label27)
        Me.loginpanel.Location = New System.Drawing.Point(378, 73)
        Me.loginpanel.Name = "loginpanel"
        Me.loginpanel.Size = New System.Drawing.Size(290, 416)
        Me.loginpanel.TabIndex = 14
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(49, 281)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cancelloginbtn
        '
        Me.cancelloginbtn.BackColor = System.Drawing.Color.Red
        Me.cancelloginbtn.Location = New System.Drawing.Point(171, 327)
        Me.cancelloginbtn.Name = "cancelloginbtn"
        Me.cancelloginbtn.Size = New System.Drawing.Size(87, 34)
        Me.cancelloginbtn.TabIndex = 8
        Me.cancelloginbtn.Text = "Exit"
        Me.cancelloginbtn.UseVisualStyleBackColor = False
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.ForestGreen
        Me.loginbtn.Location = New System.Drawing.Point(47, 327)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(87, 34)
        Me.loginbtn.TabIndex = 7
        Me.loginbtn.Text = "login"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(47, 241)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(193, 19)
        Me.txtpass.TabIndex = 6
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(46, 150)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(191, 19)
        Me.txtuser.TabIndex = 5
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(41, 163)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(205, 13)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "_________________________________"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(39, 254)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(211, 13)
        Me.Label30.TabIndex = 3
        Me.Label30.Text = "__________________________________"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(39, 208)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(78, 20)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Password"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(39, 123)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(83, 20)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "Username"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(42, 34)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(207, 39)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Admin Login"
        '
        'mainpnl
        '
        Me.mainpnl.Controls.Add(Me.Foodpnl)
        Me.mainpnl.Controls.Add(Me.Panel2)
        Me.mainpnl.Controls.Add(Me.Panel1)
        Me.mainpnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainpnl.Location = New System.Drawing.Point(0, 0)
        Me.mainpnl.Name = "mainpnl"
        Me.mainpnl.Size = New System.Drawing.Size(1047, 563)
        Me.mainpnl.TabIndex = 17
        '
        'Foodpnl
        '
        Me.Foodpnl.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Foodpnl.Controls.Add(Me.Cartpnl)
        Me.Foodpnl.Controls.Add(Me.Button6)
        Me.Foodpnl.Controls.Add(Me.Button5)
        Me.Foodpnl.Controls.Add(Me.Button4)
        Me.Foodpnl.Controls.Add(Me.Button3)
        Me.Foodpnl.Controls.Add(Me.Button2)
        Me.Foodpnl.Controls.Add(Me.Button1)
        Me.Foodpnl.Controls.Add(Me.Label11)
        Me.Foodpnl.Controls.Add(Me.Label9)
        Me.Foodpnl.Controls.Add(Me.Label12)
        Me.Foodpnl.Controls.Add(Me.Label7)
        Me.Foodpnl.Controls.Add(Me.Label10)
        Me.Foodpnl.Controls.Add(Me.Label5)
        Me.Foodpnl.Controls.Add(Me.Label8)
        Me.Foodpnl.Controls.Add(Me.Label3)
        Me.Foodpnl.Controls.Add(Me.Label6)
        Me.Foodpnl.Controls.Add(Me.Label4)
        Me.Foodpnl.Controls.Add(Me.Label2)
        Me.Foodpnl.Controls.Add(Me.Label13)
        Me.Foodpnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Foodpnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Foodpnl.Location = New System.Drawing.Point(182, 45)
        Me.Foodpnl.Name = "Foodpnl"
        Me.Foodpnl.Size = New System.Drawing.Size(865, 518)
        Me.Foodpnl.TabIndex = 4
        '
        'Cartpnl
        '
        Me.Cartpnl.Controls.Add(Me.tillno)
        Me.Cartpnl.Controls.Add(Me.till)
        Me.Cartpnl.Controls.Add(Me.Label26)
        Me.Cartpnl.Controls.Add(Me.ComboBox1)
        Me.Cartpnl.Controls.Add(Me.Button11)
        Me.Cartpnl.Controls.Add(Me.balance)
        Me.Cartpnl.Controls.Add(Me.Label25)
        Me.Cartpnl.Controls.Add(Me.Label24)
        Me.Cartpnl.Controls.Add(Me.paidtxt)
        Me.Cartpnl.Controls.Add(Me.Label23)
        Me.Cartpnl.Controls.Add(Me.Label22)
        Me.Cartpnl.Controls.Add(Me.reset)
        Me.Cartpnl.Controls.Add(Me.Button9)
        Me.Cartpnl.Controls.Add(Me.Label21)
        Me.Cartpnl.Controls.Add(Me.totalcost)
        Me.Cartpnl.Controls.Add(Me.DataGridView1)
        Me.Cartpnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cartpnl.ForeColor = System.Drawing.Color.Black
        Me.Cartpnl.Location = New System.Drawing.Point(0, 0)
        Me.Cartpnl.Name = "Cartpnl"
        Me.Cartpnl.Size = New System.Drawing.Size(865, 518)
        Me.Cartpnl.TabIndex = 17
        '
        'tillno
        '
        Me.tillno.AutoSize = True
        Me.tillno.Location = New System.Drawing.Point(731, 129)
        Me.tillno.Name = "tillno"
        Me.tillno.Size = New System.Drawing.Size(63, 20)
        Me.tillno.TabIndex = 15
        Me.tillno.Text = "031065"
        '
        'till
        '
        Me.till.AutoSize = True
        Me.till.Location = New System.Drawing.Point(710, 91)
        Me.till.Name = "till"
        Me.till.Size = New System.Drawing.Size(107, 20)
        Me.till.TabIndex = 14
        Me.till.Text = "Mpesa Till No."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(516, 91)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(129, 20)
        Me.Label26.TabIndex = 13
        Me.Label26.Text = "Payment Method"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cash", "M-pesa", "Visa Card", "Master Card"})
        Me.ComboBox1.Location = New System.Drawing.Point(517, 126)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(163, 28)
        Me.ComboBox1.TabIndex = 12
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Orange
        Me.Button11.Location = New System.Drawing.Point(518, 339)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(95, 40)
        Me.Button11.TabIndex = 11
        Me.Button11.Text = "calculate"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'balance
        '
        Me.balance.AutoSize = True
        Me.balance.Location = New System.Drawing.Point(522, 283)
        Me.balance.Name = "balance"
        Me.balance.Size = New System.Drawing.Size(40, 20)
        Me.balance.TabIndex = 10
        Me.balance.Text = "0.00"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(515, 287)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(144, 20)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "_______________"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(515, 252)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 20)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "Balance"
        '
        'paidtxt
        '
        Me.paidtxt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.paidtxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.paidtxt.Location = New System.Drawing.Point(526, 210)
        Me.paidtxt.Name = "paidtxt"
        Me.paidtxt.Size = New System.Drawing.Size(118, 19)
        Me.paidtxt.TabIndex = 7
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(515, 214)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(144, 20)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "_______________"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(513, 175)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 20)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Amount Paid"
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.Color.Orange
        Me.reset.Location = New System.Drawing.Point(657, 406)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(95, 40)
        Me.reset.TabIndex = 4
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Orange
        Me.Button9.Location = New System.Drawing.Point(518, 406)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(95, 40)
        Me.Button9.TabIndex = 3
        Me.Button9.Text = "Remove"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(327, 480)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 20)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Total"
        '
        'totalcost
        '
        Me.totalcost.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.totalcost.AutoSize = True
        Me.totalcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalcost.Location = New System.Drawing.Point(396, 480)
        Me.totalcost.Name = "totalcost"
        Me.totalcost.Size = New System.Drawing.Size(40, 20)
        Me.totalcost.TabIndex = 1
        Me.totalcost.Text = "0.00"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(126, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(348, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Amount"
        Me.Column3.Name = "Column3"
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(555, 294)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(170, 130)
        Me.Button6.TabIndex = 11
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(330, 294)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(170, 130)
        Me.Button5.TabIndex = 10
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(115, 294)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(170, 130)
        Me.Button4.TabIndex = 9
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(555, 74)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 130)
        Me.Button3.TabIndex = 8
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(325, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 130)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(115, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 130)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(559, 426)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 20)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "ksh 150"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(334, 427)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "ksh 100"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(559, 272)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 20)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Pork"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(118, 428)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "ksh 100"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(334, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Beef"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(560, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ksh 30"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(119, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Rice"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(327, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ksh 20"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(561, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Chapati"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(331, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Andazi"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ksh 50"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(119, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 20)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Coffee"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Orange
        Me.Panel2.Controls.Add(Me.Darkmode)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(182, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(865, 45)
        Me.Panel2.TabIndex = 3
        '
        'Darkmode
        '
        Me.Darkmode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Darkmode.FlatAppearance.BorderSize = 0
        Me.Darkmode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange
        Me.Darkmode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.Darkmode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Darkmode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Darkmode.Location = New System.Drawing.Point(756, 3)
        Me.Darkmode.Name = "Darkmode"
        Me.Darkmode.Size = New System.Drawing.Size(106, 39)
        Me.Darkmode.TabIndex = 12
        Me.Darkmode.Text = "Dark Mode"
        Me.Darkmode.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(5, 7)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 31)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "⭐⭐⭐⭐⭐"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label32)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.cartleftpnl)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.foodleftpnl)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(182, 563)
        Me.Panel1.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Lucida Fax", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(7, 106)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 32)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Point"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(7, 126)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(91, 13)
        Me.Label32.TabIndex = 20
        Me.Label32.Text = "______________"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Lucida Fax", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(96, 159)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 32)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Sale"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(94, 179)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(73, 13)
        Me.Label33.TabIndex = 18
        Me.Label33.Text = "___________"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Lucida Fax", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(84, 145)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(22, 16)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "of"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.SteelBlue
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(0, 361)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(182, 38)
        Me.Button10.TabIndex = 14
        Me.Button10.Text = "🔐 Lock System"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 541)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(166, 13)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "© copyrights reserved by Aston Jr"
        '
        'cartleftpnl
        '
        Me.cartleftpnl.BackColor = System.Drawing.Color.Orange
        Me.cartleftpnl.ForeColor = System.Drawing.Color.Orange
        Me.cartleftpnl.Location = New System.Drawing.Point(0, 310)
        Me.cartleftpnl.Name = "cartleftpnl"
        Me.cartleftpnl.Size = New System.Drawing.Size(11, 38)
        Me.cartleftpnl.TabIndex = 12
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.SteelBlue
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(0, 308)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(182, 38)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "🛒 MyCart"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'foodleftpnl
        '
        Me.foodleftpnl.BackColor = System.Drawing.Color.Orange
        Me.foodleftpnl.ForeColor = System.Drawing.Color.Orange
        Me.foodleftpnl.Location = New System.Drawing.Point(0, 255)
        Me.foodleftpnl.Name = "foodleftpnl"
        Me.foodleftpnl.Size = New System.Drawing.Size(11, 38)
        Me.foodleftpnl.TabIndex = 10
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.SteelBlue
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(0, 256)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(182, 38)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "🍕 Food"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(46, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 31)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "♠"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Orange
        Me.Label14.Location = New System.Drawing.Point(85, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 31)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "♠"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "♠"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1047, 563)
        Me.ControlBox = False
        Me.Controls.Add(Me.mainpnl)
        Me.Controls.Add(Me.loginpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS"
        Me.loginpanel.ResumeLayout(False)
        Me.loginpanel.PerformLayout()
        Me.mainpnl.ResumeLayout(False)
        Me.Foodpnl.ResumeLayout(False)
        Me.Foodpnl.PerformLayout()
        Me.Cartpnl.ResumeLayout(False)
        Me.Cartpnl.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents loginpanel As Panel
    Friend WithEvents cancelloginbtn As Button
    Friend WithEvents loginbtn As Button
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents mainpnl As Panel
    Friend WithEvents Foodpnl As Panel
    Friend WithEvents Cartpnl As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button11 As Button
    Friend WithEvents balance As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents paidtxt As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents reset As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents totalcost As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Darkmode As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents cartleftpnl As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents foodleftpnl As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tillno As Label
    Friend WithEvents till As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvCalculator
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbxAmount = New System.Windows.Forms.TextBox()
        Me.txtbxProductCost = New System.Windows.Forms.TextBox()
        Me.txtbxValue = New System.Windows.Forms.TextBox()
        Me.txtbxStockingFee = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 275)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ENTER the amount on hand"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 334)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ENTER the product cost"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 397)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Inventory Value"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 449)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stocking Fee"
        '
        'txtbxAmount
        '
        Me.txtbxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAmount.Location = New System.Drawing.Point(528, 278)
        Me.txtbxAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbxAmount.Name = "txtbxAmount"
        Me.txtbxAmount.Size = New System.Drawing.Size(148, 30)
        Me.txtbxAmount.TabIndex = 4
        '
        'txtbxProductCost
        '
        Me.txtbxProductCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxProductCost.Location = New System.Drawing.Point(528, 334)
        Me.txtbxProductCost.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbxProductCost.Name = "txtbxProductCost"
        Me.txtbxProductCost.Size = New System.Drawing.Size(148, 30)
        Me.txtbxProductCost.TabIndex = 5
        '
        'txtbxValue
        '
        Me.txtbxValue.BackColor = System.Drawing.Color.MistyRose
        Me.txtbxValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxValue.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbxValue.Location = New System.Drawing.Point(528, 389)
        Me.txtbxValue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbxValue.Name = "txtbxValue"
        Me.txtbxValue.Size = New System.Drawing.Size(148, 30)
        Me.txtbxValue.TabIndex = 6
        '
        'txtbxStockingFee
        '
        Me.txtbxStockingFee.BackColor = System.Drawing.Color.MistyRose
        Me.txtbxStockingFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxStockingFee.Location = New System.Drawing.Point(528, 445)
        Me.txtbxStockingFee.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbxStockingFee.Name = "txtbxStockingFee"
        Me.txtbxStockingFee.Size = New System.Drawing.Size(148, 30)
        Me.txtbxStockingFee.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(954, 274)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(162, 52)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(954, 335)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(162, 55)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(954, 449)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(162, 49)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(348, 52)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(300, 37)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Inventory Calculator"
        '
        'frmInvCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtbxStockingFee)
        Me.Controls.Add(Me.txtbxValue)
        Me.Controls.Add(Me.txtbxProductCost)
        Me.Controls.Add(Me.txtbxAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmInvCalculator"
        Me.Text = "Inventory Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbxAmount As TextBox
    Friend WithEvents txtbxProductCost As TextBox
    Friend WithEvents txtbxValue As TextBox
    Friend WithEvents txtbxStockingFee As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label5 As Label
End Class

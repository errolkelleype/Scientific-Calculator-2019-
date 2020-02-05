Public Class Form1
    Dim firstnum As Double
    Dim secondnum As Double
    Dim answer As Double
    Dim opera As String





    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_subtract.Click, btn_multiply.Click, btn_divide.Click, btn_add.Click
        Dim ops As Button = sender
        firstnum = txt_Display.Text
        lblshowop.text = txt_Display.Text
        txt_Display.Text = ""
        Opera = ops.Text
        lblshowop.text = lblshowop.text + " " + Opera
    End Sub

    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        secondnum = txt_Display.Text
        If opera = "+" Then
            answer = firstnum + secondnum
            txt_Display.Text = answer
            lblshowop.text = ""
        ElseIf opera = "-" Then
            answer = firstnum - secondnum
            txt_Display.Text = answer
            lblshowop.text = ""
        ElseIf opera = "*" Then
            answer = firstnum * secondnum
            txt_Display.Text = answer
            lblshowop.text = ""
        ElseIf opera = "/" Then
            answer = firstnum / secondnum
            txt_Display.Text = answer
            lblshowop.text = ""
        ElseIf opera = "Mod" Then
            answer = firstnum Mod secondnum
            txt_Display.Text = answer
            lblshowop.text = ""
        ElseIf opera = "Exp" Then
            answer = firstnum ^ secondnum
            txt_Display.Text = answer
            lblshowop.text = ""

        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        If txt_Display.Text.Length > 0 Then
            txt_Display.Text = txt_Display.Text.Remove(txt_Display.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub btn_dot_Click(sender As Object, e As EventArgs) Handles btn_dot.Click
        If InStr(txt_Display.Text, ".") = 0 Then
            txt_Display.Text = txt_Display.Text + "."
        End If
    End Sub

    Private Sub btn_C_Click(sender As Object, e As EventArgs) Handles btn_C.Click
        txt_Display.Text = "0"
        lblshowop.text = ""
    End Sub

    Private Sub btn_CE_Click(sender As Object, e As EventArgs) Handles btn_CE.Click
        txt_Display.Text = "0"
        lblshowop.text = ""
    End Sub

    Private Sub btn_plusminus_Click(sender As Object, e As EventArgs) Handles btn_plusminus.Click
        If (txt_Display.Text.Contains("-")) Then
            txt_Display.Text = txt_Display.Text.Remove(0, 1)
        Else
            txt_Display.Text = "-" + txt_Display.Text
        End If
    End Sub

    Private Sub btn_pi_Click(sender As Object, e As EventArgs) Handles btn_pi.Click
        txt_Display.Text = "3.14159265359"
    End Sub

    Private Sub btn_log_Click(sender As Object, e As EventArgs) Handles btn_log.Click
        Dim ilog As Double
        ilog = Double.Parse(txt_Display.Text)
        lblshowop.text = System.Convert.ToString("log" + "(" + (txt_Display.Text) + ")")
        ilog = Math.Log10(ilog)
        txt_Display.Text = System.Convert.ToString(ilog)
    End Sub

    Private Sub btn_sqrt_Click(sender As Object, e As EventArgs) Handles btn_sqrt.Click
        Dim iSqrt As Double
        iSqrt = Double.Parse(txt_Display.Text)
        lblshowop.Text = System.Convert.ToString("sqrt" + "(" + (txt_Display.Text) + ")")
        iSqrt = Math.Sqrt(iSqrt)
        txt_Display.Text = System.Convert.ToString(iSqrt)
    End Sub

    Private Sub btn_sinh_Click(sender As Object, e As EventArgs) Handles btn_sinh.Click
        Dim iSinh As Double
        iSinh = Double.Parse(txt_Display.Text)
        lblshowop.Text = System.Convert.ToString("sinh" + "(" + (txt_Display.Text) + ")")
        iSinh = Math.Sinh(iSinh)
        txt_Display.Text = System.Convert.ToString(iSinh)
    End Sub

    Private Sub btn_sin_Click(sender As Object, e As EventArgs) Handles btn_sin.Click
        Dim iSin As Double
        iSin = Double.Parse(txt_Display.Text)
        lblshowop.Text = System.Convert.ToString("sin" + "(" + (txt_Display.Text) + ")")
        iSin = Math.Sin(iSin)
        txt_Display.Text = System.Convert.ToString(iSin)
    End Sub

    Private Sub btn_cosh_Click(sender As Object, e As EventArgs) Handles btn_cosh.Click
        Dim icosh As Double
        icosh = Double.Parse(txt_Display.Text)
        lblshowop.Text = System.Convert.ToString("cosh" + "(" + (txt_Display.Text) + ")")
        icosh = Math.Cosh(icosh)
        txt_Display.Text = System.Convert.ToString(icosh)
    End Sub

    Private Sub btn_cos_Click(sender As Object, e As EventArgs) Handles btn_cos.Click
        Dim icos As Double
        icos = Double.Parse(txt_Display.Text)
        lblshowop.Text = System.Convert.ToString("cos" + "(" + (txt_Display.Text) + ")")
        icos = Math.Cos(icos)
        txt_Display.Text = System.Convert.ToString(icos)
    End Sub

    Private Sub btn_tanh_Click(sender As Object, e As EventArgs) Handles btn_tanh.Click
        Dim iTanh As Double
        iTanh = Double.Parse(txt_Display.Text)
        lblshowop.Text = System.Convert.ToString("tanh" + "(" + (txt_Display.Text) + ")")
        iTanh = Math.Tanh(iTanh)
        txt_Display.Text = System.Convert.ToString(iTanh)
    End Sub

    Private Sub btn_tan_Click(sender As Object, e As EventArgs) Handles btn_tan.Click
        Dim iTan As Double
        iTan = Double.Parse(txt_Display.Text)
        lblshowop.Text = System.Convert.ToString("tan" + "(" + (txt_Display.Text) + ")")
        iTan = Math.Tan(iTan)
        txt_Display.Text = System.Convert.ToString(iTan)
    End Sub

    Private Sub btn_oct_Click(sender As Object, e As EventArgs) Handles btn_oct.Click
        Dim a As Integer = Integer.Parse(txt_Display.Text)
        txt_Display.Text = System.Convert.ToString(a, 8)
    End Sub

    Private Sub btn_hex_Click(sender As Object, e As EventArgs) Handles btn_hex.Click
        Dim a As Integer = Integer.Parse(txt_Display.Text)
        txt_Display.Text = System.Convert.ToString(a, 16)
    End Sub

    Private Sub btn_bin_Click(sender As Object, e As EventArgs) Handles btn_bin.Click
        Dim a As Integer = Integer.Parse(txt_Display.Text)
        txt_Display.Text = System.Convert.ToString(a, 2)
    End Sub

    Private Sub txt_Display_TextChanged(sender As Object, e As EventArgs) Handles txt_Display.TextChanged
        
    End Sub

    Private Sub txt_Display_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Display.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_dec_Click(sender As Object, e As EventArgs) Handles btn_dec.Click
        Dim a As Integer = Integer.Parse(txt_Display.Text)
        txt_Display.Text = System.Convert.ToString(a)
    End Sub

    Private Sub btn_x2_Click(sender As Object, e As EventArgs) Handles btn_x2.Click
        Dim a As Double
        a = Convert.ToDouble(txt_Display.Text) * Convert.ToDouble(txt_Display.Text)
        txt_Display.Text = System.Convert.ToString(a)
    End Sub

    Private Sub btn_x3_Click(sender As Object, e As EventArgs) Handles btn_x3.Click
        Dim a As Double
        a = Convert.ToDouble(txt_Display.Text) * Convert.ToDouble(txt_Display.Text) * Convert.ToDouble(txt_Display.Text)
        txt_Display.Text = System.Convert.ToString(a)
    End Sub

    Private Sub btn_1x_Click(sender As Object, e As EventArgs) Handles btn_1x.Click
        Dim a As Double
        a = Convert.ToDouble(1.0 / Convert.ToDouble(txt_Display.Text))
        txt_Display.Text = System.Convert.ToString(a)
    End Sub

    Private Sub btn_Inx_Click(sender As Object, e As EventArgs) Handles btn_Inx.Click
        Dim ilog As Double
        ilog = Double.Parse(txt_Display.Text)
        lblshowop.Text = System.Convert.ToString("log" + "(" + (txt_Display.Text) + ")")
        ilog = Math.Log(ilog)
        txt_Display.Text = System.Convert.ToString(ilog)
    End Sub

    Private Sub btn_percent_Click(sender As Object, e As EventArgs) Handles btn_percent.Click
        Dim a As Double
        a = Convert.ToDouble(txt_Display.Text) / Convert.ToDouble(100)
        txt_Display.Text = System.Convert.ToString(a)
    End Sub

    Private Sub btn_0_Click_1(sender As Object, e As EventArgs) Handles btn_9.Click, btn_8.Click, btn_7.Click, btn_6.Click, btn_5.Click, btn_4.Click, btn_3.Click, btn_2.Click, btn_1.Click, btn_0.Click
        Dim b As Button = sender
        If txt_Display.Text = "0" Then
            txt_Display.Text = b.Text
        Else
            txt_Display.Text = txt_Display.Text + b.Text
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Display.Text = "0"
        lblshowop.Text = ""
    End Sub
End Class

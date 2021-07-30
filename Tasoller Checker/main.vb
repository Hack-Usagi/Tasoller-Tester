'Hack_Usagi 2021
Public Class main
    Private Sub main_shown(sender As Object, e As EventArgs) Handles MyBase.Load
        'ウィンドウサイズ変更不可
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        'キーの文字背景透明化するおまじない
        PictureBox1.Controls.Add(Key1)
        Key1.Top = Key1.Top - PictureBox1.Top
        Key1.Left = Key1.Left - PictureBox1.Left

        PictureBox2.Controls.Add(Key2)
        Key2.Top = Key2.Top - PictureBox2.Top
        Key2.Left = Key2.Left - PictureBox2.Left

        PictureBox3.Controls.Add(Key3)
        Key3.Top = Key3.Top - PictureBox3.Top
        Key3.Left = Key3.Left - PictureBox3.Left

        PictureBox4.Controls.Add(Key4)
        Key4.Top = Key4.Top - PictureBox4.Top
        Key4.Left = Key4.Left - PictureBox4.Left

        PictureBox5.Controls.Add(Key5)
        Key5.Top = Key5.Top - PictureBox5.Top
        Key5.Left = Key5.Left - PictureBox5.Left

        PictureBox6.Controls.Add(Key6)
        Key6.Top = Key6.Top - PictureBox6.Top
        Key6.Left = Key6.Left - PictureBox6.Left

        PictureBox7.Controls.Add(Key7)
        Key7.Top = Key7.Top - PictureBox7.Top
        Key7.Left = Key7.Left - PictureBox7.Left

        PictureBox8.Controls.Add(Key8)
        Key8.Top = Key8.Top - PictureBox8.Top
        Key8.Left = Key8.Left - PictureBox8.Left

        PictureBox9.Controls.Add(Key9)
        Key9.Top = Key9.Top - PictureBox9.Top
        Key9.Left = Key9.Left - PictureBox9.Left

        PictureBox10.Controls.Add(Key10)
        Key10.Top = Key10.Top - PictureBox10.Top
        Key10.Left = Key10.Left - PictureBox10.Left

        PictureBox11.Controls.Add(Key11)
        Key11.Top = Key11.Top - PictureBox11.Top
        Key11.Left = Key11.Left - PictureBox11.Left

        PictureBox12.Controls.Add(Key12)
        Key12.Top = Key12.Top - PictureBox12.Top
        Key12.Left = Key12.Left - PictureBox12.Left

        PictureBox13.Controls.Add(Key13)
        Key13.Top = Key13.Top - PictureBox13.Top
        Key13.Left = Key13.Left - PictureBox13.Left

        PictureBox14.Controls.Add(Key14)
        Key14.Top = Key14.Top - PictureBox14.Top
        Key14.Left = Key14.Left - PictureBox14.Left

        PictureBox15.Controls.Add(Key15)
        Key15.Top = Key15.Top - PictureBox15.Top
        Key15.Left = Key15.Left - PictureBox15.Left

        PictureBox16.Controls.Add(Key16)
        Key16.Top = Key16.Top - PictureBox16.Top
        Key16.Left = Key16.Left - PictureBox16.Left

        PictureBox17.Controls.Add(Key17)
        Key17.Top = Key17.Top - PictureBox17.Top
        Key17.Left = Key17.Left - PictureBox17.Left

        PictureBox18.Controls.Add(Key18)
        Key18.Top = Key18.Top - PictureBox18.Top
        Key18.Left = Key18.Left - PictureBox18.Left

        PictureBox19.Controls.Add(Key19)
        Key19.Top = Key19.Top - PictureBox19.Top
        Key19.Left = Key19.Left - PictureBox19.Left

        PictureBox20.Controls.Add(Key20)
        Key20.Top = Key20.Top - PictureBox20.Top
        Key20.Left = Key20.Left - PictureBox20.Left

        PictureBox21.Controls.Add(Key21)
        Key21.Top = Key21.Top - PictureBox21.Top
        Key21.Left = Key21.Left - PictureBox21.Left

        PictureBox22.Controls.Add(Key22)
        Key22.Top = Key22.Top - PictureBox22.Top
        Key22.Left = Key22.Left - PictureBox22.Left

        PictureBox23.Controls.Add(key23)
        key23.Top = key23.Top - PictureBox23.Top
        key23.Left = key23.Left - PictureBox23.Left

        PictureBox24.Controls.Add(Key24)
        Key24.Top = Key24.Top - PictureBox24.Top
        Key24.Left = Key24.Left - PictureBox24.Left

        PictureBox25.Controls.Add(Key25)
        Key25.Top = Key25.Top - PictureBox25.Top
        Key25.Left = Key25.Left - PictureBox25.Left

        PictureBox26.Controls.Add(Key26)
        Key26.Top = Key26.Top - PictureBox26.Top
        Key26.Left = Key26.Left - PictureBox26.Left

        PictureBox27.Controls.Add(Key27)
        Key27.Top = Key27.Top - PictureBox27.Top
        Key27.Left = Key27.Left - PictureBox27.Left

        PictureBox28.Controls.Add(Key28)
        Key28.Top = Key28.Top - PictureBox28.Top
        Key28.Left = Key28.Left - PictureBox28.Left

        PictureBox29.Controls.Add(Key29)
        Key29.Top = Key29.Top - PictureBox29.Top
        Key29.Left = Key29.Left - PictureBox29.Left

        PictureBox30.Controls.Add(Key30)
        Key30.Top = Key30.Top - PictureBox30.Top
        Key30.Left = Key30.Left - PictureBox30.Left

        PictureBox31.Controls.Add(Key31)
        Key31.Top = Key31.Top - PictureBox31.Top
        Key31.Left = Key31.Left - PictureBox31.Left

        PictureBox32.Controls.Add(Key32)
        Key32.Top = Key32.Top - PictureBox32.Top
        Key32.Left = Key32.Left - PictureBox32.Left
    End Sub

    Private Sub form1_KeyDown(ByVal sender As Object,
        ByVal e As KeyEventArgs) Handles Me.KeyDown
        'Touch Sensor
        If e.KeyData = Keys.D1 Then PictureBox1.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.A Then PictureBox2.BackColor = Color.DeepSkyBlue

        If e.KeyData = Keys.Q Then PictureBox3.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.Z Then PictureBox4.BackColor = Color.DeepSkyBlue

        If e.KeyData = Keys.D2 Then PictureBox5.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.S Then PictureBox6.BackColor = Color.DeepSkyBlue

        If e.KeyData = Keys.W Then PictureBox7.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.X Then PictureBox8.BackColor = Color.DeepSkyBlue

        If e.KeyData = Keys.D3 Then PictureBox9.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.D Then PictureBox10.BackColor = Color.DeepSkyBlue

        If e.KeyData = Keys.E Then PictureBox11.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.C Then PictureBox12.BackColor = Color.DeepSkyBlue

        If e.KeyData = Keys.D4 Then PictureBox13.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.F Then PictureBox14.BackColor = Color.DeepSkyBlue

        If e.KeyData = Keys.R Then PictureBox15.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.V Then PictureBox16.BackColor = Color.DeepSkyBlue

        If e.KeyData = Keys.D5 Then PictureBox17.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.G Then PictureBox18.BackColor = Color.DeepSkyBlue

        If e.KeyData = Keys.T Then PictureBox19.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.B Then PictureBox20.BackColor = Color.DeepSkyBlue

        If e.KeyData = Keys.D6 Then PictureBox21.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.H Then PictureBox22.BackColor = Color.DeepSkyBlue

        If e.KeyData = Keys.Y Then PictureBox23.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.N Then PictureBox24.BackColor = Color.DeepSkyBlue

        If e.KeyData = Keys.D7 Then PictureBox25.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.J Then PictureBox26.BackColor = Color.DeepSkyBlue

        If e.KeyData = Keys.U Then PictureBox27.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.M Then PictureBox28.BackColor = Color.DeepSkyBlue

        If e.KeyData = Keys.D8 Then PictureBox29.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.K Then PictureBox30.BackColor = Color.DeepSkyBlue

        If e.KeyData = Keys.I Then PictureBox31.BackColor = Color.DeepSkyBlue 'Key31 説明書では"/"に割り当てたれていると書いてあったが実際は"I"
        If e.KeyData = Keys.Oemcomma Then PictureBox32.BackColor = Color.DeepSkyBlue ',

        'Air Sensor
        If e.KeyData = Keys.OemQuestion Then PictureBox33_Air1.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.OemPeriod Then PictureBox34_Air2.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.OemSemicolon Then PictureBox35_Air3.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.Oemplus Then PictureBox38_Air4.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.OemOpenBrackets Then PictureBox37_Air5.BackColor = Color.DeepSkyBlue
        If e.KeyData = Keys.Oemtilde Then PictureBox36_Air6.BackColor = Color.DeepSkyBlue

    End Sub

    Private Sub main_KeyUp(ByVal sender As Object,
    ByVal e As KeyEventArgs) Handles Me.KeyUp
        'Touch Sensor
        If e.KeyData = Keys.D1 Then PictureBox1.BackColor = Color.Silver
        If e.KeyData = Keys.A Then PictureBox2.BackColor = Color.Silver

        If e.KeyData = Keys.Q Then PictureBox3.BackColor = Color.Silver
        If e.KeyData = Keys.Z Then PictureBox4.BackColor = Color.Silver

        If e.KeyData = Keys.D2 Then PictureBox5.BackColor = Color.Silver
        If e.KeyData = Keys.S Then PictureBox6.BackColor = Color.Silver

        If e.KeyData = Keys.W Then PictureBox7.BackColor = Color.Silver
        If e.KeyData = Keys.X Then PictureBox8.BackColor = Color.Silver

        If e.KeyData = Keys.D3 Then PictureBox9.BackColor = Color.Silver
        If e.KeyData = Keys.D Then PictureBox10.BackColor = Color.Silver

        If e.KeyData = Keys.E Then PictureBox11.BackColor = Color.Silver
        If e.KeyData = Keys.C Then PictureBox12.BackColor = Color.Silver

        If e.KeyData = Keys.D4 Then PictureBox13.BackColor = Color.Silver
        If e.KeyData = Keys.F Then PictureBox14.BackColor = Color.Silver

        If e.KeyData = Keys.R Then PictureBox15.BackColor = Color.Silver
        If e.KeyData = Keys.V Then PictureBox16.BackColor = Color.Silver

        If e.KeyData = Keys.D5 Then PictureBox17.BackColor = Color.Silver
        If e.KeyData = Keys.G Then PictureBox18.BackColor = Color.Silver

        If e.KeyData = Keys.T Then PictureBox19.BackColor = Color.Silver
        If e.KeyData = Keys.B Then PictureBox20.BackColor = Color.Silver

        If e.KeyData = Keys.D6 Then PictureBox21.BackColor = Color.Silver
        If e.KeyData = Keys.H Then PictureBox22.BackColor = Color.Silver

        If e.KeyData = Keys.Y Then PictureBox23.BackColor = Color.Silver
        If e.KeyData = Keys.N Then PictureBox24.BackColor = Color.Silver

        If e.KeyData = Keys.D7 Then PictureBox25.BackColor = Color.Silver
        If e.KeyData = Keys.J Then PictureBox26.BackColor = Color.Silver

        If e.KeyData = Keys.U Then PictureBox27.BackColor = Color.Silver
        If e.KeyData = Keys.M Then PictureBox28.BackColor = Color.Silver

        If e.KeyData = Keys.D8 Then PictureBox29.BackColor = Color.Silver
        If e.KeyData = Keys.K Then PictureBox30.BackColor = Color.Silver

        If e.KeyData = Keys.I Then PictureBox31.BackColor = Color.Silver 'Key31 説明書では"/"に割り当てたれていると書いてあったが実際は"I"
        If e.KeyData = Keys.Oemcomma Then PictureBox32.BackColor = Color.Silver

        'Air Sensor
        If e.KeyData = Keys.OemQuestion Then PictureBox33_Air1.BackColor = Color.Silver
        If e.KeyData = Keys.OemPeriod Then PictureBox34_Air2.BackColor = Color.Silver
        If e.KeyData = Keys.OemSemicolon Then PictureBox35_Air3.BackColor = Color.Silver
        If e.KeyData = Keys.Oemplus Then PictureBox38_Air4.BackColor = Color.Silver
        If e.KeyData = Keys.OemOpenBrackets Then PictureBox37_Air5.BackColor = Color.Silver
        If e.KeyData = Keys.Oemtilde Then PictureBox36_Air6.BackColor = Color.Silver
    End Sub
End Class

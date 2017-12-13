Public Class Form1
    Dim h As Integer
    Dim horseimg(,) As Bitmap
    Dim horsepic() As PictureBox
    Dim bet() As RadioButton
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        Randomize()
        horseimg = {{My.Resources._09_1, My.Resources._09_2},
                    {My.Resources._10_1, My.Resources._10_2},
                    {My.Resources._11_1, My.Resources._11_2},
                    {My.Resources._12_1, My.Resources._12_2},
                    {My.Resources._13_1, My.Resources._13_2},
                    {My.Resources._14_1, My.Resources._14_2}}
        horsepic = {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6}
        bet = {RadioButton1, RadioButton2, RadioButton3, RadioButton4, RadioButton5, RadioButton6}
        For i = 0 To 5
            horsepic(i).Left = 80
            horsepic(i).Top = 25 + 50 * i
            bet(i).Location = New Point(40, 35 + 50 * i)
            bet(i).Text = i + 1 & "號"
        Next
        Button2.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i, s As Integer
        Dim msg As String
        For i = 0 To 5
            horsepic(i).Image = horseimg(i, h)
            s = Int(Rnd() * 25)
            horsepic(i).Left += s
            If horsepic(i).Left + horsepic(i).Width >= LineShape2.X1 Then
                Timer1.Enabled = False
                msg = i + 1 & "號馬勝利"
                MsgBox(msg)
                Exit For
            End If
        Next
        h = (h + 1) Mod 2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        h = 0
    End Sub


End Class

Public Class Form1
    Dim h As Integer
    Dim horseimg(,) As Bitmap
    Dim horsepic() As PictureBox
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
    End Sub
End Class

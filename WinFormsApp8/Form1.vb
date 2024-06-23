Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Demo"

    End Sub

    Private Sub BttnPush(sender As Object, e As EventArgs) Handles btnRed.Click

        txtFrst.ForeColor = Color.Red

    End Sub

    Private Sub txtFrst_TextChanged(sender As Object, e As EventArgs) Handles txtFrst.TextChanged

        txtFrst.ForeColor = Color.Blue

    End Sub

    Private Sub txtFrst_Leave(sender As Object, e As EventArgs) Handles txtFrst.Leave

        txtFrst.ForeColor = Color.Black

    End Sub
End Class

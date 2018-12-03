Public Class frmSecond

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Vistra As Integer
        Dim Fristra As Integer
        Dim ComVistra As Integer
        Dim ComFrist As Integer
        Dim Result As Integer
        Dim SumCom As Integer
        Vistra = Val(txtVistra.Text)
        Fristra = Val(txtFristra.Text)
        Result = Vistra + Fristra
        ComVistra = Vistra * 0.05
        ComFrist = Fristra * 0.1
        SumCom = ComVistra + ComFrist

        lblResult.Text = Val(txtVistra.Text) + Val(txtFristra.Text)
        lblComVistra.Text = Val(txtVistra.Text) * 0.05
        lblComFristra.Text = Val(txtFristra.Text) * 0.1
        lblSumCom.Text = Val(lblComVistra.Text) + Val(lblComFristra.Text)

        lblResult.BackColor = Color.CadetBlue


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
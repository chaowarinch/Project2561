Public Class frmFrist

    Private Sub btnSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSum.Click
        'รายได้ทั้งปี = เงินเดือน * 12
        'ภาษี = รายได้ทั้งปี * 0.05
        'เงินได้หลังหักภาษี = รายได้ทั้งปี - ภาษี
        'lblSalary.text
        lblYearSalary.Text = Val(txtSalary.Text) * 12
        lblVat.Text = lblYearSalary.Text * 0.05
        lblResult.Text = Val(lblYearSalary.Text) - Val(lblVat.Text)



    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
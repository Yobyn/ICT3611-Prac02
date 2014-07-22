Public Class Prac02

    Structure Person
        Public name As String
        Public surname As String
        Public Salaray As Double
    End Structure

    Private Sub cmdDisplayMsg_Click(sender As Object, e As EventArgs) Handles cmdDisplayMsg.Click

        If txtName.Text = "" Or txtSalary.Text = "" Or txtSurname.Text = "" Then
            MsgBox("Please make sure you have provided your name, surname and relevant salary")
        Else
            Dim taxAmount As Double

            Dim prs As Person

            prs.name = txtName.Text
            prs.surname = txtSurname.Text
            prs.Salaray = Double.Parse(txtSalary.Text)

            taxAmount = calcTax(prs, rdbSimpleTax.Checked)

            MsgBox(prs.name + " " + prs.surname + ",you are liable for R" + taxAmount.ToString() + " in taxes.")
        End If
    End Sub

    Public Function calcTax(_prs As Person, ByVal simpleCalc As Boolean) As Double

        Dim _taxAmount As Double = 0.0

        If (simpleCalc) Then

            _taxAmount = simpleTaxCalc(_prs.Salaray)
        Else
            _taxAmount = complexTaxCalc(_prs.Salaray)
        End If

        Return _taxAmount

    End Function

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Close()
    End Sub
End Class

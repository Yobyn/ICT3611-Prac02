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

            If (rdbSimpleTax.Checked) Then
                taxAmount = 0.35 * prs.Salaray
            Else
                Dim tmpSalary As Double = prs.Salaray
                Dim complexTaxPortionsPerc As Double() = {25, 22, 18, 12}
                Dim complexTaxPortionsAmount As Integer() = {20000, 10000, 10000}
                Dim count As Integer = 0

                While (tmpSalary > 0)

                    If (count < 3) Then
                        If (tmpSalary > complexTaxPortionsAmount(count)) Then
                            taxAmount += complexTaxPortionsAmount(count) * (complexTaxPortionsPerc(count) / 100.0)
                            tmpSalary -= complexTaxPortionsAmount(count)
                        Else
                            taxAmount += (tmpSalary * (complexTaxPortionsPerc(count) / 100.0))
                            tmpSalary = 0
                        End If

                    Else
                        taxAmount += (tmpSalary * (complexTaxPortionsPerc(count) / 100.0))
                        tmpSalary = 0
                    End If

                    count += 1

                End While

            End If
            MsgBox(prs.name + " " + prs.surname + ",you are liable for R" + taxAmount.ToString() + " in taxes.")
        End If
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Close()
    End Sub
End Class

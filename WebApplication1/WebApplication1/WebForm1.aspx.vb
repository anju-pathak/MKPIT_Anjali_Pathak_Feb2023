Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        n1 = Convert.ToInt32(TextBox1.Text)
        n2 = Convert.ToInt32(TextBox2)
        es = n1 + n2
        Label1.Text = es.ToString()





    End Sub
End Class
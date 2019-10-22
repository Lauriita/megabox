Public Class Form1

    Dim entrada As Integer
    Dim suma As Integer
    Dim total As Integer
    Dim media As Decimal
    Dim menor As Integer
    Dim mayor As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        entrada = InputBox("introduce 1 numero")
        MsgBox(10, "maximo")
        menor = entrada
        mayor = entrada

        For operaciones As Integer = 0 To 10

            suma = suma + entrada
            total = total + 1
            menor = If(menor < entrada) Then  menor = entrada End If
            mayor = If(menor > entrada) Then  mayor = entrada End If

        Next

        media = suma / total

        TextBox3.Text = media
        TextBox1.Text = menor
        TextBox2.Text = mayor



    End Sub
End Class

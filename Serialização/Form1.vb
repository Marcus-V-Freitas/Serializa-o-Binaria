Imports Serialização.Veiculo
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Public Class Form1
    Private Sub btnSerializar_Click(sender As Object, e As EventArgs) Handles btnSerializar.Click
        Dim carro As New Veiculo
        carro.Marca = txtMarca.Text
        carro.Modelo = txtModelo.Text
        carro.Preco = txtPreco.Text

        Dim file As New FileStream("veiculo.dat", FileMode.Create)

        Dim binary As New BinaryFormatter

        binary.Serialize(file, carro)

        file.Close()

    End Sub

    Private Sub btnDeserializar_Click(sender As Object, e As EventArgs) Handles btnDeserializar.Click
        Dim file As New FileStream("veiculo.dat", FileMode.Open)
        Dim binary As New BinaryFormatter

        Dim carro As New Veiculo

        carro = CType(binary.Deserialize(file), Veiculo)

        txtMarca.Text = carro.Marca
        txtModelo.Text = carro.Modelo
        txtPreco.Text = carro.Preco

    End Sub
End Class

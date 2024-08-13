
Imports System.Net.NetworkInformatio
Module module1
    Sub Main()
        Dim frecuencia As Double
        Dim inductancia As Double
        Dim capacitancia As Double
        Dim resistencia As Double

        Console.Write("ingrese la frecuencia")
        frecuencia = Console.ReadLine()
        Console.Write("ingrese la inductancia")
        inductancia = Console.ReadLine()
        Console.Write("ingrese la capacitancia")
        capacitancia = Console.ReadLine()

        Dim XL As Double = 2 * PI * frecuencia * inductancia
        Dim XC As Double = 1 / (2 * PI * frecuencia * inductancia)
        Dim R As Double = resistencia
        Dim X As Double = XL - XC
        Dim Z As Double = Math.Atan((XL - XC) / R)
    End Sub
End Module

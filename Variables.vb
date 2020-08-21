Option Strict On
Option Explicit Off

Module Variables

    Sub Main()

        Dim myFirstNumber As Int32
        Dim secondNumber As Int32
        Dim someString As String
        Dim aTest As Boolean


        myFirstNumber = 42
        secondNumber = 33
        someString = "Texteroni"
        aTest = True
        x = 7

        Console.WriteLine(myFirstNumber)

        Console.WriteLine(myFirstNumber + secondNumber)
        Console.WriteLine(myFirstNumber - secondNumber
                          )
        Console.WriteLine(myFirstNumber * secondNumber
                          )
        Console.WriteLine(someString)
        Console.WriteLine(aTest)
        Console.WriteLine(x)
        Console.Read()

    End Sub

End Module

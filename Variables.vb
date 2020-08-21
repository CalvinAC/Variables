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

        Console.WriteLine(myFirstNumber)
        Console.Read()

        Console.WriteLine(myFirstNumber + secondNumber)
        Console.Read()
        Console.WriteLine(myFirstNumber - secondNumber
                          )
        Console.Read()
        Console.WriteLine(myFirstNumber * secondNumber
                          )
        Console.Read()

        someString = "Texteroni"


        Console.WriteLine(someString)
        Console.Read()

        aTest = True


        Console.WriteLine(aTest)
        Console.Read()

        x = 7

        Console.WriteLine(x)
        Console.Read()

    End Sub

End Module

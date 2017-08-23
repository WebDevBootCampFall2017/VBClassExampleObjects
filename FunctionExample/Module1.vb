Module Module1

    'Define new function OUTSIDE of our main sub
    Function saySomething() As String
        saySomething = "Hello World!"
    End Function

    'This is our main func
    'The entrypoint for the program
    Sub Main()
        Console.WriteLine("{0}", saySomething)

        'Wait for a key
        Console.ReadKey()
    End Sub

End Module

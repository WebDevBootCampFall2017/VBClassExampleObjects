Module Module1

    Sub Main()

        'Make a new stack
        Dim numbers As Stack = New Stack()

        'Loop from 1 to 10 and add items to the stack
        For n = 1 To 10
            numbers.Push(n)
        Next

        'Pop all elements from stack
        While numbers.Count > 0
            Console.WriteLine("{0}", numbers.Pop)
        End While

        'Get a key
        Console.ReadKey()

    End Sub

End Module

Module Module1

    Sub Main()

        'Initialize with numbers 1-10
        Dim numbers As ArrayList = New ArrayList()

        'Loop to set numbers
        For n = 1 To 10
            numbers.Add(n)
        Next

        'Print these numbers out
        For Each n In numbers
            Console.WriteLine("{0}", n)
        Next

        'wait for key press
        Console.ReadKey()

    End Sub

End Module


'Define Fridge Class
Class Fridge
    'Make an arrayList to hold fridge items
    Dim contents As Stack = New Stack

    'Make a Method to get the contents of the fridge
    Function getContents() As ArrayList
        Return New ArrayList(contents.ToArray)
    End Function

    'Make a Method to add an items to the fridge
    Sub addItem(item As String)
        contents.Push(item)
    End Sub
End Class


Module Module1

    Sub Main()

        'Make an instance of the class
        Dim myFridge As Fridge = New Fridge()

        'Add items to fridge
        myFridge.addItem("Peanut Butter")
        myFridge.addItem("Bananas")
        myFridge.addItem("Bread")

        'take a look at whats in here
        For Each item In myFridge.getContents
            Console.WriteLine("{0}", item)
        Next

        'Wait for a key
        Console.ReadKey()

    End Sub

End Module

Module Module1

    Sub Main()

        Const MaximumNumber As Integer = 15

        Dim SecretNumber As Integer
        Dim Guess As Integer
        Dim NumberOfGuesses As Integer = 0
        Dim Rnd As New Random

        Randomize()
        SecretNumber = Rnd.Next(1, MaximumNumber + 1)

        Console.WriteLine("The secret number is between 1 and " & MaximumNumber)
        Console.WriteLine()

        Do
            Console.Write("What is your guess? ")
            Guess = Console.ReadLine()

            If Guess < SecretNumber Then
                Console.WriteLine("Your guess is too LOW")
            ElseIf Guess > SecretNumber Then
                Console.WriteLine("Your guess is too HIGH")
            End If

            Console.WriteLine()
        Loop Until Guess = SecretNumber

        Console.WriteLine("You guessed it! The number is " & SecretNumber)
        Console.WriteLine()
        Console.Write("Press ENTER to end the program.")
        Console.ReadLine()

    End Sub

End Module

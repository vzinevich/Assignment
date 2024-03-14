using Assignment.Logic;

Console.WriteLine("Please provide any integer number:");
var inputValue = Console.ReadLine();

var isInteger = int.TryParse(inputValue, out var sequenceNumber);
int number = 0;

if (isInteger && sequenceNumber > 0)
{
    var fibonaccier = new Fibonaccier();
    var fibonacciNumerOneTask = fibonaccier.GetFibonacciNumberAsync(sequenceNumber);
    var fibonacciNumerTwoTask = fibonaccier.GetFibonacciNumberAsync(sequenceNumber);

    var fibonacciTasks = new List<Task<int>> { fibonacciNumerOneTask, fibonacciNumerTwoTask };

    while (fibonacciTasks.Count > 0)
    {
        var finishedTask = await Task.WhenAny(fibonacciTasks);

        var whichOneIsCompleted = finishedTask == fibonacciNumerOneTask ? "First" : "Second";
        Console.WriteLine($"{whichOneIsCompleted} call completed.");

        number = await finishedTask;
        fibonacciTasks.Remove(finishedTask);
    }
    Console.WriteLine($"The Fibonacci number at position {sequenceNumber} is {number}");
}
else
{
    Console.WriteLine("Check input value");
}

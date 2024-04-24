//https://exercism.org/tracks/csharp/exercises/calculator-conundrum
using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        switch(operation)
        {
            case null:
                 throw new ArgumentNullException("No operator");
            case "-": case "**":
                 throw new ArgumentOutOfRangeException("Operator not supported");
            case "+":
                return $"{operand1} + {operand2} = {operand1 + operand2}";
            case "*":
                return $"{operand1} * {operand2} = {operand1 * operand2}";
            case "/":
                if (operand2 == 0)
                    return "Division by zero is not allowed.";
                return $"{operand1} / {operand2} = {operand1 / operand2}";
            default:
             throw new ArgumentException("Not an operator");
        }
    }
}





public static class SimpleOperation
{
    public static int Division(int operand1, int operand2)
    {
        return operand1 / operand2;
    }

    public static int Multiplication(int operand1, int operand2)
    {
        return operand1 * operand2;
    }

    public static int Addition(int operand1, int operand2)
    {
        return operand1 + operand2;
    }
}
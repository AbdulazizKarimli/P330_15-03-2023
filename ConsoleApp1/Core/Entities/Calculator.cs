﻿using Core.Interfaces;

namespace Core.Entities;

public class Calculator : ISum, IMultiply 
{
    public int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    public int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public int Sum(int number1, int number2, int number3)
    {
        return number1 + number2 + number3;
    }
}
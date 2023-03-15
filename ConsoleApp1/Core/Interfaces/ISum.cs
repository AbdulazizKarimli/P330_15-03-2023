using Core.Entities;

namespace Core.Interfaces;

public interface ISum
{
    int Sum(int number1, int number2);
    int Sum(int number1, int number2, int number3);
}

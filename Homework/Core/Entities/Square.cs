namespace Core.Entities;

public class Square : Figure
{
    private int _side;

    public int Side 
    {
        get => _side;
        set
        {
            if(value > 0)
                _side = value;
        }
    }

    public Square(int side)
    {
        Side = side;
    }

    public override int CalcArea()
    {
        return Side * Side;
    }
}
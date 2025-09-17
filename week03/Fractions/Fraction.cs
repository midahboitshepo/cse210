using System;

public class Franction
{
    private int _top;
    private int _bottom;

    public Franction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Franction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Franction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public override string ToString()
    {
        return GetFractionString();
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

  
}
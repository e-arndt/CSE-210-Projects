using System;


public class Fraction
{
    // Class variables
    private int _top;
    private int _bottom;


    // Preset or Defualt values when no arguments are passed in
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // One values is passed in, the other is preset / default
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Both values are passed in, there are no preset or default values
    public Fraction(int topNum, int bottomNum)
    {
        _top = topNum;
        _bottom = bottomNum;
    }

    // GetTop function simply returns the top value stored in the class variable or the default
    public int GetTop()
    {
        return _top;
    }

    // SetTop function accepts one argument for the top value and sets the class variable to the value passed in
    public void SetTop(int top)
    {
        _top = top;
    }

    // GetBottom function simply returns the bottom value stored in the class variable or the default
    public int GetBottom()
    {
        return _bottom;
    }

    // SetBottom function accepts one argument for the bottom value and sets the class variable to the value passed in
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // GetFractionString function returns a string which reads top# / bottom#
    public string GetFractionString()
    {
        string myFraction = ($"{_top} / {_bottom}");
        return myFraction;
    }

    // GetDecimalValue function returns a double(float) or decimal value, calculated by
    // specifing the top and bottom numbers be in decimal form, top divided by bottom, 
    // return the answer in decimal or double format
    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }

}
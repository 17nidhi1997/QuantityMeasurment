using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    // Enum For Quanitity measure unit
    public class Unit
    {
    public static readonly Unit Feet = new Unit(12.0);
    public static readonly Unit Inch = new Unit(1.0);
    public static readonly Unit Centimeter = new Unit(0.4);
    public static readonly Unit Yard = new Unit(36.0);
    public static readonly Unit Litre = new Unit(1.0);
    public static readonly Unit Mililitre = new Unit(0.001);
    public static readonly Unit Gallon = new Unit(3.78);
    public static readonly Unit KiloGram = new Unit(1.0);
    public static readonly Unit Grams = new Unit(0.001);
    public static readonly Unit Tonne = new Unit(1000);
    public static readonly Unit Fahrenheit = new Unit(1.0);
    public static readonly Unit Celsius = new Unit(2.12);
    public static IEnumerable<Unit> values
    {
        get
        {
            yield return Feet;
            yield return Inch;
            yield return Centimeter;
            yield return Yard;
            yield return Litre;
            yield return Mililitre;
            yield return Gallon;
            yield return KiloGram;
            yield return Grams;
            yield return Tonne;
            yield return Fahrenheit;
            yield return Celsius;
        }
    }

    private double ConversionFactory;
    private Unit(double baseUnit)
    {
        this.ConversionFactory = baseUnit;
    }
    public double GetConvertedValue(double values)
    {
        return this.ConversionFactory * values;
    }

}}


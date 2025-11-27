public class Car
{
    // Member variables
    private string _brand;
    private int _year;

    // Properties
    public string Brand
    {
        get { return _brand; }
        set { _brand = value; }
    }

    public int Year
    {
        get { return _year; }
        set { _year = value; }
    }

    // Empty constructor
    public Car()
    {
        _brand = "Unknown";
        _year = 0;
    }

    // Constructor with parameters
    public Car(string brand, int year)
    {
        _brand = brand;
        _year = year;
    }

    // Member function
    public int GetCarAge()
    {
        return DateTime.Now.Year - _year;
    }

    // Override of ToString()
    public override string ToString()
    {
        return $"{_brand} - {_year}";
    }
}

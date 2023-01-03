/*
 * Beginning with C# 9, you use the record keyword to define a reference type that
 * provides built-in functionality for encapsulating data. C# 10 allows the record
 * class syntax as a synonym to clarify a reference type, and record struct to define
 * a value type with similar functionality. You can create record types with immutable
 * properties by using positional parameters or standard property syntax.
 */
//The following two examples demonstrate record (or record class) reference types:
public record Person(string FirstName, string LastName);

public record Person2
{
    public string FirstName { get; init; } = default!;
    public string LastName { get; init; } = default!;
};

//You can also create records with mutable properties and fields:
public record Person3
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
};

//The following two examples demonstrate record struct value types:
public readonly record struct Point(double X, double Y, double Z);

public record struct Point2
{
    public double X { get; init; }
    public double Y { get; init; }
    public double Z { get; init; }
}

//Record structs can be mutable as well, both positional record structs and record structs with no positional parameters:
public record struct DataMeasurement(DateTime TakenAt, double Measurement);

public record struct Point3
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
}


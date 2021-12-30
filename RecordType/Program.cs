using RecordType;


// records
Person sandro = new(1, "Sandro Bormolini", new DateOnly(1986, 12, 2));
Person sandro2 = new(1, "Sandro Bormolini", new DateOnly(1986, 12, 2));

Person sandroButYounger = sandro with { DateOfBirth = new DateOnly(1996, 12, 2) };

Console.WriteLine(sandro);
Console.WriteLine(sandroButYounger);
// compare
Console.WriteLine(sandro == sandro2);
Console.WriteLine(ReferenceEquals(sandro, sandro2));

// deconstruct
var (id, name, dateOfBirth) = sandro;
Console.WriteLine($"{name} ({id}) is born at {dateOfBirth}");


// classes
PersonAsClass sandroAsClass = new()
{
    Id = 1,
    FullName = "Sandro Bormolini",
    DateOfBirth = new DateOnly(1986, 12, 2)
};

PersonAsClass sandroAsClass2 = new()
{
    Id = 1,
    FullName = "Sandro Bormolini",
    DateOfBirth = new DateOnly(1986, 12, 2)
};

Console.WriteLine(sandroAsClass);
// compare
Console.WriteLine(sandroAsClass == sandroAsClass2);

// check sharplab.io
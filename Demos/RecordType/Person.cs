using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordType;

public record Person(int Id, string FullName, DateOnly DateOfBirth);

//public record class Person(int Id, string FullName, DateOnly DateOfBirth);

//public record Person
//{
//    public int Id { get; init; } = default!;
//    public string FullName { get; init; } = default!;
//    public DateOnly DateOfBirth { get; init; } = default!;

//    protected virtual bool PrintMembers(StringBuilder builder)
//    {
//        builder.Append($"Id is: {Id}");
//        builder.Append($"FullName is: {FullName}");
//        builder.Append($"Date of Birth is: {DateOfBirth}");
//        return true;
//    }
//}

public record struct PersonAsStruct(int Id, string FullName, DateOnly DateOfBirth);

public class PersonAsClass
{
    public int Id { get; init; } = default!;
    public string FullName { get; init; } = default!;
    public DateOnly DateOfBirth { get; init; } = default!;
}
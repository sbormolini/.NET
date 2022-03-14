using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism;

public class GradeSchool
{
    private readonly Dictionary<string, int> _students = new();

    public void Add(string student, int grade) => _students.Add(student, grade);

    public IEnumerable<string> Roster() =>
        _students.OrderBy(student => student.Key)
                .OrderBy(student => student.Value)
                .Select(student => student.Key)
                .ToList();

    public IEnumerable<string> Grade(int grade) =>
        _students.Where(student => student.Value == grade)
                .Select(student => student.Key)
                .OrderBy(student => student);
}
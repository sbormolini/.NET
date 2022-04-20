using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype;

public class Person
{
    public int Age;
    public DateTime BirthDate;
    public string Name;
    public IdInfo IdInfo;

    public Person ShallowCopy()
    {
        return (Person)MemberwiseClone();
    }

    public Person DeepCopy()
    {
        Person clone = (Person)MemberwiseClone();
        clone.IdInfo = new IdInfo(IdInfo.IdNumber);
        clone.Name = String.Copy(Name);
        return clone;
    }
}
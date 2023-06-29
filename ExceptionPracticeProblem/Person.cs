using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPracticeProblem;
public class Person
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0) // Age cannot be negative
            {
                throw new InvalidAgeException("Age cannot be negative.");
            }
            age = value;
        }
    }

    public string GetAgeCategory()
    {
        if (Age >= 1 && Age <= 14)
        {
            return "Children";
        }
        else if (Age >= 15 && Age <= 24)
        {
            return "Youth";
        }
        else if (Age >= 25 && Age <= 64)
        {
            return "Adults";
        }
        else if (Age >= 65)
        {
            return "Seniors";
        }
        else
        {
            throw new InvalidAgeException("Invalid age provided.");
        }
    }
}
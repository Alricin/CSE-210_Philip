using System;

class Person
{
    string _Name;
    string _Sex;
    public Person()
    {

    }
    public virtual string CompileInformation()
    {
        return $"{_Name}, {_Sex}";
    }
}
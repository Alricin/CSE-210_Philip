using System;

class Person
{
    protected string _Name;
    protected string _Sex;
    public Person()
    {

    }
    public virtual string CompileInformation()
    {
        return $"{_Name}, {_Sex}";
    }
}
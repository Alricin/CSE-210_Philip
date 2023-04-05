using System;

class Worker: Person
{
    string _Occupation;
    public Worker()
    {

    }
    public override string CompileInformation()
    {
        return $"{_Name}, {_Sex}, {_Occupation}";
    }
}
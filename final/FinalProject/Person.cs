using System;

class Person
{
    protected string _Name;
    List<string> NameList = new List<string>();
    protected string _Sex;
    Random rnd = new Random();
    public Person()
    {

    }
    public void ChooseSex()
    {
        if (rnd.Next(1,3) == 1)
        {
            _Sex = "Male";
        }
        else
        {
            _Sex = "Female";
        }
    }
    public void ChooseName()
    {
        ChooseSex();
        if (_Sex == "Male")
        {
            NameList.Add("Ander");
            NameList.Add("Blath");
            NameList.Add("Bran");
            NameList.Add("Frath,");
            NameList.Add("Geth");
            NameList.Add("Lander,");
            NameList.Add("Luth");
            NameList.Add("Malcer,");
            NameList.Add("Stor,");
            NameList.Add(" Taman,");
            NameList.Add("Urth");
        }
        else
        {
            NameList.Add("Amafrey,");
            NameList.Add("Betha");
            NameList.Add(" Cefrey");
            NameList.Add("Kethra");
            NameList.Add("Mara");
            NameList.Add("Olga");
            NameList.Add("Silifrey");
            NameList.Add("Westra");
        }
        _Name = NameList[rnd.Next(0, NameList.Count())];
    }
    public virtual string CompileInformation()
    {
        return $"{_Name}, {_Sex}";
    }
}
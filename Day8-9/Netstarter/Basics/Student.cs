class Student
{
    public string name;
    public string address;
    public int roll;
    public DateTime dob;
   
   
    public void PrintDetails()
    {
Console.Writeline($"{name} {address} {roll} {dob}");

    }
}
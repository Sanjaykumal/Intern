//language integreted query

//


class LINQ
{
    int [] ages = [23,45,,67,8,,9,12,345,889,76,,34,56,78];
  List<Student> students = [
        new Student() { name = "Ram", address = "Ktm"},
        new Student() { name = "Laxman", address = "Dang"},
        new Student() { name = "Bikendra", address = "Ktm"},
        new Student() { name = "Sandip", address = "Dang"},
        new Student() { name = "Chahana", address = "Dhangadhi"},
    ];
    //fin squares of all the number in collection

    public void LearLinq()
    {
        //imperative
        List<int> squares = [];
        foreach(var age in ages)
        {
            var Square = age*age;
            squares.Add(Square);
        }
        //Declarative
        var squares = ages.Select(ages=>age*age);
        //find the odd numbers within ages
        var odd = ages.where(x=>x%2==1);
        
        
        
        
        //fin the cubes of all even numbers within age collection
         var cubes = from age in ages select age*age*age where(x=>x%2==0);
        
        //find the students who lives in Dang and short the result by name
        var students = from student in students select student orderby name where address.contains "Dang";
    
    
    }
}
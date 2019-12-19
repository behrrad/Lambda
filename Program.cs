using System;
using System.Linq;
namespace Lambda
{
    class Name{
        public int id;
        public string name, lastName, address;
        public Name(int id, string name, string lastName, string address){
            this.id = id;
            this.name = name; 
            this.lastName = lastName;
            this.address = address;
        }
    }
    class Salary{
        public int id;
        public int sal;
        public string month;
        public Salary(int id, int sal, string month){
            this.id = id;
            this.sal = sal;
            this.month = month;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Name[] names = new Name[3];
            names[0] = new Name(1, "behrad", "khorram", "Tehran");
            names[1] = new Name(3, "Nikka", "shahabi", "Shamirzad");
            names[2] = new Name(4, "rahim", "ghasemi", "Tabriz");
            Salary[] salaries = new Salary[9];
            salaries[0] = new Salary(1, 2000, "Dey");
            salaries[1] = new Salary(1, 2000, "Bahman");
            salaries[2] = new Salary(1, 2000, "Esfand");
            salaries[3] = new Salary(3, 1890, "Dey");
            salaries[4] = new Salary(3, 2312, "Bahman");
            salaries[5] = new Salary(3, 2333, "Esfand");
            salaries[6] = new Salary(4, 2412, "Dey");
            salaries[7] = new Salary(4, 1000, "Bahman");
            salaries[8] = new Salary(4, 1987, "Esfand");
            var joined = names.GroupJoin(salaries, person => person.id, sal=>sal.id, 
            (person, salaryGroup)=> new{
                person = person.name, 
                sum_of_salaries = salaryGroup.ToArray().Sum(s => s.sal)
            }).OrderByDescending(x=>x.sum_of_salaries).First(); 
            //string[] name = {"Rahim","Ghasemi", "Behrad", "Ahmad", "Moeen","Somaye", "Soosan", "Sina", "Soroosh"};
            //var names = name.Where(n => n.Contains("i") || n.Contains("I"));
           // var shoroS = name.Where(n => n.StartsWith("s") || n.StartsWith("S") );
            //var endM = name.Where(n => n.EndsWith("m") || n.EndsWith("M"));
            // foreach (var n in endM)
            // {
            //     Console.WriteLine(n);
            // }
            //var firstSelect = numbers.Where(a => a==444).Single();
            //var firstSelect2 = numbers.Where(a => a==98).SingleOrDefault();
            //Console.WriteLine(firstSelect);
            //Console.WriteLine(firstSelect2);

        }
    }
}

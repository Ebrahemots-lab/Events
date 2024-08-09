using EventsLib.AssignmentEmployee;


namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee E1 = new Employee(1, new DateTime(1940, 1, 1),-10);
            Employee E2 = new Employee(2, new DateTime(1998, 1, 1),-12);
            Employee E3 = new Employee(3, new DateTime(1933, 1, 1), 3);
            Employee E4 = new Employee(4, new DateTime(1980, 1, 1), 0);
            SalesPerson sales = new SalesPerson(10, new DateTime(1998, 1, 1),22);
            sales.AchievedTarget = 10;
            sales.FireSalesPerson();
            Department dept1 = new Department() { DeptID = 10,DeptName = "Programming"};
            Department dept2 = new Department() { DeptID = 20,DeptName = "hr"};

            Club club1 = new Club() {ClubID = 100, ClubName = "Barcelona" };
            Club club2 = new Club() { ClubID = 200, ClubName = "Fifa" };


            dept1.AddStaff(E1);
            dept1.AddStaff(E2);
            dept2.AddStaff(E3);
            dept2.AddStaff(E4);

            club1.AddMember(E1);
            club1.AddMember(E2);
            club2.AddMember(E3);
            club2.AddMember(E4);

            E1.RequestVacation(new DateTime(2021, 1, 1), new DateTime(2021, 1, 12));
            E2.RequestVacation(new DateTime(2021, 1, 1), new DateTime(2021, 1, 10));
            E3.RequestVacation(new DateTime(2021, 1, 1), new DateTime(2021, 1, 10));
            E4.RequestVacation(new DateTime(2021, 1, 1), new DateTime(2021, 1, 10));

            Console.WriteLine(dept1);
            Console.WriteLine(dept2);
            Console.WriteLine(club1);
            Console.WriteLine(club2);

            Console.WriteLine("==========================");

            E1.LayOffEmp();
            E2.LayOffEmp();





















        }
    }
}

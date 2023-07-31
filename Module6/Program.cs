namespace Module6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_6_3_1();
        }

        private static void Task_6_3_1()
        {
            var department = GetCurrentDepartment();
            ShowDepartment(department);
        }

        static Department GetCurrentDepartment()
        {
            return new Department("Банк", "Точка", "Санкт-Петербург");
        }

        private static void ShowDepartment(Department department)
        {
            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine(
                    $"У банка {department.Company?.Name ?? "Неизвестная компания"} есть отделение в Санкт-Петербурге");
            }
        }
    }
}

class Company
{
    public string Type;
    public string Name;

    public Company(string type, string name)
    {
        Type = type;
        Name = name;
    }
}

class Department
{
    public Company Company;
    public City City;

    public Department(string companyType, string companyName, string cityName)
    {
        Company = new Company(companyType, companyName);
        City = new City(cityName);
    }
}
class City
{
    public string Name;

    public City(string name)
    {
        Name = name;
    }
}

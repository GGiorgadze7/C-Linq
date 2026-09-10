//დავალება 1
//შეიმუშავეთ სამომხმარებლო ტიპი “კომპანია”. მასში უნდა იყოს იფორმაცია კომპანიის სახელის, დაარსების
//თარიღის, ბიზნეს პროფილის (მარკეტინგი, IT და ა.შ.), დირექტორის სახელის, თანამშრომლების რაოდენიბისა
//და მისამართის შესახებ.
//კომპანიის მასივისთვის, შეიმუშავეთ შემდეგი ბრძანებები:
//2 | P a g e
// ყველა იმ კომპანიათა სიის მიღება, რომელთა დასახელებაში სიტყვა”Food” ფიგურირებს.
// ყველა იმ კომპანიათა სიის მიღება, რომლებიც მარკეტინგის ან IT სფეროში არიან.
// ყველა იმ კომპანიათა სიის მიღება, რომელთა თანამშრომლების რაოდენობა 100-300 დიაპაზონშია.
// ყველა იმ კოპმანიათა სიის მიღება, რომელთა დირექტორის გვარია - White
// ყველა იმ კომპანიათა სიის მიღება, რომელთა დაარსების დღიდან 123 დღეა გასული.

using C__Linq.Models;

Company[] companies =
    {
    
    new Company { Name = "Food sashaurme", Profile = BusinessProfile.Food,
    Employees = new List<Employee>
    {
         new Employee { FullName = "gia White", Position = "meshaurme",
                PhoneNumber = "787878", Email = "gia@food.com", Salary = 3000 },
            new Employee { FullName = "John Smith", Position = "Manager",
                PhoneNumber = "45444", Email = "kaxa@food.com", Salary = 4000 },
    },

    DirectorName = "giorgi White", EmployeeCount = 100, FoundedDate = DateTime.Now.AddDays(-300), Address= "Ortachala" },

     new Company { Name = "saqababe", Profile = BusinessProfile.Food,
     Employees = new List<Employee>
    {
         new Employee { FullName = "gia White", Position = "meshaurme",
                PhoneNumber = "787878", Email = "gia@food.com", Salary = 3000 },
            new Employee { FullName = "John Smith", Position = "Manager",
                PhoneNumber = "45444", Email = "kaxa@food.com", Salary = 4000 },
    },
    DirectorName = "giorgi", EmployeeCount = 90, FoundedDate = DateTime.Now.AddDays(-300), Address= "gldani" },

      new Company { Name = "ludis bari", Profile = BusinessProfile.Food,
      Employees = new List<Employee>
    {
         new Employee { FullName = "gia White", Position = "meshaurme",
                PhoneNumber = "787878", Email = "gia@food.com", Salary = 3000 },
            new Employee { FullName = "John Smith", Position = "Manager",
                PhoneNumber = "45444", Email = "kaxa@food.com", Salary = 4000 },
    },
    DirectorName = "giorgi White", EmployeeCount = 50, FoundedDate = DateTime.Now.AddDays(-200), Address= "Ortachala" },

       new Company { Name = "PcRoom", Profile = BusinessProfile.IT,
       Employees = new List<Employee>
    {
         new Employee { FullName = "gia White", Position = "meshaurme",
                PhoneNumber = "787878", Email = "gia@food.com", Salary = 3000 },
            new Employee { FullName = "John Smith", Position = "Manager",
                PhoneNumber = "45444", Email = "kaxa@food.com", Salary = 4000 },
    },
    DirectorName = "giorgi", EmployeeCount = 100, FoundedDate = DateTime.Now.AddDays(-300), Address= "avlabari" },

        new Company { Name = "Food saxinkle", Profile = BusinessProfile.Food,
        Employees = new List<Employee>
    {
         new Employee { FullName = "gia White", Position = "meshaurme",
                PhoneNumber = "787878", Email = "gia@food.com", Salary = 3000 },
            new Employee { FullName = "John Smith", Position = "Manager",
                PhoneNumber = "45444", Email = "kaxa@food.com", Salary = 4000 },
    },
    DirectorName = "giorgi", EmployeeCount = 100, FoundedDate = DateTime.Now.AddDays(-300), Address= "naxalovka" }
};

var foodCompanies = companies.Where(c => c.Name.Contains("Food"));
foreach (var c in foodCompanies) Console.WriteLine(c);
var marketingOrIt = companies.Where(c => c.Profile == BusinessProfile.Marketing || c.Profile == BusinessProfile.IT);
foreach (var c in marketingOrIt) Console.WriteLine(c);
var stafSize = companies.Where(c => c.EmployeeCount >= 100 && c.EmployeeCount <= 300);
foreach (var c in stafSize) Console.WriteLine(c);
var directorIsWhite = companies.Where(c => c.DirectorName.EndsWith("White"));
foreach (var c in directorIsWhite) Console.WriteLine(c);
var dayPass123 = companies.Where(c => (DateTime.Now - c.FoundedDate).Days >= 123);
foreach (var c in dayPass123) Console.WriteLine(c);


var food = companies.GetFoodCompanies();

string companyName = "Food sashaurme";
decimal minSalary = 2000;

var highSalary = companies.Where(c => c.Name ==  companyName)
    .SelectMany(c=> c.Employees)
    .Where(e => e.Salary > 2500);

var startWith23 = companies
    .SelectMany(c => c.Employees)
    .Where(e => e.PhoneNumber.StartsWith ("23"));

var lionEmployees = companies
    .SelectMany(c => c.Employees)
    .Where(e => e.FullName.Contains ("kaxa"));

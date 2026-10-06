using zad3;

Console.WriteLine("Hello, World!");
Console.OutputEncoding = System.Text.Encoding.UTF8;

try
{
    Student student1 = new Student("Иван Иванов Петров", 121223001, "Компютърни системи", "3-ти курс");
    student1.PrintStudentInfo();

    Student student2 = new Student("Мария Георгиева Стоянова", 121223045);
    student2.Specialty = "Софтуерно инженерство";
    student2.Course = "2-ри курс";
    student2.PrintStudentInfo();

    Console.WriteLine("\nОпит за създаване на студент с отрицателен факултетен номер:");
    Student invalidStudent = new Student("Георги Димитров", -5, "Информатика", "1-ви курс");
}
catch (Exception ex)
{
    Console.WriteLine($"\nГРЕШКА ВЪВ ВАЛИДАЦИЯТА: {ex.Message}");
}
        
    
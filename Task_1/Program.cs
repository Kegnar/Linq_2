using Task_1;

var students = new List<Student>
{
    new Student { Name = "Alice", Score = 90 },
    new Student { Name = "Bob", Score = 80 },
    new Student { Name = "Charlie", Score = 88 },
    new Student { Name = "David", Score = 92 }
};
var filtered = students.Where(s=>s.Score>85);
foreach (var student in filtered)
{
    Console.WriteLine($"Имя: {student.Name}\nОценка: {student.Score}\n");
}
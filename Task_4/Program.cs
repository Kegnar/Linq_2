using Task_4;

var students = new List<Student>
{
    new Student { Id = 1, Name = "Alice" },
    new Student { Id = 2, Name = "Bob" }
};

var grades = new List<Grade>
{
    new Grade { StudentId = 1, Subject = "Math", LetterGrade = 'A' },
    new Grade { StudentId = 2, Subject = "Math", LetterGrade = 'B' },
    new Grade { StudentId = 1, Subject = "Science", LetterGrade = 'A' }
};

var studentGrades = from student in students    
        // пробегаем по students
    join grade in grades
        on student.Id equals grade.StudentId
    select new
    {
        student.Id,
        student.Name,
        grade.Subject,
        grade.LetterGrade
    };

// Вывод результата
foreach (var item in studentGrades)
{
    Console.WriteLine($"{item.Id} - {item.Name} - {item.Subject}: {item.LetterGrade}");
}
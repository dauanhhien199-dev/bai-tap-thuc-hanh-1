
Student s = new Student
{
    Name = "Hien",
    Age = 19
};

s.DisplayInfo();

public class Student
{
    public string Name { get; set; } = "";
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Tên sinh viên: {Name}");
        Console.WriteLine($"Tuổi: {Age}");
    }
}

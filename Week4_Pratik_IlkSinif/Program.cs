using Week4_Pratik_IlkSinif;

class Program
{
    static void Main(string[] args)
    {
        Person student1 = new Person();
        student1.Name= "Ali";
        student1.Surname = "Yılmaz";
        student1.BirthDate = new DateOnly(1999,08,03);

        Person student2 = new Person();
        student2.Name = "Elif";
        student2.Surname = "Şeker";
        student2.BirthDate = new DateOnly(2000, 01, 01);

        Person student3 = new Person();
        student3.Name = "Murart";
        student3.Surname = "Okur";
        student3.BirthDate = new DateOnly(2002, 01, 08);

        Person teacher1 = new Person();
        teacher1.Name = "Burak";
        teacher1.Surname = "Yener";
        teacher1.BirthDate = new DateOnly(1984, 05, 01);

        Person teacher2 = new Person();
        teacher2.Name = "Zeynep";
        teacher2.Surname = "Koşar";
        teacher2.BirthDate = new DateOnly(1981, 03, 03);
   

        Console.WriteLine($"Öğrenci 1'in adı ve soyadı: {student1.Name} {student1.Surname} dogum tarihi: {student1.BirthDate}");

        Console.WriteLine($"Öğrenci 2'nin adı ve soyadı: {student2.Name} {student2.Surname} dogum tarihi: {student2.BirthDate}");

        Console.WriteLine($"Öğrenci 3'ün adı ve soyadı: {student3.Name} {student3.Surname} dogum tarihi: {student3.BirthDate}");


        Console.WriteLine($"Öğretmen 1'in adı ve soyadı: {teacher1.Name} {teacher1.Surname} dogum tarihi: {teacher1.BirthDate}");

        Console.WriteLine($"Öğretmen 2'nin adı ve soyadı: {teacher2.Name} {teacher2.Surname} dogum tarihi: {teacher2.BirthDate}");

    }
}

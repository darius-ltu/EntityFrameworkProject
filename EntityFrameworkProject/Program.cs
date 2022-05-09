// See https://aka.ms/new-console-template for more information
using EntityFrameworkProject;

Console.WriteLine("Hello, World!");

DepRepo show = new DepRepo();
Lecture lecture1 = new Lecture() { Name = "Anglų"};
Lecture lecture2 = new Lecture() { Name = "Rusų" };
Lecture lecture3 = new Lecture() { Name = "Prancūzų" };
Lecture lecture4 = new Lecture() { Name = "Vokiečių" };
Student student = new Student() { Name = "Indrė" };
Departament departament = new Departament() { Name = "Kalbų", Students = new List<Student>() { student }, Lectures = new List<Lecture>() { lecture1, lecture2, lecture3, lecture4 } };
//show.AddDepartament(departament);



//Show students list
using (var context = new SchoolContext())
{
    Console.WriteLine("Studentų sąrašas:");
    var stList = context.Students.Select(x => x.Name);

    foreach (var dbStudents in stList)
    {
        Console.WriteLine(dbStudents);
        foreach (var Student in dbStudents);
    }
}

//Show Departaments list
using (var context = new SchoolContext())
{
    Console.WriteLine("Departamentų sąrašas:");
    var depList = context.Departaments.Select(x => x.Name);

    foreach (var dbDepartaments in depList)
    {
        Console.WriteLine(dbDepartaments);
        foreach (var Departament in dbDepartaments);
    }
}

//Show Departaments list
using (var context = new SchoolContext())
{
    Console.WriteLine("Paskaitų sąrašas:");
    var lecList = context.Lectures.Select(x => x.Name);

    foreach (var dbLectures in lecList)
    {
        Console.WriteLine(dbLectures);
        foreach (var Departament in dbLectures) ;
    }
}


//var students = departament.Students.ToList<Student>();
//foreach (var item in students)
//{
//    Console.WriteLine(item.Name);
//}
//Console.WriteLine();

//var students = (from Student in departament.Students orderby Student.Name select Student).ToList<Student>();
//foreach (var stud in students)
//{
//    string name = stud.Name;
//    Console.WriteLine(name);
//}



//using (var contex = new SchoolContext())
//{
//    var student = new Student() { Name = "Andrius" };
//    var departament = new Departament() { Name = "Science", Students = new List<Student>() { student } };
//    var lecture = new Lecture() { Name = "Biology", Students = new List<Student>() { student } };
//    contex.Departaments.Add(departament);
//    contex.Lectures.Add(lecture);
//    contex.SaveChanges();
//}


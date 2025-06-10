using _2802_Course.ContentContext;

var course = new Course("isma", null);
var ss = new Course("adri", null);

var courses = new List<Course>();

courses.Add(course);
courses.Add(ss);


foreach (var coursi in courses)
{
    Console.WriteLine(coursi.Title);
}
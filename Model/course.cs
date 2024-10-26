using System.ComponentModel.DataAnnotations;
public class course
{

    [Key]
    public int CourseId { get; set; }  // Primary key

   
    public string name { get; set; }
    public string LecturerName { get; set; }


}

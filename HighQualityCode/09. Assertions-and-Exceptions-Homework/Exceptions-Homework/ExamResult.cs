using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("grade","Grade must be postive!");
        }
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("minGrade","Minimal grade must be positive!");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("maxGrade","Maximal grade must be bigger than minimal grade");
        }
        if (comments == null || comments == "")
        {
            throw new ArgumentException("Comments are missing or you didn't write anything in the form", "comments");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}

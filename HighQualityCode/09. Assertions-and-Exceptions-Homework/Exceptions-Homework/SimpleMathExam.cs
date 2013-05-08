using System;

public class SimpleMathExam : Exam
{
    private static readonly int numberOfTasks = 2;
    public int ProblemsSolved { get; private set; }

    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved < 0 || problemsSolved > numberOfTasks)
        {
            throw new ArgumentOutOfRangeException("problemsSolved",String.Format("Solved problem by each student are in range [0...{0}]",numberOfTasks));
        }

        this.ProblemsSolved = problemsSolved;
    }

    public override ExamResult Check()
    {
        if (ProblemsSolved == 0) 
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: nothing done.");
        }
        else if (ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "High result: needed is done.");
        }

        return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
    }
}

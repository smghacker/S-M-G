using System;

public class CSharpExam : Exam
{
    private static readonly int maxScore = 100;
    public int Score { get; private set; }

    public CSharpExam(int score)
    {
        if (score < 0 || score > maxScore)
        {
            throw new ArgumentOutOfRangeException("score", String.Format("Score must be in range [0...{0}]",maxScore));
        }

        this.Score = score;
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, 0, maxScore, "Exam results calculated by score.");
    }
}

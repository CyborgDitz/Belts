namespace Kata_Yellow_Exam;


public interface ITakeDamage
    {
        void TakeDamage(int damage);
        string? TargetName { get; set; }
    }

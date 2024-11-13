namespace Kata_Yellow_Exam;


public interface ITakeDamage
    {
        void TakeDamage(int damage);
        string Name { get; }  // Add Name property to the interface
    }

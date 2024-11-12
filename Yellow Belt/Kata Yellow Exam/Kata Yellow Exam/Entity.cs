namespace Kata_Yellow_Exam;

public class Entity : IAttack, ITakeDamage, IAmAlive
{
    public void Attack(string target, int damage)
    {
    }

    public void TakeDamage()
    {
    }
    public bool AmAlive()
    {
        return true;
    }
}

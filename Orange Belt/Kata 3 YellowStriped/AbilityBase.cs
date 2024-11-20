namespace Kata_3_YellowStriped;

public abstract class AbilityBase : IAbility //Encapsulatioooon! Meaningful names!
{ //abstract since two classes inherit and program takes all data from them.
    public string Name { get; private set; } //Encapsulatioooon!
    //the interface was set to public get, but I encapsulated set with private.
    public string Effect { get; private set; } 
//DRY (Don't Repeat Yourself)
    public AbilityBase(string name, string effect)
    { //the variables are set in the constructor so they aren´t accessed from outside the class.
        Name = name;
        Effect = effect;
    }
}

//abstract class can't be instantiated, only inherited
internal abstract class Animal
{
    public abstract void AnimalSound();

    public virtual void Sleep(String sleepSound)
    {
        Console.WriteLine(sleepSound); // or provide the implementation you want
    }
}
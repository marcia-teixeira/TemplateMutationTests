namespace Template;

public class Toy
{
    public bool RecomendadeAge(int age)
    {
        if (age >= 2 && age < 10)
            return true;

        return false;
    }
}
namespace DotnetExercises;

public class Intercambiar
{
    public void IntercambiarVal<T>(ref T valor1 , ref T valor2)
    {
        valor1 = valor2;
        valor2 = valor1;
    }
}
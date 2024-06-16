public static class Extensiones
{

    // ejercicio 5
    public static void ForEach<T>(this IEnumerable<T> secuencia, Action<T> accion)
    {
        foreach (var item in secuencia)
        {
            accion(item);
        }
    }

    public static IEnumerable<T> Donde<T>(this IEnumerable<T> secuencia, Func<T, bool> predicado)
    {
        foreach (var i in secuencia)
        {
            if (predicado(i))
            {
                yield return i;
            }
        }
    }

    public static IEnumerable<TResult> Seleccionar<T, TResult>(this IEnumerable<T> secuencia, Func<T, TResult> selector)
    {
        foreach (var item in secuencia)
        {
            yield return selector(item);
        }
    }
}

namespace Metaverso;

public class System 
{
    public string Metaverso(int x) => 
        (x % 3, x % 5) switch {
            (0, 0) => "Metaverso",
            (0, _) => "Meta",
            (_, 0) => "Verso",
            _ => $"{x}"
        };

    public string Metaverso(int[] xs) => xs.Aggregate("", (acc, x) => acc + Metaverso(x));
}

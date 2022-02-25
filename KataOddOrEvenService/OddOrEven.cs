namespace KataOddOrEvenService;
public class OddOrEven
{
    public string Ask(List<int> liste)
    {
        if(liste.Sum() % 2 == 0)
        {
            return "even";
        }

        return "odd";
    }
}

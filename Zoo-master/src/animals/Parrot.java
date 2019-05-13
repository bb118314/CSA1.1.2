package animals;
import types.Bird;

public class Parrot extends Bird
{
    private String age;

    public Parrot()
    {
        super("Parrot", "bright red and very annoying");
        this.age = "mid-age";
    }


    @Override
    public String makeNoise()
    {
        return "repeats your debit card information.";
    }
}

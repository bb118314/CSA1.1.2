package animals;
import types.Primate;

public class Orangutan extends Primate
{
    private String age;

    public Orangutan()
    {
        super("Orangutan", "orange and reserved");
        this.age = "young";
    }

    @Override
    public String makeNoise()
    {
        return "screams.";
    }
}
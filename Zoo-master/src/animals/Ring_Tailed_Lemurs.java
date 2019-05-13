package animals;
import types.Primate;

public class Ring_Tailed_Lemurs extends Primate
{
    private String age;

    public Ring_Tailed_Lemurs()
    {
        super("Ring Tailed Lemur", "small and active");
        this.age = "somewhat young";
    }

    @Override
    public String makeNoise()
    {
        return "yells violent insults.";
    }
}
package animals;
import types.Reptile;

public class Alligator extends Reptile
{
    private String age;

    public Alligator()
    {
        super("Alligator", "not sure I can't see it under the water");
        this.age = "really old";
    }


    @Override
    public String makeNoise()
    {
        return "roars";
    }
}

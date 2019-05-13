package animals;
import types.Primate;

public class Chimpanzee extends Primate
{
    private String age;

    public Chimpanzee()
    {
        super("Chimpanzee", "brown and sometimes mean");
        this.age = "very young";
    }

    @Override
        public String makeNoise()
    {
        return "screetches and throws feces.";
    }
}
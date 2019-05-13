package types;

import animal_qualities.Flying;
import main.Animal;

public class Bird extends Animal implements Flying {
    public Bird(){
        super("Birds", "They fly around in the sky");
    }
    public Bird(String name, String desc) {
        super(name, desc);
    }
    public String makeNoise()
    {
        return "hoots";
    }
    public String eat()
    {
        return "seeds";
    }
    public String fly() {return "Is being majestic";}
}

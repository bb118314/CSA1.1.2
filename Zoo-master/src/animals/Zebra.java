package animals;

import animal_qualities.Walking;
import main.Animal;

public class Zebra extends Animal implements Walking {
    public Zebra(){
        super("Zebra", "They yonder the fields");
    }
    public Zebra(String name, String desc) {
        super(name, desc);
    }
    public String makeNoise()
    {
        return "honks";
    }
    public String eat()
    {
        return "grass";
    }
    public String walk() {return "walks in the field";}
}

package types;

import animal_qualities.Swimming;
import main.Animal;

public class Reptile extends Animal implements Swimming {
    public Reptile(){
        super("Reptiles", "They swim in the pool");
    }
    public Reptile(String name, String desc) {
        super(name, desc);
    }
    public String makeNoise()
    {
        return "screeches";
    }
    public String eat()
    {
        return "meat";
    }
    public String swim() {return "Swims in the pond";}
}

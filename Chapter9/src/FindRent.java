import javax.swing.*;
import java.awt.*;

public class FindRent {
    public static void main(String[] args) {
        int [] [] rent = {{400, 450, 510},
                          {500, 560, 630},
                          {625, 676, 740},
                          {1000, 1250, 1600},
                          {1550, 1700, 1775},
                          {3500, 5000, 6500}};
        String entry;
        int floor;
        int bedrooms;

        entry = JOptionPane.showInputDialog(null, "Enter a floor number");
        floor = Integer.parseInt(entry);
        entry = JOptionPane.showInputDialog(null, "Enter number of bedrooms");
        bedrooms = Integer.parseInt(entry);

        if (floor > 6 || bedrooms > 3) {
            JOptionPane.showMessageDialog(null, "ERROR, ROOM DOES NOT EXIST");
        }
        else
        JOptionPane.showMessageDialog(null, "The rent for a " + bedrooms + " bedroom apartment on floor " + floor + " is $" + rent[floor][bedrooms]);
    }
}

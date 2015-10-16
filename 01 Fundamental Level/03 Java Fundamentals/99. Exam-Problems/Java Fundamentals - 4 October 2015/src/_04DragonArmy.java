import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class _04DragonArmy {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        LinkedHashMap<String, TreeMap<String, Integer[]>> dragons = new LinkedHashMap<>();

        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < n; i++) {
            String[] dragonData = scanner.nextLine().split(" ");

            String color = dragonData[0];
            String name = dragonData[1];
            int damage = 45;    // Default damage
            int health = 250;   // Default health
            int armor = 10;     // Default armor

            if (!dragonData[2].equals("null")) {
                damage = Integer.parseInt(dragonData[2]);
            }
            if (!dragonData[3].equals("null")) {
                health = Integer.parseInt(dragonData[3]);
            }
            if (!dragonData[4].equals("null")) {
                armor = Integer.parseInt(dragonData[4]);
            }

            Integer[] currentDragonStats = {damage, health, armor};

            TreeMap<String, Integer[]> currentDragon = new TreeMap<String, Integer[]>() {{
                put(name, currentDragonStats);
            }};

            if (!dragons.containsKey(color)) {
                dragons.put(color, currentDragon);
            } else if (!dragons.get(color).containsKey(name)){
                dragons.get(color).put(name, currentDragonStats);
            } else {
                dragons.get(color).get(name)[0] = damage;
                dragons.get(color).get(name)[1] = health;
                dragons.get(color).get(name)[2] = armor;
            }
        }

        for (String color : dragons.keySet()) {
            System.out.format("%s::", color);
            double averageDamage = getAverageStat(dragons.get(color), 0);
            double averageHealth= getAverageStat(dragons.get(color), 1);
            double averageArmor = getAverageStat(dragons.get(color), 2);

            System.out.format("(%.2f/%.2f/%.2f)", averageDamage, averageHealth, averageArmor);
            System.out.println();

            for (String name : dragons.get(color).keySet()) {
                Integer[] stats = dragons.get(color).get(name);
                System.out.format("-%s -> damage: %d, health: %d, armor: %d", name, stats[0], stats[1], stats[2]);
                System.out.println();
            }
        }
    }

    private static double getAverageStat(TreeMap<String, Integer[]> dragons, int stat) {
        int sum = 0;
        for (String name : dragons.keySet()) {
            sum += dragons.get(name)[stat];
        }
        double average = (double)sum / dragons.size();
        return average;
    }
}
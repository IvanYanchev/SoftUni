import java.util.Scanner;
import java.util.TreeMap;

public class _04_Weightlifting {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        TreeMap<String, TreeMap<String, Long>> tm = new TreeMap<>();

        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < n; i++) {
            String[] input = scanner.nextLine().split(" ");
            String player = input[0];
            String exercise = input[1];
            long weight = Integer.parseInt(input[2]);

            if (!tm.containsKey(player)) {
                tm.put (player, new TreeMap<>());
                tm.get(player).put(exercise, weight);
            } else if (!tm.get(player).containsKey(exercise)) {
                tm.get(player).put(exercise, weight);
            } else {
                tm.get(player).put(exercise, tm.get(player).get(exercise) + weight);
            }
        }

        for (String player: tm.keySet()) {
            System.out.printf("%s : ", player);

            int index = 0;
            for (String exercise: tm.get(player).keySet()) {
                System.out.printf("%s - %d kg", exercise, tm.get(player).get(exercise));

                if (index < tm.get(player).size() - 1) {
                    System.out.print(", ");
                }
                index++;
            }
            System.out.println();
        }
    }
}
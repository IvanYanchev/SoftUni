import java.util.Scanner;

public class _01_TinySporebat {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int health = 5800;
        int glowcaps = 0;

        while (true) {
            String input = scanner.nextLine();
            if (input.equals("Sporeggar")) {
                break;
            }

            for (int i = 0; i < input.length() - 1; i++) {
                char ch = input.charAt(i);
                if (ch == 'L') {
                    health += 200;
                } else {
                    health -= ch;
                }
            }

            if (health > 0) {
                glowcaps += Integer.parseInt(input.substring(input.length() - 1));
            } else {
                System.out.printf("Died. Glowcaps: %d", glowcaps);
                return;
            }
        }

        System.out.printf("Health left: %d%n", health);
        if (glowcaps >= 30) {
            System.out.printf("Bought the sporebat. Glowcaps left: %d", glowcaps - 30);
        } else {
            System.out.printf("Safe in Sporeggar, but another %d Glowcaps needed.", 30 - glowcaps);
        }
    }
}
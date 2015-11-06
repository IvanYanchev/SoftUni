import java.util.Scanner;

public class _01_DozenEggs {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int total = 0;

        for (int i = 0; i < 7; i++) {
            String[] input = scanner.nextLine().split(" ");
            int count = Integer.parseInt(input[0]);
            String measure = input[1];

            switch (measure) {
                case "eggs":
                    total += count;
                    break;
                case "dozens":
                    total += 12 * count;
                    break;
            }
        }

        System.out.printf("%d dozens + %d eggs", total / 12, total % 12);
    }
}
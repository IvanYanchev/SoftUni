import java.util.Scanner;

public class _09HitTheTarget {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int target = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i <= 20; i++) {
            for (int j = 0; j <= 20; j++) {
                if (i + j == target) {
                    System.out.printf("%d + %d = %d", i, j, target);
                    System.out.println();
                } else if (i - j == target) {
                    System.out.printf("%d - %d = %d", i, j, target);
                    System.out.println();
                }
            }
        }
    }
}

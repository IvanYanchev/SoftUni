import java.util.Scanner;

public class _02_AddingAngles {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        String[] elements = scanner.nextLine().split(" ");

        int[] angles = new int[n];

        for (int i = 0; i < n; i++) {
            angles[i] = Integer.parseInt(elements[i]);
        }

        boolean isFoundSet = false;

        if (n >= 3) {
            for (int j = 0; j < angles.length - 2; j++) {
                for (int k = j + 1; k < angles.length - 1; k++) {
                    for (int l = k + 1; l < angles.length; l++) {
                        int sum = angles[j] + angles[k] + angles[l];
                        if (sum % 360 == 0) {
                            System.out.printf("%d + %d + %d = %d degrees\n", angles[j], angles[k], angles[l], sum);
                            isFoundSet = true;
                        }
                    }
                }
            }
        }

        if (!isFoundSet) {
            System.out.println("No");
        }
    }
}
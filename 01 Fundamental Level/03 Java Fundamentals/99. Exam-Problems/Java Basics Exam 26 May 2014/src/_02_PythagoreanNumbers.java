import java.util.Arrays;
import java.util.Scanner;

public class _02_PythagoreanNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        int[] numbers = new int[n];

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(scanner.nextLine());
        }
        Arrays.sort(numbers);

        boolean isFound = false;

        if (numbers.length < 3) {
            System.out.println("No");
            return;
        }

        for (int i = 0; i < numbers.length - 2; i++) {
            for (int j = i; j < numbers.length; j++) {
                for (int k = j; k < numbers.length; k++) {
                    int a = numbers[i];
                    int b = numbers[j];
                    int c = numbers[k];

                    if (a * a + b * b == c * c) {
                        System.out.printf("%1$d*%1$d + %2$d*%2$d = %3$d*%3$d", a, b, c);
                        System.out.println();
                        isFound = true;
                    }
                }

            }

        }
        if (!isFound) {
            System.out.println("No");
        }
    }
}
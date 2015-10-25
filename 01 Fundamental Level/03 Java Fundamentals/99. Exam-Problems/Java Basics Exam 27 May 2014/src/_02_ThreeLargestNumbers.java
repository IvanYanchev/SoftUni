import java.math.BigDecimal;
import java.util.Arrays;
import java.util.Scanner;

public class _02_ThreeLargestNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        BigDecimal[] numbers = new BigDecimal[n];

        for (int i = 0; i < n; i++) {
            numbers[i] = new BigDecimal(scanner.nextLine().trim());
        }

        Arrays.sort(numbers);

        for (int i = n - 1; i >= Math.max(n - 3, 0) ; i--) {
            System.out.println(numbers[i].toPlainString());
        }
    }
}
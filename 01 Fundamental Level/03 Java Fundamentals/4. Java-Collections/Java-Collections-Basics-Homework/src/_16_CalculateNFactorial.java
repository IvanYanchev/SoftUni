import java.util.Scanner;

public class _16_CalculateNFactorial {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        int nFactorial = calculateFactorialRecursively(n);
        System.out.println(nFactorial);
    }

    private static int calculateFactorialRecursively (int n) {
        if (n == 0) {
            return 1;
        } else if (n == 1) {
            return 1;
        } else {
            return n * calculateFactorialRecursively(n - 1);
        }
    }
}
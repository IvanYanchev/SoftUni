import java.util.ArrayList;
import java.util.Collections;
import java.util.HashSet;
import java.util.Scanner;

public class _03_BiggestThreePrimeNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] elements = scanner.nextLine().split("[() ]+");

        ArrayList<Integer> numbers = new ArrayList<>();

        for (int i = 0; i < elements.length; i++) {
            if (!elements[i].isEmpty()) {
                int num = Integer.parseInt(elements[i]);

                if (isPrime(num) && !numbers.contains(num)) {
                    numbers.add(num);
                }
            }
        }

        Collections.sort(numbers);

        if (numbers.size() < 3) {
            System.out.println("No");
        } else {
            int sum = 0;
            for (int i = numbers.size() - 1; i >= numbers.size() - 3; i--) {
                sum += numbers.get(i);
            }
            System.out.println(sum);
        }
    }

    private static boolean isPrime(int num) {
        if (num <= 1) {
            return false;
        }

        for (int i = 2; i <= Math.sqrt(num); i++) {
            if (num % i == 0) {
                return false;
            }
        }

        return true;
    }
}
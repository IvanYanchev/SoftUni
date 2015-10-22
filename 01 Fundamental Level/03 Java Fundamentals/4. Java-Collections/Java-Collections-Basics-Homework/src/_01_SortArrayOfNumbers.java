import java.util.Arrays;
import java.util.Scanner;

public class _01_SortArrayOfNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        int[] numbers = new int[n];

        String[] elementsAsString = scanner.nextLine().split(" ");

        for (int i = 0; i < elementsAsString.length; i++) {
            numbers[i] = Integer.parseInt(elementsAsString[i]);
        }

        Arrays.sort(numbers);
        for (int i = 0; i < numbers.length; i++) {
            System.out.printf("%d ", numbers[i]);
        }
    }
}
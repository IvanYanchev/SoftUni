import java.util.Arrays;
import java.util.Comparator;
import java.util.Scanner;
import java.util.stream.IntStream;
import java.util.stream.Stream;

public class _14_SortArrayWithStreamAPI {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        String order = scanner.nextLine();

        int[] numbers = new int[n];

        String[] elementsAsString = scanner.nextLine().split(" ");

        for (int i = 0; i < elementsAsString.length; i++) {
            numbers[i] = Integer.parseInt(elementsAsString[i]);
        }

        int[] sortedNumbers =  Arrays.stream(numbers).sorted().toArray();
    }
}
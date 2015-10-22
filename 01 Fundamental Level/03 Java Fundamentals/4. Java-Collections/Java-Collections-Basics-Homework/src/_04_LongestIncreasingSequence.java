import java.util.Scanner;

public class _04_LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] elements = scanner.nextLine().split(" ");

        int[] numbers = new int[elements.length];
        for (int i = 0; i < elements.length; i++) {
            numbers[i] = Integer.parseInt(elements[i]);
        }

        int sequenceStartIndex = 0;
        int sequenceMaxLength = 1;
        int sequenceCurrentLength = 1;


        for (int i = 0; i < numbers.length - 1; i++) {

            System.out.printf("%d ", numbers[i]);

            if (numbers[i] < numbers[i+1]) {
                sequenceCurrentLength++;
            } else {
                sequenceCurrentLength = 1;
                System.out.printf("%n");
            }

            if (sequenceCurrentLength > sequenceMaxLength) {
                sequenceMaxLength = sequenceCurrentLength;
                sequenceStartIndex = i - sequenceMaxLength + 2;
            }
        }
        System.out.println(numbers[numbers.length - 1]);

        System.out.printf("Longest: ");
        for (int i = sequenceStartIndex; i < sequenceStartIndex + sequenceMaxLength; i++) {
            System.out.printf("%d ", numbers[i]);
        }
    }
}
import java.util.Scanner;

public class _02_PossibleTriangles {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        boolean isFound = false;

        while (true) {
            String input = scanner.nextLine();

            if (input.equals("End")) {
                break;
            }

            String[] splittedInput = input.split(" ");
            double[] numbers = new double[splittedInput.length];

            for (int i = 0; i < splittedInput.length; i++) {
                numbers[i] = Double.parseDouble(splittedInput[i]);
            }

            sort(numbers);
            if (numbers[0]+numbers[1] > numbers[2]) {
                System.out.printf("%.2f+%.2f>%.2f",numbers[0], numbers[1], numbers[2]);
                System.out.println();
                isFound = true;
            }
        }

        if (!isFound) {
            System.out.println("No");
        }
    }

    private static void sort(double[] numbers) {
        if (numbers.length == 1) {
            return;
        }

        for (int i = 0; i < numbers.length - 1; i++) {
            double minElement = Double.MAX_VALUE;
            int index = 0;
            for (int j = i; j < numbers.length; j++) {
                if (numbers[j] < minElement) {
                    minElement = numbers[j];
                    index = j;
                }
            }
            numbers[index] = numbers[i];
            numbers[i] = minElement;
        }
    }
}
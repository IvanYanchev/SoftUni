import java.util.Scanner;

public class _01_MirrorNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        String[] inputNumbers = scanner.nextLine().split(" ");

        if (n == 1) {
            System.out.println("No");
            return;
        }

        boolean isFound = false;

        for (int i = 0; i < inputNumbers.length; i++) {
            char[] number = inputNumbers[i].toCharArray();
            String reverseNumber = new String(reverse(number));

            for (int j = i + 1; j < inputNumbers.length; j++) {

                if (reverseNumber.equals(inputNumbers[j])) {
                    System.out.printf("%s<!>%s", inputNumbers[i], inputNumbers[j]);
                    System.out.println();
                    isFound = true;
                }

            }

        }

        if (!isFound) {
            System.out.println("No");
        }
    }

    private static char[] reverse(char[] number) {
        for (int i = 0; i < number.length / 2; i++) {
            char temp = number[i];
            number[i] = number[number.length - 1 - i];
            number[number.length - 1 - i] = temp;
        }
        return number;
    }
}

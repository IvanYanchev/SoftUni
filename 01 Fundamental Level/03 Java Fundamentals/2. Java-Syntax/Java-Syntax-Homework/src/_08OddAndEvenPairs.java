import java.util.Scanner;

public class _08OddAndEvenPairs {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] array = scanner.nextLine().split(" ");

        if (array.length % 2 != 0) {
            System.out.println("Invalid length");
        } else {
            for (int i = 0; i < array.length; i += 2) {
                int firstNum = Integer.parseInt(array[i]);
                int secondNum = Integer.parseInt(array[i + 1]);

                String str = "different";
                if (firstNum % 2 ==0 && secondNum % 2 == 0) {
                    str = "both are even";
                } else if (firstNum % 2 != 0 && secondNum % 2 != 0) {
                    str = "both are odd";
                }
                System.out.format("%d, %d -> %s", firstNum, secondNum, str);
                System.out.println();
            }
        }
    }
}

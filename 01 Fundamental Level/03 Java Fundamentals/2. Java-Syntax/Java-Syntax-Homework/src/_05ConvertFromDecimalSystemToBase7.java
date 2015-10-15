import java.util.Scanner;

public class _05ConvertFromDecimalSystemToBase7 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int numberInDecimal = Integer.parseInt(scanner.nextLine(), 10);
        String numberInBase7 = Integer.toString(numberInDecimal, 7);

        System.out.println(numberInBase7);

    }
}

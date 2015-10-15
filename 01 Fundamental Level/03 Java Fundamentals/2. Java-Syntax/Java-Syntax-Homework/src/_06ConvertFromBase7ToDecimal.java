import java.util.Scanner;

public class _06ConvertFromBase7ToDecimal {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int numberInBase7 = Integer.parseInt(scanner.nextLine(), 7);
        String numberInDecimal = Integer.toString(numberInBase7, 10);

        System.out.println(numberInDecimal);
    }
}

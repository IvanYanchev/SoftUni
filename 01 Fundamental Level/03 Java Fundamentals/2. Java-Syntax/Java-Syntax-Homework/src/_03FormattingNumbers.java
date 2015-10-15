import java.util.Locale;
import java.util.Scanner;

public class _03FormattingNumbers {
    public static void main(String[] args) {
        //Locale.setDefault(Locale.ROOT);
        Scanner scanner = new Scanner(System.in);
        int a = Integer.parseInt(scanner.nextLine());
        double b = Double.parseDouble(scanner.nextLine());
        double c = Double.parseDouble(scanner.nextLine());

        String intAsHex = Integer.toHexString(a).toUpperCase();
        String intAsBinary = String.format("%10s", Integer.toBinaryString(a)).replace(' ', '0');

        System.out.format("|%-10s|%10s|%10.2f|%-10.3f|", intAsHex, intAsBinary, b, c);
    }
}

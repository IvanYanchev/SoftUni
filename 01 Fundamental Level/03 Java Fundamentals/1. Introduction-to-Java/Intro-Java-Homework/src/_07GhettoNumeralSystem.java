import java.util.Scanner;

public class _07GhettoNumeralSystem {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        char[] decimalNumber = scanner.next().toCharArray();
        // Variant 1
        for (int i = 0; i < decimalNumber.length; i++) {
            String ghettoNumber = null;
            switch (decimalNumber[i]){
                case '0' : ghettoNumber = "Gee"; break;
                case '1' : ghettoNumber = "Bro"; break;
                case '2' : ghettoNumber = "Zuz"; break;
                case '3' : ghettoNumber = "Ma"; break;
                case '4' : ghettoNumber = "Duh"; break;
                case '5' : ghettoNumber = "Yo"; break;
                case '6' : ghettoNumber = "Dis"; break;
                case '7' : ghettoNumber = "Hood"; break;
                case '8' : ghettoNumber = "Jam"; break;
                case '9' : ghettoNumber = "Mack"; break;
            }
            System.out.print(ghettoNumber);
        }
        System.out.println();

        // Variant 2
        String[] ghettoNumbers = new String[] {
                "Gee", "Bro", "Zuz", "Ma", "Duh", "Yo", "Dis", "Hood", "Jam", "Mack"
        };

        for (int i = 0; i < decimalNumber.length; i++) {
            int index = decimalNumber[i] - 48;
            System.out.print(ghettoNumbers[index]);
        }
    }
}
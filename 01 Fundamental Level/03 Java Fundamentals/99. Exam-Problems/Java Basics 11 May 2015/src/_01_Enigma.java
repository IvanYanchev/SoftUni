import java.util.Scanner;

public class _01_Enigma {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < n; i++) {
            String encryptedInput = scanner.nextLine();

            int length = 0;
            for (int j = 0; j < encryptedInput.length(); j++) {
                char ch = encryptedInput.charAt(j);

                if (ch != ' ' && (ch < 48 || ch > 57)) {
                    length++;
                }
            }
            int m = length / 2;

            for (int j = 0; j < encryptedInput.length(); j++) {
                char ch = encryptedInput.charAt(j);
                char decryptedChar  = ch;
                if (ch != ' ' && (ch < 48 || ch > 57)) {
                    decryptedChar = (char)(ch + m);
                }
                System.out.print(decryptedChar);
            }
            System.out.println();
        }
    }
}
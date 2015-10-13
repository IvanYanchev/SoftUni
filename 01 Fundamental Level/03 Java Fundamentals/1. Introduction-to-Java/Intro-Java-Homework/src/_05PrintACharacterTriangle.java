import java.util.Scanner;

public class _05PrintACharacterTriangle {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int triangleWidth = scanner.nextInt();
        int i = 0;

        for (int count = 0; count < 2 * triangleWidth - 1; count++) {

            for (int ascii = 'a'; ascii <= 'a' + i; ascii++) {
                char c = (char)ascii;
                System.out.print(c + " ");
            }

            System.out.println();

            if (count < triangleWidth - 1) {
                i++;
            }
            else {
                i--;
            }
        }
    }
}
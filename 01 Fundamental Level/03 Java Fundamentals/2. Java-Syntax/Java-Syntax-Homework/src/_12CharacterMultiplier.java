import java.util.Scanner;

public class _12CharacterMultiplier {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] str = scanner.nextLine().split(" ");

        System.out.println(characterCodesMultiplied(str[0], str[1]));
    }

    private static int characterCodesMultiplied(String str1, String str2) {
        
        int longerLength = Math.max(str1.length(), str2.length());

        int sum = 0;
        for (int i = 0; i < longerLength; i++) {
            int charCode1 = 1;
            int charCode2 = 1;
            if (i < str1.length()) {
                charCode1 = str1.charAt(i);
            }
            if (i < str2.length()) {
                charCode2 = str2.charAt(i);
            }
            sum += charCode1 * charCode2;
        }

        return sum;
    }
}

import java.util.Scanner;

public class _02_SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] strings = scanner.nextLine().split(" ");
        for (int i = 0; i < strings.length - 1; i++) {
            System.out.printf("%s ", strings[i]);

            if (!strings[i].equals(strings[i+1])) {
                System.out.printf("%n");
            }
        }
        System.out.println(strings[strings.length - 1]);
    }
}
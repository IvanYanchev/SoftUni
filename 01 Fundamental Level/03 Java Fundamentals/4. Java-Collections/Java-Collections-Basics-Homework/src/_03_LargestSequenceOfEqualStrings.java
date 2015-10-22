import java.util.Scanner;

public class _03_LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] strings = scanner.nextLine().split(" ");

        int sequenceStartIndex = 0;
        int sequenceMaxLength = 1;
        int sequenceCurrentLength = 1;


        for (int i = 0; i < strings.length - 1; i++) {

            if (strings[i].equals(strings[i+1])) {
                sequenceCurrentLength++;
            } else {
                sequenceCurrentLength = 1;
            }

            if (sequenceCurrentLength > sequenceMaxLength) {
                sequenceMaxLength = sequenceCurrentLength;
                sequenceStartIndex = i - sequenceMaxLength + 2;
            }
        }

        for (int i = sequenceStartIndex; i < sequenceStartIndex + sequenceMaxLength; i++) {
            System.out.printf("%s ", strings[i]);
        }
    }
}
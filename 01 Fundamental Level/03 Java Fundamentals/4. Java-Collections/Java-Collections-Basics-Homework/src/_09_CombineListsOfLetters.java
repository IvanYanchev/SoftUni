import java.util.ArrayList;
import java.util.Scanner;
import java.util.stream.Collectors;

public class _09_CombineListsOfLetters {
    public static void main(String[] args) {

        ArrayList<Character> list1 = new ArrayList<>();
        ArrayList<Character> list2 = new ArrayList<>();

        readListOfChars(list1);
        readListOfChars(list2);

        for (int i = 0; i < list2.size(); i++) {
            char ch = list2.get(i);
            if (!list1.contains(ch)) {
                list1.add(ch);
            }
        }

        String spaceSeparatedChars = list1.stream()
                .map(i -> i.toString())
                .collect(Collectors.joining(" "));

        System.out.println(spaceSeparatedChars);
    }

    private static void readListOfChars(ArrayList<Character> list) {
        Scanner scanner = new Scanner(System.in);
        String chars = scanner.nextLine();
        for (int i = 0; i < chars.length(); i += 2) {
            list.add(chars.charAt(i));
        }
    }
}
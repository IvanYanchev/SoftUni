import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _01DragonSharp {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        ArrayList<String> listOfStatements = new ArrayList<String>();

        int n = Integer.parseInt(scanner.nextLine());
        int lineNumber = 1;

        String stringPattern = "((if) \\((\\d+)([<>=]+)(\\d+)\\)|else) (loop (\\d{1,2}) )?out \"(.*)\";";
        Pattern pattern = Pattern.compile(stringPattern);

        boolean statementFlag = true;

        for (int i = 0; i < n; i++) {
            String statement = scanner.nextLine();

            Matcher matcher = pattern.matcher(statement);
            boolean matches = matcher.matches();

            if (matches) {

                int repetitions = 1;

                if (matcher.group(7) != null) {
                    repetitions = Integer.parseInt(matcher.group(7));
                }

                String outputString = matcher.group(8);

                if (matcher.group(1).contains("if")) {
                    int value1 = Integer.parseInt(matcher.group(3));
                    int value2 = Integer.parseInt(matcher.group(5));
                    String comparator = matcher.group(4);


                    if ((comparator.equals("==") && value1 == value2) ||
                            (comparator.equals("<") && value1 < value2) ||
                            (comparator.equals(">") && value1 > value2)) {

                        statementFlag = true;

                        for (int loop = 1; loop <= repetitions; loop++) {
                            listOfStatements.add(outputString);
                        }
                    } else {

                        statementFlag = false;
                    }

                } else if (!statementFlag) {

                    for (int loop = 1; loop <= repetitions; loop++) {
                        listOfStatements.add(outputString);
                    }
                }


            } else {
                System.out.format("Compile time error @ line %d", lineNumber);
                return;
            }
            lineNumber++;
        }

        for (int i = 0; i < listOfStatements.size(); i++) {
            System.out.println(listOfStatements.get(i));
        }
    }
}
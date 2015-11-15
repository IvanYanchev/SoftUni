import java.util.Scanner;
import java.util.TreeMap;

public class _03_ExamScore {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        TreeMap<Integer, TreeMap<String, Double>> students = new TreeMap<>();

        String input;

        for (int i = 0; i < 3; i++) {
            input = scanner.nextLine();
        }

        while ((input = scanner.nextLine()).contains("|")) {
            String[] entry = input.split("\\|");

            String name = entry[1].trim();
            int score = Integer.parseInt(entry[2].trim());
            double grade = Double.parseDouble(entry[3].trim());

            if (!students.containsKey(score)) {
                students.put(score, new TreeMap<>());
                students.get(score).put(name, grade);
            } else if (!students.get(score).containsKey(name)) {
                students.get(score).put(name, grade);
            }
        }

        for (Integer score: students.keySet()) {
            System.out.printf("%d -> [", score);
            double sum = 0;
            int index = 0;
            int countStudents = students.get(score).size();

            for (String name: students.get(score).keySet()) {
                System.out.print(name);
                sum += students.get(score).get(name);
                if (index < countStudents - 1) {
                    System.out.print(", ");
                }
                index++;
            }
            System.out.printf("]; avg=%.2f\n", sum/ countStudents);
        }
    }
}
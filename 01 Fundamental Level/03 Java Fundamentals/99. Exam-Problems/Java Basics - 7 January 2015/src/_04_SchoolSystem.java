import java.util.ArrayList;
import java.util.Scanner;
import java.util.TreeMap;

public class _04_SchoolSystem {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        TreeMap<String, TreeMap<String, ArrayList<Double>>> grades = new TreeMap<>();
        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < n; i++) {
            String[] input = scanner.nextLine().split(" ");
            String fullName = input[0] + " " + input[1];
            String subject = input[2];
            double score = Double.parseDouble(input[3]);

            if (!grades.containsKey(fullName)) {
                grades.put(fullName, new TreeMap<>());
                grades.get(fullName).put(subject, new ArrayList<>());
                grades.get(fullName).get(subject).add(score);

            } else if (!grades.get(fullName).containsKey(subject)) {
                grades.get(fullName).put(subject, new ArrayList<>());
                grades.get(fullName).get(subject).add(score);

            } else {
                grades.get(fullName).get(subject).add(score);
            }
        }

        for (String name : grades.keySet()) {
            System.out.printf("%s: [", name);

            int numberOfDisciplines = grades.get(name).size();
            int index = 1;

            for (String discipline : grades.get(name).keySet()) {

                double sum = 0;
                for (int i = 0; i < grades.get(name).get(discipline).size(); i++) {
                    sum += grades.get(name).get(discipline).get(i);
                }
                double average = sum / grades.get(name).get(discipline).size();

                System.out.printf("%s - %.2f", discipline, average);
                if (index < numberOfDisciplines) {
                    System.out.print(", ");
                }
                index++;
            }
            System.out.println("]");
        }
    }
}
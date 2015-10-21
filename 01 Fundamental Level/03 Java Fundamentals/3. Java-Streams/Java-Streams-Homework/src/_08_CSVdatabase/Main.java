package _08_CSVdatabase;

import java.io.*;
import java.util.*;

public class Main {

    private static TreeMap<Integer, Student> students = new TreeMap<>();

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        try (BufferedReader brStudent = new BufferedReader(
                new FileReader("resources/students.txt"));
             BufferedReader brGrades = new BufferedReader(
                     new FileReader("resources/grades.txt")
             )) {
            String input;

            while ((input = brStudent.readLine()) != null) {
                String[] studentData = input.split(",");
                int id = Integer.parseInt(studentData[0]);
                String fullName = studentData[1] + " " + studentData[2];
                int age = Integer.parseInt(studentData[3]);
                String town = studentData[4];

                insertStudent(id, fullName, age, town);
            }

            while ((input = brGrades.readLine()) != null) {
                String[] gradesData = input.split(",");
                int id = Integer.parseInt(gradesData[0]);

                for (int i = 1; i < gradesData.length; i++) {
                    String[] disciplineData = gradesData[i].split(" ");
                    String discipline = disciplineData[0];

                    for (int j = 1; j < disciplineData.length; j++) {
                        double grade = Double.parseDouble(disciplineData[j]);

                        insertGradeById(id, discipline, grade);
                    }
                }
            }

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }

        while (true) {
            String command = scanner.nextLine();
            if (command.equals("End")) {
                break;
            }

            String[] commandArguments = command.split(" ");
            switch (commandArguments[0]) {
                case "Search-by-full-name":
                    String fullName = commandArguments[1] + " " + commandArguments[2];
                    searchByFullName(fullName);
                    break;
                case "Search-by-id":
                    int searchId = Integer.parseInt(commandArguments[1]);
                    searchById(searchId);
                    break;
                case "Delete-by-id":
                    int delId = Integer.parseInt(commandArguments[1]);
                    deleteById(delId);
                    break;
                case "Update-by-id":
                    int updateId = Integer.parseInt(commandArguments[1]);
                    updateById(updateId);
                    break;
                case "Insert-student":
                    String insertFullName = commandArguments[1] + " " + commandArguments[2];
                    int age = Integer.parseInt(commandArguments[3]);
                    String town = commandArguments[4];
                    for (int i = 5; i < commandArguments.length; i++) {
                        town += " " + commandArguments[i];
                    }
                    insertStudent(insertFullName, age, town);
                    break;
                case "Insert-grade-by-id":
                    int insertId = Integer.parseInt(commandArguments[1]);
                    String course = commandArguments[2];
                    double grade = Double.parseDouble(commandArguments[3]);
                    insertGradeById(insertId, course, grade);
                    break;
            }
        }

        try (PrintWriter pwStudent = new PrintWriter(
                new FileWriter("resources/students.txt"));
             PrintWriter pwGrades = new PrintWriter(
                     new FileWriter("resources/grades.txt")
             )) {
            for (Integer id : students.keySet()) {

                Student student = students.get(id);
                String firstName = student.getFullName().split(" ")[0];
                String lastName = student.getFullName().split(" ")[1];
                pwStudent.format("%d,%s,%s,%d,%s%n", id, firstName, lastName, student.getAge(), student.getTown());

                pwGrades.printf("%d", id);
                LinkedHashMap<String, ArrayList<Double>> grades = student.getGrades();
                for (String course : grades.keySet()) {
                    pwGrades.printf(",%s", course);
                    for (int i = 0; i < grades.get(course).size(); i++) {
                        pwGrades.printf(" %.2f", grades.get(course).get(i));
                    }
                }
                pwGrades.format("%n");
            }

        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private static void insertGradeById(int id, String course, double grade) {
        if (!students.containsKey(id)){
            printNotFoundError();
        } else {
            students.get(id).setGrade(course, grade);
        }
    }

    private static void insertStudent(int id, String fullName, int age, String town) {
        students.put(id, new Student(fullName, age, town));
    }

    private static void insertStudent(String fullName, int age, String town) {
        int greatestId = students.lastKey();

        students.put(greatestId + 1, new Student(fullName, age, town));
    }

    private static void updateById(int id) {
        if (!students.containsKey(id)){
            printNotFoundError();
        }
    }

    private static void deleteById(int id) {
        if (!students.containsKey(id)){
            printNotFoundError();
        } else {
            students.remove(id);
        }
    }

    private static void searchById(int id) {
        if (!students.containsKey(id)){
            printNotFoundError();
        } else {
            printStudent(id);
        }
    }

    private static void searchByFullName(String fullName) {
        boolean isFound = false;

        for (Integer id : students.keySet()) {
            if (students.get(id).getFullName().equals(fullName)) {
                isFound = true;
                printStudent(id);
                return;
            }
        }

        if (!isFound) {
            printNotFoundError();
        }
    }

    private static void printStudent(int id) {
        Student student = students.get(id);
        String fullName = student.getFullName();
        int age = student.getAge();
        String town = student.getTown();

        System.out.format("%s (age: %d, town: %s)%n",fullName,age,town);

        LinkedHashMap<String, ArrayList<Double>> grades = student.getGrades();
        for (String course : grades.keySet()) {
            System.out.printf("# %s: ", course);
            for (int i = 0; i < grades.get(course).size() - 1; i++) {
                System.out.printf("%.2f, ", grades.get(course).get(i));
            }
            System.out.printf("%.2f%n", grades.get(course).get(grades.get(course).size() - 1));
        }
    }

    private static void printNotFoundError(){
        System.out.println("Student does not exist");
    }
}
package _01_SumLines;

import java.io.*;

public class Main {
    public static void main(String[] args) {
        try (BufferedReader br = new BufferedReader(
                new FileReader("resources/lines.txt")
        )) {
            String line;
            while ((line = br.readLine()) != null) {
                int charSum = 0;
                for (int i = 0; i < line.length(); i++) {
                    charSum += line.charAt(i);
                }
                System.out.println(charSum);
            }

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
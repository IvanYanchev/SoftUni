package _02_AllCapitals;

import java.io.*;
import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {

        ArrayList<String> list = new ArrayList<>();
        String filePath = "resources/lines.txt";

        try (BufferedReader br = new BufferedReader(
                new FileReader(filePath)
        )) {
            String str;
            while ((str = br.readLine()) != null) {
                list.add(str.toUpperCase());
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }

        try (PrintWriter pw = new PrintWriter(
                new FileWriter(filePath)
        )) {
            for (String str : list) {
                pw.println(str);
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
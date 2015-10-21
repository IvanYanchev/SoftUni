package _04_CopyJpgFile;

import java.io.*;

public class Main {
    public static void main(String[] args) {
        try (BufferedInputStream bis = new BufferedInputStream(
                new FileInputStream("resources/xabyab.jpg"));
             BufferedOutputStream bos = new BufferedOutputStream(
                     new FileOutputStream("resources/my-copied-picture.jpg")
             )) {
            int i;
            while ( (i=bis.read()) != -1) {
                bos.write(i);
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
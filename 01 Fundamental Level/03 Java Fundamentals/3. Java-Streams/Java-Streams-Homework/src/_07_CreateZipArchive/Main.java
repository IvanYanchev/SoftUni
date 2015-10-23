package _07_CreateZipArchive;

import java.io.*;
import java.util.ArrayList;
import java.util.zip.ZipEntry;
import java.util.zip.ZipOutputStream;

public class Main {
    public static void main(String[] args) {

        ArrayList<String> filesForArchive = new ArrayList<String>() {{
            add("resources/words.txt");
            add("resources/count-chars.txt");
            add("resources/lines.txt");
        }};

        try (ZipOutputStream zos = new ZipOutputStream(
                new FileOutputStream("resources/text-files.zip")
        )) {
            for (String filename : filesForArchive) {
                try (BufferedInputStream bis = new BufferedInputStream(
                        new FileInputStream(filename)
                )) {
                    int bytes;
                    
                    zos.putNextEntry(new ZipEntry(filename));

                    while ((bytes = bis.read()) != -1) {
                        zos.write(bytes);
                    }

                    zos.closeEntry();
                }
            }

        } catch (FileNotFoundException fnfExeption) {
            fnfExeption.printStackTrace();
        } catch (IOException ioExeption) {
            ioExeption.printStackTrace();
        }
    }
}
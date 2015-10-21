package _05_SaveAnArrayListOfDoubles;

import java.io.*;
import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {

        ArrayList<Double> list = new ArrayList<Double>() {{
            add(0.34);
            add(5.67);
            add(67.1);
            add(2.54);
            add(3.14);
            add(100.01);
        }};

        try (ObjectOutputStream oos = new ObjectOutputStream(
                new BufferedOutputStream(
                        new FileOutputStream("resources/doubles.list")
                )
        )) {
            oos.writeObject(list);

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }

        list.clear();

        try (ObjectInputStream ois = new ObjectInputStream(
                new BufferedInputStream(
                        new FileInputStream("resources/doubles.list")
                )
        )) {
            list = (ArrayList<Double>) ois.readObject();

            System.out.println(list);

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        }
    }
}
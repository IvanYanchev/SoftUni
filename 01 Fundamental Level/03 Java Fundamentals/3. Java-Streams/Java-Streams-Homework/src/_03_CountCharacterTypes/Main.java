package _03_CountCharacterTypes;

import java.io.*;

public class Main {
    public static void main(String[] args) {

        int vowels = 0;
        int consonants = 0;
        int punctuationMarks = 0;

        try (BufferedReader br = new BufferedReader(
                    new FileReader("resources/words.txt"));
             PrintWriter pw = new PrintWriter(
                     new FileWriter("resources/count-chars.txt")
             )
        ) {
            int i;
            while ((i = br.read()) != -1) {
                switch (i) {
                    case 33:  //!
                    case 44:  //,
                    case 46:  //.
                    case 63:  //?
                        punctuationMarks++;
                        break;
                    case 65:  //A
                    case 97:  //a
                    case 69:  //E
                    case 101: //e
                    case 73:  //I
                    case 105: //i
                    case 79:  //O
                    case 111: //o
                    case 85:  //U
                    case 117: //u
                        vowels++;
                        break;
                    default:
                        if (i != 32) {  //space
                            consonants++;
                        }
                        break;

                }
            }

            pw.printf("Vowels: %d", vowels);
            pw.println();
            pw.printf("Consonants: %d", consonants);
            pw.println();
            pw.printf("Punctuation: %d", punctuationMarks);

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
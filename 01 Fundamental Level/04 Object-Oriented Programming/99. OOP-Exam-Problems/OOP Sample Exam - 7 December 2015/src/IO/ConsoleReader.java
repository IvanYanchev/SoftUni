package IO;

import Contracts.InputReadable;

import java.util.Scanner;

public class ConsoleReader implements InputReadable {
    Scanner scanner;

    public ConsoleReader() {
        this.scanner = new Scanner(System.in);
    }

    @Override
    public String read() {
        return this.scanner.nextLine();
    }
}
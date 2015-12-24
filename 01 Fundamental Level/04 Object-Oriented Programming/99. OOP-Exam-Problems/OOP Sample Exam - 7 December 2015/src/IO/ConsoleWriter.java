package IO;

import Contracts.OutputWriteable;

import java.util.Scanner;

public class ConsoleWriter implements OutputWriteable {

    @Override
    public void write(String message) {
        System.out.println(message);
    }
}
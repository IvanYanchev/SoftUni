import java.util.Scanner;

public class _01RectangleArea {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int a = scanner.nextInt();
        int b = scanner.nextInt();

        int area = a * b;
        System.out.format("%d * %d = %d", a, b, area);
    }
}

import java.util.Scanner;

public class _08GetAverage {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        float a = scanner.nextFloat();
        float b = scanner.nextFloat();
        float c = scanner.nextFloat();

        System.out.format("%.2f", getAverage(a,b,c));
    }

    public static float getAverage(float a, float b, float c) {
        float average = (a + b + c) / 3;
        return  average;
    }
}
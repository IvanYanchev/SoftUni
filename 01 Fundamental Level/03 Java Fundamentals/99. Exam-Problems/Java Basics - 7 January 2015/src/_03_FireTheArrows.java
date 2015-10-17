import java.util.Scanner;

public class _03_FireTheArrows {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        char[][] matrix = new char[n][];

        for (int i = 0; i < n; i++) {
            matrix[i] = scanner.nextLine().toCharArray();
        }

        int maxPossibleMoves = Math.max(matrix.length, matrix[0].length);
        for (int i = 0; i < maxPossibleMoves; i++) {
            for (int row = 0; row < matrix.length; row++) {
                for (int col = 0; col < matrix[0].length; col++) {
                    switch (matrix[row][col]) {
                        case '^': moveUp(matrix, row, col); break;
                        case 'v': moveDown(matrix, row, col); break;
                        case '<': moveLeft(matrix, row, col); break;
                        case '>': moveRight(matrix, row, col); break;
                    }
                }
            }
        }
        printMatrix(matrix);
    }

    private static void moveRight(char[][] matrix, int row, int col) {
        if (col + 1 < matrix[0].length && matrix[row][col + 1] == 'o') {
            matrix[row][col + 1] = '>';
            matrix[row][col] = 'o';
        }
    }

    private static void moveLeft(char[][] matrix, int row, int col) {
        if (col - 1 >= 0 && matrix[row][col - 1] == 'o') {
            matrix[row][col - 1] = '<';
            matrix[row][col] = 'o';
        }
    }

    private static void moveDown(char[][] matrix, int row, int col) {
        if (row + 1 < matrix.length && matrix[row + 1][col] == 'o') {
            matrix[row + 1][col] = 'v';
            matrix[row][col] = 'o';
        }
    }

    private static void moveUp(char[][] matrix, int row, int col) {
        if (row - 1 >= 0 && matrix[row - 1][col] == 'o') {
            matrix[row - 1][col] = '^';
            matrix[row][col] = 'o';
        }
    }

    private static void printMatrix(char[][] matrix) {
        for (int i = 0; i < matrix.length; i++) {
            char[] chars = matrix[i];
            System.out.println(chars);
        }
    }
}
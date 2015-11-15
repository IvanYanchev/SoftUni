import java.util.Scanner;

public class _03_RubiksMatrix {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] dimentions = scanner.nextLine().split(" ");

        int rows = Integer.parseInt(dimentions[0]);
        int cols = Integer.parseInt(dimentions[1]);

        int[][] originalMatrix = new int[rows][cols];
        int[][] matrix = new int[rows][cols];

        int element = 1;
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                originalMatrix[i][j] = element;
                matrix[i][j] = element;
                element++;
            }
        }

        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < n; i++) {
            String[] commandArgs = scanner.nextLine().split(" ");

            int num = Integer.parseInt(commandArgs[0]);
            String direction = commandArgs[1];
            int moves = Integer.parseInt(commandArgs[2]);

            switch (direction) {
                case "up":
                    moves %= matrix.length;
                    for (int move = 0; move < moves; move++) {
                        int temp = matrix[0][num];
                        for (int r = 0; r < matrix.length - 1; r++) {
                            matrix[r][num] = matrix[r + 1][num];
                        }
                        matrix[matrix.length - 1][num] = temp;
                    }
                    break;

                case "down":
                    moves %= matrix.length;
                    for (int move = 0; move < moves; move++) {
                        int temp = matrix[matrix.length - 1][num];
                        for (int r = matrix.length - 2; r >= 0 ; r--) {
                            matrix[r + 1][num] = matrix[r][num];
                        }
                        matrix[0][num] = temp;
                    }
                    break;

                case "left":
                    moves %= matrix[num].length;
                    for (int move = 0; move < moves; move++) {
                        int temp = matrix[num][0];
                        for (int c = 0; c < matrix[num].length - 1; c++) {
                            matrix[num][c] = matrix[num][c + 1];
                        }
                        matrix[num][matrix[num].length - 1] = temp;
                    }
                    break;

                case "right":
                    moves %= matrix[num].length;
                    for (int move = 0; move < moves; move++) {
                        int temp = matrix[num][matrix[num].length - 1];
                        for (int c = matrix[num].length - 2; c >= 0; c--) {
                            matrix[num][c + 1] = matrix[num][c];
                        }
                        matrix[num][0] = temp;
                    }
                    break;
            }
        }

        //OUTPUT
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                int elem = originalMatrix[i][j];
                int[] changed = findElementInMatrix(matrix, elem);
                if (i == changed[0] && j == changed[1]) {
                    System.out.println("No swap required");
                } else {
                    System.out.printf("Swap (%d, %d) with (%d, %d)\n", i, j, changed[0], changed[1]);
                    int temp = matrix[i][j];
                    matrix[i][j] = elem;
                    matrix[changed[0]][changed[1]] = temp;
                }
            }
        }
    }

    private static int[] findElementInMatrix(int[][] matrix, int element) {
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                if (matrix[i][j] == element) {
                    return new int[] {i, j};
                }
            }
        }

        return new int[] {-1, -1};
    }
}
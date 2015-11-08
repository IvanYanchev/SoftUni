import java.util.*;

public class _03DragonTrap {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        char[][] inputMatrix = new char[n][];
        char[][] resultMatrix = new char[n][];

        //INPUT MATRIX
        for (int i = 0; i < n; i++) {
            inputMatrix[i] = scanner.nextLine().toCharArray();
            resultMatrix[i] = inputMatrix[i].clone();
        }

        //INPUT COMMAND LINE
        String command;

        while (!(command = scanner.nextLine()).equals("End")) {
            String[] commandLineArgs = command.split("[() ]+");

            int dragonRow = Integer.parseInt(commandLineArgs[1]);
            int dragonCol = Integer.parseInt(commandLineArgs[2]);
            int radius = Integer.parseInt(commandLineArgs[3]);
            int rotations = Integer.parseInt(commandLineArgs[4]);

            int row;
            int col;

            ArrayList<Character> chars = new ArrayList<>();
            ArrayList<int[]> coordinates = new ArrayList<>();

            //INTERSECTION
            for (col = dragonCol - radius; col <= dragonCol + radius; col++) {
                row = dragonRow - radius;

                if (isInsideTheMatrix(inputMatrix, row, col)) {
                    chars.add(resultMatrix[row][col]);
                    coordinates.add(new int[]{row, col});
                }
            }
            for (row = dragonRow - radius + 1; row <= dragonRow + radius; row++) {
                col = dragonCol + radius;

                if (isInsideTheMatrix(inputMatrix, row, col)) {
                    chars.add(resultMatrix[row][col]);
                    coordinates.add(new int[]{row, col});
                }
            }
            for (col = dragonCol + radius - 1; col >= dragonCol - radius; col--) {
                row = dragonRow + radius;

                if (isInsideTheMatrix(inputMatrix, row, col)) {
                    chars.add(resultMatrix[row][col]);
                    coordinates.add(new int[]{row, col});
                }
            }
            for (row = dragonRow + radius - 1; row > dragonRow - radius; row--) {
                col = dragonCol - radius;

                if (isInsideTheMatrix(inputMatrix, row, col)) {
                    chars.add(resultMatrix[row][col]);
                    coordinates.add(new int[]{row, col});
                }
            }

            //ROTATION
            if (chars.size() > 1) {
                rotations = rotations % chars.size();

                if (rotations != 0) {
                    if (rotations < 0) {
                        for (int i = 0; i < Math.abs(rotations); i++) {
                            char temp = chars.get(0);
                            chars.remove(0);
                            chars.add(temp);
                        }
                    } else {
                        for (int i = 0; i < rotations; i++) {
                            char temp = chars.get(chars.size() - 1);
                            chars.remove(chars.size() - 1);
                            chars.add(0, temp);
                        }
                    }

                    for (int i = 0; i < coordinates.size(); i++) {
                        row = coordinates.get(i)[0];
                        col = coordinates.get(i)[1];
                        resultMatrix[row][col] = chars.get(i);
                    }
                }
            }
        }

        //OUTPUT
        int countChanged = 0;
        for (int row = 0; row < resultMatrix.length; row++) {
            for (int col = 0; col < resultMatrix[row].length; col++) {
                System.out.print(resultMatrix[row][col]);
                if (resultMatrix[row][col] != inputMatrix[row][col]) {
                    countChanged++;
                }
            }
            System.out.println();
        }
        System.out.printf("Symbols changed: %d", countChanged);
    }

    private static boolean isInsideTheMatrix(char[][] matrix, int row, int col) {
        if (row >= 0 && row < matrix.length && col >= 0 && col < matrix[row].length) {
            return true;
        } else {
            return false;
        }
    }
}
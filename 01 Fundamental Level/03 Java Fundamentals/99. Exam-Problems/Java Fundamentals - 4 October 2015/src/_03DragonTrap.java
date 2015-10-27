import java.util.*;

public class _03DragonTrap {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        char[][] inputMatrix = new char[n][];
        char[][] resultMatrix = new char[n][];

        for (int i = 0; i < n; i++) {
            inputMatrix[i] = scanner.nextLine().toCharArray();
            resultMatrix[i] = inputMatrix[i].clone();
        }


        String command;

        while (!(command = scanner.nextLine()).equals("End")) {

            String[] commandArguments = command.split("[() ]+");

            int centerRow = Integer.parseInt(commandArguments[1]);
            int centerCol = Integer.parseInt(commandArguments[2]);
            int radius = Integer.parseInt(commandArguments[3]);
            int rotations = Integer.parseInt(commandArguments[4]);


            int positionRow;
            int positionCol;

            // дефинираме две отделни колекции да съхраняваме символите от матрицата които ще въртим и координатите им в матрицата
            LinkedList<Character> chars = new LinkedList<>();
            LinkedList<int[]> coordinates = new LinkedList<>();

            // проверяваме дали кръга има сечение със матрицата
            for (int col = centerCol - radius; col <= centerRow + radius; col++) {
                positionRow = centerRow - radius;
                positionCol = col;

                try {
                    chars.add(inputMatrix[positionRow][positionCol]);
                    coordinates.add(new int[]{positionRow, positionCol});
                } catch (ArrayIndexOutOfBoundsException exep) {
                    continue;
                }
            }
            for (int row = centerRow - radius + 1; row <= centerRow + radius; row++) {
                positionRow = row;
                positionCol = centerCol + radius;

                try {
                    chars.add(inputMatrix[positionRow][positionCol]);
                    coordinates.add(new int[]{positionRow, positionCol});
                } catch (ArrayIndexOutOfBoundsException exep) {

                }
            }
            for (int col = centerRow + radius - 1; col >= centerCol - radius; col--) {
                positionRow = centerRow + radius;
                positionCol = col;

                try {
                    chars.add(inputMatrix[positionRow][positionCol]);
                    coordinates.add(new int[]{positionRow, positionCol});
                } catch (ArrayIndexOutOfBoundsException exep) {

                }

            }
            for (int row = centerRow + radius - 1; row > centerRow - radius; row--) {
                positionRow = row;
                positionCol = centerCol - radius;

                try {
                    chars.add(inputMatrix[positionRow][positionCol]);
                    coordinates.add(new int[]{positionRow, positionCol});
                } catch (ArrayIndexOutOfBoundsException exep) {

                }
            }

            // ако има сечение между кръга и матрицата въртим символите от сечението в колекцията и ги присвояваме обратно на матрицата по координатите им
            if (chars.size() > 0) {
                rotations = rotations % chars.size();

                if (rotations < 0) {
                    for (int i = 0; i < Math.abs(rotations); i++) {
                        char temp = chars.get(0);
                        chars.remove(0);
                        chars.add(temp);
                    }
                } else if (rotations > 0) {
                    for (int i = 0; i < rotations; i++) {
                        char temp = chars.get(chars.size() - 1);
                        chars.remove(chars.size() - 1);
                        chars.add(0, temp);
                    }
                }

                for (int i = 0; i < coordinates.size(); i++) {
                    int row = coordinates.get(i)[0];
                    int col = coordinates.get(i)[1];
                    resultMatrix[row][col] = chars.get(i);
                }
            }
        }

        // сравняваме изходната и крайната матрица символ по символ
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
}
import java.util.Scanner;

public class _03_LabyrinthDash {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        char[][] labyrinth = new char[n][];

        for (int i = 0; i < n; i++) {
            labyrinth[i] = scanner.nextLine().toCharArray();
        }

        int positionRow = 0;
        int positionCol = 0;
        int newPositionRow = 0;
        int newPositionCol = 0;
        int lives = 3;
        int totalMoves = 0;

        String moves = scanner.nextLine();
        for (int i = 0; i < moves.length(); i++) {
            switch (moves.charAt(i)) {
                case '^':
                    newPositionRow = positionRow - 1;
                    newPositionCol = positionCol;
                    break;
                case 'v':
                    newPositionRow = positionRow + 1;
                    newPositionCol = positionCol;
                    break;
                case '<':
                    newPositionRow = positionRow;
                    newPositionCol = positionCol - 1;
                    break;
                case '>':
                    newPositionRow = positionRow;
                    newPositionCol = positionCol + 1;
                    break;
            }

            if (newPositionRow < 0 ||
                    newPositionRow >= labyrinth.length ||
                    newPositionCol < 0 ||
                    newPositionCol >= labyrinth[newPositionRow].length) {
                System.out.println("Fell off a cliff! Game Over!");
                totalMoves++;
                break;
            }

            switch (labyrinth[newPositionRow][newPositionCol]) {
                case '_':
                case '|':
                    System.out.println("Bumped a wall.");
                    break;
                case '@':
                case '#':
                case '*':
                    positionRow = newPositionRow;
                    positionCol = newPositionCol;
                    lives--;
                    totalMoves++;
                    System.out.printf("Ouch! That hurt! Lives left: %d", lives);
                    System.out.println();
                    break;
                case '$':
                    labyrinth[newPositionRow][newPositionCol] = '.';
                    positionRow = newPositionRow;
                    positionCol = newPositionCol;
                    lives++;
                    totalMoves++;
                    System.out.printf("Awesome! Lives left: %d", lives);
                    System.out.println();
                    break;
                case ' ':
                    totalMoves++;
                    System.out.println("Fell off a cliff! Game Over!");
                    System.out.printf("Total moves made: %d", totalMoves);
                    return;
                case '.':
                    positionRow = newPositionRow;
                    positionCol = newPositionCol;
                    totalMoves++;
                    System.out.println("Made a move!");
                    break;
            }

            if (lives == 0) {
                System.out.println("No lives left! Game Over!");
                break;
            }
        }

        System.out.printf("Total moves made: %d", totalMoves);
    }
}
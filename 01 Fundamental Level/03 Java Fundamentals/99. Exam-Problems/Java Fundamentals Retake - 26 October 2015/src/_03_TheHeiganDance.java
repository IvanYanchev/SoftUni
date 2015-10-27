import java.util.Scanner;

public class _03_TheHeiganDance {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[][] chamber = new int[15][15];

        int playersRow = 7;
        int playersCol = 7;

        double heigansHealth = 3000000.0;
        int playersHealth = 18_500;

        double damageToHeigan = Double.parseDouble(scanner.nextLine());

        int damageFromCloudNextTurn = 0;

        while (true) {
            heigansHealth -= damageToHeigan;

            playersHealth -= damageFromCloudNextTurn;
            damageFromCloudNextTurn = 0;

            if (playersHealth <= 0) {

                if (heigansHealth <= 0) {
                    print("Defeated!", "Killed by Plague Cloud", playersRow, playersCol);
                } else {
                    print(String.format("%.2f", heigansHealth), "Killed by Plague Cloud", playersRow, playersCol);
                }

                return;
            }

            if (heigansHealth <= 0) {
                print("Defeated!", String.format("%d", playersHealth), playersRow, playersCol);
                return;
            }

            String[] cast = scanner.nextLine().split(" ");
            int damage = 0;
            String spell = cast[0];
            switch (spell) {
                case "Cloud":
                    spell = "Plague Cloud";
                    damage = 7000;
                    break;
                case "Eruption":
                    damage = 6000;
                    break;
            }
            int spellRow = Integer.parseInt(cast[1]);
            int spellCol = Integer.parseInt(cast[2]);

            for (int row = spellRow - 1; row <= spellRow + 1; row++) {
                for (int col = spellCol - 1; col <= spellCol + 1; col++) {
                    try {
                        switch (damage) {
                            case 6000:
                                chamber[row][col] = damage;
                                break;
                            case 7000:
                                chamber[row][col] = damage / 2;
                                break;
                        }
                    } catch (ArrayIndexOutOfBoundsException ex) {

                    }
                }
            }

            if (chamber[playersRow][playersCol] != 0) {
                if (canMoveUp(chamber, playersRow, playersCol)) {
                    playersRow--;
                } else if (canMoveRight(chamber, playersRow, playersCol)) {
                    playersCol++;
                } else if (canMoveDown(chamber, playersRow, playersCol)) {
                    playersRow++;
                } else if (canMoveLeft(chamber, playersRow, playersCol)) {
                    playersCol--;
                } else {

                    playersHealth -= chamber[playersRow][playersCol];
                    if (chamber[playersRow][playersCol] == 3500) {
                        damageFromCloudNextTurn = 3500;
                    }
                }
            }

            for (int row = 0; row < chamber.length; row++) {
                for (int col = 0; col < chamber[row].length; col++) {
                    chamber[row][col] = 0;
                }
            }

            if (playersHealth <= 0) {
                print(String.format("%.2f", heigansHealth), String.format("Killed by %s", spell), playersRow, playersCol);
                return;
            }
        }
    }

    private static void print(String heigansStat, String playersStat, int playersRow, int playersCol) {
        System.out.printf("Heigan: %s\n", heigansStat);
        System.out.printf("Player: %s\n", playersStat);
        System.out.printf("Final position: %d, %d", playersRow, playersCol);
    }

    private static boolean canMoveLeft(int[][] chamber, int row, int col) {
        if (col - 1 >= 0 && chamber[row][col - 1] == 0) {
            return true;
        }
        return false;
    }

    private static boolean canMoveDown(int[][] chamber, int row, int col) {
        if (row + 1 < chamber.length && chamber[row + 1][col] == 0) {
            return true;
        }
        return false;
    }

    private static boolean canMoveRight(int[][] chamber, int row, int col) {
        if (col + 1 < chamber[row].length && chamber[row][col + 1] == 0) {
            return true;
        }
        return false;
    }

    private static boolean canMoveUp(int[][] chamber, int row, int col) {
        if (row - 1 >= 0 && chamber[row - 1][col] == 0) {
            return true;
        }
        return false;
    }
}
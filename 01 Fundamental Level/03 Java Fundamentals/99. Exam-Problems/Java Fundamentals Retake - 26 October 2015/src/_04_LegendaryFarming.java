import java.util.*;

public class _04_LegendaryFarming {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String legendaryItem = "";

        TreeMap<String, Integer> keyMaterials = new TreeMap<>();
        keyMaterials.put("fragments", 0);
        keyMaterials.put("motes", 0);
        keyMaterials.put("shards", 0);
        TreeMap<String, Integer> junk = new TreeMap<>();


        while (legendaryItem.isEmpty()) {

            String input[] = scanner.nextLine().split(" ");

            int quantity = 0;
            String material = "";

            for (int i = 0; i < input.length - 1; i += 2) {
                quantity = Integer.parseInt(input[i]);
                material = input[i + 1].toLowerCase();

                if (material.equalsIgnoreCase("Shards") || material.equalsIgnoreCase("Fragments") || material.equalsIgnoreCase("Motes")) {

                    keyMaterials.put(material, keyMaterials.get(material) + quantity);

                    if (material.equalsIgnoreCase("Shards") && keyMaterials.get(material) >= 250) {
                        legendaryItem = "Shadowmourne";
                        keyMaterials.put(material, keyMaterials.get(material) - 250);
                        break;
                    }

                    if (material.equalsIgnoreCase("Fragments") && keyMaterials.get(material) >= 250) {
                        legendaryItem = "Valanyr";
                        keyMaterials.put(material, keyMaterials.get(material) - 250);
                        break;
                    }

                    if (material.equalsIgnoreCase("Motes") && keyMaterials.get(material) >= 250) {
                        legendaryItem = "Dragonwrath";
                        keyMaterials.put(material, keyMaterials.get(material) - 250);
                        break;
                    }
                } else {
                    if (!junk.containsKey(material)) {
                        junk.put(material, quantity);
                    } else {
                        junk.put(material, junk.get(material) + quantity);
                    }
                }
            }
        }

        System.out.printf("%s obtained!\n", legendaryItem);

        TreeMap<Integer, ArrayList<String>> tm = new TreeMap<>(Collections.reverseOrder());

        for (String material : keyMaterials.keySet()) {

            if (!tm.containsKey(keyMaterials.get(material))) {
                tm.put(keyMaterials.get(material), new ArrayList<>());
                tm.get(keyMaterials.get(material)).add(material);

            } else {
                tm.get(keyMaterials.get(material)).add(material);
            }
        }

        for (Integer quantity : tm.keySet()) {

            Collections.sort(tm.get(quantity));

            for (int i = 0; i < tm.get(quantity).size(); i++) {

                System.out.printf("%s: %d\n", tm.get(quantity).get(i), quantity);
            }
        }

        for (String material : junk.keySet()) {
            System.out.printf("%s: %d\n", material, junk.get(material));
        }
    }
}
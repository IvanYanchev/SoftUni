import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _04_LogParser {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        TreeMap<String, TreeMap<String, ArrayList<String>>> report = new TreeMap<>();

        String stringPattern = "\\{\"Project\":\\s+\\[\"(.+)\"\\],\\s+\"Type\":\\s*\\[\"(.+)\"\\],\\s+\"Message\":\\s*\\[\"(.+)\"\\]\\}";
        Pattern pattern = Pattern.compile(stringPattern);

        while (true) {
            String log = scanner.nextLine();

            if (log.equals("END")) {
                break;
            }

            Matcher matcher = pattern.matcher(log);

            if (matcher.find()) {
                String project = matcher.group(1);
                String type = matcher.group(2);
                String message = matcher.group(3);

                if (!report.containsKey(project)) {
                    report.put(project, new TreeMap<>());
                    report.get(project).put(type, new ArrayList<>());
                    report.get(project).get(type).add(message);
                } else if (!report.get(project).containsKey(type)) {
                    report.get(project).put(type, new ArrayList<>());
                    report.get(project).get(type).add(message);
                } else {
                    report.get(project).get(type).add(message);
                }
            }
        }

        NavigableMap<Integer, ArrayList<String>> printReport = new TreeMap<Integer, ArrayList<String>>().descendingMap();

        for (String project : report.keySet()) {
            StringBuilder projectString = new StringBuilder();
            projectString.append(String.format("%s:\n", project));

            StringBuilder criticalMessages = new StringBuilder();
            criticalMessages.append("Critical Messages:\n");
            ArrayList<String> crMsgs = report.get(project).get("Critical");
            if (crMsgs == null) {
                crMsgs = new ArrayList<>();
            }
            int critical = crMsgs.size();

            StringBuilder warningMessages = new StringBuilder();
            warningMessages.append("Warning Messages:");
            ArrayList<String> wrnMsgs = report.get(project).get("Warning");
            if (wrnMsgs == null) {
                wrnMsgs = new ArrayList<>();
            }
            int warnings = wrnMsgs.size();

            int totalErrors = critical + warnings;

            Comparator<String> messageStrComparator = new Comparator<String>() {
                @Override
                public int compare(String o1, String o2) {
                    if (o1.length() != o2.length()) {
                        return o1.length() - o2.length();
                    }
                    return o1.compareTo(o2);
                }
            };

            if (crMsgs.size() == 0) {
                criticalMessages.append("--->None\n");
            } else {
                crMsgs.stream()
                        .sorted(messageStrComparator)
                        .forEach(x -> criticalMessages.append(String.format("--->%s\n", x)));
            }

            if (wrnMsgs.size() == 0) {
                warningMessages.append("\n--->None");
            } else {
                wrnMsgs.stream()
                        .sorted(messageStrComparator)
                        .forEach(x -> warningMessages.append(String.format("\n--->%s", x)));
            }

            projectString.append(String.format("Total Errors: %d\n", totalErrors));
            projectString.append(String.format("Critical: %d\n", critical));
            projectString.append(String.format("Warnings: %d\n", warnings));

            projectString.append(criticalMessages);
            projectString.append(warningMessages);

            if (!printReport.containsKey(totalErrors)) {
                printReport.put(totalErrors, new ArrayList<>());
                printReport.get(totalErrors).add(projectString.toString());
            } else {
                printReport.get(totalErrors).add(projectString.toString());
            }
        }

        int totalSubReports = 0;
        for (int err : printReport.keySet()) {
            totalSubReports += printReport.get(err).size();
        }

        int count = 0;
        for (int err : printReport.keySet()) {
            Collections.sort(printReport.get((err)));

            for (String project : printReport.get(err)) {
                System.out.println(project);
                if (count < totalSubReports - 1) {
                    System.out.println();
                }
                count++;
            }
        }
    }
}


import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

@SuppressWarnings("unused")
public class Main {
    public static void main(String[] args) {
        // Создание объекта Stream
        Stream stream = new Stream();

        // Добавление учебных групп в поток
        stream.addStudyGroup(new StudyGroup("Group A"));
        stream.addStudyGroup(new StudyGroup("Group B"));
        stream.addStudyGroup(new StudyGroup("Group C"));

        // Вывод количества групп в потоке
        System.out.println("Number of groups in the stream: " + stream.getNumberOfGroups());

        // Создание объекта StreamComparator
        StreamComparator comparator = new StreamComparator();

        // Пример сравнения двух потоков
        Stream stream2 = new Stream();
        stream2.addStudyGroup(new StudyGroup("Group X"));
        stream2.addStudyGroup(new StudyGroup("Group Y"));

        int comparisonResult = comparator.compare(stream, stream2);
        if (comparisonResult < 0) {
            System.out.println("Stream has fewer study groups than Stream2");
        } else if (comparisonResult > 0) {
            System.out.println("Stream has more study groups than Stream2");
        } else {
            System.out.println("Stream has the same number of study groups as Stream2");
        }
    }
}

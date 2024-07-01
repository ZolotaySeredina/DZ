import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

class Stream implements Iterable<StudyGroup> {
    private List<StudyGroup> studyGroups;

    public Stream() {
        this.studyGroups = new ArrayList<>();
    }

    public void addStudyGroup(StudyGroup studyGroup) {
        studyGroups.add(studyGroup);
    }

    public int getNumberOfGroups() {
        return studyGroups.size();
    }

    @Override
    public Iterator<StudyGroup> iterator() {
        return studyGroups.iterator();
    }
}

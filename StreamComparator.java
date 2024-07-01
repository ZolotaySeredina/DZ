class StreamComparator {
    public int compare(Stream stream1, Stream stream2) {
        return Integer.compare(stream1.getNumberOfGroups(), stream2.getNumberOfGroups());
    }
}
namespace Algorithms {
  public static class Search {
    public static int BinarySearch(int[] numbers, int key) {
      int left = 0;
      int right = arr.Length - 1;
      while (left <= right) {
        int mid = (left + right) / 2;
        if (key == numbers[mid]) {
          return ++mid;
        } else if (key < numbers[mid]) {
          right = mid - 1;
        } else {
          left = mid + 1;
        }
      }
      return -1;
    }
  }
}

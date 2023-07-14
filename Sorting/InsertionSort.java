package Sorting;

public class InsertionSort {

	public static void insertionSort(int[] arr) {

		for (int i = 0; i < arr.length; i++) {

			for (int j = 0; j < i; j++) {

				if (arr[i] < arr[j]) {

					int temp = arr[i];
					arr[j] = arr[i];
					arr[i] = temp;
				}
			} // end of j for loop
		} // end of i for loop
	}// end of insertion method

}

package Sorting;

public class BubbleSort {

	public static void bubbleSort(int[] arr) {

		if (arr.length == 0) {

			System.out.println("Empty Array, Boss !");
			return;
		}

		for (int i = 0; i < arr.length; i++) {

			for (int j = 1; j < arr.length - i; j++) {

				if (arr[j - 1] > arr[j]) {

					int temp = arr[j - 1];
					arr[j - 1] = arr[j];
					arr[j] = temp;
				}
			} // end of j for loop
		} // end of i for loop
	}//end of bubbleSort

}

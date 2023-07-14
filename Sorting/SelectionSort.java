package Sorting;

public class SelectionSort {

	public static void selectionSort(int[] arr) {

		if (arr.length == 0) {
			System.out.println("Empty Array, Boss !");
			return;
		}

		for (int i = 0; i < arr.length - 1; i++) {

			for(int j = i+1; j < arr.length; j++) {
				
				if(arr[i] > arr[j]) {
					
					int temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
				}			
			}//end of j for loop
		}//end of i for loop
	}//end of selectionSort

}

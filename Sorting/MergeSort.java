package Sorting;

public class MergeSort {
	
//	public static void mergeSort
//	(int [] arr, int left, int right) {
//		
//		if(left >= right) {
//			return;
//		}
//		
//		int mid = (left + right)/2;
//		
//		mergeSort(arr,left,mid);
//		mergeSort(arr,mid+1,right);
//		merge(arr,left,mid,mid+1,right);		
//	
//	}//end of mergeSort()

	
//	public static void merge(int [] arr,
//			int leftStart, int leftEnd,
//			int rightStart, int rightEnd) {
//		
//		int noOfElements = rightEnd - leftStart + 1;
//		int [] tempArr = new int [noOfElements];
//		int tempPos = -1;
//		
//		while((leftStart <= leftEnd) && (rightStart <= rightEnd)) {
//			
//			if(arr[leftStart] < arr[rightStart]) {
//				
//				tempArr[++tempPos] = arr[leftStart];
//				leftStart++;				
//			}
//			else {
//				
//				tempArr[++tempPos] = arr[rightStart];
//				rightStart++;				
//			}			
//		}//end of 1st while
//		
//		while(leftStart <= leftEnd) {
//			
//			tempArr[++tempPos] = arr[leftStart];
//			leftStart++;	
//			
//		}//end of 2nd while
//		
//		while(rightStart <= rightEnd) {
//			
//			tempArr[++tempPos] = arr[rightStart];
//			rightStart++;			
//			
//		}//end of 3rd while
//		
//		for(int i=1; i<=noOfElements; i++) {
//			
//			arr[rightEnd] = tempArr[tempPos];
//			tempPos--;
//			rightEnd--;
//			
//		}//end of for loop
//		
//	}//end of merge()

	public static void mergeSort(int [] arr, int left, int right) {
		
		if(left >= right) {
			return;
		}
		
		int mid = (left + right)/2;
		
		mergeSort(arr,left,mid);
		mergeSort(arr,mid+1,right);
		merge(arr,left,mid,mid+1,right);	
		
	}//end of mergeSort()
	
	public static void merge(int [] arr, int leftStart, int leftEnd,
			int rightStart, int rightEnd) {
		
		int noOfElements = rightEnd - leftStart + 1;
		int [] tempArr = new int [noOfElements];
		int tempPos = -1;
		
		while((leftStart <= leftEnd) && (rightStart <= rightEnd)) {
			if(arr[leftStart] < arr[rightStart]) {
				
				tempArr[++tempPos] = arr[leftStart];
				leftStart++;				
			}
			else {
				
				tempArr[++tempPos] = arr[rightStart];
				rightStart++;				
			}		
		}//end of 1st while
		
		while(leftStart <= leftEnd) {
			
			tempArr[++tempPos] = arr[leftStart];
			leftStart++;	
			
		}//end of 2nd while
		
		while(rightStart <= rightEnd) {
			
			tempArr[++tempPos] = arr[rightStart];
			rightStart++;
			
		}//end of 3rd while
		
		for(int i=1; i<=noOfElements; i++) {
			
			arr[rightEnd] = tempArr[tempPos];
			tempPos--;
			rightEnd--;
			
		}//end of for
		
	}//end of merge()


}

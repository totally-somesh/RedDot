package Sorting;

import Sorting.SelectionSort;
import Sorting.BubbleSort;
import Sorting.InsertionSort;
import Sorting.HeapSort;
import Sorting.MergeSort;

public class Tester {

	public static void main(String[] args) {

		int[] arr = { 4, 6, 9, 8, 1, 3, 2, 5, 7, 10 };

		System.out.println(" ---< Original Array >--- ");
		for (int i = 0; i < arr.length; i++) {

			System.out.print(arr[i] + " | ");
		}
		System.out.println(" ");

		System.out.println(" ");
		System.out.println(" ---< Sorted Array (By Using Selection Sort) >--- ");

		SelectionSort.selectionSort(arr);

		for (int i = 0; i < arr.length; i++) {

			System.out.print(arr[i] + " | ");
		}
		System.out.println(" ");

		System.out.println(" ");
		System.out.println(" ---< Sorted Array (By Using Bubble Sort) >--- ");

		BubbleSort.bubbleSort(arr);

		for (int i = 0; i < arr.length; i++) {

			System.out.print(arr[i] + " | ");
		}

		System.out.println(" ");
		System.out.println(" ");
		System.out.println(" ---< Sorted Array (By Using Insertion Sort) >--- ");

		InsertionSort.insertionSort(arr);

		for (int i = 0; i < arr.length; i++) {

			System.out.print(arr[i] + " | ");
		}
		System.out.println(" ");
		System.out.println(" ");

		System.out.println(" ---< Sorted Array (By Using Heap Sort) >--- ");

		HeapSort.heapSort(arr, arr.length);

		for (int i = 0; i < arr.length; i++) {

			System.out.print(arr[i] + " | ");
		}
		System.out.println(" ");
		System.out.println(" ");

		System.out.println(" ---< Sorted Array (By Using Merge Sort) >--- ");

		MergeSort.mergeSort(arr, 0, arr.length-1);

		for (int i = 0; i < arr.length; i++) {

			System.out.print(arr[i] + " | ");
		}
		System.out.println(" ");

	}

}

using System;

namespace LargestElementinArray
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int get_largest(int array[], int size)
{
				int i, last_big = 0;

				/* Get biggest number */
				for (i = 0; i < size; i++)
					if (array[i] > last_big) last_big = array[i];

				return last_big;
			}

			int main ()
{
				/* Used variables */
				int array[5] = { 1, 6, 31, 8, 5 };
				int elements = sizeof(array) / sizeof(int);

				/* Get and print */
				int largest = get_largest(array, elements);
				printf("Largest element in the array: %d\n", largest);

				int smallest = get_smallest(array, elements);
				printf("Smallest element in the array: %d\n", smallest);

				/* Thats all folks */
				return 0;
			}
		}
	}
}

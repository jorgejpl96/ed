package iesserpis.ed;

public class programa1 {

	public static void main(String[] args) {
		int max = max(new int[] { 4, 14, 24, 8, 7 });
		System.out.println("mayor = " + max);
		int[] vector = SelectionSort(new int[] { 4, 14, 24, 8, 7 });
		for (int i = 0; i < vector.length; i++) {
			System.out.print(vector[i] + ",");
		}

	}

	public static int max(int[] v) {
		int max = v[0];
		for (int i = 0; i < v.length; i++) {
			if (v[i] > max)
				max = v[i];
		}
		return max;
	}

	public static int[] SelectionSort(int[] v) {
		if(v.length == 0) {
			throw new IllegalArgumentException();
		}
		int num;
		for (int i = 0; i < v.length; i++) {
			if (i != v.length - 1) {
				for (int j = i; j < v.length; j++) {
					if (v[j] < v[i]) {
						num = v[i];
						v[i] = v[j];
						v[j] = num;
					}
				}

			}
		}

		return v;
	}

	public static int max1(int[] v) {
		if(v.length == 0) {
			throw new IllegalArgumentException();
		}
		int max1= v[0];
		for (int i = 1; i < v.length; i++) {
			if (v[i] > max1) {
				max1 = v[i];
			}
		}
		return max1;

	}
	public static int[] OrdenParra(int[] v) {
		int num;
		for (int i = 0; i < v.length - 1; i++) {
			if (v[i] > v[i + 1]) {

				num = v[i];
				v[i] = v[i + 1];
				v[i + 1] = num;
			}
		}
		if (v[v.length - 2] > v[v.length - 1]) {
			num = v[v.length - 2];
			v[v.length - 2] = v[v.length - 1];
			v[v.length - 1] = num;
		}

		return v;
	}
}
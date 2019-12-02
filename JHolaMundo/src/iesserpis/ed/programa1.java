package iesserpis.ed;

public class programa1 {

	public static void main(String[] args) {
		int max = max(new int[] { 4, 14, 24, 8, 7 });
		System.out.println("mayor = " + max);

	}

	public static int max(int[] v)
	{
		int max = v[0];
		for(int i = 0; i< v.length; i++)
		{
			if(v[i]>max)
				max = v[i];
		}
		return max;
	}

}

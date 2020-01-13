package iesserpis.ed;
import java.util.*;
public class JVector {

	public static void main(String[] args) {
		
		Scanner teclado = new Scanner(System.in);
		Random random = new Random();
		int tam;
		int x;
		System.out.println("Tamaño total del vector: ");
		tam = teclado.nextInt();
		int[] v = new int[tam];

		for(int i = 0; i < tam; i++)
			v[i] = random.nextInt(10)+1;
		
		System.out.println("Elemento a buscar: ");
		x = teclado.nextInt();
		
		int index = indexOf(v,x);
		System.out.println("Numero de veces repetido= " + index);
		System.out.println("fin");
		
	}



	public static int indexOf(int[] v, int x)
	{
		int posicion = -1,
			contador = 0;
		for(int i = 0; i < v.length; i++)
		{
			if (x == v[i])
			{
				contador++;
				System.out.println("Posiciones en las que esta el numero: " + i);
				
			}
		}
		
		
		return contador;
	}
}
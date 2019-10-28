package iesserpis.ed;
import java.util.*;
public class JAdivina {

	public static void main(String[] args) {
		
		Scanner teclado = new Scanner(System.in);
		Random random = new Random();
		int num_al = random.nextInt(1000)+1;
		int num_int,
			contador = 0,
			ex_iz = 1,
			ex_der = 1000;
		do 
		{
			contador++;
			System.out.printf("Adivina el numero de [intento %s] (entre %s y %s): ", contador, ex_iz, ex_der);
			num_int = teclado.nextInt();
			if(num_int < num_al)
			{
				ex_iz = num_int + 1;
			}else if (num_int > num_al)
			{
				ex_der = num_int - 1;
			}
		}while(num_int != num_al);
		
		System.out.println("Enhorabuena!!");
		

	}
}

package iesserpis.ed;
import java.util.Scanner;
public class HolaMundo {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String letras;
		System.out.print("Introduzca su nombre: ");
		letras = scanner.nextLine();
		System.out.print("Hola " + letras);
	}

}

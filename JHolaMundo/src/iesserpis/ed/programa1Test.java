package iesserpis.ed;

import static org.junit.jupiter.api.Assertions.*;

import java.util.*;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

class programa1Test {

	@Test
	void test() {
		assertEquals(24, programa1.max(new int[] {4,14,24,8,7}));
		assertEquals(24, programa1.max(new int[] {24,14,4,8,7}));
		assertEquals(24, programa1.max(new int[] {4,24,14,8,7}));
		assertEquals(24, programa1.max(new int[] {4,14,7,8,24}));
		assertEquals(24, programa1.max(new int[] {4,14,8,24,7}));
		assertEquals(24, programa1.max(new int[] {4,24,8,24,7}));
		
		//caso de vector vacío
		Assertions.assertThrows(IllegalArgumentException.class, 
				() ->programa1.max1(new int[] {})
				
			);


	}

	@Test
	void test2() {
		int[] v1 = { 14, 21, 12, 7, 9 };
		programa1.SelectionSort(v1);
		assertArrayEquals(new int[] { 7, 9, 12, 14, 21 }, v1);
		
		Assertions.assertThrows(IllegalArgumentException.class, 
				() ->programa1.SelectionSort(new int[] {})
				
			);
	}
/*
	@Test
	void test3() {
		int[] v1 = { 14, 21, 12, 7, 9 };
		programa1.OrdenParra(v1);
		assertArrayEquals(new int[] { 7, 9, 12, 14, 21 }, v1);
	}
*/
}

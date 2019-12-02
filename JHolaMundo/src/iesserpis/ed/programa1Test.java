package iesserpis.ed;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

class programa1Test {

	@Test
	void test() {
		assertEquals(24, programa1.max(new int[] {4,14,24,8,7}));
	}

}

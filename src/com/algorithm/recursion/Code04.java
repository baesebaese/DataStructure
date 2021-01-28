package com.algorithm.recursion;

public class Code04 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int strLength = 0;
		strLength = length("abc");
		System.out.println(strLength);
		
		printChars("abcde");
		System.out.println();
		
		printCharsReverse("abcdef");
		System.out.println();
		
		printInBinary(23);
		System.out.println();
	}
	
	public static int length(String str) {
		
		if (str.equals("")) {
			return 0;
		} else {
			int result = 1 + length(str.substring(1));
			return result;		
		}			
	}
	
	public static void printChars(String str) {
		if(str.length() == 0) {
			return;
		} else {
			System.out.print(str.charAt(0)); //charAt 이문자열의 첫글자를 리턴해주는 메소드
			printChars(str.substring(1));			
		}	
	}
	
	//문자열을 뒤집어 프린트
	public static void printCharsReverse(String str) {
		if(str.length() == 0) {
			return;
		}else {
			printCharsReverse(str.substring(1));
			System.out.print(str.charAt(0));
						
		}		
	}
	
	//2진수로 변환하여 출력
	public static void printInBinary(int n) {
		if (n<2)
			System.out.print(n);
		else {
			printInBinary(n/2);
			System.out.print(n%2);
			
		}
		
	}
	
	//배열의 합 구하기
	public static int sum(int n, int [] data) {
		if(n<=0)
			return 0;
		else
			return sum(n-1, data) + data[n-1];
	}
	


}

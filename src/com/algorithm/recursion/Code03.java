package com.algorithm.recursion;

public class Code03 {
	public static void main(String[] args) {
		int result = func(4);
		System.out.println(result );
	}
	// 0~n까지 합 구하기
	public static int func(int n) {
		if(n==0)
			return 0;
		else {
			return n + func(n-1); // 4 + 3 + 2 + 1
		}
	}
	
	//Factorial n!
	public static int factorial(int n) {
		if(n==0)
			return 1;
		else
			return n*factorial(n-1);
		
	}
	
	// x^n
	public static double power(double x, int n) {
		if(n==0)
			return 1;
		else 
			return x*power(x, n-1);
	}
	
	//Fibonacci Number
	public int fibonacci(int n) {
		if(n<2)
			return n;
		else
			return fibonacci(n-1) + fibonacci(n-2);
	}
	
	//최대공약수 : Euclid Method
	public static double gcd(int m, int n) {
		if(m<n) {
			int tmp=m; m=n; n=tmp;
		}
		if(m%n==0)
			return n;
		else
			return gcd(n, m%n);
	}
	// m>=n 인 두 양의 정수 m과 n에 대해서 m이 n의 배수이면 gcd(m,n)=n 이고 그렇지 않으면 gcd(m,n) = gcd(n, m%n)이다.

	
}

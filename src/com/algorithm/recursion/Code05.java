package com.algorithm.recursion;

public class Code05 {
	// 매개변수의 명시화
	public static void main(String[] args) {
		
	}
	
	
	
	//최대값 찾기	
	public static int findMax(int [] data, int begin, int end) {
		if(begin==end)
			return data[begin];
		else
			return Math.max(data[begin], findMax(data, begin+1, end));
	}
	
	//최대값 찾기 : 다른버전
	public static int findMax2(int [] data, int begin, int end) {
		if(begin==end)
			return data[begin];
		else {
			int middle = (begin+end)/2;
			int max1 = findMax2(data, begin, middle);
			int max2 = findMax2(data, middle +1 , end);
			return Math.max(max1, max2);
		}	
	}
	
	// Binary Search
	// 이진 검색을 recursion을 사용하기 위해서는
	// 데이터가 크기순으로 정렬되어 있을 때 적용할 수 있다.
	public static int binarySearch(String[] items, String target, int begin, int end) {
		if(begin>end)
			return -1;
		else {
			int middle = (begin+end)/2;
			int compResult = target.compareTo(items[middle]);
			if(compResult == 0)
				return middle;
			else if(compResult<0)
				return binarySearch(items, target, begin, middle-1);
			else
				return binarySearch(items, target, middle+1, end);
			
		}	
	}
}

# A Very Big Sum 

Calculate and print the sum of the elements in an array. keeping in mind that some ofthose integers may be quite large. 

### Function Description 
Complete the aVeryBigSum function in the editor below. It must return the sum of all array elements. 

aVeryBigSum has the follovving parameter(s): 
- ar: an array afintegers . 

### Input Format

The first line of the input consists of an integer n. 

The next line contains n space•separated integers contained in the array

### Output Format

Print the integer sum ofthe elements in the array_ 

### Constraints

- 1 <= n <= 10
- 0 <= ar[i] <= 10^10


### Sample Input
```
5
1000000001 1000000002 1000000003 1000000004 1000000005
```
### Output
```
5000000015
```
### Note:

The range of the 32-bit integer is (-2^31) to (2^31 — 1) or [—2147483648, 2147483647] 
When we add severa' integer values, the resulting sum might exceed the above range. Vou might need to use long long int in C/C*+ or long data type in Java to store 
such sums
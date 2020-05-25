# Diagonal Difference 

Given a square matrix, calculate the absolute difference between the sums of its diagonais. 

For example, the square matrix arr is shown below: 
```
1 2 3 
4 5 6 
9 8 9 
```

The left-to-right diagonal = 1 + 5 + 9 = 15, The right-to-left diagonal = 3 + 5 + 9 = 17. Their absolute difference is |115 - 171| = 2

### Function description 
Complete the diagonalDifference function in the editor below. It must return an integer representing Che absolute diagonal difference.

diagonalDifference takes the following parameter: 

- arr: an array of integers 

### Input Format 
The first line contains a single integer, n, the number ot rows and columns in the matrix arr.

Each Of the next n lines destribes a row, arr[i], and consists of n space-separated integers arr[i][j]

### Constraints 
- -100 <= arr[i][j] <= 100 

### Output Format 
Print the absolute difference between the sums of the matrix's two diagonals as a single integer. 

### Sample Input 
```
3
11   2     4 
 4   5     6 
10   8   -12 
```
### Sample Output
```
15
``` 

### Explanation 
The primary diagonal is:
``` 
11
   5
     -12
```

Sum across the primany diagonal: 11 + 5 - 12 = 4

The secondary diagonal is: 
``` 
     4
   5
10
``` 
Difference: |4 - 19| = 15

### Note: 
|x| is the absolute value of x
# String manipulation assignments
## AS Computer Science 

Here is a list of problems solved:
1. Find if the input string has all the alphabets (case neutral).
2. Replace selected character with another in entered string.
3. Count and output the NUMBER of an entered character in a string. Also output separate counts for alphabets (cap & small together; case neutral), digits and other characters in same entered string. 
4. Find the character that appears most number of times in an entered string and output it.
5. Find the count of vowels characters in an entered string separately.
6. donuts: INPUT an INT count of a number of donuts, OUTPUT a string of the form 'Number of donuts: <count>', where <count> is the number input. However, if the count is 10 or more, then use the word 'many' instead of the actual count. So donuts(5) outputs 'Number of donuts: 5' and donuts(23) outputs 'Number of donuts: many'.
7. both_ends:
Input a string s, output a string made of the first 2
and the last 2 chars of the original string,
so 'spring' yields 'spng'. However, if the string length
is less than 2, return string s instead the empty string.
8. fix_start:
Given a string s, return a string
where all occurences of its first char have
been changed to '*', except do not change
the first char itself.
e.g., 'babble' yields 'ba*le' or 'alpha' outputs 'alph'
Assume that the string is length 1 or more
9. MixUp:
Given strings a and b, return a single string with a and b separated
by a space, except swap the first 2 chars of each string.
e.g.
  'mix', pod' -> 'pox mid'
  'dog', 'dinner' -> 'dig donner'
  Assume a and b are length 2 or more.
10. verbing:
Given a string, if its length is at least 3,
add 'ing' to its end.
Unless it already ends in 'ing', in which case
add 'ly' instead.
If the string length is less than 3, leave it unchanged.
Return the resulting string.
examples:
input 'end' --> 'ending'
input 'ending' --> 'endingly'
input 'go' --> 'go'
11. not_bad:
Given a string, find the first appearance of the
substring 'not' and 'bad'. If the 'bad' follows
the 'not', replace the whole 'not'...'bad' substring
with 'good'.
Return the resulting string.
Input: 'This dinner is not that bad!' 
Outputs: This dinner is good!


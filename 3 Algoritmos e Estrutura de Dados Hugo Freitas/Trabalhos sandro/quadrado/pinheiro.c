




/*
Escreva um programa que desenhe no ecr˜a (usando o caracter #) um quadrado de dimens˜ao 5. Deﬁna para isso uma fun¸c˜ao que desennha um quadrado de dimens˜ao n. Use a fun¸c˜ao putchar. O resultado da invoca¸c˜ao dessa fun¸c˜ao com um argumento 5 dever´a ser o que se apresenta abaixo.
*/
#include <stdio.h>




void pinheiro(int);
int main ()
{
    int i, j, n=6;

   for (  i = 0; i < n; i++){
        for (j=0; j < (n*2)-1; j++){
        if (j<n-1-i) putchar(' ');  
        
}
for(int k=0;k<(2*i)+1;k++)
        putchar('#');
        putchar('\n');
}

}  
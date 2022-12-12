




/*
Escreva um programa que desenhe no ecr˜a (usando o caracter #) um quadrado de dimens˜ao 5. Deﬁna para isso uma fun¸c˜ao que desennha um quadrado de dimens˜ao n. Use a fun¸c˜ao putchar. O resultado da invoca¸c˜ao dessa fun¸c˜ao com um argumento 5 dever´a ser o que se apresenta abaixo.
*/
#include <stdio.h>




void quadrado(int);
int main ()
{
    int i, j, n=5;
/*   putchar(' ');
    putchar('#');
    putchar('\n');*/ 
   for (  i = 0; i < n; i++){
        for (j=0; j < i+1; j++){
        putchar('#');     
}
        putchar('\n');
}

  for (  i = 0; i < n; i++){

        for (j=1; j < n-i; j++){
        putchar('#');     
}
        putchar('\n');
}


}

#include <stdio.h>




void meio_Pinheiro(int);
int main ()
{
    int i, j, n;
    printf("introduza um numero inteiro");
    scanf("%d", &n);
        

   for (  i = 1; i <= n; i++)/* O primeiro for para imprimir a quebra de linha*/
   {    
        for (j =n-i; j >=1; j--)/* O tresceiro for para imprimir " " por linha*/
        {
            printf(" ");
        }
        
        for (j= 1; j <= i; j++)/* O segundo for para imprimir "i" asteriscos por linha*/
        {
            printf("*");
        }
    printf("\n");
     

   }    

return 0;
}  
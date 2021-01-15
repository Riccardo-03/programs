/* 
    auth: Chiavegato Riccardo
    file name: division of a string that have more words
    exe: do a program that divide a string if have more words
*/

#include <stdio.h>

void division(char* s);

int main(int argc, char** argv){

    char str[50] = {'\0'};

    printf("\nType a string with more words: ");
    gets(str);
    fflush(stdin);

    division(str);

    return 0;
}

void division(char* s){
    int space = 0;

    for(int i = 0; *(s+i) != '\0'; i++){
        if(*(s+i) == ' '){
            space++;
        }
    }

    if(space == 0){
        printf("\nThere was only a word!!");
    }else{
        char division_words[space+1][50];
        int trovato = 0;
        int i = 0;

        for(int i = 0; i < (space+1); i++){
            for(int j = 0; j < 50; j++){
                division_words[i][j] = '\0';
            }
        } 

        int k = 0;

        for(int j = 0; j < 50; j++){
            if(s[j] != ' '){
                division_words[i][k] = s[j];
                k++;
            }else{
                i++;
                k = 0;
            }
        }

        for(int i = 0; i < (space+1); i++){
            for(int j = 0; j < 20; j++){
                printf("%c", division_words[i][j]);
            }
            printf("\n");
        }
    }
}
/*  
    auth: Chiavegato Riccardo
    file name: polindrome
    exe: create a program that it give you if a word of you have insert (argv) is palindrome or not
*/

#include <stdio.h>

int palindrome(char* s, int l);
int lenght(char* f);

int main(int argc, char** argv){

    int size = lenght(argv[1]);

    if(palindrome(argv[1], size) == 1){
        printf("\nThe word \"%s\" is polindrome", argv[1]);
    }else{
        printf("\nThe word \"%s\" is not polindrome", argv[1]);
    } 

    return 0;
}

int palindrome(char* s, int l){
    if(*s != '\0'){
        if(*s == *(s+l-1)){
            return palindrome(s+1, l-2);
        }else{
            return 0;
        }
    }
    
    return 1;
}

int lenght(char* f){
    if(*f != '\0'){
        return 1 + lenght(f+1);
    }
}
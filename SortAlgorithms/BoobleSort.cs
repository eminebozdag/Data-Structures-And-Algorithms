BoobleSort(int ar[], int N){
    int temporary, k, move;
    for(move=0; move<N-1; move++)
    {
        for(k=0; k<N-1-move; k++)
        {
            if(ar[k]>ar[k+1]){
                temporary = ar[k];
                ar[k] = ar[k+1];
                ar[k+1] = temporary;
            }
        }
    }
}
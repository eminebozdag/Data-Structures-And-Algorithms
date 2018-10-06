SelectionSort(int ar[], int N)
{
    int i, j, index, lowest;
    for(i=0; i<N-1; i++){
        lowest = ar[N-1];
        index = N-1;
        for(j=1; j<N-1; j++)
        {
            if(ar[j] < lowest)
            {
                lowest = ar[j];
                index j;
            }
            ar[index] = ar[i];
            ar[i] = lowest;
        }        
    }
}
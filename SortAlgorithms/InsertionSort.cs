
InsertionSort(int ar[],int N)
{
    int i,k,add;
    for(i=1; i<N; i++)
    {
        add=ar[i];
        for(k=i-1; k>=0; && add<=ar[k]; k--)
            ar[k+1]=ar[k];
        ar[k+1]=add;
    }
}
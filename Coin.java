public  class Coin {
    public static void coinChangeGreedy(int n) {
        int coins[] = {100,50,20, 10, 5, 2, 1};
        int i=0;

        while(n>0) {
            if(coins[i] > n) {
                i++;
            }
            else {
                System.out.print(coins[i]+"\t");
                n = n-coins[i];
            }
        }
        System.out.println("");
    }

    public static void main(String[] args) {
        for(int i=1; i<=56; i++) {
            coinChangeGreedy(i);
        }
    }
}
using System;
 
public class GFG{
    static long gcd(long a, long b)
{
if(a%b != 0)
    return gcd(b,a%b);
else
    return b;
}
 
static long lcm(long n)
{
    long ans = 1;    
    for (long i = 1; i <= n; i++)
        ans = (ans * i)/(gcd(ans, i));
    return ans;
}
 
    static public void Main (){
        long n = 20;
        Console.WriteLine(lcm(n));
    }
}
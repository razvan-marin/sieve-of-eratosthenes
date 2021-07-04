static IEnumerable<int> Primes()
{
    static IEnumerable<int> Sieve(int prime)
    {
        yield return prime;

        foreach (var nextPrime in Sieve(prime + 1).Where(number => number % prime != 0))
        {
            yield return nextPrime;
        }
    }

    return Sieve(2);
}

static void Main()
{
    // display the first 100 prime numbers
    foreach (var prime in Primes().Take(100))
    {
        Console.WriteLine(prime);
    }

    // display all primes numbers between 100 and 1000
    foreach (var prime in Primes().SkipWhile(prime => prime > 100).TakeWhile(prime => prime < 1000))
    {
        Console.WriteLine(prime);
    }
}

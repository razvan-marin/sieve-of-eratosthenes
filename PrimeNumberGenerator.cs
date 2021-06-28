// generates prime numbers
static IEnumerable<int> Primes()
{
    static IEnumerable<int> Sieve(int number)
    {
        // this is a prime
        yield return number;

        // keep sieving and skip multiples of this number
        foreach (var other in Sieve(number + 1).Where(other => other % number != 0))
        {
            yield return other;
        }
    }

    // start sieving from 2
    return Sieve(2);
}

static void Main()
{
    // display the first 100 prime numbers
    foreach (var prime in Primes().Take(100))
    {
        Console.WriteLine(prime);
    }
}

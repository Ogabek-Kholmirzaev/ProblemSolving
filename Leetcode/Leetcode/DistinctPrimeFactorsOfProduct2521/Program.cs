int DistinctPrimeFactors(int[] nums)
{ 
    var primes = new HashSet<int>();
    for (var i = 0; i < nums.Length; i++)
    {
	    var num = nums[i];
	    var k = 2;

	    while (num != 1)
	    {
		    if (num % k == 0)
		    {
			    primes.Add(k);
			    while (num % k == 0)
			    {
				    num /= k;
			    }
		    }

		    k++;
	    }
    }

    return primes.Count;
}

Console.WriteLine(DistinctPrimeFactors(new []{2,4,3,7,10,6}));
Console.WriteLine(DistinctPrimeFactors(new []{2,4,8,16}));
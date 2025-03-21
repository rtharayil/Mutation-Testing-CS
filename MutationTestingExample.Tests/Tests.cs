namespace MutationTestingExample.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }

    [Fact]  
	public void testComputeWithOddSeed()    
	{
		SomeComplexComputation Computation = new SomeComplexComputation(new Algorithm());

		Assert.Equal(1, Computation.compute(1));
        

	}


	[Fact]
	public void testComputeWithEvenSeed() {

		SomeComplexComputation Computation = new SomeComplexComputation(new Algorithm());

		Assert.Equal(1, Computation.compute(2));

	}


}
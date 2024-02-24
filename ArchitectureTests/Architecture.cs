using NetArchTest.Rules;
//using FastTrackerDomain;


namespace ArchitectureTests;

public class Architecture
{
    [Fact]
    public void Domain_Should_NotDependOnApplicationOrInfrastructure()
    {
        TestResult result = Types.InCurrentDomain()
            .That()
            .ResideInNamespace("FastTrackerDomain")
            .ShouldNot()
            .HaveDependencyOnAny("FastTrackerApplication", "FastTrackerInfrastructure")
            .GetResult();

        Assert.True(result.IsSuccessful);
    }

    [Fact]
    public void Application_Should_NotDependOnApplicationOrInfrastructure()
    {
        TestResult result = Types.InCurrentDomain()
            .That()
            .ResideInNamespace("FastTrackerApplication")
            .ShouldNot()
            .HaveDependencyOn("FastTrackerInfrastructure")
            .GetResult();

        Assert.True(result.IsSuccessful);
    }
}
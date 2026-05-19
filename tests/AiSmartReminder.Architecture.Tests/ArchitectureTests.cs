using FluentAssertions;
using NetArchTest.Rules;
using System.Reflection;

namespace AiSmartReminder.Architecture.Tests;

public class ArchitectureTests
{
    private static readonly Assembly DomainAssembly = typeof(Domain.AssemblyReference).Assembly;
    private static readonly Assembly ApplicationAssembly = typeof(Application.DependencyInjection).Assembly;
    private static readonly Assembly InfrastructureAssembly = typeof(Infrastructure.DependencyInjection).Assembly;
    private static readonly Assembly ApiAssembly = typeof(Program).Assembly;

    [Fact]
    public void Domain_ShouldNotDependOn_Application()
    {
        var result = Types.InAssembly(DomainAssembly)
            .ShouldNot()
            .HaveDependencyOn("AiSmartReminder.Application")
            .GetResult();

        result.IsSuccessful.Should().BeTrue(
            because: "Domain layer must not depend on Application layer. " +
                     "Violating types: {0}",
            GetFailingTypeNames(result));
    }

    [Fact]
    public void Domain_ShouldNotDependOn_Infrastructure()
    {
        var result = Types.InAssembly(DomainAssembly)
            .ShouldNot()
            .HaveDependencyOn("AiSmartReminder.Infrastructure")
            .GetResult();

        result.IsSuccessful.Should().BeTrue(
            because: "Domain layer must not depend on Infrastructure layer. " +
                     "Violating types: {0}",
            GetFailingTypeNames(result));
    }

    [Fact]
    public void Domain_ShouldNotDependOn_Api()
    {
        var result = Types.InAssembly(DomainAssembly)
            .ShouldNot()
            .HaveDependencyOn("AiSmartReminder.Api")
            .GetResult();

        result.IsSuccessful.Should().BeTrue(
            because: "Domain layer must not depend on Presentation/API layer. " +
                     "Violating types: {0}",
            GetFailingTypeNames(result));
    }

    [Fact]
    public void Application_ShouldNotDependOn_Infrastructure()
    {
        var result = Types.InAssembly(ApplicationAssembly)
            .ShouldNot()
            .HaveDependencyOn("AiSmartReminder.Infrastructure")
            .GetResult();

        result.IsSuccessful.Should().BeTrue(
            because: "Application layer must not depend on Infrastructure layer. " +
                     "Violating types: {0}",
            GetFailingTypeNames(result));
    }

    [Fact]
    public void Application_ShouldNotDependOn_Api()
    {
        var result = Types.InAssembly(ApplicationAssembly)
            .ShouldNot()
            .HaveDependencyOn("AiSmartReminder.Api")
            .GetResult();

        result.IsSuccessful.Should().BeTrue(
            because: "Application layer must not depend on Presentation/API layer. " +
                     "Violating types: {0}",
            GetFailingTypeNames(result));
    }

    [Fact]
    public void Infrastructure_ShouldNotDependOn_Api()
    {
        var result = Types.InAssembly(InfrastructureAssembly)
            .ShouldNot()
            .HaveDependencyOn("AiSmartReminder.Api")
            .GetResult();

        result.IsSuccessful.Should().BeTrue(
            because: "Infrastructure layer must not depend on Presentation/API layer. " +
                     "Violating types: {0}",
            GetFailingTypeNames(result));
    }

    private static string GetFailingTypeNames(TestResult result)
    {
        if (result.FailingTypes is null || !result.FailingTypes.Any())
            return "none";

        return string.Join(", ", result.FailingTypes.Select(t => t.FullName));
    }
}

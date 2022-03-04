using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Net.Http;

namespace MinimalAPIDemo.Tests;

[TestClass]
public class ApiTests
{
    private HttpClient _httpClient { get; }

    public ApiTests()
    {
        var webAppFactory = new WebApplicationFactory<Program>();
        _httpClient = webAppFactory.CreateClient();
    }

    [TestMethod]
    public async Task DefaultRoute_ReturnHello()
    {
        var response = await _httpClient.GetAsync("");
        var result = await response.Content.ReadAsStringAsync();

        Assert.AreEqual("hello", result);
    }

    [TestMethod]
    public async Task Sum_Return3For1And2()
    {
        var response = await _httpClient.GetAsync("/sum?a=1&b=2");
        var result = await response.Content.ReadAsStringAsync();

        Assert.AreEqual(3, int.Parse(result));
    }
}

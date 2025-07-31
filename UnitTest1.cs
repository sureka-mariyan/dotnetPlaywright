namespace playwrightTestSurabhi;

using System.Threading.Tasks;
using Microsoft.Playwright;

public class Tests
{
    // [SetUp]
    // public void Setup()
    // {
    // }

    [Test]
    public async Task Test1()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false }); //lauch browser
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.google.co.in");
        await page.PauseAsync();
        var page1 = await browser.NewPageAsync();
        await page1.GotoAsync("https://yahoo.com");
        await page1.PauseAsync();
    }
}

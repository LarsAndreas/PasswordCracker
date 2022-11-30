// See https://aka.ms/new-console-template for more information

using NBomber.Contracts;
using NBomber.CSharp;

using var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://localhost:7210"),
    Timeout = TimeSpan.FromMilliseconds(1750),
};

var stepFirst = Step.Create("first", async context =>
{
    try
    {
        var response = await httpClient.GetAsync("/?password=a0bc1abd89d921faf91151f437e99f2ca7d40889df029c7cf1aefd3ccdf362849f3af3e706bec65e91f8e98ee04e6a56b3fe06e03359cc311dd6c481a91b14309a1e40e467dc44c13253b485b0afaf985ba12afd25fba5c1f5a316e8822b2742d13d910ddb94a9dd85e842845c9b6452d3a1aa672a8a9188b2be3ca87ac1b73b34c41c1448882c7b53dc61447baae5f8dd71fc4c476a708b2591c7789447993e 34dc062a6850448ce179c5e3f3d2d7988ce40566658a3cd669d823bbc2d6cd6b 5a2ec1560f071332a65fd0a0ef6cd61eb2200057bf64dc17d2742ff2dda0e1fe 6e70351183e4197d411d0791c154331256cd3925aa89e028e4d833db7e2101cd 66411816748bb876c901e4068ecf889670d7c7e10f6e8de34a3f9657a78121e4 f4d73371bf0579ccad439b8e1ee44c39b1b77ce2e5c1552c530eadad831c32d3");

        return Response.Ok();
    } catch (Exception ex)
    {
        return Response.Fail();
    }               
});

var stepSecond = Step.Create("second", async context =>
{
    try
    {
        var response = await httpClient.GetAsync("/?password=ba22d8613cb210e03e49ca48f14bc090ca7bd6f17ab04aaad14ce8aff461d5f259f1fb0aec7d042077d94b6f5e24e2bf8dc50cfac614e96628ab15fef5a808fd55ff24c1b545eba2ea407db49c238811b0f59e2d43501cae6ddbfbcf20b86958328df52a90b2aee46b6bbeda548184de0f71acc7e4890155c4fb716e7ae22e41914f2b1efe6369fbdb7742a885da60db6cb83b7dfd6a794dad75f732d71d3850087c10e080f02c185e9c55e53d6c51c79020bf86bf7a05a82880a9d20d769c4acaa2fc7061511384e6b3b4bec974931ec094c8398b6e855ff4d980e188637272cac32ac5e732b4c7a0fc9f23e70eb1c00b7cb24deef530574f657eba62995782 4d7e6600e25ca960402f57c6de6c8b2bce6bf0463ef799c89d6e9a9ac1bddbb8 40f42db4d5a53bbb87c9f832fe156064782f92349788b806ce2d6a1df3c675b2");

        return Response.Ok();
    } catch (Exception ex)
    {
        return Response.Fail();
    }               
});

var scenarioFirst = ScenarioBuilder.CreateScenario("scenarioFirst", stepFirst);
var scenarioSecond = ScenarioBuilder.CreateScenario("scenarioSecond", stepSecond);

NBomberRunner
    .RegisterScenarios(scenarioFirst, scenarioSecond)
    .Run();
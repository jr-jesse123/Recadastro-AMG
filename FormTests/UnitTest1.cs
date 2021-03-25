using RecadastroAMG.Web.Pages;
using System;
using Xunit;
using Bunit;
using Index = RecadastroAMG.Web.Pages.Index;
using RecadastroAMG.Web;

namespace FormTests
{
    public class UnitTest1
    {
        [Fact]
        public void TesteSomenteNumeros()
        {
            var sit = "3df2adfe5";

            Assert.Equal( "325", sit.SomenteNumeros());
        }

        [Fact]
        public void Test1()
        {
            
            // Arrange: render the Counter.razor component
            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<Counter>();

            // Act: find and click the <button> element to increment
            // the counter in the <p> element
            cut.Find("button").Click();

            // Assert: first find the <p> element, then verify its content
            cut.Find("p").MarkupMatches("<p>Current count: 1</p>");
        }
    }
}

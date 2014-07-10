
[TestFixture]
public class WikiTest : FluentTest
{
        void GivenINavigatedGoodle()
        {
			 I.Open("http://google.com");
        }
 
        void WhenIEnterWikiIntoTheSearchbox()
        {
        	I.Enter("wiki").In("#gbqfq");
        }
 
        void ThenIShouldBeAbleToSeeWikiPage()
        {
			I.Wait(1);
        	I.Expect.Text("About").In("#resultStats");
        }

        [Test]
        public void Execute()
        {
        	this.BDDfy();
        }
 }

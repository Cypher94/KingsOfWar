using TechTalk.SpecFlow;

namespace KingsOfWar.Spec.Steps
{
    [Binding]
    public class HomePageSteps
    {
        #region Background
        [Given(@"I am on Home Page")]
        public void GivenIAmOnHomePage()
        {
            ScenarioContext.Current.Pending();
        }
        #endregion

        #region Home Page is displayed correctly
        [Then(@"I should see following elements displayed")]
        public void ThenIShouldSeeFollowingElementsDisplayed(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        #endregion

        #region Articles are displayed correctly
        [Then(@"I should see Articles with following elements displayed")]
        public void ThenIShouldSeeArticlesWithFollowingElementsDisplayed(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        #endregion
    }
}

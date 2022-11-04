namespace FatTree.UnitTests;

public class LinkTests
{
    [Fact]
    public void BuildNetwork_KIs4_ThereShouldBe36Links()
    {
        // Arrange
        byte k = 4;
        var expectedLinks = TestData.K4Links;

        // Act
        var dataCenter = new FatTreeDataCenter(k);
        var links = dataCenter.GetLinks().ToList();

        // Assert
        Assert.Equal(48, links.Count);
        foreach (var link in links)
        {
            Assert.Contains(expectedLinks, x =>
                (x.Node_1 == link.Node_1 || x.Node_1 == link.Node_2)
                &&
                (x.Node_2 == link.Node_1 || x.Node_2 == link.Node_2));
        }
    }
}
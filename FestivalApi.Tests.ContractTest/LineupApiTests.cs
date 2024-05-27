
namespace FestivalApi.Test.ContractTest;

public class LineupApiTests: IClassFixture<LineupApiFixture>{
    private readonly LineupApiFixture fixture;

    public LineupApiTests(LineupApiFixture fixture){
        this.fixture = fixture;
    }
    
    [Fact]
    public void GetLineupTest(){
        // Arrange
        var config = new PactVerifierConfig
    }
}
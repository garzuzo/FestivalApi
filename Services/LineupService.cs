using FestivalApi.Models;
namespace FestivalApi.Services;
public class LineupService : ILineupService
{
    public IEnumerable<Lineup> GetLineup()
    {
        return new List<Lineup>{
            new Lineup{
                Artist = new Artist{
                    Name = "Artist 1",
                    Description = "Description 1"
                },
                Stage = "Stage 1",
                Date = DateTime.Now.AddHours(1).,
            },
            new Lineup{
                Artist = new Artist{
                    Name = "Artist 2",
                    Description = "Description 2"
                },
                Stage = "Stage 2",
                Date = DateTime.Now.AddHours(2),
            }
        };
    }
}
public interface ILineupService
{
    IEnumerable<Lineup> GetLineup();
}
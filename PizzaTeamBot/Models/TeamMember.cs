
namespace PizzaTeamBot.Models
{
    public class TeamMemer
    {
        string Id;
        string Name;
        int NumberOfBeers;

        private TeamMemer()
        {

        }

        public TeamMemer(string id, string name, int beers)
        {
            this.Id = id;
            this.Name = name;
            this.NumberOfBeers = beers;
        }

    }
}
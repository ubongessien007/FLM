using FLM.DAL.EFCore.Mapping.Configurations;
using Microsoft.EntityFrameworkCore;

namespace FLM.DAL.EFCore.Mapping
{
	public class FlmEntityMapper : IEntityMapper
	{
		public void MapEntities(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new PlayerConfiguration());
			modelBuilder.ApplyConfiguration(new LeagueConfiguration());
			modelBuilder.ApplyConfiguration(new TeamConfiguration());
			modelBuilder.ApplyConfiguration(new MatchConfiguration());
			modelBuilder.ApplyConfiguration(new ScoreConfiguration());

			modelBuilder.ApplyConfiguration(new PlayerTeamAssignmentConfiguration());
			modelBuilder.ApplyConfiguration(new TeamLeagueAssignmentConfiguration());
			modelBuilder.ApplyConfiguration(new TeamTableStandingConfiguration());
		}
	}
}
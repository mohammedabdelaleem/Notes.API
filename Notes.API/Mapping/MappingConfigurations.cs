using Mapster;

namespace Notes.API.Mapping;

public class MappingConfigurations : IRegister
{
	public void Register(TypeAdapterConfig config)
	{
		// If property names don't match or you want to customize mapping:

		// add you configurations globally over the whole application
		// here i say map notes at destination with Description at source 
		// but if we are the same , here we don't need this 
		//config.NewConfig<Poll, PollResponse>()
		//.Map(dest => dest.Notes, src => src.Description);

	}
}

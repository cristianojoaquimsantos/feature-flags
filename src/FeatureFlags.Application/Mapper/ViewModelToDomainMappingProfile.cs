using AutoMapper;
using FeatureFlags.Application.ViewModel;
using FeatureFlags.Domain.Entities;

namespace FeatureFlags.Application.Mapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AmbienteViewModel, Ambiente>().ReverseMap();
            CreateMap<AmbienteFeatureFlagViewModel, AmbienteFeatureFlag>().ReverseMap();
            CreateMap<FeatureFlagViewModel, FeatureFlag>().ReverseMap();
            CreateMap<IntencaoFuncionalidadeViewModel, IntencaoFuncionalidade>().ReverseMap();
            CreateMap<IntencaoFuncionalidadeFeatureFlagViewModel, IntencaoFuncionalidadeFeatureFlag>().ReverseMap();
            CreateMap<SistemaViewModel, Sistema>().ReverseMap();
            CreateMap<UsuarioSistemaFeatureFlagViewModel, UsuarioSistemaFeatureFlag>().ReverseMap();
            CreateMap<UsuarioSistemaViewModel, UsuarioSistema>().ReverseMap();
        }
    }
}

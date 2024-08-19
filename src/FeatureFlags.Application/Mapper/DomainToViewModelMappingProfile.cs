using AutoMapper;
using FeatureFlags.Application.ViewModel;
using FeatureFlags.Domain.Entities;

namespace FeatureFlags.Application.Mapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Ambiente, AmbienteViewModel>().ReverseMap();
            CreateMap<AmbienteFeatureFlag, AmbienteFeatureFlagViewModel>().ReverseMap();
            CreateMap<FeatureFlag, FeatureFlagViewModel>().ReverseMap();
            CreateMap<IntencaoFuncionalidade, IntencaoFuncionalidadeViewModel>().ReverseMap();
            CreateMap<IntencaoFuncionalidadeFeatureFlag, IntencaoFuncionalidadeFeatureFlagViewModel>().ReverseMap();
            CreateMap<Sistema, SistemaViewModel>().ReverseMap();
            CreateMap<UsuarioSistemaFeatureFlag, UsuarioSistemaFeatureFlagViewModel>().ReverseMap();
            CreateMap<UsuarioSistema, UsuarioSistemaViewModel>().ReverseMap();
        }
    }
}

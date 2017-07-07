using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace LearningForAbp
{
    [DependsOn(typeof(LearningForAbpCoreModule), typeof(AbpAutoMapperModule))]
    public class LearningForAbpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                //Add your custom AutoMapper mappings here...
                //mapper.CreateMap<,>()
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

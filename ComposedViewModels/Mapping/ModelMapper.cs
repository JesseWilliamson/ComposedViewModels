using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ComposedViewModels.Models;
using ComposedViewModels.ViewModels;
using ComposedViewModels.ViewModels.Fields;

namespace ComposedViewModels.Mapping
{
    public class ModelMapper
    {
        public static void ConfigureMapper()
        {
            Mapper.CreateMap<PersonalInformationViewModel,Person>()
                .ConvertUsing(new ComposedModelConverter<PersonalInformationViewModel, Person>());
            Mapper.CreateMap<IPageField, Person>()
                .Include<NameInformation, Person>()
                .Include<DateOfBirthInformation, Person>()
                .Include<PhoneNumberInformation, Person>();
            Mapper.CreateMap<NameInformation, Person>();
            Mapper.CreateMap<DateOfBirthInformation, Person>();
            Mapper.CreateMap<PhoneNumberInformation, Person>();
        }
    }

    internal class ComposedModelConverter<TSource, TDestination> : ITypeConverter<TSource, TDestination> where TSource : IComposedModel where TDestination : new()
    {
        public TDestination Convert(ResolutionContext context)
        {
            var destinationObject = new TDestination();
            var sourceObject = (TSource) context.SourceValue;
            foreach (var field in sourceObject.Fields)
            {
                Mapper.Map(field, destinationObject);
            }
            return destinationObject;
        }
    }
}
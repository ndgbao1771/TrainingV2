﻿using AutoMapper;

namespace BookWareHouse.Service.AutoMappers
{
	public class AutoMapperConfig
	{
		public static MapperConfiguration RegisterMappings()
		{
			return new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new DomainToDTO());
				cfg.AddProfile(new DTOToDomain());
			});
		}
	}
}
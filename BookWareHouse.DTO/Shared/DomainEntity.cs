﻿namespace BookWareHouse.DTO.Shared
{
	public abstract class DomainEntity<T>
	{
		public T Id { get; set; }

		public bool IsTransient()
		{
			return Id.Equals(default(T));
		}
	}
}
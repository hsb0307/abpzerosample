﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace SimpleTaskSystem.People.Dtos
{
    public class GetAllPeopleOutput : IOutputDto
    {
        public List<PersonDto> People { get; set; }
    }
}
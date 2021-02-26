using AutoMapper;
using RestApiExample.Dtos;
using RestApiExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiExample.Profiles
{
    //Profile AutoMapper'den alındı
    public class CommandsProfile:Profile
    {
        public CommandsProfile()
        {
            //Source => Target
            CreateMap<Command, CommandReadDto>();

            //create işlemi için oluşturduk
            CreateMap<CommandCreateDto, Command>();

            //put(güncelleme) işlemi için oluşturduk
            CreateMap<CommandUpdateDto, Command>();

            //patch için tanımlandı
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}

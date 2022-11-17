﻿using Commander_Web_Api.Models;
using System.Collections;
using System.Collections.Generic;

namespace Commander_Web_Api.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();

        Command GetCommandById(int id);


    }
}

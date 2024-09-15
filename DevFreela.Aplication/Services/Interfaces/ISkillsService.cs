﻿using DevFreela.Aplication.InputModels;
using DevFreela.Aplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Aplication.Services.Interfaces
{
    public interface ISkillsService
    {
        List<SkillsViewModel> GetSkills();
        
    }
}

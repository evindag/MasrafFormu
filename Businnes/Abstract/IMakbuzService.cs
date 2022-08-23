﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstract
{
    public interface IMakbuzService
    {
        List<Makbuz> GetAll();
        Makbuz GetById(int id);
        IResult Add (Makbuz makbuz);
    }
}
﻿using BlogProject.Shared.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Entities.Concrete
{
    public class Role :IdentityRole<int>
    {
    }
}

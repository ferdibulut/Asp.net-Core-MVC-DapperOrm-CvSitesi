﻿using Entities.Abstract;
using Entities.Concrete.BaseEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Skills")]
    public class Skill : BaseEntity2, IEntity
    {
    }
}

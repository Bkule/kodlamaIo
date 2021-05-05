﻿using System;
using System.Collections.Generic;
using System.Text;
using Core;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        List<Rental> CheckCarReturn();
        List<RentalDetailDto> GetRentalDetails();
    }
}

﻿using HospitalLibrary.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary.Core.Repository
{
    public interface IBloodRequestRepository
    {
        IEnumerable<BloodRequest> GetAll();
        BloodRequest GetById(int id);
        void Create(BloodRequest bloodRequest);
        void Update(BloodRequest bloodRequest);
        void Delete(BloodRequest bloodRequest);
    }
}
